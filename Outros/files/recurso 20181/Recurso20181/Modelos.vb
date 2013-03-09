Public Class Modelos

    Dim TodosModelos As Dictionary(Of String, ModeloAuto)

    Public Sub New()

        TodosModelos = New Dictionary(Of String, ModeloAuto)

    End Sub

    Public Sub juntaModelo(ByVal p As ModeloAuto)
        If Not TodosModelos.ContainsKey(p.ModeloAuto) Then
            TodosModelos.Add(p.ModeloAuto, p)

        End If

    End Sub

    Public Function GetAutomovel(ByVal a As String) As Automovel
        For Each aut As Automovel In FrotaEmpresa()
            If aut.Matricula = a Then
                Return aut
            End If
        Next
        Return Nothing
    End Function

    Private Function FrotaEmpresa() As Object
        Throw New NotImplementedException
    End Function

    Public Sub ImprimeTodos()
        Dim TotalA As Double = 0
        For Each m As Automovel In FrotaEmpresa()
            Dim ma As ModeloAuto = Modelos(t.Modelo)
            If ma IsNot Nothing Then
                Console.WriteLine(t.ToString & ma.ToString)
                TotalA += ma.Custo

            End If
        Next
        Console.WriteLine("Custo Automoveis total: " & TotalA)
    End Sub

    Private Function Modelos(ByVal p As String) As ModeloAuto
        Return TodosModelos.Item(p)
    End Function

    Private Function t() As Object
        Throw New NotImplementedException
    End Function


End Class
