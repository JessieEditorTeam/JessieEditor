<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.trvPlugins = New System.Windows.Forms.TreeView()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(540, 32)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(134, 35)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'trvPlugins
        '
        Me.trvPlugins.Location = New System.Drawing.Point(10, 32)
        Me.trvPlugins.Name = "trvPlugins"
        Me.trvPlugins.Size = New System.Drawing.Size(495, 412)
        Me.trvPlugins.TabIndex = 3
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(540, 87)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(134, 35)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 485)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.trvPlugins)
        Me.Controls.Add(Me.btnRemove)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(702, 524)
        Me.MinimumSize = New System.Drawing.Size(702, 524)
        Me.Name = "Form8"
        Me.Text = "Plugin Manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRemove As Button
    Friend WithEvents trvPlugins As TreeView
    Friend WithEvents btnRun As Button
    Friend WithEvents Process1 As Process
End Class
