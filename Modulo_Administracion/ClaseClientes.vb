Imports System.Data.SqlClient
Imports ModuloClientes
Public Class ClaseClientes
    Public sqlcom As SqlCommand
    Public procedimiento As New clientes
    Public Function agregar_nuevo_cliente(idcliente As Integer, nombre As String, ubicacion As String, email As String, telefono As String)
        sqlcom = procedimiento.agregar_cliente(idcliente, nombre, ubicacion, email, telefono)
        If sqlcom.ExecuteNonQuery() Then
            Return "Cliente Agregado Correctamente"
        Else
            Return "Error al Agregar"
        End If
    End Function
End Class