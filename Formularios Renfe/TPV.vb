Imports System.Data.OleDb

Public Class TPV
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Repsol_DB.accdb")
    Public dataset As New DataSet
    Private Sub TPV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'METODO DEL BOTON DE CATEGORIA DE PRODUCTO 'COMBUSTIBLE'
    'busca en la base de datos los tipo de combustible que hay
    'y crea un boton por cada registro, se requiere el nombre y el precio de cada uno
    Private Sub btnGas_Click(sender As Object, e As EventArgs) Handles btnGas.Click
        'se crea un adaptador para conectar la bd con el dataset
        Dim adapt_gas_nombre As New OleDbDataAdapter("SELECT nombre FROM combustibles", conexion)
        Dim adapt_gas_precio As New OleDbDataAdapter("SELECT precio FROM combustibles", conexion)

        'se rellena el dataset
        adapt_gas_nombre.Fill(dataset, "nombre")
        adapt_gas_precio.Fill(dataset, "precio")

        'se crea un Data Grid View temporal que recoga esos datos
        Dim dgv As New DataGridView
        Dim dgv2 As New DataGridView

        'se rellenan esos DGV
        dgv.DataSource = dataset
        dgv.DataMember = "gas"
        dgv2.DataSource = dataset
        dgv2.DataMember = "precio"

        'se crean unos arrays de string que contengan los valores de las columnas obtenidas
        Dim nombres() As String
        ReDim nombres(10)
        dgv.Columns.CopyTo(nombres, 0)
        Dim precios() As String
        ReDim precios(10)
        dgv2.Columns.CopyTo(precios, 0)

        'por cada valor de una de los array, se crea un boton y se introduce dentro del panel
        For i = 0 To nombres.Length
            Dim btn As New Button
            btn.Name = nombres(i)
            btn.Text = nombres(i) & ", " & precios(i) & "€"
            AddHandler btn.Click, AddressOf btn_Click
            flpProductos.Controls.Add(btn)
        Next
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs)
        MsgBox("Hola?")
    End Sub
End Class

'DataBindings.Add("text", dataset, "gas.nombre")