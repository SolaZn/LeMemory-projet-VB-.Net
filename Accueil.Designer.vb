<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.CB_NomJoueur = New System.Windows.Forms.ComboBox()
        Me.Btn_Jouer = New System.Windows.Forms.Button()
        Me.Btn_Scores = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.LB_NomJoueur = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_NomJoueur
        '
        Me.CB_NomJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_NomJoueur.FormattingEnabled = True
        Me.CB_NomJoueur.Location = New System.Drawing.Point(134, 215)
        Me.CB_NomJoueur.Name = "CB_NomJoueur"
        Me.CB_NomJoueur.Size = New System.Drawing.Size(121, 24)
        Me.CB_NomJoueur.TabIndex = 0
        '
        'Btn_Jouer
        '
        Me.Btn_Jouer.Location = New System.Drawing.Point(61, 266)
        Me.Btn_Jouer.Name = "Btn_Jouer"
        Me.Btn_Jouer.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Jouer.TabIndex = 1
        Me.Btn_Jouer.Text = "Jouer"
        Me.Btn_Jouer.UseVisualStyleBackColor = True
        '
        'Btn_Scores
        '
        Me.Btn_Scores.Location = New System.Drawing.Point(262, 266)
        Me.Btn_Scores.Name = "Btn_Scores"
        Me.Btn_Scores.Size = New System.Drawing.Size(80, 23)
        Me.Btn_Scores.TabIndex = 2
        Me.Btn_Scores.Text = "Scores"
        Me.Btn_Scores.UseVisualStyleBackColor = True
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.Location = New System.Drawing.Point(163, 266)
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
        Me.LB_NomJoueur.Location = New System.Drawing.Point(96, 175)
        Me.LB_NomJoueur.Name = "LB_NomJoueur"
        Me.LB_NomJoueur.Size = New System.Drawing.Size(205, 20)
        Me.LB_NomJoueur.TabIndex = 4
        Me.LB_NomJoueur.Text = "Entrez votre nom de Joueur"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.LeMemory___projet_VB.Net.My.Resources.Resources.memory
        Me.PictureBox1.Location = New System.Drawing.Point(100, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 355)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_NomJoueur)
        Me.Controls.Add(Me.Btn_Quitter)
        Me.Controls.Add(Me.Btn_Scores)
        Me.Controls.Add(Me.Btn_Jouer)
        Me.Controls.Add(Me.CB_NomJoueur)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.Text = "LeMemory - Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_NomJoueur As ComboBox
    Friend WithEvents Btn_Jouer As Button
    Friend WithEvents Btn_Scores As Button
    Friend WithEvents Btn_Quitter As Button
    Friend WithEvents LB_NomJoueur As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
