<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOPO
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOPO))
        Me.OPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPODataSet = New ACL.OPODataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttachmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rtpOPO = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OPOTableAdapter = New ACL.OPODataSetTableAdapters.OPOTableAdapter()
        Me.SupplierTableAdapter = New ACL.OPODataSetTableAdapters.SupplierTableAdapter()
        Me.QuotationTableAdapter = New ACL.OPODataSetTableAdapters.QuotationTableAdapter()
        Me.AttachmentTableAdapter = New ACL.OPODataSetTableAdapters.AttachmentTableAdapter()
        CType(Me.OPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttachmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OPOBindingSource
        '
        Me.OPOBindingSource.DataMember = "OPO"
        Me.OPOBindingSource.DataSource = Me.OPODataSet
        '
        'OPODataSet
        '
        Me.OPODataSet.DataSetName = "OPODataSet"
        Me.OPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.OPODataSet
        '
        'QuotationBindingSource
        '
        Me.QuotationBindingSource.DataMember = "Quotation"
        Me.QuotationBindingSource.DataSource = Me.OPODataSet
        '
        'AttachmentBindingSource
        '
        Me.AttachmentBindingSource.DataMember = "Attachment"
        Me.AttachmentBindingSource.DataSource = Me.OPODataSet
        '
        'rtpOPO
        '
        Me.rtpOPO.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "OPO"
        ReportDataSource1.Value = Me.OPOBindingSource
        ReportDataSource2.Name = "Supplier"
        ReportDataSource2.Value = Me.SupplierBindingSource
        ReportDataSource3.Name = "Quotation"
        ReportDataSource3.Value = Me.QuotationBindingSource
        ReportDataSource4.Name = "Attachment"
        ReportDataSource4.Value = Me.AttachmentBindingSource
        Me.rtpOPO.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rtpOPO.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rtpOPO.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rtpOPO.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rtpOPO.LocalReport.ReportEmbeddedResource = "ACL.OPOReport.rdlc"
        Me.rtpOPO.Location = New System.Drawing.Point(0, 0)
        Me.rtpOPO.Name = "rtpOPO"
        Me.rtpOPO.ShowBackButton = False
        Me.rtpOPO.ShowFindControls = False
        Me.rtpOPO.ShowPromptAreaButton = False
        Me.rtpOPO.Size = New System.Drawing.Size(884, 612)
        Me.rtpOPO.TabIndex = 0
        Me.rtpOPO.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'OPOTableAdapter
        '
        Me.OPOTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'QuotationTableAdapter
        '
        Me.QuotationTableAdapter.ClearBeforeFill = True
        '
        'AttachmentTableAdapter
        '
        Me.AttachmentTableAdapter.ClearBeforeFill = True
        '
        'frmPOPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.rtpOPO)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.OPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttachmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtpOPO As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OPODataSet As ACL.OPODataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuotationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttachmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OPOTableAdapter As ACL.OPODataSetTableAdapters.OPOTableAdapter
    Friend WithEvents SupplierTableAdapter As ACL.OPODataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents QuotationTableAdapter As ACL.OPODataSetTableAdapters.QuotationTableAdapter
    Friend WithEvents AttachmentTableAdapter As ACL.OPODataSetTableAdapters.AttachmentTableAdapter
End Class
