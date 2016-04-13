'Made by: Benjamin Blackwell, James Stewart, and Jack Helm.
'Date Worked on:10/20/15 to 3/10/16
'The purpose of this form is to create math equations for the user's programs.
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide the output label
        lblOutput.Hide()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If radAdd.Checked = True Then
                If radVariable1.Checked = True Then
                    radVariable1.Checked = False
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + "%" + txtNumb1.Text + "% " + " +"
                    txtNumb1.Text = ""
                Else
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + txtNumb1.Text + " +"
                    txtNumb1.Text = ""
                End If
                If radVariable2.Checked = True Then
                    radVariable2.Checked = False
                    lblOutput.Text = lblOutput.Text + " " + "%" + txtNumb2.Text + "%"
                    txtNumb2.Text = ""
                Else
                    lblOutput.Text = lblOutput.Text + " " + txtNumb2.Text
                    txtNumb2.Text = ""
                End If
            End If
            If radSubtract.Checked = True Then
                radSubtract.Checked = False
                If radVariable1.Checked = True Then
                    radVariable1.Checked = False
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + "%" + txtNumb1.Text + "% " + " -"
                    txtNumb1.Text = ""
                Else
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + txtNumb1.Text + " -"
                    txtNumb1.Text = ""
                End If
                If radVariable2.Checked = True Then
                    radVariable2.Checked = False
                    lblOutput.Text = lblOutput.Text + " " + "%" + txtNumb2.Text + "%"
                    txtNumb2.Text = ""
                Else
                    lblOutput.Text = lblOutput.Text + " " + txtNumb2.Text
                    txtNumb2.Text = ""
                End If
            End If
            If radDivide.Checked = True Then
                radDivide.Checked = False
                If radVariable1.Checked = True Then
                    radVariable1.Checked = False
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + "%" + txtNumb1.Text + "% " + " /"
                    txtNumb1.Text = ""
                Else
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + txtNumb1.Text + " /"
                    txtNumb1.Text = ""
                End If
                If radVariable2.Checked = True Then
                    radVariable2.Checked = False
                    lblOutput.Text = lblOutput.Text + " " + "%" + txtNumb2.Text + "%"
                    txtNumb2.Text = ""
                Else
                    lblOutput.Text = lblOutput.Text + " " + txtNumb2.Text
                    txtNumb2.Text = ""
                End If
            End If
            If radMulitply.Checked = True Then
                radMulitply.Checked = False
                If radVariable1.Checked = True Then
                    radVariable1.Checked = False
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + "%" + txtNumb1.Text + "% " + " *"
                    txtNumb1.Text = ""
                Else
                    lblOutput.Text = "set /a " + txtOutputVar.Text + "=" + txtNumb1.Text + " *"
                    txtNumb1.Text = ""
                End If
                If radVariable2.Checked = True Then
                    radVariable2.Checked = False
                    lblOutput.Text = lblOutput.Text + " " + "%" + txtNumb2.Text + "%"
                    txtNumb2.Text = ""
                Else
                    lblOutput.Text = lblOutput.Text + " " + txtNumb2.Text
                    txtNumb2.Text = ""
                End If
            End If
            If MainForm.rchEditor.Text = "" Then
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + lblOutput.Text
            Else
                MainForm.rchEditor.Text = MainForm.rchEditor.Text + vbCrLf + lblOutput.Text
            End If
            txtOutputVar.Text = ""
            lblOutput.Text = ""
            Me.Hide()
        Catch
            MsgBox("Invalid Input!")
        End Try
    End Sub
    Private Sub radAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radAdd.CheckedChanged
        lblOperator.Text = "+"
    End Sub
    Private Sub radSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles radSubtract.CheckedChanged
        lblOperator.Text = "-"
    End Sub
    Private Sub radDivide_CheckedChanged(sender As Object, e As EventArgs) Handles radDivide.CheckedChanged
        lblOperator.Text = "/"
    End Sub
    Private Sub radMultiply_CheckedChanged(sender As Object, e As EventArgs) Handles radMulitply.CheckedChanged
        lblOperator.Text = "*"
    End Sub
End Class