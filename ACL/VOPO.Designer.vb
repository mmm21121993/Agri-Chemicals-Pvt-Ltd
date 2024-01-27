<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVOPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVOPO))
        Me.tlpOPO = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOPRNo = New System.Windows.Forms.Label()
        Me.lblAGLPO = New System.Windows.Forms.Label()
        Me.lbInvoice = New System.Windows.Forms.Label()
        Me.txtOPONo = New System.Windows.Forms.TextBox()
        Me.txtAGLPO = New System.Windows.Forms.TextBox()
        Me.lsvOPO = New System.Windows.Forms.ListView()
        Me.cmsOPO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRequest = New System.Windows.Forms.ToolStripMenuItem()
        Me.cblSupplier = New System.Windows.Forms.CheckedListBox()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblNone = New System.Windows.Forms.Label()
        Me.tlpOPO.SuspendLayout()
        Me.cmsOPO.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpOPO
        '
        Me.tlpOPO.ColumnCount = 3
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOPO.Controls.Add(Me.lblOPRNo, 0, 1)
        Me.tlpOPO.Controls.Add(Me.lblAGLPO, 0, 5)
        Me.tlpOPO.Controls.Add(Me.lbInvoice, 0, 9)
        Me.tlpOPO.Controls.Add(Me.txtOPONo, 0, 3)
        Me.tlpOPO.Controls.Add(Me.txtAGLPO, 0, 7)
        Me.tlpOPO.Controls.Add(Me.lsvOPO, 2, 1)
        Me.tlpOPO.Controls.Add(Me.cblSupplier, 0, 15)
        Me.tlpOPO.Controls.Add(Me.txtInvoice, 0, 11)
        Me.tlpOPO.Controls.Add(Me.btnClear, 1, 17)
        Me.tlpOPO.Controls.Add(Me.btnSearch, 0, 17)
        Me.tlpOPO.Controls.Add(Me.lblSupplier, 0, 13)
        Me.tlpOPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOPO.Location = New System.Drawing.Point(0, 0)
        Me.tlpOPO.Name = "tlpOPO"
        Me.tlpOPO.RowCount = 18
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpOPO.Size = New System.Drawing.Size(934, 582)
        Me.tlpOPO.TabIndex = 0
        '
        'lblOPRNo
        '
        Me.lblOPRNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPRNo.AutoSize = True
        Me.lblOPRNo.BackColor = System.Drawing.Color.Transparent
        Me.tlpOPO.SetColumnSpan(Me.lblOPRNo, 2)
        Me.lblOPRNo.Location = New System.Drawing.Point(13, 19)
        Me.lblOPRNo.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblOPRNo.Name = "lblOPRNo"
        Me.lblOPRNo.Size = New System.Drawing.Size(234, 14)
        Me.lblOPRNo.TabIndex = 0
        Me.lblOPRNo.Text = "OPR Number:"
        '
        'lblAGLPO
        '
        Me.lblAGLPO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAGLPO.AutoSize = True
        Me.lblAGLPO.BackColor = System.Drawing.Color.Transparent
        Me.tlpOPO.SetColumnSpan(Me.lblAGLPO, 2)
        Me.lblAGLPO.Location = New System.Drawing.Point(13, 86)
        Me.lblAGLPO.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblAGLPO.Name = "lblAGLPO"
        Me.lblAGLPO.Size = New System.Drawing.Size(234, 14)
        Me.lblAGLPO.TabIndex = 0
        Me.lblAGLPO.Text = "AGLPO Number:"
        '
        'lbInvoice
        '
        Me.lbInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbInvoice.AutoSize = True
        Me.lbInvoice.BackColor = System.Drawing.Color.Transparent
        Me.tlpOPO.SetColumnSpan(Me.lbInvoice, 2)
        Me.lbInvoice.Location = New System.Drawing.Point(13, 153)
        Me.lbInvoice.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lbInvoice.Name = "lbInvoice"
        Me.lbInvoice.Size = New System.Drawing.Size(234, 14)
        Me.lbInvoice.TabIndex = 0
        Me.lbInvoice.Text = "Invoice Number:"
        '
        'txtOPONo
        '
        Me.txtOPONo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOPONo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOPONo.BackColor = System.Drawing.Color.Ivory
        Me.txtOPONo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtOPONo, 2)
        Me.txtOPONo.Location = New System.Drawing.Point(13, 47)
        Me.txtOPONo.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.txtOPONo.Name = "txtOPONo"
        Me.txtOPONo.Size = New System.Drawing.Size(225, 22)
        Me.txtOPONo.TabIndex = 1
        '
        'txtAGLPO
        '
        Me.txtAGLPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAGLPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAGLPO.BackColor = System.Drawing.Color.Ivory
        Me.txtAGLPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtAGLPO, 2)
        Me.txtAGLPO.Location = New System.Drawing.Point(13, 114)
        Me.txtAGLPO.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.txtAGLPO.Name = "txtAGLPO"
        Me.txtAGLPO.Size = New System.Drawing.Size(225, 22)
        Me.txtAGLPO.TabIndex = 2
        '
        'lsvOPO
        '
        Me.lsvOPO.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lsvOPO.BackColor = System.Drawing.Color.White
        Me.lsvOPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvOPO.ContextMenuStrip = Me.cmsOPO
        Me.lsvOPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvOPO.FullRowSelect = True
        Me.lsvOPO.Location = New System.Drawing.Point(275, 26)
        Me.lsvOPO.Margin = New System.Windows.Forms.Padding(25, 13, 0, 0)
        Me.lsvOPO.MultiSelect = False
        Me.lsvOPO.Name = "lsvOPO"
        Me.tlpOPO.SetRowSpan(Me.lsvOPO, 16)
        Me.lsvOPO.ShowItemToolTips = True
        Me.lsvOPO.Size = New System.Drawing.Size(659, 506)
        Me.lsvOPO.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvOPO.TabIndex = 7
        Me.lsvOPO.TileSize = New System.Drawing.Size(250, 60)
        Me.lsvOPO.UseCompatibleStateImageBehavior = False
        Me.lsvOPO.View = System.Windows.Forms.View.SmallIcon
        '
        'cmsOPO
        '
        Me.cmsOPO.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsOPO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuPrint, Me.mnuRequest})
        Me.cmsOPO.Name = "cmsOPO"
        Me.cmsOPO.Size = New System.Drawing.Size(172, 70)
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(171, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(171, 22)
        Me.mnuPrint.Text = "Print"
        '
        'mnuRequest
        '
        Me.mnuRequest.Name = "mnuRequest"
        Me.mnuRequest.Size = New System.Drawing.Size(171, 22)
        Me.mnuRequest.Text = "Request Delete"
        '
        'cblSupplier
        '
        Me.cblSupplier.BackColor = System.Drawing.Color.FloralWhite
        Me.cblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpOPO.SetColumnSpan(Me.cblSupplier, 2)
        Me.cblSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblSupplier.FormattingEnabled = True
        Me.cblSupplier.Location = New System.Drawing.Point(13, 248)
        Me.cblSupplier.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.cblSupplier.Name = "cblSupplier"
        Me.cblSupplier.Size = New System.Drawing.Size(234, 272)
        Me.cblSupplier.TabIndex = 4
        '
        'txtInvoice
        '
        Me.txtInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtInvoice.BackColor = System.Drawing.Color.Ivory
        Me.txtInvoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtInvoice, 2)
        Me.txtInvoice.Location = New System.Drawing.Point(13, 181)
        Me.txtInvoice.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(225, 22)
        Me.txtInvoice.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(142, 543)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(17, 543)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 27)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.BackColor = System.Drawing.Color.Transparent
        Me.tlpOPO.SetColumnSpan(Me.lblSupplier, 2)
        Me.lblSupplier.Location = New System.Drawing.Point(13, 220)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(234, 14)
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "Related Supplier:"
        '
        'lblNone
        '
        Me.lblNone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNone.AutoSize = True
        Me.lblNone.BackColor = System.Drawing.Color.Transparent
        Me.lblNone.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNone.ForeColor = System.Drawing.Color.LightGray
        Me.lblNone.Location = New System.Drawing.Point(340, 232)
        Me.lblNone.Name = "lblNone"
        Me.lblNone.Size = New System.Drawing.Size(561, 118)
        Me.lblNone.TabIndex = 1
        Me.lblNone.Text = "No Purchase Orders" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Found"
        Me.lblNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVOPO
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.lblNone)
        Me.Controls.Add(Me.tlpOPO)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmVOPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View OPO Details"
        Me.tlpOPO.ResumeLayout(False)
        Me.tlpOPO.PerformLayout()
        Me.cmsOPO.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpOPO As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOPRNo As System.Windows.Forms.Label
    Friend WithEvents lblAGLPO As System.Windows.Forms.Label
    Friend WithEvents lbInvoice As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtOPONo As System.Windows.Forms.TextBox
    Friend WithEvents txtAGLPO As System.Windows.Forms.TextBox
    Friend WithEvents cblSupplier As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lsvOPO As System.Windows.Forms.ListView
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents cmsOPO As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRequest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNone As System.Windows.Forms.Label
End Class
