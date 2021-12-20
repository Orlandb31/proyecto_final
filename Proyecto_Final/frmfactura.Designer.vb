<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfactura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_cerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_itbms = New System.Windows.Forms.Label()
        Me.lbl_toal = New System.Windows.Forms.Label()
        Me.lbl_monto = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtg_compras = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_ncliente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_nfactura = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dtg_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btn_cerrar)
        Me.Guna2Panel1.Controls.Add(Me.lbl_itbms)
        Me.Guna2Panel1.Controls.Add(Me.lbl_toal)
        Me.Guna2Panel1.Controls.Add(Me.lbl_monto)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.dtg_compras)
        Me.Guna2Panel1.Controls.Add(Me.lbl_email)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.lbl_telefono)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.lbl_ncliente)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.lbl_nombre)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.lbl_nfactura)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Panel1.Location = New System.Drawing.Point(43, 38)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(550, 430)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btn_cerrar
        '
        Me.btn_cerrar.CheckedState.Parent = Me.btn_cerrar
        Me.btn_cerrar.CustomImages.Parent = Me.btn_cerrar
        Me.btn_cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cerrar.DisabledState.Parent = Me.btn_cerrar
        Me.btn_cerrar.FillColor = System.Drawing.Color.SpringGreen
        Me.btn_cerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.HoverState.Parent = Me.btn_cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(337, 354)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.ShadowDecoration.Parent = Me.btn_cerrar
        Me.btn_cerrar.Size = New System.Drawing.Size(150, 33)
        Me.btn_cerrar.TabIndex = 18
        Me.btn_cerrar.Text = "Cerrar"
        '
        'lbl_itbms
        '
        Me.lbl_itbms.AutoSize = True
        Me.lbl_itbms.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_itbms.Location = New System.Drawing.Point(372, 309)
        Me.lbl_itbms.Name = "lbl_itbms"
        Me.lbl_itbms.Size = New System.Drawing.Size(58, 20)
        Me.lbl_itbms.TabIndex = 17
        Me.lbl_itbms.Text = "*******"
        '
        'lbl_toal
        '
        Me.lbl_toal.AutoSize = True
        Me.lbl_toal.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_toal.Location = New System.Drawing.Point(183, 354)
        Me.lbl_toal.Name = "lbl_toal"
        Me.lbl_toal.Size = New System.Drawing.Size(64, 20)
        Me.lbl_toal.TabIndex = 16
        Me.lbl_toal.Text = "*****/**"
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monto.Location = New System.Drawing.Point(183, 309)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(72, 20)
        Me.lbl_monto.TabIndex = 15
        Me.lbl_monto.Text = "*********"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(61, 354)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total a Pagar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(289, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "ITBMS:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(61, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total neto:"
        '
        'dtg_compras
        '
        Me.dtg_compras.AllowUserToAddRows = False
        Me.dtg_compras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtg_compras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtg_compras.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dtg_compras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_compras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_compras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_compras.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_compras.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_compras.EnableHeadersVisualStyles = False
        Me.dtg_compras.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_compras.Location = New System.Drawing.Point(67, 152)
        Me.dtg_compras.Name = "dtg_compras"
        Me.dtg_compras.ReadOnly = True
        Me.dtg_compras.RowHeadersVisible = False
        Me.dtg_compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_compras.Size = New System.Drawing.Size(420, 142)
        Me.dtg_compras.TabIndex = 11
        Me.dtg_compras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_compras.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtg_compras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtg_compras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtg_compras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtg_compras.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dtg_compras.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_compras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_compras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtg_compras.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_compras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_compras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtg_compras.ThemeStyle.HeaderStyle.Height = 4
        Me.dtg_compras.ThemeStyle.ReadOnly = True
        Me.dtg_compras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtg_compras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_compras.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dtg_compras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.dtg_compras.ThemeStyle.RowsStyle.Height = 22
        Me.dtg_compras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtg_compras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(150, 129)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(142, 20)
        Me.lbl_email.TabIndex = 10
        Me.lbl_email.Text = "*******************"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "E-Mail:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono.Location = New System.Drawing.Point(392, 100)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(59, 20)
        Me.lbl_telefono.TabIndex = 8
        Me.lbl_telefono.Text = "+++++"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(291, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nº Telefono:"
        '
        'lbl_ncliente
        '
        Me.lbl_ncliente.AutoSize = True
        Me.lbl_ncliente.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ncliente.Location = New System.Drawing.Point(150, 100)
        Me.lbl_ncliente.Name = "lbl_ncliente"
        Me.lbl_ncliente.Size = New System.Drawing.Size(51, 20)
        Me.lbl_ncliente.TabIndex = 6
        Me.lbl_ncliente.Text = "******"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Cliente:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(357, 66)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(128, 20)
        Me.lbl_nombre.TabIndex = 4
        Me.lbl_nombre.Text = "*****************"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'lbl_nfactura
        '
        Me.lbl_nfactura.AutoSize = True
        Me.lbl_nfactura.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nfactura.Location = New System.Drawing.Point(95, 66)
        Me.lbl_nfactura.Name = "lbl_nfactura"
        Me.lbl_nfactura.Size = New System.Drawing.Size(30, 20)
        Me.lbl_nfactura.TabIndex = 2
        Me.lbl_nfactura.Text = "***"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura"
        '
        'frmfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmfactura"
        Me.Text = "frmfactura"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dtg_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_nfactura As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_itbms As Label
    Friend WithEvents lbl_toal As Label
    Friend WithEvents lbl_monto As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtg_compras As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_ncliente As Label
    Friend WithEvents Label6 As Label
End Class
