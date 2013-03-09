Public Class Licenca
    Public Property Produto As Produto
    Public Property Licenciamento As Licenciamento
    Public Property DataCompra As DateTime

    Private _codigo As Integer
    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)

            If _codigo > 0 Then
                _codigo = value
            End If
        End Set
    End Property

    Public Property ChaveProduto As ChaveProduto
    Public Property Quantidade As Integer

    Public Sub New(ByVal p As Produto, ByVal l As Licenciamento, ByVal c As Integer, ByVal dc As DateTime, ByVal ChP As ChaveProduto, ByVal q As Integer)
        Produto = p
        Licenciamento = l
        Codigo = c
        DataCompra = dc
        ChaveProduto = ChP
        Quantidade = q

    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("Produto:   Licenciamento:   Codigo.:  Data de Compra.: Chave do Produto.: Quantidade.:", Produto, Licenciamento, Codigo, DataCompra, ChaveProduto, Quantidade)
    End Function



End Class
