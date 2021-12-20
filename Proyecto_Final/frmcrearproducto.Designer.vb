<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcrearproducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Numeric1 = New System.Windows.Forms.NumericUpDown()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncrear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Numeric1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(344, 116)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(350, 34)
        Me.txtnombre.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(344, 186)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(350, 34)
        Me.txtprecio.TabIndex = 4
        '
        'Numeric1
        '
        Me.Numeric1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numeric1.Location = New System.Drawing.Point(344, 249)
        Me.Numeric1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Numeric1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Numeric1.Name = "Numeric1"
        Me.Numeric1.Size = New System.Drawing.Size(350, 34)
        Me.Numeric1.TabIndex = 5
        Me.Numeric1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(344, 322)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(350, 34)
        Me.txtdescripcion.TabIndex = 8
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.txtdescripcion)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.btncrear)
        Me.Guna2Panel1.Controls.Add(Me.txtnombre)
        Me.Guna2Panel1.Controls.Add(Me.txtprecio)
        Me.Guna2Panel1.Controls.Add(Me.Numeric1)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Location = New System.Drawing.Point(170, 111)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(737, 521)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(53, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nombre-Producto:"
        '
        'btncrear
        '
        Me.btncrear.BorderColor = System.Drawing.Color.White
        Me.btncrear.CheckedState.Parent = Me.btncrear
        Me.btncrear.CustomImages.Parent = Me.btncrear
        Me.btncrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncrear.DisabledState.Parent = Me.btncrear
        Me.btncrear.FillColor = System.Drawing.Color.SpringGreen
        Me.btncrear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btncrear.HoverState.Parent = Me.btncrear
        Me.btncrear.Location = New System.Drawing.Point(237, 422)
        Me.btncrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.ShadowDecoration.Parent = Me.btncrear
        Me.btncrear.Size = New System.Drawing.Size(240, 55)
        Me.btncrear.TabIndex = 9
        Me.btncrear.Text = "Registrar Producto "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(53, 322)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 28)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Descripcion Del Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(53, 249)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cantidad-Disponible"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(53, 186)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 28)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(4, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(728, 54)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Crear Producto y Registrar Inventario"
        '
        'frmcrearproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 804)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "frmcrearproducto"
        Me.Text = "frmcrearproducto"
        CType(Me.Numeric1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Numeric1 As NumericUpDown
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btncrear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
