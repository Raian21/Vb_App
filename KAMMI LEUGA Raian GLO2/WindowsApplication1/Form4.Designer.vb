<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnprenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columncontact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columnreabonnement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.Columnprenom, Me.Columncontact, Me.Columnemail, Me.Columnreabonnement})
        Me.DataGridView1.GridColor = System.Drawing.Color.Crimson
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'column1
        '
        Me.column1.HeaderText = "Nom"
        Me.column1.Name = "column1"
        '
        'Columnprenom
        '
        Me.Columnprenom.HeaderText = "Prénom"
        Me.Columnprenom.Name = "Columnprenom"
        '
        'Columncontact
        '
        Me.Columncontact.HeaderText = "Contact"
        Me.Columncontact.Name = "Columncontact"
        '
        'Columnemail
        '
        Me.Columnemail.HeaderText = "E-mail"
        Me.Columnemail.Name = "Columnemail"
        '
        'Columnreabonnement
        '
        Me.Columnreabonnement.HeaderText = "N° réabonnement"
        Me.Columnreabonnement.Name = "Columnreabonnement"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(565, 346)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents column1 As DataGridViewTextBoxColumn
    Friend WithEvents Columnprenom As DataGridViewTextBoxColumn
    Friend WithEvents Columncontact As DataGridViewTextBoxColumn
    Friend WithEvents Columnemail As DataGridViewTextBoxColumn
    Friend WithEvents Columnreabonnement As DataGridViewTextBoxColumn
End Class
