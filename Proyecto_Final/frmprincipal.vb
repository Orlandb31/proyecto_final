Imports Modulo_Administracion
Public Class frmprincipal
    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        frmcrearproducto.MdiParent = Me
        frmcrearproducto.WindowState = FormWindowState.Maximized
        frmcrearproducto.Show()
    End Sub

    Private Sub RegistrarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarInventarioToolStripMenuItem.Click

    End Sub

    Private Sub CrearClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearClientesToolStripMenuItem.Click
        frmCrearC.MdiParent = Me
        frmCrearC.WindowState = FormWindowState.Maximized
        frmCrearC.Show()
        frmfacturacion.Close()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        frmfacturacion.MdiParent = Me
        frmfacturacion.WindowState = FormWindowState.Maximized
        frmfacturacion.Show()
        frmCrearC.Close()
    End Sub

    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim nombre, apellido, correo, contrasena As String
        Dim tipo_usuario = -1, estado As Integer
        Dim user As New CLogica

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        correo = txtContrasena.Text
        contrasena = txtContrasena.Text

            If rbt_Administrador.Checked Then
                tipo_usuario = 1
            ElseIf rbt_Inventario.Checked Then
                tipo_usuario = 2
            ElseIf rbt_Cajera.Checked Then
                tipo_usuario = 3
            End If

            If String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(apellido) Or String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(contrasena) Or tipo_usuario = -1 Then
                MsgBox("Complete todos los campos del Formulario")
            Else
            Try
                MessageBox.Show(user.IngresarUsuarios(nombre, apellido, correo, contrasena, tipo_usuario))
                txtNombre.ResetText()
                txtApellido.ResetText()
                txtCorreo.ResetText()
                txtContrasena.ResetText()
            Catch ex As Exception
                MessageBox.Show("Error al insertar Usuario " + ex.Message)
            End Try

        End If
    End Sub
End Class