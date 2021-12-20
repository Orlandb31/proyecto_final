Imports Modulo_Administracion
Public Class frmprincipal
    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCrearUsuario.MdiParent = Me
        frmCrearUsuario.WindowState = FormWindowState.Maximized
        frmCrearUsuario.Show()

    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        frmcrearproducto.MdiParent = Me
        frmcrearproducto.WindowState = FormWindowState.Maximized
        frmcrearproducto.Show()

        frmCrearUsuario.Close()
        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()

    End Sub

   
    Private Sub CrearClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearClientesToolStripMenuItem.Click
        frmCrearCliente.MdiParent = Me
        frmCrearCliente.WindowState = FormWindowState.Maximized
        frmCrearCliente.Show()

        frmCrearUsuario.Close()
        frmfactura.Close()
        frmfacturacion.Close()

    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frmfacturacion.MdiParent = Me
        frmfacturacion.WindowState = FormWindowState.Maximized
        frmfacturacion.Show()

        frmCrearCliente.Close()
        frmCrearUsuario.Close()
        frmfactura.Close()

    End Sub

    Private Sub CrearClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearClienteToolStripMenuItem.Click
        frmCrearUsuario.MdiParent = Me
        frmCrearUsuario.WindowState = FormWindowState.Maximized
        frmCrearUsuario.Show()


        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()


    End Sub

<<<<<<< HEAD
    Private Sub ModificarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
=======
    Private Sub ModificarClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModificarClientesToolStripMenuItem.Click
>>>>>>> 03d4baddb0a4266dabe7c44fc554a66299013bed
        ModificarCliente.MdiParent = Me
        ModificarCliente.WindowState = FormWindowState.Maximized
        ModificarCliente.Show()

        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()
        frmCrearUsuario.Close()
    End Sub

    Private Sub RegistrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class