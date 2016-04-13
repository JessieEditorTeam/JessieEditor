<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPointsAdd = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(102, 44)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(176, 20)
        Me.txtPoints.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(4, 108)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(275, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(1, 9)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(76, 13)
        Me.lblPoints.TabIndex = 3
        Me.lblPoints.Text = "Current Points:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(102, 82)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(176, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPointsAdd
        '
        Me.lblPointsAdd.AutoSize = True
        Me.lblPointsAdd.Location = New System.Drawing.Point(1, 44)
        Me.lblPointsAdd.Name = "lblPointsAdd"
        Me.lblPointsAdd.Size = New System.Drawing.Size(73, 13)
        Me.lblPointsAdd.TabIndex = 5
        Me.lblPointsAdd.Text = "Points to Add:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(1, 82)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(99, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Teacher Password:"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 137)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblPointsAdd)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPoints)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 176)
        Me.MinimumSize = New System.Drawing.Size(300, 176)
        Me.Name = "Form10"
        Me.Text = "Points"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPointsAdd As Label
    Friend WithEvents lblPassword As Label
End Class
