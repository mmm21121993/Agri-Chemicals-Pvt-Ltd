<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageUser))
        Me.tlpUserDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cblType = New System.Windows.Forms.CheckedListBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cblStatus = New System.Windows.Forms.CheckedListBox()
        Me.cblGender = New System.Windows.Forms.CheckedListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lsvEmployee = New System.Windows.Forms.ListView()
        Me.cmsEmployee = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuApprove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpUserDetails.SuspendLayout()
        Me.cmsEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpUserDetails
        '
        Me.tlpUserDetails.ColumnCount = 3
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserDetails.Controls.Add(Me.lblType, 0, 9)
        Me.tlpUserDetails.Controls.Add(Me.cblType, 0, 11)
        Me.tlpUserDetails.Controls.Add(Me.lblStatus, 0, 13)
        Me.tlpUserDetails.Controls.Add(Me.cblStatus, 0, 15)
        Me.tlpUserDetails.Controls.Add(Me.cblGender, 0, 7)
        Me.tlpUserDetails.Controls.Add(Me.txtName, 0, 3)
        Me.tlpUserDetails.Controls.Add(Me.lblName, 0, 1)
        Me.tlpUserDetails.Controls.Add(Me.lblGender, 0, 5)
        Me.tlpUserDetails.Controls.Add(Me.btnSearch, 0, 17)
        Me.tlpUserDetails.Controls.Add(Me.btnClear, 1, 17)
        Me.tlpUserDetails.Controls.Add(Me.lsvEmployee, 2, 1)
        Me.tlpUserDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserDetails.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserDetails.Name = "tlpUserDetails"
        Me.tlpUserDetails.RowCount = 18
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserDetails.Size = New System.Drawing.Size(934, 582)
        Me.tlpUserDetails.TabIndex = 0
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserDetails.SetColumnSpan(Me.lblType, 2)
        Me.lblType.Location = New System.Drawing.Point(13, 186)
        Me.lblType.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(257, 14)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Account Type:"
        '
        'cblType
        '
        Me.cblType.BackColor = System.Drawing.Color.FloralWhite
        Me.cblType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpUserDetails.SetColumnSpan(Me.cblType, 2)
        Me.cblType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblType.FormattingEnabled = True
        Me.cblType.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cblType.Location = New System.Drawing.Point(13, 211)
        Me.cblType.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblType.Name = "cblType"
        Me.cblType.Size = New System.Drawing.Size(257, 60)
        Me.cblType.TabIndex = 5
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserDetails.SetColumnSpan(Me.lblStatus, 2)
        Me.lblStatus.Location = New System.Drawing.Point(13, 286)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(257, 14)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Account Status:"
        '
        'cblStatus
        '
        Me.cblStatus.BackColor = System.Drawing.Color.FloralWhite
        Me.cblStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpUserDetails.SetColumnSpan(Me.cblStatus, 2)
        Me.cblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblStatus.FormattingEnabled = True
        Me.cblStatus.Items.AddRange(New Object() {"Approved", "Pending", "Rejected"})
        Me.cblStatus.Location = New System.Drawing.Point(13, 311)
        Me.cblStatus.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblStatus.Name = "cblStatus"
        Me.cblStatus.Size = New System.Drawing.Size(257, 60)
        Me.cblStatus.TabIndex = 7
        '
        'cblGender
        '
        Me.cblGender.BackColor = System.Drawing.Color.FloralWhite
        Me.cblGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpUserDetails.SetColumnSpan(Me.cblGender, 2)
        Me.cblGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblGender.FormattingEnabled = True
        Me.cblGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cblGender.Location = New System.Drawing.Point(13, 111)
        Me.cblGender.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblGender.Name = "cblGender"
        Me.cblGender.Size = New System.Drawing.Size(257, 60)
        Me.cblGender.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Location = New System.Drawing.Point(13, 46)
        Me.txtName.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 22)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserDetails.SetColumnSpan(Me.lblName, 2)
        Me.lblName.Location = New System.Drawing.Point(13, 19)
        Me.lblName.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(257, 14)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Employee Name:"
        '
        'lblGender
        '
        Me.lblGender.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserDetails.SetColumnSpan(Me.lblGender, 2)
        Me.lblGender.Location = New System.Drawing.Point(13, 86)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(257, 14)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Employee's Gender:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(17, 465)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 31)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(152, 465)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 31)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lsvEmployee
        '
        Me.lsvEmployee.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lsvEmployee.BackColor = System.Drawing.Color.White
        Me.lsvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvEmployee.ContextMenuStrip = Me.cmsEmployee
        Me.lsvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvEmployee.FullRowSelect = True
        Me.lsvEmployee.Location = New System.Drawing.Point(295, 26)
        Me.lsvEmployee.Margin = New System.Windows.Forms.Padding(25, 13, 0, 0)
        Me.lsvEmployee.MultiSelect = False
        Me.lsvEmployee.Name = "lsvEmployee"
        Me.tlpUserDetails.SetRowSpan(Me.lsvEmployee, 17)
        Me.lsvEmployee.ShowItemToolTips = True
        Me.lsvEmployee.Size = New System.Drawing.Size(639, 556)
        Me.lsvEmployee.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvEmployee.TabIndex = 10
        Me.lsvEmployee.TileSize = New System.Drawing.Size(350, 130)
        Me.lsvEmployee.UseCompatibleStateImageBehavior = False
        Me.lsvEmployee.View = System.Windows.Forms.View.Tile
        '
        'cmsEmployee
        '
        Me.cmsEmployee.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsEmployee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStatus, Me.mnuDelete})
        Me.cmsEmployee.Name = "cmsEmployee"
        Me.cmsEmployee.Size = New System.Drawing.Size(169, 48)
        '
        'mnuStatus
        '
        Me.mnuStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuApprove, Me.mnuReject})
        Me.mnuStatus.Name = "mnuStatus"
        Me.mnuStatus.Size = New System.Drawing.Size(200, 22)
        Me.mnuStatus.Text = "Account Status"
        '
        'mnuApprove
        '
        Me.mnuApprove.Name = "mnuApprove"
        Me.mnuApprove.Size = New System.Drawing.Size(134, 22)
        Me.mnuApprove.Text = "Approved"
        '
        'mnuReject
        '
        Me.mnuReject.Name = "mnuReject"
        Me.mnuReject.Size = New System.Drawing.Size(134, 22)
        Me.mnuReject.Text = "Rejected"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(200, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'frmManageUser
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.tlpUserDetails)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmManageUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Employee Details"
        Me.tlpUserDetails.ResumeLayout(False)
        Me.tlpUserDetails.PerformLayout()
        Me.cmsEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpUserDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cblGender As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cblType As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cblStatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lsvEmployee As System.Windows.Forms.ListView
    Friend WithEvents cmsEmployee As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuApprove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReject As System.Windows.Forms.ToolStripMenuItem
End Class
