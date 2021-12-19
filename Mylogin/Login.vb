Imports Proyecto_Final

Public Class Login
    Dim main As New Proyecto_Final.frmfactura()
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

        pmain.Visible = False
        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        p1.Top = False
        p2.Top = False
        p3.Top = False
        main.Top = False
        pmain.Controls.Clear()
        pmain.Visible = True
        pmain.Top = True
        pmain.Controls.Add(main)
        pmain.Show()


        pmain.Controls.Add(main)


    End Sub
End Class