<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelnom = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.labelprenom = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.labelcontact = New System.Windows.Forms.Label()
        Me.labelemail = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Payement = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelvalider = New System.Windows.Forms.Button()
        Me.Labelreabonnement = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Labelmdp = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Abonné CANAL+"
        '
        'labelnom
        '
        Me.labelnom.AutoSize = True
        Me.labelnom.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnom.Location = New System.Drawing.Point(16, 56)
        Me.labelnom.Name = "labelnom"
        Me.labelnom.Size = New System.Drawing.Size(41, 16)
        Me.labelnom.TabIndex = 1
        Me.labelnom.Text = "Nom :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(250, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'labelprenom
        '
        Me.labelprenom.AutoSize = True
        Me.labelprenom.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprenom.Location = New System.Drawing.Point(247, 56)
        Me.labelprenom.Name = "labelprenom"
        Me.labelprenom.Size = New System.Drawing.Size(57, 16)
        Me.labelprenom.TabIndex = 4
        Me.labelprenom.Text = "Prénom :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(18, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(332, 20)
        Me.TextBox3.TabIndex = 5
        '
        'labelcontact
        '
        Me.labelcontact.AutoSize = True
        Me.labelcontact.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcontact.Location = New System.Drawing.Point(16, 115)
        Me.labelcontact.Name = "labelcontact"
        Me.labelcontact.Size = New System.Drawing.Size(57, 16)
        Me.labelcontact.TabIndex = 6
        Me.labelcontact.Text = "Contact :"
        '
        'labelemail
        '
        Me.labelemail.AutoSize = True
        Me.labelemail.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelemail.Location = New System.Drawing.Point(16, 168)
        Me.labelemail.Name = "labelemail"
        Me.labelemail.Size = New System.Drawing.Size(48, 16)
        Me.labelemail.TabIndex = 7
        Me.labelemail.Text = "E-mail :"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(18, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(332, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Payement
        '
        Me.Payement.FormattingEnabled = True
        Me.Payement.Location = New System.Drawing.Point(18, 341)
        Me.Payement.Name = "Payement"
        Me.Payement.Size = New System.Drawing.Size(332, 69)
        Me.Payement.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(165, 381)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 20)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "OM"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(265, 381)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(67, 20)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "MOMO"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(18, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mode Payement"
        '
        'labelvalider
        '
        Me.labelvalider.BackColor = System.Drawing.Color.Crimson
        Me.labelvalider.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelvalider.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelvalider.Location = New System.Drawing.Point(19, 426)
        Me.labelvalider.Name = "labelvalider"
        Me.labelvalider.Size = New System.Drawing.Size(331, 44)
        Me.labelvalider.TabIndex = 13
        Me.labelvalider.Text = "Valider"
        Me.labelvalider.UseVisualStyleBackColor = False
        '
        'Labelreabonnement
        '
        Me.Labelreabonnement.AutoSize = True
        Me.Labelreabonnement.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelreabonnement.Location = New System.Drawing.Point(16, 228)
        Me.Labelreabonnement.Name = "Labelreabonnement"
        Me.Labelreabonnement.Size = New System.Drawing.Size(127, 16)
        Me.Labelreabonnement.TabIndex = 15
        Me.Labelreabonnement.Text = "N° de réabonnement :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(18, 247)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(332, 20)
        Me.TextBox5.TabIndex = 16
        '
        'Labelmdp
        '
        Me.Labelmdp.AutoSize = True
        Me.Labelmdp.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmdp.Location = New System.Drawing.Point(18, 288)
        Me.Labelmdp.Name = "Labelmdp"
        Me.Labelmdp.Size = New System.Drawing.Size(85, 16)
        Me.Labelmdp.TabIndex = 17
        Me.Labelmdp.Text = "Mot de passe :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(21, 305)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(329, 20)
        Me.TextBox6.TabIndex = 18
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(374, 526)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Labelmdp)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Labelreabonnement)
        Me.Controls.Add(Me.labelvalider)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Payement)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.labelemail)
        Me.Controls.Add(Me.labelcontact)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.labelprenom)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.labelnom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents labelnom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents labelprenom As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents labelcontact As Label
    Friend WithEvents labelemail As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Payement As ListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labelvalider As Button
    Friend WithEvents Labelreabonnement As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Labelmdp As Label
    Friend WithEvents TextBox6 As TextBox
End Class
