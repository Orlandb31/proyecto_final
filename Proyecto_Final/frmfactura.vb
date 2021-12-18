Imports Modulo_Administracion
Public Class frmfactura
    Private idfactura As Integer
    Private obj As New ClassFacturas
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frmfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idfactura = obj.retornar_idfacturas()
        Dim row As DataRow = obj.impresion_rows(idfactura)
        Dim monto As Double
        Dim itbms, total As Double
        Dim i1 As Decimal
        Dim dtmovimientos As DataTable = obj.impresion_dtg(idfactura)
        lbl_nfactura.Text = idfactura
        lbl_nombre.Text = row("nombre")
        monto = CDbl(row("monto"))
        lbl_ncliente.Text = row("id_cliente")
        lbl_telefono.Text = row("numero_telefono")
        lbl_email.Text = row("correo")
        itbms = monto * 0.07
        i1 = Decimal.Round(CDec(itbms), 2)
        total = monto + i1
        lbl_monto.Text = monto
        lbl_itbms.Text = i1
        lbl_toal.Text = total
        If dtmovimientos.Rows.Count <> 0 Then
            dtg_compras.DataSource = dtmovimientos
            dtg_compras.AutoResizeColumns()
        End If
    End Sub
End Class