'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:1/28/16
'The purpose of this form is to display the user's data such as their name and points.
Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the user's name as it is stored in memory.
        lblName.Text = lblName.Text & My.Settings.FirstName & " " & My.Settings.LastName
        'Display the current points that the user has.
        lblPoints.Text = lblPoints.Text + My.Settings.Points
    End Sub
End Class