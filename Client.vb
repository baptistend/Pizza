Public Class Client
    Inherits Form

    ' Définition des états
    Private Enum EtatCommande
        SelectionModeLivraison
        SelectionPizzeria
        SelectionPizza
        Confirmation
    End Enum

    Private Enum EtatSelectionPizza
        AjoutPizza
        PanierVide
        PanierRempli
    End Enum

    Private EtatActuel As EtatCommande

    Private EtatSelectionPizzaActuel As EtatSelectionPizza

    Private lblTitle As Label
    Private lstPizzerias As ListBox
    Private lstPizzas As ListBox
    Private lstPanier As ListBox
    Private btnAjouter As Button
    Private btnSupprimer As Button
    Private btnRecup As Button
    Private btnEmporter As Button
    Private btnLivraison As Button
    Private btnValiderPizzeria As Button
    Private btnRetour As Button

    Private panier As New List(Of String)

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuration du formulaire
        Me.Text = "Client - Sélection de Pizza"
        Me.Size = New Drawing.Size(350, 400)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Label
        lblTitle = New Label()
        lblTitle.Location = New Drawing.Point(10, 10)
        Me.Controls.Add(lblTitle)

        ' Boutons de sélection du mode de livraison
        btnEmporter = New Button()
        btnEmporter.Text = "À emporter"
        btnEmporter.Location = New Drawing.Point(10, 40)
        AddHandler btnEmporter.Click, AddressOf Me.ModeLivraison_Selected
        Me.Controls.Add(btnEmporter)

        btnLivraison = New Button()
        btnLivraison.Text = "Livraison"
        btnLivraison.Location = New Drawing.Point(150, 40)
        AddHandler btnLivraison.Click, AddressOf Me.ModeLivraison_Selected
        Me.Controls.Add(btnLivraison)

        ' Liste des pizzerias
        lstPizzerias = New ListBox()
        lstPizzerias.Items.AddRange(New String() {"Pizzeria A", "Pizzeria B", "Pizzeria C"})
        lstPizzerias.Location = New Drawing.Point(10, 80)
        lstPizzerias.Size = New Drawing.Size(260, 100)
        Me.Controls.Add(lstPizzerias)

        btnValiderPizzeria = New Button()
        btnValiderPizzeria.Text = "Valider Pizzeria"
        btnValiderPizzeria.Location = New Drawing.Point(10, 190)
        AddHandler btnValiderPizzeria.Click, AddressOf Me.Pizzeria_Selectionnee
        Me.Controls.Add(btnValiderPizzeria)

        ' Liste des pizzas
        lstPizzas = New ListBox()
        lstPizzas.Items.AddRange(New String() {"Margherita", "Pepperoni", "4 Fromages", "Végétarienne", "Hawaïenne"})
        lstPizzas.Location = New Drawing.Point(10, 80)
        lstPizzas.Size = New Drawing.Size(150, 100)
        Me.Controls.Add(lstPizzas)

        ' Liste du panier
        lstPanier = New ListBox()
        lstPanier.Location = New Drawing.Point(180, 80)
        lstPanier.Size = New Drawing.Size(150, 100)
        Me.Controls.Add(lstPanier)

        ' Boutons pour gérer le panier
        btnAjouter = New Button()
        btnAjouter.Text = "Ajouter"
        btnAjouter.Location = New Drawing.Point(10, 190)
        AddHandler btnAjouter.Click, AddressOf Me.Ajouter_Pizza
        Me.Controls.Add(btnAjouter)

        btnSupprimer = New Button()
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.Location = New Drawing.Point(180, 190)
        AddHandler btnSupprimer.Click, AddressOf Me.Supprimer_Pizza
        Me.Controls.Add(btnSupprimer)

        ' Bouton récupération
        btnRecup = New Button()
        btnRecup.Text = "Valider la commande"
        btnRecup.Location = New Drawing.Point(300, 300)
        btnRecup.Enabled = False ' Désactivé par défaut
        AddHandler btnRecup.Click, AddressOf Me.Valid_Click
        Me.Controls.Add(btnRecup)

        ' Bouton retour
        btnRetour = New Button()
        btnRetour.Text = "Retour"
        btnRetour.Location = New Drawing.Point(180, 300)
        AddHandler btnRetour.Click, AddressOf Me.Retour_Click
        Me.Controls.Add(btnRetour)

        ' Initialisation de l'état
        ChangerEtat(EtatCommande.SelectionModeLivraison)
    End Sub

    ' Changement d'état de la machine
    Private Sub ChangerEtat(nouvelEtat As EtatCommande)
        EtatActuel = nouvelEtat

        Select Case EtatActuel
            Case EtatCommande.SelectionModeLivraison
                lblTitle.Text = "Choisissez le mode de livraison :"
                btnEmporter.Visible = True
                btnLivraison.Visible = True
                lstPizzerias.Visible = False
                btnValiderPizzeria.Visible = False
                lstPizzas.Visible = False
                lstPanier.Visible = False
                btnAjouter.Visible = False
                btnSupprimer.Visible = False
                btnRecup.Visible = False
                btnRetour.Visible = False

            Case EtatCommande.SelectionPizzeria
                lblTitle.Text = "Sélectionnez une pizzeria :"
                btnEmporter.Visible = False
                btnLivraison.Visible = False
                lstPizzerias.Visible = True
                btnValiderPizzeria.Visible = True
                lstPizzas.Visible = False
                lstPanier.Visible = False
                btnAjouter.Visible = False
                btnSupprimer.Visible = False
                btnRecup.Visible = False
                btnRetour.Visible = True

            Case EtatCommande.SelectionPizza
                lblTitle.Text = "Ajoutez des pizzas à votre panier :"
                btnEmporter.Visible = False
                btnLivraison.Visible = False
                lstPizzerias.Visible = False
                btnValiderPizzeria.Visible = False
                lstPizzas.Visible = True
                lstPanier.Visible = True
                btnAjouter.Visible = True
                btnSupprimer.Visible = True
                btnRecup.Visible = panier.Count > 0
                btnRetour.Visible = True
                EtatSelectionPizzaActuel = EtatSelectionPizza.PanierVide

            Case EtatCommande.Confirmation
                lblTitle.Text = "Commande confirmée !"
                MessageBox.Show("Merci pour votre commande !", "Confirmation")
        End Select
    End Sub

    ' Sélection du mode de livraison
    Private Sub ModeLivraison_Selected(sender As Object, e As EventArgs)
        ChangerEtat(EtatCommande.SelectionPizzeria)
    End Sub

    ' Sélection de la pizzeria
    Private Sub Pizzeria_Selectionnee(sender As Object, e As EventArgs)
        If lstPizzerias.SelectedItem IsNot Nothing Then
            ChangerEtat(EtatCommande.SelectionPizza)
        Else
            MessageBox.Show("Veuillez sélectionner une pizzeria.", "Erreur")
        End If
    End Sub

    ' Ajouter une pizza au panier
    Private Sub Ajouter_Pizza(sender As Object, e As EventArgs)
        If lstPizzas.SelectedItem IsNot Nothing Then
            panier.Add(lstPizzas.SelectedItem.ToString())
            lstPanier.Items.Add(lstPizzas.SelectedItem.ToString())
            btnRecup.Enabled = True
            EtatSelectionPizzaActuel = EtatSelectionPizza.PanierRempli
        End If
    End Sub

    ' Supprimer une pizza du panier
    Private Sub Supprimer_Pizza(sender As Object, e As EventArgs)
        If lstPanier.SelectedItem IsNot Nothing Then
            panier.Remove(lstPanier.SelectedItem.ToString())
            lstPanier.Items.Remove(lstPanier.SelectedItem)

            If panier.Count > 0 Then
                btnRecup.Enabled = True
            Else
                EtatSelectionPizzaActuel = EtatSelectionPizza.PanierVide
                btnRecup.Enabled = False
            End If
        End If
    End Sub

    ' Validation de la commande
    Private Sub Valid_Click(sender As Object, e As EventArgs)
        If lstPizzas.SelectedItem IsNot Nothing Then
            MessageBox.Show("Vous avez sélectionné : " & lstPizzas.SelectedItem.ToString, "Confirmation")
            ChangerEtat(EtatCommande.Confirmation)
        Else
            MessageBox.Show("Veuillez sélectionner une pizza.", "Erreur")
        End If
    End Sub

    ' Bouton retour
    ' Retour à l'étape précédente
    Private Sub Retour_Click(sender As Object, e As EventArgs)
        Select Case EtatActuel
            Case EtatCommande.SelectionPizzeria
                ChangerEtat(EtatCommande.SelectionModeLivraison)
            Case EtatCommande.SelectionPizza
                ChangerEtat(EtatCommande.SelectionPizzeria)
        End Select
    End Sub

End Class