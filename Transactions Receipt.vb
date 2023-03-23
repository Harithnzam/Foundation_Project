Public Class Transactions_Receipt

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If picReceipt.Image Is Nothing Then
            MsgBox("Please upload transactional receipt", MsgBoxStyle.Critical, "Status")
        Else
            MsgBox("Transaction succeed!", MsgBoxStyle.Information & MsgBoxStyle.OkOnly, "Status")
            Main_Page.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openPhoto As New OpenFileDialog
        openPhoto.Filter = ("Picture File|*.jpg;*.gif;*.png;.bmp;*.jpeg")
        openPhoto.ShowDialog()
        picReceipt.ImageLocation = openPhoto.FileName
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Check_out.Show()
        Me.Hide()
    End Sub

End Class