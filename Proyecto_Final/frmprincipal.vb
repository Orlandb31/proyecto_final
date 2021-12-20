Imports Modulo_Administracion
Public Class frmprincipal
    Dim userinfo As New UserData()
    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If ModuleUser.Tipo.ToString().Equals("1") Then

                frmCrearUsuario.MdiParent = Me
                frmCrearUsuario.WindowState = FormWindowState.Maximized
                frmCrearUsuario.p1.Left = (Me.Width - frmCrearCliente.p1.Width) / 2
                frmCrearUsuario.p1.Top = (frmCrearUsuario.Height - frmCrearUsuario.p1.Height) / 2
                frmCrearUsuario.Show()

            ElseIf ModuleUser.Tipo.ToString().Equals("2") Then
                CrearUsuarioToolStripMenuItem.Visible = False
                CrearClientesToolStripMenuItem.Visible = False
                FacturacionToolStripMenuItem.Visible = False
                ModificarClientesToolStripMenuItem.Visible = False

                frmcrearproducto.MdiParent = Me
                frmcrearproducto.WindowState = FormWindowState.Maximized
                frmcrearproducto.pCrearProducto.Left = (frmcrearproducto.Width - frmcrearproducto.pCrearProducto.Width) / 2
                frmcrearproducto.pCrearProducto.Top = (frmcrearproducto.Height - frmcrearproducto.pCrearProducto.Height) / 2
                frmcrearproducto.Show()

            ElseIf ModuleUser.Tipo.ToString().Equals("3") Then
                CrearUsuarioToolStripMenuItem.Visible = False
                CrearInventarioToolStripMenuItem.Visible = False
                CrearClientesToolStripMenuItem.Visible = True
                FacturacionToolStripMenuItem.Visible = True
                ModificarClientesToolStripMenuItem.Visible = True

                frmCrearCliente.MdiParent = Me
                frmCrearCliente.p1.Left = (Me.Width - frmCrearCliente.p1.Width) / 2
                frmCrearCliente.p1.Top = (frmCrearCliente.Height - frmCrearCliente.p1.Height) / 2
                frmCrearCliente.WindowState = FormWindowState.Maximized
                frmCrearCliente.Show()

            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            Me.Close()
            Form1.Visible = True


        End Try



    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearInventarioToolStripMenuItem.Click
        frmcrearproducto.MdiParent = Me
        frmcrearproducto.WindowState = FormWindowState.Maximized
        frmcrearproducto.pCrearProducto.Left = (frmcrearproducto.Width - frmcrearproducto.pCrearProducto.Width) / 2
        frmcrearproducto.pCrearProducto.Top = (frmcrearproducto.Height - frmcrearproducto.pCrearProducto.Height) / 2
        frmcrearproducto.Show()

        frmCrearUsuario.Close()
        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()
        ModificarCliente.Close()

    End Sub


    Private Sub CrearClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearClientesToolStripMenuItem.Click
        frmCrearCliente.MdiParent = Me
        frmCrearCliente.WindowState = FormWindowState.Maximized
        frmCrearCliente.p1.Left = (Me.Width - frmCrearCliente.p1.Width) / 2
        frmCrearCliente.p1.Top = (frmCrearCliente.Height - frmCrearCliente.p1.Height) / 2
        frmCrearCliente.Show()

        frmCrearUsuario.Close()
        frmfactura.Close()
        frmfacturacion.Close()
        ModificarCliente.Close()

    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frmfacturacion.MdiParent = Me
        frmfacturacion.WindowState = FormWindowState.Maximized
        frmfacturacion.p1.Left = (Me.Width - frmCrearCliente.p1.Width) / 2
        frmfacturacion.p1.Top = (frmfacturacion.Height - frmfacturacion.p1.Height) / 2
        frmfacturacion.Show()

        frmCrearCliente.Close()
        frmCrearUsuario.Close()
        ModificarCliente.Close()
        frmfactura.Close()

    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        frmCrearUsuario.MdiParent = Me
        frmCrearUsuario.WindowState = FormWindowState.Maximized
        frmCrearUsuario.p1.Left = (Me.Width - frmCrearCliente.p1.Width) / 2

        frmCrearUsuario.Show()


        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()
        ModificarCliente.Close()

    End Sub




    Private Sub ModificarClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModificarClientesToolStripMenuItem.Click

        ModificarCliente.MdiParent = Me
        ModificarCliente.WindowState = FormWindowState.Maximized

        ModificarCliente.p1.Left = (Me.Width - ModificarCliente.p1.Width) / 2
        ModificarCliente.Show()

        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()
        frmCrearUsuario.Close()
    End Sub

    Private Sub RegistrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class