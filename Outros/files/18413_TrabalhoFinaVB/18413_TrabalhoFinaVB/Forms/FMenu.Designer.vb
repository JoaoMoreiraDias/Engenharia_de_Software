<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Me.BCliente = New System.Windows.Forms.Button()
        Me.BProduto = New System.Windows.Forms.Button()
        Me.BLicenciamento = New System.Windows.Forms.Button()
        Me.BLicenca = New System.Windows.Forms.Button()
        Me.BChaveProduto = New System.Windows.Forms.Button()
        Me.BSair = New System.Windows.Forms.Button()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BCliente
        '
        Me.BCliente.Location = New System.Drawing.Point(83, 95)
        Me.BCliente.Name = "BCliente"
        Me.BCliente.Size = New System.Drawing.Size(100, 59)
        Me.BCliente.TabIndex = 0
        Me.BCliente.Text = "Cliente"
        Me.BCliente.UseVisualStyleBackColor = True
        '
        'BProduto
        '
        Me.BProduto.Location = New System.Drawing.Point(227, 95)
        Me.BProduto.Name = "BProduto"
        Me.BProduto.Size = New System.Drawing.Size(96, 59)
        Me.BProduto.TabIndex = 1
        Me.BProduto.Text = "Produto"
        Me.BProduto.UseVisualStyleBackColor = True
        '
        'BLicenciamento
        '
        Me.BLicenciamento.Location = New System.Drawing.Point(83, 181)
        Me.BLicenciamento.Name = "BLicenciamento"
        Me.BLicenciamento.Size = New System.Drawing.Size(100, 51)
        Me.BLicenciamento.TabIndex = 2
        Me.BLicenciamento.Text = "Licenciamento"
        Me.BLicenciamento.UseVisualStyleBackColor = True
        '
        'BLicenca
        '
        Me.BLicenca.Location = New System.Drawing.Point(227, 181)
        Me.BLicenca.Name = "BLicenca"
        Me.BLicenca.Size = New System.Drawing.Size(96, 51)
        Me.BLicenca.TabIndex = 3
        Me.BLicenca.Text = "Licenca"
        Me.BLicenca.UseVisualStyleBackColor = True
        '
        'BChaveProduto
        '
        Me.BChaveProduto.Location = New System.Drawing.Point(83, 277)
        Me.BChaveProduto.Name = "BChaveProduto"
        Me.BChaveProduto.Size = New System.Drawing.Size(100, 46)
        Me.BChaveProduto.TabIndex = 4
        Me.BChaveProduto.Text = "Chave do Produto"
        Me.BChaveProduto.UseVisualStyleBackColor = True
        '
        'BSair
        '
        Me.BSair.Location = New System.Drawing.Point(357, 384)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(96, 46)
        Me.BSair.TabIndex = 5
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = True
        '
        'LTitulo
        '
        Me.LTitulo.Location = New System.Drawing.Point(90, 39)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(232, 25)
        Me.LTitulo.TabIndex = 6
        Me.LTitulo.Text = "Licenciamento de Software"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(489, 442)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.BChaveProduto)
        Me.Controls.Add(Me.BLicenca)
        Me.Controls.Add(Me.BLicenciamento)
        Me.Controls.Add(Me.BProduto)
        Me.Controls.Add(Me.BCliente)
        Me.Name = "FMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BCliente As System.Windows.Forms.Button
    Friend WithEvents BProduto As System.Windows.Forms.Button
    Friend WithEvents BLicenciamento As System.Windows.Forms.Button
    Friend WithEvents BLicenca As System.Windows.Forms.Button
    Friend WithEvents BChaveProduto As System.Windows.Forms.Button
    Friend WithEvents BSair As System.Windows.Forms.Button
    Friend WithEvents LTitulo As System.Windows.Forms.Label
End Class
