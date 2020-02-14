<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPV
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
        Me.components = New System.ComponentModel.Container()
        Me.MSMain = New System.Windows.Forms.MenuStrip()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerListaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cerrar_SesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbFechaHora = New System.Windows.Forms.Label()
        Me.TxBUsuarioConectado = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnComida = New System.Windows.Forms.Button()
        Me.btnBebida = New System.Windows.Forms.Button()
        Me.btnMotor = New System.Windows.Forms.Button()
        Me.btnGas = New System.Windows.Forms.Button()
        Me.flpProductos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btnImprimirTicket = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnBorrarLinea = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnEliminar1 = New System.Windows.Forms.Button()
        Me.btnNuevoTicket = New System.Windows.Forms.Button()
        Me.TanquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MSMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMain
        '
        Me.MSMain.Font = New System.Drawing.Font("Segoe UI", 16.5!)
        Me.MSMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.TanquesToolStripMenuItem, Me.Cerrar_SesionToolStripMenuItem})
        Me.MSMain.Location = New System.Drawing.Point(0, 0)
        Me.MSMain.Name = "MSMain"
        Me.MSMain.Padding = New System.Windows.Forms.Padding(13, 4, 0, 4)
        Me.MSMain.Size = New System.Drawing.Size(1342, 42)
        Me.MSMain.TabIndex = 17
        Me.MSMain.Text = "MenuStrip1"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(129, 34)
        Me.CajaToolStripMenuItem.Text = "Cerrar caja"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUToolStripMenuItem, Me.ToolStripSeparator1, Me.VerListaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(107, 34)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoUToolStripMenuItem
        '
        Me.NuevoUToolStripMenuItem.Name = "NuevoUToolStripMenuItem"
        Me.NuevoUToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.NuevoUToolStripMenuItem.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'VerListaToolStripMenuItem
        '
        Me.VerListaToolStripMenuItem.Name = "VerListaToolStripMenuItem"
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(180, 34)
        Me.VerListaToolStripMenuItem.Text = "Ver lista"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.VerListaToolStripMenuItem1})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(122, 34)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'VerListaToolStripMenuItem1
        '
        Me.VerListaToolStripMenuItem1.Name = "VerListaToolStripMenuItem1"
        Me.VerListaToolStripMenuItem1.Size = New System.Drawing.Size(180, 34)
        Me.VerListaToolStripMenuItem1.Text = "Ver lista"
        '
        'Cerrar_SesionToolStripMenuItem
        '
        Me.Cerrar_SesionToolStripMenuItem.Name = "Cerrar_SesionToolStripMenuItem"
        Me.Cerrar_SesionToolStripMenuItem.Size = New System.Drawing.Size(152, 34)
        Me.Cerrar_SesionToolStripMenuItem.Text = "Cerrar sesión"
        '
        'LbFechaHora
        '
        Me.LbFechaHora.AutoSize = True
        Me.LbFechaHora.Location = New System.Drawing.Point(226, 51)
        Me.LbFechaHora.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LbFechaHora.Name = "LbFechaHora"
        Me.LbFechaHora.Size = New System.Drawing.Size(135, 26)
        Me.LbFechaHora.TabIndex = 28
        Me.LbFechaHora.Text = "Hora y fecha"
        '
        'TxBUsuarioConectado
        '
        Me.TxBUsuarioConectado.Location = New System.Drawing.Point(16, 48)
        Me.TxBUsuarioConectado.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TxBUsuarioConectado.Name = "TxBUsuarioConectado"
        Me.TxBUsuarioConectado.ReadOnly = True
        Me.TxBUsuarioConectado.Size = New System.Drawing.Size(196, 32)
        Me.TxBUsuarioConectado.TabIndex = 27
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 89)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(425, 457)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnComida
        '
        Me.btnComida.Location = New System.Drawing.Point(780, 65)
        Me.btnComida.Name = "btnComida"
        Me.btnComida.Size = New System.Drawing.Size(184, 105)
        Me.btnComida.TabIndex = 30
        Me.btnComida.Text = "Comida"
        Me.btnComida.UseVisualStyleBackColor = True
        '
        'btnBebida
        '
        Me.btnBebida.Location = New System.Drawing.Point(970, 65)
        Me.btnBebida.Name = "btnBebida"
        Me.btnBebida.Size = New System.Drawing.Size(184, 105)
        Me.btnBebida.TabIndex = 31
        Me.btnBebida.Text = "Bebida"
        Me.btnBebida.UseVisualStyleBackColor = True
        '
        'btnMotor
        '
        Me.btnMotor.Location = New System.Drawing.Point(1160, 65)
        Me.btnMotor.Name = "btnMotor"
        Me.btnMotor.Size = New System.Drawing.Size(170, 105)
        Me.btnMotor.TabIndex = 32
        Me.btnMotor.Text = "Motor"
        Me.btnMotor.UseVisualStyleBackColor = True
        '
        'btnGas
        '
        Me.btnGas.Location = New System.Drawing.Point(590, 65)
        Me.btnGas.Name = "btnGas"
        Me.btnGas.Size = New System.Drawing.Size(184, 105)
        Me.btnGas.TabIndex = 33
        Me.btnGas.Text = "Combustible"
        Me.btnGas.UseVisualStyleBackColor = True
        '
        'flpProductos
        '
        Me.flpProductos.BackColor = System.Drawing.SystemColors.Control
        Me.flpProductos.Location = New System.Drawing.Point(590, 176)
        Me.flpProductos.Name = "flpProductos"
        Me.flpProductos.Size = New System.Drawing.Size(740, 561)
        Me.flpProductos.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 586)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 38)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Total:"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(158, 586)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(0, 38)
        Me.lbTotal.TabIndex = 36
        '
        'btnImprimirTicket
        '
        Me.btnImprimirTicket.Location = New System.Drawing.Point(16, 642)
        Me.btnImprimirTicket.Name = "btnImprimirTicket"
        Me.btnImprimirTicket.Size = New System.Drawing.Size(166, 95)
        Me.btnImprimirTicket.TabIndex = 37
        Me.btnImprimirTicket.Text = "Imprimir tiquet"
        Me.btnImprimirTicket.UseVisualStyleBackColor = True
        '
        'btnPago
        '
        Me.btnPago.Location = New System.Drawing.Point(188, 642)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(166, 95)
        Me.btnPago.TabIndex = 38
        Me.btnPago.Text = "Realizar pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnBorrarLinea
        '
        Me.btnBorrarLinea.Location = New System.Drawing.Point(447, 89)
        Me.btnBorrarLinea.Name = "btnBorrarLinea"
        Me.btnBorrarLinea.Size = New System.Drawing.Size(119, 76)
        Me.btnBorrarLinea.TabIndex = 39
        Me.btnBorrarLinea.Text = "Borrar linea"
        Me.btnBorrarLinea.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(447, 171)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(119, 76)
        Me.btnAdd1.TabIndex = 40
        Me.btnAdd1.Text = "+1"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(447, 253)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(119, 76)
        Me.btnEliminar1.TabIndex = 41
        Me.btnEliminar1.Text = "-1"
        Me.btnEliminar1.UseVisualStyleBackColor = True
        '
        'btnNuevoTicket
        '
        Me.btnNuevoTicket.Location = New System.Drawing.Point(447, 470)
        Me.btnNuevoTicket.Name = "btnNuevoTicket"
        Me.btnNuevoTicket.Size = New System.Drawing.Size(119, 76)
        Me.btnNuevoTicket.TabIndex = 42
        Me.btnNuevoTicket.Text = "Nuevo tiquet"
        Me.btnNuevoTicket.UseVisualStyleBackColor = True
        '
        'TanquesToolStripMenuItem
        '
        Me.TanquesToolStripMenuItem.Name = "TanquesToolStripMenuItem"
        Me.TanquesToolStripMenuItem.Size = New System.Drawing.Size(104, 34)
        Me.TanquesToolStripMenuItem.Text = "Tanques"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'TPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 749)
        Me.Controls.Add(Me.btnNuevoTicket)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.btnBorrarLinea)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.btnImprimirTicket)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flpProductos)
        Me.Controls.Add(Me.btnGas)
        Me.Controls.Add(Me.btnMotor)
        Me.Controls.Add(Me.btnBebida)
        Me.Controls.Add(Me.btnComida)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LbFechaHora)
        Me.Controls.Add(Me.TxBUsuarioConectado)
        Me.Controls.Add(Me.MSMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "TPV"
        Me.Text = "TPV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMain.ResumeLayout(False)
        Me.MSMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMain As MenuStrip
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents VerListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VerListaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Cerrar_SesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbFechaHora As Label
    Friend WithEvents TxBUsuarioConectado As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnComida As Button
    Friend WithEvents btnBebida As Button
    Friend WithEvents btnMotor As Button
    Friend WithEvents btnGas As Button
    Friend WithEvents flpProductos As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btnImprimirTicket As Button
    Friend WithEvents btnPago As Button
    Friend WithEvents btnBorrarLinea As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnEliminar1 As Button
    Friend WithEvents btnNuevoTicket As Button
    Friend WithEvents TanquesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
End Class
