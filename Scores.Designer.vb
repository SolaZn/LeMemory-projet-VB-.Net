<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scores))
        Me.LBox_NbCarres = New System.Windows.Forms.ListBox()
        Me.LBox_TpsCarres = New System.Windows.Forms.ListBox()
        Me.LBox_NbParties = New System.Windows.Forms.ListBox()
        Me.LBox_TpsJeu = New System.Windows.Forms.ListBox()
        Me.LB_Scores = New System.Windows.Forms.Label()
        Me.LBox_NomsJoueurs = New System.Windows.Forms.ListBox()
        Me.LB_Carrés = New System.Windows.Forms.Label()
        Me.LB_TpsCarres = New System.Windows.Forms.Label()
        Me.LB_NbParties = New System.Windows.Forms.Label()
        Me.LB_TpsJeu = New System.Windows.Forms.Label()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LB_MeilleurePartie = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_NomJoueur = New System.Windows.Forms.ComboBox()
        Me.LB_NomJoueur = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_moinsfort = New System.Windows.Forms.Button()
        Me.Btn_plusfort = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_stats = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBox_NbCarres
        '
        Me.LBox_NbCarres.FormattingEnabled = True
        Me.LBox_NbCarres.Location = New System.Drawing.Point(69, 178)
        Me.LBox_NbCarres.Name = "LBox_NbCarres"
        Me.LBox_NbCarres.Size = New System.Drawing.Size(120, 134)
        Me.LBox_NbCarres.TabIndex = 0
        '
        'LBox_TpsCarres
        '
        Me.LBox_TpsCarres.FormattingEnabled = True
        Me.LBox_TpsCarres.Location = New System.Drawing.Point(196, 178)
        Me.LBox_TpsCarres.Name = "LBox_TpsCarres"
        Me.LBox_TpsCarres.Size = New System.Drawing.Size(129, 134)
        Me.LBox_TpsCarres.TabIndex = 1
        '
        'LBox_NbParties
        '
        Me.LBox_NbParties.FormattingEnabled = True
        Me.LBox_NbParties.Location = New System.Drawing.Point(529, 178)
        Me.LBox_NbParties.Name = "LBox_NbParties"
        Me.LBox_NbParties.Size = New System.Drawing.Size(120, 134)
        Me.LBox_NbParties.TabIndex = 2
        '
        'LBox_TpsJeu
        '
        Me.LBox_TpsJeu.FormattingEnabled = True
        Me.LBox_TpsJeu.Location = New System.Drawing.Point(665, 178)
        Me.LBox_TpsJeu.Name = "LBox_TpsJeu"
        Me.LBox_TpsJeu.Size = New System.Drawing.Size(120, 134)
        Me.LBox_TpsJeu.TabIndex = 3
        '
        'LB_Scores
        '
        Me.LB_Scores.AutoSize = True
        Me.LB_Scores.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Scores.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LB_Scores.Location = New System.Drawing.Point(238, 51)
        Me.LB_Scores.Name = "LB_Scores"
        Me.LB_Scores.Size = New System.Drawing.Size(151, 49)
        Me.LB_Scores.TabIndex = 4
        Me.LB_Scores.Text = "SCORES"
        '
        'LBox_NomsJoueurs
        '
        Me.LBox_NomsJoueurs.FormattingEnabled = True
        Me.LBox_NomsJoueurs.Location = New System.Drawing.Point(154, 372)
        Me.LBox_NomsJoueurs.Name = "LBox_NomsJoueurs"
        Me.LBox_NomsJoueurs.Size = New System.Drawing.Size(199, 69)
        Me.LBox_NomsJoueurs.TabIndex = 5
        '
        'LB_Carrés
        '
        Me.LB_Carrés.AutoSize = True
        Me.LB_Carrés.Location = New System.Drawing.Point(82, 162)
        Me.LB_Carrés.Name = "LB_Carrés"
        Me.LB_Carrés.Size = New System.Drawing.Size(93, 13)
        Me.LB_Carrés.TabIndex = 7
        Me.LB_Carrés.Text = "Carrés découverts"
        '
        'LB_TpsCarres
        '
        Me.LB_TpsCarres.AutoSize = True
        Me.LB_TpsCarres.Location = New System.Drawing.Point(193, 162)
        Me.LB_TpsCarres.Name = "LB_TpsCarres"
        Me.LB_TpsCarres.Size = New System.Drawing.Size(138, 13)
        Me.LB_TpsCarres.TabIndex = 8
        Me.LB_TpsCarres.Text = "... en combien de secondes"
        Me.LB_TpsCarres.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LB_NbParties
        '
        Me.LB_NbParties.AutoSize = True
        Me.LB_NbParties.Location = New System.Drawing.Point(553, 162)
        Me.LB_NbParties.Name = "LB_NbParties"
        Me.LB_NbParties.Size = New System.Drawing.Size(73, 13)
        Me.LB_NbParties.TabIndex = 9
        Me.LB_NbParties.Text = "Parties jouées"
        '
        'LB_TpsJeu
        '
        Me.LB_TpsJeu.AutoSize = True
        Me.LB_TpsJeu.Location = New System.Drawing.Point(678, 162)
        Me.LB_TpsJeu.Name = "LB_TpsJeu"
        Me.LB_TpsJeu.Size = New System.Drawing.Size(94, 13)
        Me.LB_TpsJeu.TabIndex = 10
        Me.LB_TpsJeu.Text = "Temps de jeu total"
        '
        'Btn_Retour
        '
        Me.Btn_Retour.Location = New System.Drawing.Point(722, 479)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Retour.TabIndex = 11
        Me.Btn_Retour.Text = "Fermer"
        Me.Btn_Retour.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.LeMemory___projet_VB.Net.My.Resources.Resources.memory
        Me.PictureBox1.Location = New System.Drawing.Point(395, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LB_MeilleurePartie
        '
        Me.LB_MeilleurePartie.AutoSize = True
        Me.LB_MeilleurePartie.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MeilleurePartie.Location = New System.Drawing.Point(121, 137)
        Me.LB_MeilleurePartie.Name = "LB_MeilleurePartie"
        Me.LB_MeilleurePartie.Size = New System.Drawing.Size(146, 25)
        Me.LB_MeilleurePartie.TabIndex = 13
        Me.LB_MeilleurePartie.Text = "Meilleure partie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(386, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 49)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "OU"
        '
        'CB_NomJoueur
        '
        Me.CB_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_NomJoueur.FormattingEnabled = True
        Me.CB_NomJoueur.Location = New System.Drawing.Point(491, 401)
        Me.CB_NomJoueur.Name = "CB_NomJoueur"
        Me.CB_NomJoueur.Size = New System.Drawing.Size(135, 32)
        Me.CB_NomJoueur.TabIndex = 15
        '
        'LB_NomJoueur
        '
        Me.LB_NomJoueur.AutoSize = True
        Me.LB_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NomJoueur.Location = New System.Drawing.Point(461, 372)
        Me.LB_NomJoueur.Name = "LB_NomJoueur"
        Me.LB_NomJoueur.Size = New System.Drawing.Size(188, 20)
        Me.LB_NomJoueur.TabIndex = 16
        Me.LB_NomJoueur.Text = "Entrez un nom de Joueur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sélectionnez un joueur"
        '
        'Btn_moinsfort
        '
        Me.Btn_moinsfort.Location = New System.Drawing.Point(386, 254)
        Me.Btn_moinsfort.Name = "Btn_moinsfort"
        Me.Btn_moinsfort.Size = New System.Drawing.Size(75, 44)
        Me.Btn_moinsfort.TabIndex = 18
        Me.Btn_moinsfort.Text = "Moins fort au plus fort"
        Me.Btn_moinsfort.UseVisualStyleBackColor = True
        '
        'Btn_plusfort
        '
        Me.Btn_plusfort.Enabled = False
        Me.Btn_plusfort.Location = New System.Drawing.Point(386, 204)
        Me.Btn_plusfort.Name = "Btn_plusfort"
        Me.Btn_plusfort.Size = New System.Drawing.Size(75, 44)
        Me.Btn_plusfort.TabIndex = 19
        Me.Btn_plusfort.Text = "Plus fort au moins fort"
        Me.Btn_plusfort.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Trier"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_stats
        '
        Me.Btn_stats.Location = New System.Drawing.Point(491, 439)
        Me.Btn_stats.Name = "Btn_stats"
        Me.Btn_stats.Size = New System.Drawing.Size(135, 23)
        Me.Btn_stats.TabIndex = 21
        Me.Btn_stats.Text = "Voir statistiques"
        Me.Btn_stats.UseVisualStyleBackColor = True
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 524)
        Me.Controls.Add(Me.Btn_stats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_plusfort)
        Me.Controls.Add(Me.Btn_moinsfort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LB_NomJoueur)
        Me.Controls.Add(Me.CB_NomJoueur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_MeilleurePartie)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.LB_TpsJeu)
        Me.Controls.Add(Me.LB_NbParties)
        Me.Controls.Add(Me.LB_TpsCarres)
        Me.Controls.Add(Me.LB_Carrés)
        Me.Controls.Add(Me.LBox_NomsJoueurs)
        Me.Controls.Add(Me.LB_Scores)
        Me.Controls.Add(Me.LBox_TpsJeu)
        Me.Controls.Add(Me.LBox_NbParties)
        Me.Controls.Add(Me.LBox_TpsCarres)
        Me.Controls.Add(Me.LBox_NbCarres)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Scores"
        Me.Text = "Scores"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBox_NbCarres As ListBox
    Friend WithEvents LBox_TpsCarres As ListBox
    Friend WithEvents LBox_NbParties As ListBox
    Friend WithEvents LBox_TpsJeu As ListBox
    Friend WithEvents LB_Scores As Label
    Friend WithEvents LBox_NomsJoueurs As ListBox
    Friend WithEvents LB_Carrés As Label
    Friend WithEvents LB_TpsCarres As Label
    Friend WithEvents LB_NbParties As Label
    Friend WithEvents LB_TpsJeu As Label
    Friend WithEvents Btn_Retour As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LB_MeilleurePartie As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_NomJoueur As ComboBox
    Friend WithEvents LB_NomJoueur As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_moinsfort As Button
    Friend WithEvents Btn_plusfort As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_stats As Button
End Class
