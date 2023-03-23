Public Class Tour_Guide_List
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        lstMyTourGuide.Items.Add(lblCost1.Text & vbTab & lblName1.Text)
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstMyTourGuide.Items.Add(lblCost2.Text & vbTab & lblName2.Text)
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        lstMyTourGuide.Items.Add(lblCost3.Text & vbTab & lblName3.Text)
    End Sub

    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        lstMyTourGuide.Items.Add(lblCost4.Text & vbTab & lblName4.Text)
    End Sub

    Private Sub btnAdd5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        lstMyTourGuide.Items.Add(lblCost5.Text & vbTab & lblName5.Text)
    End Sub

    Private Sub btnAdd6_Click(sender As Object, e As EventArgs) Handles btnAdd6.Click
        lstMyTourGuide.Items.Add(lblCost6.Text & vbTab & lblName6.Text)
    End Sub

    Private Sub btnAdd7_Click(sender As Object, e As EventArgs) Handles btnAdd7.Click
        lstMyTourGuide.Items.Add(lblCost7.Text & vbTab & lblName7.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstMyTourGuide.SelectedItem Is Nothing Then
            MsgBox("Choose the Tour Guide that you want to remove." & MsgBoxStyle.OkOnly & "Remove Tour Guide")
        Else
            MsgBox("Do you want to remove the selected Tour Guide?" & MsgBoxStyle.YesNo & MsgBoxStyle.Question & "Remove Confimation")
            If MsgBoxResult.Yes Then
                lstMyTourGuide.Items.Remove(lstMyTourGuide.SelectedItem)
            End If
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Destinations.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Check_out.Show()
        Me.Hide()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        totCost = 22
        'For i = 1 To lstMyTourGuide.Items.Count - 1
        '    totCost += Val(lstMyTourGuide.Items(i) * Val(cboHours.SelectedItem))
        'Next

    End Sub


End Class