<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblUsername = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.btnSearchUsername = New System.Windows.Forms.Button
        Me.lstGroups = New System.Windows.Forms.ListBox
        Me.grpUserInfo = New System.Windows.Forms.GroupBox
        Me.rbSemicolon = New System.Windows.Forms.RadioButton
        Me.rbCRLF = New System.Windows.Forms.RadioButton
        Me.btnNotepadCopy = New System.Windows.Forms.Button
        Me.lblUserStatus = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpUserInfo.SuspendLayout()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(8, 12)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(14, 32)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(156, 20)
        Me.txtUsername.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtUsername, "Enter a Username")
        '
        'btnSearchUsername
        '
        Me.btnSearchUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchUsername.Location = New System.Drawing.Point(178, 31)
        Me.btnSearchUsername.Name = "btnSearchUsername"
        Me.btnSearchUsername.Size = New System.Drawing.Size(102, 20)
        Me.btnSearchUsername.TabIndex = 2
        Me.btnSearchUsername.Text = "Search"
        Me.btnSearchUsername.UseVisualStyleBackColor = True
        '
        'lstGroups
        '
        Me.lstGroups.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstGroups.FormattingEnabled = True
        Me.lstGroups.Location = New System.Drawing.Point(12, 74)
        Me.lstGroups.Name = "lstGroups"
        Me.lstGroups.Size = New System.Drawing.Size(252, 173)
        Me.lstGroups.Sorted = True
        Me.lstGroups.TabIndex = 3
        '
        'grpUserInfo
        '
        Me.grpUserInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUserInfo.Controls.Add(Me.rbSemicolon)
        Me.grpUserInfo.Controls.Add(Me.rbCRLF)
        Me.grpUserInfo.Controls.Add(Me.btnNotepadCopy)
        Me.grpUserInfo.Controls.Add(Me.lblUserStatus)
        Me.grpUserInfo.Controls.Add(Me.lblName)
        Me.grpUserInfo.Controls.Add(Me.lstGroups)
        Me.grpUserInfo.Location = New System.Drawing.Point(16, 65)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(277, 288)
        Me.grpUserInfo.TabIndex = 4
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "User Info"
        '
        'rbSemicolon
        '
        Me.rbSemicolon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbSemicolon.AutoSize = True
        Me.rbSemicolon.Location = New System.Drawing.Point(70, 261)
        Me.rbSemicolon.Name = "rbSemicolon"
        Me.rbSemicolon.Size = New System.Drawing.Size(77, 17)
        Me.rbSemicolon.TabIndex = 8
        Me.rbSemicolon.Text = "Semi colon"
        Me.rbSemicolon.UseVisualStyleBackColor = True
        '
        'rbCRLF
        '
        Me.rbCRLF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbCRLF.AutoSize = True
        Me.rbCRLF.Checked = True
        Me.rbCRLF.Location = New System.Drawing.Point(12, 261)
        Me.rbCRLF.Name = "rbCRLF"
        Me.rbCRLF.Size = New System.Drawing.Size(52, 17)
        Me.rbCRLF.TabIndex = 7
        Me.rbCRLF.TabStop = True
        Me.rbCRLF.Text = "CRLF"
        Me.rbCRLF.UseVisualStyleBackColor = True
        '
        'btnNotepadCopy
        '
        Me.btnNotepadCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotepadCopy.Location = New System.Drawing.Point(162, 261)
        Me.btnNotepadCopy.Name = "btnNotepadCopy"
        Me.btnNotepadCopy.Size = New System.Drawing.Size(102, 21)
        Me.btnNotepadCopy.TabIndex = 6
        Me.btnNotepadCopy.Text = "Copy"
        Me.btnNotepadCopy.UseVisualStyleBackColor = True
        '
        'lblUserStatus
        '
        Me.lblUserStatus.Location = New System.Drawing.Point(9, 49)
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Size = New System.Drawing.Size(242, 18)
        Me.lblUserStatus.TabIndex = 5
        Me.lblUserStatus.Text = "User Status: Unknown"
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(9, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(255, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Location = New System.Drawing.Point(16, 356)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(277, 34)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Idle"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotifyIcon
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "User Group Membership"
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestoreToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(114, 54)
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSearchUsername
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 394)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.grpUserInfo)
        Me.Controls.Add(Me.btnSearchUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(323, 418)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Group Membership"
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchUsername As System.Windows.Forms.Button
    Friend WithEvents lstGroups As System.Windows.Forms.ListBox
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblUserStatus As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnNotepadCopy As System.Windows.Forms.Button
    Friend WithEvents rbSemicolon As System.Windows.Forms.RadioButton
    Friend WithEvents rbCRLF As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsNotifyIcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
