Public Class Login
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Sign_Up.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Page.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MsgBox("Login Successful!", MsgBoxStyle.Information, "Status")
        Main_Page.Show()
        Me.Hide()

    End Sub

    Private Sub lblSeePword_Click(sender As Object, e As EventArgs) Handles lblSeePword.Click
        txtPassword.PasswordChar = ""

    End Sub

    Private Sub lblSeePword_MouseLeave(sender As Object, e As EventArgs) Handles lblSeePword.MouseLeave
        txtPassword.PasswordChar = "*"
    End Sub
End Class