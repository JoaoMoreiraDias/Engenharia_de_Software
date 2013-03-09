Public Class Cliente
    Private _descricao As String
    Public Property Descricao As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            If Not _descricao = "" Then
                _descricao = value
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

    Public Property DataAdesao As DateTime

    Private Licencas As Dictionary(Of Integer, Licenca)

    Public Sub New(ByVal c As Integer, ByVal d As String, ByVal dt As DateTime) ' construtor
        Descricao = d
        Codigo = c
        DataAdesao = dt

        Licencas = New Dictionary(Of Integer, Licenca)


    End Sub

    Public Sub JuntaLicenca(ByVal l As Licenca) ' junta licencas ao dicionario de licencas
        Try
            Licencas.Add(l.Codigo, l)
        Catch ex As Exception
        End Try
    End Sub

    Public Function getListaEntreDatas(ByVal DataInicial As DateTime, ByVal DataFinal As DateTime) As List(Of Licenca) ' Lista licencas entre 2 datas
        Dim ListaDatas As List(Of Licenca) = New List(Of Licenca)
        For Each d As Licenca In Licencas.Values()
            If d.DataCompra > DataInicial And d.DataCompra < DataFinal Then
                ListaDatas.Add(d)
            End If

        Next
        Return ListaDatas
    End Function

    Public Function GetTodasLicencas() As List(Of Licenca)
        Dim ListaLicencas As List(Of Licenca) = New List(Of Licenca)

        For Each l As Licenca In Licencas.Values()
            ListaLicencas.Add(l)
        Next
        Return ListaLicencas
    End Function



    'Public Function TotalLicencasProduto(ByVal prd As Integer) As Double
    '    Dim total As Double = 0
    '    For Each l As Licenca In Licencas.Values()
    '        If l.Produto.Equals(prd) Then
    '            total += l.Quantidade
    '        End If
    '    Next
    '    Return total
    'End Function


    Public Function totalLicencas() As Double
        Dim q As Integer = 0
        For Each l As Licenca In Licencas.Values
            q += l.Quantidade
        Next
        Return q
    End Function


    Public Sub apagarLicencas(ByVal cod As Integer) ' elimina licencas do dicionario
        Try
            Licencas.Remove(cod)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub





End Class
