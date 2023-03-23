Public Class Online_Banking
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Do you want to cancel your booking?" & MsgBoxStyle.YesNo & MsgBoxStyle.Question & "Cancel Confirmation")
        If MsgBoxResult.Yes Then
            Main_Page.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Transactions_Receipt.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Check_out.Show()
        Me.Hide()

    End Sub
End Class
