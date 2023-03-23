Public Class Tour_Guide_Registration
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim openPhoto As New OpenFileDialog
        openPhoto.Filter = ("Picture File|*.jpg;*.gif;*.png;.bmp;*.jpeg")
        openPhoto.ShowDialog()
        picProfile.ImageLocation = openPhoto.FileName
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Sign_Up.Show()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MsgBox("You have successfully register!", MsgBoxStyle.Information, "Status")
        Main_Page.Show()
        Me.Hide()

    End Sub
End Class