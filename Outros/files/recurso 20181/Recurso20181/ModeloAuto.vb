Public Class ModeloAuto

    Friend ModeloAuto As String

    Public Property Descricao As String
    Public Property Cilindrada As Integer
    Public Property Custo As Integer


    Public Sub New(ByVal D As String, ByVal CI As Integer, ByVal CU As Integer)

        Descricao = D
        Cilindrada = CI
        Custo = CU

    End Sub

End Class
