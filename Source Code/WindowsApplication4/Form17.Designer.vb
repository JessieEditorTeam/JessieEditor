<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.txtVarName = New System.Windows.Forms.TextBox()
        Me.lblVarName = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVarName
        '
        Me.txtVarName.Location = New System.Drawing.Point(12, 25)
        Me.txtVarName.Name = "txtVarName"
        Me.txtVarName.Size = New System.Drawing.Size(260, 20)
        Me.txtVarName.TabIndex = 0
        '
        'lblVarName
        '
        Me.lblVarName.AutoSize = True
        Me.lblVarName.Location = New System.Drawing.Point(12, 9)
        Me.lblVarName.Name = "lblVarName"
        Me.lblVarName.Size = New System.Drawing.Size(76, 13)
        Me.lblVarName.TabIndex = 1
        Me.lblVarName.Text = "Variable Name"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(12, 65)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(101, 13)
        Me.lblQuestion.TabIndex = 3
        Me.lblQuestion.Text = "User Input Question"
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(12, 81)
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(260, 20)
        Me.txtQuestion.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 107)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(260, 33)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 144)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.lblVarName)
        Me.Controls.Add(Me.txtVarName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 183)
        Me.MinimumSize = New System.Drawing.Size(300, 183)
        Me.Name = "Form17"
        Me.Text = "User Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVarName As TextBox
    Friend WithEvents lblVarName As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btnSubmit As Button
End Class
