Public Class Clientela
    Public Clientes As List(Of Cliente) ' Dict de Clientes

    Public Sub New()
        Clientes = New List(Of Cliente)

    End Sub

    Public Sub JuntaClientes(ByVal c As Cliente) ' junta clientes ao dicionario de clientes 
        Try
            Clientes.Add(c)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AlteraDescricao(ByVal cod As Integer, ByVal novoNome As String) ' altera o nome do Cliente dado o codigo
        Try
            Dim c As Cliente = Clientes.Item(cod)
            c.Descricao = novoNome
        Catch ex As Exception
        End Try
    End Sub

    Public Function getListaClientes() As List(Of Cliente) ' retorna lista com todos os  clientes
        Dim listaClientes As List(Of Cliente) = New List(Of Cliente)

        For Each clt As Cliente In Clientes
            listaClientes.Add(clt)
        Next

        Return listaClientes
    End Function

    Public Function getCliente(ByVal cod As Integer) As Cliente ' retorna um Cliente
        Try
            Return Clientes.Item(cod)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub apagarCliente(ByVal cod As Integer) ' elimina clientes do dicionario
        '       Clientes.Remove(cod)
    End Sub


    '

    Public Function getListaEntreDatasAdesao(ByVal DataInicial As DateTime, ByVal DataFinal As DateTime) As List(Of Cliente) ' Lista Clientes por data de adesao
        Dim ListaDatas As List(Of Cliente) = New List(Of Cliente)
        For Each d As Cliente In Clientes
            If d.DataAdesao > DataInicial And d.DataAdesao < DataFinal Then
                ListaDatas.Add(d)
            End If

        Next
        Return ListaDatas
    End Function
End Class
