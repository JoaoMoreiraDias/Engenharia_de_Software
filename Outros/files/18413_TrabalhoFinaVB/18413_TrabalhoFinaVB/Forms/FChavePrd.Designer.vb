<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FChavePrd
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
        Me.TChaveProduto = New System.Windows.Forms.TextBox()
        Me.LChaveProduto = New System.Windows.Forms.Label()
        Me.BGravar = New System.Windows.Forms.Button()
        Me.BSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TChaveProduto
        '
        Me.TChaveProduto.Location = New System.Drawing.Point(132, 45)
        Me.TChaveProduto.Name = "TChaveProduto"
        Me.TChaveProduto.Size = New System.Drawing.Size(121, 20)
        Me.TChaveProduto.TabIndex = 10
        '
        'LChaveProduto
        '
        Me.LChaveProduto.Location = New System.Drawing.Point(12, 45)
        Me.LChaveProduto.Name = "LChaveProduto"
        Me.LChaveProduto.Size = New System.Drawing.Size(96, 20)
        Me.LChaveProduto.TabIndex = 11
        Me.LChaveProduto.Text = "Chave do Produto"
        '
        'BGravar
        '
        Me.BGravar.Location = New System.Drawing.Point(132, 209)
        Me.BGravar.Name = "BGravar"
        Me.BGravar.Size = New System.Drawing.Size(75, 23)
        Me.BGravar.TabIndex = 12
        Me.BGravar.Text = "Gravar"
        Me.BGravar.UseVisualStyleBackColor = True
        '
        'BSair
        '
        Me.BSair.Location = New System.Drawing.Point(213, 209)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(75, 23)
        Me.BSair.TabIndex = 13
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 261)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.BGravar)
        Me.Controls.Add(Me.LChaveProduto)
        Me.Controls.Add(Me.TChaveProduto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TChaveProduto As System.Windows.Forms.TextBox
    Friend WithEvents LChaveProduto As System.Windows.Forms.Label
    Friend WithEvents BGravar As System.Windows.Forms.Button
    Friend WithEvents BSair As System.Windows.Forms.Button
End Class
