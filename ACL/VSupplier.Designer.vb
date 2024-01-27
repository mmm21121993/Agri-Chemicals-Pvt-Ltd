<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVSupplier))
        Me.tlpSupplier = New System.Windows.Forms.TableLayoutPanel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cblType = New System.Windows.Forms.CheckedListBox()
        Me.cblCountry = New System.Windows.Forms.CheckedListBox()
        Me.cblCity = New System.Windows.Forms.CheckedListBox()
        Me.lsvSupplier = New System.Windows.Forms.ListView()
        Me.cmsSupplier = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNone = New System.Windows.Forms.Label()
        Me.tlpSupplier.SuspendLayout()
        Me.cmsSupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSupplier
        '
        Me.tlpSupplier.BackColor = System.Drawing.Color.White
        Me.tlpSupplier.ColumnCount = 3
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSupplier.Controls.Add(Me.lblName, 0, 1)
        Me.tlpSupplier.Controls.Add(Me.lblType, 0, 5)
        Me.tlpSupplier.Controls.Add(Me.lblCountry, 0, 9)
        Me.tlpSupplier.Controls.Add(Me.lblCity, 0, 13)
        Me.tlpSupplier.Controls.Add(Me.txtName, 0, 3)
        Me.tlpSupplier.Controls.Add(Me.cblType, 0, 7)
        Me.tlpSupplier.Controls.Add(Me.cblCountry, 0, 11)
        Me.tlpSupplier.Controls.Add(Me.cblCity, 0, 15)
        Me.tlpSupplier.Controls.Add(Me.lsvSupplier, 2, 1)
        Me.tlpSupplier.Controls.Add(Me.btnSearch, 0, 16)
        Me.tlpSupplier.Controls.Add(Me.btnClear, 1, 16)
        Me.tlpSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSupplier.Location = New System.Drawing.Point(0, 0)
        Me.tlpSupplier.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.tlpSupplier.Name = "tlpSupplier"
        Me.tlpSupplier.RowCount = 17
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpSupplier.Size = New System.Drawing.Size(934, 582)
        Me.tlpSupplier.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.tlpSupplier.SetColumnSpan(Me.lblName, 2)
        Me.lblName.Location = New System.Drawing.Point(13, 15)
        Me.lblName.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(237, 14)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Supplier Name:"
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.tlpSupplier.SetColumnSpan(Me.lblType, 2)
        Me.lblType.Location = New System.Drawing.Point(13, 81)
        Me.lblType.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(237, 14)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Supplier Type:"
        '
        'lblCountry
        '
        Me.lblCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountry.AutoSize = True
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.tlpSupplier.SetColumnSpan(Me.lblCountry, 2)
        Me.lblCountry.Location = New System.Drawing.Point(13, 237)
        Me.lblCountry.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(237, 14)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.Text = "Supplier Country:"
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.tlpSupplier.SetColumnSpan(Me.lblCity, 2)
        Me.lblCity.Location = New System.Drawing.Point(13, 394)
        Me.lblCity.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(237, 14)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "Supplier City:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.BackColor = System.Drawing.Color.Ivory
        Me.tlpSupplier.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Location = New System.Drawing.Point(13, 41)
        Me.txtName.Margin = New System.Windows.Forms.Padding(13, 0, 9, 0)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 22)
        Me.txtName.TabIndex = 1
        '
        'cblType
        '
        Me.cblType.BackColor = System.Drawing.Color.FloralWhite
        Me.cblType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpSupplier.SetColumnSpan(Me.cblType, 2)
        Me.cblType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblType.FormattingEnabled = True
        Me.cblType.Location = New System.Drawing.Point(13, 105)
        Me.cblType.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblType.Name = "cblType"
        Me.cblType.Size = New System.Drawing.Size(237, 117)
        Me.cblType.Sorted = True
        Me.cblType.TabIndex = 2
        '
        'cblCountry
        '
        Me.cblCountry.BackColor = System.Drawing.Color.FloralWhite
        Me.cblCountry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpSupplier.SetColumnSpan(Me.cblCountry, 2)
        Me.cblCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblCountry.FormattingEnabled = True
        Me.cblCountry.Location = New System.Drawing.Point(13, 261)
        Me.cblCountry.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblCountry.Name = "cblCountry"
        Me.cblCountry.Size = New System.Drawing.Size(237, 118)
        Me.cblCountry.Sorted = True
        Me.cblCountry.TabIndex = 3
        '
        'cblCity
        '
        Me.cblCity.BackColor = System.Drawing.Color.FloralWhite
        Me.cblCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpSupplier.SetColumnSpan(Me.cblCity, 2)
        Me.cblCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cblCity.FormattingEnabled = True
        Me.cblCity.Location = New System.Drawing.Point(13, 418)
        Me.cblCity.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.cblCity.Name = "cblCity"
        Me.cblCity.Size = New System.Drawing.Size(237, 117)
        Me.cblCity.Sorted = True
        Me.cblCity.TabIndex = 4
        Me.cblCity.ThreeDCheckBoxes = True
        '
        'lsvSupplier
        '
        Me.lsvSupplier.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lsvSupplier.BackColor = System.Drawing.Color.White
        Me.lsvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsvSupplier.ContextMenuStrip = Me.cmsSupplier
        Me.lsvSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvSupplier.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSupplier.FullRowSelect = True
        Me.lsvSupplier.Location = New System.Drawing.Point(275, 22)
        Me.lsvSupplier.Margin = New System.Windows.Forms.Padding(25, 13, 0, 13)
        Me.lsvSupplier.MultiSelect = False
        Me.lsvSupplier.Name = "lsvSupplier"
        Me.tlpSupplier.SetRowSpan(Me.lsvSupplier, 16)
        Me.lsvSupplier.ShowItemToolTips = True
        Me.lsvSupplier.Size = New System.Drawing.Size(659, 547)
        Me.lsvSupplier.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsvSupplier.TabIndex = 7
        Me.lsvSupplier.TileSize = New System.Drawing.Size(360, 100)
        Me.lsvSupplier.UseCompatibleStateImageBehavior = False
        '
        'cmsSupplier
        '
        Me.cmsSupplier.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuPrint, Me.mnuDelete})
        Me.cmsSupplier.Name = "cmsOPO"
        Me.cmsSupplier.Size = New System.Drawing.Size(171, 92)
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(170, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(170, 22)
        Me.mnuPrint.Text = "Print"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(170, 22)
        Me.mnuDelete.Text = "Delete Supplier"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(22, 545)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 3, 13, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 27)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(138, 545)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 27)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
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
        Me.lblNone.Size = New System.Drawing.Size(541, 118)
        Me.lblNone.TabIndex = 1
        Me.lblNone.Text = "No Supplier Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Found"
        Me.lblNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVSupplier
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.lblNone)
        Me.Controls.Add(Me.tlpSupplier)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmVSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Supplier Details"
        Me.tlpSupplier.ResumeLayout(False)
        Me.tlpSupplier.PerformLayout()
        Me.cmsSupplier.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpSupplier As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cblType As System.Windows.Forms.CheckedListBox
    Friend WithEvents cblCountry As System.Windows.Forms.CheckedListBox
    Friend WithEvents cblCity As System.Windows.Forms.CheckedListBox
    Friend WithEvents lsvSupplier As System.Windows.Forms.ListView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cmsSupplier As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNone As System.Windows.Forms.Label
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
End Class
