<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblHaveyou = New System.Windows.Forms.Label()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.chkRecorded = New System.Windows.Forms.CheckBox()
        Me.chkSaved = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(15, 119)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(368, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblHaveyou
        '
        Me.lblHaveyou.AutoSize = True
        Me.lblHaveyou.Location = New System.Drawing.Point(12, 9)
        Me.lblHaveyou.Name = "lblHaveyou"
        Me.lblHaveyou.Size = New System.Drawing.Size(61, 13)
        Me.lblHaveyou.TabIndex = 1
        Me.lblHaveyou.Text = "Have You.."
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(38, 43)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(119, 17)
        Me.chkBackup.TabIndex = 2
        Me.chkBackup.Text = "backed up plugins?"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'chkRecorded
        '
        Me.chkRecorded.AutoSize = True
        Me.chkRecorded.Location = New System.Drawing.Point(38, 66)
        Me.chkRecorded.Name = "chkRecorded"
        Me.chkRecorded.Size = New System.Drawing.Size(184, 17)
        Me.chkRecorded.TabIndex = 3
        Me.chkRecorded.Text = "recorded all user data and repos?"
        Me.chkRecorded.UseVisualStyleBackColor = True
        '
        'chkSaved
        '
        Me.chkSaved.AutoSize = True
        Me.chkSaved.Location = New System.Drawing.Point(38, 89)
        Me.chkSaved.Name = "chkSaved"
        Me.chkSaved.Size = New System.Drawing.Size(120, 17)
        Me.chkSaved.TabIndex = 4
        Me.chkSaved.Text = "saved all programs?"
        Me.chkSaved.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(408, 193)
        Me.AutoScrollMinSize = New System.Drawing.Size(408, 193)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(412, 173)
        Me.Controls.Add(Me.chkSaved)
        Me.Controls.Add(Me.chkRecorded)
        Me.Controls.Add(Me.chkBackup)
        Me.Controls.Add(Me.lblHaveyou)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "Are you sure?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents lblHaveyou As Label
    Friend WithEvents chkBackup As CheckBox
    Friend WithEvents chkRecorded As CheckBox
    Friend WithEvents chkSaved As CheckBox
End Class
