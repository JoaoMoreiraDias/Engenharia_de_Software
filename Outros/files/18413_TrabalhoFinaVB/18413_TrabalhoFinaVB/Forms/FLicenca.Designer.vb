<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLicenca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BGravar = New System.Windows.Forms.Button()
        Me.LProduto = New System.Windows.Forms.Label()
        Me.LCodigo = New System.Windows.Forms.Label()
        Me.LDataCompra = New System.Windows.Forms.Label()
        Me.LLicenciamento = New System.Windows.Forms.Label()
        Me.LQuantidade = New System.Windows.Forms.Label()
        Me.LChaveProduto = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TCodigo = New System.Windows.Forms.TextBox()
        Me.TDataCompra = New System.Windows.Forms.TextBox()
        Me.TChaveProduto = New System.Windows.Forms.TextBox()
        Me.TQuantidade = New System.Windows.Forms.TextBox()
        Me.BSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BGravar
        '
        Me.BGravar.Location = New System.Drawing.Point(646, 407)
        Me.BGravar.Name = "BGravar"
        Me.BGravar.Size = New System.Drawing.Size(75, 23)
        Me.BGravar.TabIndex = 0
        Me.BGravar.Text = "Gravar"
        Me.BGravar.UseVisualStyleBackColor = True
        '
        'LProduto
        '
        Me.LProduto.Location = New System.Drawing.Point(52, 63)
        Me.LProduto.Name = "LProduto"
        Me.LProduto.Size = New System.Drawing.Size(78, 20)
        Me.LProduto.TabIndex = 1
        Me.LProduto.Text = "Produto"
        '
        'LCodigo
        '
        Me.LCodigo.Location = New System.Drawing.Point(52, 142)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(78, 20)
        Me.LCodigo.TabIndex = 2
        Me.LCodigo.Text = "Codigo"
        '
        'LDataCompra
        '
        Me.LDataCompra.Location = New System.Drawing.Point(52, 180)
        Me.LDataCompra.Name = "LDataCompra"
        Me.LDataCompra.Size = New System.Drawing.Size(93, 20)
        Me.LDataCompra.TabIndex = 3
        Me.LDataCompra.Text = "Data de Compra"
        '
        'LLicenciamento
        '
        Me.LLicenciamento.Location = New System.Drawing.Point(52, 105)
        Me.LLicenciamento.Name = "LLicenciamento"
        Me.LLicenciamento.Size = New System.Drawing.Size(78, 20)
        Me.LLicenciamento.TabIndex = 4
        Me.LLicenciamento.Text = "Licenciamento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LQuantidade
        '
        Me.LQuantidade.Location = New System.Drawing.Point(52, 211)
        Me.LQuantidade.Name = "LQuantidade"
        Me.LQuantidade.Size = New System.Drawing.Size(78, 20)
        Me.LQuantidade.TabIndex = 5
        Me.LQuantidade.Text = "Quantidade"
        '
        'LChaveProduto
        '
        Me.LChaveProduto.Location = New System.Drawing.Point(52, 242)
        Me.LChaveProduto.Name = "LChaveProduto"
        Me.LChaveProduto.Size = New System.Drawing.Size(99, 20)
        Me.LChaveProduto.TabIndex = 6
        Me.LChaveProduto.Text = "Chave do Produto"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(179, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(179, 103)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'TCodigo
        '
        Me.TCodigo.Location = New System.Drawing.Point(179, 142)
        Me.TCodigo.Name = "TCodigo"
        Me.TCodigo.Size = New System.Drawing.Size(121, 20)
        Me.TCodigo.TabIndex = 9
        '
        'TDataCompra
        '
        Me.TDataCompra.Location = New System.Drawing.Point(179, 177)
        Me.TDataCompra.Name = "TDataCompra"
        Me.TDataCompra.Size = New System.Drawing.Size(121, 20)
        Me.TDataCompra.TabIndex = 10
        '
        'TChaveProduto
        '
        Me.TChaveProduto.Location = New System.Drawing.Point(179, 239)
        Me.TChaveProduto.Name = "TChaveProduto"
        Me.TChaveProduto.Size = New System.Drawing.Size(121, 20)
        Me.TChaveProduto.TabIndex = 11
        '
        'TQuantidade
        '
        Me.TQuantidade.Location = New System.Drawing.Point(179, 205)
        Me.TQuantidade.Name = "TQuantidade"
        Me.TQuantidade.Size = New System.Drawing.Size(121, 20)
        Me.TQuantidade.TabIndex = 12
        '
        'BSair
        '
        Me.BSair.Location = New System.Drawing.Point(744, 407)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(75, 23)
        Me.BSair.TabIndex = 13
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = True
        '
        'FLicenca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 442)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.TQuantidade)
        Me.Controls.Add(Me.TChaveProduto)
        Me.Controls.Add(Me.TDataCompra)
        Me.Controls.Add(Me.TCodigo)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LChaveProduto)
        Me.Controls.Add(Me.LQuantidade)
        Me.Controls.Add(Me.LLicenciamento)
        Me.Controls.Add(Me.LDataCompra)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.LProduto)
        Me.Controls.Add(Me.BGravar)
        Me.Name = "FLicenca"
        Me.Text = "Licenca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BGravar As System.Windows.Forms.Button
    Friend WithEvents LProduto As System.Windows.Forms.Label
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents LDataCompra As System.Windows.Forms.Label
    Friend WithEvents LLicenciamento As System.Windows.Forms.Label
    Friend WithEvents LQuantidade As System.Windows.Forms.Label
    Friend WithEvents LChaveProduto As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TDataCompra As System.Windows.Forms.TextBox
    Friend WithEvents TChaveProduto As System.Windows.Forms.TextBox
    Friend WithEvents TQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents BSair As System.Windows.Forms.Button
End Class
