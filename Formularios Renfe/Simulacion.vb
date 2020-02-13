Imports System.Data.OleDb
Public Class Simulacion
    Dim tiempo As Integer
    Dim i As Integer = 0
    Dim id As Integer
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Depositos", conexion)
    Public midataset As New DataSet
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBS1.CheckedChanged

    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PBSacarManguera.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBS1.Checked Then
            PBS1.Visible = True
        ElseIf RBS2.Checked Then
            PBS2.Visible = True
        ElseIf RBS3.Checked Then
            PBS3.Visible = True
        ElseIf RBS4.Checked Then
            PBS4.Visible = True
        Else
            MsgBox("Por favor seleccione surtidor")
            Exit Sub
        End If
        id = 1
        tiempo = 70
        PBAparcar.Enabled = True
        PBAparcar.Visible = True
        Timer1.Enabled = True
        Button1.Enabled = False
        RBS1.Enabled = False
        RBS2.Enabled = False
        RBS3.Enabled = False
        RBS4.Enabled = False


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1
        If i = tiempo Then
            PBAparcar.Enabled = False
            PBGuardarManguera.Enabled = False
            PBSacarManguera.Enabled = False
            PBAparcar.Visible = False
            PBGuardarManguera.Visible = False
            PBSacarManguera.Visible = False
            Timer1.Enabled = False
            If id = 1 Then
                Button2.Enabled = True
            ElseIf id = 2 Then
                Button3.Enabled = True
            ElseIf id = 3 Then
                Button5.Enabled = True
            End If

            i = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id = 2
        tiempo = 40
        PBSacarManguera.Enabled = True
        PBSacarManguera.Visible = True
        Timer1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        id = 3
        tiempo = 20
        PBGuardarManguera.Enabled = True
        PBGuardarManguera.Visible = True
        Timer1.Enabled = True

        Button4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = True
        Button3.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BTerminar.Click
        Button4.Enabled = True
        Panel2.Enabled = False
        Dim litros As Single = TBLitros.Text()
        If RBSP95.Checked Then
            Dim ordensql As String = "Select Cantidad from Depositos where TipoG='SP95'"
            Dim comando As New OleDbCommand(ordensql, conexion)
            conexion.Open()
            Dim res As OleDbDataReader = comando.ExecuteReader
            While res.Read
                litros = res("Cantidad")
            End While
            Dim total As Integer = litros - TBLitros.Text

            Dim ordensql1 As String = "Update Depositos set Cantidad = " + total.ToString + " where TipoG = 'SP95'"
            Dim comando1 As New OleDbCommand(ordensql1, conexion)
            comando1.ExecuteNonQuery()

            conexion.Close()
        ElseIf RBSP98.Checked Then
            Dim ordensql As String = "Select Cantidad from Depositos where TipoG='SP98'"
            Dim comando As New OleDbCommand(ordensql, conexion)
            conexion.Open()
            Dim res As OleDbDataReader = comando.ExecuteReader
            While res.Read
                litros = res("Cantidad")
            End While
            Dim total As Integer = litros - TBLitros.Text

            Dim ordensql1 As String = "Update Depositos set Cantidad = " + total.ToString + " where TipoG = 'SP98'"
            Dim comando1 As New OleDbCommand(ordensql1, conexion)
            comando1.ExecuteNonQuery()

            conexion.Close()
        ElseIf RBDiesel.Checked Then
            Dim ordensql As String = "Select Cantidad from Depositos where TipoG='Diesel'"
            Dim comando As New OleDbCommand(ordensql, conexion)
            conexion.Open()
            Dim res As OleDbDataReader = comando.ExecuteReader
            While res.Read
                litros = res("Cantidad")
            End While
            Dim total As Integer = litros - TBLitros.Text

            Dim ordensql1 As String = "Update Depositos set Cantidad = " + total.ToString + " where TipoG = 'Diesel'"
            Dim comando1 As New OleDbCommand(ordensql1, conexion)
            comando1.ExecuteNonQuery()

            conexion.Close()
        ElseIf RBDieselPlus.Checked Then
            Dim ordensql As String = "Select Cantidad from Depositos where TipoG='DieselPlus'"
            Dim comando As New OleDbCommand(ordensql, conexion)
            conexion.Open()
            Dim res As OleDbDataReader = comando.ExecuteReader
            While res.Read
                litros = res("Cantidad")
            End While
            Dim total As Integer = litros - TBLitros.Text

            Dim ordensql1 As String = "Update Depositos set Cantidad = " + total.ToString + " where TipoG = 'DieselPlus'"
            Dim comando1 As New OleDbCommand(ordensql1, conexion)
            comando1.ExecuteNonQuery()

            conexion.Close()

        End If
        Panel2.Visible = False
    End Sub

    Private Sub BIniciar_Click(sender As Object, e As EventArgs) Handles BIniciar.Click

        If RBSP95.Checked = False And RBSP98.Checked = False And RBDiesel.Checked = False And RBDieselPlus.Checked = False Then
            MsgBox("Selecciona un tipo de gasolina")
        Else
            Timer2.Enabled = True
            BIniciar.Enabled = False
            BParar.Enabled = True
            BTerminar.Enabled = False
            RBDiesel.Enabled = False
            RBSP95.Enabled = False
            RBSP98.Enabled = False
            RBDieselPlus.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If RBSP95.Checked Then
            TBLitros.Text = TBLitros.Text + 0.1
            TBPrecio.Text = TBPrecio.Text + 0.129
        ElseIf RBSP98.Checked Then
            TBLitros.Text = TBLitros.Text + 0.1
            TBPrecio.Text = TBPrecio.Text + 0.142
        ElseIf RBDiesel.Checked Then
            TBLitros.Text = TBLitros.Text + 0.1
            TBPrecio.Text = TBPrecio.Text + 0.12
        ElseIf RBDieselPlus.Checked Then
            TBLitros.Text = TBLitros.Text + 0.1
            TBPrecio.Text = TBPrecio.Text + 0.126

        End If
    End Sub

    Private Sub BParar_Click(sender As Object, e As EventArgs) Handles BParar.Click
        Timer2.Enabled = False
        BIniciar.Enabled = True
        BParar.Enabled = False
        BTerminar.Enabled = True


    End Sub


End Class