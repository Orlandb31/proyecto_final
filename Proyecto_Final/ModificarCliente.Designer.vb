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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_clientes = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_elegir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_elegir)
        Me.Panel1.Controls.Add(Me.btn_Modificar)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbox_clientes)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtNombreBuscar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(84, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 450)
        Me.Panel1.TabIndex = 0
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(255, 397)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(113, 28)
        Me.btn_Modificar.TabIndex = 6
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(27, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 201)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elija su usuario"
        '
        'cbox_clientes
        '
        Me.cbox_clientes.FormattingEnabled = True
        Me.cbox_clientes.Location = New System.Drawing.Point(144, 126)
        Me.cbox_clientes.Name = "cbox_clientes"
        Me.cbox_clientes.Size = New System.Drawing.Size(285, 24)
        Me.cbox_clientes.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(464, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(107, 22)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Location = New System.Drawing.Point(178, 41)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(217, 22)
        Me.txtNombreBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Usuario"
        '
        'btn_elegir
        '
        Me.btn_elegir.Location = New System.Drawing.Point(480, 119)
        Me.btn_elegir.Name = "btn_elegir"
        Me.btn_elegir.Size = New System.Drawing.Size(75, 37)
        Me.btn_elegir.TabIndex = 7
        Me.btn_elegir.Text = "Elegir"
        Me.btn_elegir.UseVisualStyleBackColor = True
        '
        'ModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModificarCliente"
        Me.Text = "ModificarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbox_clientes As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNombreBuscar As TextBox
    Friend WithEvents btn_elegir As Button
End Class
