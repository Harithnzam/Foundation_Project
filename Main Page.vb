Public Class Main_Page
    Private Sub lblLogSign_Click(sender As Object, e As EventArgs) Handles lblLogSign.Click
        Login.Show()
    End Sub

    Private Sub lblMyBookings_Click(sender As Object, e As EventArgs) Handles lblMyBookings.Click
        My_Booking.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        MsgBox("Do you want to Log Out?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "Log Out Confirmation")
        If MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        About_Page.Show()

    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        'tolong code kan yng error ni guna msgbox yg aku sediakan ni
        'MsgBox("Please Log In or Sign Up first to make a booking.", MsgBoxStyle.OkOnly, "Vaccal")
        Destinations.Show()
        Me.Hide()

    End Sub

    Private Sub btnTGList_Click(sender As Object, e As EventArgs) Handles btnTGList.Click
        Tour_Guide_List.Show()
        Me.Hide()

        'tolong code kan yng error ni 

        'MsgBox("Please Log In or Sign Up first to view our tour guide lists.", MsgBoxStyle.OkOnly, "Vaccal")
    End Sub

    Private Sub lblChecklists_Click(sender As Object, e As EventArgs) Handles lblChecklists.Click
        Checklists.Show()
        Me.Hide()

    End Sub
End Class