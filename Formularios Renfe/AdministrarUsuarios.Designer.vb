<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarUsuarios))
        Me.LEjemploCorreo = New System.Windows.Forms.Label()
        Me.LEjemploContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TBId = New System.Windows.Forms.TextBox()
        Me.LID = New System.Windows.Forms.Label()
        Me.CBRol = New System.Windows.Forms.ComboBox()
        Me.LRol = New System.Windows.Forms.Label()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBDNI = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrarTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaAvanzadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LEjemploCorreo
        '
        Me.LEjemploCorreo.AutoSize = True
        Me.LEjemploCorreo.Location = New System.Drawing.Point(82, 273)
        Me.LEjemploCorreo.Name = "LEjemploCorreo"
        Me.LEjemploCorreo.Size = New System.Drawing.Size(171, 13)
        Me.LEjemploCorreo.TabIndex = 50
        Me.LEjemploCorreo.Text = "Ejemplo: ejemple@montaditos.com"
        '
        'LEjemploContraseña
        '
        Me.LEjemploContraseña.AutoSize = True
        Me.LEjemploContraseña.Location = New System.Drawing.Point(251, 162)
        Me.LEjemploContraseña.Name = "LEjemploContraseña"
        Me.LEjemploContraseña.Size = New System.Drawing.Size(105, 13)
        Me.LEjemploContraseña.TabIndex = 49
        Me.LEjemploContraseña.Text = "Ejemplo: Ejemplo123"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(333, 80)
        Me.TBUsuario.MaxLength = 12
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TBUsuario.TabIndex = 28
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(284, 80)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(47, 13)
        Me.LUsuario.TabIndex = 48
        Me.LUsuario.Text = "Usuario*"
        '
        'TBId
        '
        Me.TBId.Enabled = False
        Me.TBId.Location = New System.Drawing.Point(100, 83)
        Me.TBId.MaxLength = 2
        Me.TBId.Name = "TBId"
        Me.TBId.ReadOnly = True
        Me.TBId.Size = New System.Drawing.Size(100, 20)
        Me.TBId.TabIndex = 47
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Location = New System.Drawing.Point(64, 83)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(22, 13)
        Me.LID.TabIndex = 46
        Me.LID.Text = "ID*"
        '
        'CBRol
        '
        Me.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBRol.FormattingEnabled = True
        Me.CBRol.Items.AddRange(New Object() {"Encargado", "Propietario ", "Vendedor"})
        Me.CBRol.Location = New System.Drawing.Point(333, 254)
        Me.CBRol.Name = "CBRol"
        Me.CBRol.Size = New System.Drawing.Size(121, 21)
        Me.CBRol.TabIndex = 41
        '
        'LRol
        '
        Me.LRol.AutoSize = True
        Me.LRol.BackColor = System.Drawing.Color.Transparent
        Me.LRol.Location = New System.Drawing.Point(300, 254)
        Me.LRol.Name = "LRol"
        Me.LRol.Size = New System.Drawing.Size(27, 13)
        Me.LRol.TabIndex = 45
        Me.LRol.Text = "Rol*"
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(100, 242)
        Me.TBCorreo.MaxLength = 25
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(153, 20)
        Me.TBCorreo.TabIndex = 40
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(333, 195)
        Me.TBTelefono.MaxLength = 9
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TBTelefono.TabIndex = 39
        '
        'TBDNI
        '
        Me.TBDNI.Location = New System.Drawing.Point(100, 195)
        Me.TBDNI.MaxLength = 9
        Me.TBDNI.Name = "TBDNI"
        Me.TBDNI.Size = New System.Drawing.Size(100, 20)
        Me.TBDNI.TabIndex = 37
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(100, 162)
        Me.TBContraseña.MaxLength = 15
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TBContraseña.TabIndex = 35
        Me.TBContraseña.UseSystemPasswordChar = True
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(333, 114)
        Me.TBApellido.MaxLength = 12
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBApellido.TabIndex = 33
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(100, 121)
        Me.TBNombre.MaxLength = 10
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 31
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.Location = New System.Drawing.Point(-3, 242)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(94, 13)
        Me.LCorreo.TabIndex = 38
        Me.LCorreo.Text = "Correo Electronico"
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(278, 198)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 36
        Me.LTelefono.Text = "Teléfono"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Location = New System.Drawing.Point(56, 195)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(30, 13)
        Me.LDNI.TabIndex = 34
        Me.LDNI.Text = "DNI*"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Location = New System.Drawing.Point(21, 162)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(65, 13)
        Me.LContraseña.TabIndex = 32
        Me.LContraseña.Text = "Contraseña*"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(251, 114)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(80, 13)
        Me.LApellido.TabIndex = 30
        Me.LApellido.Text = "Primer Apellido*"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(38, 121)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(48, 13)
        Me.LNombre.TabIndex = 29
        Me.LNombre.Text = "Nombre*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(685, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioTSMI, Me.ToolStripSeparator1, Me.GuardarTSMI, Me.ModificarTSMI, Me.ToolStripSeparator2, Me.BorrarTSMI, Me.ToolStripSeparator3, Me.BuscarToolStripMenuItem, Me.BusquedaAvanzadaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'NuevoUsuarioTSMI
        '
        Me.NuevoUsuarioTSMI.Name = "NuevoUsuarioTSMI"
        Me.NuevoUsuarioTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.NuevoUsuarioTSMI.Size = New System.Drawing.Size(193, 22)
        Me.NuevoUsuarioTSMI.Text = "Nuevo usuario"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'GuardarTSMI
        '
        Me.GuardarTSMI.Name = "GuardarTSMI"
        Me.GuardarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarTSMI.Size = New System.Drawing.Size(193, 22)
        Me.GuardarTSMI.Text = "Guardar"
        '
        'ModificarTSMI
        '
        Me.ModificarTSMI.Name = "ModificarTSMI"
        Me.ModificarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarTSMI.Size = New System.Drawing.Size(193, 22)
        Me.ModificarTSMI.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'BorrarTSMI
        '
        Me.BorrarTSMI.Name = "BorrarTSMI"
        Me.BorrarTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BorrarTSMI.Size = New System.Drawing.Size(193, 22)
        Me.BorrarTSMI.Text = "Borrar"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 31)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Administracion de Usuarios"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "G:\Proyesto 1.0\Ayuda usuario\Documento 2 (1).html"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 320)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(686, 206)
        Me.DataGridView1.TabIndex = 56
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(190, 6)
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'BusquedaAvanzadaToolStripMenuItem
        '
        Me.BusquedaAvanzadaToolStripMenuItem.Name = "BusquedaAvanzadaToolStripMenuItem"
        Me.BusquedaAvanzadaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BusquedaAvanzadaToolStripMenuItem.Text = "Busqueda Avanzada"
        '
        'AdministrarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(685, 538)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LEjemploCorreo)
        Me.Controls.Add(Me.LEjemploContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.TBId)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.CBRol)
        Me.Controls.Add(Me.LRol)
        Me.Controls.Add(Me.TBCorreo)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.TBDNI)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LCorreo)
        Me.Controls.Add(Me.LTelefono)
        Me.Controls.Add(Me.LDNI)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministrarUsuarios"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Administracion de usuarios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LEjemploCorreo As Label
    Friend WithEvents LEjemploContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents TBId As TextBox
    Friend WithEvents LID As Label
    Friend WithEvents CBRol As ComboBox
    Friend WithEvents LRol As Label
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GuardarTSMI As ToolStripMenuItem
    Friend WithEvents ModificarTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BorrarTSMI As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaAvanzadaToolStripMenuItem As ToolStripMenuItem
End Class
