Imports Pizza.Commande

Public Class Pizzaiolo
    Public Async Sub CommandeRecue(commande As Commande)
        Await Task.Delay(1000)
        MessageBox.Show($"Commande reçue : {commande.afficherCommande()}")
    End Sub
End Class
