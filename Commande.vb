Imports Microsoft.VisualBasic
Imports System.Text

Public Class Commande
    Public Property TypeDeLivraison As String ' "Emporter" ou "Livraison"
    Public Property Pizzeria As String ' Nom de la pizzeria
    Public Property Pizzas As List(Of String) ' Liste des noms de pizzas

    Public Sub New()

        Me.Pizzas = New List(Of String)()
    End Sub

    Public Sub SetTypeDeLivraison(typeLivraison As String)
        TypeDeLivraison = typeLivraison
    End Sub

    Public Sub SetPizzeria(pizzeria As String)
        Me.Pizzeria = pizzeria
    End Sub
    Public Function GetPizzas() As List(Of String)
        Return Pizzas
    End Function

    Public Function getCommandSize() As Integer
        Return Pizzas.Count
    End Function
    ' Ajouter une pizza
    Public Sub AjouterPizza(nomPizza As String)
        Pizzas.Add(nomPizza)
    End Sub
    Public Sub SupprimerPizza(index As Integer)
        If index >= 0 AndAlso index < Pizzas.Count Then
            Pizzas.RemoveAt(index)
        End If
    End Sub

    Public Function AfficherCommande() As String
        Dim commandeDetails As New StringBuilder()
        commandeDetails.AppendLine($"Commande ({TypeDeLivraison})")
        commandeDetails.AppendLine("")
        commandeDetails.AppendLine($"Pizzeria : {Pizzeria}")
        commandeDetails.AppendLine("")

        commandeDetails.AppendLine("Pizzas commandées :")

        For Each Pizza As String In Pizzas
            commandeDetails.AppendLine($"- {Pizza}")
        Next

        Return commandeDetails.ToString()
    End Function

End Class
