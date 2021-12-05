Imports System.Data.SqlClient
Imports ModuloAdministracion


Public Class CrearProducto
    Private conectar As New CAConexion
    Private con As New SqlConnection


    Public Function insertarproducto(nombre As String, precio As Double, cantidad As Integer, descripcion As String)
        con = conectar.conexion()

        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@nombre", nombre))
        command.Parameters.Add(New SqlParameter("@precio", precio))
        command.Parameters.Add(New SqlParameter("@cantidad_disponible", cantidad))
        command.Parameters.Add(New SqlParameter("@descripcion", descripcion))
        command.CommandText = "REGISTRAR_PRODUCTO"
        Return command
        con.Close()
    End Function

End Class
