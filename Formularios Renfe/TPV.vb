Imports System.Data.OleDb

Public Class TPV

    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Óscar\source\repos\Proyecto_Repsol\Formularios Renfe\bin\Debug\Repsol_DB.accdb")
    Public adaptador_comida As New OleDbDataAdapter("Select * from productos where tipo=""Aperitivos""", conexion)
    Public dataset_comida As New DataSet
    Public adaptador_bebida As New OleDbDataAdapter("Select * from productos where tipo=""Bebidas""", conexion)
    Public dataset_bebida As New DataSet
    Public adaptador_motor As New OleDbDataAdapter("Select * from productos where tipo=""Motor""", conexion)
    Public dataset_motor As New DataSet
    Public adaptador_gas As New OleDbDataAdapter("Select * from combustibles", conexion)
    Public dataset_gas As New DataSet

    Public prods As New List(Of Producto)
    Public gass As New List(Of Gas)

    Public esGas As Boolean = False
    Public esProd As Boolean = False

    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador_comida.Fill(dataset_comida, "comida")
        adaptador_bebida.Fill(dataset_bebida, "bebida")
        adaptador_motor.Fill(dataset_motor, "motor")
        adaptador_gas.Fill(dataset_gas, "gas")
    End Sub

    Private Sub btnGas_Click(sender As Object, e As EventArgs) Handles btnGas.Click
        flp.Controls.Clear()
        esProd = False
        esGas = True
        If gass IsNot Nothing Then
            gass.Clear()
        End If

        For i As Integer = 0 To dataset_gas.Tables(0).Rows.Count - 1
            Dim btn As New Button()
            Dim tipo, cant, pre As String
            tipo = dataset_gas.Tables(0).Rows(i)(0).ToString
            cant = dataset_gas.Tables(0).Rows(i)(1).ToString
            pre = dataset_gas.Tables(0).Rows(i)(2).ToString
            Dim prod As New Gas(tipo, Convert.ToDouble(cant), Convert.ToDouble(pre))

            gass.Add(prod)

            btn.Name = prod.TipoG
            btn.Text = prod.TipoG
            btn.Height = 100
            btn.Width = 180
            btn.BackColor = Color.Orange
            AddHandler btn.Click, AddressOf addProduct

            flp.Controls.Add(btn)
        Next
    End Sub

    Private Sub btnComida_Click(sender As Object, e As EventArgs) Handles btnComida.Click
        flp.Controls.Clear()
        esGas = False
        esProd = True
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
        esGas = False
        esProd = True
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
        esGas = False
        esProd = True
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

    Private Sub addProduct(ByVal sender As Object, ByVal e As EventArgs)
        If TypeOf sender Is Button Then
            Dim precio As String
            If esGas Then
                Dim adapter As New OleDbDataAdapter("Select * from combustibles where TipoG = '" & CType(sender, Button).Text & "'", conexion)
                Dim dataset As New DataSet
                adapter.Fill(dataset, "precios")
                precio = dataset.Tables(0).Rows(0)(2).ToString
            ElseIf esProd Then
                Dim adapter As New OleDbDataAdapter("Select * from productos where nombre = '" & CType(sender, Button).Text & "'", conexion)
                Dim dataset As New DataSet
                adapter.Fill(dataset, "precios")
                precio = dataset.Tables(0).Rows(0)(3).ToString
            Else
                precio = "error"
            End If

            With lstPedido.Items.Add(1)
                .SubItems.Add(CType(sender, Button).Text)
                .SubItems.Add(Precio)
            End With
            calcularPrecioTotal()
        End If
    End Sub

    Private Sub calcularPrecioTotal()
        Dim total, tmp As Double
        For i As Integer = 0 To lstPedido.Items.Count - 1
            If Double.TryParse(lstPedido.Items(i).SubItems(1).Text, tmp) Then
                total += tmp
            End If
        Next
        lbTotal.Text = total
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        MsgBox("not yet")
    End Sub

    Private Sub btnMinus1_Click(sender As Object, e As EventArgs) Handles btnMinus1.Click

    End Sub

    Private Sub btnResetPedido_Click(sender As Object, e As EventArgs) Handles btnResetPedido.Click
        Dim i As Integer = MsgBox("¿Seguro que desea borrar el tiquet actual?", 292)
        If i = MsgBoxResult.Yes Then
            lstPedido.Items.Clear()
        End If
    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        Try
            lstPedido.Items.RemoveAt(lstPedido.FocusedItem.Index)
        Catch ex As NullReferenceException
            MsgBox("Selecciona una lína a borrar", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbFechaHora.Text = Now
    End Sub

End Class

'Dim precio As Double
'Dim nombre As String
'If TypeOf sender Is Button Then
'Select Case CType(sender, Button).Text
'Case "Nachos"
'nombre = "Nachos"
'precio = 2
'Case "Yatekomo"
'nombre = "Yatekomo"
'precio = 1
'Case "Longaniza"
'nombre = "Longaniza"
'precio = 1.5
'Case "Monster"
'nombre = "Monster"
'precio = 1.15
'Case "Lays"
'nombre = "Lays"
'precio = 1.5
'Case "CocaCola"
'nombre = "CocaCola"
'precio = 1.36
'Case "Leche"
'nombre = "Leche"
'precio = 1.56
'Case "Cadenas para ruedas"
'nombre = "Cadenas para ruedas"
'precio = 25.9
'Case "Chalecos fosforescentes"
'nombre = "Chalecos fosforescentes"
'precio = 25.9
'Case "Filipinos"
'nombre = "Filipinos"
'precio = 2.35
'Case "Fanta"
'nombre = "Fanta"
'precio = 2.62
'End Select
'For Each item In lstPedido.Items
'If item.ToString = nombre Then
'Dim cantidad As Integer = Convert.ToInt32(lstPedido.Columns(0).ToString)
'cantidad += 1
'Dim item_nombre As New ListViewItem
'Dim item_cant As New ListViewItem
'item_nombre.Text = nombre
'item_cant.Text = cantidad
'lstPedido.Items.Insert(lstPedido.Items.IndexOf(item_nombre), item_cant)
'End If
'Next

'With lstPedido.Items.Add(1)
'.SubItems.Add(nombre)
'.SubItems.Add(precio)
'End With

'Dim iBuscar As New ListViewItem
'iBuscar.Text = nombre
'If lstPedido.Items.Contains(iBuscar) Then
'Dim index As Integer = lstPedido.Items.IndexOf(iBuscar)
'Else
'With lstPedido.Items.Add(1)
'.SubItems.Add(nombre)
'.SubItems.Add(precio)
'End With
'End If
'End If