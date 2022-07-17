Public Class frmMainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPriceAdjuster.Click
        frmPriceAdjuster.ShowDialog()
    End Sub

    Private Sub btnCheckPrices_Click(sender As Object, e As EventArgs) Handles btnCheckPrices.Click
        frmCheckPrices.ShowDialog()
    End Sub

    Private Sub btnCheckMargins_Click(sender As Object, e As EventArgs) Handles btnCheckMargins.Click
        frmMarginAdjuster.ShowDialog()
    End Sub
End Class