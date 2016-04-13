'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:11/5/15
'The purpose of this form is to allow the user to change the build output of the editor.
Imports System.IO
Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Test to see if custom build is allready enabled
        If My.Settings.CustomBuild = True Then
            chkCustom.Checked = True
        End If
        If chkCustom.Checked = True Then
            'If it is checked then enable the custom build output file and build process along with the submit button.
            txtBuild.Enabled = True
            txtFile.Enabled = True
            btnSubmit.Enabled = True
        Else
            'If it is not checked then disable the custom output form objects.
            txtBuild.Enabled = False
            txtFile.Enabled = False
            btnSubmit.Enabled = False
        End If
    End Sub
    Private Sub chkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustom.CheckedChanged
        If chkCustom.Checked = True Then
            'If Custom build is enabled then enable all objects.
            txtBuild.Enabled = True
            txtFile.Enabled = True
            btnSubmit.Enabled = True
        Else
            'If custom  build is disabled then disable all objects.
            txtBuild.Enabled = False
            txtFile.Enabled = False
            btnSubmit.Enabled = False
        End If
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'It custom build is enabled then store the build file name and create a custom compilation batch file.
        If chkCustom.Checked = True Then
            My.Settings.CustomBuild = True
            My.Settings.BuildFile = txtFile.Text()
            Dim FileWriter As StreamWriter
            FileWriter = New StreamWriter("custom.bat", False)
            FileWriter.WriteLine(txtBuild.Text)
            FileWriter.Flush()
            FileWriter.Close()
        Else
            'If custom build is disabled then store build defualts.
            My.Settings.CustomBuild = False
            My.Settings.BuildFile = "run.bat"
        End If
    End Sub
End Class