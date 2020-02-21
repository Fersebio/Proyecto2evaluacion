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
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.lbFechaHora = New System.Windows.Forms.Label()
        Me.lstPedido = New System.Windows.Forms.ListView()
        Me.Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.btnBorrarLinea = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnMinus1 = New System.Windows.Forms.Button()
        Me.btnResetPedido = New System.Windows.Forms.Button()
        Me.btnBebida = New System.Windows.Forms.Button()
        Me.btnMotor = New System.Windows.Forms.Button()
        Me.btnComida = New System.Windows.Forms.Button()
        Me.flp = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txbUsuario
        '
        Me.txbUsuario.Enabled = False
        Me.txbUsuario.Location = New System.Drawing.Point(12, 12)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(190, 32)
        Me.txbUsuario.TabIndex = 1
        '
        'lbFechaHora
        '
        Me.lbFechaHora.AutoSize = True
        Me.lbFechaHora.Location = New System.Drawing.Point(208, 12)
        Me.lbFechaHora.Name = "lbFechaHora"
        Me.lbFechaHora.Size = New System.Drawing.Size(138, 26)
        Me.lbFechaHora.TabIndex = 2
        Me.lbFechaHora.Text = "Fecha y hora"
        '
        'lstPedido
        '
        Me.lstPedido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Cantidad, Me.Nombre, Me.Precio})
        Me.lstPedido.FullRowSelect = True
        Me.lstPedido.HideSelection = False
        Me.lstPedido.Location = New System.Drawing.Point(12, 196)
        Me.lstPedido.Name = "lstPedido"
        Me.lstPedido.Size = New System.Drawing.Size(503, 472)
        Me.lstPedido.TabIndex = 3
        Me.lstPedido.UseCompatibleStateImageBehavior = False
        Me.lstPedido.View = System.Windows.Forms.View.Details
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.Width = 165
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 230
        '
        'Precio
        '
        Me.Precio.Text = "Precio"
        Me.Precio.Width = 103
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(407, 674)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(171, 60)
        Me.btnPagar.TabIndex = 5
        Me.btnPagar.Text = "Realizar pago"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 682)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 52)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total:"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(176, 682)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(47, 52)
        Me.lbTotal.TabIndex = 7
        Me.lbTotal.Text = "0"
        '
        'btnBorrarLinea
        '
        Me.btnBorrarLinea.Location = New System.Drawing.Point(521, 398)
        Me.btnBorrarLinea.Name = "btnBorrarLinea"
        Me.btnBorrarLinea.Size = New System.Drawing.Size(95, 95)
        Me.btnBorrarLinea.TabIndex = 8
        Me.btnBorrarLinea.Text = "Borrar linea"
        Me.btnBorrarLinea.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(521, 196)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(95, 95)
        Me.btnAdd1.TabIndex = 9
        Me.btnAdd1.Text = "+ 1"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'btnMinus1
        '
        Me.btnMinus1.Location = New System.Drawing.Point(521, 297)
        Me.btnMinus1.Name = "btnMinus1"
        Me.btnMinus1.Size = New System.Drawing.Size(95, 95)
        Me.btnMinus1.TabIndex = 10
        Me.btnMinus1.Text = "- 1"
        Me.btnMinus1.UseVisualStyleBackColor = True
        '
        'btnResetPedido
        '
        Me.btnResetPedido.Location = New System.Drawing.Point(521, 499)
        Me.btnResetPedido.Name = "btnResetPedido"
        Me.btnResetPedido.Size = New System.Drawing.Size(95, 95)
        Me.btnResetPedido.TabIndex = 11
        Me.btnResetPedido.Text = "Borrar todo"
        Me.btnResetPedido.UseVisualStyleBackColor = True
        '
        'btnBebida
        '
        Me.btnBebida.Location = New System.Drawing.Point(844, 12)
        Me.btnBebida.Name = "btnBebida"
        Me.btnBebida.Size = New System.Drawing.Size(146, 72)
        Me.btnBebida.TabIndex = 16
        Me.btnBebida.Text = "Bebida"
        Me.btnBebida.UseVisualStyleBackColor = True
        '
        'btnMotor
        '
        Me.btnMotor.Location = New System.Drawing.Point(996, 12)
        Me.btnMotor.Name = "btnMotor"
        Me.btnMotor.Size = New System.Drawing.Size(146, 72)
        Me.btnMotor.TabIndex = 17
        Me.btnMotor.Text = "Motor"
        Me.btnMotor.UseVisualStyleBackColor = True
        '
        'btnComida
        '
        Me.btnComida.Location = New System.Drawing.Point(692, 12)
        Me.btnComida.Name = "btnComida"
        Me.btnComida.Size = New System.Drawing.Size(146, 72)
        Me.btnComida.TabIndex = 18
        Me.btnComida.Text = "Comida"
        Me.btnComida.UseVisualStyleBackColor = True
        '
        'flp
        '
        Me.flp.BackColor = System.Drawing.SystemColors.ControlDark
        Me.flp.Location = New System.Drawing.Point(692, 90)
        Me.flp.Name = "flp"
        Me.flp.Size = New System.Drawing.Size(602, 644)
        Me.flp.TabIndex = 19
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(470, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(146, 55)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Cerrar TPV"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 682)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 52)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "€"
        '
        'TPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 746)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.flp)
        Me.Controls.Add(Me.btnComida)
        Me.Controls.Add(Me.btnMotor)
        Me.Controls.Add(Me.btnBebida)
        Me.Controls.Add(Me.btnResetPedido)
        Me.Controls.Add(Me.btnMinus1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.btnBorrarLinea)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lstPedido)
        Me.Controls.Add(Me.lbFechaHora)
        Me.Controls.Add(Me.txbUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "TPV"
        Me.Text = "TPV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents lbFechaHora As Label
    Friend WithEvents lstPedido As ListView
    Friend WithEvents Cantidad As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Precio As ColumnHeader
    Friend WithEvents btnPagar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btnBorrarLinea As Button
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnMinus1 As Button
    Friend WithEvents btnResetPedido As Button
    Friend WithEvents btnBebida As Button
    Friend WithEvents btnMotor As Button
    Friend WithEvents btnComida As Button
    Friend WithEvents flp As FlowLayoutPanel
    Friend WithEvents btnVolver As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label2 As Label
End Class
