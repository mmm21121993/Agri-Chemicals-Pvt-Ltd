<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEPanel))
        Me.mnuEmployee = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNOPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEOPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuESupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVOPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssAccount = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsEmployee = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuEmployee.SuspendLayout()
        Me.stsEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuEmployee
        '
        Me.mnuEmployee.AutoSize = False
        Me.mnuEmployee.BackColor = System.Drawing.Color.Bisque
        Me.mnuEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuNew, Me.mnuEdit, Me.mnuView, Me.mnuAccount})
        Me.mnuEmployee.Location = New System.Drawing.Point(0, 0)
        Me.mnuEmployee.Name = "mnuEmployee"
        Me.mnuEmployee.Size = New System.Drawing.Size(1044, 31)
        Me.mnuEmployee.TabIndex = 1
        '
        'mnuHome
        '
        Me.mnuHome.AutoToolTip = True
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(57, 27)
        Me.mnuHome.Text = "Home"
        '
        'mnuNew
        '
        Me.mnuNew.AutoToolTip = True
        Me.mnuNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNOPO, Me.mnuNSupplier})
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(47, 27)
        Me.mnuNew.Text = "New"
        '
        'mnuNOPO
        '
        Me.mnuNOPO.AutoToolTip = True
        Me.mnuNOPO.Name = "mnuNOPO"
        Me.mnuNOPO.Size = New System.Drawing.Size(170, 22)
        Me.mnuNOPO.Text = "Purchase Order"
        '
        'mnuNSupplier
        '
        Me.mnuNSupplier.AutoToolTip = True
        Me.mnuNSupplier.Name = "mnuNSupplier"
        Me.mnuNSupplier.Size = New System.Drawing.Size(170, 22)
        Me.mnuNSupplier.Text = "Supplier Details"
        '
        'mnuEdit
        '
        Me.mnuEdit.AutoToolTip = True
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEOPO, Me.mnuESupplier})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(43, 27)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEOPO
        '
        Me.mnuEOPO.AutoToolTip = True
        Me.mnuEOPO.Name = "mnuEOPO"
        Me.mnuEOPO.Size = New System.Drawing.Size(170, 22)
        Me.mnuEOPO.Text = "Purchase Order"
        '
        'mnuESupplier
        '
        Me.mnuESupplier.AutoToolTip = True
        Me.mnuESupplier.Name = "mnuESupplier"
        Me.mnuESupplier.Size = New System.Drawing.Size(170, 22)
        Me.mnuESupplier.Text = "Supplier Details"
        '
        'mnuView
        '
        Me.mnuView.AutoToolTip = True
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVOPO, Me.mnuVSupplier})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(48, 27)
        Me.mnuView.Text = "View"
        '
        'mnuVOPO
        '
        Me.mnuVOPO.AutoToolTip = True
        Me.mnuVOPO.Name = "mnuVOPO"
        Me.mnuVOPO.Size = New System.Drawing.Size(170, 22)
        Me.mnuVOPO.Text = "Purchase Order"
        '
        'mnuVSupplier
        '
        Me.mnuVSupplier.AutoToolTip = True
        Me.mnuVSupplier.Name = "mnuVSupplier"
        Me.mnuVSupplier.Size = New System.Drawing.Size(170, 22)
        Me.mnuVSupplier.Text = "Supplier Details"
        '
        'mnuAccount
        '
        Me.mnuAccount.AutoToolTip = True
        Me.mnuAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuPassword, Me.tssAccount, Me.mnuLogout})
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
        'tssAccount
        '
        Me.tssAccount.Name = "tssAccount"
        Me.tssAccount.Size = New System.Drawing.Size(181, 6)
        '
        'mnuLogout
        '
        Me.mnuLogout.AutoToolTip = True
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(184, 22)
        Me.mnuLogout.Text = "Logout"
        '
        'stsEmployee
        '
        Me.stsEmployee.AutoSize = False
        Me.stsEmployee.BackColor = System.Drawing.Color.Bisque
        Me.stsEmployee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.stsEmployee.Location = New System.Drawing.Point(0, 657)
        Me.stsEmployee.Name = "stsEmployee"
        Me.stsEmployee.Size = New System.Drawing.Size(1044, 25)
        Me.stsEmployee.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(89, 20)
        Me.lblStatus.Text = "Welcome, "
        '
        'frmEPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1044, 682)
        Me.Controls.Add(Me.stsEmployee)
        Me.Controls.Add(Me.mnuEmployee)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuEmployee
        Me.MinimumSize = New System.Drawing.Size(1060, 720)
        Me.Name = "frmEPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agri Chemicals Limited Information System"
        Me.mnuEmployee.ResumeLayout(False)
        Me.mnuEmployee.PerformLayout()
        Me.stsEmployee.ResumeLayout(False)
        Me.stsEmployee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuEmployee As System.Windows.Forms.MenuStrip
    Friend WithEvents stsEmployee As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssAccount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNOPO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEOPO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuESupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVOPO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVSupplier As System.Windows.Forms.ToolStripMenuItem
End Class
