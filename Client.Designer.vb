﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LabelHeader = New Label()
        LivraisonImage = New PictureBox()
        EmporterImage = New PictureBox()
        LabelEmporter = New Label()
        LabelLivraison = New Label()
        LivraisonLayout = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        SelectionModeLivraisonLayout = New FlowLayoutPanel()
        SelectionPizzeriaLayout = New FlowLayoutPanel()
        lstPizzerias = New ListBox()
        btnValiderPizzeria = New Button()
        btnRetour = New Button()
        SelectionPizzaLayout = New FlowLayoutPanel()
        lstPizzas = New ListBox()
        lstPanier = New ListBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnAjouter = New Button()
        btnSupprimer = New Button()
        btnValiderCommande = New Button()
        CType(LivraisonImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmporterImage, ComponentModel.ISupportInitialize).BeginInit()
        LivraisonLayout.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SelectionModeLivraisonLayout.SuspendLayout()
        SelectionPizzeriaLayout.SuspendLayout()
        SelectionPizzaLayout.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Location = New Point(188, 43)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(238, 25)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "Choisir un mode de livraison"
        ' 
        ' LivraisonImage
        ' 
        LivraisonImage.BackgroundImage = My.Resources.Resources._4988376_livraison_de_pizza_avec_logo_scooter_gratuit_vectoriel
        LivraisonImage.BackgroundImageLayout = ImageLayout.Stretch
        LivraisonImage.InitialImage = My.Resources.Resources._4988376_livraison_de_pizza_avec_logo_scooter_gratuit_vectoriel
        LivraisonImage.Location = New Point(3, 3)
        LivraisonImage.Name = "LivraisonImage"
        LivraisonImage.Size = New Size(176, 140)
        LivraisonImage.SizeMode = PictureBoxSizeMode.AutoSize
        LivraisonImage.TabIndex = 1
        LivraisonImage.TabStop = False
        ' 
        ' EmporterImage
        ' 
        EmporterImage.BackgroundImage = My.Resources.Resources.Restaurant_pizzeria_à_Péron_La_Baronessa20
        EmporterImage.BackgroundImageLayout = ImageLayout.Stretch
        EmporterImage.InitialImage = My.Resources.Resources.Restaurant_pizzeria_à_Péron_La_Baronessa20
        EmporterImage.Location = New Point(3, 3)
        EmporterImage.Name = "EmporterImage"
        EmporterImage.Size = New Size(176, 140)
        EmporterImage.SizeMode = PictureBoxSizeMode.AutoSize
        EmporterImage.TabIndex = 2
        EmporterImage.TabStop = False
        ' 
        ' LabelEmporter
        ' 
        LabelEmporter.AutoSize = True
        LabelEmporter.Location = New Point(3, 146)
        LabelEmporter.Name = "LabelEmporter"
        LabelEmporter.Size = New Size(86, 25)
        LabelEmporter.TabIndex = 3
        LabelEmporter.Text = "Emporter"
        ' 
        ' LabelLivraison
        ' 
        LabelLivraison.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelLivraison.AutoSize = True
        LabelLivraison.Location = New Point(3, 146)
        LabelLivraison.Name = "LabelLivraison"
        LabelLivraison.Size = New Size(176, 25)
        LabelLivraison.TabIndex = 4
        LabelLivraison.Text = "Livraison"
        ' 
        ' LivraisonLayout
        ' 
        LivraisonLayout.AutoSize = True
        LivraisonLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        LivraisonLayout.Controls.Add(LivraisonImage)
        LivraisonLayout.Controls.Add(LabelLivraison)
        LivraisonLayout.FlowDirection = FlowDirection.TopDown
        LivraisonLayout.Location = New Point(3, 3)
        LivraisonLayout.Name = "LivraisonLayout"
        LivraisonLayout.Size = New Size(182, 171)
        LivraisonLayout.TabIndex = 5
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoSize = True
        FlowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel2.Controls.Add(EmporterImage)
        FlowLayoutPanel2.Controls.Add(LabelEmporter)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(191, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(182, 171)
        FlowLayoutPanel2.TabIndex = 6
        ' 
        ' SelectionModeLivraisonLayout
        ' 
        SelectionModeLivraisonLayout.AutoSize = True
        SelectionModeLivraisonLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SelectionModeLivraisonLayout.Controls.Add(LivraisonLayout)
        SelectionModeLivraisonLayout.Controls.Add(FlowLayoutPanel2)
        SelectionModeLivraisonLayout.Location = New Point(107, 126)
        SelectionModeLivraisonLayout.Margin = New Padding(3, 10, 10, 3)
        SelectionModeLivraisonLayout.Name = "SelectionModeLivraisonLayout"
        SelectionModeLivraisonLayout.Size = New Size(376, 177)
        SelectionModeLivraisonLayout.TabIndex = 7
        ' 
        ' SelectionPizzeriaLayout
        ' 
        SelectionPizzeriaLayout.AutoSize = True
        SelectionPizzeriaLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SelectionPizzeriaLayout.Controls.Add(lstPizzerias)
        SelectionPizzeriaLayout.Controls.Add(btnValiderPizzeria)
        SelectionPizzeriaLayout.FlowDirection = FlowDirection.TopDown
        SelectionPizzeriaLayout.Location = New Point(219, 125)
        SelectionPizzeriaLayout.Name = "SelectionPizzeriaLayout"
        SelectionPizzeriaLayout.Size = New Size(186, 175)
        SelectionPizzeriaLayout.TabIndex = 8
        ' 
        ' lstPizzerias
        ' 
        lstPizzerias.FormattingEnabled = True
        lstPizzerias.ItemHeight = 25
        lstPizzerias.Items.AddRange(New Object() {"Pizzeria A", "Pizzeria B", "Pizzeria C"})
        lstPizzerias.Location = New Point(3, 3)
        lstPizzerias.Name = "lstPizzerias"
        lstPizzerias.Size = New Size(180, 129)
        lstPizzerias.TabIndex = 0
        ' 
        ' btnValiderPizzeria
        ' 
        btnValiderPizzeria.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnValiderPizzeria.Location = New Point(71, 138)
        btnValiderPizzeria.Name = "btnValiderPizzeria"
        btnValiderPizzeria.Size = New Size(112, 34)
        btnValiderPizzeria.TabIndex = 1
        btnValiderPizzeria.Text = "Valider"
        btnValiderPizzeria.TextAlign = ContentAlignment.BottomRight
        btnValiderPizzeria.UseVisualStyleBackColor = True
        ' 
        ' btnRetour
        ' 
        btnRetour.Location = New Point(59, 400)
        btnRetour.Name = "btnRetour"
        btnRetour.Size = New Size(112, 34)
        btnRetour.TabIndex = 9
        btnRetour.Text = "Retour"
        btnRetour.UseVisualStyleBackColor = True
        ' 
        ' SelectionPizzaLayout
        ' 
        SelectionPizzaLayout.AutoSize = True
        SelectionPizzaLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SelectionPizzaLayout.Controls.Add(lstPizzas)
        SelectionPizzaLayout.Controls.Add(lstPanier)
        SelectionPizzaLayout.Controls.Add(FlowLayoutPanel1)
        SelectionPizzaLayout.Location = New Point(105, 137)
        SelectionPizzaLayout.Name = "SelectionPizzaLayout"
        SelectionPizzaLayout.Size = New Size(496, 135)
        SelectionPizzaLayout.TabIndex = 10
        ' 
        ' lstPizzas
        ' 
        lstPizzas.FormattingEnabled = True
        lstPizzas.ItemHeight = 25
        lstPizzas.Items.AddRange(New Object() {"Margherita", "Pepperoni", "4 Fromages", "Végétarienne", "Hawaïenne"})
        lstPizzas.Location = New Point(3, 3)
        lstPizzas.Name = "lstPizzas"
        lstPizzas.Size = New Size(180, 129)
        lstPizzas.TabIndex = 0
        ' 
        ' lstPanier
        ' 
        lstPanier.FormattingEnabled = True
        lstPanier.ItemHeight = 25
        lstPanier.Location = New Point(189, 3)
        lstPanier.Name = "lstPanier"
        lstPanier.Size = New Size(180, 129)
        lstPanier.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(btnAjouter)
        FlowLayoutPanel1.Controls.Add(btnSupprimer)
        FlowLayoutPanel1.Controls.Add(btnValiderCommande)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(375, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(118, 120)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' btnAjouter
        ' 
        btnAjouter.Location = New Point(3, 3)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(112, 34)
        btnAjouter.TabIndex = 2
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = True
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.Location = New Point(3, 43)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(112, 34)
        btnSupprimer.TabIndex = 3
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' btnValiderCommande
        ' 
        btnValiderCommande.Location = New Point(3, 83)
        btnValiderCommande.Name = "btnValiderCommande"
        btnValiderCommande.Size = New Size(112, 34)
        btnValiderCommande.TabIndex = 5
        btnValiderCommande.Text = "Valider"
        btnValiderCommande.UseVisualStyleBackColor = True
        ' 
        ' Client
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(687, 750)
        Controls.Add(SelectionPizzaLayout)
        Controls.Add(btnRetour)
        Controls.Add(SelectionModeLivraisonLayout)
        Controls.Add(LabelHeader)
        Controls.Add(SelectionPizzeriaLayout)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Client"
        StartPosition = FormStartPosition.Manual
        Text = "Client"
        CType(LivraisonImage, ComponentModel.ISupportInitialize).EndInit()
        CType(EmporterImage, ComponentModel.ISupportInitialize).EndInit()
        LivraisonLayout.ResumeLayout(False)
        LivraisonLayout.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        SelectionModeLivraisonLayout.ResumeLayout(False)
        SelectionModeLivraisonLayout.PerformLayout()
        SelectionPizzeriaLayout.ResumeLayout(False)
        SelectionPizzaLayout.ResumeLayout(False)
        SelectionPizzaLayout.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelHeader As Label
    Friend WithEvents LivraisonImage As PictureBox
    Friend WithEvents EmporterImage As PictureBox
    Friend WithEvents LabelEmporter As Label
    Friend WithEvents LabelLivraison As Label
    Friend WithEvents LivraisonLayout As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SelectionModeLivraisonLayout As FlowLayoutPanel
    Friend WithEvents SelectionPizzeriaLayout As FlowLayoutPanel
    Friend WithEvents lstPizzerias As ListBox
    Friend WithEvents btnValiderPizzeria As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents SelectionPizzaLayout As FlowLayoutPanel
    Friend WithEvents lstPizzas As ListBox
    Friend WithEvents lstPanier As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnValiderCommande As Button
End Class
