Public Class Client
    Inherits Form

    ' Définition des états
    Private Enum EtatCommande
        SelectionModeLivraison
        SelectionPizzeria
        SelectionPizza
        Confirmation
    End Enum

    Private EtatActuel As EtatCommande

    Private lblTitle As Label
    Private lstPizzerias As ListBox
    Private lstPizzas As ListBox
    Private btnRecup As Button
    Private btnEmporter As Button
    Private btnLivraison As Button
    Private btnValiderPizzeria As Button

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuration du formulaire
        Me.Text = "Client - Sélection de Pizza"
        Me.Size = New Drawing.Size(300, 350)
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
        lstPizzas.Size = New Drawing.Size(260, 150)
        Me.Controls.Add(lstPizzas)

        ' Bouton récupération
        btnRecup = New Button()
        btnRecup.Text = "Sélectionner"
        btnRecup.Location = New Drawing.Point(10, 240)
        AddHandler btnRecup.Click, AddressOf Me.Recup_Click
        Me.Controls.Add(btnRecup)

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
                btnRecup.Visible = False

            Case EtatCommande.SelectionPizzeria
                lblTitle.Text = "Sélectionnez une pizzeria :"
                btnEmporter.Visible = False
                btnLivraison.Visible = False
                lstPizzerias.Visible = True
                btnValiderPizzeria.Visible = True
                lstPizzas.Visible = False
                btnRecup.Visible = False

            Case EtatCommande.SelectionPizza
                lblTitle.Text = "Sélectionnez votre pizza :"
                btnEmporter.Visible = False
                btnLivraison.Visible = False
                lstPizzerias.Visible = False
                btnValiderPizzeria.Visible = False
                lstPizzas.Visible = True
                btnRecup.Visible = True

            Case EtatCommande.Confirmation
                lblTitle.Text = "Commande confirmée !"
                btnEmporter.Visible = False
                btnLivraison.Visible = False
                lstPizzerias.Visible = False
                btnValiderPizzeria.Visible = False
                lstPizzas.Visible = False
                btnRecup.Visible = False
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

    ' Sélection de la pizza
    Private Sub Recup_Click(sender As Object, e As EventArgs)
        If lstPizzas.SelectedItem IsNot Nothing Then
            MessageBox.Show("Vous avez sélectionné : " & lstPizzas.SelectedItem.ToString, "Confirmation")
            ChangerEtat(EtatCommande.Confirmation)
        Else
            MessageBox.Show("Veuillez sélectionner une pizza.", "Erreur")
        End If
    End Sub
End Class
