Imports System.ComponentModel

Public Class FCliente
    Public Clientes As New List(Of Cliente) ' Dict de Clientes

    Private Sub FCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Clientes.Add(New Cliente(1, "Marcio", "20/11/2011"))
        Clientes.Add(New Cliente(2, "Carlos", "27/12/2011"))
        Clientes.Add(New Cliente(3, "André", "27/12/2011"))
        Clientes.Add(New Cliente(4, "Antonio", "29/12/2011"))
        Clientes.Add(New Cliente(5, "Pedro", "29/12/2011"))
        Clientes.Add(New Cliente(6, "Adriana", "30/12/2011"))
        Clientes.Add(New Cliente(7, "Cleo", "31/12/2011"))

        BindingNavigator1.BindingSource = BindingSource1
        BindingSource1.DataSource = Clientes
        TDescricao.DataBindings.Add("Text", BindingSource1, "Descricao")
        TCodigo.DataBindings.Add("Text", BindingSource1, "Codigo")


        'Dim l As New Licenca

        'l.JuntaLicenca(New Licenca("Office", "Dinheiro", 1, "20/11/2011", 100, 2))
        'l.JuntaLicenca(New Licenca("Steam", "Dinheiro", 2, "20/11/2011", 101, 4))
        'l.JuntaLicenca(New Licenca("Antivirus", "Dinheiro", 3, "20/11/2011", 102, 1))
        'l.JuntaLicenca(New Licenca("Photoshop", "Dinheiro", 4, "20/11/2011", 103, 5))
        'l.JuntaLicenca(New Licenca("Visual Studio", "Dinheiro", 5, "20/11/2011", 104, 1))


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub




    Private Sub BListaDatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BListaDatas.Click
        Dim st As String = ""
        'For Each a As Cliente In BListaDatas

        '    st &= a.ToString & vbCrLf 'vbCrLf muda de linha

        'Next
        MsgBox(st, MsgBoxStyle.OkOnly, " Lista dos Alunos")
    End Sub
End Class