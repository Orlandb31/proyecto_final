Imports Modulo_Administracion
Public Class frmfacturacion
    Private idcliente As Integer
    Private idproducto As Integer
    Private idusuario As Integer = 1
    Private idfactura As Integer
    Private obj As New ClassFacturas

    Private Sub frmfacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = obj.llenar_cbo_clientes()
        If dt.Rows.Count <> 0 Then
            With cbo_clientes
                .DataSource = dt
                .ValueMember = "id_clientes"
                .DisplayMember = "nombre"
            End With
        End If
        dt = obj.llenar_cbo_productos()
        If dt.Rows.Count <> 0 Then
            With cbo_productos
                .DataSource = dt
                .ValueMember = "id_producto"
                .DisplayMember = "nombre_producto"
            End With
        End If
        facturacionpanel3.Hide()
        'btnimprimir.Hide()
        idproducto = cbo_productos.SelectedValue()
        nud_cantidades.Value = 1
        nud_cantidades.Maximum = obj.nud_cantidades(idproducto)
        nud_cantidades.Minimum = 1
        lbl_precio.Text = obj.mostrar_precio(idproducto)
    End Sub

    Private Sub cbo_productos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_productos.SelectionChangeCommitted
        idproducto = cbo_productos.SelectedValue()
        nud_cantidades.Value = 1
        nud_cantidades.Maximum = obj.nud_cantidades(idproducto)
        nud_cantidades.Minimum = 1
        lbl_precio.Text = obj.mostrar_precio(idproducto)
    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        idcliente = cbo_clientes.SelectedValue()
        facturacionpanel3.Show()
        Dim obj2 As New validaciones
        Dim r As Boolean = obj2.validar_tablafacturas()
        If r Then
            idfactura = 0
        Else
            idfactura = (obj.retornar_idfacturas() + 1)
        End If
        Try
            MessageBox.Show(obj.ingresar_nueva_factura(idfactura, idcliente, idusuario))
        Catch ex As Exception
            MessageBox.Show("Hubo un error=" + ex.ToString)
        End Try

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim cantidad As Integer = nud_cantidades.Value()
        Try
            MessageBox.Show(obj.agregar_compra(idproducto, idfactura, cantidad))
        Catch ex As Exception
            MessageBox.Show("Hubo un error=" + ex.ToString)
        End Try
        btnimprimir.Show()
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        frmfactura.TopLevel = False
        frmfactura.TopMost = True
        panelFacturacion.Controls.Add(frmfactura)
        frmfactura.Show()
        panelFacturacion.Visible = True
    End Sub
End Class