<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.grpType1 = New System.Windows.Forms.GroupBox()
        Me.radVariable1 = New System.Windows.Forms.RadioButton()
        Me.radNumber1 = New System.Windows.Forms.RadioButton()
        Me.grpType2 = New System.Windows.Forms.GroupBox()
        Me.radVariable2 = New System.Windows.Forms.RadioButton()
        Me.radNumber2 = New System.Windows.Forms.RadioButton()
        Me.txtNumb1 = New System.Windows.Forms.TextBox()
        Me.txtNumb2 = New System.Windows.Forms.TextBox()
        Me.grpOperation = New System.Windows.Forms.GroupBox()
        Me.radMulitply = New System.Windows.Forms.RadioButton()
        Me.radDivide = New System.Windows.Forms.RadioButton()
        Me.radSubtract = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblOutputVar = New System.Windows.Forms.Label()
        Me.txtOutputVar = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpType1.SuspendLayout()
        Me.grpType2.SuspendLayout()
        Me.grpOperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpType1
        '
        Me.grpType1.Controls.Add(Me.radVariable1)
        Me.grpType1.Controls.Add(Me.radNumber1)
        Me.grpType1.Location = New System.Drawing.Point(12, 47)
        Me.grpType1.Name = "grpType1"
        Me.grpType1.Size = New System.Drawing.Size(122, 72)
        Me.grpType1.TabIndex = 0
        Me.grpType1.TabStop = False
        Me.grpType1.Text = "Type"
        '
        'radVariable1
        '
        Me.radVariable1.AutoSize = True
        Me.radVariable1.Location = New System.Drawing.Point(6, 42)
        Me.radVariable1.Name = "radVariable1"
        Me.radVariable1.Size = New System.Drawing.Size(63, 17)
        Me.radVariable1.TabIndex = 1
        Me.radVariable1.TabStop = True
        Me.radVariable1.Text = "Variable"
        Me.radVariable1.UseVisualStyleBackColor = True
        '
        'radNumber1
        '
        Me.radNumber1.AutoSize = True
        Me.radNumber1.Location = New System.Drawing.Point(6, 19)
        Me.radNumber1.Name = "radNumber1"
        Me.radNumber1.Size = New System.Drawing.Size(62, 17)
        Me.radNumber1.TabIndex = 0
        Me.radNumber1.TabStop = True
        Me.radNumber1.Text = "Number"
        Me.radNumber1.UseVisualStyleBackColor = True
        '
        'grpType2
        '
        Me.grpType2.Controls.Add(Me.radVariable2)
        Me.grpType2.Controls.Add(Me.radNumber2)
        Me.grpType2.Location = New System.Drawing.Point(299, 47)
        Me.grpType2.Name = "grpType2"
        Me.grpType2.Size = New System.Drawing.Size(122, 72)
        Me.grpType2.TabIndex = 1
        Me.grpType2.TabStop = False
        Me.grpType2.Text = "Type"
        '
        'radVariable2
        '
        Me.radVariable2.AutoSize = True
        Me.radVariable2.Location = New System.Drawing.Point(6, 42)
        Me.radVariable2.Name = "radVariable2"
        Me.radVariable2.Size = New System.Drawing.Size(63, 17)
        Me.radVariable2.TabIndex = 1
        Me.radVariable2.TabStop = True
        Me.radVariable2.Text = "Variable"
        Me.radVariable2.UseVisualStyleBackColor = True
        '
        'radNumber2
        '
        Me.radNumber2.AutoSize = True
        Me.radNumber2.Location = New System.Drawing.Point(6, 19)
        Me.radNumber2.Name = "radNumber2"
        Me.radNumber2.Size = New System.Drawing.Size(62, 17)
        Me.radNumber2.TabIndex = 0
        Me.radNumber2.TabStop = True
        Me.radNumber2.Text = "Number"
        Me.radNumber2.UseVisualStyleBackColor = True
        '
        'txtNumb1
        '
        Me.txtNumb1.Location = New System.Drawing.Point(12, 12)
        Me.txtNumb1.Name = "txtNumb1"
        Me.txtNumb1.Size = New System.Drawing.Size(160, 20)
        Me.txtNumb1.TabIndex = 2
        '
        'txtNumb2
        '
        Me.txtNumb2.Location = New System.Drawing.Point(261, 12)
        Me.txtNumb2.Name = "txtNumb2"
        Me.txtNumb2.Size = New System.Drawing.Size(160, 20)
        Me.txtNumb2.TabIndex = 3
        '
        'grpOperation
        '
        Me.grpOperation.Controls.Add(Me.radMulitply)
        Me.grpOperation.Controls.Add(Me.radDivide)
        Me.grpOperation.Controls.Add(Me.radSubtract)
        Me.grpOperation.Controls.Add(Me.radAdd)
        Me.grpOperation.Location = New System.Drawing.Point(12, 182)
        Me.grpOperation.Name = "grpOperation"
        Me.grpOperation.Size = New System.Drawing.Size(408, 117)
        Me.grpOperation.TabIndex = 4
        Me.grpOperation.TabStop = False
        Me.grpOperation.Text = "Operation"
        '
        'radMulitply
        '
        Me.radMulitply.AutoSize = True
        Me.radMulitply.Location = New System.Drawing.Point(6, 88)
        Me.radMulitply.Name = "radMulitply"
        Me.radMulitply.Size = New System.Drawing.Size(60, 17)
        Me.radMulitply.TabIndex = 3
        Me.radMulitply.TabStop = True
        Me.radMulitply.Text = "Multiply"
        Me.radMulitply.UseVisualStyleBackColor = True
        '
        'radDivide
        '
        Me.radDivide.AutoSize = True
        Me.radDivide.Location = New System.Drawing.Point(6, 65)
        Me.radDivide.Name = "radDivide"
        Me.radDivide.Size = New System.Drawing.Size(55, 17)
        Me.radDivide.TabIndex = 2
        Me.radDivide.TabStop = True
        Me.radDivide.Text = "Divide"
        Me.radDivide.UseVisualStyleBackColor = True
        '
        'radSubtract
        '
        Me.radSubtract.AutoSize = True
        Me.radSubtract.Location = New System.Drawing.Point(6, 42)
        Me.radSubtract.Name = "radSubtract"
        Me.radSubtract.Size = New System.Drawing.Size(65, 17)
        Me.radSubtract.TabIndex = 1
        Me.radSubtract.TabStop = True
        Me.radSubtract.Text = "Subtract"
        Me.radSubtract.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(6, 19)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(44, 17)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(195, 19)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(0, 13)
        Me.lblOperator.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 305)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(408, 31)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblOutputVar
        '
        Me.lblOutputVar.AutoSize = True
        Me.lblOutputVar.Location = New System.Drawing.Point(12, 145)
        Me.lblOutputVar.Name = "lblOutputVar"
        Me.lblOutputVar.Size = New System.Drawing.Size(111, 13)
        Me.lblOutputVar.TabIndex = 7
        Me.lblOutputVar.Text = "Output Variable Name"
        '
        'txtOutputVar
        '
        Me.txtOutputVar.Location = New System.Drawing.Point(129, 142)
        Me.txtOutputVar.Name = "txtOutputVar"
        Me.txtOutputVar.Size = New System.Drawing.Size(292, 20)
        Me.txtOutputVar.TabIndex = 8
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(203, 67)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 9
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 348)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOutputVar)
        Me.Controls.Add(Me.lblOutputVar)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.grpOperation)
        Me.Controls.Add(Me.txtNumb2)
        Me.Controls.Add(Me.txtNumb1)
        Me.Controls.Add(Me.grpType2)
        Me.Controls.Add(Me.grpType1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(449, 387)
        Me.MinimumSize = New System.Drawing.Size(449, 387)
        Me.Name = "Form5"
        Me.Text = "Math"
        Me.grpType1.ResumeLayout(False)
        Me.grpType1.PerformLayout()
        Me.grpType2.ResumeLayout(False)
        Me.grpType2.PerformLayout()
        Me.grpOperation.ResumeLayout(False)
        Me.grpOperation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpType1 As GroupBox
    Friend WithEvents radVariable1 As RadioButton
    Friend WithEvents radNumber1 As RadioButton
    Friend WithEvents grpType2 As GroupBox
    Friend WithEvents radVariable2 As RadioButton
    Friend WithEvents radNumber2 As RadioButton
    Friend WithEvents txtNumb1 As TextBox
    Friend WithEvents txtNumb2 As TextBox
    Friend WithEvents grpOperation As GroupBox
    Friend WithEvents radMulitply As RadioButton
    Friend WithEvents radDivide As RadioButton
    Friend WithEvents radSubtract As RadioButton
    Friend WithEvents radAdd As RadioButton
    Friend WithEvents lblOperator As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblOutputVar As Label
    Friend WithEvents txtOutputVar As TextBox
    Friend WithEvents lblOutput As Label
End Class
