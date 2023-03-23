Public Class Cancel_Booking
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If rbOthers.Checked Then
            If txtOthers.Text = "" Then
                MsgBox("Please fill in the 'Others' section" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Information")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My_Booking.Show()
        Me.Hide()

    End Sub
End Class