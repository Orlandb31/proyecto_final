Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Login
    Private conectar As New CAConexion
    Private con As New SqlConnection


    Public Function user_login(email As String, pass As String)
        Dim respuesta As Integer
        Dim sqlDa As SqlDataAdapter
        Dim Glcommand As New SqlCommand
        Dim dtusers As New DataTable

        con = conectar.conexion()
        con.Open()

        Try

            Glcommand.Connection = con
            Glcommand.CommandText = "SP_LOGIN"
            Glcommand.Parameters.AddWithValue("@email", email)
            Glcommand.Parameters.AddWithValue("@pass", pass)
            Glcommand.CommandType = CommandType.StoredProcedure

            Glcommand.ExecuteNonQuery()
            sqlDa = New SqlDataAdapter(Glcommand)

            sqlDa.Fill(dtusers)
            If dtusers.Rows.Count > 0 Then
                Return dtusers
            Else
                Return dtusers
            End If


            con.Close()
            ''con.Close()

        Catch ex As Exception
            Return respuesta
        End Try

    End Function

    Public Function validarMail(email As String)
        Dim respuesta As Integer
        Dim sqlDa As SqlDataAdapter
        Dim Glcommand As New SqlCommand
        Dim dtusers As New DataTable

        con = conectar.conexion()
        con.Open()

        Try

            Glcommand.Connection = con
            Glcommand.CommandText = "SP_CHECK_MAIL"
            Glcommand.Parameters.AddWithValue("@email", email)
            Glcommand.CommandType = CommandType.StoredProcedure
            Glcommand.ExecuteNonQuery()
            sqlDa = New SqlDataAdapter(Glcommand)

            sqlDa.Fill(dtusers)
            If dtusers.Rows.Count > 0 Then
                Return dtusers
            Else
                Return dtusers
            End If


            con.Close()
            ''con.Close()

        Catch ex As Exception
            Return respuesta
        End Try
    End Function


    Public Function updatePassword(email As String, pass As String)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@email", email))
        command.Parameters.Add(New SqlParameter("@pass", pass))
        command.CommandText = "SP_Update_Pass"
            Return command
            con.Close()








    End Function

End Class
