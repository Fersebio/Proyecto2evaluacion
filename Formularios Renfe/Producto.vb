Public Class Producto
    Public Tipo, Nombre As String
    Public stock As Integer
    Public precio As Double

    Public Sub New(ByVal tipo As String, ByVal nombre As String, ByVal stock As Integer, ByVal precio As Double)
        Me.Tipo = tipo
        Me.Nombre = nombre
        Me.stock = stock
        Me.precio = precio
    End Sub
End Class