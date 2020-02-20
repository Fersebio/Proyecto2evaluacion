Public Class Inicio
    Private Sub AdminUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminUsuariosToolStripMenuItem.Click
        AdministrarUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        StockP.Show()
        Me.Hide()
    End Sub

    Private Sub DepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositosToolStripMenuItem.Click
        AdminDepos.Show()
        Me.Hide()
    End Sub

    Private Sub AdminDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminDepositosToolStripMenuItem.Click
        AdminDepos.BRSinPlomo95.Visible = True
        AdminDepos.BRSinPlomo98.Visible = True
        AdminDepos.BRDiesel.Visible = True
        AdminDepos.BRDieselPlus.Visible = True
        AdminDepos.BRTodos.Visible = True
        AdminDepos.Show()
        Me.Hide()

    End Sub

    Private Sub AdminProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminProductosToolStripMenuItem.Click
        AdminProductos.Show()
        Me.Hide()

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Bienvenido " + Prod.Nombre
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        InicioSesion.Show()
        Me.Close()
        AdminToolStripMenuItem.Visible = False

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim a As Integer = MsgBox("¿Esta seguro que desea salir?", 36, "Salir")
        If a = 6 Then
            Me.Close()
            InicioSesion.Close()

        End If
    End Sub




    Private Sub SimulacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulacionToolStripMenuItem.Click
        Simulacion.Show()
        Me.Hide()
    End Sub
End Class