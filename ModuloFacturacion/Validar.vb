Imports System.Data.SqlClient
Imports Modulo_Conexion
Public Class Validar
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Public Function validar_tablaFacturas_Vacia()
        con = conectar.conexion()
        Dim sqlDa As SqlDataAdapter
        Dim sqlQuery As String
        Dim resp As String
        sqlQuery = "IF EXISTS (SELECT * FROM Facturas) SELECT 'tabla no vacia' AS col1 ELSE SELECT 'tabla vacia' AS col1;"
        sqlDa = New SqlDataAdapter(sqlQuery, con)
        Dim dt = New DataTable
        sqlDa.Fill(dt)
        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
        resp = row("col1")
        Return resp
        con.Close()
    End Function
End Class
