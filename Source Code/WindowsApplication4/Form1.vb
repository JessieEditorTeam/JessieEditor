'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 4/10/16
'This form is the main editor in which the code is edited and commands are executed.
'Other things can be used from it such as the plugin shop or the points manager.

'Imports the printing capabilities.
Imports System.Drawing.Printing
'Imports file management capabilities.
Imports System.IO
Public Class MainForm
    'Declare variables
    Dim strFile As String
    Dim intChanged As Integer
    Dim intCount As String
    Dim intError As Integer
    Dim intSaved As Integer
    Dim intResave As Integer
    Dim intRespond As Integer
    Public bolIndexStart As Boolean
    Public Sub MainForm_Load() Handles MyBase.Load
        Form6.Close()
        bolIndexStart = False
        If My.Settings.FirstName = "0" Then
            'If Not used before then defualt color palette is set.
            My.Settings.ColorIDE = SystemColors.ControlDark
            My.Settings.ColorSide = Color.FromArgb(64, 64, 64)
            My.Settings.ColorText = Color.White
            My.Settings.Colorcback = SystemColors.GrayText
        Else
        End If
        'Sets colors from My.Settings
        rchEditor.BackColor = My.Settings.Colorcback
        Me.BackColor = My.Settings.ColorIDE
        rchEditor.ForeColor = My.Settings.ColorText
        rchEditor.BackColor = My.Settings.Colorcback
        grpCommands.BackColor = My.Settings.ColorSide
        lstCommands.BackColor = My.Settings.ColorSide
        lblLine.BackColor = My.Settings.ColorSide
        lstCommands.ForeColor = My.Settings.Colorcback
        'Hides main Editor
        Me.Opacity = 0
        'Show Splash screen
        SplashScreen1.Show()
        btnStopDebug.Enabled = False
            intChanged = 0
        txtConsole.Text = txtConsole.Text + vbCrLf
        RefreshCommands()
        bolIndexStart = True
    End Sub
    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        'Runs debug sub
        debug()
    End Sub
    Sub debug()
        'Starts Debugging process
        txtConsole.Text = txtConsole.Text + "Loading.." + vbCrLf
        btnDebug.Enabled = False
        Dim FileWriter As StreamWriter
        'Saves program
        txtConsole.Text = txtConsole.Text + "Starting Program.." + vbCrLf
        FileWriter = New StreamWriter(My.Settings.BuildFile, False)
        FileWriter.WriteLine(rchEditor.Text)
        FileWriter.Flush()
        FileWriter.Close()
        'Start program using custom script or not.
        If My.Settings.CustomBuild = True Then
            prsProgram.StartInfo.FileName = "custom.bat"
        Else
            prsProgram.StartInfo.FileName = "run.bat"
        End If
        prsProgram.Start()
        rchEditor.Enabled = False
        'Disable all other controls and notify user.
        btnStopDebug.Enabled = True
        txtConsole.Text = txtConsole.Text + "Done!" + vbCrLf
        txtConsole.ForeColor = Color.DarkOrange
        notBuilding.BalloonTipTitle = "Debugging!"
        notBuilding.BalloonTipText = "Debugging has started..."
        notBuilding.ShowBalloonTip(5)
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStopDebug.Click
        'Ends Debugging.
        btnDebug.Enabled = True
        btnStopDebug.Enabled = False
        rchEditor.Enabled = True
        'Closes Program
        If prsProgram.HasExited = False Then
            prsProgram.Kill()
        End If
        'Notify user and delete file
        txtConsole.Text = txtConsole.Text + "Program Stopped." + vbCrLf
        txtConsole.ForeColor = Color.White
        My.Computer.FileSystem.DeleteFile(My.Settings.BuildFile)
    End Sub
    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        'Opens plugin manager
        Form8.Show()
    End Sub
    Private Sub lstCommands_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstCommands.SelectedIndexChanged
        If bolIndexStart = True Then
            If lstCommands.SelectedIndex = 0 Then
                'Add no line repeating command
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "@echo off"
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "@echo off"
                End If
            End If
            If lstCommands.SelectedIndex = 1 Then
                'Add clear screen command
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "cls"
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "cls"
                End If
            End If
            If lstCommands.SelectedIndex = 2 Then
                'Display message box with prompt to add title text.
                Dim myValue As String
                Dim message As String
                message = "Title text:"
                Dim title As String
                title = "Text Input"
                Dim defaultValue As String
                defaultValue = "Title"
                myValue = InputBox(message, title, defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "title" + " " + myValue
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "title" + " " + myValue
                End If
            End If
            If lstCommands.SelectedIndex = 3 Then
                'Displays add text command
                Form2.Show()
            End If
            If lstCommands.SelectedIndex = 4 Then
                'Adds pause command
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "pause"
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "pause"
                End If
            End If
            If lstCommands.SelectedIndex = 5 Then
                'Display variable creator form
                Form7.Show()
            End If
            If lstCommands.SelectedIndex = 6 Then
                'Display user input message box for user input command.
                Form17.Show()
            End If
            If lstCommands.SelectedIndex = 7 Then
                'Add location for jump to later
                Dim myValue As String
                Dim message As String
                message = "Location name:"
                Dim title As String
                title = "Text Input"
                Dim defaultValue As String
                defaultValue = "text"
                myValue = InputBox(message, title, defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + ":" + myValue
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + ":" + myValue
                End If
            End If
            If lstCommands.SelectedIndex = 8 Then
                'Add goto command
                Dim myValue As String
                Dim message As String
                message = "Jump to:"
                Dim title As String
                title = "Text Input"
                Dim defaultValue As String
                defaultValue = "text"
                myValue = InputBox(message, title, defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "goto" + " " + myValue
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "goto" + " " + myValue
                End If
            End If
            If lstCommands.SelectedIndex = 9 Then
                'Add "if" statement
                Form3.Show()
            End If
            If lstCommands.SelectedIndex = 10 Then
                'Add quit command
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "exit"
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "exit"
                End If
            End If
            If lstCommands.SelectedIndex = 11 Then
                'Add program color.
                Form4.Show()
            End If
            If lstCommands.SelectedIndex = 12 Then
                'Add Math to program.
                Form5.Show()
            End If
            If lstCommands.SelectedIndex = 13 Then
                'Add comment to user program.
                Dim myValue As String
                Dim message As String
                message = "Comment text:"
                Dim title As String
                title = "Text Input"
                Dim defaultValue As String
                defaultValue = "Title"
                myValue = InputBox(message, title, defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "::" + myValue
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "::" + myValue
                End If
            End If
            If lstCommands.SelectedIndex = 14 Then
                'Add a delay to the users program.
                Dim myValue As String
                Dim message As String
                message = "Delay in seconds:"
                Dim title As String
                title = "Text Input"
                Dim defaultValue As String
                defaultValue = "3"
                myValue = InputBox(message, title, defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + "timeout " + myValue + " /nobreak" + " >nul"
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + "timeout " + myValue + " /nobreak" + " >nul"
                End If
            End If
            If lstCommands.SelectedIndex = 15 Then
                'Add a program to be ran in the program.
                Dim myValue As String
                Dim defaultValue As String
                defaultValue = "defualt.exe"
                myValue = InputBox("Location of the file to execute:", "Executable name", defaultValue)
                If rchEditor.Text = "" Then
                    rchEditor.Text = rchEditor.Text + myValue
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + myValue
                End If
            End If
            If lstCommands.SelectedIndex = 16 Then
                If My.Settings.NewCommand1 = "" Then
                    Form16.Show()
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + My.Settings.NewCommand1
                End If
            End If
            If lstCommands.SelectedIndex = 17 Then
                If My.Settings.NewCommand2 = "" Then
                    Form16.Show()
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + My.Settings.NewCommand2
                End If
            End If
            If lstCommands.SelectedIndex = 18 Then
                If My.Settings.NewCommand3 = "" Then
                    Form16.Show()
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + My.Settings.NewCommand3
                End If
            End If
            If lstCommands.SelectedIndex = 19 Then
                If My.Settings.NewCommand4 = "" Then
                    Form16.Show()
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + My.Settings.NewCommand4
                End If
            End If
            If lstCommands.SelectedIndex = 20 Then
                If My.Settings.NewCommand5 = "" Then
                    Form16.Show()
                Else
                    rchEditor.Text = rchEditor.Text + vbCrLf + My.Settings.NewCommand5
                End If
            End If
        End If
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Dim Response As Integer
        If intChanged = 1 Then
            'Notify users there are unsaved changes and if they want to save or not.
            Response = MsgBox(Prompt:="There are unsaved changes." + vbCrLf + " Are you sure you want to quit?", Buttons:=vbYesNo)
            If Response = vbYes Then
                rchEditor.Text = "::Made With Jessie Editor!"
                rchEditor.Hide()
            Else
            End If
        Else
            rchEditor.Text = "::Made With Jessie Editor!"
            rchEditor.Hide()
        End If

    End Sub
    Private Sub rchEditor_Changed(sender As Object, e As EventArgs) Handles rchEditor.TextChanged
        'Notify save that program has been edited.
        intChanged = 1
        'if not done allready, close the splash screen
        SplashScreen1.Close()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        intSaved = 1
        intChanged = 0
        If intResave = 1 Then
            Dim filewriter As StreamWriter
            If intRespond = 0 Then
                'Saves program if allready exists
                filewriter = New StreamWriter(strFile, False)
                filewriter.WriteLine(rchEditor.Text)
                filewriter.Flush()
                filewriter.Close()
                txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
            End If
        Else
            Try
                savProgram.ShowDialog()
                Dim FileWriter As StreamWriter
                If intRespond = 0 Then
                    'Saves program if it has not been saved before
                    FileWriter = New StreamWriter(savProgram.FileName, False)
                    FileWriter.WriteLine(rchEditor.Text)
                    FileWriter.Flush()
                    FileWriter.Close()
                    strFile = savProgram.FileName
                    txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
                End If
            Catch
                'Notify user file save error.
                txtConsole.Text = txtConsole.Text + vbCrLf + "File save error!"
            End Try

            intResave = 1
        End If
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        'Clears textbox and adds our name to program comment.
        rchEditor.Text = "::Made With Jessie Editor!"
        rchEditor.Show()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Prompts user to open a file.
        opnFile.ShowDialog()
        Dim fileReader As String
        'Reads file and opens it to the richtext box editor.
        fileReader = My.Computer.FileSystem.ReadAllText(opnFile.FileName)
        rchEditor.Text = fileReader
        rchEditor.Show()
        strFile = opnFile.FileName
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Checks to see if user has saved work.
        Dim Response As String
        If intChanged = 1 Then
            Response = MsgBox(Prompt:="There are unsaved changes." + vbCrLf + " Are you sure you want to quit?", Buttons:=vbYesNo)
            If Response = vbYes Then
                'Close program.
                Me.Close()
            Else
            End If
        End If
    End Sub
    Private Sub DebubToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem1.Click
        'Starts the debugging process.
        debug()
    End Sub
    Private Sub CompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileToolStripMenuItem.Click
        'If it has been saved then dont ask user to save.
        If intSaved = 1 Then
            'Compiles program
            Dim FileWriter As StreamWriter
            FileWriter = New StreamWriter(savProgram.FileName, False)
            FileWriter.WriteLine(rchEditor.Text)
            FileWriter.Flush()
            FileWriter.Close()
            txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
            strFile = savProgram.FileName
            'If custom build is enabled then run build script
            If My.Settings.CustomBuild = True Then
                prsProgram.StartInfo.FileName = "custom.bat"
            End If
            'Notify user that compiling is complete
            txtConsole.Text = txtConsole.Text + vbCrLf + "Compiling.....Done!"
        Else
            'Prompt user to save file, then compile.
            Try
                intSaved = 1
                intChanged = 0
                savProgram.ShowDialog()
                'Write program to desired file.
                Dim FileWriter As StreamWriter
                FileWriter = New StreamWriter(savProgram.FileName, False)
                FileWriter.WriteLine(rchEditor.Text)
                FileWriter.Flush()
                FileWriter.Close()
                strFile = savProgram.FileName
                txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
                'If custom build is enabled then run build script
                If My.Settings.CustomBuild = True Then
                    prsProgram.StartInfo.FileName = "custom.bat"
                End If
                txtConsole.Text = txtConsole.Text + vbCrLf + "Compiling.....Done!"
            Catch
                'Notify user file save error.
                txtConsole.Text = txtConsole.Text + vbCrLf + "File save error!"
            End Try
        End If
    End Sub
    Private Sub AddPointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPointsToolStripMenuItem.Click
        'Opens Points Prompt window
        Form10.Show()
    End Sub
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        'Opens profile info dialog
        Form12.Show()
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Saves program in new directory
        savProgram.ShowDialog()
        Dim FileWriter As StreamWriter
        'Tests to see if user clicked cancel
        Try
            If intRespond = 0 Then
                'Save program
                FileWriter = New StreamWriter(savProgram.FileName, False)
                FileWriter.WriteLine(rchEditor.Text)
                FileWriter.Flush()
                FileWriter.Close()
                strFile = savProgram.FileName
                'Set intResave to 1 to notify program that the current code has been previously saved
                intResave = 1
            End If
        Catch
            'Notify user file save error 
            txtConsole.Text = txtConsole.Text + vbCrLf + "File save error!"
        End Try
    End Sub
    Private Sub OpenPluginsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPluginsToolStripMenuItem.Click
        'Starts explorer to open plugins folder
        Process.Start("plugins\")
    End Sub
    Private Sub NewProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProfileToolStripMenuItem.Click
        'Open New profile checklist
        Form6.Show()
    End Sub
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Open Change font dialog
        fntCode.ShowDialog()
        'Sets font to selected font
        rchEditor.Font = fntCode.Font
    End Sub
    Private Sub ColorSchemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorSchemeToolStripMenuItem.Click
        'Open color change form.
        Form9.Show()
    End Sub
    Private Sub notBuilding_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notBuilding.MouseDoubleClick
        'Makes Main editor the center of the screen.
        Me.Opacity = 1
        Me.Show()
        Me.TopMost = True
        Me.TopMost = False
    End Sub
    Private Sub notBuilding_BalloonTipShown() Handles notBuilding.BalloonTipShown
        'Makes Main editor the center of the screen.
        Me.Opacity = 1
        Me.Show()
        Me.TopMost = True
        Me.TopMost = False
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        'Open the password update form.
        Form15.Show()
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Prompts user to select print settings.
        printprg()
    End Sub
    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Trys to use print settings and then prints.
        Try
            pntCode.PrinterSettings = pntDialog.PrinterSettings
        Catch
            printprg()
        End Try
        printprg()
    End Sub
    Sub printprg()
        If intResave = 1 Then
            'Show print dialog form
            pntDialog.ShowDialog()
            'Saves file if allready saved
            strFile = savProgram.FileName
            Dim filewriter As StreamWriter
            filewriter = New StreamWriter(strFile, False)
            filewriter.WriteLine(rchEditor.Text)
            filewriter.Flush()
            filewriter.Close()
            txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
            pntCode.PrinterSettings = pntDialog.PrinterSettings
            pntCode.DocumentName = strFile
            ' Make a PrintDocument object.
            Dim print_document As PrintDocument = PreparePrintDocument()
            ' Prints
            print_document.Print()
        Else
            Try
                'Save document
                savProgram.ShowDialog()
                'Show Print Document
                pntDialog.ShowDialog()
                strFile = savProgram.FileName
                Dim filewriter As StreamWriter
                filewriter = New StreamWriter(strFile, False)
                filewriter.WriteLine(rchEditor.Text)
                filewriter.Flush()
                filewriter.Close()
                txtConsole.Text = txtConsole.Text + vbCrLf + "Project Saved!"
                pntCode.PrinterSettings = pntDialog.PrinterSettings
                ' Make a PrintDocument object.
                Dim print_document As PrintDocument = PreparePrintDocument()
                ' Prints
                print_document.Print()
            Catch
                MsgBox("Invalid File Save!")
            End Try
        End If
    End Sub
    Private Sub rchEditor_TextChanged(sender As Object, e As EventArgs) Handles rchEditor.TextChanged
        'Notify program that code has been edited
        intSaved = 0
    End Sub
    Private Sub PluginsShopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PluginsShopToolStripMenuItem.Click
        'Open plugin shop
        Form13.Show()
    End Sub
    Private Sub CustomBuildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomBuildToolStripMenuItem.Click
        'Open custom build dialog
        Form14.Show()
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PreparePrintDocument()
        'Launches Print Preview
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Function PreparePrintDocument() As PrintDocument
        ' Makes the PrintDocument object
        Dim print_document As New PrintDocument
        ' Installs the PrintPage event handler
        AddHandler print_document.PrintPage, AddressOf Print_PrintPage
        ' Return the print object
        Return print_document
    End Function
    Private Sub Print_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Draw text in print.
        e.Graphics.DrawString(rchEditor.Text, rchEditor.Font, Brushes.Black, 1, 1)
        e.HasMorePages = False
    End Sub
    Private Sub PrintToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click
        'Print Document
        printprg()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show the About dialog box
        AboutBox1.Show()
    End Sub
    Sub RefreshCommands()
        lstCommands.SelectedIndex = 16
        If My.Settings.NewCommand1 = "" Then
            lstCommands.Items(lstCommands.SelectedIndex) = "Custom Command 1"
        Else
            lstCommands.Items(lstCommands.SelectedIndex) = My.Settings.Command1Name
        End If
        lstCommands.SelectedIndex = 17
        If My.Settings.NewCommand2 = "" Then
            lstCommands.Items(lstCommands.SelectedIndex) = "Custom Command 2"
        Else
            lstCommands.Items(lstCommands.SelectedIndex) = My.Settings.Command2Name
        End If
        lstCommands.SelectedIndex = 18
        If My.Settings.NewCommand3 = "" Then
            lstCommands.Items(lstCommands.SelectedIndex) = "Custom Command 3"
        Else
            lstCommands.Items(lstCommands.SelectedIndex) = My.Settings.Command3Name
        End If
        lstCommands.SelectedIndex = 19
        If My.Settings.NewCommand4 = "" Then
            lstCommands.Items(lstCommands.SelectedIndex) = "Custom Command 4"
        Else
            lstCommands.Items(lstCommands.SelectedIndex) = My.Settings.Command4Name
        End If
        lstCommands.SelectedIndex = 20
        If My.Settings.Command5Name = "" Then
            lstCommands.Items(lstCommands.SelectedIndex) = "Custom Command 5"
        Else
            lstCommands.Items(lstCommands.SelectedIndex) = My.Settings.Command5Name
        End If
        lstCommands.SelectedIndex.Equals(Nothing)
        bolIndexStart = True
    End Sub
    Private Sub CustomCommandsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomCommandsToolStripMenuItem.Click
        'Show custom commands form.
        Form16.Show()
    End Sub
    Private Sub RestoreSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreSoftwareToolStripMenuItem.Click
        'Ask User if they are sure they want to restore Jessie Editor to defualt state.
        Dim result As Integer = MessageBox.Show("Are you sure you want to restore software?" & vbCrLf & "All data will be lost.", "Are you sure?", MessageBoxButtons.YesNo)
        'If yes then start restoration process.
        If result = DialogResult.Yes Then
            'Close all open forms besides the main editor.
            Form2.Close()
            Form3.Close()
            Form4.Close()
            Form5.Close()
            Form6.Close()
            Form7.Close()
            Form8.Close()
            Form9.Close()
            Form10.Close()
            Form11.Close()
            Form12.Close()
            Form13.Close()
            Form14.Close()
            Form15.Close()
            Form16.Close()
            SplashScreen1.Close()
            'Clear the editor text
            rchEditor.Text = "::Made with Jessie Editor"
            'Set all system settings to there defualt values.
            My.Settings.FirstName = "0"
            My.Settings.LastName = ""
            My.Settings.Password = ""
            My.Settings.Points = ""
            My.Settings.Repo1 = ""
            My.Settings.Repo2 = ""
            My.Settings.Repo3 = ""
            My.Settings.Repo4 = ""
            My.Settings.Repo5 = ""
            My.Settings.Repo6 = ""
            My.Settings.Repo7 = ""
            My.Settings.Repo8 = ""
            My.Settings.Repo9 = ""
            My.Settings.Repo10 = ""
            My.Settings.Repo1URL = ""
            My.Settings.Repo2URL = ""
            My.Settings.Repo3URL = ""
            My.Settings.Repo4URL = ""
            My.Settings.Repo5URL = ""
            My.Settings.Repo6URL = ""
            My.Settings.Repo7URL = ""
            My.Settings.Repo8URL = ""
            My.Settings.Repo9URL = ""
            My.Settings.Repo10URL = ""
            My.Settings.BuildFile = "run.bat"
            My.Settings.CustomBuild = "false"
            My.Settings.NewCommand1 = ""
            My.Settings.NewCommand2 = ""
            My.Settings.NewCommand3 = ""
            My.Settings.NewCommand4 = ""
            My.Settings.NewCommand5 = ""
            My.Settings.Command1Name = ""
            My.Settings.Command2Name = ""
            My.Settings.Command3Name = ""
            My.Settings.Command4Name = ""
            My.Settings.Command5Name = ""
            My.Settings.restored = "1"
            'Delete the plugins and repos folder.
            My.Computer.FileSystem.DeleteDirectory("plugins\", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            My.Computer.FileSystem.DeleteDirectory("repos\", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            'Reload main form
            Me.MainForm_Load()
        End If
    End Sub
    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        'Open HTML help file
        Process.Start("resources\index.html")
    End Sub
End Class