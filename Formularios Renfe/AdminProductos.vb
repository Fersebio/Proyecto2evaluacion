Imports System.Data.OleDb
Public Class AdminProductos
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Productos", conexion)
    Public midataset As New DataSet

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Dim ordensql As String = "Insert into Productos(Nombre,Precio,Stock,Categoria) values (@nom,@pre,@sto,@cat)"
        Dim comando As New OleDbCommand(ordensql, conexion)
        comando.Parameters.AddWithValue("@nom", TBNombre.Text)
        comando.Parameters.AddWithValue("@pre", TBPrecio.Text)
        comando.Parameters.AddWithValue("@sto", TBStock.Text)
        comando.Parameters.AddWithValue("@cat", CBCategoria.Text)
        conexion.Open()
        Try
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Claves duplicadas")
        End Try
        conexion.Close()
        midataset.Clear()
        adaptador.Fill(midataset, "Tabla1")
        DataGridView1.DataSource = midataset
        DataGridView1.DataMember = "Tabla1"
    End Sub



    Private Sub AdminProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador.Fill(midataset, "Tabla1")
        TBNombre.DataBindings.Add("text", midataset, "Tabla1.Nombre")
        TBPrecio.DataBindings.Add("text", midataset, "Tabla1.Precio")
        TBStock.DataBindings.Add("text", midataset, "Tabla1.Stock")
        CBCategoria.DataBindings.Add("text", midataset, "Tabla1.Categoria")
        TextBox1.DataBindings.Add("text", midataset, "Tabla1.Id")
        DataGridView1.DataSource = midataset
        DataGridView1.DataMember = "Tabla1"
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim res As Integer
        Dim ordensql As String = "Delete from Productos Where Nombre=@nom"
        Dim comando As New OleDbCommand(ordensql, conexion)
        comando.Parameters.AddWithValue("@nom", TBNombre.Text)
        res = MsgBox("Esta Seguro...?", 20, "Aviso")
        If res = 6 Then
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
        End If
        midataset.Clear()
        adaptador.Fill(midataset, "Tabla1")
        DataGridView1.DataSource = midataset
        DataGridView1.DataMember = "Tabla1"
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Try
            Dim ordensql As String = "Update Productos Set Nombre=@nom, Precio=@pre, Stock=@sto, Categoria=@cat where id = " + TextBox1.Text
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@nom", TBNombre.Text)
            comando.Parameters.AddWithValue("@pre", TBPrecio.Text)
            comando.Parameters.AddWithValue("@sto", TBStock.Text)
            comando.Parameters.AddWithValue("@cat", CBCategoria.Text)
            comando.Parameters.AddWithValue("@id", TextBox1.Text)
            conexion.Open()

            If comando.ExecuteNonQuery() Then
                MsgBox("Actualizacion correcta")

            Else
                MsgBox("No se puede modificar")
            End If
            conexion.Close()

            midataset.Clear()
            adaptador.Fill(midataset, "Tabla1")
            DataGridView1.DataSource = midataset
            DataGridView1.DataMember = "Tabla1"
        Catch ex As Exception
            MsgBox("No se ha introducido ninguna ID ")
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        TBNombre.Clear()
        TBPrecio.Clear()
        TBStock.Clear()
        Dim var As String = InputBox("Dime nombre del producto a buscar...")
        Dim m As Integer = 0
        Dim comando As New OleDbCommand("Select * from Productos where Nombre = @nom", conexion)
        comando.Parameters.AddWithValue("@nom", var)
        conexion.Open()
        Dim res As OleDbDataReader = comando.ExecuteReader
        While res.Read
            If res.Item("Nombre") = var Then
                TBNombre.Text = res("Nombre")
                TBPrecio.Text = res("Precio")
                TBStock.Text = res("Stock")
                CBCategoria.Text = res("Categoria")
                TextBox1.Text = res("ID")
                m = 1
            End If
        End While
        conexion.Close()
        If m = 0 Then
            MsgBox("Busqueda fallida")
        End If
    End Sub
End Class