<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tabDatos = New System.Windows.Forms.TabControl()
        Me.tabDirecciones = New System.Windows.Forms.TabPage()
        Me.btnEliminarDireccion = New System.Windows.Forms.Button()
        Me.lstDirecciones = New System.Windows.Forms.ListBox()
        Me.btnAgregarDireccion = New System.Windows.Forms.Button()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabTelefonos = New System.Windows.Forms.TabPage()
        Me.btnEliminarTelefono = New System.Windows.Forms.Button()
        Me.lstTelefonos = New System.Windows.Forms.ListBox()
        Me.btnAgregarTelefono = New System.Windows.Forms.Button()
        Me.cmbTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabCorreos = New System.Windows.Forms.TabPage()
        Me.btnEliminarCorreo = New System.Windows.Forms.Button()
        Me.lstCorreos = New System.Windows.Forms.ListBox()
        Me.btnAgregarCorreo = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.tabDirecciones.SuspendLayout()
        Me.tabTelefonos.SuspendLayout()
        Me.tabCorreos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbGenero)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRut)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(110, 140)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(150, 20)
        Me.dtpFechaNacimiento.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(15, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Nacimiento:"
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro", "Prefiero no decir"})
        Me.cmbGenero.Location = New System.Drawing.Point(110, 177)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(150, 21)
        Me.cmbGenero.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(15, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Género:"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtRut.Location = New System.Drawing.Point(110, 103)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(150, 20)
        Me.txtRut.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RUT:"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtApellido.Location = New System.Drawing.Point(110, 66)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(150, 20)
        Me.txtApellido.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(15, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNombre.Location = New System.Drawing.Point(110, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(12, 245)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(202, 245)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(90, 32)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(107, 245)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(90, 32)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar "
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(10, 75)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(970, 220)
        Me.dgvClientes.TabIndex = 8
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.tabDirecciones)
        Me.tabDatos.Controls.Add(Me.tabTelefonos)
        Me.tabDatos.Controls.Add(Me.tabCorreos)
        Me.tabDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tabDatos.Location = New System.Drawing.Point(298, 12)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectedIndex = 0
        Me.tabDatos.Size = New System.Drawing.Size(694, 265)
        Me.tabDatos.TabIndex = 9
        '
        'tabDirecciones
        '
        Me.tabDirecciones.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabDirecciones.Controls.Add(Me.btnEliminarDireccion)
        Me.tabDirecciones.Controls.Add(Me.lstDirecciones)
        Me.tabDirecciones.Controls.Add(Me.btnAgregarDireccion)
        Me.tabDirecciones.Controls.Add(Me.txtCiudad)
        Me.tabDirecciones.Controls.Add(Me.Label6)
        Me.tabDirecciones.Controls.Add(Me.txtDireccion)
        Me.tabDirecciones.Controls.Add(Me.Label5)
        Me.tabDirecciones.Location = New System.Drawing.Point(4, 24)
        Me.tabDirecciones.Name = "tabDirecciones"
        Me.tabDirecciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDirecciones.Size = New System.Drawing.Size(686, 237)
        Me.tabDirecciones.TabIndex = 0
        Me.tabDirecciones.Text = "Direcciones"
        '
        'btnEliminarDireccion
        '
        Me.btnEliminarDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEliminarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarDireccion.ForeColor = System.Drawing.Color.White
        Me.btnEliminarDireccion.Location = New System.Drawing.Point(100, 150)
        Me.btnEliminarDireccion.Name = "btnEliminarDireccion"
        Me.btnEliminarDireccion.Size = New System.Drawing.Size(200, 28)
        Me.btnEliminarDireccion.TabIndex = 6
        Me.btnEliminarDireccion.Text = "❌ Eliminar Seleccionada"
        Me.btnEliminarDireccion.UseVisualStyleBackColor = False
        '
        'lstDirecciones
        '
        Me.lstDirecciones.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.lstDirecciones.FormattingEnabled = True
        Me.lstDirecciones.Location = New System.Drawing.Point(330, 20)
        Me.lstDirecciones.Name = "lstDirecciones"
        Me.lstDirecciones.Size = New System.Drawing.Size(340, 199)
        Me.lstDirecciones.TabIndex = 5
        '
        'btnAgregarDireccion
        '
        Me.btnAgregarDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarDireccion.ForeColor = System.Drawing.Color.White
        Me.btnAgregarDireccion.Location = New System.Drawing.Point(100, 115)
        Me.btnAgregarDireccion.Name = "btnAgregarDireccion"
        Me.btnAgregarDireccion.Size = New System.Drawing.Size(200, 28)
        Me.btnAgregarDireccion.TabIndex = 4
        Me.btnAgregarDireccion.Text = "➕ Agregar Dirección"
        Me.btnAgregarDireccion.UseVisualStyleBackColor = False
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCiudad.Location = New System.Drawing.Point(100, 70)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(200, 21)
        Me.txtCiudad.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(20, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Comuna:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(100, 30)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(200, 21)
        Me.txtDireccion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(20, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dirección:"
        '
        'tabTelefonos
        '
        Me.tabTelefonos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabTelefonos.Controls.Add(Me.btnEliminarTelefono)
        Me.tabTelefonos.Controls.Add(Me.lstTelefonos)
        Me.tabTelefonos.Controls.Add(Me.btnAgregarTelefono)
        Me.tabTelefonos.Controls.Add(Me.cmbTipoTelefono)
        Me.tabTelefonos.Controls.Add(Me.Label10)
        Me.tabTelefonos.Controls.Add(Me.txtTelefono)
        Me.tabTelefonos.Controls.Add(Me.Label7)
        Me.tabTelefonos.Location = New System.Drawing.Point(4, 24)
        Me.tabTelefonos.Name = "tabTelefonos"
        Me.tabTelefonos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTelefonos.Size = New System.Drawing.Size(686, 237)
        Me.tabTelefonos.TabIndex = 1
        Me.tabTelefonos.Text = " Teléfonos"
        '
        'btnEliminarTelefono
        '
        Me.btnEliminarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEliminarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarTelefono.ForeColor = System.Drawing.Color.White
        Me.btnEliminarTelefono.Location = New System.Drawing.Point(100, 150)
        Me.btnEliminarTelefono.Name = "btnEliminarTelefono"
        Me.btnEliminarTelefono.Size = New System.Drawing.Size(200, 28)
        Me.btnEliminarTelefono.TabIndex = 12
        Me.btnEliminarTelefono.Text = "❌ Eliminar Seleccionado"
        Me.btnEliminarTelefono.UseVisualStyleBackColor = False
        '
        'lstTelefonos
        '
        Me.lstTelefonos.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.lstTelefonos.FormattingEnabled = True
        Me.lstTelefonos.Location = New System.Drawing.Point(330, 20)
        Me.lstTelefonos.Name = "lstTelefonos"
        Me.lstTelefonos.Size = New System.Drawing.Size(340, 199)
        Me.lstTelefonos.TabIndex = 11
        '
        'btnAgregarTelefono
        '
        Me.btnAgregarTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarTelefono.ForeColor = System.Drawing.Color.White
        Me.btnAgregarTelefono.Location = New System.Drawing.Point(100, 115)
        Me.btnAgregarTelefono.Name = "btnAgregarTelefono"
        Me.btnAgregarTelefono.Size = New System.Drawing.Size(200, 28)
        Me.btnAgregarTelefono.TabIndex = 10
        Me.btnAgregarTelefono.Text = "➕ Agregar Teléfono"
        Me.btnAgregarTelefono.UseVisualStyleBackColor = False
        '
        'cmbTipoTelefono
        '
        Me.cmbTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cmbTipoTelefono.FormattingEnabled = True
        Me.cmbTipoTelefono.Items.AddRange(New Object() {"Móvil", "Casa", "Trabajo", "Otro"})
        Me.cmbTipoTelefono.Location = New System.Drawing.Point(100, 70)
        Me.cmbTipoTelefono.Name = "cmbTipoTelefono"
        Me.cmbTipoTelefono.Size = New System.Drawing.Size(200, 23)
        Me.cmbTipoTelefono.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(20, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tipo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(100, 30)
        Me.txtTelefono.Mask = "+00 000000000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(200, 21)
        Me.txtTelefono.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(20, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Teléfono:"
        '
        'tabCorreos
        '
        Me.tabCorreos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabCorreos.Controls.Add(Me.btnEliminarCorreo)
        Me.tabCorreos.Controls.Add(Me.lstCorreos)
        Me.tabCorreos.Controls.Add(Me.btnAgregarCorreo)
        Me.tabCorreos.Controls.Add(Me.txtCorreo)
        Me.tabCorreos.Controls.Add(Me.Label9)
        Me.tabCorreos.Location = New System.Drawing.Point(4, 24)
        Me.tabCorreos.Name = "tabCorreos"
        Me.tabCorreos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCorreos.Size = New System.Drawing.Size(686, 237)
        Me.tabCorreos.TabIndex = 2
        Me.tabCorreos.Text = " Correos"
        '
        'btnEliminarCorreo
        '
        Me.btnEliminarCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEliminarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCorreo.Location = New System.Drawing.Point(100, 110)
        Me.btnEliminarCorreo.Name = "btnEliminarCorreo"
        Me.btnEliminarCorreo.Size = New System.Drawing.Size(200, 28)
        Me.btnEliminarCorreo.TabIndex = 8
        Me.btnEliminarCorreo.Text = "❌ Eliminar Seleccionado"
        Me.btnEliminarCorreo.UseVisualStyleBackColor = False
        '
        'lstCorreos
        '
        Me.lstCorreos.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.lstCorreos.FormattingEnabled = True
        Me.lstCorreos.Location = New System.Drawing.Point(323, 18)
        Me.lstCorreos.Name = "lstCorreos"
        Me.lstCorreos.Size = New System.Drawing.Size(340, 199)
        Me.lstCorreos.TabIndex = 7
        '
        'btnAgregarCorreo
        '
        Me.btnAgregarCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAgregarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarCorreo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCorreo.Location = New System.Drawing.Point(100, 75)
        Me.btnAgregarCorreo.Name = "btnAgregarCorreo"
        Me.btnAgregarCorreo.Size = New System.Drawing.Size(200, 28)
        Me.btnAgregarCorreo.TabIndex = 6
        Me.btnAgregarCorreo.Text = "➕ Agregar Correo"
        Me.btnAgregarCorreo.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCorreo.Location = New System.Drawing.Point(100, 30)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(200, 21)
        Me.txtCorreo.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(20, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Correo:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(784, 301)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(196, 32)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = " ELIMINAR CLIENTE"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dgvClientes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(990, 310)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Clientes"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(10, 295)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 13)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total Clientes: 0"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(70, 35)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(250, 20)
        Me.txtBuscar.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(10, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Filtro Buscar:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 605)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1014, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 627)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.tabDatos)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tabDirecciones.ResumeLayout(False)
        Me.tabDirecciones.PerformLayout()
        Me.tabTelefonos.ResumeLayout(False)
        Me.tabTelefonos.PerformLayout()
        Me.tabCorreos.ResumeLayout(False)
        Me.tabCorreos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents tabDatos As TabControl
    Friend WithEvents tabDirecciones As TabPage
    Friend WithEvents tabTelefonos As TabPage
    Friend WithEvents tabCorreos As TabPage
    Friend WithEvents lstDirecciones As ListBox
    Friend WithEvents btnAgregarDireccion As Button
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstTelefonos As ListBox
    Friend WithEvents btnAgregarTelefono As Button
    Friend WithEvents txtTelefono As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lstCorreos As ListBox
    Friend WithEvents btnAgregarCorreo As Button
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cmbTipoTelefono As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEliminarDireccion As Button
    Friend WithEvents btnEliminarTelefono As Button
    Friend WithEvents btnEliminarCorreo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class