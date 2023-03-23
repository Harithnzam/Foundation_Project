Public Class My_Booking
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Page.Show()
        Me.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Do you want to cancel?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Cancellation")
        'If MsgBoxResult.Yes Then

        'End If

    End Sub
End Class