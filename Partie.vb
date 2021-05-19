Public Class Partie
    'Initialisation du jeu
    Private tableauCartesCachees As New List(Of Integer)
    Private numeroCartePrecedente As Integer = -1
    Private tabIndexPrecedent As Integer = -1
    Private listeCartesPrecedentes As New List(Of Integer)
    Private carresCompletes As Integer = 0
    Private Compteur As Integer = 59

    Private Sub chargerImages()
        Randomize()

        Dim listeCartes As New List(Of Integer) From {1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5}

        For i = 1 To FLPanel_Cartes.Controls.Count
            Dim idCarte As Integer = Int((listeCartes.Count - 1 - 0 + 1) * Rnd() + 0)
            Dim nomLabelString = "Label" & i
            Dim nomLabel As Label = Me.Controls("FLPanel_Cartes").Controls(nomLabelString)

            Dim petitAffichage As New Font("Microsoft Sans Serif", 0.01)

            If listeCartes(idCarte) = 1 Then
                tableauCartesCachees.Add(0)
            ElseIf listeCartes(idCarte) = 2 Then
                tableauCartesCachees.Add(1)
            ElseIf listeCartes(idCarte) = 3 Then
                tableauCartesCachees.Add(2)
            ElseIf listeCartes(idCarte) = 4 Then
                tableauCartesCachees.Add(3)
            ElseIf listeCartes(idCarte) = 5 Then
                tableauCartesCachees.Add(4)
            End If
            nomLabel.Text = i
            nomLabel.Font = petitAffichage

            listeCartes.RemoveAt(idCarte)
        Next

        For Each label As Label In FLPanel_Cartes.Controls
            AddHandler label.Click, AddressOf revelerCarte
        Next
    End Sub

    Private Sub revelerCarte(sender As Object, e As EventArgs)
        afficherCarte(sender.Text)

        If Not numeroCartePrecedente = -1 Then
            If Not tableauCartesCachees(numeroCartePrecedente - 1) = tableauCartesCachees(sender.Text - 1) Then
                listeCartesPrecedentes.Clear()
                numeroCartePrecedente = -1
                cacherCartes()
                Exit Sub
            End If
        End If

        If Not sender.TabIndex = tabIndexPrecedent Then
            listeCartesPrecedentes.Add(sender.Text)
        End If
        numeroCartePrecedente = sender.Text
        tabIndexPrecedent = sender.TabIndex

        TimerIdle.Interval = 1
        TimerIdle.Start()

        If listeCartesPrecedentes.Count = 4 Then 'attention à vérifier si l'appui sur une carte deux fois ne génère pas un carré complet
            carreComplet()
            listeCartesPrecedentes.Clear()
            numeroCartePrecedente = -1
        End If
    End Sub

    Private Sub carreComplet()
        'il faudra gérer la désactivation des champs et l'enregistrement des 4 premiers carrés joués (possible de compter aussi le temps pris avec un timer
        'pour compléter le carré
        enregistrerCarre()

        If carresCompletes = 5 Then
            TerminerJeu()
        End If
    End Sub

    Private Sub enregistrerCarre()
        For i = 0 To listeCartesPrecedentes.Count - 1
            Dim nomLabelString = "Label" & listeCartesPrecedentes(i)
            Dim nomLabel As Label = Me.Controls("FLPanel_Cartes").Controls(nomLabelString)

            nomLabel.Enabled = False
        Next
        carresCompletes += 1
    End Sub

    Private Sub afficherCarte(numeroCarte As Integer)
        If numeroCartePrecedente = -1 Then
            TimerJeu_Refresh.Start()
        End If

        Dim nomLabelString = "Label" & numeroCarte
        Dim nomLabel As Label = Me.Controls("FLPanel_Cartes").Controls(nomLabelString)

        If tableauCartesCachees(numeroCarte - 1) = 0 Then
            nomLabel.Image = My.Resources.Card0
        ElseIf tableauCartesCachees(numeroCarte - 1) = 1 Then
            nomLabel.Image = My.Resources.Card1
        ElseIf tableauCartesCachees(numeroCarte - 1) = 2 Then
            nomLabel.Image = My.Resources.Card2
        ElseIf tableauCartesCachees(numeroCarte - 1) = 3 Then
            nomLabel.Image = My.Resources.Card3
        ElseIf tableauCartesCachees(numeroCarte - 1) = 4 Then
            nomLabel.Image = My.Resources.Card4
        End If
    End Sub

    Private Sub cacherCartes()
        TimerErreur.Start()
    End Sub

    Private Sub Partie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargerImages()
        NomJ.Text = ModuleJoueurs.NomJoueur
        Me.Text = "Partie de " & NomJ.Text
        TimerErreur.Interval() = 1
        TimerJeu_Refresh.Interval() = 1000
    End Sub

    Private Sub TimerErreur_Tick(sender As Object, e As EventArgs) Handles TimerErreur.Tick
        Threading.Thread.Sleep(750)
        For Each label As Label In FLPanel_Cartes.Controls
            If label.Enabled = True Then
                label.Image = My.Resources.BackCard
            End If
        Next

        listeCartesPrecedentes.Clear()
        TimerErreur.Stop()
    End Sub

    Private Sub TerminerJeu()
        TimerJeu_Refresh.Stop()
        MsgBox("Le jeu est fini ! Bien joué !" + vbNewLine + "Vous avez complété " & carresCompletes & " carrés !", MsgBoxStyle.OkOnly, "Résultats")
        Accueil.Show()
        Close()
    End Sub

    Private Sub TimerIdle_Tick(sender As Object, e As EventArgs) Handles TimerIdle.Tick
        Threading.Thread.Sleep(500)
        TimerIdle.Stop()
    End Sub

    Private Sub TimerJeu_Refresh_Tick(sender As Object, e As EventArgs) Handles TimerJeu_Refresh.Tick
        Compteur -= 1
        If Compteur > 9 Then
            TimerJeu_Aff.Text = "0:" & Compteur
        Else
            TimerJeu_Aff.Text = "0:0" & Compteur
        End If
        If Compteur < 0 Then
            TerminerJeu()
        End If
    End Sub

    Private Sub Btn_Abandon_Click(sender As Object, e As EventArgs) Handles Btn_Abandon.Click
        TimerJeu_Refresh().Stop()
        cacherCartes()
        Dim Abandon As Integer = MsgBox("Voulez-vous abandonner la partie ?", MsgBoxStyle.OkCancel, "Abandon")
        If Abandon = 1 Then
            Accueil.Show()
            Me.Close()
        End If
        TimerJeu_Refresh.Start()
    End Sub

End Class
