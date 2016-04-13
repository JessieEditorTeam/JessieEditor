'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:2/20/16 to 2/27/16
'The purpose of this form is to allow the use to change the color scheme of the program.
Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the color pictures to the color stored in the settings.
        lblColorWindow.BackColor = MainForm.rchEditor.BackColor
        lblIDEColor.BackColor = MainForm.BackColor
        lblCommands.BackColor = MainForm.lstCommands.BackColor
    End Sub
    Private Sub lblColorWindow_Click(sender As Object, e As EventArgs) Handles lblColorWindow.Click
        'Display the color dialog
        clrWindow.ShowDialog()
        'Store and set the background color of the code editor.
        MainForm.rchEditor.BackColor = clrWindow.Color
        lblColorWindow.BackColor = clrWindow.Color
        My.Settings.Colorcback = clrWindow.Color
    End Sub
    Private Sub lblCodeTXT_Click(sender As Object, e As EventArgs) Handles lblCodeTXT.Click
        'Display the color dialog
        clrWindow.ShowDialog()
        'Store and set the background color of the code editor.
        MainForm.rchEditor.BackColor = clrWindow.Color
        lblColorWindow.BackColor = clrWindow.Color
        My.Settings.Colorcback = clrWindow.Color
    End Sub
    Private Sub lblIDEColor_Click(sender As Object, e As EventArgs) Handles lblIDEColor.Click
        'Display the color dialog
        clrIDE.ShowDialog()
        'Store and set the background color of the main form.
        MainForm.BackColor = clrIDE.Color
        lblIDEColor.BackColor = clrIDE.Color
        My.Settings.ColorIDE = clrIDE.Color
    End Sub
    Private Sub lblIDETXT_Click(sender As Object, e As EventArgs) Handles lblIDETXT.Click
        'Display the color dialog
        clrIDE.ShowDialog()
        'Store and set the background color of the main form.
        MainForm.BackColor = clrIDE.Color
        lblIDEColor.BackColor = clrIDE.Color
        My.Settings.ColorIDE = clrIDE.Color
    End Sub
    Private Sub lblCommands_Click(sender As Object, e As EventArgs) Handles lblCommands.Click
        'Display the color dialog
        clrSidebar.ShowDialog()
        'Store and set the background color of the commands sidebar.
        MainForm.grpCommands.BackColor = clrSidebar.Color
        MainForm.lstCommands.BackColor = clrSidebar.Color
        MainForm.lblLine.BackColor = clrSidebar.Color
        lblCommands.BackColor = clrSidebar.Color
        My.Settings.ColorSide = clrSidebar.Color
    End Sub
    Private Sub lblCommandsSideTXT_Click(sender As Object, e As EventArgs) Handles lblCommandsSideTXT.Click
        'Display the color dialog
        clrSidebar.ShowDialog()
        'Store and set the background color of the commands sidebar.
        MainForm.grpCommands.BackColor = clrSidebar.Color
        MainForm.lstCommands.BackColor = clrSidebar.Color
        MainForm.lblLine.BackColor = clrSidebar.Color
        lblCommands.BackColor = clrSidebar.Color
        My.Settings.ColorSide = clrSidebar.Color
    End Sub
    Private Sub lblCode_Click(sender As Object, e As EventArgs) Handles lblCode.Click
        'Display the color dialog
        clrCode.ShowDialog()
        'Sets the color of the code in the editor.
        MainForm.rchEditor.ForeColor = clrCode.Color
        lblCode.BackColor = clrCode.Color
        MainForm.lstCommands.ForeColor = clrCode.Color
        My.Settings.ColorText = clrCode.Color
    End Sub
    Private Sub lblCodetxtTXT_Click(sender As Object, e As EventArgs) Handles lblCodetxtTXT.Click
        'Display the color dialog
        clrCode.ShowDialog()
        'Sets the color of the code in the editor.
        MainForm.rchEditor.ForeColor = clrCode.Color
        MainForm.lstCommands.ForeColor = clrCode.Color
        lblCode.BackColor = clrCode.Color
        My.Settings.ColorText = clrCode.Color
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Close this form
        Me.Close()
    End Sub
End Class