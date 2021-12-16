Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Validar
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Public Function validar_user(ByVal nombre As String)
        con = conectar.conexion()
        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        sqlQuery = "Select id_cliente from tlb_datoscliente where id_cliente ="
        sqlQuery &= "'" & nombre & "'"
        sqlDa = New SqlDataAdapter(sqlQuery, con)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                nombre = row("id_cliente").ToString
            Next
            Return True
        Else Return False

        End If

    End Function
End Class