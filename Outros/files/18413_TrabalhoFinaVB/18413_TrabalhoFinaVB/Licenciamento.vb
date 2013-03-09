Public Class Licenciamento

    Public Property Nome As String
    Public Property Referencia As Integer
    Public Property DescVolume As Double
    Public Property QuantMinima As Integer
    Public Property QuantMaxima As Integer
    Public Property Validade As TimeSpan

    Public Sub New(ByVal n As String, ByVal r As Integer, ByVal dv As Double, ByVal QMin As Integer, ByVal QMax As Integer, ByVal V As TimeSpan)

        Nome = n
        Referencia = r
        DescVolume = dv
        QuantMinima = QMin
        QuantMaxima = QMax
        Validade = V

    End Sub




End Class
