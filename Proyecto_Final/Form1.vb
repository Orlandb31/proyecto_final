Imports Modulo_Conexion
Imports Modulo_Administracion
Imports System.Net.Mail
Imports System.Net
Public Class Form1
    Dim count As Integer = 0
    Dim randomCode As String
    Public Shared txtmail As String
    Dim makeLogin As New Login
    Dim reset As New CLogica
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


        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub


    Private Sub btnconexion_Click(sender As Object, e As EventArgs)
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
        Try

            Dim email, pass As String

            Dim resOk As DataTable
            Dim vUserInfo As UserData = New UserData()
            email = txtCorreo.Text
            pass = txtpass.Text
            If email = String.Empty Or pass = String.Empty Then
                MsgBox("Por favor llene los campos")
            Else
                resOk = makeLogin.user_login(email, pass)
                If count <= 3 Then
                    If resOk.Rows.Count > 0 Then
                        For Each dr As System.Data.DataRow In resOk.Rows
                            Dim vtryInt As Integer
                            Integer.TryParse(dr("id_usuario").ToString(), vtryInt)
                            vUserInfo.ID = vtryInt
                            vUserInfo.Email = dr("correo").ToString()
                            vUserInfo.Tipo = dr("tipo_usuario").ToString()

                        Next
                        ID = vUserInfo.ID
                        ModuleUser.Email = vUserInfo.Email.ToString()
                        Tipo = vUserInfo.Tipo.ToString()
                        Console.WriteLine(vUserInfo)
                        Dim fp As New frmprincipal()
                        Me.Hide()
                        fp.Show()

                    Else
                        resOk = makeLogin.validarMail(email)
                        If resOk.Rows.Count > 0 Then
                            count = count + 1
                            MsgBox("Usuario y contraseña invalido")
                        Else
                            count = 0
                            MsgBox("El correo electronico ingresado no existe")
                        End If




                    End If

                        Else
                    MsgBox("Usuario Bloqueado Comuníquese con el administrador " + " Numero de intentos " + count.ToString())

                End If

            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        randomCode = (rand.Next(999999999)).ToString()
        Dim message As MailMessage = New MailMessage
        Dim resOk As DataTable
        txtmail = txtsendmail.Text
        resOk = makeLogin.validarMail(txtmail)
        If resOk.Rows.Count > 0 Then
            from = "doggytechUTP@gmail.com"
            pass = "techdog123"
            messageBody = "Tu contraseña tempora es " + randomCode
            message.To.Add(txtmail)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Reestablecer Contraseña"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)

            Try

                If reset.actualizar_contraseña(txtmail, randomCode) = 1 Then
                    smtp.Send(message)
                    count = 0
                    MessageBox.Show("Verifique su bandeja de correo e inicie Sesion nuevamente")
                    anima1.HideSync(p3)
                    anima1.ShowSync(p2)
                    l3.Text = "Authentication"
                Else
                    MsgBox("No se pudo enviar la contraseña temporal")
                End If



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("El correo que ha introducido no existe")
        End If
    End Sub


End Class
