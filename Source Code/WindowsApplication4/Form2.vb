'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 4/10/16
'The purpose of this form is to add the display text command to the main editor, based on the text input from the user.
Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Test to See if the user wants the text as a variable.
        If chkVar.Checked = True Then
            If MainForm.rchEditor.Text = "" Then
                'If yes then convert input to variable
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + "echo" + " " + "%" + txtText.Text + "%"
            Else
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + "echo" + " " + "%" + txtText.Text + "%"
            End If
        Else
            'If not checked than leave text as is
            If MainForm.rchEditor.Text = "" Then
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + "echo" + " " + txtText.Text
            Else
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + "echo" + " " + txtText.Text
            End If
        End If
        'Clear Text Box and de-check text box
        txtText.Text = ""
        chkVar.Checked = False
        'hide form
        Me.Close()
    End Sub
End Class