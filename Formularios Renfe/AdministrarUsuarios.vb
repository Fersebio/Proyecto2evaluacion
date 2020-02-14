
Imports BC_Montaditos
Imports System.Data.OleDb

Public Class AdministrarUsuarios
    Public conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Repsol_db.accdb")
    Public adaptador As New OleDbDataAdapter("Select * from Usuarios", conexion)
    Public midataset As New DataSet
    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub AdministrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptador.Fill(midataset, "Tabla1")
        TBId.DataBindings.Add("text", midataset, "Tabla1.ID")
        TBNombre.DataBindings.Add("text", midataset, "Tabla1.Nombre")
        TBApellido.DataBindings.Add("text", midataset, "Tabla1.Apellidos")
        TBUsuario.DataBindings.Add("text", midataset, "Tabla1.Usuario")
        TBTelefono.DataBindings.Add("text", midataset, "Tabla1.Telefono")
        TBContraseña.DataBindings.Add("text", midataset, "Tabla1.Contraseña")
        TBDNI.DataBindings.Add("text", midataset, "Tabla1.DNI")
        CBRol.DataBindings.Add("text", midataset, "Tabla1.Rol")
        TBCorreo.DataBindings.Add("text", midataset, "Tabla1.Email")
        DataGridView1.DataSource = midataset
        DataGridView1.DataMember = "Tabla1"
    End Sub

    Private Sub NuevoUsuarioTSMI_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioTSMI.Click
        TBId.Clear()
        TBNombre.Clear()
        TBApellido.Clear()
        TBUsuario.Clear()
        TBTelefono.Clear()
        TBCorreo.Clear()
        TBContraseña.Clear()
        TBDNI.Clear()
    End Sub

    Private Sub GuardarTSMI_Click(sender As Object, e As EventArgs) Handles GuardarTSMI.Click
        Dim ordensql As String = "Insert into Usuarios(Nombre,Apellidos,Usuario,Contraseña,Telefono,DNI,Email,Rol) values (@nom,@ape,@usu,@con,@tel,@dni,@ema,rol)"
        Dim comando As New OleDbCommand(ordensql, conexion)
        comando.Parameters.AddWithValue("@nom", TBNombre.Text)
        comando.Parameters.AddWithValue("@ape", TBApellido.Text)
        comando.Parameters.AddWithValue("@usu", TBUsuario.Text)
        comando.Parameters.AddWithValue("@con", TBContraseña.Text)
        comando.Parameters.AddWithValue("@tel", TBTelefono.Text)
        comando.Parameters.AddWithValue("@dni", TBDNI.Text)
        comando.Parameters.AddWithValue("@ema", TBCorreo.Text)
        comando.Parameters.AddWithValue("@rol", CBRol.Text)
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

    Private Sub ModificarTSMI_Click(sender As Object, e As EventArgs) Handles ModificarTSMI.Click
        Try
            Dim ordensql As String = "Update Usuarios Set Nombre=@nom, Apellidos=@ape, Usuario=@usu, Contraseña=@con,Telefono=@tel,DNI=@dni,Email=@ema,Rol=@rol where id = " + TBId.Text
            Dim comando As New OleDbCommand(ordensql, conexion)
            comando.Parameters.AddWithValue("@nom", TBNombre.Text)
            comando.Parameters.AddWithValue("@ape", TBApellido.Text)
            comando.Parameters.AddWithValue("@usu", TBUsuario.Text)
            comando.Parameters.AddWithValue("@con", TBContraseña.Text)
            comando.Parameters.AddWithValue("@tel", TBTelefono.Text)
            comando.Parameters.AddWithValue("@dni", TBDNI.Text)
            comando.Parameters.AddWithValue("@ema", TBCorreo.Text)
            comando.Parameters.AddWithValue("@rol", CBRol.Text)
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

    Private Sub BorrarTSMI_Click(sender As Object, e As EventArgs) Handles BorrarTSMI.Click
        Dim res As Integer
        Dim ordensql As String = "Delete from Usuarios Where Id=@id"
        Dim comando As New OleDbCommand(ordensql, conexion)
        comando.Parameters.AddWithValue("@nom", TBId.Text)
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

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        NuevoUsuarioTSMI_Click(sender, e)
        Dim var As String = InputBox("Dime nombre del Usuario a buscar...")
        Dim m As Integer = 0
        Dim comando As New OleDbCommand("Select * from Usuarios where Nombre = @nom", conexion)
        comando.Parameters.AddWithValue("@nom", var)
        conexion.Open()
        Dim res As OleDbDataReader = comando.ExecuteReader
        While res.Read
            If res.Item("Nombre") = var Then
                TBId.Text = res("Id")
                TBNombre.Text = res("Nombre")
                TBApellido.Text = res("Apellidos")
                TBUsuario.Text = res("Usuario")
                TBContraseña.Text = res("Contraseña")
                TBTelefono.Text = res("Telefono")
                TBDNI.Text = res("DNI")
                TBCorreo.Text = res("Email")
                CBRol.Text = res("Rol")
                m = 1
            End If
        End While
        conexion.Close()
        If m = 0 Then
            MsgBox("Busqueda fallida")
        End If
    End Sub
End Class
