Public Class frmDialogue
    Private Sub frmDialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.buyPrice = -1
        Module1.sellPrice = -1
        Module1.individual = -1
    End Sub

    Private Sub btnUpdateValues_Click(sender As Object, e As EventArgs) Handles btnUpdateValues.Click
        Module1.buyPrice = nudBuyPrice.Value
        Module1.sellPrice = nudSellPrice.Value
        Module1.individual = nudIndividual.Value
        Close()
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Throw New Exception("Operation cancelled!")
    End Sub
End Class