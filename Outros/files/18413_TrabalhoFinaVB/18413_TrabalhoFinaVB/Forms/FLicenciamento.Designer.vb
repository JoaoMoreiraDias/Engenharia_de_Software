<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLicenciamento
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
        Me.BSair = New System.Windows.Forms.Button()
        Me.LNome = New System.Windows.Forms.Label()
        Me.LReferencia = New System.Windows.Forms.Label()
        Me.LQuantMinima = New System.Windows.Forms.Label()
        Me.LDescontoV = New System.Windows.Forms.Label()
        Me.LValidade = New System.Windows.Forms.Label()
        Me.LQuantMaxima = New System.Windows.Forms.Label()
        Me.TNome = New System.Windows.Forms.TextBox()
        Me.TReferencia = New System.Windows.Forms.TextBox()
        Me.TQuantMinima = New System.Windows.Forms.TextBox()
        Me.TDescVolume = New System.Windows.Forms.TextBox()
        Me.TQuantMaxima = New System.Windows.Forms.TextBox()
        Me.TValidade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BGravar
        '
        Me.BGravar.Location = New System.Drawing.Point(625, 403)
        Me.BGravar.Name = "BGravar"
        Me.BGravar.Size = New System.Drawing.Size(75, 23)
        Me.BGravar.TabIndex = 0
        Me.BGravar.Text = "Gravar"
        Me.BGravar.UseVisualStyleBackColor = True
        '
        'BSair
        '
        Me.BSair.Location = New System.Drawing.Point(727, 403)
        Me.BSair.Name = "BSair"
        Me.BSair.Size = New System.Drawing.Size(75, 23)
        Me.BSair.TabIndex = 1
        Me.BSair.Text = "Sair"
        Me.BSair.UseVisualStyleBackColor = True
        '
        'LNome
        '
        Me.LNome.Location = New System.Drawing.Point(34, 56)
        Me.LNome.Name = "LNome"
        Me.LNome.Size = New System.Drawing.Size(78, 20)
        Me.LNome.TabIndex = 2
        Me.LNome.Text = "Nome"
        '
        'LReferencia
        '
        Me.LReferencia.Location = New System.Drawing.Point(34, 101)
        Me.LReferencia.Name = "LReferencia"
        Me.LReferencia.Size = New System.Drawing.Size(78, 20)
        Me.LReferencia.TabIndex = 3
        Me.LReferencia.Text = "Referencia"
        '
        'LQuantMinima
        '
        Me.LQuantMinima.Location = New System.Drawing.Point(34, 187)
        Me.LQuantMinima.Name = "LQuantMinima"
        Me.LQuantMinima.Size = New System.Drawing.Size(105, 20)
        Me.LQuantMinima.TabIndex = 4
        Me.LQuantMinima.Text = "Quantidade Minima"
        '
        'LDescontoV
        '
        Me.LDescontoV.Location = New System.Drawing.Point(34, 145)
        Me.LDescontoV.Name = "LDescontoV"
        Me.LDescontoV.Size = New System.Drawing.Size(105, 20)
        Me.LDescontoV.TabIndex = 5
        Me.LDescontoV.Text = "Desconto Volume"
        '
        'LValidade
        '
        Me.LValidade.Location = New System.Drawing.Point(34, 262)
        Me.LValidade.Name = "LValidade"
        Me.LValidade.Size = New System.Drawing.Size(105, 20)
        Me.LValidade.TabIndex = 6
        Me.LValidade.Text = "Validade"
        '
        'LQuantMaxima
        '
        Me.LQuantMaxima.Location = New System.Drawing.Point(34, 226)
        Me.LQuantMaxima.Name = "LQuantMaxima"
        Me.LQuantMaxima.Size = New System.Drawing.Size(105, 20)
        Me.LQuantMaxima.TabIndex = 7
        Me.LQuantMaxima.Text = "Quantidade Maxima"
        '
        'TNome
        '
        Me.TNome.Location = New System.Drawing.Point(163, 56)
        Me.TNome.Name = "TNome"
        Me.TNome.Size = New System.Drawing.Size(233, 20)
        Me.TNome.TabIndex = 10
        '
        'TReferencia
        '
        Me.TReferencia.Location = New System.Drawing.Point(163, 101)
        Me.TReferencia.Name = "TReferencia"
        Me.TReferencia.Size = New System.Drawing.Size(121, 20)
        Me.TReferencia.TabIndex = 11
        '
        'TQuantMinima
        '
        Me.TQuantMinima.Location = New System.Drawing.Point(163, 187)
        Me.TQuantMinima.Name = "TQuantMinima"
        Me.TQuantMinima.Size = New System.Drawing.Size(121, 20)
        Me.TQuantMinima.TabIndex = 12
        '
        'TDescVolume
        '
        Me.TDescVolume.Location = New System.Drawing.Point(163, 145)
        Me.TDescVolume.Name = "TDescVolume"
        Me.TDescVolume.Size = New System.Drawing.Size(121, 20)
        Me.TDescVolume.TabIndex = 13
        '
        'TQuantMaxima
        '
        Me.TQuantMaxima.Location = New System.Drawing.Point(163, 223)
        Me.TQuantMaxima.Name = "TQuantMaxima"
        Me.TQuantMaxima.Size = New System.Drawing.Size(121, 20)
        Me.TQuantMaxima.TabIndex = 14
        '
        'TValidade
        '
        Me.TValidade.Location = New System.Drawing.Point(163, 259)
        Me.TValidade.Name = "TValidade"
        Me.TValidade.Size = New System.Drawing.Size(121, 20)
        Me.TValidade.TabIndex = 15
        '
        'FLicenciamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 438)
        Me.Controls.Add(Me.TValidade)
        Me.Controls.Add(Me.TQuantMaxima)
        Me.Controls.Add(Me.TDescVolume)
        Me.Controls.Add(Me.TQuantMinima)
        Me.Controls.Add(Me.TReferencia)
        Me.Controls.Add(Me.TNome)
        Me.Controls.Add(Me.LQuantMaxima)
        Me.Controls.Add(Me.LValidade)
        Me.Controls.Add(Me.LDescontoV)
        Me.Controls.Add(Me.LQuantMinima)
        Me.Controls.Add(Me.LReferencia)
        Me.Controls.Add(Me.LNome)
        Me.Controls.Add(Me.BSair)
        Me.Controls.Add(Me.BGravar)
        Me.Name = "FLicenciamento"
        Me.Text = "Licenciamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BGravar As System.Windows.Forms.Button
    Friend WithEvents BSair As System.Windows.Forms.Button
    Friend WithEvents LNome As System.Windows.Forms.Label
    Friend WithEvents LReferencia As System.Windows.Forms.Label
    Friend WithEvents LQuantMinima As System.Windows.Forms.Label
    Friend WithEvents LDescontoV As System.Windows.Forms.Label
    Friend WithEvents LValidade As System.Windows.Forms.Label
    Friend WithEvents LQuantMaxima As System.Windows.Forms.Label
    Friend WithEvents TNome As System.Windows.Forms.TextBox
    Friend WithEvents TReferencia As System.Windows.Forms.TextBox
    Friend WithEvents TQuantMinima As System.Windows.Forms.TextBox
    Friend WithEvents TDescVolume As System.Windows.Forms.TextBox
    Friend WithEvents TQuantMaxima As System.Windows.Forms.TextBox
    Friend WithEvents TValidade As System.Windows.Forms.TextBox
End Class
