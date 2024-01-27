<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPO
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOPO))
        Me.tlpOPO = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOPRNo = New System.Windows.Forms.Label()
        Me.lblOPRDate = New System.Windows.Forms.Label()
        Me.lblOPONo = New System.Windows.Forms.Label()
        Me.lblOPODate = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.lblAGL = New System.Windows.Forms.Label()
        Me.lblLPO = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFreight = New System.Windows.Forms.Label()
        Me.lblFOB = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblGrand = New System.Windows.Forms.Label()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtOPRNo = New System.Windows.Forms.TextBox()
        Me.dtpOPRDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOPONo = New System.Windows.Forms.TextBox()
        Me.dtpOPODate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAGL = New System.Windows.Forms.TextBox()
        Me.txtLPO = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtFreight = New System.Windows.Forms.TextBox()
        Me.txtFOB = New System.Windows.Forms.TextBox()
        Me.txtCommission = New System.Windows.Forms.TextBox()
        Me.txtGrand = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.dgvQuotation = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lsvAttachment = New System.Windows.Forms.ListView()
        Me.pnlQuotation = New System.Windows.Forms.Panel()
        Me.lnkExport = New System.Windows.Forms.LinkLabel()
        Me.lnkUnload = New System.Windows.Forms.LinkLabel()
        Me.lnkUpload = New System.Windows.Forms.LinkLabel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lnkAttach = New System.Windows.Forms.LinkLabel()
        Me.lnkRemove = New System.Windows.Forms.LinkLabel()
        Me.lblBLDate = New System.Windows.Forms.Label()
        Me.lblBLNo = New System.Windows.Forms.Label()
        Me.txtBLNo = New System.Windows.Forms.TextBox()
        Me.dtpBLDate = New System.Windows.Forms.DateTimePicker()
        Me.tlpOPO.SuspendLayout()
        CType(Me.dgvQuotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuotation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpOPO
        '
        Me.tlpOPO.ColumnCount = 8
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.5!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.5!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.tlpOPO.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.tlpOPO.Controls.Add(Me.lblOPRNo, 0, 1)
        Me.tlpOPO.Controls.Add(Me.lblOPRDate, 4, 1)
        Me.tlpOPO.Controls.Add(Me.lblOPONo, 0, 3)
        Me.tlpOPO.Controls.Add(Me.lblOPODate, 4, 3)
        Me.tlpOPO.Controls.Add(Me.lblInvoiceNo, 0, 5)
        Me.tlpOPO.Controls.Add(Me.lblInvoiceDate, 4, 5)
        Me.tlpOPO.Controls.Add(Me.lblAGL, 0, 9)
        Me.tlpOPO.Controls.Add(Me.lblLPO, 4, 9)
        Me.tlpOPO.Controls.Add(Me.lblTotal, 0, 14)
        Me.tlpOPO.Controls.Add(Me.lblFreight, 0, 16)
        Me.tlpOPO.Controls.Add(Me.lblFOB, 0, 18)
        Me.tlpOPO.Controls.Add(Me.lblCommission, 0, 20)
        Me.tlpOPO.Controls.Add(Me.lblGrand, 0, 22)
        Me.tlpOPO.Controls.Add(Me.lblAttachment, 2, 14)
        Me.tlpOPO.Controls.Add(Me.lblSupplier, 2, 20)
        Me.tlpOPO.Controls.Add(Me.lblComment, 2, 22)
        Me.tlpOPO.Controls.Add(Me.txtOPRNo, 1, 1)
        Me.tlpOPO.Controls.Add(Me.dtpOPRDate, 5, 1)
        Me.tlpOPO.Controls.Add(Me.txtOPONo, 1, 3)
        Me.tlpOPO.Controls.Add(Me.dtpOPODate, 5, 3)
        Me.tlpOPO.Controls.Add(Me.txtInvoiceNo, 1, 5)
        Me.tlpOPO.Controls.Add(Me.dtpInvoiceDate, 5, 5)
        Me.tlpOPO.Controls.Add(Me.txtAGL, 1, 9)
        Me.tlpOPO.Controls.Add(Me.txtLPO, 5, 9)
        Me.tlpOPO.Controls.Add(Me.txtTotal, 1, 14)
        Me.tlpOPO.Controls.Add(Me.txtFreight, 1, 16)
        Me.tlpOPO.Controls.Add(Me.txtFOB, 1, 18)
        Me.tlpOPO.Controls.Add(Me.txtCommission, 1, 20)
        Me.tlpOPO.Controls.Add(Me.txtGrand, 1, 22)
        Me.tlpOPO.Controls.Add(Me.txtSupplier, 3, 20)
        Me.tlpOPO.Controls.Add(Me.txtComment, 3, 22)
        Me.tlpOPO.Controls.Add(Me.dgvQuotation, 0, 11)
        Me.tlpOPO.Controls.Add(Me.lsvAttachment, 3, 14)
        Me.tlpOPO.Controls.Add(Me.pnlQuotation, 0, 12)
        Me.tlpOPO.Controls.Add(Me.btnSave, 1, 23)
        Me.tlpOPO.Controls.Add(Me.btnReset, 4, 23)
        Me.tlpOPO.Controls.Add(Me.btnSearch, 3, 0)
        Me.tlpOPO.Controls.Add(Me.lnkAttach, 7, 14)
        Me.tlpOPO.Controls.Add(Me.lnkRemove, 7, 18)
        Me.tlpOPO.Controls.Add(Me.lblBLDate, 4, 7)
        Me.tlpOPO.Controls.Add(Me.lblBLNo, 0, 7)
        Me.tlpOPO.Controls.Add(Me.txtBLNo, 1, 7)
        Me.tlpOPO.Controls.Add(Me.dtpBLDate, 5, 7)
        Me.tlpOPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOPO.Location = New System.Drawing.Point(16, 7)
        Me.tlpOPO.Name = "tlpOPO"
        Me.tlpOPO.RowCount = 24
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpOPO.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpOPO.Size = New System.Drawing.Size(902, 568)
        Me.tlpOPO.TabIndex = 0
        '
        'lblOPRNo
        '
        Me.lblOPRNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPRNo.AutoSize = True
        Me.lblOPRNo.Location = New System.Drawing.Point(3, 16)
        Me.lblOPRNo.Name = "lblOPRNo"
        Me.lblOPRNo.Size = New System.Drawing.Size(114, 14)
        Me.lblOPRNo.TabIndex = 0
        Me.lblOPRNo.Text = "OPR Number:"
        '
        'lblOPRDate
        '
        Me.lblOPRDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPRDate.AutoSize = True
        Me.lblOPRDate.Location = New System.Drawing.Point(465, 16)
        Me.lblOPRDate.Name = "lblOPRDate"
        Me.lblOPRDate.Size = New System.Drawing.Size(114, 14)
        Me.lblOPRDate.TabIndex = 0
        Me.lblOPRDate.Text = "OPR Date:"
        '
        'lblOPONo
        '
        Me.lblOPONo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPONo.AutoSize = True
        Me.lblOPONo.Location = New System.Drawing.Point(3, 47)
        Me.lblOPONo.Name = "lblOPONo"
        Me.lblOPONo.Size = New System.Drawing.Size(114, 14)
        Me.lblOPONo.TabIndex = 0
        Me.lblOPONo.Text = "OPO Number:"
        '
        'lblOPODate
        '
        Me.lblOPODate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPODate.AutoSize = True
        Me.lblOPODate.Location = New System.Drawing.Point(465, 47)
        Me.lblOPODate.Name = "lblOPODate"
        Me.lblOPODate.Size = New System.Drawing.Size(114, 14)
        Me.lblOPODate.TabIndex = 0
        Me.lblOPODate.Text = "OPO Date:"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(3, 78)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(114, 14)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "Invoice Number:"
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceDate.AutoSize = True
        Me.lblInvoiceDate.Location = New System.Drawing.Point(465, 78)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(114, 14)
        Me.lblInvoiceDate.TabIndex = 0
        Me.lblInvoiceDate.Text = "Invoice Date:"
        '
        'lblAGL
        '
        Me.lblAGL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAGL.AutoSize = True
        Me.lblAGL.Location = New System.Drawing.Point(3, 140)
        Me.lblAGL.Name = "lblAGL"
        Me.lblAGL.Size = New System.Drawing.Size(114, 14)
        Me.lblAGL.TabIndex = 0
        Me.lblAGL.Text = "AGLPO Number:"
        '
        'lblLPO
        '
        Me.lblLPO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLPO.AutoSize = True
        Me.lblLPO.Location = New System.Drawing.Point(465, 140)
        Me.lblLPO.Name = "lblLPO"
        Me.lblLPO.Size = New System.Drawing.Size(114, 14)
        Me.lblLPO.TabIndex = 0
        Me.lblLPO.Text = "LPO Number:"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(3, 375)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(114, 14)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total:"
        '
        'lblFreight
        '
        Me.lblFreight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFreight.AutoSize = True
        Me.lblFreight.Location = New System.Drawing.Point(3, 406)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(114, 14)
        Me.lblFreight.TabIndex = 0
        Me.lblFreight.Text = "Freight Charge:"
        '
        'lblFOB
        '
        Me.lblFOB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFOB.AutoSize = True
        Me.lblFOB.Location = New System.Drawing.Point(3, 437)
        Me.lblFOB.Name = "lblFOB"
        Me.lblFOB.Size = New System.Drawing.Size(114, 14)
        Me.lblFOB.TabIndex = 0
        Me.lblFOB.Text = "FOB Charge:"
        '
        'lblCommission
        '
        Me.lblCommission.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(3, 468)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(114, 14)
        Me.lblCommission.TabIndex = 0
        Me.lblCommission.Text = "Commission:"
        '
        'lblGrand
        '
        Me.lblGrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrand.AutoSize = True
        Me.lblGrand.Location = New System.Drawing.Point(3, 499)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(114, 14)
        Me.lblGrand.TabIndex = 0
        Me.lblGrand.Text = "Grand Total:"
        '
        'lblAttachment
        '
        Me.lblAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttachment.AutoSize = True
        Me.lblAttachment.Location = New System.Drawing.Point(311, 375)
        Me.lblAttachment.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(104, 14)
        Me.lblAttachment.TabIndex = 0
        Me.lblAttachment.Text = "Attachments:"
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Location = New System.Drawing.Point(311, 468)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(104, 14)
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "Supplier:"
        '
        'lblComment
        '
        Me.lblComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(311, 499)
        Me.lblComment.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(104, 14)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Text = "Comments:"
        '
        'txtOPRNo
        '
        Me.txtOPRNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOPRNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOPRNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOPRNo.BackColor = System.Drawing.Color.Ivory
        Me.txtOPRNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtOPRNo, 2)
        Me.txtOPRNo.Location = New System.Drawing.Point(123, 13)
        Me.txtOPRNo.Name = "txtOPRNo"
        Me.txtOPRNo.Size = New System.Drawing.Size(292, 22)
        Me.txtOPRNo.TabIndex = 1
        '
        'dtpOPRDate
        '
        Me.dtpOPRDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOPO.SetColumnSpan(Me.dtpOPRDate, 3)
        Me.dtpOPRDate.Location = New System.Drawing.Point(585, 13)
        Me.dtpOPRDate.Name = "dtpOPRDate"
        Me.dtpOPRDate.Size = New System.Drawing.Size(314, 22)
        Me.dtpOPRDate.TabIndex = 2
        '
        'txtOPONo
        '
        Me.txtOPONo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOPONo.BackColor = System.Drawing.Color.Ivory
        Me.txtOPONo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtOPONo, 2)
        Me.txtOPONo.Location = New System.Drawing.Point(123, 44)
        Me.txtOPONo.Name = "txtOPONo"
        Me.txtOPONo.Size = New System.Drawing.Size(292, 22)
        Me.txtOPONo.TabIndex = 3
        '
        'dtpOPODate
        '
        Me.dtpOPODate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOPO.SetColumnSpan(Me.dtpOPODate, 3)
        Me.dtpOPODate.Location = New System.Drawing.Point(585, 44)
        Me.dtpOPODate.Name = "dtpOPODate"
        Me.dtpOPODate.Size = New System.Drawing.Size(314, 22)
        Me.dtpOPODate.TabIndex = 4
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.Ivory
        Me.txtInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtInvoiceNo, 2)
        Me.txtInvoiceNo.Location = New System.Drawing.Point(123, 75)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(292, 22)
        Me.txtInvoiceNo.TabIndex = 5
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOPO.SetColumnSpan(Me.dtpInvoiceDate, 3)
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(585, 75)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(314, 22)
        Me.dtpInvoiceDate.TabIndex = 6
        '
        'txtAGL
        '
        Me.txtAGL.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAGL.BackColor = System.Drawing.Color.Ivory
        Me.txtAGL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtAGL, 2)
        Me.txtAGL.Location = New System.Drawing.Point(123, 137)
        Me.txtAGL.Name = "txtAGL"
        Me.txtAGL.Size = New System.Drawing.Size(292, 22)
        Me.txtAGL.TabIndex = 9
        '
        'txtLPO
        '
        Me.txtLPO.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLPO.BackColor = System.Drawing.Color.Ivory
        Me.txtLPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtLPO, 3)
        Me.txtLPO.Location = New System.Drawing.Point(585, 137)
        Me.txtLPO.Name = "txtLPO"
        Me.txtLPO.Size = New System.Drawing.Size(314, 22)
        Me.txtLPO.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.Ivory
        Me.txtTotal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(123, 372)
        Me.txtTotal.MaxLength = 20
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(172, 22)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFreight
        '
        Me.txtFreight.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFreight.BackColor = System.Drawing.Color.Ivory
        Me.txtFreight.Location = New System.Drawing.Point(123, 403)
        Me.txtFreight.MaxLength = 20
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.Size = New System.Drawing.Size(172, 22)
        Me.txtFreight.TabIndex = 14
        Me.txtFreight.Text = "0"
        Me.txtFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFOB
        '
        Me.txtFOB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFOB.BackColor = System.Drawing.Color.Ivory
        Me.txtFOB.Location = New System.Drawing.Point(123, 434)
        Me.txtFOB.MaxLength = 20
        Me.txtFOB.Name = "txtFOB"
        Me.txtFOB.Size = New System.Drawing.Size(172, 22)
        Me.txtFOB.TabIndex = 15
        Me.txtFOB.Text = "0"
        Me.txtFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCommission
        '
        Me.txtCommission.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommission.BackColor = System.Drawing.Color.Ivory
        Me.txtCommission.Location = New System.Drawing.Point(123, 465)
        Me.txtCommission.MaxLength = 20
        Me.txtCommission.Name = "txtCommission"
        Me.txtCommission.Size = New System.Drawing.Size(172, 22)
        Me.txtCommission.TabIndex = 16
        Me.txtCommission.Text = "0"
        Me.txtCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrand
        '
        Me.txtGrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrand.BackColor = System.Drawing.Color.Ivory
        Me.txtGrand.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrand.Location = New System.Drawing.Point(123, 496)
        Me.txtGrand.Name = "txtGrand"
        Me.txtGrand.ReadOnly = True
        Me.txtGrand.Size = New System.Drawing.Size(172, 22)
        Me.txtGrand.TabIndex = 17
        Me.txtGrand.Text = "0"
        Me.txtGrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSupplier
        '
        Me.txtSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSupplier.BackColor = System.Drawing.Color.Ivory
        Me.tlpOPO.SetColumnSpan(Me.txtSupplier, 5)
        Me.txtSupplier.Location = New System.Drawing.Point(421, 465)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(478, 22)
        Me.txtSupplier.TabIndex = 21
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComment.AutoCompleteCustomSource.AddRange(New String() {"None"})
        Me.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComment.BackColor = System.Drawing.Color.Ivory
        Me.tlpOPO.SetColumnSpan(Me.txtComment, 5)
        Me.txtComment.Location = New System.Drawing.Point(421, 496)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(478, 22)
        Me.txtComment.TabIndex = 22
        '
        'dgvQuotation
        '
        Me.dgvQuotation.AllowUserToResizeColumns = False
        Me.dgvQuotation.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvQuotation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvQuotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvQuotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuotation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvQuotation.BackgroundColor = System.Drawing.Color.White
        Me.dgvQuotation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQuotation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuotation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colQuantity, Me.colUnit, Me.colPrice, Me.colCurrency})
        Me.tlpOPO.SetColumnSpan(Me.dgvQuotation, 8)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvQuotation.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvQuotation.Location = New System.Drawing.Point(3, 170)
        Me.dgvQuotation.Name = "dgvQuotation"
        Me.dgvQuotation.RowHeadersWidth = 54
        Me.dgvQuotation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvQuotation.Size = New System.Drawing.Size(896, 165)
        Me.dgvQuotation.TabIndex = 11
        '
        'colItem
        '
        Me.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colItem.DataPropertyName = "Items"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.colItem.HeaderText = "Item Description"
        Me.colItem.Name = "colItem"
        '
        'colQuantity
        '
        Me.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colQuantity.DataPropertyName = "Quantity"
        Me.colQuantity.FillWeight = 130.0!
        Me.colQuantity.HeaderText = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Width = 130
        '
        'colUnit
        '
        Me.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colUnit.DataPropertyName = "Unit"
        Me.colUnit.FillWeight = 130.0!
        Me.colUnit.HeaderText = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.Width = 130
        '
        'colPrice
        '
        Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colPrice.DataPropertyName = "Price"
        Me.colPrice.FillWeight = 150.0!
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 150
        '
        'colCurrency
        '
        Me.colCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colCurrency.DataPropertyName = "Currency"
        Me.colCurrency.FillWeight = 150.0!
        Me.colCurrency.HeaderText = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.Width = 150
        '
        'lsvAttachment
        '
        Me.lsvAttachment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvAttachment.BackColor = System.Drawing.Color.Ivory
        Me.tlpOPO.SetColumnSpan(Me.lsvAttachment, 4)
        Me.lsvAttachment.Location = New System.Drawing.Point(421, 372)
        Me.lsvAttachment.MultiSelect = False
        Me.lsvAttachment.Name = "lsvAttachment"
        Me.tlpOPO.SetRowSpan(Me.lsvAttachment, 5)
        Me.lsvAttachment.ShowItemToolTips = True
        Me.lsvAttachment.Size = New System.Drawing.Size(394, 83)
        Me.lsvAttachment.TabIndex = 18
        Me.lsvAttachment.TileSize = New System.Drawing.Size(387, 27)
        Me.lsvAttachment.UseCompatibleStateImageBehavior = False
        Me.lsvAttachment.View = System.Windows.Forms.View.List
        '
        'pnlQuotation
        '
        Me.pnlQuotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOPO.SetColumnSpan(Me.pnlQuotation, 8)
        Me.pnlQuotation.Controls.Add(Me.lnkExport)
        Me.pnlQuotation.Controls.Add(Me.lnkUnload)
        Me.pnlQuotation.Controls.Add(Me.lnkUpload)
        Me.pnlQuotation.Location = New System.Drawing.Point(3, 341)
        Me.pnlQuotation.Name = "pnlQuotation"
        Me.pnlQuotation.Size = New System.Drawing.Size(896, 21)
        Me.pnlQuotation.TabIndex = 12
        '
        'lnkExport
        '
        Me.lnkExport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkExport.AutoSize = True
        Me.lnkExport.Location = New System.Drawing.Point(533, 4)
        Me.lnkExport.Name = "lnkExport"
        Me.lnkExport.Size = New System.Drawing.Size(115, 14)
        Me.lnkExport.TabIndex = 2
        Me.lnkExport.TabStop = True
        Me.lnkExport.Text = "Export Quotation"
        '
        'lnkUnload
        '
        Me.lnkUnload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkUnload.AutoSize = True
        Me.lnkUnload.Location = New System.Drawing.Point(391, 3)
        Me.lnkUnload.Name = "lnkUnload"
        Me.lnkUnload.Size = New System.Drawing.Size(118, 14)
        Me.lnkUnload.TabIndex = 1
        Me.lnkUnload.TabStop = True
        Me.lnkUnload.Text = "Unload Quotation"
        '
        'lnkUpload
        '
        Me.lnkUpload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkUpload.AutoSize = True
        Me.lnkUpload.Location = New System.Drawing.Point(249, 4)
        Me.lnkUpload.Name = "lnkUpload"
        Me.lnkUpload.Size = New System.Drawing.Size(118, 14)
        Me.lnkUpload.TabIndex = 0
        Me.lnkUpload.TabStop = True
        Me.lnkUpload.Text = "Upload Quotation"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tlpOPO.SetColumnSpan(Me.btnSave, 2)
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(255, 527)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 34)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save Details"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpOPO.SetColumnSpan(Me.btnReset, 2)
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(465, 527)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 34)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "Reset Details"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Image = Global.ACL.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(422, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.tlpOPO.SetRowSpan(Me.btnSearch, 3)
        Me.btnSearch.Size = New System.Drawing.Size(35, 35)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.UseVisualStyleBackColor = True
        Me.btnSearch.Visible = False
        '
        'lnkAttach
        '
        Me.lnkAttach.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lnkAttach.AutoSize = True
        Me.lnkAttach.Location = New System.Drawing.Point(821, 375)
        Me.lnkAttach.Name = "lnkAttach"
        Me.lnkAttach.Size = New System.Drawing.Size(47, 14)
        Me.lnkAttach.TabIndex = 19
        Me.lnkAttach.TabStop = True
        Me.lnkAttach.Text = "Attach"
        '
        'lnkRemove
        '
        Me.lnkRemove.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lnkRemove.AutoSize = True
        Me.lnkRemove.Location = New System.Drawing.Point(821, 437)
        Me.lnkRemove.Name = "lnkRemove"
        Me.lnkRemove.Size = New System.Drawing.Size(57, 14)
        Me.lnkRemove.TabIndex = 20
        Me.lnkRemove.TabStop = True
        Me.lnkRemove.Text = "Remove"
        '
        'lblBLDate
        '
        Me.lblBLDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBLDate.AutoSize = True
        Me.lblBLDate.Location = New System.Drawing.Point(465, 109)
        Me.lblBLDate.Name = "lblBLDate"
        Me.lblBLDate.Size = New System.Drawing.Size(114, 14)
        Me.lblBLDate.TabIndex = 0
        Me.lblBLDate.Text = "BL/AWB Date:"
        '
        'lblBLNo
        '
        Me.lblBLNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBLNo.AutoSize = True
        Me.lblBLNo.Location = New System.Drawing.Point(3, 109)
        Me.lblBLNo.Name = "lblBLNo"
        Me.lblBLNo.Size = New System.Drawing.Size(114, 14)
        Me.lblBLNo.TabIndex = 0
        Me.lblBLNo.Text = "BL/AWB Number:"
        '
        'txtBLNo
        '
        Me.txtBLNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBLNo.BackColor = System.Drawing.Color.Ivory
        Me.txtBLNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpOPO.SetColumnSpan(Me.txtBLNo, 2)
        Me.txtBLNo.Location = New System.Drawing.Point(123, 106)
        Me.txtBLNo.Name = "txtBLNo"
        Me.txtBLNo.Size = New System.Drawing.Size(292, 22)
        Me.txtBLNo.TabIndex = 7
        '
        'dtpBLDate
        '
        Me.dtpBLDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpOPO.SetColumnSpan(Me.dtpBLDate, 3)
        Me.dtpBLDate.Location = New System.Drawing.Point(585, 106)
        Me.dtpBLDate.Name = "dtpBLDate"
        Me.dtpBLDate.Size = New System.Drawing.Size(314, 22)
        Me.dtpBLDate.TabIndex = 8
        '
        'frmOPO
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.tlpOPO)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmOPO"
        Me.Padding = New System.Windows.Forms.Padding(16, 7, 16, 7)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New OPO Registration"
        Me.tlpOPO.ResumeLayout(False)
        Me.tlpOPO.PerformLayout()
        CType(Me.dgvQuotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuotation.ResumeLayout(False)
        Me.pnlQuotation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpOPO As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOPRNo As System.Windows.Forms.Label
    Friend WithEvents lblOPRDate As System.Windows.Forms.Label
    Friend WithEvents lblOPONo As System.Windows.Forms.Label
    Friend WithEvents lblOPODate As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceDate As System.Windows.Forms.Label
    Friend WithEvents lblAGL As System.Windows.Forms.Label
    Friend WithEvents lblLPO As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblFreight As System.Windows.Forms.Label
    Friend WithEvents lblFOB As System.Windows.Forms.Label
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents txtOPRNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpOPRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOPONo As System.Windows.Forms.TextBox
    Friend WithEvents dtpOPODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAGL As System.Windows.Forms.TextBox
    Friend WithEvents txtLPO As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFreight As System.Windows.Forms.TextBox
    Friend WithEvents txtFOB As System.Windows.Forms.TextBox
    Friend WithEvents txtCommission As System.Windows.Forms.TextBox
    Friend WithEvents txtGrand As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents dgvQuotation As System.Windows.Forms.DataGridView
    Friend WithEvents lsvAttachment As System.Windows.Forms.ListView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlQuotation As System.Windows.Forms.Panel
    Friend WithEvents lnkExport As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUnload As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkUpload As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lnkAttach As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkRemove As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBLDate As System.Windows.Forms.Label
    Friend WithEvents lblBLNo As System.Windows.Forms.Label
    Friend WithEvents txtBLNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpBLDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCurrency As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
