Public Class Scores
    Private Sub SynchroniserListes(index As Integer)
        LBox_TpsJeu.SelectedIndex() = index
        LBox_TpsCarres.SelectedIndex() = index
        LBox_NomsJoueurs.SelectedIndex() = index
        LBox_NbCarres.SelectedIndex() = index
        LBox_NbParties.SelectedIndex() = index

        CB_NomJoueur.SelectedIndex = index
    End Sub

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Joueur.TrierJoueurs("plus fort")
        afficherScoresJoueurs()
    End Sub

    Private Sub afficherScoresJoueurs()
        LBox_NomsJoueurs.Items.Clear()
        LBox_NbCarres.Items.Clear()
        LBox_NbParties.Items.Clear()
        LBox_TpsCarres.Items.Clear()
        LBox_TpsJeu.Items.Clear()

        CB_NomJoueur.Items.Clear()

        For Each Player As Joueur In listeJoueurs
            LBox_NomsJoueurs.Items.Add(Player.RecupererNom)
            LBox_NbCarres.Items.Add(Player.RecupererNbMaxCarre)
            LBox_NbParties.Items.Add(Player.RecupererNbParties)
            LBox_TpsCarres.Items.Add(Player.RecupererTempsMin)
            LBox_TpsJeu.Items.Add(Int(Player.RecupererTempsJeu / 60) & " min:" & Player.RecupererTempsJeu Mod 60 & " sec")
        Next

        For Each Str As String In getNomsJoueurs()
            If Not CB_NomJoueur.Items.Contains(Str) Then
                CB_NomJoueur.Items.Add(Str)
            End If
        Next
    End Sub

    Private Sub LBox_NbParties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBox_NbParties.SelectedIndexChanged, LBox_TpsCarres.SelectedIndexChanged,
            LBox_NbCarres.SelectedIndexChanged, LBox_TpsJeu.SelectedIndexChanged, LBox_NomsJoueurs.SelectedIndexChanged
        SynchroniserListes(sender.SelectedIndex)
    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Accueil.Show()
        Close()
    End Sub


    Private Sub Btn_plusfort_Click(sender As Object, e As EventArgs) Handles Btn_plusfort.Click
        Btn_moinsfort.Enabled = True
        Joueur.TrierJoueurs("plus fort")
        afficherScoresJoueurs()
        Btn_plusfort.Enabled = False
    End Sub

    Private Sub Btn_moinsfort_Click(sender As Object, e As EventArgs) Handles Btn_moinsfort.Click
        Btn_plusfort.Enabled = True
        Joueur.TrierJoueurs("moins fort")
        afficherScoresJoueurs()
        Btn_moinsfort.Enabled = False
    End Sub

    Private Sub Btn_stats_Click(sender As Object, e As EventArgs) Handles Btn_stats.Click
        If Joueur.RecupererNomsJoueurs.Contains(CB_NomJoueur.Text) Then
            MsgBox(Joueur.RecupererStats(CB_NomJoueur.Text), MsgBoxStyle.OkOnly, "Statistiques du joueur " & CB_NomJoueur.Text)
        Else
            MsgBox("Joueur introuvable", MsgBoxStyle.OkOnly, "Erreur")
        End If

    End Sub
End Class