'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 4/1/16
'The main purpose of this form is to populate a list of plugins and allows users to run or remove them.
Imports System.IO
Public Class Form8
    'Declare variables.
    Dim fileReader As String
    Dim fileReader2 As String
    Private mRootPath As String = "plugins\"
    Dim itlives As Integer
    Dim p() As Process
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create a new node for the plugin treeview as the root node.
        Dim mRootNode As New TreeNode
        mRootNode.Text = RootPath
        mRootNode.Tag = RootPath
        mRootNode.Name = RootPath.ToLower
        mRootNode.Nodes.Add("*plugins*")
        trvPlugins.Nodes.Add(mRootNode)
    End Sub
    Property RootPath() As String
        Get
            Return mRootPath
        End Get
        Set(ByVal value As String)
            mRootPath = value
        End Set
    End Property
    Private Sub TreeView1_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvPlugins.BeforeCollapse
        'Clear all nodes then show main node.
        e.Node.Nodes.Clear()
        e.Node.Nodes.Add("*plugins*")
    End Sub
    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles trvPlugins.BeforeExpand
        'Clear all nodes.
        e.Node.Nodes.Clear()
        'Go to plugin director
        Dim mNodeDirectory As IO.DirectoryInfo
        mNodeDirectory = New IO.DirectoryInfo(e.Node.Tag.ToString)
        For Each mDirectory As IO.DirectoryInfo In mNodeDirectory.GetDirectories
            'Populate the tree view with all the plugins in the plugin directory.
            Dim mDirectoryNode As New TreeNode
            mDirectoryNode.Tag = mDirectory.FullName
            mDirectoryNode.Text = mDirectory.Name
            mDirectoryNode.Name = mDirectory.FullName.ToLower
            mDirectoryNode.Nodes.Add("*plugins*")
            e.Node.Nodes.Add(mDirectoryNode)
        Next
    End Sub
    Private Sub btnRemove_Click() Handles btnRemove.Click
        'If the selected node is the plugins folder then give error message to user.
        If trvPlugins.SelectedNode.Text = "plugins\" Then
            MsgBox("Cannot Delete Plugins Folder!")
        Else
            'Deletes the selected plugin
            My.Computer.FileSystem.DeleteDirectory("plugins\" + trvPlugins.SelectedNode.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
        End If
    End Sub
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'If the user tries to select the plugins folder, give them an error.
        If trvPlugins.SelectedNode.Text = "plugins\" Then
            MsgBox("Cannot run the plugins folder!")
        Else
            'Read the config folder of the selected plugin.
            fileReader = My.Computer.FileSystem.ReadAllText("plugins\" + trvPlugins.SelectedNode.Text + "\load.conf")
            'Run the exe file from the config file.
            Process1.StartInfo.FileName = "plugins\" + trvPlugins.SelectedNode.Text + "\" + fileReader
            Process1.Start()
            Do Until itlives = 1
                'Loop until plugin is done.
                CheckIfRunning()
            Loop
            itlives = 0
        End If
        Try
            My.Computer.FileSystem.DeleteFile("plugins\" + trvPlugins.SelectedNode.Text + "\read.txt")
            My.Computer.FileSystem.DeleteFile("plugins\" + trvPlugins.SelectedNode.Text + "\output.txt")
        Catch
            Try
                My.Computer.FileSystem.DeleteFile("read.txt")
                My.Computer.FileSystem.DeleteFile("output.txt")
            Catch
            End Try
        End Try
    End Sub
    Sub CheckIfRunning()
        'If the file exists then read it,stop the loop, and add it to the main editor.
        If Process1.HasExited = True Then
            Try
                If My.Computer.FileSystem.FileExists("output.txt") Then
                    'Copy the output to a seperate file for reading.
                    My.Computer.FileSystem.CopyFile("output.txt", "read.txt")
                    'Read the file.
                    fileReader2 = My.Computer.FileSystem.ReadAllText("read.txt")
                    'End the loop
                    itlives = 1
                    'Add it to the main editor.
                    MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + fileReader2
                ElseIf My.Computer.FileSystem.FileExists("plugins\" & trvPlugins.SelectedNode.Text & "output.txt") Then
                    'Copy the output to a seperate file for reading.
                    My.Computer.FileSystem.CopyFile("plugins\" + trvPlugins.SelectedNode.Text + "output.txt", "plugins\" + trvPlugins.SelectedNode.Text + "read.txt")
                    'Read the file.
                    fileReader2 = My.Computer.FileSystem.ReadAllText("plugins\" + trvPlugins.SelectedNode.Text + "\read.txt")
                    'End the loop
                    itlives = 1
                    'Add it to the main editor.
                    MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + fileReader2
                Else
                    'Notify user that plugin doesnt exist.
                    MsgBox("Plugin did not produce any output!")
                    itlives = 1
                End If
            Catch
                'Notify the plugin produced an error
                MsgBox("Error Reading Plugin!")
                itlives = 1
            End Try
        End If
    End Sub
End Class