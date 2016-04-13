'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:2/19/16 to 4/10/16
'The purpose of this form is to allow users to download plugins.
Imports System.IO
Public Class Form13
    'Set variables
    Dim strRepoText As String
    Dim strRepoPic
    Dim repourl As String
    Dim intNoError As Integer
    'Dim repo settings from settings
    Dim repoFile1 As String = My.Settings.Repo1
    Dim repoFile2 As String = My.Settings.Repo2
    Dim repoFile3 As String = My.Settings.Repo3
    Dim repoFile4 As String = My.Settings.Repo4
    Dim repoFile5 As String = My.Settings.Repo5
    Dim repoFile6 As String = My.Settings.Repo6
    Dim repoFile7 As String = My.Settings.Repo7
    Dim repoFile8 As String = My.Settings.Repo8
    Dim repoFile9 As String = My.Settings.Repo9
    Dim repoFile10 As String = My.Settings.Repo10
    Private Sub Form13_Load() Handles MyBase.Load
        'Clear the repo list
        lstRepos.Items.Clear()
        'Load the labels with repo settings
        lblRepo1.Text = My.Settings.Repo1
        lblRepo2.Text = My.Settings.Repo2
        lblRepo3.Text = My.Settings.Repo3
        lblRepo4.Text = My.Settings.Repo4
        lblRepo5.Text = My.Settings.Repo5
        lblRepo6.Text = My.Settings.Repo6
        lblRepo7.Text = My.Settings.Repo7
        lblRepo8.Text = My.Settings.Repo8
        lblRepo9.Text = My.Settings.Repo9
        lblRepo10.Text = My.Settings.Repo10
        'Load pics and enable buttons of repos.
        If Not My.Settings.Repo1 = "" Then
            picRepo1.Image = Image.FromFile("repos\" & My.Settings.Repo1 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo1)
            btnRemove1.Enabled = True
            btnUpdate1.Enabled = True
        End If
        If Not My.Settings.Repo2 = "" Then
            picRepo2.Image = Image.FromFile("repos\" & My.Settings.Repo2 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo2)
            btnRemove2.Enabled = True
            btnUpdate2.Enabled = True
        End If
        If Not My.Settings.Repo3 = "" Then
            picRepo3.Image = Image.FromFile("repos\" & My.Settings.Repo3 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo3)
            btnRemove3.Enabled = True
            btnUpdate3.Enabled = True
        End If
        If Not My.Settings.Repo4 = "" Then
            picRepo4.Image = Image.FromFile("repos\" & My.Settings.Repo4 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo4)
            btnRemove4.Enabled = True
            btnUpdate4.Enabled = True
        End If
        If Not My.Settings.Repo5 = "" Then
            picRepo5.Image = Image.FromFile("repos\" & My.Settings.Repo5 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo5)
            btnRemove5.Enabled = True
            btnUpdate5.Enabled = True
        End If
        If Not My.Settings.Repo6 = "" Then
            picRepo6.Image = Image.FromFile("repos\" & My.Settings.Repo6 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo6)
            btnRemove6.Enabled = True
            btnUpdate6.Enabled = True
        End If
        If Not My.Settings.Repo7 = "" Then
            picRepo7.Image = Image.FromFile("repos\" & My.Settings.Repo7 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo7)
            btnRemove7.Enabled = True
            btnUpdate7.Enabled = True
        End If
        If Not My.Settings.Repo8 = "" Then
            picRepo8.Image = Image.FromFile("repos\" & My.Settings.Repo8 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo8)
            btnRemove8.Enabled = True
            btnUpdate8.Enabled = True
        End If
        If Not My.Settings.Repo9 = "" Then
            picRepo9.Image = Image.FromFile("repos\" & My.Settings.Repo9 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo9)
            btnRemove9.Enabled = True
            btnUpdate9.Enabled = True
        End If
        If Not My.Settings.Repo10 = "" Then
            picRepo10.Image = Image.FromFile("repos\" & My.Settings.Repo10 & "\repo.ico")
            lstRepos.Items.Add(My.Settings.Repo10)
            btnRemove10.Enabled = True
            btnUpdate10.Enabled = True
        End If
    End Sub
    Private Sub btnAddRepo_Click(sender As Object, e As EventArgs) Handles btnAddRepo.Click
        'Add a repo to the list in the first open slot.
        strRepoText = txtRepoName.Text
        download()
        If intNoError = 1 Then
            If My.Settings.Repo1 = "" Then
                'Store repo name in label
                lblRepo1.Text = strRepoText
                'set the repo image to the Repo's Icon
                picRepo1.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                'Store the repo name
                My.Settings.Repo1 = strRepoText
                'Enable the repos remove and update buttons.
                btnRemove1.Enabled = True
                btnUpdate1.Enabled = True
                'Store the repo's url in settings
                My.Settings.Repo1URL = txtRepoURL.Text
            ElseIf My.Settings.Repo2 = "" Then
                lblRepo2.Text = strRepoText
                picRepo2.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo2 = strRepoText
                btnRemove2.Enabled = True
                btnUpdate2.Enabled = True
                My.Settings.Repo2URL = txtRepoURL.Text
            ElseIf My.Settings.Repo3 = "" Then
                lblRepo3.Text = strRepoText
                picRepo3.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo3 = strRepoText
                btnRemove3.Enabled = True
                btnUpdate3.Enabled = True
                My.Settings.Repo3URL = txtRepoURL.Text
            ElseIf My.Settings.Repo4 = "" Then
                lblRepo4.Text = strRepoText
                picRepo4.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo4 = strRepoText
                btnRemove4.Enabled = True
                btnUpdate4.Enabled = True
                My.Settings.Repo4URL = txtRepoURL.Text
            ElseIf My.Settings.Repo5 = "" Then
                lblRepo5.Text = strRepoText
                picRepo5.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo5 = strRepoText
                btnRemove5.Enabled = True
                btnUpdate5.Enabled = True
                My.Settings.Repo5URL = txtRepoURL.Text
            ElseIf My.Settings.Repo6 = "" Then
                lblRepo6.Text = strRepoText
                picRepo6.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo6 = strRepoText
                btnRemove6.Enabled = True
                btnUpdate6.Enabled = True
                My.Settings.Repo6URL = txtRepoURL.Text
            ElseIf My.Settings.Repo7 = "" Then
                lblRepo7.Text = strRepoText
                picRepo7.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo7 = strRepoText
                btnRemove7.Enabled = True
                btnRemove7.Enabled = True
                My.Settings.Repo7URL = txtRepoURL.Text
            ElseIf My.Settings.Repo8 = "" Then
                lblRepo8.Text = strRepoText
                picRepo8.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo8 = strRepoText
                btnRemove8.Enabled = True
                btnUpdate8.Enabled = True
                My.Settings.Repo8URL = txtRepoURL.Text
            ElseIf My.Settings.Repo9 = "" Then
                lblRepo9.Text = strRepoText
                picRepo9.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo9 = strRepoText
                btnRemove9.Enabled = True
                btnUpdate9.Enabled = True
                My.Settings.Repo9URL = txtRepoURL.Text
            ElseIf My.Settings.Repo10 = "" Then
                lblRepo10.Text = strRepoText
                picRepo10.Image = Image.FromFile("repos\" & strRepoText & "\repo.ico")
                My.Settings.Repo10 = strRepoText
                btnRemove10.Enabled = True
                btnUpdate10.Enabled = True
                My.Settings.Repo10URL = txtRepoURL.Text
            Else
                'Notify user the maximum number of repos has been reached.
                MsgBox("Maximum number of repos reached!" + vbCrLf + "Delete one or more repos to add more.")
            End If
        End If
    End Sub
    Sub download()
        Try
            'Create repo directory 
            My.Computer.FileSystem.CreateDirectory("repos\" & txtRepoName.Text)
        Catch
            'Notify user that repo directory exists.
            MsgBox("Repo Already Exists!")
        End Try
        Try
            'Try to download the repo's required files.
            My.Computer.Network.DownloadFile(txtRepoURL.Text & "/repo1.txt", "repos\" & strRepoText & "\repo1.txt")
            My.Computer.Network.DownloadFile(txtRepoURL.Text & "/repo2.txt", "repos\" & strRepoText & "\repo2.txt")
            My.Computer.Network.DownloadFile(txtRepoURL.Text & "/repo3.txt", "repos\" & strRepoText & "\repo3.txt")
            My.Computer.Network.DownloadFile(txtRepoURL.Text & "/repo.ico", "repos\" & strRepoText & "\repo.ico")
            intNoError = 1
        Catch
            Try
                'Try to download the repo's required files.
                My.Computer.Network.DownloadFile(txtRepoURL.Text & "repo1.txt", "repos\" & strRepoText & "\repo1.txt")
                My.Computer.Network.DownloadFile(txtRepoURL.Text & "repo2.txt", "repos\" & strRepoText & "\repo2.txt")
                My.Computer.Network.DownloadFile(txtRepoURL.Text & "repo3.txt", "repos\" & strRepoText & "\repo3.txt")
                My.Computer.Network.DownloadFile(txtRepoURL.Text & "repo.ico", "repos\" & strRepoText & "\repo.ico")
                intNoError = 1
            Catch
                'Notify user that the url is invalid or doesn't exist.
                MsgBox("Invalid URL!")
            End Try
        End Try
    End Sub
    Private Sub lstRepos_SelectedIndexChanged() Handles lstRepos.SelectedIndexChanged
        Try
            'Test to see if user clicks on repo package name.
            Select Case lstRepos.SelectedItem.ToString
                Case My.Settings.Repo1
                    'Read the repo's package files and display packages.
                    readline()
                    repourl = My.Settings.Repo1URL
                    strRepoText = My.Settings.Repo1
                Case My.Settings.Repo2
                    readline()
                    repourl = My.Settings.Repo2URL
                    strRepoText = My.Settings.Repo2
                Case My.Settings.Repo3
                    readline()
                    repourl = My.Settings.Repo3URL
                    strRepoText = My.Settings.Repo3
                Case My.Settings.Repo4
                    readline()
                    repourl = My.Settings.Repo4URL
                    strRepoText = My.Settings.Repo4
                Case My.Settings.Repo5
                    readline()
                    repourl = My.Settings.Repo5URL
                    strRepoText = My.Settings.Repo5
                Case My.Settings.Repo6
                    readline()
                    repourl = My.Settings.Repo6URL
                    strRepoText = My.Settings.Repo6
                Case My.Settings.Repo7
                    readline()
                    repourl = My.Settings.Repo7URL
                    strRepoText = My.Settings.Repo7
                Case My.Settings.Repo8
                    readline()
                    repourl = My.Settings.Repo8URL
                    strRepoText = My.Settings.Repo8
                Case My.Settings.Repo9
                    readline()
                    repourl = My.Settings.Repo9URL
                    strRepoText = My.Settings.Repo9
                Case My.Settings.Repo10
                    readline()
                    repourl = My.Settings.Repo10URL
                    strRepoText = My.Settings.Repo10
                'If user clicks on one of the headings, do nothing.
                Case "Name-Description-Points"
                Case "_______________________________"
                Case Else
                    'If selected index isn't a repo then download package.
                    Dim s As String = lstRepos.SelectedItem.ToString
                    Dim parts As String() = s.Split(New Char() {"-"c})
                    Dim testurl As String = repourl & "/packages/" & parts(0) & ".zip"
                    Dim response As String
                    'Notify user the point cost of plugin and verify user wants the plugin.
                    response = MsgBox(Prompt:="This plugin costs:" & parts(2) & " points." & vbCrLf & " Are you sure you want to make this purchase?", Buttons:=vbYesNo)
                    If response = vbYes Then
                        'If yes then see if user has enough points.
                        If My.Settings.Points >= parts(2) Then
                            'Subtract the points from the user's profile.
                            My.Settings.Points = My.Settings.Points - parts(2)
                            'Download plugin and notify it was downloaded succefully.
                            My.Computer.Network.DownloadFile(testurl, "repos\" & strRepoText & "\" & lstRepos.SelectedItem.ToString & ".zip")
                            MsgBox("Download Succesful!")
                            'Open plugin zip file for user to extract it.
                            Process.Start("repos\" & strRepoText & "\" & lstRepos.SelectedItem.ToString & ".zip")
                        Else
                            'Notify user not enough points.
                            MsgBox("Not enough points to purchase plugin!")
                        End If
                    End If
            End Select
        Catch
            'Notify user that the repo or package is invalid.
            MsgBox("Repo/Package Is Invalid Or Corrupted!")
        End Try
    End Sub
    Sub readline()
        'set linecount and repo name variables.
        Dim linecount As Integer = -1
        Dim strSelectedRepo As String = lstRepos.SelectedItem.ToString
        Dim intdone As Integer = 0
        'Clear repos and prepare for packages.
        lstRepos.Items.Clear()
        lstRepos.Items.Add("Name-Description-Points")
        lstRepos.Items.Add("_______________________________")
        Try
            Do Until intdone = 1
                'Read the repo's package files.
                Dim filename As String = "repos\" & strSelectedRepo & "\repo1.txt"
                Dim filename2 As String = "repos\" & strSelectedRepo & "\repo2.txt"
                Dim filename3 As String = "repos\" & strSelectedRepo & "\repo3.txt"
                linecount = linecount + 1
                If linecount = GetNumberOfLines(filename) Then
                    intdone = 1
                End If
                'Add points to the repo package viewer.
                lstRepos.Items.Add(ReadLinenumb(filename, GetNumberOfLines(filename), linecount) & "-" & ReadLinenumb(filename2, GetNumberOfLines(filename2), linecount) & "-" & ReadLinenumb(filename3, GetNumberOfLines(filename3), linecount))
            Loop
        Catch
        End Try
    End Sub
    Public Function ReadLinenumb(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String
        'Create a file reading array.
        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return ""
        End If
        'Read all the lines of a file.
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line
    End Function
    Public Function GetNumberOfLines(ByVal file_path As String) As Integer
        'Count the number of available lines and create a new stream reader for the repo files.
        Dim sr As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While sr.Peek >= 0
            sr.ReadLine()
            'Count line up by 1
            NumberOfLines += 1
        Loop
        Return NumberOfLines
        'Close the stream reader.
        sr.Close()
        sr.Dispose()
    End Function
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Reload the form.
        Form13_Load()
    End Sub
    'When a update button is pushed, start the update process. This applies to all update buttons.
    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        Try
            'Delete all old repo files.
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo1 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo1 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo1 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo1URL & "/repo1.txt"
            'Download new repo files.
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo1 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo1URL & "/repo2.txt", "repos\" & My.Settings.Repo1 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo1URL & "/repo3.txt", "repos\" & My.Settings.Repo1 & "\repo3.txt")
            'Notify the user that updating is done.
            MsgBox("Update Succesful")
        Catch
            'Notify user that there was an error updating.
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo2 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo2 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo2 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo2URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo2 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo2URL & "/repo2.txt", "repos\" & My.Settings.Repo2 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo2URL & "/repo3.txt", "repos\" & My.Settings.Repo2 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo3 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo3 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo3 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo3URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo3 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo3URL & "/repo2.txt", "repos\" & My.Settings.Repo3 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo3URL & "/repo3.txt", "repos\" & My.Settings.Repo3 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate4_Click(sender As Object, e As EventArgs) Handles btnUpdate4.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo4 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo4 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo4 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo4URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo2 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo4URL & "/repo2.txt", "repos\" & My.Settings.Repo4 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo4URL & "/repo3.txt", "repos\" & My.Settings.Repo4 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate5_Click(sender As Object, e As EventArgs) Handles btnUpdate5.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo5 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo5 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo5 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo5URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo5 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo2URL & "/repo2.txt", "repos\" & My.Settings.Repo5 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo2URL & "/repo3.txt", "repos\" & My.Settings.Repo5 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate6_Click(sender As Object, e As EventArgs) Handles btnUpdate6.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo6 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo6 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo6 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo6URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo6 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo6URL & "/repo2.txt", "repos\" & My.Settings.Repo6 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo6URL & "/repo3.txt", "repos\" & My.Settings.Repo6 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate7_Click(sender As Object, e As EventArgs) Handles btnUpdate7.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo7 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo7 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo7 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo7URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo7 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo7URL & "/repo2.txt", "repos\" & My.Settings.Repo7 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo7URL & "/repo3.txt", "repos\" & My.Settings.Repo7 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate8_Click(sender As Object, e As EventArgs) Handles btnUpdate8.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo8 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo8 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo8 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo8URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo8 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo8URL & "/repo2.txt", "repos\" & My.Settings.Repo8 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo8URL & "/repo3.txt", "repos\" & My.Settings.Repo8 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub

    Private Sub btnUpdate9_Click(sender As Object, e As EventArgs) Handles btnUpdate9.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo9 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo9 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo9 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo9URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo9 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo9URL & "/repo2.txt", "repos\" & My.Settings.Repo9 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo9URL & "/repo3.txt", "repos\" & My.Settings.Repo9 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    Private Sub btnUpdate10_Click(sender As Object, e As EventArgs) Handles btnUpdate10.Click
        Try
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo10 & "\repo1.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo10 & "\repo2.txt")
            My.Computer.FileSystem.DeleteFile("repos\" & My.Settings.Repo10 & "\repo3.txt")
            Dim repoUpdate As String = My.Settings.Repo10URL & "/repo1.txt"
            My.Computer.Network.DownloadFile(repoUpdate, "repos\" & My.Settings.Repo10 & "\repo1.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo10URL & "/repo2.txt", "repos\" & My.Settings.Repo10 & "\repo2.txt")
            My.Computer.Network.DownloadFile(My.Settings.Repo10URL & "/repo3.txt", "repos\" & My.Settings.Repo10 & "\repo3.txt")
            MsgBox("Update Succesful")
        Catch
            MsgBox("Error Updating!")
        End Try
    End Sub
    'When a remove button is pushed then the remove repo process will stop.
    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        Try
            'Set the repo image to a blank image so the icon can be deleted.
            picRepo1.Image = My.Resources.Droplet
            'set the plugin directory to delete.
            Dim delDir As String = "repos\" & My.Settings.Repo1
            'Delete the plugin folder.
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            'Disable the remove and update button;also clear the stored repo data.
        Catch
            'Notify the user that there was an error removing the repo.
            MsgBox("Error removing some files!")
        End Try
        btnUpdate1.Enabled = False
        lblRepo1.Text = "Example Repo"
        My.Settings.Repo1 = ""
        My.Settings.Repo1URL = ""
        btnRemove1.Enabled = False
        'Notify the user that the repo was succesfully removed.
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove2_Click(sender As Object, e As EventArgs) Handles btnRemove2.Click
        Try
            picRepo2.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo2
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate2.Enabled = False
        lblRepo2.Text = ""
        My.Settings.Repo2 = "Example Repo"
        My.Settings.Repo2URL = ""
        btnRemove2.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove3_Click(sender As Object, e As EventArgs) Handles btnRemove3.Click
        Try
            picRepo3.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo3
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate3.Enabled = False
        lblRepo3.Text = "Example Repo"
        My.Settings.Repo3 = ""
        My.Settings.Repo3URL = ""
        btnRemove3.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove4_Click(sender As Object, e As EventArgs) Handles btnRemove4.Click
        Try
            picRepo4.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo4
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate4.Enabled = False
        lblRepo4.Text = "Example Repo"
        My.Settings.Repo4 = ""
        My.Settings.Repo4URL = ""
        btnRemove4.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove5_Click(sender As Object, e As EventArgs) Handles btnRemove5.Click
        Try
            picRepo5.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo5
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate5.Enabled = False
        lblRepo5.Text = "Example Repo"
        My.Settings.Repo5 = ""
        My.Settings.Repo5URL = ""
        btnRemove5.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove6_Click(sender As Object, e As EventArgs) Handles btnRemove6.Click
        Try
            picRepo6.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo6
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate6.Enabled = False
        lblRepo6.Text = "Example Repo"
        My.Settings.Repo6 = ""
        My.Settings.Repo6URL = ""
        btnRemove6.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove7_Click(sender As Object, e As EventArgs) Handles btnRemove7.Click
        Try
            picRepo7.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo7
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate7.Enabled = False
        lblRepo7.Text = "Example Repo"
        My.Settings.Repo7 = ""
        My.Settings.Repo7URL = ""
        btnRemove7.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove8_Click(sender As Object, e As EventArgs) Handles btnRemove8.Click
        Try
            picRepo8.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo8
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate8.Enabled = False
        lblRepo8.Text = "Example Repo"
        My.Settings.Repo8 = ""
        My.Settings.Repo8URL = ""
        btnRemove8.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove9_Click(sender As Object, e As EventArgs) Handles btnRemove9.Click
        Try
            picRepo9.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo9
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate9.Enabled = False
        lblRepo9.Text = "Example Repo"
        My.Settings.Repo9 = ""
        My.Settings.Repo9URL = ""
        btnRemove9.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
    Private Sub btnRemove10_Click(sender As Object, e As EventArgs) Handles btnRemove10.Click
        Try
            picRepo10.Image = My.Resources.Droplet
            Dim delDir As String = "repos\" & My.Settings.Repo10
            My.Computer.FileSystem.DeleteDirectory(delDir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch
            MsgBox("Error removing some files!")
        End Try
        btnUpdate10.Enabled = False
        lblRepo10.Text = "Example Repo"
        My.Settings.Repo10 = ""
        My.Settings.Repo10URL = ""
        btnRemove10.Enabled = False
        MsgBox("Repo Succesfully removed!")
    End Sub
End Class