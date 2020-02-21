Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class PagarForm

    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_DB.accdb")
    Private adapter As New OleDbDataAdapter("Select * from clientes", conexion)

    Private seHaPagado As Boolean

    Private Sub PagarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbImporte.Text = TPV.precioTotal
        Dim dataset As New DataSet
        adapter.Fill(dataset, "clientes")
        cbClientes.DataSource = dataset.Tables("clientes")
        cbClientes.DisplayMember = "nombre"
        Label5.Visible = False
        cbClientes.Visible = False
        cbxEsCliente_CheckedChanged(Nothing, Nothing)
        seHaPagado = False
    End Sub

    Private Sub introducirValor(ByVal valor As Integer)
        Dim actual As Integer
        If txbEntregdo.Text.Equals("") Then
            actual = valor
            txbEntregdo.Text = actual
        Else
            actual = txbEntregdo.Text
            txbEntregdo.Text = Convert.ToString(actual) & Convert.ToString(valor)
        End If
        txbCambio.Text = txbEntregdo.Text - txbImporte.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        introducirValor(Convert.ToInt32(CType(sender, Button).Text))
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txbEntregdo.Text = ""
        txbCambio.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txbEntregdo.Text > txbImporte.Text Then
            Dim apadter As New OleDbDataAdapter("Select * from ventas", conexion)
            Dim midataset As New DataSet
            adapter.Fill(midataset, "id")
            Dim id As String = Now

            Dim query As String = "Insert into ventas values(@id, @importe, @tipo, @cliente)"
            Dim comando As New OleDbCommand(query, conexion)
            comando.Parameters.AddWithValue("@id", id)
            comando.Parameters.AddWithValue("@importe", txbImporte.Text)
            comando.Parameters.AddWithValue("@tipo", tabPagar.SelectedTab.Text)
            comando.Parameters.AddWithValue("@cliente", cbClientes.Text)

            conexion.Open()

            Try
                comando.ExecuteNonQuery()
                MsgBox("Pago realizado correctamente.", MsgBoxStyle.Information)
                seHaPagado = True
            Catch ex As Exception
                MsgBox("Ha ocurrido un problema con la venta, reinicie la aplicación.", MsgBoxStyle.Exclamation)
            End Try
            conexion.Close()
            midataset.Clear()

            TPV.lstPedido.Items.Clear()
            Me.Close()
        Else
            MsgBox("El dinero introducido es menor al importe necesario.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cbxEsCliente_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEsCliente.CheckedChanged
        If cbxEsCliente.Checked Then
            Label5.Visible = True
            cbClientes.Visible = True
        Else
            cbClientes.Text = " "
            Label5.Visible = False
            cbClientes.Visible = False
        End If
    End Sub

    Private Sub btnPrintTicket_Click(sender As Object, e As EventArgs) Handles btnPrintTicket.Click
        If seHaPagado Then
            Try
                AddHandler PrintDocument1.PrintPage, AddressOf imprimirTiquet
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox("Error durante la impresión del tiquet. Compruebe que la impresora está conectada al ordenador, está enchufada, tiene papel y tinta...", MsgBoxStyle.Exclamation, "Error durante la impresión")
            End Try
        Else
            MsgBox("Debe realizarse primero el pago del pedido.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub imprimirTiquet(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            Dim y As Integer = 0
            'despues de cada linea impresa, aumentar el valor de y en 20 por linea

            '4 primeras líneas, la cabecera
            Dim cabecera As String
            cabecera = "REPSOL ESTACIONES DE SERVICIO S.A." & vbCrLf & "E.S.Hipódromo / N.33003" & vbCrLf & "Autovía A-6 pk. 7,800" & vbCrLf & "28023 Madrid"
            ev.Graphics.DrawString(cabecera, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 80

            'separador
            Dim separador As String
            separador = "------------------------------------------"
            ev.Graphics.DrawString(separador, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'titulo
            Dim titulo As String = "               Tiquet venta"
            ev.Graphics.DrawString(titulo, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 60

            'datos de la caja y el empleado
            Dim datosCaja As String
            datosCaja = "NIF A7849782       " & Now & vbCrLf & "N. de transac.:0355/272676 Caja N. 1" & vbCrLf & "Cajero: ADMINISTRADOR"
            ev.Graphics.DrawString(datosCaja, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 80

            'Venta de combustible
            ev.Graphics.DrawString("Venta de Combustible", New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'n surtidor
            Dim nSurtidor As String
            Dim surtidor As Integer
            nSurtidor = "N. de surtidor " & surtidor & "*E95 Neotech"
            ev.Graphics.DrawString(nSurtidor, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'productos del tiquet



            'impuestos



            'prods de terceros
            Dim pro_terceros As String
            pro_terceros = "     Los articulos comenzados por *" & vbCrLf & "son vendidos por cuenta de terceros"
            ev.Graphics.DrawString(pro_terceros, New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 40

            'IVA incluido
            ev.Graphics.DrawString("              IVA Incluido", New Font("Arial", 9, FontStyle.Regular), Brushes.Black, 120, y)
            y += 20

            'pie de página
            Dim footer As String
            footer = "       ¡GRACIAS POR SU VISITA!" & vbCrLf & "Hay salida a la violencia de género" & vbCrLf & "         Teléfono de ayuda 016"

        Catch ex As Exception
            MsgBox("Error en uno de los elementos del tiquet.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class