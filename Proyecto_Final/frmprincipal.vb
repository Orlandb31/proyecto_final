Public Class frmprincipal
    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        frmcrearproducto.MdiParent = Me
        frmcrearproducto.WindowState = FormWindowState.Maximized
        frmcrearproducto.Show()
    End Sub
End Class