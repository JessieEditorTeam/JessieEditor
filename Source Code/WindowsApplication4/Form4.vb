'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 2/5/16
'The purpose of this form is to create the color command for the main editor, based on the selected radio buttons.
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the output lable
        lblOutput.Hide()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblOutput.Text = "color "
        'Checks to see what radio buttons are seleted and adds the propper hex code to the output label.
        If radBblack.Checked = True Then
            lblOutput.Text = lblOutput.Text + "0"
            radBblack.Checked = False
        End If
        If radBblue.Checked = True Then
            lblOutput.Text = lblOutput.Text + "1"
            radBblue.Checked = False
        End If
        If radBgreen.Checked = True Then
            lblOutput.Text = lblOutput.Text + "2"
            radBgreen.Checked = False
        End If
        If radBpurple.Checked = True Then
            lblOutput.Text = lblOutput.Text + "5"
            radBpurple.Checked = False
        End If
        If radBred.Checked = True Then
            lblOutput.Text = lblOutput.Text + "4"
            radBred.Checked = False
        End If
        If radBaqua.Checked = True Then
            lblOutput.Text = lblOutput.Text + "3"
            radBaqua.Checked = False
        End If
        If radBgray.Checked = True Then
            lblOutput.Text = lblOutput.Text + "8"
            radBgray.Checked = False
        End If
        If radBwhite.Checked = True Then
            lblOutput.Text = lblOutput.Text + "7"
            radBwhite.Checked = False
        End If
        If radByellow.Checked = True Then
            lblOutput.Text = lblOutput.Text + "6"
            radByellow.Checked = False
        End If
        If radBlightgreen.Checked = True Then
            lblOutput.Text = lblOutput.Text + "A"
            radBlightgreen.Checked = False
        End If
        If radBlightred.Checked = True Then
            lblOutput.Text = lblOutput.Text + "C"
            radBlightred.Checked = False
        End If
        If radBlightblue.Checked = True Then
            lblOutput.Text = lblOutput.Text + "9"
            radBlightblue.Checked = False
        End If
        If radBlightaqua.Checked = True Then
            lblOutput.Text = lblOutput.Text + "B"
            radBlightaqua.Checked = False
        End If
        If radBlightyellow.Checked = True Then
            lblOutput.Text = lblOutput.Text + "E"
            radBlightyellow.Checked = False
        End If
        If radBlightpurple.Checked = True Then
            lblOutput.Text = lblOutput.Text + "D"
            radBlightpurple.Checked = False
        End If
        If radBbrightwhite.Checked = True Then
            lblOutput.Text = lblOutput.Text + "F"
            radBbrightwhite.Checked = False
        End If
        If radFblack.Checked = True Then
            lblOutput.Text = lblOutput.Text + "0"
            radFblack.Checked = False
        End If
        If radFblue.Checked = True Then
            lblOutput.Text = lblOutput.Text + "1"
            radFblue.Checked = False
        End If
        If radFgreen.Checked = True Then
            lblOutput.Text = lblOutput.Text + "2"
            radFgreen.Checked = False
        End If
        If radFpurple.Checked = True Then
            lblOutput.Text = lblOutput.Text + "5"
            radFpurple.Checked = False
        End If
        If radFred.Checked = True Then
            lblOutput.Text = lblOutput.Text + "4"
            radFred.Checked = False
        End If
        If radFaqua.Checked = True Then
            lblOutput.Text = lblOutput.Text + "3"
            radFaqua.Checked = False
        End If
        If radFgray.Checked = True Then
            lblOutput.Text = lblOutput.Text + "8"
            radFgray.Checked = False
        End If
        If radFwhite.Checked = True Then
            lblOutput.Text = lblOutput.Text + "7"
            radFwhite.Checked = False
        End If
        If radFyellow.Checked = True Then
            lblOutput.Text = lblOutput.Text + "6"
            radFyellow.Checked = False
        End If
        If radFlightgreen.Checked = True Then
            lblOutput.Text = lblOutput.Text + "A"
            radFlightgreen.Checked = False
        End If
        If radFlightred.Checked = True Then
            lblOutput.Text = lblOutput.Text + "C"
            radFlightred.Checked = False
        End If
        If radFlightblue.Checked = True Then
            lblOutput.Text = lblOutput.Text + "9"
            radFlightblue.Checked = False
        End If
        If radFlightaqua.Checked = True Then
            lblOutput.Text = lblOutput.Text + "B"
            radFlightaqua.Checked = False
        End If
        If radFlightyellow.Checked = True Then
            lblOutput.Text = lblOutput.Text + "E"
            radFlightyellow.Checked = False
        End If
        If radFlightpurple.Checked = True Then
            lblOutput.Text = lblOutput.Text + "D"
            radFlightpurple.Checked = False
        End If
        If radFbrightwhite.Checked = True Then
            lblOutput.Text = lblOutput.Text + "F"
            radFbrightwhite.Checked = False
        End If
        'Add code to the main editor
        If MainForm.rchEditor.Text = "" Then
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + lblOutput.Text
        Else
            MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + lblOutput.Text
        End If
        'Clears the output label
        lblOutput.Text = ""
        'Hides the form
        Me.Hide()
    End Sub
End Class