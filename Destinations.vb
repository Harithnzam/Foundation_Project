Public Class Destinations

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest1.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If
        End sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest2.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest3.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest4.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest5.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd6_Click(sender As Object, e As EventArgs) Handles btnAdd6.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest6.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd7_Click(sender As Object, e As EventArgs) Handles btnAdd7.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest7.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnAdd8_Click(sender As Object, e As EventArgs) Handles btnAdd8.Click
        If datTravel.Value = Nothing And datReturn.Value = Nothing Then
            MsgBox("Please choose your Date to Travel and Date to Return" & MsgBoxStyle.OkOnly & MsgBoxStyle.Exclamation & "Missing Mnformation")
        Else
            lstItinerary.Items.Add(lblDest7.Text & vbTab & datTravel.Value & " until " & datReturn.Value)
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstItinerary.Items.Remove(lstItinerary.SelectedItem)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Page.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rbYes.Checked Then
            Tour_Guide_List.Show()
            Me.Hide()
        Else
            Check_out.Show()
            Me.Hide()

        End If
    End Sub


End Class