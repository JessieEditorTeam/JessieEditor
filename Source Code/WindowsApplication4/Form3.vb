'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 4/10/16
'This form is designed to create an if statement in the main editor.
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the output label
        lblOutput.Hide()
    End Sub
    Private Sub radEquals_CheckedChanged(sender As Object, e As EventArgs) Handles radEquals.CheckedChanged
        'Set the Operator text to "equals"
        lblOperator.Text = "Equals"
    End Sub
    Private Sub radLess_CheckedChanged(sender As Object, e As EventArgs) Handles radLess.CheckedChanged
        'Set the Operator text to "is less than"
        lblOperator.Text = "is less than"
    End Sub
    Private Sub radGreater_CheckedChanged(sender As Object, e As EventArgs) Handles radGreater.CheckedChanged
        'Set the Operator text to "is greater than"
        lblOperator.Text = "is greater than"
    End Sub
    Private Sub radGreatEqual_CheckedChanged(sender As Object, e As EventArgs) Handles RadGreatEqual.CheckedChanged
        'Set the Operator text to "is greater than or equal to"
        lblOperator.Text = "is greater than or equal to"
    End Sub
    Private Sub radLessEqual_CheckedChanged(sender As Object, e As EventArgs) Handles radLessEqual.CheckedChanged
        'Set the Operator text to "is less than or equal to"
        lblOperator.Text = "is less than or equal to"
    End Sub
    Private Sub radNotEqual_CheckedChanged(sender As Object, e As EventArgs) Handles radNotEqual.CheckedChanged
        'Set the Operator text to "isnot equal to"
        lblOperator.Text = "is not equal to"
    End Sub
    Private Sub radClose_CheckedChanged(sender As Object, e As EventArgs) Handles radClose.CheckedChanged
        'set lblAction to "close" and disable action text box
        txtAction.Enabled = False
        lblAction.Text = "close."
    End Sub
    Private Sub radPause_CheckedChanged(sender As Object, e As EventArgs) Handles radPause.CheckedChanged
        'set lblAction to "pause." and disable action text box
        txtAction.Enabled = False
        lblAction.Text = "pause."
    End Sub
    Private Sub radClear_CheckedChanged(sender As Object, e As EventArgs) Handles radClear.CheckedChanged
        'set lblAction to "clear screen." and disable action text box
        txtAction.Enabled = False
        lblAction.Text = "clear screen."
    End Sub
    Private Sub radDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles radDisplay.CheckedChanged
        'set lblAction to "display text" and enable action text box
        txtAction.Enabled = True
        lblAction.Text = "display text:"
    End Sub
    Private Sub radJump_CheckedChanged(sender As Object, e As EventArgs) Handles radJump.CheckedChanged
        'set lblAction to "jump to:" and enable action text box
        txtAction.Enabled = True
        lblAction.Text = "jump to:"
    End Sub
    Private Sub btnSubmit_clicked(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Check the radio buttons and create an output based on selected radio buttons.
        lblOutput.Text = "if "
        If radVar1.Checked = True Then
            lblOutput.Text = lblOutput.Text + "%" + txtIf1.Text + "%"
            radVar1.Checked = False
        Else
            lblOutput.Text = lblOutput.Text + txtIf1.Text
            radTxt1.Checked = False
        End If
        If radEquals.Checked = True Then
            lblOutput.Text = lblOutput.Text + "=="
            radEquals.Checked = False
        End If
        If radLess.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "LSS" + " "
            radLess.Checked = False
        End If
        If radGreater.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "GTR" + " "
            radGreater.Checked = False
        End If
        If radNotEqual.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "NEQ" + " "
            radNotEqual.Checked = False
        End If
        If radLessEqual.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "LEQ" + " "
            radLessEqual.Checked = False
        End If
        If RadGreatEqual.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "GEQ" + " "
            RadGreatEqual.Checked = False
        End If
        If radVar2.Checked = True Then
            lblOutput.Text = lblOutput.Text + "%" + txtIf2.Text + "%"
            radVar2.Checked = False
        Else
            lblOutput.Text = lblOutput.Text + txtIf2.Text
            radText2.Checked = False
        End If
        If radJump.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "goto" + " " + txtAction.Text
            radJump.Checked = False
        End If
        If radDisplay.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "echo" + " " + txtAction.Text
            radDisplay.Checked = False
        End If
        If radClear.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "cls"
            radClear.Checked = False
        End If
        If radPause.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "pause"
            radPause.Checked = False
        End If
        If radClose.Checked = True Then
            lblOutput.Text = lblOutput.Text + " " + "exit"
            radClose.Checked = False
        End If
        'Add the finished command to the main editor
        If MainForm.rchEditor.Text = "" Then
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + lblOutput.Text
        Else
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + lblOutput.Text
        End If
        'Clear items and hide form.
        lblOutput.Text = ""
        txtIf1.Text = ""
        txtIf2.Text = ""
        txtAction.Text = ""
        Me.Hide()
    End Sub
End Class