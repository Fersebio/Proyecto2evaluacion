Public Class Gas
    Public TipoG As String
    Public Cantidad, Precio As Double

    Public Sub New(ByVal TipoG As String, ByVal Cantidad As Double, ByVal Precio As Double)
        Me.TipoG = TipoG
        Me.Cantidad = Cantidad
        Me.Precio = Precio
    End Sub
End Class
