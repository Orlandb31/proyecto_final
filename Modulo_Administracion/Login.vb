Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Login
    Private conectar As New CAConexion
    Private con As New SqlConnection


    Public Function user_login(email As String, pass As String)
        Dim respuesta As Integer

        Try

            con = conectar.conexion()
            Dim cm = New SqlCommand("SP_LOGIN", con)
            con.Open()
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@email", email)
                .Parameters.AddWithValue("@pass", pass)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()
                If CInt(.Parameters("@result").Value = 1) Then
                    Console.WriteLine("EXITOOO")
                    respuesta = 1
                    Return respuesta
                Else
                    respuesta = 0
                    Return respuesta
                End If
            End With
            ''con.Close()

        Catch ex As Exception
            Return respuesta
        End Try


        'Dim command As SqlCommand = con.CreateCommand
        'con.Open()
        'command
        'command.Parameters.Add(New SqlParameter("@email", email))
        'command.Parameters.Add(New SqlParameter("@pass", pass))
        'command.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

        'Return command.ExecuteScalar()


    End Function

End Class
