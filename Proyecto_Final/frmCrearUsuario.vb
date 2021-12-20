Imports Modulo_Administracion
Public Class frmCrearUsuario
    Private Sub btnRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistrarUsuario.Click
        Dim nombre
        Dim apellido
        Dim correo
        Dim contrasena
        Dim tipo_usuario = -1
        Dim user As New CLogica
        Dim val As New validaciones
        Dim res As Boolean



        nombre = txtNombre.Text
        apellido = txtApellido.Text
        correo = txtCorreo.Text
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
                res = val.validar_Usuario(correo)
                'If res Then
                '    MsgBox("Ya existe un usuario ligado a este correo electronico, Favor Ingrese otro")
                '    txtCorreo.ResetText()
                'Else
                MessageBox.Show(user.IngresarUsuarios(nombre, apellido, correo, contrasena, tipo_usuario))
                txtNombre.ResetText()
                txtApellido.ResetText()
                txtCorreo.ResetText()
                txtContrasena.ResetText()
                rbt_Administrador.Checked = False
                rbt_Cajera.Checked = False
                rbt_Inventario.Checked = False
                'End If



            Catch ex As Exception
                MessageBox.Show("Error al insertar Usuario " + ex.Message)
            End Try



        End If

    End Sub
End Class