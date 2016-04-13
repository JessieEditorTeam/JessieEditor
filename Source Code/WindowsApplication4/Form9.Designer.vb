<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.clrWindow = New System.Windows.Forms.ColorDialog()
        Me.lblColorWindow = New System.Windows.Forms.Label()
        Me.lblIDEColor = New System.Windows.Forms.Label()
        Me.lblCommands = New System.Windows.Forms.Label()
        Me.lblCodeTXT = New System.Windows.Forms.Label()
        Me.lblIDETXT = New System.Windows.Forms.Label()
        Me.lblCommandsSideTXT = New System.Windows.Forms.Label()
        Me.clrIDE = New System.Windows.Forms.ColorDialog()
        Me.clrSidebar = New System.Windows.Forms.ColorDialog()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblCodetxtTXT = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.clrCode = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'clrWindow
        '
        Me.clrWindow.Color = System.Drawing.SystemColors.GrayText
        '
        'lblColorWindow
        '
        Me.lblColorWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblColorWindow.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblColorWindow.Location = New System.Drawing.Point(27, 22)
        Me.lblColorWindow.Name = "lblColorWindow"
        Me.lblColorWindow.Size = New System.Drawing.Size(71, 63)
        Me.lblColorWindow.TabIndex = 0
        '
        'lblIDEColor
        '
        Me.lblIDEColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIDEColor.Location = New System.Drawing.Point(27, 130)
        Me.lblIDEColor.Name = "lblIDEColor"
        Me.lblIDEColor.Size = New System.Drawing.Size(71, 63)
        Me.lblIDEColor.TabIndex = 1
        '
        'lblCommands
        '
        Me.lblCommands.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCommands.Location = New System.Drawing.Point(27, 237)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(71, 63)
        Me.lblCommands.TabIndex = 2
        '
        'lblCodeTXT
        '
        Me.lblCodeTXT.AutoSize = True
        Me.lblCodeTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeTXT.Location = New System.Drawing.Point(125, 41)
        Me.lblCodeTXT.Name = "lblCodeTXT"
        Me.lblCodeTXT.Size = New System.Drawing.Size(358, 33)
        Me.lblCodeTXT.TabIndex = 3
        Me.lblCodeTXT.Text = "Code Window Background"
        '
        'lblIDETXT
        '
        Me.lblIDETXT.AutoSize = True
        Me.lblIDETXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDETXT.Location = New System.Drawing.Point(125, 150)
        Me.lblIDETXT.Name = "lblIDETXT"
        Me.lblIDETXT.Size = New System.Drawing.Size(226, 33)
        Me.lblIDETXT.TabIndex = 4
        Me.lblIDETXT.Text = "IDE Background"
        '
        'lblCommandsSideTXT
        '
        Me.lblCommandsSideTXT.AutoSize = True
        Me.lblCommandsSideTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommandsSideTXT.Location = New System.Drawing.Point(125, 252)
        Me.lblCommandsSideTXT.Name = "lblCommandsSideTXT"
        Me.lblCommandsSideTXT.Size = New System.Drawing.Size(273, 33)
        Me.lblCommandsSideTXT.TabIndex = 5
        Me.lblCommandsSideTXT.Text = "Commands Sidebar"
        '
        'clrIDE
        '
        Me.clrIDE.Color = System.Drawing.Color.DarkGray
        '
        'clrSidebar
        '
        Me.clrSidebar.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(30, 412)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(481, 49)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblCodetxtTXT
        '
        Me.lblCodetxtTXT.AutoSize = True
        Me.lblCodetxtTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodetxtTXT.Location = New System.Drawing.Point(125, 350)
        Me.lblCodetxtTXT.Name = "lblCodetxtTXT"
        Me.lblCodetxtTXT.Size = New System.Drawing.Size(149, 33)
        Me.lblCodetxtTXT.TabIndex = 8
        Me.lblCodetxtTXT.Text = "Code Text"
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCode.Location = New System.Drawing.Point(27, 335)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(71, 63)
        Me.lblCode.TabIndex = 7
        '
        'clrCode
        '
        Me.clrCode.Color = System.Drawing.Color.White
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 473)
        Me.Controls.Add(Me.lblCodetxtTXT)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCommandsSideTXT)
        Me.Controls.Add(Me.lblIDETXT)
        Me.Controls.Add(Me.lblCodeTXT)
        Me.Controls.Add(Me.lblCommands)
        Me.Controls.Add(Me.lblIDEColor)
        Me.Controls.Add(Me.lblColorWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(565, 512)
        Me.MinimumSize = New System.Drawing.Size(565, 512)
        Me.Name = "Form9"
        Me.Text = "Change Color Scheme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clrWindow As ColorDialog
    Friend WithEvents lblColorWindow As Label
    Friend WithEvents lblIDEColor As Label
    Friend WithEvents lblCommands As Label
    Friend WithEvents lblCodeTXT As Label
    Friend WithEvents lblIDETXT As Label
    Friend WithEvents lblCommandsSideTXT As Label
    Friend WithEvents clrIDE As ColorDialog
    Friend WithEvents clrSidebar As ColorDialog
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblCodetxtTXT As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents clrCode As ColorDialog
End Class
