Imports ModuloAdministracion
Public Class CCProbarConexion

    Dim moduloadmi As New CAProbarConexion

    Public Function VerificarConexion() As Boolean
        Return moduloadmi.verificarconexion
    End Function

End Class
