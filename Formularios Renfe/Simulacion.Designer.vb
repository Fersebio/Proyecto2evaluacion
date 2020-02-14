<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simulacion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PBS1 = New System.Windows.Forms.PictureBox()
        Me.PBS4 = New System.Windows.Forms.PictureBox()
        Me.PBS3 = New System.Windows.Forms.PictureBox()
        Me.PBS2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBS4 = New System.Windows.Forms.RadioButton()
        Me.RBS3 = New System.Windows.Forms.RadioButton()
        Me.RBS2 = New System.Windows.Forms.RadioButton()
        Me.RBS1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBSacarManguera = New System.Windows.Forms.PictureBox()
        Me.PBAparcar = New System.Windows.Forms.PictureBox()
        Me.PBGuardarManguera = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTerminar = New System.Windows.Forms.Button()
        Me.BParar = New System.Windows.Forms.Button()
        Me.BIniciar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RBDieselPlus = New System.Windows.Forms.RadioButton()
        Me.RBDiesel = New System.Windows.Forms.RadioButton()
        Me.RBSP98 = New System.Windows.Forms.RadioButton()
        Me.RBSP95 = New System.Windows.Forms.RadioButton()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBLitros = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBS2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBSacarManguera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAparcar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBGuardarManguera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 72)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Llegada coche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(225, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 64)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Sacar Manguera"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(404, 337)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Repostar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(584, 332)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 68)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Introducir Manguera"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(758, 333)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 66)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Pagar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "---------->"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(679, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "---------->"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "---------->"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "---------->"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(465, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 71)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PBS1
        '
        Me.PBS1.Image = CType(resources.GetObject("PBS1.Image"), System.Drawing.Image)
        Me.PBS1.Location = New System.Drawing.Point(164, 69)
        Me.PBS1.Name = "PBS1"
        Me.PBS1.Size = New System.Drawing.Size(55, 71)
        Me.PBS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS1.TabIndex = 15
        Me.PBS1.TabStop = False
        Me.PBS1.Visible = False
        '
        'PBS4
        '
        Me.PBS4.Image = CType(resources.GetObject("PBS4.Image"), System.Drawing.Image)
        Me.PBS4.Location = New System.Drawing.Point(404, 189)
        Me.PBS4.Name = "PBS4"
        Me.PBS4.Size = New System.Drawing.Size(55, 71)
        Me.PBS4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS4.TabIndex = 16
        Me.PBS4.TabStop = False
        Me.PBS4.Visible = False
        '
        'PBS3
        '
        Me.PBS3.Image = CType(resources.GetObject("PBS3.Image"), System.Drawing.Image)
        Me.PBS3.Location = New System.Drawing.Point(404, 69)
        Me.PBS3.Name = "PBS3"
        Me.PBS3.Size = New System.Drawing.Size(55, 71)
        Me.PBS3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS3.TabIndex = 17
        Me.PBS3.TabStop = False
        Me.PBS3.Visible = False
        '
        'PBS2
        '
        Me.PBS2.Image = CType(resources.GetObject("PBS2.Image"), System.Drawing.Image)
        Me.PBS2.Location = New System.Drawing.Point(164, 189)
        Me.PBS2.Name = "PBS2"
        Me.PBS2.Size = New System.Drawing.Size(55, 71)
        Me.PBS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBS2.TabIndex = 18
        Me.PBS2.TabStop = False
        Me.PBS2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBS4)
        Me.Panel1.Controls.Add(Me.RBS3)
        Me.Panel1.Controls.Add(Me.RBS2)
        Me.Panel1.Controls.Add(Me.RBS1)
        Me.Panel1.Location = New System.Drawing.Point(625, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 150)
        Me.Panel1.TabIndex = 19
        '
        'RBS4
        '
        Me.RBS4.AutoSize = True
        Me.RBS4.Location = New System.Drawing.Point(99, 92)
        Me.RBS4.Name = "RBS4"
        Me.RBS4.Size = New System.Drawing.Size(70, 17)
        Me.RBS4.TabIndex = 3
        Me.RBS4.TabStop = True
        Me.RBS4.Text = "Surtidor 4"
        Me.RBS4.UseVisualStyleBackColor = True
        '
        'RBS3
        '
        Me.RBS3.AutoSize = True
        Me.RBS3.Location = New System.Drawing.Point(99, 17)
        Me.RBS3.Name = "RBS3"
        Me.RBS3.Size = New System.Drawing.Size(70, 17)
        Me.RBS3.TabIndex = 2
        Me.RBS3.TabStop = True
        Me.RBS3.Text = "Surtidor 3"
        Me.RBS3.UseVisualStyleBackColor = True
        '
        'RBS2
        '
        Me.RBS2.AutoSize = True
        Me.RBS2.Location = New System.Drawing.Point(3, 92)
        Me.RBS2.Name = "RBS2"
        Me.RBS2.Size = New System.Drawing.Size(70, 17)
        Me.RBS2.TabIndex = 1
        Me.RBS2.TabStop = True
        Me.RBS2.Text = "Surtidor 2"
        Me.RBS2.UseVisualStyleBackColor = True
        '
        'RBS1
        '
        Me.RBS1.AutoSize = True
        Me.RBS1.Location = New System.Drawing.Point(3, 17)
        Me.RBS1.Name = "RBS1"
        Me.RBS1.Size = New System.Drawing.Size(70, 17)
        Me.RBS1.TabIndex = 0
        Me.RBS1.TabStop = True
        Me.RBS1.Text = "Surtidor 1"
        Me.RBS1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(225, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(225, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(465, 69)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1266, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'PBSacarManguera
        '
        Me.PBSacarManguera.Enabled = False
        Me.PBSacarManguera.Image = CType(resources.GetObject("PBSacarManguera.Image"), System.Drawing.Image)
        Me.PBSacarManguera.Location = New System.Drawing.Point(896, 57)
        Me.PBSacarManguera.Name = "PBSacarManguera"
        Me.PBSacarManguera.Size = New System.Drawing.Size(292, 348)
        Me.PBSacarManguera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSacarManguera.TabIndex = 0
        Me.PBSacarManguera.TabStop = False
        Me.PBSacarManguera.Visible = False
        '
        'PBAparcar
        '
        Me.PBAparcar.Enabled = False
        Me.PBAparcar.Image = CType(resources.GetObject("PBAparcar.Image"), System.Drawing.Image)
        Me.PBAparcar.Location = New System.Drawing.Point(896, 57)
        Me.PBAparcar.Name = "PBAparcar"
        Me.PBAparcar.Size = New System.Drawing.Size(292, 348)
        Me.PBAparcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAparcar.TabIndex = 0
        Me.PBAparcar.TabStop = False
        Me.PBAparcar.Visible = False
        '
        'PBGuardarManguera
        '
        Me.PBGuardarManguera.Enabled = False
        Me.PBGuardarManguera.Image = CType(resources.GetObject("PBGuardarManguera.Image"), System.Drawing.Image)
        Me.PBGuardarManguera.Location = New System.Drawing.Point(896, 57)
        Me.PBGuardarManguera.Name = "PBGuardarManguera"
        Me.PBGuardarManguera.Size = New System.Drawing.Size(292, 348)
        Me.PBGuardarManguera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBGuardarManguera.TabIndex = 25
        Me.PBGuardarManguera.TabStop = False
        Me.PBGuardarManguera.Visible = False
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTerminar)
        Me.Panel2.Controls.Add(Me.BParar)
        Me.Panel2.Controls.Add(Me.BIniciar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.RBDieselPlus)
        Me.Panel2.Controls.Add(Me.RBDiesel)
        Me.Panel2.Controls.Add(Me.RBSP98)
        Me.Panel2.Controls.Add(Me.RBSP95)
        Me.Panel2.Controls.Add(Me.TBPrecio)
        Me.Panel2.Controls.Add(Me.TBLitros)
        Me.Panel2.Location = New System.Drawing.Point(896, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 144)
        Me.Panel2.TabIndex = 26
        Me.Panel2.Visible = False
        '
        'BTerminar
        '
        Me.BTerminar.Location = New System.Drawing.Point(287, 108)
        Me.BTerminar.Name = "BTerminar"
        Me.BTerminar.Size = New System.Drawing.Size(75, 23)
        Me.BTerminar.TabIndex = 10
        Me.BTerminar.Text = "Terminar"
        Me.BTerminar.UseVisualStyleBackColor = True
        '
        'BParar
        '
        Me.BParar.Location = New System.Drawing.Point(204, 108)
        Me.BParar.Name = "BParar"
        Me.BParar.Size = New System.Drawing.Size(68, 23)
        Me.BParar.TabIndex = 9
        Me.BParar.Text = "Parar"
        Me.BParar.UseVisualStyleBackColor = True
        '
        'BIniciar
        '
        Me.BIniciar.Location = New System.Drawing.Point(122, 108)
        Me.BIniciar.Name = "BIniciar"
        Me.BIniciar.Size = New System.Drawing.Size(63, 23)
        Me.BIniciar.TabIndex = 8
        Me.BIniciar.Text = "Iniciar"
        Me.BIniciar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "/€"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "/Litros"
        '
        'RBDieselPlus
        '
        Me.RBDieselPlus.AutoSize = True
        Me.RBDieselPlus.Location = New System.Drawing.Point(3, 108)
        Me.RBDieselPlus.Name = "RBDieselPlus"
        Me.RBDieselPlus.Size = New System.Drawing.Size(60, 17)
        Me.RBDieselPlus.TabIndex = 5
        Me.RBDieselPlus.TabStop = True
        Me.RBDieselPlus.Text = "Diesel+"
        Me.RBDieselPlus.UseVisualStyleBackColor = True
        '
        'RBDiesel
        '
        Me.RBDiesel.AutoSize = True
        Me.RBDiesel.Location = New System.Drawing.Point(4, 81)
        Me.RBDiesel.Name = "RBDiesel"
        Me.RBDiesel.Size = New System.Drawing.Size(54, 17)
        Me.RBDiesel.TabIndex = 4
        Me.RBDiesel.TabStop = True
        Me.RBDiesel.Text = "Diesel"
        Me.RBDiesel.UseVisualStyleBackColor = True
        '
        'RBSP98
        '
        Me.RBSP98.AutoSize = True
        Me.RBSP98.Location = New System.Drawing.Point(4, 43)
        Me.RBSP98.Name = "RBSP98"
        Me.RBSP98.Size = New System.Drawing.Size(87, 17)
        Me.RBSP98.TabIndex = 3
        Me.RBSP98.TabStop = True
        Me.RBSP98.Text = "Sin Plomo 98"
        Me.RBSP98.UseVisualStyleBackColor = True
        '
        'RBSP95
        '
        Me.RBSP95.AutoSize = True
        Me.RBSP95.Location = New System.Drawing.Point(4, 20)
        Me.RBSP95.Name = "RBSP95"
        Me.RBSP95.Size = New System.Drawing.Size(87, 17)
        Me.RBSP95.TabIndex = 2
        Me.RBSP95.TabStop = True
        Me.RBSP95.Text = "Sin Plomo 95"
        Me.RBSP95.UseVisualStyleBackColor = True
        '
        'TBPrecio
        '
        Me.TBPrecio.Enabled = False
        Me.TBPrecio.Location = New System.Drawing.Point(161, 80)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(149, 20)
        Me.TBPrecio.TabIndex = 1
        Me.TBPrecio.Text = "0"
        Me.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBLitros
        '
        Me.TBLitros.Enabled = False
        Me.TBLitros.Location = New System.Drawing.Point(161, 29)
        Me.TBLitros.Name = "TBLitros"
        Me.TBLitros.Size = New System.Drawing.Size(149, 20)
        Me.TBLitros.TabIndex = 0
        Me.TBLitros.Text = "0"
        Me.TBLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer2
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Surtidor 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(462, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Surtidor 4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(222, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Surtidor 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Surtidor 3"
        '
        'Simulacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 596)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PBGuardarManguera)
        Me.Controls.Add(Me.PBSacarManguera)
        Me.Controls.Add(Me.PBAparcar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBS2)
        Me.Controls.Add(Me.PBS3)
        Me.Controls.Add(Me.PBS4)
        Me.Controls.Add(Me.PBS1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Simulacion"
        Me.Text = "Simulacion"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBS2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBSacarManguera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAparcar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBGuardarManguera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PBS1 As PictureBox
    Friend WithEvents PBS4 As PictureBox
    Friend WithEvents PBS3 As PictureBox
    Friend WithEvents PBS2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBS4 As RadioButton
    Friend WithEvents RBS3 As RadioButton
    Friend WithEvents RBS2 As RadioButton
    Friend WithEvents RBS1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PBSacarManguera As PictureBox
    Friend WithEvents PBAparcar As PictureBox
    Friend WithEvents PBGuardarManguera As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTerminar As Button
    Friend WithEvents BParar As Button
    Friend WithEvents BIniciar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RBDieselPlus As RadioButton
    Friend WithEvents RBDiesel As RadioButton
    Friend WithEvents RBSP98 As RadioButton
    Friend WithEvents RBSP95 As RadioButton
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBLitros As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
