<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfacturacion
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
        Me.cbo_clientes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.p1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelFacturacion = New System.Windows.Forms.Panel()
        Me.btnimprimir = New Guna.UI2.WinForms.Guna2Button()
        Me.facturacionpanel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nud_cantidades = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnagregar = New Guna.UI2.WinForms.Guna2Button()
        Me.cbo_productos = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.facturacionpanel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnseleccionar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.facturacionpanel3.SuspendLayout()
        CType(Me.nud_cantidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.facturacionpanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_clientes
        '
        Me.cbo_clientes.BackColor = System.Drawing.Color.Transparent
        Me.cbo_clientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_clientes.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_clientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_clientes.FocusedState.Parent = Me.cbo_clientes
        Me.cbo_clientes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_clientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbo_clientes.HoverState.Parent = Me.cbo_clientes
        Me.cbo_clientes.ItemHeight = 30
        Me.cbo_clientes.ItemsAppearance.Parent = Me.cbo_clientes
        Me.cbo_clientes.Location = New System.Drawing.Point(117, 17)
        Me.cbo_clientes.Name = "cbo_clientes"
        Me.cbo_clientes.ShadowDecoration.Parent = Me.cbo_clientes
        Me.cbo_clientes.Size = New System.Drawing.Size(221, 36)
        Me.cbo_clientes.TabIndex = 0
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p1.Controls.Add(Me.panelFacturacion)
        Me.p1.Controls.Add(Me.btnimprimir)
        Me.p1.Controls.Add(Me.facturacionpanel3)
        Me.p1.Controls.Add(Me.facturacionpanel2)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(53, 34)
        Me.p1.Name = "p1"
        Me.p1.ShadowDecoration.Parent = Me.p1
        Me.p1.Size = New System.Drawing.Size(611, 534)
        Me.p1.TabIndex = 1
        '
        'panelFacturacion
        '
        Me.panelFacturacion.Location = New System.Drawing.Point(3, 6)
        Me.panelFacturacion.Name = "panelFacturacion"
        Me.panelFacturacion.Size = New System.Drawing.Size(611, 528)
        Me.panelFacturacion.TabIndex = 2
        Me.panelFacturacion.Visible = False
        '
        'btnimprimir
        '
        Me.btnimprimir.CheckedState.Parent = Me.btnimprimir
        Me.btnimprimir.CustomImages.Parent = Me.btnimprimir
        Me.btnimprimir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnimprimir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnimprimir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnimprimir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnimprimir.DisabledState.Parent = Me.btnimprimir
        Me.btnimprimir.FillColor = System.Drawing.Color.SpringGreen
        Me.btnimprimir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.ForeColor = System.Drawing.Color.Black
        Me.btnimprimir.HoverState.Parent = Me.btnimprimir
        Me.btnimprimir.Location = New System.Drawing.Point(402, 433)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.ShadowDecoration.Parent = Me.btnimprimir
        Me.btnimprimir.Size = New System.Drawing.Size(134, 36)
        Me.btnimprimir.TabIndex = 5
        Me.btnimprimir.Text = "Imprimir Factura"
        '
        'facturacionpanel3
        '
        Me.facturacionpanel3.Controls.Add(Me.lbl_precio)
        Me.facturacionpanel3.Controls.Add(Me.Label4)
        Me.facturacionpanel3.Controls.Add(Me.Label5)
        Me.facturacionpanel3.Controls.Add(Me.nud_cantidades)
        Me.facturacionpanel3.Controls.Add(Me.btnagregar)
        Me.facturacionpanel3.Controls.Add(Me.cbo_productos)
        Me.facturacionpanel3.Controls.Add(Me.Label3)
        Me.facturacionpanel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturacionpanel3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.facturacionpanel3.Location = New System.Drawing.Point(45, 190)
        Me.facturacionpanel3.Name = "facturacionpanel3"
        Me.facturacionpanel3.ShadowDecoration.Parent = Me.facturacionpanel3
        Me.facturacionpanel3.Size = New System.Drawing.Size(514, 227)
        Me.facturacionpanel3.TabIndex = 4
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(417, 112)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(67, 30)
        Me.lbl_precio.TabIndex = 8
        Me.lbl_precio.Text = "00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 30)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad disponible"
        '
        'nud_cantidades
        '
        Me.nud_cantidades.BackColor = System.Drawing.Color.Transparent
        Me.nud_cantidades.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nud_cantidades.DisabledState.Parent = Me.nud_cantidades
        Me.nud_cantidades.FocusedState.Parent = Me.nud_cantidades
        Me.nud_cantidades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nud_cantidades.ForeColor = System.Drawing.Color.Black
        Me.nud_cantidades.Location = New System.Drawing.Point(391, 61)
        Me.nud_cantidades.Name = "nud_cantidades"
        Me.nud_cantidades.ShadowDecoration.Parent = Me.nud_cantidades
        Me.nud_cantidades.Size = New System.Drawing.Size(100, 36)
        Me.nud_cantidades.TabIndex = 4
        Me.nud_cantidades.UpDownButtonFillColor = System.Drawing.Color.SpringGreen
        '
        'btnagregar
        '
        Me.btnagregar.CheckedState.Parent = Me.btnagregar
        Me.btnagregar.CustomImages.Parent = Me.btnagregar
        Me.btnagregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnagregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnagregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnagregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnagregar.DisabledState.Parent = Me.btnagregar
        Me.btnagregar.FillColor = System.Drawing.Color.SpringGreen
        Me.btnagregar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnagregar.ForeColor = System.Drawing.Color.Black
        Me.btnagregar.HoverState.Parent = Me.btnagregar
        Me.btnagregar.Location = New System.Drawing.Point(357, 176)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.ShadowDecoration.Parent = Me.btnagregar
        Me.btnagregar.Size = New System.Drawing.Size(134, 36)
        Me.btnagregar.TabIndex = 2
        Me.btnagregar.Text = "Agregar"
        '
        'cbo_productos
        '
        Me.cbo_productos.BackColor = System.Drawing.Color.Transparent
        Me.cbo_productos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_productos.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_productos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbo_productos.FocusedState.Parent = Me.cbo_productos
        Me.cbo_productos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbo_productos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbo_productos.HoverState.Parent = Me.cbo_productos
        Me.cbo_productos.ItemHeight = 30
        Me.cbo_productos.ItemsAppearance.Parent = Me.cbo_productos
        Me.cbo_productos.Location = New System.Drawing.Point(259, 13)
        Me.cbo_productos.Name = "cbo_productos"
        Me.cbo_productos.ShadowDecoration.Parent = Me.cbo_productos
        Me.cbo_productos.Size = New System.Drawing.Size(232, 36)
        Me.cbo_productos.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lista de Productos"
        '
        'facturacionpanel2
        '
        Me.facturacionpanel2.Controls.Add(Me.btnseleccionar)
        Me.facturacionpanel2.Controls.Add(Me.cbo_clientes)
        Me.facturacionpanel2.Controls.Add(Me.Label2)
        Me.facturacionpanel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturacionpanel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.facturacionpanel2.Location = New System.Drawing.Point(45, 109)
        Me.facturacionpanel2.Name = "facturacionpanel2"
        Me.facturacionpanel2.ShadowDecoration.Parent = Me.facturacionpanel2
        Me.facturacionpanel2.Size = New System.Drawing.Size(514, 75)
        Me.facturacionpanel2.TabIndex = 3
        '
        'btnseleccionar
        '
        Me.btnseleccionar.CheckedState.Parent = Me.btnseleccionar
        Me.btnseleccionar.CustomImages.Parent = Me.btnseleccionar
        Me.btnseleccionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnseleccionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnseleccionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnseleccionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnseleccionar.DisabledState.Parent = Me.btnseleccionar
        Me.btnseleccionar.FillColor = System.Drawing.Color.SpringGreen
        Me.btnseleccionar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnseleccionar.ForeColor = System.Drawing.Color.Black
        Me.btnseleccionar.HoverState.Parent = Me.btnseleccionar
        Me.btnseleccionar.Location = New System.Drawing.Point(357, 17)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.ShadowDecoration.Parent = Me.btnseleccionar
        Me.btnseleccionar.Size = New System.Drawing.Size(134, 36)
        Me.btnseleccionar.TabIndex = 3
        Me.btnseleccionar.Text = "Seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(217, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Facturacion"
        '
        'frmfacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 615)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmfacturacion"
        Me.Text = "frmfacturacion"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.facturacionpanel3.ResumeLayout(False)
        Me.facturacionpanel3.PerformLayout()
        CType(Me.nud_cantidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.facturacionpanel2.ResumeLayout(False)
        Me.facturacionpanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbo_clientes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents p1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents facturacionpanel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents nud_cantidades As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnagregar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbo_productos As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents facturacionpanel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnseleccionar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnimprimir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_precio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panelFacturacion As Panel
End Class
