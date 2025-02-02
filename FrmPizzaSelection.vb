Imports System.Windows.Forms

Public Class FrmPizzaSelection
    Inherits Form

    Private lblTitle As Label
    Private lstPizzas As ListBox
    Private btnSelect As Button
    Private btnCancel As Button

    Public Sub New()
        ' Configuration du formulaire
        Me.Text = "Sélection de Pizza"
        Me.Size = New Drawing.Size(300, 250)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Label
        lblTitle = New Label()
        lblTitle.Text = "Choisissez une pizza :"
        lblTitle.Location = New Drawing.Point(10, 10)
        Me.Controls.Add(lblTitle)

        ' Liste des pizzas
        lstPizzas = New ListBox()
        lstPizzas.Items.AddRange(New String() {"Margherita", "Pepperoni", "4 Fromages", "Végétarienne", "Hawaïenne"})
        lstPizzas.Location = New Drawing.Point(10, 40)
        lstPizzas.Size = New Drawing.Size(260, 100)
        Me.Controls.Add(lstPizzas)

        ' Bouton de sélection
        btnSelect = New Button()
        btnSelect.Text = "Sélectionner"
        btnSelect.Location = New Drawing.Point(10, 160)
        AddHandler btnSelect.Click, AddressOf Me.BtnSelect_Click
        Me.Controls.Add(btnSelect)

        ' Bouton d'annulation
        btnCancel = New Button()
        btnCancel.Text = "Annuler"
        btnCancel.Location = New Drawing.Point(150, 160)
        AddHandler btnCancel.Click, AddressOf Me.BtnCancel_Click
        Me.Controls.Add(btnCancel)
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs)
        If lstPizzas.SelectedItem IsNot Nothing Then
            MessageBox.Show("Vous avez sélectionné : " & lstPizzas.SelectedItem.ToString(), "Confirmation")
        Else
            MessageBox.Show("Veuillez sélectionner une pizza.", "Erreur")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class

