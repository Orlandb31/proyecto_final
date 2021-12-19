Imports ModuloInventario
Imports System.Data.SqlClient
Public Class CLogica

    Public sqlcom As SqlCommand
    Public procedimiento As New CrearProducto
    Public Produsuario As New Usuario
    Public Function Ingresarproducto(nombre As String, precio As Double, cantidad As Integer, Descripcion As String)
        sqlcom = procedimiento.insertarproducto(nombre, precio, cantidad, Descripcion)
        If sqlcom.ExecuteNonQuery() Then
            Return "Producto Insertado"
        Else
            Return "Error de Insersion"
        End If
    End Function

    Public Function IngresarUsuarios(nombre As String, apellido As String, correo As String, contrasena As String, tipo As Integer)
        sqlcom = Produsuario.agregar_usuario(nombre, apellido, correo, contrasena, tipo)
        If sqlcom.ExecuteNonQuery() Then
            Return "Producto Insertado"
        Else
            Return "Error de Insersion"
        End If
    End Function

End Class