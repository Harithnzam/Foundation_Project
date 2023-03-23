Public Class Checklists


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If chk1.Checked = False Or chk2.Checked = False Or chk3.Checked = False Or chk4.Checked = False Or chk5.Checked = False Or chk6.Checked = False Then
            lblDisplay.Text = "Make sure your premise is in good and safe condition."

        ElseIf chk7.Checked Or chk8.Checked Or chk9.Checked Or chk10.Checked Or chk11.Checked Or chk12.Checked Then
            lblDisplay.Text = "You are not suitable to travel. Please take rest!"
        Else
            lblDisplay.Text = "HAVE A NICE TRIP!"

        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Page.Show()
        Me.Hide()

    End Sub

End Class