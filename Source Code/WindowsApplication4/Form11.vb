'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:1/17/16 to 1/27/16
'The purpose of this form is to create a new user profile and setup the program.
Public Class Form11
    Public Property GrayText As Color
    Private Sub btnSumbit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Tests to see if any fields were left blank and if so give an error.
        If txtFirst.Text = "" Then
            MsgBox("Please fill out every field!")
        ElseIf txtLast.Text = "" Then
            MsgBox("Please fill out every field!")
        ElseIf txtPass.Text = "" Then
            MsgBox("Please fill out every field!")
        Else
            'If all fields were stored propperly then store them.
            pointwr()
            passwrt()
            usrwrt()
            Try
                'Delete all old plugins and repos if they exist
                Form8.Close()
                Form13.Close()
                If My.Computer.FileSystem.DirectoryExists("plugins") Then
                    My.Computer.FileSystem.DeleteDirectory("plugins", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                End If
                If My.Computer.FileSystem.DirectoryExists("repos") Then
                    My.Computer.FileSystem.DeleteDirectory("repos", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                End If
                'Create the plugins and repos directory.
                My.Computer.FileSystem.CreateDirectory("plugins")
                My.Computer.FileSystem.CreateDirectory("repos")
                'Hide this form and display the main editor.
                MainForm.Opacity = 1
                MainForm.Enabled = True
                If My.Settings.restored = "1" Then
                    MainForm.notBuilding.BalloonTipTitle = "Reopen"
                    MainForm.notBuilding.BalloonTipText = "Jessie Editor Restored!"
                    MainForm.notBuilding.ShowBalloonTip(5)
                    My.Settings.restored = 0
                End If
                Me.Close()
            Catch
                MsgBox("Error Creating new profile!")
            End Try
        End If
    End Sub
    Sub pointwr()
        'Store the first and last name in settings.
        My.Settings.FirstName = txtFirst.Text
        My.Settings.LastName = txtLast.Text
    End Sub
    Sub passwrt()
        'Stores the password in settings.
        My.Settings.Password = txtPass.Text
    End Sub
    Sub usrwrt()
        'Sets the users point value to zero.
        My.Settings.Points = 0
    End Sub
End Class