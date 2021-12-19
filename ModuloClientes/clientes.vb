Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class clientes
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Public Function agregar_cliente(idcliente As Integer, nombre As String, ubicacion As String, email As String, telefono As String)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@idcliente", idcliente))
        command.Parameters.Add(New SqlParameter("@nombre", nombre))
        command.Parameters.Add(New SqlParameter("@ubicacion", ubicacion))
        command.Parameters.Add(New SqlParameter("@telefono", telefono))
        command.Parameters.Add(New SqlParameter("@email", email))
        command.CommandText = "SP_InsertarCliente"
        Return command
        con.Close()
    End Function

    Public Function Consultar_cliente(nombre As Integer)
        Dim Glcommand As New SqlCommand
        Dim dtcuentas As New DataTable
        Dim sqlDa As SqlDataAdapter

        Glcommand.Connection = conectar.conexion()
        Glcommand.CommandText = "Mostrar_clientes"
        Glcommand.Parameters.AddWithValue("@nombre", nombre)
        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        conectar.conexion.Open()
        Glcommand.ExecuteNonQuery()
        sqlDa = New SqlDataAdapter(Glcommand)

        sqlDa.Fill(dtcuentas)
        Return dtcuentas
    End Function
End Class
