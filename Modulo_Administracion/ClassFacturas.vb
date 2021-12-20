Imports System.Data.SqlClient
Imports ModuloFacturacion
Public Class ClassFacturas
    Public procedimiento As New Facturacion
    Public sqlcom As SqlCommand
    Public dtble As DataTable
    Public Function llenar_cbo_clientes()
        dtble = procedimiento.combo_box_clientes()
        Return dtble
    End Function
    Public Function llenar_cbo_productos()
        dtble = procedimiento.combo_box_productos()
        Return dtble
    End Function
    Public Function nud_cantidades(idproducto As Integer)
        Dim resp As Integer = procedimiento.nud_cantidad(idproducto)
        Return resp
    End Function
    Public Function mostrar_precio(idproducto As Integer)
        Dim resp As Double = procedimiento.lbl_precio(idproducto)
        Return resp
    End Function
    Public Function retornar_idfacturas()
        Dim resp As Integer = procedimiento.obtener_last_idfacturas()
        Return resp
    End Function
    Public Function ingresar_nueva_factura(idfacturas As Integer, idclientes As Integer, idusuarios As Integer)
        sqlcom = procedimiento.nueva_factura(idfacturas, idclientes, idusuarios)
        If sqlcom.ExecuteNonQuery() Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function agregar_compra(idproducto As Integer, idfacturas As Integer, cantidad As Integer)
        sqlcom = procedimiento.agregar_nueva_compra(idproducto, idfacturas, cantidad)
        If sqlcom.ExecuteNonQuery() Then
            Return "Compra Agregada Correctamente"
        Else
            Return "Error al Agregar la compra"
        End If
    End Function
    Public Function impresion_rows(idfacturas As Integer)
        Dim row As DataRow = procedimiento.imprimir_facturas_rows(idfacturas)
        Return row
    End Function
    Public Function impresion_dtg(idfacturas As Integer)
        dtble = procedimiento.imprimir_facturas_dtg(idfacturas)
        Return dtble
    End Function
End Class