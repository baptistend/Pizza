Imports Pizza.Commande

Module Module1
    Public WithEvents Client As New Client
    Public WithEvents Pizzaiolo As New Pizzaiolo
    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").
    Public grain As String = "Idle"

    Public Sub Client_CommandeValidee(command As Commande) Handles Client.commandeValidee
        grain = "CommandeReceived"
        Pizzaiolo.CommandeRecue(command)
    End Sub


    Public Sub Main()
        grain = “Idle"
        Client.Show()
        Pizzaiolo.Show()

    End Sub
End Module
