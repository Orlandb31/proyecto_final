Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Usuario
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Private command As SqlCommand = con.CreateCommand
    Public Function agregar_usuario(nombre As String, apellido As String, correo As String, contrasena As String, tipo As Integer)

        con = conectar.conexion()
            con.Open()
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@nombre", nombre))
            command.Parameters.Add(New SqlParameter("@apellido", apellido))
            command.Parameters.Add(New SqlParameter("@correo", correo))
            command.Parameters.Add(New SqlParameter("@contrasena", contrasena))
            command.Parameters.Add(New SqlParameter("@tipo", tipo))
            command.CommandText = "REGISTRAR_USUARIO"
            Return command
            con.Close()

        'Catch ex As Exception
        '    MsgBox("Error al realizar la insercion de los datos " + ex.Message)
        '    con.Close()
        'End Try
    End Function
End Class
