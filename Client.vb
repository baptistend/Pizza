Imports System.Globalization
Imports System.Text
Imports Pizza.Commande
Public Class Client
    Inherits Form
    Public Event commandeValidee(commande As Commande)



    ' Définition des états
    Private Enum EtatCommande
        SelectionModeLivraison
        SelectionPizzeria
        SelectionPizza
        Confirmation
    End Enum

    Private Enum EtatSelectionPizza
        PanierVide
        PanierRempli
    End Enum

    Private EtatActuel As EtatCommande = EtatCommande.SelectionModeLivraison
    Private CommandeActuelle As Commande = New Commande()
    Private EtatSelectionPizzaActuel As EtatSelectionPizza


    Private btnEmporter As Button
    Private btnLivraison As Button


    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialisation de l'état
        ChangerEtat(EtatCommande.SelectionModeLivraison)
    End Sub

    Private Sub Init()


    End Sub
    ' Changement d'état de la machine
    Private Sub ChangerEtat(nouvelEtat As EtatCommande)
        EtatActuel = nouvelEtat

        Select Case EtatActuel
            Case EtatCommande.SelectionModeLivraison
                RendSelectionModeLivraison()

            Case EtatCommande.SelectionPizzeria
                RendSelectionPizzeria()

            Case EtatCommande.SelectionPizza
                RendSelectionPizza()

            Case EtatCommande.Confirmation
                RendConfirmation()
        End Select
    End Sub

    Private Sub UpdateEtatSelectionPizza()

        If CommandeActuelle.getCommandSize > 0 Then
            EtatSelectionPizzaActuel = EtatSelectionPizza.PanierRempli
            RendPanierRempli()
        Else
            EtatSelectionPizzaActuel = EtatSelectionPizza.PanierVide
            RendPanierVide()
        End If
    End Sub





    Private Sub LivraisonImage_Click(sender As Object, e As EventArgs) Handles LivraisonImage.Click
        Select Case EtatActuel
            Case EtatCommande.SelectionModeLivraison
                ChangerEtat(EtatCommande.SelectionPizzeria)
                CommandeActuelle.SetTypeDeLivraison("Livraison")


        End Select
    End Sub

    Private Sub EmporterImage_Click(sender As Object, e As EventArgs) Handles EmporterImage.Click
        Select Case EtatActuel
            Case EtatCommande.SelectionModeLivraison
                ChangerEtat(EtatCommande.SelectionPizzeria)
                CommandeActuelle.SetTypeDeLivraison("A emporter")


        End Select
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If lstPizzas.SelectedItem IsNot Nothing Then
            CommandeActuelle.AjouterPizza(lstPizzas.SelectedItem.ToString())
            lstPanier.Items.Clear()
            lstPanier.Items.AddRange(CommandeActuelle.GetPizzas().ToArray())
        End If

        ChangerEtat(EtatCommande.SelectionPizza)
        UpdateEtatSelectionPizza()

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If lstPanier.SelectedItem IsNot Nothing Then
            CommandeActuelle.SupprimerPizza(lstPanier.SelectedIndex)
            refreshPizzaList()
            UpdateEtatSelectionPizza()
        End If
    End Sub

    Private Sub btnValiderPizzeria_Click(sender As Object, e As EventArgs) Handles btnValiderPizzeria.Click
        ChangerEtat(EtatCommande.SelectionPizza)
        UpdateEtatSelectionPizza()
        CommandeActuelle.SetPizzeria(lstPizzerias.SelectedItem.ToString())

    End Sub

    Private Sub btnValiderCommande_Click(sender As Object, e As EventArgs) Handles btnValiderCommande.Click
        MessageBox.Show("Vous avez sélectionné : " & CommandeActuelle.AfficherCommande(), "Confirmation")

        RaiseEvent commandeValidee(CommandeActuelle)
        ChangerEtat(EtatCommande.Confirmation)
        CommandeActuelle = New Commande()
        refreshPizzaList()



    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Debug.WriteLine("Etat actuelle" + EtatActuel.ToString())

        Select Case EtatActuel
            Case EtatCommande.SelectionPizzeria
                ChangerEtat(EtatCommande.SelectionModeLivraison)
            Case EtatCommande.SelectionPizza

                ChangerEtat(EtatCommande.SelectionPizzeria)
        End Select
    End Sub

    Private Sub refreshPizzaList()
        lstPanier.Items.Clear()
        lstPanier.Items.AddRange(CommandeActuelle.GetPizzas().ToArray())
    End Sub

    Private Sub RendSelectionModeLivraison()
        LabelHeader.Text = "Choisissez le mode de livraison :"
        SelectionModeLivraisonLayout.Visible = True
        SelectionPizzeriaLayout.Visible = False
        SelectionPizzaLayout.Visible = False
        btnRetour.Visible = False
    End Sub

    Private Sub RendSelectionPizzeria()
        LabelHeader.Text = "Sélectionnez une pizzeria :"
        SelectionModeLivraisonLayout.Visible = False
        SelectionPizzeriaLayout.Visible = True
        SelectionPizzaLayout.Visible = False
        btnRetour.Visible = True
    End Sub

    Private Sub RendSelectionPizza()
        LabelHeader.Text = "Ajoutez des pizzas à votre panier :"
        SelectionModeLivraisonLayout.Visible = False
        SelectionPizzeriaLayout.Visible = False
        SelectionPizzaLayout.Visible = True
        btnRetour.Visible = True
        UpdateEtatSelectionPizza()
    End Sub

    Private Sub RendConfirmation()
        LabelHeader.Text = "Commande confirmée !"
        Dim result As DialogResult = MessageBox.Show("Merci pour votre commande !", "Confirmation", MessageBoxButtons.OK)
        If result = DialogResult.OK Then
            CommandeActuelle = New Commande()
            ChangerEtat(EtatCommande.SelectionModeLivraison)

        End If
    End Sub


    Private Sub RendPanierVide()
        btnValiderCommande.Visible = False
    End Sub

    Private Sub RendPanierRempli()
        btnValiderCommande.Visible = True
    End Sub
End Class