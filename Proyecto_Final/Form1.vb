Imports Modulo_Conexion
Imports Modulo_Administracion
Public Class Form1

    Dim makeLogin As New CLogica
    Private Sub linkaccnt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccnt.LinkClicked
        anima1.HideSync(p2)
        anima1.ShowSync(p3)
        l3.Text = "Create Account"
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        anima1.HideSync(p3)
        anima1.ShowSync(p2)
        l3.Text = "Authentication"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim modulo As New CAProbarConexion
        Dim respuestas As Boolean = modulo.verificarconexion
        If respuestas Then

        Else
            MessageBox.Show("error al realizar la conexion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub


    Private Sub btnconexion_Click(sender As Object, e As EventArgs) Handles btnconexion.Click
        Dim modulo As New CAProbarConexion
        Dim respuestas As Boolean = modulo.verificarconexion
        If respuestas Then
            frmprincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("error al realizar la conexion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim modulo As New CAProbarConexion
        Dim respuestas As Boolean = modulo.verificarconexion
        Dim email, pass As String
        Dim count As Integer
        email = txtCorreo.Text
        pass = txtpass.Text




        If makeLogin.LoginUsuarios(email, pass) = 1 Then
            frmprincipal.Show()
            '' Me.Close()
        Else
            MsgBox("Usuario y contraseña invalido")
            count = +1
        End If
    End Sub
End Class
