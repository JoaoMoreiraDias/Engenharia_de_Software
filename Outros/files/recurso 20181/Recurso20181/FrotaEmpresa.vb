Public Class FrotaEmpresa
    Public Property NomeEmpresa As String
    Dim ListaAuto As List(Of Automovel)


    Public Sub New(ByVal NE As String)

        NomeEmpresa = NE
        ListaAuto = New List(Of Automovel)


    End Sub



    Public Function GetAutomovel() As String

    End Function
End Class
