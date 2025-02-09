Imports Pizza.Commande

Public Class Pizzaiolo
    Inherits Form

    Private Enum EtatCommande
        AucuneCommandeSelectionnee
        CommandeSelectionnee
    End Enum

    Private commandesEnCours As New List(Of Commande)
    Private EtatActuel As EtatCommande

    ''' <summary>
    ''' Ajoute une commande à la liste
    ''' </summary>
    Public Async Sub CommandeRecue(commande As Commande)
        Await Task.Delay(1000) ' Simulation de traitement
        commandesEnCours.Add(commande)

        ' Création de l'item et ajout à la ListView
        Dim item As New ListViewItem(commande.AfficherCommande())
        item.SubItems.Add("En cours")
        lstCommandes.Items.Add(item)

        MessageBox.Show($"Nouvelle commande reçue : {commande.AfficherCommande()}")

        ' Mise à jour de l'état après ajout
        ChangerEtat()
    End Sub

    ''' <summary>
    ''' Gestion du bouton Terminer
    ''' </summary>
    Private Sub btnTerminer_Click(sender As Object, e As EventArgs) Handles btnTerminer.Click
        If lstCommandes.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lstCommandes.SelectedItems(0)
            lstCommandes.Items.Remove(item)

            MessageBox.Show("Commande terminée avec succès !")

            ' Mise à jour de l'état après suppression
            ChangerEtat()
        Else
            MessageBox.Show("Veuillez sélectionner une commande.")
        End If
    End Sub

    ''' <summary>
    ''' Met à jour l'état du bouton Terminer
    ''' </summary>
    Private Sub ChangerEtat()
        If lstCommandes.SelectedItems.Count > 0 Then
            EtatActuel = EtatCommande.CommandeSelectionnee
            btnTerminer.Enabled = True
        Else
            EtatActuel = EtatCommande.AucuneCommandeSelectionnee
            btnTerminer.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Événement déclenché lorsqu'une commande est sélectionnée
    ''' </summary>
    Private Sub lstCommandes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCommandes.SelectedIndexChanged
        ChangerEtat()
    End Sub
End Class
