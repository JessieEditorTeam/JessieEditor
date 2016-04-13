<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.chkCustom = New System.Windows.Forms.CheckBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.txtBuild = New System.Windows.Forms.TextBox()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkCustom
        '
        Me.chkCustom.AutoSize = True
        Me.chkCustom.Location = New System.Drawing.Point(12, 12)
        Me.chkCustom.Name = "chkCustom"
        Me.chkCustom.Size = New System.Drawing.Size(87, 17)
        Me.chkCustom.TabIndex = 0
        Me.chkCustom.Text = "Custom Build"
        Me.chkCustom.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(9, 32)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(118, 13)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output Build File Name:"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(133, 29)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(139, 20)
        Me.txtFile.TabIndex = 2
        '
        'txtBuild
        '
        Me.txtBuild.Location = New System.Drawing.Point(12, 75)
        Me.txtBuild.Multiline = True
        Me.txtBuild.Name = "txtBuild"
        Me.txtBuild.Size = New System.Drawing.Size(260, 174)
        Me.txtBuild.TabIndex = 3
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.Location = New System.Drawing.Point(9, 61)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(71, 13)
        Me.lblBuild.TabIndex = 4
        Me.lblBuild.Text = "Build Process"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(13, 255)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(259, 29)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 289)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblBuild)
        Me.Controls.Add(Me.txtBuild)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.chkCustom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 328)
        Me.MinimumSize = New System.Drawing.Size(300, 328)
        Me.Name = "Form14"
        Me.Text = "Custom Build"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkCustom As CheckBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents txtBuild As TextBox
    Friend WithEvents lblBuild As Label
    Friend WithEvents btnSubmit As Button
End Class
