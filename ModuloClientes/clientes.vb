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

    Public Function Consultar_clientes(nombre As String)
        Dim Glcommand As New SqlCommand
        Dim dtclientes As New DataTable
        Dim sqlDa As SqlDataAdapter

        con = conectar.conexion()
        con.Open()

        Glcommand.Connection = con
        Glcommand.CommandText = "Mostrar_clientes"
        Glcommand.Parameters.AddWithValue("@nombre", nombre)
        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        Glcommand.ExecuteNonQuery()
        sqlDa = New SqlDataAdapter(Glcommand)

        sqlDa.Fill(dtclientes)
        Return dtclientes
        con.Close()
    End Function

    Public Function Con_cliente(id As Integer, nombre As String)
        Dim Glcommand As New SqlCommand
        Dim dtcuentas As New DataTable
        Dim sqlDa As SqlDataAdapter

        con = conectar.conexion()
        con.Open()

        Glcommand.Connection = con
        Glcommand.CommandText = "SP_Mostrar_Cliente"
        Glcommand.Parameters.AddWithValue("@id", id)
        Glcommand.Parameters.AddWithValue("@nombre", nombre)
        Glcommand.CommandTimeout = 0
        Glcommand.CommandType = CommandType.StoredProcedure

        Glcommand.ExecuteNonQuery()
        sqlDa = New SqlDataAdapter(Glcommand)

        sqlDa.Fill(dtcuentas)
        Return dtcuentas

    End Function

    Public Function Act_cliente(id As Integer, nombre As String, apellido As String, correo As String, tel As String)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id", id))
        command.Parameters.Add(New SqlParameter("@nombre", nombre))
        command.Parameters.Add(New SqlParameter("@apellido", apellido))
        command.Parameters.Add(New SqlParameter("@correo", correo))
        command.Parameters.Add(New SqlParameter("@telefono", tel))
        command.CommandText = "SP_Cliente_Update"
        Return command
        con.Close()

    End Function
End Class
