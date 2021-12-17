Imports ModuloClientes
Imports ModuloFacturacion
Public Class validaciones
    Public res As Boolean
    Public procedimiento As New ModuloClientes.Validar
    Public obj As New ModuloFacturacion.Validar
    Public Function validar_nombre_empresa(ByVal nombre As String)
        res = procedimiento.validar_name_empresa(nombre)
        If res Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function validar_cod_empresa(ByVal cod As String)
        res = procedimiento.validar_cod_empresa(cod)
        If res Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function validar_tablafacturas()
        Dim result As String = obj.validar_tablaFacturas_Vacia()
        If result = "tabla vacia" Then
            Return True
        ElseIf result = "tabla no vacia" Then
            Return False
        Else
            Return True
            MsgBox("error")
        End If
    End Function
End Class