<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAHome
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAHome))
        Me.tlpAdmin = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPending = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRequest = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblNoRequest = New System.Windows.Forms.Label()
        Me.lblNoEmployee = New System.Windows.Forms.Label()
        Me.tlpAdmin.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpAdmin
        '
        Me.tlpAdmin.ColumnCount = 4
        Me.tlpAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpAdmin.Controls.Add(Me.dgvEmployee, 0, 6)
        Me.tlpAdmin.Controls.Add(Me.dgvRequest, 0, 2)
        Me.tlpAdmin.Controls.Add(Me.Label1, 0, 4)
        Me.tlpAdmin.Controls.Add(Me.lblRequest, 0, 0)
        Me.tlpAdmin.Controls.Add(Me.lblStatus, 2, 0)
        Me.tlpAdmin.Controls.Add(Me.cmbStatus, 3, 0)
        Me.tlpAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAdmin.Location = New System.Drawing.Point(9, 9)
        Me.tlpAdmin.Name = "tlpAdmin"
        Me.tlpAdmin.RowCount = 7
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAdmin.Size = New System.Drawing.Size(916, 564)
        Me.tlpAdmin.TabIndex = 0
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.AllowUserToResizeColumns = False
        Me.dgvEmployee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmployee.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colRequest, Me.colPending, Me.colAccept, Me.colReject})
        Me.tlpAdmin.SetColumnSpan(Me.dgvEmployee, 4)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployee.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployee.Location = New System.Drawing.Point(3, 325)
        Me.dgvEmployee.MultiSelect = False
        Me.dgvEmployee.Name = "dgvEmployee"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmployee.RowHeadersWidth = 54
        Me.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvEmployee.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployee.Size = New System.Drawing.Size(910, 236)
        Me.dgvEmployee.TabIndex = 6
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 75
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.DataPropertyName = "Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colName.HeaderText = "Requester Name"
        Me.colName.Name = "colName"
        '
        'colRequest
        '
        Me.colRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colRequest.DataPropertyName = "Request"
        Me.colRequest.HeaderText = "Requests Made"
        Me.colRequest.Name = "colRequest"
        Me.colRequest.Width = 125
        '
        'colPending
        '
        Me.colPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPending.DataPropertyName = "Pending"
        Me.colPending.HeaderText = "Pending"
        Me.colPending.Name = "colPending"
        Me.colPending.Width = 125
        '
        'colAccept
        '
        Me.colAccept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colAccept.DataPropertyName = "Accept"
        Me.colAccept.HeaderText = "Accepted"
        Me.colAccept.Name = "colAccept"
        Me.colAccept.Width = 125
        '
        'colReject
        '
        Me.colReject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colReject.DataPropertyName = "Reject"
        Me.colReject.HeaderText = "Rejected"
        Me.colReject.Name = "colReject"
        Me.colReject.Width = 125
        '
        'dgvRequest
        '
        Me.dgvRequest.AllowUserToAddRows = False
        Me.dgvRequest.AllowUserToDeleteRows = False
        Me.dgvRequest.AllowUserToResizeColumns = False
        Me.dgvRequest.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRequest.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRequest.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpAdmin.SetColumnSpan(Me.dgvRequest, 4)
        Me.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequest.Location = New System.Drawing.Point(3, 39)
        Me.dgvRequest.MultiSelect = False
        Me.dgvRequest.Name = "dgvRequest"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequest.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRequest.RowHeadersWidth = 54
        Me.dgvRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvRequest.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequest.Size = New System.Drawing.Size(910, 235)
        Me.dgvRequest.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpAdmin.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. of OPO Deletion Request submiteed by employees :"
        '
        'lblRequest
        '
        Me.lblRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpAdmin.SetColumnSpan(Me.lblRequest, 2)
        Me.lblRequest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequest.Location = New System.Drawing.Point(3, 5)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(452, 17)
        Me.lblRequest.TabIndex = 1
        Me.lblRequest.Text = "OPO Deleteion Requests Submitted by the employee :"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(567, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(117, 14)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Request Status : "
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.BackColor = System.Drawing.Color.Ivory
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Any", "Accepted", "Pending", "Rejected"})
        Me.cmbStatus.Location = New System.Drawing.Point(700, 3)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(213, 22)
        Me.cmbStatus.TabIndex = 3
        '
        'lblNoRequest
        '
        Me.lblNoRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoRequest.AutoSize = True
        Me.lblNoRequest.BackColor = System.Drawing.Color.Transparent
        Me.lblNoRequest.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRequest.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoRequest.Location = New System.Drawing.Point(195, 130)
        Me.lblNoRequest.Name = "lblNoRequest"
        Me.lblNoRequest.Size = New System.Drawing.Size(545, 59)
        Me.lblNoRequest.TabIndex = 2
        Me.lblNoRequest.Text = "No Requests Found"
        Me.lblNoRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoEmployee
        '
        Me.lblNoEmployee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoEmployee.AutoSize = True
        Me.lblNoEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lblNoEmployee.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEmployee.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoEmployee.Location = New System.Drawing.Point(151, 435)
        Me.lblNoEmployee.Name = "lblNoEmployee"
        Me.lblNoEmployee.Size = New System.Drawing.Size(632, 59)
        Me.lblNoEmployee.TabIndex = 3
        Me.lblNoEmployee.Text = "No Requests are made"
        Me.lblNoEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.lblNoEmployee)
        Me.Controls.Add(Me.lblNoRequest)
        Me.Controls.Add(Me.tlpAdmin)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmAHome"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Home Panel"
        Me.tlpAdmin.ResumeLayout(False)
        Me.tlpAdmin.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpAdmin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvRequest As System.Windows.Forms.DataGridView
    Friend WithEvents dgvEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoRequest As System.Windows.Forms.Label
    Friend WithEvents lblNoEmployee As System.Windows.Forms.Label
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRequest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPending As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccept As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReject As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
