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
        Dim Animation6 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnconexion = New System.Windows.Forms.Button()
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.txtCorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.btnx = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuMaterialTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.anima1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.p3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnconexion
        '
        Me.btnconexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.anima1.SetDecoration(Me.btnconexion, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnconexion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconexion.ForeColor = System.Drawing.Color.Black
        Me.btnconexion.Location = New System.Drawing.Point(792, 763)
        Me.btnconexion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnconexion.Name = "btnconexion"
        Me.btnconexion.Size = New System.Drawing.Size(120, 46)
        Me.btnconexion.TabIndex = 0
        Me.btnconexion.Text = " Conectar"
        Me.btnconexion.UseVisualStyleBackColor = False
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.GunaLabel1)
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.l3)
        Me.anima1.SetDecoration(Me.p1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(216, 121)
        Me.p1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(436, 601)
        Me.p1.TabIndex = 3
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.anima1.SetDecoration(Me.l2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.l2.ForeColor = System.Drawing.Color.Silver
        Me.l2.Location = New System.Drawing.Point(130, 52)
        Me.l2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(205, 41)
        Me.l2.TabIndex = 2
        Me.l2.Text = "Proyecto Final"
        Me.l2.Visible = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.anima1.SetDecoration(Me.l3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.l3.ForeColor = System.Drawing.Color.Silver
        Me.l3.Location = New System.Drawing.Point(162, 141)
        Me.l3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(111, 25)
        Me.l3.TabIndex = 1
        Me.l3.Text = "Integrantes:"
        Me.l3.Visible = False
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p2.Controls.Add(Me.txtCorreo)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.GunaButton1)
        Me.p2.Controls.Add(Me.txtpass)
        Me.anima1.SetDecoration(Me.p2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(651, 121)
        Me.p2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(436, 601)
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
        Me.txtCorreo.Location = New System.Drawing.Point(55, 95)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(336, 54)
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
        Me.linkaccnt.Location = New System.Drawing.Point(149, 521)
        Me.linkaccnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(152, 20)
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
        Me.GunaButton1.Location = New System.Drawing.Point(55, 405)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(336, 52)
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
        Me.txtpass.Location = New System.Drawing.Point(55, 170)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(336, 54)
        Me.txtpass.TabIndex = 1
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'p3
        '
        Me.p3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p3.Controls.Add(Me.btnx)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox5)
        Me.p3.Controls.Add(Me.GunaCheckBox2)
        Me.p3.Controls.Add(Me.GunaButton2)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox4)
        Me.anima1.SetDecoration(Me.p3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(651, 121)
        Me.p3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(436, 601)
        Me.p3.TabIndex = 5
        Me.p3.Visible = False
        '
        'btnx
        '
        Me.btnx.AutoSize = True
        Me.anima1.SetDecoration(Me.btnx, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnx.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnx.ForeColor = System.Drawing.Color.Silver
        Me.btnx.Location = New System.Drawing.Point(409, 4)
        Me.btnx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(23, 25)
        Me.btnx.TabIndex = 6
        Me.btnx.Text = "X"
        '
        'BunifuMaterialTextbox5
        '
        Me.BunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.HintText = "Re-Enter Password"
        Me.BunifuMaterialTextbox5.isPassword = False
        Me.BunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.LineThickness = 3
        Me.BunifuMaterialTextbox5.Location = New System.Drawing.Point(45, 247)
        Me.BunifuMaterialTextbox5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMaterialTextbox5.Name = "BunifuMaterialTextbox5"
        Me.BunifuMaterialTextbox5.Size = New System.Drawing.Size(336, 54)
        Me.BunifuMaterialTextbox5.TabIndex = 5
        Me.BunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaCheckBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.anima1.SetDecoration(Me.GunaCheckBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox2.Location = New System.Drawing.Point(45, 310)
        Me.GunaCheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(126, 20)
        Me.GunaCheckBox2.TabIndex = 4
        Me.GunaCheckBox2.Text = "Show Password"
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
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(45, 487)
        Me.GunaButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(336, 52)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Text = "Save"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.HintText = "Password"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(45, 176)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(336, 54)
        Me.BunifuMaterialTextbox3.TabIndex = 1
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox4
        '
        Me.BunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.HintText = "Username"
        Me.BunifuMaterialTextbox4.isPassword = False
        Me.BunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.LineThickness = 3
        Me.BunifuMaterialTextbox4.Location = New System.Drawing.Point(45, 112)
        Me.BunifuMaterialTextbox4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMaterialTextbox4.Name = "BunifuMaterialTextbox4"
        Me.BunifuMaterialTextbox4.Size = New System.Drawing.Size(336, 54)
        Me.BunifuMaterialTextbox4.TabIndex = 0
        Me.BunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation6
        Me.anima1.Interval = 20
        Me.anima1.TimeStep = 0.1!
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.anima1.SetDecoration(Me.GunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(162, 176)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(191, 125)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "BORRERO,ORLANDO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CASTILLO,WENCERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GUTIERREZ,LUIS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GREEN,ABRAHAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-1LS132-"
        Me.GunaLabel1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1303, 842)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.btnconexion)
        Me.anima1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents btnconexion As Button
    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnx As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuMaterialTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents anima1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents txtCorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
