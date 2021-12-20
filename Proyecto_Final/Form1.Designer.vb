<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtCorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.btnx = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.txtsendmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.anima1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.p3.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.GunaLabel1)
        Me.p1.Controls.Add(Me.l3)
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.l1)
        Me.p1.Controls.Add(Me.Label2)
        Me.anima1.SetDecoration(Me.p1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(162, 98)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(327, 488)
        Me.p1.TabIndex = 3
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p2.Controls.Add(Me.txtCorreo)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.GunaButton1)
        Me.p2.Controls.Add(Me.txtpass)
        Me.anima1.SetDecoration(Me.p2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(488, 98)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(327, 488)
        Me.p2.TabIndex = 4
        Me.p2.Visible = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtCorreo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCorreo.ForeColor = System.Drawing.Color.Silver
        Me.txtCorreo.HintForeColor = System.Drawing.Color.Silver
        Me.txtCorreo.HintText = "Correo"
        Me.txtCorreo.isPassword = False
        Me.txtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtCorreo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCorreo.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtCorreo.LineThickness = 3
        Me.txtCorreo.Location = New System.Drawing.Point(41, 77)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(252, 44)
        Me.txtCorreo.TabIndex = 4
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'linkaccnt
        '
        Me.linkaccnt.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.linkaccnt.AutoSize = True
        Me.anima1.SetDecoration(Me.linkaccnt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.linkaccnt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkaccnt.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.linkaccnt.LinkColor = System.Drawing.Color.Silver
        Me.linkaccnt.Location = New System.Drawing.Point(112, 423)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(120, 15)
        Me.linkaccnt.TabIndex = 3
        Me.linkaccnt.TabStop = True
        Me.linkaccnt.Text = "Olvido la contraseña?"
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(41, 329)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(252, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "Sign in"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpass
        '
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpass.HintForeColor = System.Drawing.Color.Silver
        Me.txtpass.HintText = "Password"
        Me.txtpass.isPassword = True
        Me.txtpass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtpass.LineIdleColor = System.Drawing.Color.Gray
        Me.txtpass.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtpass.LineThickness = 3
        Me.txtpass.Location = New System.Drawing.Point(41, 138)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(252, 44)
        Me.txtpass.TabIndex = 1
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'p3
        '
        Me.p3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p3.Controls.Add(Me.GunaLabel2)
        Me.p3.Controls.Add(Me.btnx)
        Me.p3.Controls.Add(Me.GunaButton2)
        Me.p3.Controls.Add(Me.txtsendmail)
        Me.anima1.SetDecoration(Me.p3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(488, 98)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(327, 488)
        Me.p3.TabIndex = 5
        Me.p3.Visible = False
        '
        'btnx
        '
        Me.btnx.AutoSize = True
        Me.anima1.SetDecoration(Me.btnx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnx.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnx.ForeColor = System.Drawing.Color.Silver
        Me.btnx.Location = New System.Drawing.Point(307, 3)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(18, 20)
        Me.btnx.TabIndex = 6
        Me.btnx.Text = "X"
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(34, 396)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(252, 42)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Text = "Enviar"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsendmail
        '
        Me.txtsendmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtsendmail, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtsendmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsendmail.ForeColor = System.Drawing.Color.Silver
        Me.txtsendmail.HintForeColor = System.Drawing.Color.Silver
        Me.txtsendmail.HintText = "Correo"
        Me.txtsendmail.isPassword = False
        Me.txtsendmail.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.txtsendmail.LineIdleColor = System.Drawing.Color.Silver
        Me.txtsendmail.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtsendmail.LineThickness = 3
        Me.txtsendmail.Location = New System.Drawing.Point(34, 91)
        Me.txtsendmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsendmail.Name = "txtsendmail"
        Me.txtsendmail.Size = New System.Drawing.Size(252, 44)
        Me.txtsendmail.TabIndex = 0
        Me.txtsendmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation2
        Me.anima1.Interval = 20
        Me.anima1.TimeStep = 0.1!
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.anima1.SetDecoration(Me.l3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.l3.ForeColor = System.Drawing.Color.Silver
        Me.l3.Location = New System.Drawing.Point(165, 134)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(48, 20)
        Me.l3.TabIndex = 8
        Me.l3.Text = "FINAL"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.anima1.SetDecoration(Me.l2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.l2.ForeColor = System.Drawing.Color.Silver
        Me.l2.Location = New System.Drawing.Point(166, 100)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(128, 32)
        Me.l2.TabIndex = 9
        Me.l2.Text = "PROYECTO"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.anima1.SetDecoration(Me.l1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold)
        Me.l1.ForeColor = System.Drawing.Color.Silver
        Me.l1.Location = New System.Drawing.Point(51, 91)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(134, 72)
        Me.l1.TabIndex = 7
        Me.l1.Text = "UTP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.anima1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(89, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 184)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Integrantes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Castillo,Wencers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrero, Orlando" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Green, Abraham" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gutierrez, Lu" &
    "is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     -1LS132-"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(102, 36)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(134, 32)
        Me.GunaLabel1.TabIndex = 10
        Me.GunaLabel1.Text = "DoogyTech"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel2.Location = New System.Drawing.Point(37, 36)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(275, 32)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "Reestablecer Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(977, 684)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p3)
        Me.anima1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnx As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtsendmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents anima1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents txtCorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
