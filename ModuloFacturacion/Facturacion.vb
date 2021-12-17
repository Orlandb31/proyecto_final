Imports Modulo_Conexion
Imports System.Data.SqlClient
Public Class Facturacion
    Private conectar As New CAConexion
    Private con As New SqlConnection
    Public Function combo_box_clientes()
        con = conectar.conexion()
        Dim Sqlda As SqlDataAdapter
        Dim dtclientes As DataTable = New DataTable
        Dim sqlQuery As String = "SELECT id_cliente,nombre FROM Clientes"
        Sqlda = New SqlDataAdapter(sqlQuery, con)
        Sqlda.Fill(dtclientes)
        Return dtclientes
        con.Close()
    End Function
    Public Function combo_box_productos()
        con = conectar.conexion()
        Dim Sqlda As SqlDataAdapter
        Dim dtproductos As DataTable = New DataTable
        Dim sqlQuery As String = "SELECT id_producto,nombre_producto FROM Producto"
        Sqlda = New SqlDataAdapter(sqlQuery, con)
        Sqlda.Fill(dtproductos)
        Return dtproductos
        con.Close()
    End Function
    Public Function nud_cantidad(idproducto As Integer)
        con = conectar.conexion()
        Dim cantidad As Integer
        Dim sqld As SqlDataAdapter
        Dim dtcantidad As DataTable = New DataTable
        Dim sqlquery As String = "SELECT Cantidad_Disponible as ct FROM Producto where id_producto=" & idproducto
        sqld = New SqlDataAdapter(sqlquery, con)
        sqld.Fill(dtcantidad)
        Dim row As DataRow = dtcantidad.Rows(dtcantidad.Rows.Count - 1)
        cantidad = row("ct")
        Return cantidad
        con.Close()
    End Function
    Public Function lbl_precio(idproducto As Integer)
        con = conectar.conexion()
        Dim precio As Double
        Dim sqld As SqlDataAdapter
        Dim dtcantidad As DataTable = New DataTable
        Dim sqlquery As String = "SELECT precio FROM Producto WHERE id_producto=" & idproducto
        sqld = New SqlDataAdapter(sqlquery, con)
        sqld.Fill(dtcantidad)
        Dim row As DataRow = dtcantidad.Rows(dtcantidad.Rows.Count - 1)
        precio = row("precio")
        Return precio
        con.Close()
    End Function
    Public Function obtener_last_idfacturas()
        con = conectar.conexion()
        Dim idres As Integer
        Dim sqld As SqlDataAdapter
        Dim dtid As DataTable = New DataTable
        Dim sqlquery As String = "SELECT TOP 1 * FROM Facturas ORDER BY id_facturas DESC"
        sqld = New SqlDataAdapter(sqlquery, con)
        sqld.Fill(dtid)
        Dim row As DataRow = dtid.Rows(dtid.Rows.Count - 1)
        idres = row("id_facturas")
        Return idres
        con.Close()
    End Function
    Public Function nueva_factura(idfacturas As Integer, idclientes As Integer, idusuarios As Integer)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id_facturas", idfacturas))
        command.Parameters.Add(New SqlParameter("@id_cliente", idclientes))
        command.Parameters.Add(New SqlParameter("@id_usuario", idusuarios))
        command.CommandText = "SP_InsertarFactura"
        Return command
        con.Close()
    End Function
    Public Function agregar_nueva_compra(idproductos As Integer, idfacturas As Integer, cantidad As Integer)
        con = conectar.conexion()
        Dim command As SqlCommand = con.CreateCommand
        con.Open()
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add(New SqlParameter("@id_productos", idproductos))
        command.Parameters.Add(New SqlParameter("@id_facturas", idfacturas))
        command.Parameters.Add(New SqlParameter("@cantidad", cantidad))
        command.CommandText = "SP_AgregarCompra"
        Return command
        con.Close()
    End Function
    Public Function imprimir_facturas_rows(id_facturas As Integer)
        con = conectar.conexion()
        Dim sqld As SqlDataAdapter
        Dim dtcantidad As DataTable = New DataTable
        Dim sqlquery As String = "SELECT C.nombre, C.id_cliente, F.id_facturas,F.monto,C.numero_telefono,C.correo
FROM Facturas as F INNER JOIN Clientes as C
ON F.id_cliente= C.id_cliente
WHERE F.id_facturas =" & id_facturas & ";"
        sqld = New SqlDataAdapter(sqlquery, con)
        sqld.Fill(dtcantidad)
        Dim row As DataRow = dtcantidad.Rows(dtcantidad.Rows.Count - 1)
        Return row
    End Function
    Public Function imprimir_facturas_dtg(id_facturas As Integer)
        con = conectar.conexion()
        Dim sqld As SqlDataAdapter
        Dim dtcantidad As DataTable = New DataTable
        Dim sqlquery As String = "SELECT C.id_producto,P.nombre_producto,C.Cantidad,P.precio
FROM Producto as P INNER JOIN Compras as C
ON P.id_producto= C.id_producto
WHERE C.id_factura=" & id_facturas & ";"
        sqld = New SqlDataAdapter(sqlquery, con)
        sqld.Fill(dtcantidad)
        Return dtcantidad
    End Function
End Class