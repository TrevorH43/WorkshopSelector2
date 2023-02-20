Public Class Form1

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intTotalCost As Integer
        Dim intNumOfDays As Integer
        Dim intRegFee As Integer
        Dim intCostPerDay As Integer
        Dim intTotal As Integer
        costListBox.Items.Add(intNumOfDays)
        costListBox.Items.Add(intRegFee)
        costListBox.Items.Add(intCostPerDay)
        costListBox.Items.Add(intTotal)



        If workshopListBox.SelectedIndex = -1 Then
            MessageBox.Show("Select a Workshop.")
        ElseIf locationListBox.SelectedIndex = -1 Then
            MessageBox.Show("Select a City.")
        End If

        If workshopListBox.SelectedIndex = 0 Then
            intRegFee = 595
            intNumOfDays = 3
            costListBox.Items.Insert(0, "Handling Stress : $" & intRegFee)
        ElseIf workshopListBox.SelectedIndex = 1 Then
            intRegFee = 695
            intNumOfDays = 3
            costListBox.Items.Insert(0, "Time Management : $" & intRegFee)
        ElseIf workshopListBox.SelectedIndex = 2 Then
            intRegFee = 995
            intNumOfDays = 3
            costListBox.Items.Insert(0, "Supervision Skills : $" & intRegFee)
        ElseIf workshopListBox.SelectedIndex = 3 Then
            intRegFee = 1295
            intNumOfDays = 5
            costListBox.Items.Insert(0, "Negotiation : $" & intRegFee)
        ElseIf workshopListBox.SelectedIndex = 4 Then
            intRegFee = 395
            intNumOfDays = 1
            costListBox.Items.Insert(0, "How To Interview : $" & intRegFee)
        End If
        If workshopListBox.SelectedIndex = 0 Then
            intCostPerDay = 95 * intNumOfDays
            costListBox.Items.Insert(0, "Austin : $ " & intCostPerDay)
        ElseIf workshopListBox.SelectedIndex = 1 Then
            intCostPerDay = 125 * intNumOfDays
            costListBox.Items.Insert(0, "Chicago : $ " & intCostPerDay)
        ElseIf workshopListBox.SelectedIndex = 2 Then
            intCostPerDay = 110 * intNumOfDays
            costListBox.Items.Insert(0, "Dallas : $ " & intCostPerDay)
        ElseIf workshopListBox.SelectedIndex = 3 Then
            intCostPerDay = 100 * intNumOfDays
            costListBox.Items.Insert(0, "Orlando : $ " & intCostPerDay)
        ElseIf workshopListBox.SelectedIndex = 4 Then
            intCostPerDay = 92 * intNumOfDays
            costListBox.Items.Insert(0, "Phoenix : $ " & intCostPerDay)
        ElseIf workshopListBox.SelectedIndex = 5 Then
            intCostPerDay = 90 * intNumOfDays
            costListBox.Items.Insert(0, "Raleigh : $ " & intCostPerDay)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        totalCostLabel.Text = ""
        costListBox.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intNumOfDays As Integer
        Dim intRegFee As Integer
        Dim intCostPerDay As Integer

        If workshopListBox.SelectedIndex = 0 Then
            intRegFee = 595
            intNumOfDays = 3
        ElseIf workshopListBox.SelectedIndex = 1 Then
            intRegFee = 695
            intNumOfDays = 3
        ElseIf workshopListBox.SelectedIndex = 2 Then
            intRegFee = 995
            intNumOfDays = 3
        ElseIf workshopListBox.SelectedIndex = 3 Then
            intRegFee = 1295
            intNumOfDays = 5
        ElseIf workshopListBox.SelectedIndex = 4 Then
            intRegFee = 395
            intNumOfDays = 1
        End If
        If workshopListBox.SelectedIndex = 0 Then
            intCostPerDay = 95 * intNumOfDays
        ElseIf workshopListBox.SelectedIndex = 1 Then
            intCostPerDay = 125 * intNumOfDays
        ElseIf workshopListBox.SelectedIndex = 2 Then
            intCostPerDay = 110 * intNumOfDays
        ElseIf workshopListBox.SelectedIndex = 3 Then
            intCostPerDay = 100 * intNumOfDays
        ElseIf workshopListBox.SelectedIndex = 4 Then
            intCostPerDay = 92 * intNumOfDays
        ElseIf workshopListBox.SelectedIndex = 5 Then
            intCostPerDay = 90 * intNumOfDays
        End If


        totalCostLabel.Text = intCostPerDay + intRegFee

    End Sub
End Class
