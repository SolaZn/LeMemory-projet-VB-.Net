Public Class Accueil

    Private Sub Btn_Jouer_Click() Handles Btn_Jouer.Click
        If Not CB_NomJoueur.Text = "" Then
            If Not CB_NomJoueur.Text.Length < 3 Then
                ModuleJoueurs.NomJoueur = CB_NomJoueur.Text
                EnregistrerJoueur(NomJoueur)
                Partie.Show()
                Me.Close()
            Else
                MsgBox("Vous devez renseigner un nom d'au moins 3 caractères pour jouer", MsgBoxStyle.OkOnly, "Alerte")
            End If
        Else
            MsgBox("Vous devez renseigner un nom d'au moins 3 caractères pour jouer", MsgBoxStyle.OkOnly, "Alerte")
        End If
    End Sub

    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click
        SauvegarderJoueurs()
        Dim ResultatMsg As Integer = MsgBox("Voulez-vous quitter Memory ?", MsgBoxStyle.OkCancel, "Quitter l'application")
        If ResultatMsg = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub CB_NomJoueur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CB_NomJoueur.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_Jouer_Click()
        End If
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Accueil"
        CB_NomJoueur.MaxLength = 15
        If JeuLance = False Then
            RechargerJoueurs()
            JeuLance = True
        End If

        For Each Str As String In getNomsJoueurs()
            If Not CB_NomJoueur.Items.Contains(Str) Then
                CB_NomJoueur.Items.Add(Str)
            End If
        Next


    End Sub

    Private Sub Btn_Scores_Click(sender As Object, e As EventArgs) Handles Btn_Scores.Click
        Scores.Show()
    End Sub
End Class