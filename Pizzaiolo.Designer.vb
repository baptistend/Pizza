<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pizzaiolo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstCommandes = New ListView()
        Commande = New ColumnHeader()
        Statut = New ColumnHeader()
        btnTerminer = New Button()
        SuspendLayout()
        ' 
        ' lstCommandes
        ' 
        lstCommandes.Columns.AddRange(New ColumnHeader() {Commande, Statut})
        lstCommandes.FullRowSelect = True
        lstCommandes.Location = New Point(10, 10)
        lstCommandes.Name = "lstCommandes"
        lstCommandes.Size = New Size(460, 250)
        lstCommandes.TabIndex = 0
        lstCommandes.UseCompatibleStateImageBehavior = False
        lstCommandes.View = View.Details
        ' 
        ' Commande
        ' 
        Commande.Text = "Commande"
        Commande.Width = 350
        ' 
        ' Statut
        ' 
        Statut.Text = "Statut"
        Statut.Width = 100
        ' 
        ' btnTerminer
        ' 
        btnTerminer.Enabled = False
        btnTerminer.Location = New Point(10, 302)
        btnTerminer.Name = "btnTerminer"
        btnTerminer.Size = New Size(111, 46)
        btnTerminer.TabIndex = 1
        btnTerminer.Text = "Terminer"
        btnTerminer.UseVisualStyleBackColor = True
        ' 
        ' Pizzaiolo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTerminer)
        Controls.Add(lstCommandes)
        Location = New Point(820, 0)
        Name = "Pizzaiolo"
        StartPosition = FormStartPosition.Manual
        Text = "Pizzaiolo"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstCommandes As ListView
    Private WithEvents Statut As ColumnHeader
    Friend WithEvents btnTerminer As Button
    Friend WithEvents Commande As ColumnHeader

End Class
