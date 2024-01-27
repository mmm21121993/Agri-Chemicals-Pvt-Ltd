<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEHome
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEHome))
        Me.tlpUser = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.dgvRequest = New System.Windows.Forms.DataGridView()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.lblNoRequest = New System.Windows.Forms.Label()
        Me.lblNoRecent = New System.Windows.Forms.Label()
        Me.tlpUser.SuspendLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpUser
        '
        Me.tlpUser.BackColor = System.Drawing.Color.Transparent
        Me.tlpUser.ColumnCount = 4
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUser.Controls.Add(Me.dgvRecent, 0, 6)
        Me.tlpUser.Controls.Add(Me.lblRequest, 0, 0)
        Me.tlpUser.Controls.Add(Me.dgvRequest, 0, 2)
        Me.tlpUser.Controls.Add(Me.lblStatus, 2, 0)
        Me.tlpUser.Controls.Add(Me.cmbStatus, 3, 0)
        Me.tlpUser.Controls.Add(Me.lblRecent, 0, 4)
        Me.tlpUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUser.Location = New System.Drawing.Point(9, 9)
        Me.tlpUser.Name = "tlpUser"
        Me.tlpUser.RowCount = 8
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUser.Size = New System.Drawing.Size(916, 564)
        Me.tlpUser.TabIndex = 0
        '
        'dgvRecent
        '
        Me.dgvRecent.AllowUserToAddRows = False
        Me.dgvRecent.AllowUserToDeleteRows = False
        Me.dgvRecent.AllowUserToResizeColumns = False
        Me.dgvRecent.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRecent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRecent.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpUser.SetColumnSpan(Me.dgvRecent, 4)
        Me.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecent.Location = New System.Drawing.Point(3, 321)
        Me.dgvRecent.MultiSelect = False
        Me.dgvRecent.Name = "dgvRecent"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecent.RowHeadersWidth = 54
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvRecent.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecent.Size = New System.Drawing.Size(910, 236)
        Me.dgvRecent.TabIndex = 2
        '
        'lblRequest
        '
        Me.lblRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequest.AutoSize = True
        Me.tlpUser.SetColumnSpan(Me.lblRequest, 2)
        Me.lblRequest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequest.Location = New System.Drawing.Point(3, 5)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(452, 16)
        Me.lblRequest.TabIndex = 0
        Me.lblRequest.Text = "Status of OPO Deletion Requests made by you :"
        '
        'dgvRequest
        '
        Me.dgvRequest.AllowUserToAddRows = False
        Me.dgvRequest.AllowUserToDeleteRows = False
        Me.dgvRequest.AllowUserToResizeColumns = False
        Me.dgvRequest.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRequest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRequest.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpUser.SetColumnSpan(Me.dgvRequest, 4)
        Me.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequest.Location = New System.Drawing.Point(3, 34)
        Me.dgvRequest.MultiSelect = False
        Me.dgvRequest.Name = "dgvRequest"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequest.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRequest.RowHeadersWidth = 54
        Me.dgvRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvRequest.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequest.Size = New System.Drawing.Size(910, 236)
        Me.dgvRequest.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(567, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(117, 14)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Request Status : "
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.BackColor = System.Drawing.Color.Ivory
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Any", "Accepted", "Pending", "Rejected"})
        Me.cmbStatus.Location = New System.Drawing.Point(690, 3)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(223, 22)
        Me.cmbStatus.TabIndex = 3
        '
        'lblRecent
        '
        Me.lblRecent.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecent.AutoSize = True
        Me.lblRecent.BackColor = System.Drawing.Color.White
        Me.tlpUser.SetColumnSpan(Me.lblRecent, 3)
        Me.lblRecent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.Location = New System.Drawing.Point(3, 287)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(681, 16)
        Me.lblRecent.TabIndex = 0
        Me.lblRecent.Text = "Recent Activities performed in the system after last time you logged out :"
        '
        'lblNoRequest
        '
        Me.lblNoRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoRequest.AutoSize = True
        Me.lblNoRequest.BackColor = System.Drawing.Color.Transparent
        Me.lblNoRequest.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRequest.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoRequest.Location = New System.Drawing.Point(195, 100)
        Me.lblNoRequest.Name = "lblNoRequest"
        Me.lblNoRequest.Size = New System.Drawing.Size(545, 59)
        Me.lblNoRequest.TabIndex = 1
        Me.lblNoRequest.Text = "No Requests Found"
        Me.lblNoRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoRecent
        '
        Me.lblNoRecent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoRecent.AutoSize = True
        Me.lblNoRecent.BackColor = System.Drawing.Color.Transparent
        Me.lblNoRecent.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRecent.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoRecent.Location = New System.Drawing.Point(185, 410)
        Me.lblNoRecent.Name = "lblNoRecent"
        Me.lblNoRecent.Size = New System.Drawing.Size(565, 59)
        Me.lblNoRecent.TabIndex = 2
        Me.lblNoRecent.Text = "No Recent Activities"
        Me.lblNoRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.lblNoRecent)
        Me.Controls.Add(Me.lblNoRequest)
        Me.Controls.Add(Me.tlpUser)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmEHome"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Home Panel"
        Me.tlpUser.ResumeLayout(False)
        Me.tlpUser.PerformLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpUser As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents dgvRequest As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblNoRequest As System.Windows.Forms.Label
    Friend WithEvents lblRecent As System.Windows.Forms.Label
    Friend WithEvents dgvRecent As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoRecent As System.Windows.Forms.Label
End Class
