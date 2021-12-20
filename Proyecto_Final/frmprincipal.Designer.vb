<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem, Me.CrearInventarioToolStripMenuItem, Me.CrearClientesToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.ModificarClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(918, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear  Usuario"
        '
        'CrearInventarioToolStripMenuItem
        '
        Me.CrearInventarioToolStripMenuItem.Name = "CrearInventarioToolStripMenuItem"
        Me.CrearInventarioToolStripMenuItem.Size = New System.Drawing.Size(215, 20)
        Me.CrearInventarioToolStripMenuItem.Text = "Crear Producto /  Registrar inventario"
        '
        'CrearClientesToolStripMenuItem
        '
        Me.CrearClientesToolStripMenuItem.Name = "CrearClientesToolStripMenuItem"
        Me.CrearClientesToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CrearClientesToolStripMenuItem.Text = "Crear Cliente"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'ModificarClientesToolStripMenuItem
        '
        Me.ModificarClientesToolStripMenuItem.Name = "ModificarClientesToolStripMenuItem"
        Me.ModificarClientesToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.ModificarClientesToolStripMenuItem.Text = "ModificarClientes"
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 531)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmprincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CrearInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClientesToolStripMenuItem As ToolStripMenuItem
End Class
