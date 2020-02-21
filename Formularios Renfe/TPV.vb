Imports System.Data.OleDb

Public Class TPV

    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_DB.accdb")

    Public adaptador_comida As New OleDbDataAdapter("Select * from productos where tipo=""Aperitivos""", conexion)
    Public dataset_comida As New DataSet
    Public adaptador_bebida As New OleDbDataAdapter("Select * from productos where tipo=""Bebidas""", conexion)
    Public dataset_bebida As New DataSet
    Public adaptador_motor As New OleDbDataAdapter("Select * from productos where tipo=""Motor""", conexion)
    Public dataset_motor As New DataSet

    Public prods As New List(Of Producto)
    Public gass As New List(Of Gas)
    Public tiquet As New List(Of Prod_Tiquet)

    Public precioTotal As Double

    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador_comida.Fill(dataset_comida, "comida")
        adaptador_bebida.Fill(dataset_bebida, "bebida")
        adaptador_motor.Fill(dataset_motor, "motor")
        tiquet.Clear()
    End Sub

    Private Sub btnComida_Click(sender As Object, e As EventArgs) Handles btnComida.Click
        flp.Controls.Clear()
        If prods IsNot Nothing Then
            prods.Clear()
        End If

        For i As Integer = 0 To dataset_comida.Tables(0).Rows.Count - 1
            Dim btn As New Button()

            Dim tipo, nombre, stock, precio As String
            tipo = dataset_comida.Tables(0).Rows(i)(1).ToString
            nombre = dataset_comida.Tables(0).Rows(i)(2).ToString
            stock = dataset_comida.Tables(0).Rows(i)(4).ToString
            precio = dataset_comida.Tables(0).Rows(i)(3).ToString
            Dim prod As New Producto(tipo, nombre, Convert.ToInt32(stock), Convert.ToDouble(precio))

            prods.Add(prod)

            btn.Name = prod.Nombre
            btn.Text = prod.Nombre
            btn.Height = 100
            btn.Width = 180
            btn.BackColor = Color.Orange
            AddHandler btn.Click, AddressOf addProduct

            flp.Controls.Add(btn)
        Next
    End Sub

    Private Sub btnMotor_Click(sender As Object, e As EventArgs) Handles btnMotor.Click
        flp.Controls.Clear()
        If prods IsNot Nothing Then
            prods.Clear()
        End If

        For i As Integer = 0 To dataset_motor.Tables(0).Rows.Count - 1
            Dim btn As New Button()
            Dim tipo, nombre, stock, precio As String
            tipo = dataset_motor.Tables(0).Rows(i)(1).ToString
            nombre = dataset_motor.Tables(0).Rows(i)(2).ToString
            stock = dataset_motor.Tables(0).Rows(i)(4).ToString
            precio = dataset_motor.Tables(0).Rows(i)(3).ToString
            Dim prod As New Producto(tipo, nombre, Convert.ToInt32(stock), Convert.ToDouble(precio))

            prods.Add(prod)

            btn.Name = prod.Nombre
            btn.Text = prod.Nombre
            btn.Height = 100
            btn.Width = 180
            btn.BackColor = Color.Orange
            AddHandler btn.Click, AddressOf addProduct

            flp.Controls.Add(btn)
        Next
    End Sub

    Private Sub btnBebida_Click(sender As Object, e As EventArgs) Handles btnBebida.Click
        flp.Controls.Clear()
        If prods IsNot Nothing Then
            prods.Clear()
        End If

        For i As Integer = 0 To dataset_bebida.Tables(0).Rows.Count - 1
            Dim btn As New Button()

            Dim tipo, nombre, stock, precio As String
            tipo = dataset_bebida.Tables(0).Rows(i)(1).ToString
            nombre = dataset_bebida.Tables(0).Rows(i)(2).ToString
            stock = dataset_bebida.Tables(0).Rows(i)(4).ToString
            precio = dataset_bebida.Tables(0).Rows(i)(3).ToString
            Dim prod As New Producto(tipo, nombre, Convert.ToInt32(stock), Convert.ToDouble(precio))

            prods.Add(prod)

            btn.Name = prod.Nombre
            btn.Text = prod.Nombre
            btn.Height = 100
            btn.Width = 180
            btn.BackColor = Color.Orange
            AddHandler btn.Click, AddressOf addProduct

            flp.Controls.Add(btn)
        Next
    End Sub

    Public Sub addProduct(ByVal sender As Object, ByVal e As EventArgs)
        If TypeOf sender Is Button Then
            Dim precio As Double
            Dim nombre As String
            Dim prod As New Prod_Tiquet

            Dim adapter As New OleDbDataAdapter("Select * from productos where nombre = '" & CType(sender, Button).Text & "'", conexion)
            Dim dataset As New DataSet
            adapter.Fill(dataset, "precios")
            precio = dataset.Tables(0).Rows(0)(3).ToString
            nombre = dataset.Tables(0).Rows(0)(2).ToString
            prod.precio = precio
            prod.nombre = nombre
            prod.cantidad = 1
            tiquet.Add(prod)

            Dim chivato As Boolean = True
            For i As Integer = 0 To lstPedido.Items.Count - 1
                Dim item As New ListViewItem
                item = lstPedido.Items.Item(i)
                If item.SubItems(1).Text = nombre Then
                    item.SubItems(0).Text += 1
                    item.SubItems(2).Text = item.SubItems(0).Text * precio
                    chivato = False
                    Exit For
                End If
            Next
            If chivato Then
                With lstPedido.Items.Add(prod.cantidad)
                    .SubItems.Add(prod.nombre)
                    .SubItems.Add(prod.precio)
                End With
                calcularPrecioTotal()
            End If

            calcularPrecioTotal()
        End If
    End Sub

    Private Sub calcularPrecioTotal()
        Dim total, tmp As Double
        For i As Integer = 0 To lstPedido.Items.Count - 1
            If Double.TryParse(lstPedido.Items(i).SubItems(2).Text, tmp) Then
                total += tmp
            End If
        Next
        lbTotal.Text = total
        precioTotal = total
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try
            Dim item As New ListViewItem
            Dim precio As Double
            item = lstPedido.SelectedItems.Item(0)
            Dim adapter As New OleDbDataAdapter("Select * from productos where nombre = """ & item.SubItems(1).Text & """", conexion)
            Dim dataset As New DataSet
            adapter.Fill(dataset, "precio")
            precio = dataset.Tables(0).Rows(0)(3).ToString
            item.SubItems(0).Text += 1
            item.SubItems(2).Text = item.SubItems(0).Text * precio
            calcularPrecioTotal()
        Catch ex As Exception
            MsgBox("Seleccione una fila para proceder.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnMinus1_Click(sender As Object, e As EventArgs) Handles btnMinus1.Click
        Try
            Dim item As New ListViewItem
            Dim precio As Double
            item = lstPedido.SelectedItems.Item(0)
            Dim adapter As New OleDbDataAdapter("Select * from productos where nombre = """ & item.SubItems(1).Text & """", conexion)
            Dim dataset As New DataSet
            adapter.Fill(dataset, "precio")
            precio = dataset.Tables(0).Rows(0)(3).ToString
            item.SubItems(0).Text -= 1
            item.SubItems(2).Text = item.SubItems(0).Text * precio
            If item.SubItems(0).Text = 0 Then
                btnBorrarLinea_Click(Nothing, Nothing)
            End If
            calcularPrecioTotal()
        Catch ex As Exception
            MsgBox("Seleccione una fila para proceder.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnResetPedido_Click(sender As Object, e As EventArgs) Handles btnResetPedido.Click
        Dim i As Integer = MsgBox("¿Seguro que desea borrar el tiquet actual?.", 292)
        If i = MsgBoxResult.Yes Then
            lstPedido.Items.Clear()
        End If
        calcularPrecioTotal()
    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        Try
            lstPedido.Items.RemoveAt(lstPedido.FocusedItem.Index)
        Catch ex As NullReferenceException
            MsgBox("Selecciona una lína a borrar.", MsgBoxStyle.Exclamation)
        End Try
        calcularPrecioTotal()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbFechaHora.Text = Now
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        PagarForm.Show()
    End Sub
End Class

'Dim precio As Double
'Dim nombre As String
'Dim prod As New Prod_Tiquet
'If esGas Then
'Dim adapter As New OleDbDataAdapter("Select * from combustibles where TipoG = '" & CType(sender, Button).Text & "'", conexion)
'Dim dataset As New DataSet
'adapter.Fill(dataset, "precios")
'precio = dataset.Tables(0).Rows(0)(2).ToString
'nombre = dataset.Tables(0).Rows(0)(0).ToString
'prod.precio = precio
'prod.nombre = nombre
'prod.cantidad = 1
'tiquet.Add(prod)
'ElseIf esProd Then
'Dim adapter As New OleDbDataAdapter("Select * from productos where nombre = '" & CType(sender, Button).Text & "'", conexion)
'Dim dataset As New DataSet
'adapter.Fill(dataset, "precios")
'precio = dataset.Tables(0).Rows(0)(3).ToString
'nombre = dataset.Tables(0).Rows(0)(2).ToString
'prod.precio = precio
'prod.nombre = nombre
'prod.cantidad = 1
'tiquet.Add(prod)
'Else
'precio = "error"
'End If

'With lstPedido.Items.Add(prod.cantidad)
'.SubItems.Add(prod.nombre)
'.SubItems.Add(prod.precio)
'End With
'calcularPrecioTotal()