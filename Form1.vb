Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form1
    ' Cadena de conexión - Ajusta según tu configuración
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestionClientes;Integrated Security=True"
    Private clienteIdActual As Integer = 0
    Private modoEdicion As Boolean = False

    ' Clase para representar un Cliente
    Public Class Cliente
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Apellido As String
        Public Property Rut As String
        Public Property FechaNacimiento As Date
        Public Property Genero As String
        Public Property Direcciones As New List(Of String)
        Public Property Telefonos As New List(Of String)
        Public Property Correos As New List(Of String)
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar DateTimePicker
        dtpFechaNacimiento.MaxDate = DateTime.Today
        dtpFechaNacimiento.Value = DateTime.Today.AddYears(-18)

        ' Configurar ComboBox
        cmbGenero.SelectedIndex = -1
        cmbTipoTelefono.SelectedIndex = 0

        ' Configurar DataGridView
        ConfigurarDataGridView()

        ' Cargar datos
        CargarClientes()

        ' Estado inicial
        btnActualizar.Enabled = False
    End Sub

    Private Sub ConfigurarDataGridView()
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.Columns.Clear()

        ' Columna oculta para el ID
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "Id"
        colId.DataPropertyName = "Id"
        colId.Visible = False
        dgvClientes.Columns.Add(colId)

        ' Columnas visibles
        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.Name = "Nombre"
        colNombre.HeaderText = "Nombre"
        colNombre.DataPropertyName = "Nombre"
        dgvClientes.Columns.Add(colNombre)

        Dim colApellido As New DataGridViewTextBoxColumn()
        colApellido.Name = "Apellido"
        colApellido.HeaderText = "Apellido"
        colApellido.DataPropertyName = "Apellido"
        dgvClientes.Columns.Add(colApellido)

        Dim colRut As New DataGridViewTextBoxColumn()
        colRut.Name = "Rut"
        colRut.HeaderText = "RUT"
        colRut.DataPropertyName = "Rut"
        dgvClientes.Columns.Add(colRut)

        Dim colFecha As New DataGridViewTextBoxColumn()
        colFecha.Name = "FechaNacimiento"
        colFecha.HeaderText = "Fecha Nacimiento"
        colFecha.DataPropertyName = "FechaNacimiento"
        colFecha.DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvClientes.Columns.Add(colFecha)

        Dim colGenero As New DataGridViewTextBoxColumn()
        colGenero.Name = "Genero"
        colGenero.HeaderText = "Género"
        colGenero.DataPropertyName = "Genero"
        dgvClientes.Columns.Add(colGenero)
    End Sub

    Private Sub CargarClientes()
        Try
            Dim clientes As New List(Of Cliente)

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT * FROM Clientes ORDER BY Nombre", conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim cliente As New Cliente With {
                        .Id = Convert.ToInt32(reader("Id")),
                        .Nombre = reader("Nombre").ToString(),
                        .Apellido = reader("Apellido").ToString(),
                        .Rut = reader("Rut").ToString(),
                        .FechaNacimiento = Convert.ToDateTime(reader("FechaNacimiento")),
                        .Genero = reader("Genero").ToString()
                    }
                    clientes.Add(cliente)
                End While
            End Using

            dgvClientes.DataSource = clientes
            lblTotal.Text = $"Total Clientes: {clientes.Count}"

        Catch ex As Exception
            MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Return

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As New SqlCommand("INSERT INTO Clientes (Nombre, Apellido, Rut, FechaNacimiento, Genero) VALUES (@Nombre, @Apellido, @Rut, @Fecha, @Genero); SELECT SCOPE_IDENTITY();", conn)

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                cmd.Parameters.AddWithValue("@Rut", txtRut.Text.Trim())
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaNacimiento.Value)
                cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text)

                Dim nuevoId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Guardar direcciones, teléfonos y correos
                GuardarDatosAdicionales(conn, nuevoId)
            End Using

            MessageBox.Show("Cliente guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormulario()
            CargarClientes()

        Catch ex As Exception
            MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GuardarDatosAdicionales(conn As SqlConnection, clienteId As Integer)
        ' Guardar direcciones
        For Each item As String In lstDirecciones.Items
            Dim cmd As New SqlCommand("INSERT INTO Direcciones (ClienteId, Direccion, Ciudad) VALUES (@ClienteId, @Direccion, @Ciudad)", conn)
            Dim partes() As String = item.Split(New String() {" - "}, StringSplitOptions.None)
            cmd.Parameters.AddWithValue("@ClienteId", clienteId)
            cmd.Parameters.AddWithValue("@Direccion", partes(0))
            cmd.Parameters.AddWithValue("@Ciudad", If(partes.Length > 1, partes(1), ""))
            cmd.ExecuteNonQuery()
        Next

        ' Guardar teléfonos
        For Each item As String In lstTelefonos.Items
            Dim cmd As New SqlCommand("INSERT INTO Telefonos (ClienteId, Numero, Tipo) VALUES (@ClienteId, @Numero, @Tipo)", conn)
            Dim partes() As String = item.Split(New String() {" - "}, StringSplitOptions.None)
            cmd.Parameters.AddWithValue("@ClienteId", clienteId)
            cmd.Parameters.AddWithValue("@Numero", partes(0))
            cmd.Parameters.AddWithValue("@Tipo", If(partes.Length > 1, partes(1), ""))
            cmd.ExecuteNonQuery()
        Next

        ' Guardar correos
        For Each correo As String In lstCorreos.Items
            Dim cmd As New SqlCommand("INSERT INTO Correos (ClienteId, Correo) VALUES (@ClienteId, @Correo)", conn)
            cmd.Parameters.AddWithValue("@ClienteId", clienteId)
            cmd.Parameters.AddWithValue("@Correo", correo)
            cmd.ExecuteNonQuery()
        Next
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If clienteIdActual = 0 Then
            MessageBox.Show("Debe seleccionar un cliente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not ValidarCampos() Then Return

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Actualizar cliente
                Dim cmd As New SqlCommand("UPDATE Clientes SET Nombre=@Nombre, Apellido=@Apellido, Rut=@Rut, FechaNacimiento=@Fecha, Genero=@Genero WHERE Id=@Id", conn)
                cmd.Parameters.AddWithValue("@Id", clienteIdActual)
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim())
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text.Trim())
                cmd.Parameters.AddWithValue("@Rut", txtRut.Text.Trim())
                cmd.Parameters.AddWithValue("@Fecha", dtpFechaNacimiento.Value)
                cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text)
                cmd.ExecuteNonQuery()

                ' Eliminar datos adicionales antiguos
                EliminarDatosAdicionales(conn, clienteIdActual)

                ' Guardar nuevos datos adicionales
                GuardarDatosAdicionales(conn, clienteIdActual)
            End Using

            MessageBox.Show("Cliente actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormulario()
            CargarClientes()

        Catch ex As Exception
            MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarDatosAdicionales(conn As SqlConnection, clienteId As Integer)
        Dim cmd1 As New SqlCommand("DELETE FROM Direcciones WHERE ClienteId=@Id", conn)
        cmd1.Parameters.AddWithValue("@Id", clienteId)
        cmd1.ExecuteNonQuery()

        Dim cmd2 As New SqlCommand("DELETE FROM Telefonos WHERE ClienteId=@Id", conn)
        cmd2.Parameters.AddWithValue("@Id", clienteId)
        cmd2.ExecuteNonQuery()

        Dim cmd3 As New SqlCommand("DELETE FROM Correos WHERE ClienteId=@Id", conn)
        cmd3.Parameters.AddWithValue("@Id", clienteId)
        cmd3.ExecuteNonQuery()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If dgvClientes.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un cliente de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Try
            Dim clienteId As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("Id").Value)

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Eliminar datos adicionales
                EliminarDatosAdicionales(conn, clienteId)

                ' Eliminar cliente
                Dim cmd As New SqlCommand("DELETE FROM Clientes WHERE Id=@Id", conn)
                cmd.Parameters.AddWithValue("@Id", clienteId)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Cliente eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormulario()
            CargarClientes()

        Catch ex As Exception
            MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If e.RowIndex < 0 Then Return

        Try
            clienteIdActual = Convert.ToInt32(dgvClientes.Rows(e.RowIndex).Cells("Id").Value)

            ' Cargar datos del cliente
            txtNombre.Text = dgvClientes.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            txtApellido.Text = dgvClientes.Rows(e.RowIndex).Cells("Apellido").Value.ToString()
            txtRut.Text = dgvClientes.Rows(e.RowIndex).Cells("Rut").Value.ToString()
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvClientes.Rows(e.RowIndex).Cells("FechaNacimiento").Value)
            cmbGenero.Text = dgvClientes.Rows(e.RowIndex).Cells("Genero").Value.ToString()

            ' Cargar datos adicionales
            CargarDatosAdicionales(clienteIdActual)

            modoEdicion = True
            btnActualizar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception
            MessageBox.Show($"Error al cargar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDatosAdicionales(clienteId As Integer)
        lstDirecciones.Items.Clear()
        lstTelefonos.Items.Clear()
        lstCorreos.Items.Clear()

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Cargar direcciones
                Dim cmd1 As New SqlCommand("SELECT * FROM Direcciones WHERE ClienteId=@Id", conn)
                cmd1.Parameters.AddWithValue("@Id", clienteId)
                Dim reader1 As SqlDataReader = cmd1.ExecuteReader()
                While reader1.Read()
                    lstDirecciones.Items.Add($"{reader1("Direccion")} - {reader1("Ciudad")}")
                End While
                reader1.Close()

                ' Cargar teléfonos
                Dim cmd2 As New SqlCommand("SELECT * FROM Telefonos WHERE ClienteId=@Id", conn)
                cmd2.Parameters.AddWithValue("@Id", clienteId)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
                While reader2.Read()
                    lstTelefonos.Items.Add($"{reader2("Numero")} - {reader2("Tipo")}")
                End While
                reader2.Close()

                ' Cargar correos
                Dim cmd3 As New SqlCommand("SELECT * FROM Correos WHERE ClienteId=@Id", conn)
                cmd3.Parameters.AddWithValue("@Id", clienteId)
                Dim reader3 As SqlDataReader = cmd3.ExecuteReader()
                While reader3.Read()
                    lstCorreos.Items.Add(reader3("Correo").ToString())
                End While
                reader3.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error al cargar datos adicionales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub LimpiarFormulario()
        txtNombre.Clear()
        txtApellido.Clear()
        txtRut.Clear()
        dtpFechaNacimiento.Value = DateTime.Today.AddYears(-18)
        cmbGenero.SelectedIndex = -1

        txtDireccion.Clear()
        txtCiudad.Clear()
        txtTelefono.Clear()
        cmbTipoTelefono.SelectedIndex = 0
        txtCorreo.Clear()

        lstDirecciones.Items.Clear()
        lstTelefonos.Items.Clear()
        lstCorreos.Items.Clear()

        clienteIdActual = 0
        modoEdicion = False
        btnActualizar.Enabled = False
        btnGuardar.Enabled = True

        txtNombre.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtApellido.Text) Then
            MessageBox.Show("El apellido es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApellido.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("El RUT es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRut.Focus()
            Return False
        End If

        If cmbGenero.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un género", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbGenero.Focus()
            Return False
        End If

        Return True
    End Function

    ' Eventos para agregar direcciones, teléfonos y correos
    Private Sub btnAgregarDireccion_Click(sender As Object, e As EventArgs) Handles btnAgregarDireccion.Click
        If String.IsNullOrWhiteSpace(txtDireccion.Text) Or String.IsNullOrWhiteSpace(txtCiudad.Text) Then
            MessageBox.Show("Complete todos los campos de dirección", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lstDirecciones.Items.Add($"{txtDireccion.Text.Trim()} - {txtCiudad.Text.Trim()}")
        txtDireccion.Clear()
        txtCiudad.Clear()
        txtDireccion.Focus()
    End Sub

    Private Sub btnAgregarTelefono_Click(sender As Object, e As EventArgs) Handles btnAgregarTelefono.Click
        If String.IsNullOrWhiteSpace(txtTelefono.Text.Replace("+", "").Replace(" ", "")) Then
            MessageBox.Show("Ingrese un número de teléfono", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbTipoTelefono.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el tipo de teléfono", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lstTelefonos.Items.Add($"{txtTelefono.Text.Trim()} - {cmbTipoTelefono.Text}")
        txtTelefono.Clear()
        cmbTipoTelefono.SelectedIndex = 0
        txtTelefono.Focus()
    End Sub

    Private Sub btnAgregarCorreo_Click(sender As Object, e As EventArgs) Handles btnAgregarCorreo.Click
        If String.IsNullOrWhiteSpace(txtCorreo.Text) Then
            MessageBox.Show("Ingrese un correo electrónico", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not ValidarCorreo(txtCorreo.Text) Then
            MessageBox.Show("El formato del correo no es válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lstCorreos.Items.Add(txtCorreo.Text.Trim())
        txtCorreo.Clear()
        txtCorreo.Focus()
    End Sub

    Private Function ValidarCorreo(correo As String) As Boolean
        Dim patron As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(correo, patron)
    End Function

    ' Eventos para eliminar items de las listas
    Private Sub btnEliminarDireccion_Click(sender As Object, e As EventArgs) Handles btnEliminarDireccion.Click
        If lstDirecciones.SelectedIndex >= 0 Then
            lstDirecciones.Items.RemoveAt(lstDirecciones.SelectedIndex)
        Else
            MessageBox.Show("Seleccione una dirección para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminarTelefono_Click(sender As Object, e As EventArgs) Handles btnEliminarTelefono.Click
        If lstTelefonos.SelectedIndex >= 0 Then
            lstTelefonos.Items.RemoveAt(lstTelefonos.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un teléfono para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminarCorreo_Click(sender As Object, e As EventArgs) Handles btnEliminarCorreo.Click
        If lstCorreos.SelectedIndex >= 0 Then
            lstCorreos.Items.RemoveAt(lstCorreos.SelectedIndex)
        Else
            MessageBox.Show("Seleccione un correo para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Búsqueda en tiempo real
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim filtro As String = txtBuscar.Text.Trim().ToLower()

        If String.IsNullOrEmpty(filtro) Then
            CargarClientes()
            Return
        End If

        Try
            Dim clientes As New List(Of Cliente)

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT * FROM Clientes WHERE LOWER(Nombre) LIKE @Filtro OR LOWER(Apellido) LIKE @Filtro OR LOWER(Rut) LIKE @Filtro ORDER BY Nombre", conn)
                cmd.Parameters.AddWithValue("@Filtro", $"%{filtro}%")

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim cliente As New Cliente With {
                        .Id = Convert.ToInt32(reader("Id")),
                        .Nombre = reader("Nombre").ToString(),
                        .Apellido = reader("Apellido").ToString(),
                        .Rut = reader("Rut").ToString(),
                        .FechaNacimiento = Convert.ToDateTime(reader("FechaNacimiento")),
                        .Genero = reader("Genero").ToString()
                    }
                    clientes.Add(cliente)
                End While
            End Using

            dgvClientes.DataSource = clientes
            lblTotal.Text = $"Total Clientes: {clientes.Count}"

        Catch ex As Exception
            MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validación del RUT chileno
    Private Sub txtRut_Leave(sender As Object, e As EventArgs) Handles txtRut.Leave
        If Not String.IsNullOrWhiteSpace(txtRut.Text) Then
            txtRut.Text = FormatearRut(txtRut.Text)
        End If
    End Sub

    Private Function FormatearRut(rut As String) As String
        ' Eliminar puntos y guiones
        rut = rut.Replace(".", "").Replace("-", "").Trim().ToUpper()

        If rut.Length < 2 Then Return rut

        ' Separar dígito verificador
        Dim cuerpo As String = rut.Substring(0, rut.Length - 1)
        Dim dv As String = rut.Substring(rut.Length - 1)

        ' Formatear con puntos
        Dim rutFormateado As String = ""
        Dim contador As Integer = 0

        For i As Integer = cuerpo.Length - 1 To 0 Step -1
            rutFormateado = cuerpo(i) & rutFormateado
            contador += 1
            If contador = 3 AndAlso i > 0 Then
                rutFormateado = "." & rutFormateado
                contador = 0
            End If
        Next

        Return rutFormateado & "-" & dv
    End Function

    ' Permitir solo letras en nombre y apellido
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub


End Class