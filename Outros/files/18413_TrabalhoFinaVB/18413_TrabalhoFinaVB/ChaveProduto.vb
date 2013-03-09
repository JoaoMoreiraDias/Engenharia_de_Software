Public Class ChaveProduto

    Private Property Chave As String

    Public Sub New(ByVal c As String) ' construtor
        Chave = c

    End Sub

    Public Overrides Function ToString() As String

        Return "" & Chave & "" 'vbTab - faz um TAB

    End Function



End Class
