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
        Me.CrearClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearClienteToolStripMenuItem, Me.CrearToolStripMenuItem, Me.RegistrarInventarioToolStripMenuItem, Me.CrearClientesToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.ModificarClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearClienteToolStripMenuItem
        '
        Me.CrearClienteToolStripMenuItem.Name = "CrearClienteToolStripMenuItem"
        Me.CrearClienteToolStripMenuItem.Size = New System.Drawing.Size(14, 24)
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(122, 24)
        Me.CrearToolStripMenuItem.Text = "Crear Producto"
        '
        'RegistrarInventarioToolStripMenuItem
        '
        Me.RegistrarInventarioToolStripMenuItem.Name = "RegistrarInventarioToolStripMenuItem"
        Me.RegistrarInventarioToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RegistrarInventarioToolStripMenuItem.Text = "Registrar Inventario"
        '
        'CrearClientesToolStripMenuItem
        '
        Me.CrearClientesToolStripMenuItem.Name = "CrearClientesToolStripMenuItem"
        Me.CrearClientesToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.CrearClientesToolStripMenuItem.Text = "Crear Cliente"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'ModificarClientesToolStripMenuItem
        '
        Me.ModificarClientesToolStripMenuItem.Name = "ModificarClientesToolStripMenuItem"
        Me.ModificarClientesToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.ModificarClientesToolStripMenuItem.Text = "Modificar clientes"
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmprincipal"
        Me.Text = "frmprincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClientesToolStripMenuItem As ToolStripMenuItem
End Class
