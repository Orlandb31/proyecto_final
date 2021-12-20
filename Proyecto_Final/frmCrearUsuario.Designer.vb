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
        Me.gbox_tipoUsuario = New System.Windows.Forms.GroupBox()
        Me.rbt_Cajera = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_Inventario = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbt_Administrador = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtContrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegistrarUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.p1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbox_tipoUsuario.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_tipoUsuario
        '
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Cajera)
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Inventario)
        Me.gbox_tipoUsuario.Controls.Add(Me.rbt_Administrador)
        Me.gbox_tipoUsuario.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.gbox_tipoUsuario.Location = New System.Drawing.Point(83, 310)
        Me.gbox_tipoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbox_tipoUsuario.Name = "gbox_tipoUsuario"
        Me.gbox_tipoUsuario.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbox_tipoUsuario.Size = New System.Drawing.Size(447, 55)
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
        Me.rbt_Cajera.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbt_Cajera.Location = New System.Drawing.Point(326, 21)
        Me.rbt_Cajera.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbt_Cajera.Name = "rbt_Cajera"
        Me.rbt_Cajera.Size = New System.Drawing.Size(55, 17)
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
        Me.rbt_Inventario.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbt_Inventario.Location = New System.Drawing.Point(186, 21)
        Me.rbt_Inventario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbt_Inventario.Name = "rbt_Inventario"
        Me.rbt_Inventario.Size = New System.Drawing.Size(72, 17)
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
        Me.rbt_Administrador.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.rbt_Administrador.Location = New System.Drawing.Point(44, 21)
        Me.rbt_Administrador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbt_Administrador.Name = "rbt_Administrador"
        Me.rbt_Administrador.Size = New System.Drawing.Size(88, 17)
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
        Me.txtContrasena.Location = New System.Drawing.Point(208, 242)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrasena.PlaceholderText = ""
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.ShadowDecoration.Parent = Me.txtContrasena
        Me.txtContrasena.Size = New System.Drawing.Size(227, 33)
        Me.txtContrasena.TabIndex = 9
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
        Me.txtCorreo.Location = New System.Drawing.Point(208, 188)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.ShadowDecoration.Parent = Me.txtCorreo
        Me.txtCorreo.Size = New System.Drawing.Size(227, 33)
        Me.txtCorreo.TabIndex = 7
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
        Me.txtApellido.Location = New System.Drawing.Point(208, 138)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.ShadowDecoration.Parent = Me.txtApellido
        Me.txtApellido.Size = New System.Drawing.Size(227, 30)
        Me.txtApellido.TabIndex = 5
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
        Me.txtNombre.Location = New System.Drawing.Point(208, 88)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.ShadowDecoration.Parent = Me.txtNombre
        Me.txtNombre.Size = New System.Drawing.Size(227, 30)
        Me.txtNombre.TabIndex = 2
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
        Me.btnRegistrarUsuario.FillColor = System.Drawing.Color.SpringGreen
        Me.btnRegistrarUsuario.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarUsuario.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarUsuario.HoverState.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.Location = New System.Drawing.Point(246, 393)
        Me.btnRegistrarUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrarUsuario.Name = "btnRegistrarUsuario"
        Me.btnRegistrarUsuario.ShadowDecoration.Parent = Me.btnRegistrarUsuario
        Me.btnRegistrarUsuario.Size = New System.Drawing.Size(142, 37)
        Me.btnRegistrarUsuario.TabIndex = 0
        Me.btnRegistrarUsuario.Text = "Registrar"
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p1.Controls.Add(Me.gbox_tipoUsuario)
        Me.p1.Controls.Add(Me.txtContrasena)
        Me.p1.Controls.Add(Me.Label6)
        Me.p1.Controls.Add(Me.Label8)
        Me.p1.Controls.Add(Me.btnRegistrarUsuario)
        Me.p1.Controls.Add(Me.txtCorreo)
        Me.p1.Controls.Add(Me.txtApellido)
        Me.p1.Controls.Add(Me.Label7)
        Me.p1.Controls.Add(Me.txtNombre)
        Me.p1.Controls.Add(Me.Label9)
        Me.p1.Controls.Add(Me.Label10)
        Me.p1.Location = New System.Drawing.Point(58, 69)
        Me.p1.Name = "p1"
        Me.p1.ShadowDecoration.Parent = Me.p1
        Me.p1.Size = New System.Drawing.Size(607, 485)
        Me.p1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(99, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(99, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Correo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(99, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Contraseña :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(99, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Apellido :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(211, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 45)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Crear Usuario"
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(771, 656)
        Me.Controls.Add(Me.p1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearUsuario"
        Me.Text = "frmclientes"
        Me.gbox_tipoUsuario.ResumeLayout(False)
        Me.gbox_tipoUsuario.PerformLayout()
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbox_tipoUsuario As GroupBox
    Friend WithEvents rbt_Cajera As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_Inventario As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbt_Administrador As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtContrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegistrarUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents p1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
