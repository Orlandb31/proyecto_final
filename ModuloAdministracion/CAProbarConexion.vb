Public Class CAProbarConexion
    Private conectar As New CAConexion

    Public Function verificarconexion() As Boolean
        Dim respuestas As Boolean
        Try
            conectar.conexion.Open()
            respuestas = True
        Catch ex As Exception
            respuestas = False
        Finally
            If conectar.conexion.State <> ConnectionState.Closed Then conectar.conexion.Close()
        End Try
        Return respuestas
    End Function

End Class
