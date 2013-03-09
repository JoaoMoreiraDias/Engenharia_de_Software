Public Class AutoHibrido
    Inherits ModeloAuto

    Public Property Autonomia As Integer


    Public Sub New(ByVal D As String, ByVal CI As Integer, ByVal CU As Integer, ByVal AT As Integer)

        MyBase.New(D, CI, CU)

        Autonomia = AT


    End Sub

End Class
