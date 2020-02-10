<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminDepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaToolStripMenuItem, Me.AdminToolStripMenuItem, Me.SesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepositosToolStripMenuItem, Me.StockToolStripMenuItem, Me.CajaToolStripMenuItem, Me.SimulacionToolStripMenuItem})
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProgramaToolStripMenuItem.Text = "Programa"
        '
        'DepositosToolStripMenuItem
        '
        Me.DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem"
        Me.DepositosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DepositosToolStripMenuItem.Text = "Depositos"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'SimulacionToolStripMenuItem
        '
        Me.SimulacionToolStripMenuItem.Name = "SimulacionToolStripMenuItem"
        Me.SimulacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SimulacionToolStripMenuItem.Text = "Simulacion"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminUsuariosToolStripMenuItem, Me.AdminProductosToolStripMenuItem, Me.AdminDepositosToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        Me.AdminToolStripMenuItem.Visible = False
        '
        'AdminUsuariosToolStripMenuItem
        '
        Me.AdminUsuariosToolStripMenuItem.Name = "AdminUsuariosToolStripMenuItem"
        Me.AdminUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdminUsuariosToolStripMenuItem.Text = "Admin Usuarios"
        '
        'AdminProductosToolStripMenuItem
        '
        Me.AdminProductosToolStripMenuItem.Name = "AdminProductosToolStripMenuItem"
        Me.AdminProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdminProductosToolStripMenuItem.Text = "Admin Productos"
        '
        'AdminDepositosToolStripMenuItem
        '
        Me.AdminDepositosToolStripMenuItem.Name = "AdminDepositosToolStripMenuItem"
        Me.AdminDepositosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdminDepositosToolStripMenuItem.Text = "Admin Depositos"
        '
        'SesionToolStripMenuItem
        '
        Me.SesionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SesionToolStripMenuItem.Name = "SesionToolStripMenuItem"
        Me.SesionToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SesionToolStripMenuItem.Text = "Sesion"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminDepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
