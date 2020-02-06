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
            MsgBox("Actualizacion correcta")

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
            MsgBox("Actualizacion correcta")

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
            MsgBox("Actualizacion correcta")

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
            MsgBox("Actualizacion correcta")

        Else
            MsgBox("No se puede modificar")
        End If
        conexion.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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
        conexion.Open()
        If comando1.ExecuteNonQuery() And comando2.ExecuteNonQuery() And comando3.ExecuteNonQuery() And comando4.ExecuteNonQuery() Then
            MsgBox("Actualizacion correcta")
        Else
            MsgBox("No se puede modificar")
        End If

    End Sub
End Class
