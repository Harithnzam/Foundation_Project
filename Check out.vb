Public Class Check_out

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If cboPayMode.SelectedItem = "Online Banking" Then
            Online_Banking.Show()
            Me.Hide()

        ElseIf cboPayMode.SelectedItem = "QR Payment" Then
            QR_Payment.Show()
            Me.Hide()

        Else
            Card_Payment.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Check_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAmtPay.Text = Format(totCost, "currency")
    End Sub
End Class