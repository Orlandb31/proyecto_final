<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCliente
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
        Me.p1 = New System.Windows.Forms.Panel()
        Me.btn_Modificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_elegir = New Guna.UI2.WinForms.Guna2Button()
        Me.cbox_clientes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNombreBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnumerot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p1.Controls.Add(Me.btn_Modificar)
        Me.p1.Controls.Add(Me.btn_elegir)
        Me.p1.Controls.Add(Me.cbox_clientes)
        Me.p1.Controls.Add(Me.btnBuscar)
        Me.p1.Controls.Add(Me.txtNombreBuscar)
        Me.p1.Controls.Add(Me.Label8)
        Me.p1.Controls.Add(Me.GroupBox1)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(44, 23)
        Me.p1.Margin = New System.Windows.Forms.Padding(2)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(854, 627)
        Me.p1.TabIndex = 0
        '
        'btn_Modificar
        '
        Me.btn_Modificar.CheckedState.Parent = Me.btn_Modificar
        Me.btn_Modificar.CustomImages.Parent = Me.btn_Modificar
        Me.btn_Modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Modificar.DisabledState.Parent = Me.btn_Modificar
        Me.btn_Modificar.FillColor = System.Drawing.Color.SpringGreen
        Me.btn_Modificar.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_Modificar.HoverState.Parent = Me.btn_Modificar
        Me.btn_Modificar.Location = New System.Drawing.Point(349, 565)
        Me.btn_Modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.ShadowDecoration.Parent = Me.btn_Modificar
        Me.btn_Modificar.Size = New System.Drawing.Size(120, 37)
        Me.btn_Modificar.TabIndex = 12
        Me.btn_Modificar.Text = "Actualizar"
        '
        'btn_elegir
        '
        Me.btn_elegir.CheckedState.Parent = Me.btn_elegir
        Me.btn_elegir.CustomImages.Parent = Me.btn_elegir
        Me.btn_elegir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_elegir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_elegir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_elegir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_elegir.DisabledState.Parent = Me.btn_elegir
        Me.btn_elegir.FillColor = System.Drawing.Color.SpringGreen
        Me.btn_elegir.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_elegir.ForeColor = System.Drawing.Color.Black
        Me.btn_elegir.HoverState.Parent = Me.btn_elegir
        Me.btn_elegir.Location = New System.Drawing.Point(615, 161)
        Me.btn_elegir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_elegir.Name = "btn_elegir"
        Me.btn_elegir.ShadowDecoration.Parent = Me.btn_elegir
        Me.btn_elegir.Size = New System.Drawing.Size(120, 37)
        Me.btn_elegir.TabIndex = 11
        Me.btn_elegir.Text = "Seleccionar"
        '
        'cbox_clientes
        '
        Me.cbox_clientes.BackColor = System.Drawing.Color.Transparent
        Me.cbox_clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbox_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_clientes.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbox_clientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbox_clientes.FocusedState.Parent = Me.cbox_clientes
        Me.cbox_clientes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbox_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbox_clientes.HoverState.Parent = Me.cbox_clientes
        Me.cbox_clientes.ItemHeight = 30
        Me.cbox_clientes.ItemsAppearance.Parent = Me.cbox_clientes
        Me.cbox_clientes.Location = New System.Drawing.Point(272, 162)
        Me.cbox_clientes.Name = "cbox_clientes"
        Me.cbox_clientes.ShadowDecoration.Parent = Me.cbox_clientes
        Me.cbox_clientes.Size = New System.Drawing.Size(303, 36)
        Me.cbox_clientes.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.CheckedState.Parent = Me.btnBuscar
        Me.btnBuscar.CustomImages.Parent = Me.btnBuscar
        Me.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBuscar.DisabledState.Parent = Me.btnBuscar
        Me.btnBuscar.FillColor = System.Drawing.Color.SpringGreen
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.HoverState.Parent = Me.btnBuscar
        Me.btnBuscar.Location = New System.Drawing.Point(615, 102)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.ShadowDecoration.Parent = Me.btnBuscar
        Me.btnBuscar.Size = New System.Drawing.Size(120, 37)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreBuscar.DefaultText = ""
        Me.txtNombreBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreBuscar.DisabledState.Parent = Me.txtNombreBuscar
        Me.txtNombreBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreBuscar.FocusedState.Parent = Me.txtNombreBuscar
        Me.txtNombreBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreBuscar.HoverState.Parent = Me.txtNombreBuscar
        Me.txtNombreBuscar.Location = New System.Drawing.Point(272, 102)
        Me.txtNombreBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreBuscar.PlaceholderText = ""
        Me.txtNombreBuscar.SelectedText = ""
        Me.txtNombreBuscar.ShadowDecoration.Parent = Me.txtNombreBuscar
        Me.txtNombreBuscar.Size = New System.Drawing.Size(303, 37)
        Me.txtNombreBuscar.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(264, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(278, 45)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Modificar Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnumerot)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 221)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(607, 317)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'txtnumerot
        '
        Me.txtnumerot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnumerot.DefaultText = ""
        Me.txtnumerot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnumerot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnumerot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumerot.DisabledState.Parent = Me.txtnumerot
        Me.txtnumerot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnumerot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumerot.FocusedState.Parent = Me.txtnumerot
        Me.txtnumerot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnumerot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnumerot.HoverState.Parent = Me.txtnumerot
        Me.txtnumerot.Location = New System.Drawing.Point(246, 223)
        Me.txtnumerot.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumerot.Name = "txtnumerot"
        Me.txtnumerot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnumerot.PlaceholderText = ""
        Me.txtnumerot.SelectedText = ""
        Me.txtnumerot.ShadowDecoration.Parent = Me.txtnumerot
        Me.txtnumerot.Size = New System.Drawing.Size(241, 37)
        Me.txtnumerot.TabIndex = 22
        '
        'txtemail
        '
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.Parent = Me.txtemail
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.FocusedState.Parent = Me.txtemail
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemail.HoverState.Parent = Me.txtemail
        Me.txtemail.Location = New System.Drawing.Point(246, 162)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderText = ""
        Me.txtemail.SelectedText = ""
        Me.txtemail.ShadowDecoration.Parent = Me.txtemail
        Me.txtemail.Size = New System.Drawing.Size(241, 37)
        Me.txtemail.TabIndex = 23
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
        Me.txtNombre.Location = New System.Drawing.Point(246, 24)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.ShadowDecoration.Parent = Me.txtNombre
        Me.txtNombre.Size = New System.Drawing.Size(241, 37)
        Me.txtNombre.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(31, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Codigo de la empresa:"
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
        Me.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApellido.HoverState.Parent = Me.txtApellido
        Me.txtApellido.Location = New System.Drawing.Point(246, 95)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.PlaceholderText = ""
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.ShadowDecoration.Parent = Me.txtApellido
        Me.txtApellido.Size = New System.Drawing.Size(241, 37)
        Me.txtApellido.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(31, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Numero de Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(31, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "E-mail:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(31, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre de la empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(96, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elija su usuario :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Usuario"
        '
        'ModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 690)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModificarCliente"
        Me.Text = "ModificarCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbox_clientes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_Modificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_elegir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtnumerot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtApellido As Guna.UI2.WinForms.Guna2TextBox
End Class
