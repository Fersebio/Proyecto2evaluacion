Imports System.Data.OleDb
Public Class InicioSesion
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Public midataset As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim comando As New OleDbCommand("Select Usuario, Contraseña,Rol from Usuarios where Usuario=@cod", conexion)
            comando.Parameters.AddWithValue("@cod", TextBox1.Text)
            conexion.Open()
            Dim res As OleDbDataReader = comando.ExecuteReader
            While res.Read
                If res("Usuario") = TextBox1.Text And res("Contraseña") = TextBox2.Text Then
                    If res.Item("Rol") = "Admin" Then
                        Producto.Nombre = res("Usuario")
                        Inicio.AdminToolStripMenuItem.Visible = True
                        Inicio.Show()
                        Me.Hide()
                    Else
                        Producto.Nombre = res("Usuario")
                        Inicio.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("El nombre de usuario es incorrecto",, "Usuario incorrecto")
                    TextBox1.Clear()
                    TextBox2.Clear()
                End If
        End While
        conexion.Close()
        Catch ex As Exception
        MsgBox("El nombre de usuario es incorrecto",, "Usuario incorrecto")
        TextBox1.Clear()
        TextBox2.Clear()
        End Try

    End Sub
End Class