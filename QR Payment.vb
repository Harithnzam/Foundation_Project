Public Class QR_Payment
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Check_out.Show()
        Me.Hide()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Transactions_Receipt.Show()
        Me.Hide()

    End Sub


End Class