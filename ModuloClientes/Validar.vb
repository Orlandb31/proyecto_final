Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Validar
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Public Function validar_name_empresa(ByVal nombre As String)
        con = conectar.conexion()
        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        sqlQuery = "SELECT nombre FROM Clientes where nombre="
        sqlQuery &= "'" & nombre & "'"
        sqlDa = New SqlDataAdapter(sqlQuery, con)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                nombre = row("nombre").ToString
            Next
            Return True
        Else
            Return False
        End If
        con.Close()
    End Function
    Public Function validar_cod_empresa(ByVal codigo As String)
        con = conectar.conexion()
        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        sqlQuery = "SELECT id_cliente FROM Clientes where id_cliente="
        sqlQuery &= "'" & codigo & "'"
        sqlDa = New SqlDataAdapter(sqlQuery, con)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                codigo = row("id_cliente").ToString
            Next
            Return True
        Else
            Return False
        End If
        con.Close()
    End Function
End Class