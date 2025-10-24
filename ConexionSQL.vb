Imports System.Data.SqlClient

Module ConexionSQL
    Public conexion As SqlConnection

    Public Sub Conectar()
        conexion = New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestionClientes;Integrated Security=True")
        conexion.Open()
    End Sub
End Module
