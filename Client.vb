Public Class Client
    Inherits Form

    Private lblTitle As Label
    Private lstPizzas As ListBox
    Private btnRecup As Button
    Private btnEmporter As Button
    Private btnLivraison As Button

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuration du formulaire
        Me.Text = "Client - Sélection de Pizza"
        Me.Size = New Drawing.Size(300, 300)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Label
        lblTitle = New Label()
        lblTitle.Text = "Choisissez le mode de livraison :"
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

        ' Liste des pizzas
        lstPizzas = New ListBox()
        lstPizzas.Items.AddRange(New String() {"Margherita", "Pepperoni", "4 Fromages", "Végétarienne", "Hawaïenne"})
        lstPizzas.Location = New Drawing.Point(10, 80)
        lstPizzas.Size = New Drawing.Size(260, 150)
        lstPizzas.Visible = False ' Caché par défaut
        Me.Controls.Add(lstPizzas)

        ' Bouton récupération
        btnRecup = New Button()
        btnRecup.Text = "Sélectionner"
        btnRecup.Location = New Drawing.Point(10, 240)
        btnRecup.Visible = False ' Caché par défaut
        AddHandler btnRecup.Click, AddressOf Me.Recup_Click
        Me.Controls.Add(btnRecup)
    End Sub

    Private Sub ModeLivraison_Selected(sender As Object, e As EventArgs)
        lstPizzas.Visible = True
        btnRecup.Visible = True
    End Sub

    Private Sub Recup_Click(sender As Object, e As EventArgs)
        If lstPizzas.SelectedItem IsNot Nothing Then
            MessageBox.Show("Vous avez sélectionné : " & lstPizzas.SelectedItem.ToString, "Confirmation")
        Else
            MessageBox.Show("Veuillez sélectionner une pizza.", "Erreur")
        End If
    End Sub
End Class