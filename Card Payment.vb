Public Class Card_Payment
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Check_out.Show()
        Me.Hide()

    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        MsgBox("Payment Successful!", MsgBoxStyle.Information, "Status")
        Main_Page.Show()
        Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Do you want to cancel?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Cancellation")
        If MsgBoxResult.Yes Then
            Main_Page.Show()
            Me.Hide()

        End If
    End Sub
End Class