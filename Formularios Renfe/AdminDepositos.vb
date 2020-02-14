Imports System.Data.OleDb

Public Class AdminDepos

    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Depositos", conexion)
    Public midataset As New DataSet
    Private Sub BRSinPlomo95_Click(sender As Object, e As EventArgs) Handles BRSinPlomo95.Click
        PBSinPlomo95.Value = PBSinPlomo95.Maximum
        Dim ordensql As String = "Update Depositos set Cantidad = " + PBSinPlomo95.Maximum.ToString + " where TipoG = 'SP95'"
        Dim comando As New OleDbCommand(ordensql, conexion)

        conexion.Open()
        If comando.ExecuteNonQuery() Then
            MsgBox("Tanque de Sin plomo 95 Rellenado con exito")
            Label5.Text = "10000/10000"

        Else
            MsgBox("No se puede modificar")
        End If
        conexion.Close()
    End Sub

    Private Sub BRSinPlomo98_Click(sender As Object, e As EventArgs) Handles BRSinPlomo98.Click
        PBSinPlomo98.Value = PBSinPlomo98.Maximum
        Dim ordensql As String = "Update Depositos set Cantidad = " + PBSinPlomo98.Maximum.ToString + " where TipoG = 'SP98'"
        Dim comando As New OleDbCommand(ordensql, conexion)

        conexion.Open()
        If comando.ExecuteNonQuery() Then
            MsgBox("Tanque de Sin plomo 98 Rellenado con exito")
            Label8.Text = "10000/10000"

        Else
            MsgBox("No se puede modificar")
        End If
        conexion.Close()
    End Sub

    Private Sub BRDiesel_Click(sender As Object, e As EventArgs) Handles BRDiesel.Click
        PBDiesel.Value = PBDiesel.Maximum
        Dim ordensql As String = "Update Depositos set Cantidad = " + PBDiesel.Maximum.ToString + " where TipoG = 'Diesel'"
        Dim comando As New OleDbCommand(ordensql, conexion)

        conexion.Open()
        If comando.ExecuteNonQuery() Then
            MsgBox("Tanque de Diesel Rellenado con exito")
            Label7.Text = "10000/10000"

        Else
            MsgBox("No se puede modificar")
        End If
        conexion.Close()
    End Sub

    Private Sub BRDieselPlus_Click(sender As Object, e As EventArgs) Handles BRDieselPlus.Click
        PBDieselPlus.Value = PBDieselPlus.Maximum
        Dim ordensql As String = "Update Depositos set Cantidad = " + PBDieselPlus.Maximum.ToString + " where TipoG = 'DieselPlus'"
        Dim comando As New OleDbCommand(ordensql, conexion)

        conexion.Open()
        If comando.ExecuteNonQuery() Then
            MsgBox("Tanque de Diesel+ Rellenado con exito")
            Label6.Text = "10000/10000"
        Else
            MsgBox("Error con la conexion a la base de datos")
        End If




        conexion.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BRTodos.Click
        PBDieselPlus.Value = PBDieselPlus.Maximum
        PBDiesel.Value = PBDiesel.Maximum
        PBSinPlomo98.Value = PBSinPlomo98.Maximum
        PBSinPlomo95.Value = PBSinPlomo95.Maximum
        Dim ordensql1 As String = "Update Depositos set Cantidad = " + PBSinPlomo95.Maximum.ToString + " where TipoG = 'SP95'"
        Dim ordensql2 As String = "Update Depositos set Cantidad = " + PBSinPlomo98.Maximum.ToString + " where TipoG = 'SP98'"
        Dim ordensql3 As String = "Update Depositos set Cantidad = " + PBDiesel.Maximum.ToString + " where TipoG = 'Diesel'"
        Dim ordensql4 As String = "Update Depositos set Cantidad = " + PBDieselPlus.Maximum.ToString + " where TipoG = 'DieselPlus'"
        Dim comando1 As New OleDbCommand(ordensql1, conexion)
        Dim comando2 As New OleDbCommand(ordensql2, conexion)
        Dim comando3 As New OleDbCommand(ordensql3, conexion)
        Dim comando4 As New OleDbCommand(ordensql4, conexion)
        Label8.Text = "10000/10000"
        Label7.Text = "10000/10000"
        Label5.Text = "10000/10000"
        Label6.Text = "10000/10000"
        conexion.Open()
        If comando1.ExecuteNonQuery() And comando2.ExecuteNonQuery() And comando3.ExecuteNonQuery() And comando4.ExecuteNonQuery() Then
            MsgBox("Todos los tanques rellenados")
        Else
            MsgBox("Error con la conexion a la base de datos")
        End If

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
        BRSinPlomo95.Visible = False
        BRSinPlomo98.Visible = False
        BRDiesel.Visible = False
        BRDieselPlus.Visible = False
        BRTodos.Visible = False
    End Sub

    Private Sub AdminDepos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ordensql As String = "Select * from Depositos"
        Dim comando As New OleDbCommand(ordensql, conexion)
        conexion.Open()
        Dim res As OleDbDataReader = comando.ExecuteReader
        While res.Read
            If res("TipoG") = "SP98" Then
                PBSinPlomo98.Value = res("Cantidad")
                Label8.Text = res("Cantidad").ToString + "/10000"
            ElseIf res("TipoG") = "SP95" Then
                PBSinPlomo95.Value = res("Cantidad")
                Label5.Text = res("Cantidad").ToString + "/10000"
            ElseIf res("TipoG") = "Diesel" Then
                PBDiesel.Value = res("Cantidad")
                Label7.Text = res("Cantidad").ToString + "/10000"
            ElseIf res("TipoG") = "DieselPlus" Then
                PBDieselPlus.Value = res("Cantidad")
                Label6.Text = res("Cantidad").ToString + "/10000"
            End If
        End While
        conexion.Close()
    End Sub


End Class
