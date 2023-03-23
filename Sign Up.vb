Public Class Sign_Up


    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If cboSignAs.SelectedItem = "Tour Guide" Then
            Tour_Guide_Registration.Show()
            Me.Hide()
        Else
            MsgBox("Register successful!", MsgBoxStyle.Information, "Status")
            Main_Page.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub txtConfirmPassword_leave(sender As Object, e As EventArgs) Handles txtConfirmPassword.Leave
        If txtConfirmPassword.Text <> txtPassword.Text Then
            MsgBox("Incorrect Password, Please re-input", MsgBoxStyle.Exclamation, "Incorrect password")
            txtConfirmPassword.Text = ""
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Hide()

    End Sub

End Class