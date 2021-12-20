Imports ModuloInventario
Imports ModuloClientes
Imports System.Data.SqlClient
Public Class CLogica
    Public LoginUser As New Login
    Public Produsuario As New Usuario
    Public sqlcom As SqlCommand
    Public procedimiento As New CrearProducto
    Public upCliente As New clientes
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
            Return "Usuario Insertado con exito"
        Else
            Return "Error en la Insercion del Usuario"
        End If
    End Function

    Public Function LoginUsuarios(email As String, pass As String)


        If LoginUser.user_login(email, pass) = 1 Then
            Return 1
        Else
            Return 0
        End If

    End Function

    Public Function actualizar_cliente(id As Integer, nombre As String, apellido As String, email As String, telefono As String)
        sqlcom = upCliente.Act_cliente(id, nombre, apellido, email, telefono)
        If sqlcom.ExecuteNonQuery() Then
            Return "Cliente Actualizado Correctamente"
        Else
            Return "Error al Actualizar"
        End If
    End Function

End Class