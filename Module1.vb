Module Module1
    Public WithEvents Client As New Client
    Public WithEvents Pizzaiolo As New Pizzaiolo

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").
    Public grain As String = "Idle"


    'Public Sub f1_nextWindow() Handles F1.nextWindow
    '    Select Case grain
    '        Case "F1"
    '            grain = "F2"
    '            F1.Hide()
    '            F2.Show()
    '            F3.Hide()
    '        Case "F2"
    '            'interdit'
    '        Case "F3"
    '            'interdit'
    '    End Select

    'End Sub

    Public Sub Main()
        grain = “Idle"
        Client.Show()
        Pizzaiolo.Show()

    End Sub
End Module
