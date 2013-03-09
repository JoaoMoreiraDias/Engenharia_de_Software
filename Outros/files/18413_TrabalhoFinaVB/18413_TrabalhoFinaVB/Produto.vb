Public Class Produto
    Private _nome As String
    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            If Not _nome = "" Then
                _nome = value
            End If
        End Set
    End Property

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

    Private _precoUnitario As Double
    Public Property PrecoUnitario As Double
        Get
            Return _precoUnitario
        End Get
        Set(ByVal value As Double)
            If _precoUnitario > 0 Then
                _precoUnitario = value
            End If
        End Set
    End Property

    Private Licenciamentos As Dictionary(Of Integer, Licenciamento) 'lista que vai indicar todas as maneiras de vender o produto


    Public Sub New(ByVal n As String, ByVal c As Integer, ByVal PU As Double) ' construtor
        Nome = n
        Codigo = c
        PrecoUnitario = PU

        Licenciamentos = New Dictionary(Of Integer, Licenciamento)


    End Sub

    Public Sub JuntaLicenciamentos(ByVal cod As Integer, ByVal l As Licenciamento) ' junta licenciamento ao dicionario de licenciamentos
        Try
            Licenciamentos.Add(cod, l)
        Catch ex As Exception
        End Try
    End Sub

    Public Function getLicenciamentos(ByVal ref As Integer) As Licenciamento  ' retorna um Licenciamento dado a referencia
        Try
            Return Licenciamentos.Item(ref)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getListaLicenciametos() As List(Of Licenciamento) ' retorna lista com todos os  Licenciamentos
        Dim listaLicenciamentos As List(Of Licenciamento) = New List(Of Licenciamento)

        For Each lcm As Licenciamento In Licenciamentos.Values()
            listaLicenciamentos.Add(lcm)
        Next

        Return listaLicenciamentos
    End Function

    Public Sub AlteraNome(ByVal ref As Integer, ByVal novoNome As String) ' altera o nome do tipo de Licenciamento dado a referencia
        Try
            Dim l As Licenciamento = Licenciamentos.Item(ref)
            l.Nome = novoNome
        Catch ex As Exception
        End Try
    End Sub



    Public Sub apagarLicenciamentos(ByVal cod As Integer) ' elimina licenciamentos do dicionario
        Try
            Licenciamentos.Remove(cod)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub



End Class
