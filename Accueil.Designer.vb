<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.CB_NomJoueur = New System.Windows.Forms.ComboBox()
        Me.Btn_Jouer = New System.Windows.Forms.Button()
        Me.Btn_Scores = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.LB_NomJoueur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CB_NomJoueur
        '
        Me.CB_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_NomJoueur.FormattingEnabled = True
        Me.CB_NomJoueur.Location = New System.Drawing.Point(145, 92)
        Me.CB_NomJoueur.Name = "CB_NomJoueur"
        Me.CB_NomJoueur.Size = New System.Drawing.Size(121, 24)
        Me.CB_NomJoueur.TabIndex = 0
        '
        'Btn_Jouer
        '
        Me.Btn_Jouer.Location = New System.Drawing.Point(72, 150)
        Me.Btn_Jouer.Name = "Btn_Jouer"
        Me.Btn_Jouer.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Jouer.TabIndex = 1
        Me.Btn_Jouer.Text = "Jouer"
        Me.Btn_Jouer.UseVisualStyleBackColor = True
        '
        'Btn_Scores
        '
        Me.Btn_Scores.Location = New System.Drawing.Point(273, 150)
        Me.Btn_Scores.Name = "Btn_Scores"
        Me.Btn_Scores.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Scores.TabIndex = 2
        Me.Btn_Scores.Text = "Scores"
        Me.Btn_Scores.UseVisualStyleBackColor = True
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.Location = New System.Drawing.Point(174, 150)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Quitter.TabIndex = 3
        Me.Btn_Quitter.Text = "Quitter"
        Me.Btn_Quitter.UseVisualStyleBackColor = True
        '
        'LB_NomJoueur
        '
        Me.LB_NomJoueur.AutoSize = True
        Me.LB_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NomJoueur.Location = New System.Drawing.Point(107, 59)
        Me.LB_NomJoueur.Name = "LB_NomJoueur"
        Me.LB_NomJoueur.Size = New System.Drawing.Size(205, 20)
        Me.LB_NomJoueur.TabIndex = 4
        Me.LB_NomJoueur.Text = "Entrez votre nom de Joueur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 239)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_NomJoueur)
        Me.Controls.Add(Me.Btn_Quitter)
        Me.Controls.Add(Me.Btn_Scores)
        Me.Controls.Add(Me.Btn_Jouer)
        Me.Controls.Add(Me.CB_NomJoueur)
        Me.Name = "Accueil"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_NomJoueur As ComboBox
    Friend WithEvents Btn_Jouer As Button
    Friend WithEvents Btn_Scores As Button
    Friend WithEvents Btn_Quitter As Button
    Friend WithEvents LB_NomJoueur As Label
    Friend WithEvents Label1 As Label
End Class
