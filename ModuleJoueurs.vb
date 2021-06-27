Imports System.IO

Module ModuleJoueurs
    Public JeuLance As Boolean = False
    Public listeJoueurs As New List(Of Joueur)
    Dim path As String = My.Application.Info.DirectoryPath
    Dim statsJoueurs As String = IO.Path.Combine(path, "statsJoueurs.txt")

    Public NomJoueur As String
    Public JoueurJouant As Joueur

    Public Function getNomsJoueurs()
        Return Joueur.RecupererNomsJoueurs()
    End Function

    Public Sub EnregistrerJoueur(nomJoueur As String)
        Dim listeNoms As List(Of String) = Joueur.RecupererNomsJoueurs()

        If Not listeNoms.Contains(nomJoueur) Then
            listeJoueurs.Add(New Joueur(nomJoueur))
        End If

        For Each JoueurJ As Joueur In listeJoueurs
            If JoueurJ.RecupererNom = nomJoueur Then
                JoueurJouant = JoueurJ
            End If
        Next
    End Sub

    Public Sub SauvegarderJoueurs()
        Joueur.StockerJoueurs(statsJoueurs)
    End Sub

    Public Sub RechargerJoueurs()
        Joueur.RechargerJoueurs(statsJoueurs)
    End Sub
End Module
