<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.txtVarName = New System.Windows.Forms.TextBox()
        Me.txtVarVal = New System.Windows.Forms.TextBox()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.lblVarName = New System.Windows.Forms.Label()
        Me.lblVarVal = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtVarName
        '
        Me.txtVarName.Location = New System.Drawing.Point(12, 39)
        Me.txtVarName.Name = "txtVarName"
        Me.txtVarName.Size = New System.Drawing.Size(207, 20)
        Me.txtVarName.TabIndex = 0
        '
        'txtVarVal
        '
        Me.txtVarVal.Location = New System.Drawing.Point(276, 39)
        Me.txtVarVal.Name = "txtVarVal"
        Me.txtVarVal.Size = New System.Drawing.Size(207, 20)
        Me.txtVarVal.TabIndex = 1
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.Location = New System.Drawing.Point(237, 39)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblEqual.TabIndex = 2
        Me.lblEqual.Text = "="
        '
        'lblVarName
        '
        Me.lblVarName.AutoSize = True
        Me.lblVarName.Location = New System.Drawing.Point(12, 23)
        Me.lblVarName.Name = "lblVarName"
        Me.lblVarName.Size = New System.Drawing.Size(76, 13)
        Me.lblVarName.TabIndex = 3
        Me.lblVarName.Text = "Variable Name"
        '
        'lblVarVal
        '
        Me.lblVarVal.AutoSize = True
        Me.lblVarVal.Location = New System.Drawing.Point(273, 23)
        Me.lblVarVal.Name = "lblVarVal"
        Me.lblVarVal.Size = New System.Drawing.Size(75, 13)
        Me.lblVarVal.TabIndex = 4
        Me.lblVarVal.Text = "Variable Value"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 94)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(471, 43)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 147)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblVarVal)
        Me.Controls.Add(Me.lblVarName)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.txtVarVal)
        Me.Controls.Add(Me.txtVarName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(511, 186)
        Me.MinimumSize = New System.Drawing.Size(511, 186)
        Me.Name = "Form7"
        Me.Text = "Set Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVarName As TextBox
    Friend WithEvents txtVarVal As TextBox
    Friend WithEvents lblEqual As Label
    Friend WithEvents lblVarName As Label
    Friend WithEvents lblVarVal As Label
    Friend WithEvents btnSubmit As Button
End Class
