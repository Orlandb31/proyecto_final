Imports System.Data.SqlClient
Imports ModuloClientes
Imports ModuloFacturacion
Imports Modulo_Conexion
Public Class validaciones
    Private conectar As New CAConexion
    Private con As New SQLConnection
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

    Public Function validar_Usuario(ByVal email As String)
        con = conectar.conexion()
        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        sqlQuery = "SELECT correo FROM usuarios where correo="
        sqlQuery &= "'" & email & "'"
        sqlDa = New SqlDataAdapter(sqlQuery, con)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                email = row("correo").ToString
            Next
            Return res = True
        Else
            Return res = False
        End If
        con.Close()
    End Function
End Class