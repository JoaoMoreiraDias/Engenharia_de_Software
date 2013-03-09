Public Class ProdutoDict
    Private Produtos As Dictionary(Of Integer, Produto) ' lista todos os produtos - opcional

    Public Sub New()
        Produtos = New Dictionary(Of Integer, Produto)

    End Sub

    Public Sub JuntaProdutos(ByVal cod As Integer, ByVal p As Produto) ' junta Produto ao dicionario de Produtos
        Try
            Produtos.Add(cod, p)
        Catch ex As Exception
        End Try
    End Sub

    Public Function getProduto(ByVal cod As Integer) As Produto ' retorna um Produto dado o Codigo
        Try
            Return Produtos.Item(cod)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getListaProdutos() As List(Of Produto) ' retorna lista com todos os  Produtos
        Dim listaProdutos As List(Of Produto) = New List(Of Produto)

        For Each clt As Produto In Produtos.Values()
            listaProdutos.Add(clt)
        Next

        Return listaProdutos
    End Function

    Public Sub AlteraNome(ByVal cod As Integer, ByVal novoNome As String) ' altera o nome do Produto dado o codigo
        Try
            Dim c As Produto = Produtos.Item(cod)
            c.Nome = novoNome
        Catch ex As Exception
        End Try
    End Sub

    Public Sub apagarProdutos(ByVal cod As Integer) ' elimina Produtos do dicionario
        Produtos.Remove(cod)
    End Sub




End Class
