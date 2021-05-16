Public Class Accueil

    Private Sub Btn_Jouer_Click() Handles Btn_Jouer.Click
        If Not CB_NomJoueur.Text = "" Then
            ModuleJoueurs.NomJoueur = CB_NomJoueur.Text
            Partie.Show()
            Me.Close()
        Else
            MsgBox("Vous devez renseigner un nom pour jouer", MsgBoxStyle.OkOnly, "Alerte")
        End If
    End Sub

    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click
        End
    End Sub

    Private Sub CB_NomJoueur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CB_NomJoueur.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_Jouer_Click()
        End If
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Accueil"
        CB_NomJoueur.MaxLength = 15
    End Sub
End Class