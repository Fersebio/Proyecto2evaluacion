Imports System.Data.OleDb
Public Class StockP
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select Nombre,Stock from Productos", conexion)
    Public midataset As New DataSet
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub StockP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador.Fill(midataset, "Tabla1")
        DataGridView1.DataSource = midataset
        DataGridView1.DataMember = "Tabla1"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class