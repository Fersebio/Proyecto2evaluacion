Public Class Prod_Tiquet
    Public cantidad As Integer
    Public nombre As String
    Public precio As Double

    Public Sub New(ByVal cantidad As Integer, ByVal nombre As String, ByVal precio As Double)
        Me.cantidad = cantidad
        Me.nombre = nombre
        Me.precio = precio
    End Sub
    Public Sub New()

    End Sub
End Class
