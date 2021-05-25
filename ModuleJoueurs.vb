Imports System.IO

Module ModuleJoueurs
    Public listeJoueurs As New List(Of String)
    Dim path As String = My.Application.Info.DirectoryPath
    Dim statsJoueurs As String = IO.Path.Combine(path, "statsJoueurs.txt")
    Public Function getNomsJoueurs()

        Dim path As String = My.Application.Info.DirectoryPath
        Dim statsJoueurs As String = IO.Path.Combine(path, "statsJoueurs.txt")

        Dim SR_Joueurs As New StreamReader(statsJoueurs)
        Do While SR_Joueurs.Peek() >= 0
            RecupererNoms(SR_Joueurs.ReadLine)
        Loop
        SR_Joueurs.Close()

        Return listeJoueurs
    End Function

    Public Sub EnregistrerJoueur(nomJoueur As String)
        Using SW_Joueurs As StreamWriter = File.AppendText(statsJoueurs)
            If Not nomJoueur = vbNullString Then
                SW_Joueurs.WriteLine("NOM:" + nomJoueur)
                SW_Joueurs.WriteLine("---")
            End If
        End Using
    End Sub

    Private Sub RecupererNoms(readLine As String)
        If (readLine.Contains("NOM:")) Then
            listeJoueurs.Add(readLine.Remove(0, 4))
        End If
    End Sub



    Public NomJoueur As String
End Module
