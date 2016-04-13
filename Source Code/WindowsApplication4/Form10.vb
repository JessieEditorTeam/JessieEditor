'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/27/15 to 10/30/15
'The purpose of this form is to add or remove points from the user's point balance.
Public Class Form10
    'Set the current points variable.
    Dim cpoints As Integer
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the current amount points.
        lblPoints.Text = "Current Points:" & My.Settings.Points
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            'Set cpoints as the current ammount of points
            cpoints = My.Settings.Points
            Dim pass As String
            pass = txtPassword.Text
            'Test to see if the input password is equal to the teacher password
            If pass = My.Settings.Password Then
                'If the password is correct then add the points to the user's balance.
                My.Settings.Points = cpoints + txtPoints.Text
                txtPoints.Text = ""
                cpoints = My.Settings.Points
                lblPoints.Text = "Current Points:" & cpoints
                Me.Hide()
                txtPassword.Text = ""
            Else
                'If the password is correct then display an error.
                MsgBox("Invalid Password!")
                txtPassword.Text = ""
            End If
        Catch
            'If the user entered a non-integer point value then give an error.
            MsgBox("Invalid Input!")
        End Try
    End Sub
End Class