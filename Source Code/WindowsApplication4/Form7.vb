'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 10/27/15
'The purpose of this form is to create a variable for the main program.
Public Class Form7
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If MainForm.rchEditor.Text = "" Then
            'If the main editor is empty then add to top line.
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + "set " + txtVarName.Text + "=" + txtVarVal.Text
        Else
            'If the main editor is not empty then add to new line.
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + "set " + txtVarName.Text + "=" + txtVarVal.Text
            'Clear Text then hide form.
            txtVarName.Text = ""
            txtVarVal.Text = ""
            Me.Hide()
        End If
    End Sub
End Class