Public Class Automovel

    Public Property Matricula As String
    Public Property ModeloDescricao As String



    Public Sub New(ByVal m As String, ByVal MD As String)


        Matricula = m
        ModeloDescricao = MD

    End Sub

    Public Overrides Function toString() As String

        Return "Matricula" & Matricula & "ModeloDescricao" & ModeloDescricao

    End Function


End Class
