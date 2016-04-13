<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.grpCommands = New System.Windows.Forms.GroupBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lstCommands = New System.Windows.Forms.ListBox()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.btnStopDebug = New System.Windows.Forms.Button()
        Me.prsProgram = New System.Diagnostics.Process()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.notBuilding = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnsBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginsShopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorSchemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomBuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomCommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreSoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.savProgram = New System.Windows.Forms.SaveFileDialog()
        Me.opnFile = New System.Windows.Forms.OpenFileDialog()
        Me.rchEditor = New System.Windows.Forms.RichTextBox()
        Me.fntCode = New System.Windows.Forms.FontDialog()
        Me.pntDialog = New System.Windows.Forms.PrintDialog()
        Me.pntCode = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpCommands.SuspendLayout()
        Me.mnsBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommands
        '
        Me.grpCommands.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpCommands.Controls.Add(Me.lblLine)
        Me.grpCommands.Controls.Add(Me.lstCommands)
        Me.grpCommands.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpCommands.Location = New System.Drawing.Point(12, 32)
        Me.grpCommands.Name = "grpCommands"
        Me.grpCommands.Size = New System.Drawing.Size(170, 510)
        Me.grpCommands.TabIndex = 0
        Me.grpCommands.TabStop = False
        Me.grpCommands.Text = "Commands"
        '
        'lblLine
        '
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLine.Location = New System.Drawing.Point(2, 16)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(163, 21)
        Me.lblLine.TabIndex = 16
        Me.lblLine.Text = "--------------------------------------"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstCommands
        '
        Me.lstCommands.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstCommands.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCommands.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCommands.ForeColor = System.Drawing.SystemColors.Menu
        Me.lstCommands.FormattingEnabled = True
        Me.lstCommands.ItemHeight = 15
        Me.lstCommands.Items.AddRange(New Object() {"Disable Line Returning", "Clear Screen", "Add Title", "Display Text", "Pause", "Make Variable", "User Input", "Add Location", "Jump to Location", "If, Then", "Close", "Color", "Math", "Comment", "Delay", "Run", "Custom Command 1", "Custom Command 2", "Custom Command 3", "Custom Command 4", "Custom Command 5"})
        Me.lstCommands.Location = New System.Drawing.Point(6, 40)
        Me.lstCommands.Name = "lstCommands"
        Me.lstCommands.Size = New System.Drawing.Size(159, 450)
        Me.lstCommands.TabIndex = 15
        '
        'btnDebug
        '
        Me.btnDebug.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDebug.FlatAppearance.BorderSize = 5
        Me.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDebug.Location = New System.Drawing.Point(204, 518)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(220, 24)
        Me.btnDebug.TabIndex = 4
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'btnStopDebug
        '
        Me.btnStopDebug.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopDebug.Location = New System.Drawing.Point(464, 518)
        Me.btnStopDebug.Name = "btnStopDebug"
        Me.btnStopDebug.Size = New System.Drawing.Size(220, 24)
        Me.btnStopDebug.TabIndex = 5
        Me.btnStopDebug.Text = "Stop Debugging"
        Me.btnStopDebug.UseVisualStyleBackColor = True
        '
        'prsProgram
        '
        Me.prsProgram.StartInfo.Domain = ""
        Me.prsProgram.StartInfo.FileName = "run.bat"
        Me.prsProgram.StartInfo.LoadUserProfile = False
        Me.prsProgram.StartInfo.Password = Nothing
        Me.prsProgram.StartInfo.StandardErrorEncoding = Nothing
        Me.prsProgram.StartInfo.StandardOutputEncoding = Nothing
        Me.prsProgram.StartInfo.UserName = ""
        Me.prsProgram.SynchronizingObject = Me
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.White
        Me.txtConsole.Location = New System.Drawing.Point(17, 548)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(672, 84)
        Me.txtConsole.TabIndex = 6
        Me.txtConsole.Text = "Idle.."
        '
        'notBuilding
        '
        Me.notBuilding.Icon = CType(resources.GetObject("notBuilding.Icon"), System.Drawing.Icon)
        Me.notBuilding.Text = "Jessie Editor"
        Me.notBuilding.Visible = True
        '
        'mnsBar
        '
        Me.mnsBar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.mnsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DebugToolStripMenuItem, Me.PluginsToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.PropertiesToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnsBar.Location = New System.Drawing.Point(0, 0)
        Me.mnsBar.Name = "mnsBar"
        Me.mnsBar.Size = New System.Drawing.Size(701, 24)
        Me.mnsBar.TabIndex = 7
        Me.mnsBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem1})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem1.Text = "Print"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileToolStripMenuItem, Me.DebugToolStripMenuItem1})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'DebugToolStripMenuItem1
        '
        Me.DebugToolStripMenuItem1.Name = "DebugToolStripMenuItem1"
        Me.DebugToolStripMenuItem1.Size = New System.Drawing.Size(119, 22)
        Me.DebugToolStripMenuItem1.Text = "Debug"
        '
        'PluginsToolStripMenuItem
        '
        Me.PluginsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.OpenPluginsToolStripMenuItem, Me.PluginsShopToolStripMenuItem})
        Me.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem"
        Me.PluginsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PluginsToolStripMenuItem.Text = "Plugins"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'OpenPluginsToolStripMenuItem
        '
        Me.OpenPluginsToolStripMenuItem.Name = "OpenPluginsToolStripMenuItem"
        Me.OpenPluginsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OpenPluginsToolStripMenuItem.Text = "Open Plugins Folder"
        '
        'PluginsShopToolStripMenuItem
        '
        Me.PluginsShopToolStripMenuItem.Name = "PluginsShopToolStripMenuItem"
        Me.PluginsShopToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PluginsShopToolStripMenuItem.Text = "Plugins Shop"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.AddPointsToolStripMenuItem, Me.NewProfileToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AddPointsToolStripMenuItem
        '
        Me.AddPointsToolStripMenuItem.Name = "AddPointsToolStripMenuItem"
        Me.AddPointsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddPointsToolStripMenuItem.Text = "Add Points"
        '
        'NewProfileToolStripMenuItem
        '
        Me.NewProfileToolStripMenuItem.Name = "NewProfileToolStripMenuItem"
        Me.NewProfileToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.NewProfileToolStripMenuItem.Text = "New Profile"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorSchemeToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.CustomBuildToolStripMenuItem, Me.CustomCommandsToolStripMenuItem, Me.RestoreSoftwareToolStripMenuItem})
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorSchemeToolStripMenuItem
        '
        Me.ColorSchemeToolStripMenuItem.Name = "ColorSchemeToolStripMenuItem"
        Me.ColorSchemeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ColorSchemeToolStripMenuItem.Text = "Color Scheme"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'CustomBuildToolStripMenuItem
        '
        Me.CustomBuildToolStripMenuItem.Name = "CustomBuildToolStripMenuItem"
        Me.CustomBuildToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CustomBuildToolStripMenuItem.Text = "Custom Build"
        '
        'CustomCommandsToolStripMenuItem
        '
        Me.CustomCommandsToolStripMenuItem.Name = "CustomCommandsToolStripMenuItem"
        Me.CustomCommandsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CustomCommandsToolStripMenuItem.Text = "Custom Commands"
        '
        'RestoreSoftwareToolStripMenuItem
        '
        Me.RestoreSoftwareToolStripMenuItem.Name = "RestoreSoftwareToolStripMenuItem"
        Me.RestoreSoftwareToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RestoreSoftwareToolStripMenuItem.Text = "Restore Software"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(176, 579)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(62, 40)
        Me.TreeView1.TabIndex = 8
        '
        'savProgram
        '
        Me.savProgram.CheckPathExists = False
        Me.savProgram.DefaultExt = "bat"
        Me.savProgram.ValidateNames = False
        '
        'opnFile
        '
        Me.opnFile.DefaultExt = "bat"
        Me.opnFile.FileName = "OpenFileDialog1"
        '
        'rchEditor
        '
        Me.rchEditor.AcceptsTab = True
        Me.rchEditor.BackColor = System.Drawing.SystemColors.GrayText
        Me.rchEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rchEditor.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchEditor.ForeColor = System.Drawing.SystemColors.Info
        Me.rchEditor.Location = New System.Drawing.Point(203, 32)
        Me.rchEditor.Name = "rchEditor"
        Me.rchEditor.Size = New System.Drawing.Size(486, 480)
        Me.rchEditor.TabIndex = 9
        Me.rchEditor.Text = "::Made with Jessie Editor"
        Me.rchEditor.WordWrap = False
        '
        'pntDialog
        '
        Me.pntDialog.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(701, 657)
        Me.Controls.Add(Me.rchEditor)
        Me.Controls.Add(Me.txtConsole)
        Me.Controls.Add(Me.btnStopDebug)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.grpCommands)
        Me.Controls.Add(Me.mnsBar)
        Me.Controls.Add(Me.TreeView1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsBar
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(717, 696)
        Me.MinimumSize = New System.Drawing.Size(717, 696)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jessie Editor"
        Me.grpCommands.ResumeLayout(False)
        Me.mnsBar.ResumeLayout(False)
        Me.mnsBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCommands As GroupBox
    Friend WithEvents btnDebug As Button
    Friend WithEvents btnStopDebug As Button
    Friend WithEvents prsProgram As Process
    Friend WithEvents txtConsole As TextBox
    Friend WithEvents notBuilding As NotifyIcon
    Friend WithEvents mnsBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PluginsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents lstCommands As ListBox
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents savProgram As SaveFileDialog
    Friend WithEvents opnFile As OpenFileDialog
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPluginsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPointsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rchEditor As RichTextBox
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorSchemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLine As Label
    Friend WithEvents fntCode As FontDialog
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pntDialog As PrintDialog
    Friend WithEvents pntCode As Printing.PrintDocument
    Friend WithEvents PluginsShopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomBuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomCommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreSoftwareToolStripMenuItem As ToolStripMenuItem
End Class
