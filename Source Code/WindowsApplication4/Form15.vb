'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:4/5/16
'The purpose of this form is to allow the teacher to update the password
Public Class Form15
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'If the input password is the same as the current stored password.
        If txtCurrentPassword.Text = My.Settings.Password Then
            'Store the new password in the settings.
            My.Settings.Password = txtNewPassword.Text
            'Notify the user that password was succesfully updated.
            MsgBox("Password Succefully Update!")
            Me.Close()
        Else
            'Notify the user that the password was incorrect.
            MsgBox("Incorrect Password!")
            txtNewPassword.Text = ""
            txtCurrentPassword.Text = ""
        End If
    End Sub
End Class