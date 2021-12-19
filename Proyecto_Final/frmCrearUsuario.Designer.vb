<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearUsuario
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
        Me.grb_RegistrarUsuario = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.gbox_tipoUsuario = New System.Windows.Forms.GroupBox()
        Me.rbt_Cajera = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_Inventario = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_Administrador = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtContrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistrarUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.grb_RegistrarUsuario.SuspendLayout()
        Me.gbox_tipoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_RegistrarUsuario
        '
        Me.grb_RegistrarUsuario.Controls.Add(Me.gbox_tipoUsuario)
        Me.grb_RegistrarUsuario.Controls.Add(Me.txtContrasena)
        Me.grb_RegistrarUsuario.Controls.Add(Me.lblContrasena)
        Me.grb_RegistrarUsuario.Controls.Add(Me.txtCorreo)
        Me.grb_RegistrarUsuario.Controls.Add(Me.lblCorreo)
        Me.grb_RegistrarUsuario.Controls.Add(Me.txtApellido)
        Me.grb_RegistrarUsuario.Controls.Add(Me.lblApellido)
        Me.grb_RegistrarUsuario.Controls.Add(Me.txtNombre)
        Me.grb_RegistrarUsuario.Controls.Add(Me.Label1)
        Me.grb_RegistrarUsuario.Controls.Add(Me.btnRegistrarUsuario)
        Me.grb_RegistrarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grb_RegistrarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.grb_RegistrarUsuario.Location = New System.Drawing.Point(163, 52)
        Me.grb_RegistrarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.grb_RegistrarUsuario.Name = "grb_RegistrarUsuario"
        Me.grb_RegistrarUsuario.ShadowDecoration.Parent = Me.grb_RegistrarUsuario
        Me.grb_RegistrarUsuario.Size = New System.Drawing.Size(416, 306)
        Me.grb_RegistrarUsuario.TabIndex = 5
        '
        'gbox_tipoUsuario
        '
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Cajera)
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Inventario)
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Administrador)
        Me.gbox_tipoUsuario.Location = New System.Drawing.Point(28, 187)
        Me.gbox_tipoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.gbox_tipoUsuario.Name = "gbox_tipoUsuario"
        Me.gbox_tipoUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.gbox_tipoUsuario.Size = New System.Drawing.Size(358, 55)
        Me.gbox_tipoUsuario.TabIndex = 10
        Me.gbox_tipoUsuario.TabStop = False
        Me.gbox_tipoUsuario.Text = "Tipo de Usuario"
        '
        'rbt_Cajera
        '
        Me.rbt_Cajera.AutoSize = True
        Me.rbt_Cajera.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Cajera.CheckedState.BorderThickness = 0
        Me.rbt_Cajera.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Cajera.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_Cajera.CheckedState.InnerOffset = -4
        Me.rbt_Cajera.Location = New System.Drawing.Point(260, 20)
        Me.rbt_Cajera.Margin = New System.Windows.Forms.Padding(2)
        Me.rbt_Cajera.Name = "rbt_Cajera"
        Me.rbt_Cajera.Size = New System.Drawing.Size(58, 19)
        Me.rbt_Cajera.TabIndex = 2
        Me.rbt_Cajera.Text = "Cajera"
        Me.rbt_Cajera.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_Cajera.UncheckedState.BorderThickness = 2
        Me.rbt_Cajera.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbt_Cajera.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbt_Inventario
        '
        Me.rbt_Inventario.AutoSize = True
        Me.rbt_Inventario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Inventario.CheckedState.BorderThickness = 0
        Me.rbt_Inventario.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Inventario.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_Inventario.CheckedState.InnerOffset = -4
        Me.rbt_Inventario.Location = New System.Drawing.Point(137, 21)
        Me.rbt_Inventario.Margin = New System.Windows.Forms.Padding(2)
        Me.rbt_Inventario.Name = "rbt_Inventario"
        Me.rbt_Inventario.Size = New System.Drawing.Size(78, 19)
        Me.rbt_Inventario.TabIndex = 1
        Me.rbt_Inventario.Text = "Inventario"
        Me.rbt_Inventario.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_Inventario.UncheckedState.BorderThickness = 2
        Me.rbt_Inventario.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbt_Inventario.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbt_Administrador
        '
        Me.rbt_Administrador.AutoSize = True
        Me.rbt_Administrador.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Administrador.CheckedState.BorderThickness = 0
        Me.rbt_Administrador.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbt_Administrador.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbt_Administrador.CheckedState.InnerOffset = -4
        Me.rbt_Administrador.Location = New System.Drawing.Point(15, 21)
        Me.rbt_Administrador.Margin = New System.Windows.Forms.Padding(2)
        Me.rbt_Administrador.Name = "rbt_Administrador"
        Me.rbt_Administrador.Size = New System.Drawing.Size(101, 19)
        Me.rbt_Administrador.TabIndex = 0
        Me.rbt_Administrador.Text = "Administrador"
        Me.rbt_Administrador.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbt_Administrador.UncheckedState.BorderThickness = 2
        Me.rbt_Administrador.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbt_Administrador.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtContrasena
        '
        Me.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContrasena.DefaultText = ""
        Me.txtContrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContrasena.DisabledState.Parent = Me.txtContrasena
        Me.txtContrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContrasena.FocusedState.Parent = Me.txtContrasena
        Me.txtContrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContrasena.HoverState.Parent = Me.txtContrasena
        Me.txtContrasena.Location = New System.Drawing.Point(99, 136)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrasena.PlaceholderText = ""
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.ShadowDecoration.Parent = Me.txtContrasena
        Me.txtContrasena.Size = New System.Drawing.Size(176, 33)
        Me.txtContrasena.TabIndex = 9
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.ForeColor = System.Drawing.Color.Black
        Me.lblContrasena.Location = New System.Drawing.Point(27, 145)
        Me.lblContrasena.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(73, 15)
        Me.lblContrasena.TabIndex = 8
        Me.lblContrasena.Text = "Contraseña :"
        '
        'txtCorreo
        '
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.Parent = Me.txtCorreo
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.FocusedState.Parent = Me.txtCorreo
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.HoverState.Parent = Me.txtCorreo
        Me.txtCorreo.Location = New System.Drawing.Point(77, 93)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.ShadowDecoration.Parent = Me.txtCorreo
        Me.txtCorreo.Size = New System.Drawing.Size(310, 33)
        Me.txtCorreo.TabIndex = 7
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.ForeColor = System.Drawing.Color.Black
        Me.lblCorreo.Location = New System.Drawing.Point(25, 102)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(49, 15)
        Me.lblCorreo.TabIndex = 6
        Me.lblCorreo.Text = "Correo :"
        '
        'txtApellido
        '
        Me.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellido.DefaultText = ""
        Me.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.DisabledState.Parent = Me.txtApellido
        Me.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.FocusedState.Parent = Me.txtApellido
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApellido.ForeColor = System.Drawing.Color.Black
        Me.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.HoverState.Parent = Me.txtApellido
        Me.txtApellido.Location = New System.Drawing.Point(272, 47)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.ShadowDecoration.Parent = Me.txtApellido
        Me.txtApellido.Size = New System.Drawing.Size(115, 30)
        Me.txtApellido.TabIndex = 5
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.ForeColor = System.Drawing.Color.Black
        Me.lblApellido.Location = New System.Drawing.Point(213, 53)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(57, 15)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido :"
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.Parent = Me.txtNombre
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.FocusedState.Parent = Me.txtNombre
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.HoverState.Parent = Me.txtNombre
        Me.txtNombre.Location = New System.Drawing.Point(77, 47)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.ShadowDecoration.Parent = Me.txtNombre
        Me.txtNombre.Size = New System.Drawing.Size(115, 30)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :"
        '
        'btnRegistrarUsuario
        '
        Me.btnRegistrarUsuario.CheckedState.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.CustomImages.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrarUsuario.DisabledState.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarUsuario.HoverState.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(151, 258)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.ShadowDecoration.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(124, 37)
        Me.btnRegistrarUsuario.TabIndex = 0
        Me.btnRegistrarUsuario.Text = "Registrar"
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grb_RegistrarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearUsuario"
        Me.Text = "frmclientes"
        Me.grb_RegistrarUsuario.ResumeLayout(False)
        Me.grb_RegistrarUsuario.PerformLayout()
        Me.gbox_tipoUsuario.ResumeLayout(False)
        Me.gbox_tipoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_RegistrarUsuario As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents gbox_tipoUsuario As GroupBox
    Friend WithEvents rbt_Cajera As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_Inventario As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_Administrador As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtContrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrarUsuario As Guna.UI2.WinForms.Guna2Button
End Class
