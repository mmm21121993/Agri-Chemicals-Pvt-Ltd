<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAPanel))
        Me.mnuAdmin = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManageEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspEmployee = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.tspAccount = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsAdmin = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuAdmin.SuspendLayout()
        Me.stsAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuAdmin
        '
        Me.mnuAdmin.AutoSize = False
        Me.mnuAdmin.BackColor = System.Drawing.Color.Bisque
        Me.mnuAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuEmployee, Me.mnuSystem, Me.mnuAccount})
        Me.mnuAdmin.Location = New System.Drawing.Point(0, 0)
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(1044, 31)
        Me.mnuAdmin.TabIndex = 1
        '
        'mnuHome
        '
        Me.mnuHome.AutoToolTip = True
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(57, 27)
        Me.mnuHome.Text = "Home"
        '
        'mnuEmployee
        '
        Me.mnuEmployee.AutoToolTip = True
        Me.mnuEmployee.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewEmployee, Me.mnuManageEmployee, Me.tspEmployee, Me.mnuViewEmployee})
        Me.mnuEmployee.Name = "mnuEmployee"
        Me.mnuEmployee.Size = New System.Drawing.Size(164, 27)
        Me.mnuEmployee.Text = "Employee Management"
        '
        'mnuNewEmployee
        '
        Me.mnuNewEmployee.AutoToolTip = True
        Me.mnuNewEmployee.Name = "mnuNewEmployee"
        Me.mnuNewEmployee.Size = New System.Drawing.Size(243, 22)
        Me.mnuNewEmployee.Text = "New Employee Registration"
        '
        'mnuManageEmployee
        '
        Me.mnuManageEmployee.AutoToolTip = True
        Me.mnuManageEmployee.Name = "mnuManageEmployee"
        Me.mnuManageEmployee.Size = New System.Drawing.Size(243, 22)
        Me.mnuManageEmployee.Text = "Manage Employee Details"
        '
        'tspEmployee
        '
        Me.tspEmployee.Name = "tspEmployee"
        Me.tspEmployee.Size = New System.Drawing.Size(240, 6)
        '
        'mnuViewEmployee
        '
        Me.mnuViewEmployee.AutoToolTip = True
        Me.mnuViewEmployee.Name = "mnuViewEmployee"
        Me.mnuViewEmployee.Size = New System.Drawing.Size(243, 22)
        Me.mnuViewEmployee.Text = "View Employee Activities"
        '
        'mnuSystem
        '
        Me.mnuSystem.AutoToolTip = True
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBackup, Me.mnuRestore})
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(111, 27)
        Me.mnuSystem.Text = "System Setting"
        '
        'mnuBackup
        '
        Me.mnuBackup.AutoToolTip = True
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(230, 22)
        Me.mnuBackup.Text = "Backup System Database"
        '
        'mnuRestore
        '
        Me.mnuRestore.AutoToolTip = True
        Me.mnuRestore.Name = "mnuRestore"
        Me.mnuRestore.Size = New System.Drawing.Size(230, 22)
        Me.mnuRestore.Text = "Restore System Database"
        '
        'mnuAccount
        '
        Me.mnuAccount.AutoToolTip = True
        Me.mnuAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuPassword, Me.tspAccount, Me.mnuLogout})
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.Size = New System.Drawing.Size(117, 27)
        Me.mnuAccount.Text = "Account Setting"
        '
        'mnuProfile
        '
        Me.mnuProfile.AutoToolTip = True
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(184, 22)
        Me.mnuProfile.Text = "Edit Profile"
        '
        'mnuPassword
        '
        Me.mnuPassword.AutoToolTip = True
        Me.mnuPassword.Name = "mnuPassword"
        Me.mnuPassword.Size = New System.Drawing.Size(184, 22)
        Me.mnuPassword.Text = "Change Password"
        '
        'tspAccount
        '
        Me.tspAccount.Name = "tspAccount"
        Me.tspAccount.Size = New System.Drawing.Size(181, 6)
        '
        'mnuLogout
        '
        Me.mnuLogout.AutoToolTip = True
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(184, 22)
        Me.mnuLogout.Text = "Logout"
        '
        'stsAdmin
        '
        Me.stsAdmin.AutoSize = False
        Me.stsAdmin.BackColor = System.Drawing.Color.Bisque
        Me.stsAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.stsAdmin.Location = New System.Drawing.Point(0, 657)
        Me.stsAdmin.Name = "stsAdmin"
        Me.stsAdmin.Size = New System.Drawing.Size(1044, 25)
        Me.stsAdmin.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(89, 20)
        Me.lblStatus.Text = "Welcome, "
        '
        'frmAPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1044, 682)
        Me.Controls.Add(Me.stsAdmin)
        Me.Controls.Add(Me.mnuAdmin)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuAdmin
        Me.MinimumSize = New System.Drawing.Size(1060, 720)
        Me.Name = "frmAPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agri Chemicals Limited Information System"
        Me.mnuAdmin.ResumeLayout(False)
        Me.mnuAdmin.PerformLayout()
        Me.stsAdmin.ResumeLayout(False)
        Me.stsAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuAdmin As System.Windows.Forms.MenuStrip
    Friend WithEvents stsAdmin As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuManageEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspEmployee As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuViewEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspAccount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestore As System.Windows.Forms.ToolStripMenuItem
End Class
