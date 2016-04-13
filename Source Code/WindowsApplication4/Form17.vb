'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:4/9/16
'The main purpose of this form is to allow users to make user input.
Public Class Form17
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Test to See if the program is empty.
        Try
            If MainForm.rchEditor.Text = "" Then
                'If yes then convert input to variable
                MainForm.rchEditor.Text = MainForm.rchEditor.Text
            Else
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + "set /p " + txtVarName.Text + "=" + txtQuestion.Text
            End If
            'hide form
            Me.Close()
        Catch
            MsgBox("Please Enter Valid Data!")
        End Try
    End Sub
End Class