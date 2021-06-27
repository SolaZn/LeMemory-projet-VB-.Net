Imports System.IO

Public Class Joueur
    Private NOM As String
    Private TempsJeuTotal As Integer
    Private NombrePartiesJouee As Integer
    Private TempsMinPrCarré As Integer
    Private NombreMaxCarré As Integer

    Public Sub New(ByVal NomJ As String)
        Me.NOM = NomJ
        NombrePartiesJouee = 0
        TempsMinPrCarré = 0
        NombreMaxCarré = 0
        TempsJeuTotal = 0
    End Sub

    Public Shared Sub StockerJoueurs(path As String)
        Using SW_Joueurs As StreamWriter = File.CreateText(path)
            For Each Jou As Joueur In listeJoueurs
                SW_Joueurs.WriteLine("NOM:" + Jou.NOM)
                If Not Jou.TempsJeuTotal = vbNull Then
                    SW_Joueurs.WriteLine("TempsJeuTotal: " & Jou.TempsJeuTotal)
                    SW_Joueurs.WriteLine("NombrePartiesJouee: " & Jou.NombrePartiesJouee)
                    SW_Joueurs.WriteLine("TempsMinPrCarré: " & Jou.TempsMinPrCarré)
                    SW_Joueurs.WriteLine("NombreMaxCarré: " & Jou.NombreMaxCarré)
                    SW_Joueurs.WriteLine("---")
                Else
                    SW_Joueurs.WriteLine("TempsJeuTotal: ")
                    SW_Joueurs.WriteLine("NombrePartiesJouee: ")
                    SW_Joueurs.WriteLine("TempsMinPrCarré: ")
                    SW_Joueurs.WriteLine("NombreMaxCarré: ")
                    SW_Joueurs.WriteLine("---")
                End If
            Next
        End Using
    End Sub

    Public Shared Sub RechargerJoueurs(path As String)
        Dim num As Integer = FreeFile()
        Dim contenuSauvegarde() As String
        contenuSauvegarde = File.ReadAllLines(path)
        For i = 0 To contenuSauvegarde.Length - 1
            If contenuSauvegarde(i).Contains("NOM:") Then
                Dim Jou As Joueur = New Joueur(contenuSauvegarde(i).Remove(0, 4))
                Jou.SetValeurs(contenuSauvegarde(i + 1).Remove(0, 14), contenuSauvegarde(i + 3).Remove(0, 17), contenuSauvegarde(i + 4).Remove(0, 16))
                listeJoueurs.Add(Jou)
            End If
        Next
    End Sub

    Public Shared Sub TrierJoueurs(mode As String)
        If mode = "plus fort" Then
            listeJoueurs.Sort(Function(x, y) y.NombreMaxCarré.CompareTo(x.NombreMaxCarré))
        ElseIf mode = "moins fort" Then
            listeJoueurs.Sort(Function(x, y) x.NombreMaxCarré.CompareTo(y.NombreMaxCarré))
        End If
    End Sub

    Public Shared Function RecupererNomsJoueurs()
        Dim listeNoms As New List(Of String)
        For Each Jou As Joueur In listeJoueurs
            listeNoms.Add(Jou.NOM)
        Next

        Return listeNoms
    End Function

    Public Shared Function RecupererStats(nomJoueur As String)
        Dim JoueurMentionne As Joueur = Nothing
        For Each Player As Joueur In listeJoueurs
            If Player.NOM = nomJoueur Then
                JoueurMentionne = Player
            End If
        Next

        Return "Le joueur " & JoueurMentionne.NOM & " a joué " & JoueurMentionne.NombrePartiesJouee & " parties de Memory, pour " & Int(JoueurMentionne.RecupererTempsJeu / 60) & "min et " & JoueurMentionne.RecupererTempsJeu Mod 60 & "sec de temps de jeu total." & vbNewLine & "Sa meilleure partie était de " & JoueurMentionne.NombreMaxCarré _
        & " carrés trouvés en " & JoueurMentionne.TempsMinPrCarré & " secondes !"
    End Function

    Public Function RecupererNom()
        Return NOM
    End Function

    Public Function RecupererTempsJeu()
        Return TempsJeuTotal
    End Function

    Public Function RecupererTempsMin()
        Return TempsMinPrCarré
    End Function

    Public Function RecupererNbMaxCarre()
        Return NombreMaxCarré
    End Function

    Public Function RecupererNbParties()
        Return NombrePartiesJouee
    End Function

    Public Sub SetValeurs(TpsJTot As String, TpsMinPrCarre As String, NbMaxCarre As String, Optional NbPartJouees As Integer = 0)
        If Me.NOM = vbNullString Then
            NOM = NomJoueur
        End If
        TempsJeuTotal += TpsJTot
        NombrePartiesJouee += 1
        If TempsMinPrCarré < TpsMinPrCarre Then
            TempsMinPrCarré = TpsMinPrCarre
        End If
        NombreMaxCarré = NbMaxCarre
    End Sub

End Class