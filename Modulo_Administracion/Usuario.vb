Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Usuario
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Private command As SqlCommand = con.CreateCommand
    Public Function agregar_usuario(nombre As String, apellido As String, correo As String, contrasena As String, tipo As Integer)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@nombre", nombre))
        command.Parameters.Add(New SqlParameter("@apellido", apellido))
        command.Parameters.Add(New SqlParameter("@email", correo))
        command.Parameters.Add(New SqlParameter("@contrasena", contrasena))
        command.Parameters.Add(New SqlParameter("@perfil_usuario", tipo))
        command.CommandText = "REGISTRAR_USUARIO"
        Return command
        con.Close()
    End Function
End Class
