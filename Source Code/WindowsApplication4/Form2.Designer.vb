<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkVar = New System.Windows.Forms.CheckBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(100, 107)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 29)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'chkVar
        '
        Me.chkVar.AutoSize = True
        Me.chkVar.Location = New System.Drawing.Point(12, 114)
        Me.chkVar.Name = "chkVar"
        Me.chkVar.Size = New System.Drawing.Size(78, 17)
        Me.chkVar.TabIndex = 1
        Me.chkVar.Text = "All Variable"
        Me.chkVar.UseVisualStyleBackColor = True
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(6, 66)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(204, 20)
        Me.txtText.TabIndex = 2
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(3, 24)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(65, 13)
        Me.lblText.TabIndex = 3
        Me.lblText.Text = "Text to Add:"
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(3, 139)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(259, 81)
        Me.lblInstructions.TabIndex = 4
        Me.lblInstructions.Text = "To make a segment of text a variable, add ""%"" around that segment of text.       " &
    "                             Ex: Hello my name is %var1%"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 196)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.chkVar)
        Me.Controls.Add(Me.btnSubmit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(246, 235)
        Me.MinimumSize = New System.Drawing.Size(246, 235)
        Me.Name = "Form2"
        Me.Text = "Add Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents chkVar As CheckBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblInstructions As Label
End Class
