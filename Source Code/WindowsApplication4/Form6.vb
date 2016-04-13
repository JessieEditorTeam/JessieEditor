'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:4/2/16 to 4/3/16
'This form is designed to check to make sure the user is ready to create a new profile.
Public Class Form6
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Makes sure that the plugins have been backed up, the points have been recorded, and the program has been saved. 
        If chkBackup.Checked = True Then
            If chkRecorded.Checked = True Then
                If chkSaved.Checked = True Then
                    'If all check boxes have been checked then create new user.
                    My.Settings.FirstName = "0"
                    My.Settings.LastName = ""
                    My.Settings.Points = "0"
                    MsgBox("Jessie Editor will now restart")
                    MainForm.bolIndexStart = False
                    MainForm.MainForm_Load()
                Else
                    'If any of the checkboxes arent checked then give message box notifiying user.
                    MsgBox("Please complete all the following actions before continuing.")
                End If
            Else
                MsgBox("Please complete all the following actions before continuing.")
            End If
        Else
            MsgBox("Please complete all the following actions before continuing.")
        End If
    End Sub
End Class