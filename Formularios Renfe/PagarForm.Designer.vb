<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagarForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbImporte = New System.Windows.Forms.TextBox()
        Me.btnPrintTicket = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tabPagar = New System.Windows.Forms.TabControl()
        Me.tabCash = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.txbCambio = New System.Windows.Forms.TextBox()
        Me.txbEntregdo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabTarjeta = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxEsCliente = New System.Windows.Forms.CheckBox()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.tabPagar.SuspendLayout()
        Me.tabCash.SuspendLayout()
        Me.tabTarjeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importe total:"
        '
        'txbImporte
        '
        Me.txbImporte.Enabled = False
        Me.txbImporte.Location = New System.Drawing.Point(157, 6)
        Me.txbImporte.Name = "txbImporte"
        Me.txbImporte.ReadOnly = True
        Me.txbImporte.Size = New System.Drawing.Size(148, 32)
        Me.txbImporte.TabIndex = 1
        Me.txbImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPrintTicket
        '
        Me.btnPrintTicket.Location = New System.Drawing.Point(60, 419)
        Me.btnPrintTicket.Name = "btnPrintTicket"
        Me.btnPrintTicket.Size = New System.Drawing.Size(171, 48)
        Me.btnPrintTicket.TabIndex = 5
        Me.btnPrintTicket.Text = "Imprimir tiquet"
        Me.btnPrintTicket.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(414, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(171, 48)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(237, 419)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(171, 48)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'tabPagar
        '
        Me.tabPagar.Controls.Add(Me.tabCash)
        Me.tabPagar.Controls.Add(Me.tabTarjeta)
        Me.tabPagar.Location = New System.Drawing.Point(12, 87)
        Me.tabPagar.Name = "tabPagar"
        Me.tabPagar.SelectedIndex = 0
        Me.tabPagar.Size = New System.Drawing.Size(577, 326)
        Me.tabPagar.TabIndex = 8
        '
        'tabCash
        '
        Me.tabCash.Controls.Add(Me.Label7)
        Me.tabCash.Controls.Add(Me.Label6)
        Me.tabCash.Controls.Add(Me.btn0)
        Me.tabCash.Controls.Add(Me.btnCE)
        Me.tabCash.Controls.Add(Me.btn8)
        Me.tabCash.Controls.Add(Me.btn7)
        Me.tabCash.Controls.Add(Me.btn6)
        Me.tabCash.Controls.Add(Me.btn5)
        Me.tabCash.Controls.Add(Me.btn4)
        Me.tabCash.Controls.Add(Me.btn1)
        Me.tabCash.Controls.Add(Me.btn2)
        Me.tabCash.Controls.Add(Me.btn3)
        Me.tabCash.Controls.Add(Me.btn9)
        Me.tabCash.Controls.Add(Me.txbCambio)
        Me.tabCash.Controls.Add(Me.txbEntregdo)
        Me.tabCash.Controls.Add(Me.Label4)
        Me.tabCash.Controls.Add(Me.Label3)
        Me.tabCash.Location = New System.Drawing.Point(4, 35)
        Me.tabCash.Name = "tabCash"
        Me.tabCash.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCash.Size = New System.Drawing.Size(569, 287)
        Me.tabCash.TabIndex = 0
        Me.tabCash.Text = "Efectivo"
        Me.tabCash.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 26)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "€"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 26)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "€"
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(402, 230)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(161, 50)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnCE
        '
        Me.btnCE.Location = New System.Drawing.Point(402, 6)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(161, 50)
        Me.btnCE.TabIndex = 13
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(457, 62)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 50)
        Me.btn8.TabIndex = 12
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(402, 62)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 50)
        Me.btn7.TabIndex = 11
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(513, 118)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 50)
        Me.btn6.TabIndex = 10
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(457, 118)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 50)
        Me.btn5.TabIndex = 9
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(401, 118)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 50)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(401, 174)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 50)
        Me.btn1.TabIndex = 7
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(457, 174)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 50)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(513, 174)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 50)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(513, 62)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 50)
        Me.btn9.TabIndex = 4
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'txbCambio
        '
        Me.txbCambio.Location = New System.Drawing.Point(159, 71)
        Me.txbCambio.Name = "txbCambio"
        Me.txbCambio.ReadOnly = True
        Me.txbCambio.Size = New System.Drawing.Size(141, 32)
        Me.txbCambio.TabIndex = 3
        Me.txbCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbEntregdo
        '
        Me.txbEntregdo.Location = New System.Drawing.Point(159, 21)
        Me.txbEntregdo.Name = "txbEntregdo"
        Me.txbEntregdo.ReadOnly = True
        Me.txbEntregdo.Size = New System.Drawing.Size(141, 32)
        Me.txbEntregdo.TabIndex = 2
        Me.txbEntregdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cambio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Entregado"
        '
        'tabTarjeta
        '
        Me.tabTarjeta.Controls.Add(Me.Label2)
        Me.tabTarjeta.Location = New System.Drawing.Point(4, 35)
        Me.tabTarjeta.Name = "tabTarjeta"
        Me.tabTarjeta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTarjeta.Size = New System.Drawing.Size(569, 287)
        Me.tabTarjeta.TabIndex = 1
        Me.tabTarjeta.Text = "Tarjeta"
        Me.tabTarjeta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Haga el pago con tarjeta y pulse aceptar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 26)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "€"
        '
        'cbxEsCliente
        '
        Me.cbxEsCliente.AutoSize = True
        Me.cbxEsCliente.Location = New System.Drawing.Point(16, 44)
        Me.cbxEsCliente.Name = "cbxEsCliente"
        Me.cbxEsCliente.Size = New System.Drawing.Size(205, 30)
        Me.cbxEsCliente.TabIndex = 22
        Me.cbxEsCliente.Text = "Venta a un cliente"
        Me.cbxEsCliente.UseVisualStyleBackColor = True
        '
        'cbClientes
        '
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(400, 47)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(159, 34)
        Me.cbClientes.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 26)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nombre del cliente"
        '
        'PagarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 480)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxEsCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tabPagar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnPrintTicket)
        Me.Controls.Add(Me.txbImporte)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "PagarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.tabPagar.ResumeLayout(False)
        Me.tabCash.ResumeLayout(False)
        Me.tabCash.PerformLayout()
        Me.tabTarjeta.ResumeLayout(False)
        Me.tabTarjeta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txbImporte As TextBox
    Friend WithEvents btnPrintTicket As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents tabPagar As TabControl
    Friend WithEvents tabCash As TabPage
    Friend WithEvents tabTarjeta As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txbCambio As TextBox
    Friend WithEvents txbEntregdo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn0 As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxEsCliente As CheckBox
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
