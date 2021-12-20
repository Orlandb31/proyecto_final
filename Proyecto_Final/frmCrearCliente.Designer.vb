<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearCliente
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
        Me.p1 = New System.Windows.Forms.Panel()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncrear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtnumerot = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtubicacion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p1.Controls.Add(Me.txtcod)
        Me.p1.Controls.Add(Me.Label6)
        Me.p1.Controls.Add(Me.btncrear)
        Me.p1.Controls.Add(Me.txtnumerot)
        Me.p1.Controls.Add(Me.txtemail)
        Me.p1.Controls.Add(Me.txtubicacion)
        Me.p1.Controls.Add(Me.txtnombre)
        Me.p1.Controls.Add(Me.Label5)
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(29, 48)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(573, 461)
        Me.p1.TabIndex = 12
        '
        'txtcod
        '
        Me.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcod.Location = New System.Drawing.Point(266, 116)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(263, 20)
        Me.txtcod.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(48, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Codigo de la empresa:"
        '
        'btncrear
        '
        Me.btncrear.CheckedState.Parent = Me.btncrear
        Me.btncrear.CustomImages.Parent = Me.btncrear
        Me.btncrear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncrear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncrear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncrear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncrear.DisabledState.Parent = Me.btncrear
        Me.btncrear.FillColor = System.Drawing.Color.SpringGreen
        Me.btncrear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.Color.Black
        Me.btncrear.HoverState.Parent = Me.btncrear
        Me.btncrear.Location = New System.Drawing.Point(192, 378)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.ShadowDecoration.Parent = Me.btncrear
        Me.btncrear.Size = New System.Drawing.Size(180, 45)
        Me.btncrear.TabIndex = 21
        Me.btncrear.Text = "Crear"
        '
        'txtnumerot
        '
        Me.txtnumerot.BackColor = System.Drawing.SystemColors.Window
        Me.txtnumerot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumerot.CausesValidation = False
        Me.txtnumerot.Location = New System.Drawing.Point(266, 330)
        Me.txtnumerot.Name = "txtnumerot"
        Me.txtnumerot.Size = New System.Drawing.Size(263, 20)
        Me.txtnumerot.TabIndex = 20
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.CausesValidation = False
        Me.txtemail.Location = New System.Drawing.Point(266, 276)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(263, 20)
        Me.txtemail.TabIndex = 19
        '
        'txtubicacion
        '
        Me.txtubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtubicacion.CausesValidation = False
        Me.txtubicacion.Location = New System.Drawing.Point(266, 219)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(263, 20)
        Me.txtubicacion.TabIndex = 18
        '
        'txtnombre
        '
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.CausesValidation = False
        Me.txtnombre.Location = New System.Drawing.Point(266, 168)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(263, 20)
        Me.txtnombre.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(48, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Numero de Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(48, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(48, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ubicacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(48, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre de la empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(85, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Agregar un Nuevo Cliente"
        '
        'frmCrearCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 552)
        Me.Controls.Add(Me.p1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCrearC"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Panel
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btncrear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtnumerot As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtubicacion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
