Imports Modulo_Administracion
Public Class frmprincipal
    Dim userinfo As New UserData()
    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If ModuleUser.Tipo.ToString().Equals("1") Then

                frmCrearUsuario.MdiParent = Me
                frmCrearUsuario.WindowState = FormWindowState.Maximized
                frmCrearUsuario.Show()

            ElseIf ModuleUser.Tipo.ToString().Equals("2") Then
                CrearUsuarioToolStripMenuItem.Visible = False
                CrearClientesToolStripMenuItem.Visible = False
                FacturacionToolStripMenuItem.Visible = False
                ModificarClientesToolStripMenuItem.Visible = False

                frmcrearproducto.MdiParent = Me
                frmcrearproducto.WindowState = FormWindowState.Maximized
                frmcrearproducto.Show()

            ElseIf ModuleUser.Tipo.ToString().Equals("3") Then
                CrearUsuarioToolStripMenuItem.Visible = False
                CrearInventarioToolStripMenuItem.Visible = False
                CrearClientesToolStripMenuItem.Visible = True
                FacturacionToolStripMenuItem.Visible = True
                ModificarClientesToolStripMenuItem.Visible = True

                frmCrearCliente.MdiParent = Me
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
        frmCrearCliente.Show()

        frmCrearUsuario.Close()
        frmfactura.Close()
        frmfacturacion.Close()
        ModificarCliente.Close()

    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frmfacturacion.MdiParent = Me
        frmfacturacion.WindowState = FormWindowState.Maximized
        frmfacturacion.Show()

        frmCrearCliente.Close()
        frmCrearUsuario.Close()
        ModificarCliente.Close()
        frmfactura.Close()

    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        frmCrearUsuario.MdiParent = Me
        frmCrearUsuario.WindowState = FormWindowState.Maximized
        frmCrearUsuario.Show()


        frmfactura.Close()
        frmfacturacion.Close()
        frmCrearCliente.Close()
        ModificarCliente.Close()

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