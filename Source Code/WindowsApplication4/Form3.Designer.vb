<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtIf1 = New System.Windows.Forms.TextBox()
        Me.txtIf2 = New System.Windows.Forms.TextBox()
        Me.lblIf = New System.Windows.Forms.Label()
        Me.lblThen = New System.Windows.Forms.Label()
        Me.grpLogic = New System.Windows.Forms.GroupBox()
        Me.radNotEqual = New System.Windows.Forms.RadioButton()
        Me.radLessEqual = New System.Windows.Forms.RadioButton()
        Me.RadGreatEqual = New System.Windows.Forms.RadioButton()
        Me.radGreater = New System.Windows.Forms.RadioButton()
        Me.radLess = New System.Windows.Forms.RadioButton()
        Me.radEquals = New System.Windows.Forms.RadioButton()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.grpPart1 = New System.Windows.Forms.GroupBox()
        Me.radVar1 = New System.Windows.Forms.RadioButton()
        Me.radTxt1 = New System.Windows.Forms.RadioButton()
        Me.grpPart2 = New System.Windows.Forms.GroupBox()
        Me.radVar2 = New System.Windows.Forms.RadioButton()
        Me.radText2 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpThen = New System.Windows.Forms.GroupBox()
        Me.radClose = New System.Windows.Forms.RadioButton()
        Me.radPause = New System.Windows.Forms.RadioButton()
        Me.radClear = New System.Windows.Forms.RadioButton()
        Me.radDisplay = New System.Windows.Forms.RadioButton()
        Me.radJump = New System.Windows.Forms.RadioButton()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpLogic.SuspendLayout()
        Me.grpPart1.SuspendLayout()
        Me.grpPart2.SuspendLayout()
        Me.grpThen.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIf1
        '
        Me.txtIf1.Location = New System.Drawing.Point(70, 19)
        Me.txtIf1.Name = "txtIf1"
        Me.txtIf1.Size = New System.Drawing.Size(216, 20)
        Me.txtIf1.TabIndex = 0
        '
        'txtIf2
        '
        Me.txtIf2.Location = New System.Drawing.Point(421, 19)
        Me.txtIf2.Name = "txtIf2"
        Me.txtIf2.Size = New System.Drawing.Size(216, 20)
        Me.txtIf2.TabIndex = 1
        '
        'lblIf
        '
        Me.lblIf.AutoSize = True
        Me.lblIf.Location = New System.Drawing.Point(24, 19)
        Me.lblIf.Name = "lblIf"
        Me.lblIf.Size = New System.Drawing.Size(22, 13)
        Me.lblIf.TabIndex = 2
        Me.lblIf.Text = "IF.."
        '
        'lblThen
        '
        Me.lblThen.AutoSize = True
        Me.lblThen.Location = New System.Drawing.Point(12, 172)
        Me.lblThen.Name = "lblThen"
        Me.lblThen.Size = New System.Drawing.Size(43, 13)
        Me.lblThen.TabIndex = 3
        Me.lblThen.Text = "THEN.."
        '
        'grpLogic
        '
        Me.grpLogic.Controls.Add(Me.radNotEqual)
        Me.grpLogic.Controls.Add(Me.radLessEqual)
        Me.grpLogic.Controls.Add(Me.RadGreatEqual)
        Me.grpLogic.Controls.Add(Me.radGreater)
        Me.grpLogic.Controls.Add(Me.radLess)
        Me.grpLogic.Controls.Add(Me.radEquals)
        Me.grpLogic.Location = New System.Drawing.Point(217, 45)
        Me.grpLogic.Name = "grpLogic"
        Me.grpLogic.Size = New System.Drawing.Size(265, 104)
        Me.grpLogic.TabIndex = 4
        Me.grpLogic.TabStop = False
        Me.grpLogic.Text = "Logic"
        '
        'radNotEqual
        '
        Me.radNotEqual.AutoSize = True
        Me.radNotEqual.Location = New System.Drawing.Point(125, 19)
        Me.radNotEqual.Name = "radNotEqual"
        Me.radNotEqual.Size = New System.Drawing.Size(83, 17)
        Me.radNotEqual.TabIndex = 5
        Me.radNotEqual.TabStop = True
        Me.radNotEqual.Text = "Not equal to"
        Me.radNotEqual.UseVisualStyleBackColor = True
        '
        'radLessEqual
        '
        Me.radLessEqual.AutoSize = True
        Me.radLessEqual.Location = New System.Drawing.Point(125, 42)
        Me.radLessEqual.Name = "radLessEqual"
        Me.radLessEqual.Size = New System.Drawing.Size(124, 17)
        Me.radLessEqual.TabIndex = 4
        Me.radLessEqual.TabStop = True
        Me.radLessEqual.Text = "Less than or equal to"
        Me.radLessEqual.UseVisualStyleBackColor = True
        '
        'RadGreatEqual
        '
        Me.RadGreatEqual.AutoSize = True
        Me.RadGreatEqual.Location = New System.Drawing.Point(125, 65)
        Me.RadGreatEqual.Name = "RadGreatEqual"
        Me.RadGreatEqual.Size = New System.Drawing.Size(137, 17)
        Me.RadGreatEqual.TabIndex = 3
        Me.RadGreatEqual.TabStop = True
        Me.RadGreatEqual.Text = "Greater than or equal to"
        Me.RadGreatEqual.UseVisualStyleBackColor = True
        '
        'radGreater
        '
        Me.radGreater.AutoSize = True
        Me.radGreater.Location = New System.Drawing.Point(6, 65)
        Me.radGreater.Name = "radGreater"
        Me.radGreater.Size = New System.Drawing.Size(88, 17)
        Me.radGreater.TabIndex = 2
        Me.radGreater.TabStop = True
        Me.radGreater.Text = "Greater Than"
        Me.radGreater.UseVisualStyleBackColor = True
        '
        'radLess
        '
        Me.radLess.AutoSize = True
        Me.radLess.Location = New System.Drawing.Point(6, 42)
        Me.radLess.Name = "radLess"
        Me.radLess.Size = New System.Drawing.Size(75, 17)
        Me.radLess.TabIndex = 1
        Me.radLess.TabStop = True
        Me.radLess.Text = "Less Than"
        Me.radLess.UseVisualStyleBackColor = True
        '
        'radEquals
        '
        Me.radEquals.AutoSize = True
        Me.radEquals.Location = New System.Drawing.Point(6, 19)
        Me.radEquals.Name = "radEquals"
        Me.radEquals.Size = New System.Drawing.Size(57, 17)
        Me.radEquals.TabIndex = 0
        Me.radEquals.TabStop = True
        Me.radEquals.Text = "Equals"
        Me.radEquals.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(292, 22)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(0, 13)
        Me.lblOperator.TabIndex = 5
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(181, 169)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(493, 20)
        Me.txtAction.TabIndex = 6
        '
        'grpPart1
        '
        Me.grpPart1.Controls.Add(Me.radVar1)
        Me.grpPart1.Controls.Add(Me.radTxt1)
        Me.grpPart1.Location = New System.Drawing.Point(70, 45)
        Me.grpPart1.Name = "grpPart1"
        Me.grpPart1.Size = New System.Drawing.Size(111, 104)
        Me.grpPart1.TabIndex = 7
        Me.grpPart1.TabStop = False
        Me.grpPart1.Text = "If Part1"
        '
        'radVar1
        '
        Me.radVar1.AutoSize = True
        Me.radVar1.Location = New System.Drawing.Point(6, 65)
        Me.radVar1.Name = "radVar1"
        Me.radVar1.Size = New System.Drawing.Size(63, 17)
        Me.radVar1.TabIndex = 1
        Me.radVar1.TabStop = True
        Me.radVar1.Text = "Variable"
        Me.radVar1.UseVisualStyleBackColor = True
        '
        'radTxt1
        '
        Me.radTxt1.AutoSize = True
        Me.radTxt1.Location = New System.Drawing.Point(6, 24)
        Me.radTxt1.Name = "radTxt1"
        Me.radTxt1.Size = New System.Drawing.Size(46, 17)
        Me.radTxt1.TabIndex = 0
        Me.radTxt1.TabStop = True
        Me.radTxt1.Text = "Text"
        Me.radTxt1.UseVisualStyleBackColor = True
        '
        'grpPart2
        '
        Me.grpPart2.Controls.Add(Me.radVar2)
        Me.grpPart2.Controls.Add(Me.radText2)
        Me.grpPart2.Location = New System.Drawing.Point(526, 45)
        Me.grpPart2.Name = "grpPart2"
        Me.grpPart2.Size = New System.Drawing.Size(111, 104)
        Me.grpPart2.TabIndex = 8
        Me.grpPart2.TabStop = False
        Me.grpPart2.Text = "If Part 2"
        '
        'radVar2
        '
        Me.radVar2.AutoSize = True
        Me.radVar2.Location = New System.Drawing.Point(6, 65)
        Me.radVar2.Name = "radVar2"
        Me.radVar2.Size = New System.Drawing.Size(63, 17)
        Me.radVar2.TabIndex = 2
        Me.radVar2.TabStop = True
        Me.radVar2.Text = "Variable"
        Me.radVar2.UseVisualStyleBackColor = True
        '
        'radText2
        '
        Me.radText2.AutoSize = True
        Me.radText2.Location = New System.Drawing.Point(6, 24)
        Me.radText2.Name = "radText2"
        Me.radText2.Size = New System.Drawing.Size(46, 17)
        Me.radText2.TabIndex = 1
        Me.radText2.TabStop = True
        Me.radText2.Text = "Text"
        Me.radText2.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 425)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(675, 41)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpThen
        '
        Me.grpThen.Controls.Add(Me.radClose)
        Me.grpThen.Controls.Add(Me.radPause)
        Me.grpThen.Controls.Add(Me.radClear)
        Me.grpThen.Controls.Add(Me.radDisplay)
        Me.grpThen.Controls.Add(Me.radJump)
        Me.grpThen.Location = New System.Drawing.Point(70, 221)
        Me.grpThen.Name = "grpThen"
        Me.grpThen.Size = New System.Drawing.Size(566, 181)
        Me.grpThen.TabIndex = 10
        Me.grpThen.TabStop = False
        Me.grpThen.Text = "Then Action"
        '
        'radClose
        '
        Me.radClose.AutoSize = True
        Me.radClose.Location = New System.Drawing.Point(6, 111)
        Me.radClose.Name = "radClose"
        Me.radClose.Size = New System.Drawing.Size(51, 17)
        Me.radClose.TabIndex = 4
        Me.radClose.TabStop = True
        Me.radClose.Text = "Close"
        Me.radClose.UseVisualStyleBackColor = True
        '
        'radPause
        '
        Me.radPause.AutoSize = True
        Me.radPause.Location = New System.Drawing.Point(6, 88)
        Me.radPause.Name = "radPause"
        Me.radPause.Size = New System.Drawing.Size(55, 17)
        Me.radPause.TabIndex = 3
        Me.radPause.TabStop = True
        Me.radPause.Text = "Pause"
        Me.radPause.UseVisualStyleBackColor = True
        '
        'radClear
        '
        Me.radClear.AutoSize = True
        Me.radClear.Location = New System.Drawing.Point(6, 65)
        Me.radClear.Name = "radClear"
        Me.radClear.Size = New System.Drawing.Size(86, 17)
        Me.radClear.TabIndex = 2
        Me.radClear.TabStop = True
        Me.radClear.Text = "Clear Screen"
        Me.radClear.UseVisualStyleBackColor = True
        '
        'radDisplay
        '
        Me.radDisplay.AutoSize = True
        Me.radDisplay.Location = New System.Drawing.Point(6, 42)
        Me.radDisplay.Name = "radDisplay"
        Me.radDisplay.Size = New System.Drawing.Size(83, 17)
        Me.radDisplay.TabIndex = 1
        Me.radDisplay.TabStop = True
        Me.radDisplay.Text = "Display Text"
        Me.radDisplay.UseVisualStyleBackColor = True
        '
        'radJump
        '
        Me.radJump.AutoSize = True
        Me.radJump.Location = New System.Drawing.Point(6, 19)
        Me.radJump.Name = "radJump"
        Me.radJump.Size = New System.Drawing.Size(62, 17)
        Me.radJump.TabIndex = 0
        Me.radJump.TabStop = True
        Me.radJump.Text = "Jump to"
        Me.radJump.UseVisualStyleBackColor = True
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Location = New System.Drawing.Point(73, 172)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(0, 13)
        Me.lblAction.TabIndex = 11
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(7, 244)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 12
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 478)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.grpThen)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpPart2)
        Me.Controls.Add(Me.grpPart1)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.grpLogic)
        Me.Controls.Add(Me.lblThen)
        Me.Controls.Add(Me.lblIf)
        Me.Controls.Add(Me.txtIf2)
        Me.Controls.Add(Me.txtIf1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(715, 517)
        Me.MinimumSize = New System.Drawing.Size(715, 517)
        Me.Name = "Form3"
        Me.Text = "IF Maker"
        Me.grpLogic.ResumeLayout(False)
        Me.grpLogic.PerformLayout()
        Me.grpPart1.ResumeLayout(False)
        Me.grpPart1.PerformLayout()
        Me.grpPart2.ResumeLayout(False)
        Me.grpPart2.PerformLayout()
        Me.grpThen.ResumeLayout(False)
        Me.grpThen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIf1 As TextBox
    Friend WithEvents txtIf2 As TextBox
    Friend WithEvents lblIf As Label
    Friend WithEvents lblThen As Label
    Friend WithEvents grpLogic As GroupBox
    Friend WithEvents radLessEqual As RadioButton
    Friend WithEvents RadGreatEqual As RadioButton
    Friend WithEvents radGreater As RadioButton
    Friend WithEvents radLess As RadioButton
    Friend WithEvents radEquals As RadioButton
    Friend WithEvents lblOperator As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents grpPart1 As GroupBox
    Friend WithEvents radVar1 As RadioButton
    Friend WithEvents radTxt1 As RadioButton
    Friend WithEvents grpPart2 As GroupBox
    Friend WithEvents radVar2 As RadioButton
    Friend WithEvents radText2 As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents grpThen As GroupBox
    Friend WithEvents radClose As RadioButton
    Friend WithEvents radPause As RadioButton
    Friend WithEvents radClear As RadioButton
    Friend WithEvents radDisplay As RadioButton
    Friend WithEvents radJump As RadioButton
    Friend WithEvents lblAction As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents radNotEqual As RadioButton
End Class
