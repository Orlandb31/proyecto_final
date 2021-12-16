<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearC
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnombree = New System.Windows.Forms.TextBox()
        Me.txtubicacion = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnumerot = New System.Windows.Forms.TextBox()
        Me.btncrear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btncrear)
        Me.Guna2Panel1.Controls.Add(Me.txtnumerot)
        Me.Guna2Panel1.Controls.Add(Me.txtemail)
        Me.Guna2Panel1.Controls.Add(Me.txtubicacion)
        Me.Guna2Panel1.Controls.Add(Me.txtnombree)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(47, 36)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(553, 423)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(77, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar un Nuevo Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(36, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de la empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(36, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ubicacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(36, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(36, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numero de Telefono:"
        '
        'txtnombree
        '
        Me.txtnombree.Location = New System.Drawing.Point(254, 112)
        Me.txtnombree.Name = "txtnombree"
        Me.txtnombree.Size = New System.Drawing.Size(263, 20)
        Me.txtnombree.TabIndex = 5
        '
        'txtubicacion
        '
        Me.txtubicacion.Location = New System.Drawing.Point(254, 171)
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(263, 20)
        Me.txtubicacion.TabIndex = 6
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(254, 228)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(263, 20)
        Me.txtemail.TabIndex = 7
        '
        'txtnumerot
        '
        Me.txtnumerot.Location = New System.Drawing.Point(254, 291)
        Me.txtnumerot.Name = "txtnumerot"
        Me.txtnumerot.Size = New System.Drawing.Size(263, 20)
        Me.txtnumerot.TabIndex = 8
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
        Me.btncrear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btncrear.HoverState.Parent = Me.btncrear
        Me.btncrear.Location = New System.Drawing.Point(182, 346)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.ShadowDecoration.Parent = Me.btncrear
        Me.btncrear.Size = New System.Drawing.Size(180, 45)
        Me.btncrear.TabIndex = 9
        Me.btncrear.Text = "Crear"
        '
        'frmCrearC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearC"
        Me.Text = "frmCrearC"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btncrear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtnumerot As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtubicacion As TextBox
    Friend WithEvents txtnombree As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
