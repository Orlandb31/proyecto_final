Imports ModuloClientes
Public Class validaciones
    Public res As Boolean
    Public procedimiento As New Validar
    Public Function validar(ByVal nombre As String)
        res = procedimiento.validar_user(nombre)
        If res Then
            Return True
        Else
            Return False
        End If
    End Function
End Class