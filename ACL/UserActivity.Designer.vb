<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserActivity
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserActivity))
        Me.tlpUser = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvRecent = New System.Windows.Forms.DataGridView()
        Me.dgvCount = New System.Windows.Forms.DataGridView()
        Me.colCOPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEOPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colESupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lsvEmployee = New System.Windows.Forms.ListView()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.lblNoActivity = New System.Windows.Forms.Label()
        Me.tlpUser.SuspendLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpUser
        '
        Me.tlpUser.ColumnCount = 4
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUser.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUser.Controls.Add(Me.dgvRecent, 2, 5)
        Me.tlpUser.Controls.Add(Me.dgvCount, 2, 1)
        Me.tlpUser.Controls.Add(Me.lsvEmployee, 0, 0)
        Me.tlpUser.Controls.Add(Me.lblActivity, 2, 3)
        Me.tlpUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUser.Location = New System.Drawing.Point(0, 0)
        Me.tlpUser.Name = "tlpUser"
        Me.tlpUser.RowCount = 7
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUser.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUser.Size = New System.Drawing.Size(934, 582)
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
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecent.Location = New System.Drawing.Point(233, 127)
        Me.dgvRecent.MultiSelect = False
        Me.dgvRecent.Name = "dgvRecent"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecent.RowHeadersWidth = 54
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRecent.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.dgvRecent.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecent.Size = New System.Drawing.Size(688, 442)
        Me.dgvRecent.TabIndex = 9
        Me.dgvRecent.Visible = False
        '
        'dgvCount
        '
        Me.dgvCount.AllowUserToAddRows = False
        Me.dgvCount.AllowUserToDeleteRows = False
        Me.dgvCount.AllowUserToResizeColumns = False
        Me.dgvCount.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCount.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCount.BackgroundColor = System.Drawing.Color.White
        Me.dgvCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCOPO, Me.colEOPO, Me.colCSupplier, Me.colESupplier, Me.colRequest})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCount.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCount.Location = New System.Drawing.Point(233, 12)
        Me.dgvCount.MultiSelect = False
        Me.dgvCount.Name = "dgvCount"
        Me.dgvCount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(4)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCount.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCount.RowHeadersVisible = False
        Me.dgvCount.RowHeadersWidth = 54
        Me.dgvCount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvCount.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCount.Size = New System.Drawing.Size(688, 74)
        Me.dgvCount.TabIndex = 7
        Me.dgvCount.Visible = False
        '
        'colCOPO
        '
        Me.colCOPO.DataPropertyName = "COPO"
        Me.colCOPO.HeaderText = "No. of OPO Created"
        Me.colCOPO.Name = "colCOPO"
        '
        'colEOPO
        '
        Me.colEOPO.DataPropertyName = "EOPO"
        Me.colEOPO.HeaderText = "No. of OPO Edited"
        Me.colEOPO.Name = "colEOPO"
        '
        'colCSupplier
        '
        Me.colCSupplier.DataPropertyName = "CSupplier"
        Me.colCSupplier.HeaderText = "No. of Supplier Created"
        Me.colCSupplier.Name = "colCSupplier"
        '
        'colESupplier
        '
        Me.colESupplier.DataPropertyName = "ESupplier"
        Me.colESupplier.HeaderText = "No. of Supplier Edited"
        Me.colESupplier.Name = "colESupplier"
        '
        'colRequest
        '
        Me.colRequest.DataPropertyName = "Request"
        Me.colRequest.HeaderText = "OPO Deletion Requests"
        Me.colRequest.Name = "colRequest"
        '
        'lsvEmployee
        '
        Me.lsvEmployee.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lsvEmployee.BackColor = System.Drawing.Color.Ivory
        Me.lsvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvEmployee.Location = New System.Drawing.Point(3, 3)
        Me.lsvEmployee.MultiSelect = False
        Me.lsvEmployee.Name = "lsvEmployee"
        Me.tlpUser.SetRowSpan(Me.lsvEmployee, 7)
        Me.lsvEmployee.Size = New System.Drawing.Size(214, 576)
        Me.lsvEmployee.TabIndex = 0
        Me.lsvEmployee.UseCompatibleStateImageBehavior = False
        '
        'lblActivity
        '
        Me.lblActivity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Location = New System.Drawing.Point(233, 99)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(285, 14)
        Me.lblActivity.TabIndex = 8
        Me.lblActivity.Text = "Activities Performed by selected Employee : "
        Me.lblActivity.Visible = False
        '
        'lblNoActivity
        '
        Me.lblNoActivity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoActivity.AutoSize = True
        Me.lblNoActivity.BackColor = System.Drawing.Color.Transparent
        Me.lblNoActivity.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoActivity.ForeColor = System.Drawing.Color.LightGray
        Me.lblNoActivity.Location = New System.Drawing.Point(305, 290)
        Me.lblNoActivity.Name = "lblNoActivity"
        Me.lblNoActivity.Size = New System.Drawing.Size(565, 59)
        Me.lblNoActivity.TabIndex = 3
        Me.lblNoActivity.Text = "No Recent Activities"
        Me.lblNoActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoActivity.Visible = False
        '
        'frmUserActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.lblNoActivity)
        Me.Controls.Add(Me.tlpUser)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmUserActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Day to Day Activities"
        Me.tlpUser.ResumeLayout(False)
        Me.tlpUser.PerformLayout()
        CType(Me.dgvRecent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpUser As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lsvEmployee As System.Windows.Forms.ListView
    Friend WithEvents dgvCount As System.Windows.Forms.DataGridView
    Friend WithEvents colCOPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEOPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colESupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRequest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents dgvRecent As System.Windows.Forms.DataGridView
    Friend WithEvents lblNoActivity As System.Windows.Forms.Label
End Class
