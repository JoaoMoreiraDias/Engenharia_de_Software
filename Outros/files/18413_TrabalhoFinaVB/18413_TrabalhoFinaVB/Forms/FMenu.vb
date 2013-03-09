Public Class FMenu
    Public d As Dados
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LTitulo.Click

    End Sub

    Private Sub BSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSair.Click
        '
        ' GRAVAR FICHEIROS
        '
        Me.Close()

    End Sub

    Private Sub BCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCliente.Click
        FCliente.Show()
    End Sub

    Private Sub BProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BProduto.Click
        FProduto.Show()
    End Sub

    Private Sub FMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d = New Dados
        d.c.JuntaClientes(New Cliente(1, "Marcio", "20/11/2011"))
        d.c.JuntaClientes(New Cliente(2, "Carlos", "27/12/2011"))
        d.c.JuntaClientes(New Cliente(3, "André", "27/12/2011"))
        d.c.JuntaClientes(New Cliente(4, "Antonio", "29/12/2011"))
        d.c.JuntaClientes(New Cliente(5, "Pedro", "29/12/2011"))
        d.c.JuntaClientes(New Cliente(6, "Adriana", "30/12/2011"))
        d.c.JuntaClientes(New Cliente(7, "Cleo", "31/12/2011"))

    End Sub

End Class