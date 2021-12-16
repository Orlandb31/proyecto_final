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
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnseleccionar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnagregar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2NumericUpDown1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnimprimir = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(117, 3)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(221, 36)
        Me.Guna2ComboBox1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnimprimir)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(53, 34)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(551, 430)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Facturacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clientes"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnseleccionar)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 52)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(514, 55)
        Me.Guna2Panel2.TabIndex = 3
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
        Me.btnseleccionar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnseleccionar.ForeColor = System.Drawing.Color.White
        Me.btnseleccionar.HoverState.Parent = Me.btnseleccionar
        Me.btnseleccionar.Location = New System.Drawing.Point(357, 3)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.ShadowDecoration.Parent = Me.btnseleccionar
        Me.btnseleccionar.Size = New System.Drawing.Size(134, 36)
        Me.btnseleccionar.TabIndex = 3
        Me.btnseleccionar.Text = "Seleccionar"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2NumericUpDown1)
        Me.Guna2Panel3.Controls.Add(Me.btnagregar)
        Me.Guna2Panel3.Controls.Add(Me.Guna2ComboBox2)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(18, 133)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(514, 143)
        Me.Guna2Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lista de Productos"
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.HoverState.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.ItemsAppearance.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(36, 55)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.ShadowDecoration.Parent = Me.Guna2ComboBox2
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(232, 36)
        Me.Guna2ComboBox2.TabIndex = 1
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
        Me.btnagregar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnagregar.ForeColor = System.Drawing.Color.White
        Me.btnagregar.HoverState.Parent = Me.btnagregar
        Me.btnagregar.Location = New System.Drawing.Point(190, 97)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.ShadowDecoration.Parent = Me.btnagregar
        Me.btnagregar.Size = New System.Drawing.Size(134, 36)
        Me.btnagregar.TabIndex = 2
        Me.btnagregar.Text = "Agregar"
        '
        'Guna2NumericUpDown1
        '
        Me.Guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2NumericUpDown1.DisabledState.Parent = Me.Guna2NumericUpDown1
        Me.Guna2NumericUpDown1.FocusedState.Parent = Me.Guna2NumericUpDown1
        Me.Guna2NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.Guna2NumericUpDown1.Location = New System.Drawing.Point(321, 55)
        Me.Guna2NumericUpDown1.Name = "Guna2NumericUpDown1"
        Me.Guna2NumericUpDown1.ShadowDecoration.Parent = Me.Guna2NumericUpDown1
        Me.Guna2NumericUpDown1.Size = New System.Drawing.Size(100, 36)
        Me.Guna2NumericUpDown1.TabIndex = 4
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
        Me.btnimprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnimprimir.ForeColor = System.Drawing.Color.White
        Me.btnimprimir.HoverState.Parent = Me.btnimprimir
        Me.btnimprimir.Location = New System.Drawing.Point(375, 366)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.ShadowDecoration.Parent = Me.btnimprimir
        Me.btnimprimir.Size = New System.Drawing.Size(134, 36)
        Me.btnimprimir.TabIndex = 5
        Me.btnimprimir.Text = "Imprimir Factura"
        '
        'frmfacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmfacturacion"
        Me.Text = "frmfacturacion"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.Guna2NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2NumericUpDown1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnagregar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnseleccionar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnimprimir As Guna.UI2.WinForms.Guna2Button
End Class
