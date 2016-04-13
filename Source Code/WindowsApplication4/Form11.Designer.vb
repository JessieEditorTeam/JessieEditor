<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(11, 18)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(437, 50)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Jessie Editor"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(17, 108)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "Student First Name"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(119, 108)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(241, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(119, 150)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(241, 20)
        Me.txtLast.TabIndex = 4
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(17, 195)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(96, 13)
        Me.lblPassord.TabIndex = 3
        Me.lblPassord.Text = "Teacher Password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(119, 192)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(241, 20)
        Me.txtPass.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(17, 153)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(98, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Student Last Name"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(12, 266)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(436, 52)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(464, 345)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 383)
        Me.MinimumSize = New System.Drawing.Size(480, 383)
        Me.Name = "Form11"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblPassord As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnSubmit As Button
End Class
