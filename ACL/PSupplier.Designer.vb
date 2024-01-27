<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPSupplier))
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New ACL.SupplierDataSet()
        Me.PhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rtpSupplier = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SupplierTableAdapter = New ACL.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.PhoneTableAdapter = New ACL.SupplierDataSetTableAdapters.PhoneTableAdapter()
        Me.FaxTableAdapter = New ACL.SupplierDataSetTableAdapters.FaxTableAdapter()
        Me.ContactTableAdapter = New ACL.SupplierDataSetTableAdapters.ContactTableAdapter()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhoneBindingSource
        '
        Me.PhoneBindingSource.DataMember = "Phone"
        Me.PhoneBindingSource.DataSource = Me.SupplierDataSet
        '
        'FaxBindingSource
        '
        Me.FaxBindingSource.DataMember = "Fax"
        Me.FaxBindingSource.DataSource = Me.SupplierDataSet
        '
        'ContactBindingSource
        '
        Me.ContactBindingSource.DataMember = "Contact"
        Me.ContactBindingSource.DataSource = Me.SupplierDataSet
        '
        'rtpSupplier
        '
        Me.rtpSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Supplier"
        ReportDataSource1.Value = Me.SupplierBindingSource
        ReportDataSource2.Name = "Phone"
        ReportDataSource2.Value = Me.PhoneBindingSource
        ReportDataSource3.Name = "Fax"
        ReportDataSource3.Value = Me.FaxBindingSource
        ReportDataSource4.Name = "Contact"
        ReportDataSource4.Value = Me.ContactBindingSource
        Me.rtpSupplier.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rtpSupplier.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rtpSupplier.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rtpSupplier.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rtpSupplier.LocalReport.ReportEmbeddedResource = "ACL.SupplierReport.rdlc"
        Me.rtpSupplier.Location = New System.Drawing.Point(0, 0)
        Me.rtpSupplier.Name = "rtpSupplier"
        Me.rtpSupplier.ShowBackButton = False
        Me.rtpSupplier.ShowFindControls = False
        Me.rtpSupplier.ShowPromptAreaButton = False
        Me.rtpSupplier.Size = New System.Drawing.Size(884, 612)
        Me.rtpSupplier.TabIndex = 0
        Me.rtpSupplier.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'PhoneTableAdapter
        '
        Me.PhoneTableAdapter.ClearBeforeFill = True
        '
        'FaxTableAdapter
        '
        Me.FaxTableAdapter.ClearBeforeFill = True
        '
        'ContactTableAdapter
        '
        Me.ContactTableAdapter.ClearBeforeFill = True
        '
        'frmPSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.rtpSupplier)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "frmPSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtpSupplier As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierDataSet As ACL.SupplierDataSet
    Friend WithEvents PhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FaxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As ACL.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents PhoneTableAdapter As ACL.SupplierDataSetTableAdapters.PhoneTableAdapter
    Friend WithEvents FaxTableAdapter As ACL.SupplierDataSetTableAdapters.FaxTableAdapter
    Friend WithEvents ContactTableAdapter As ACL.SupplierDataSetTableAdapters.ContactTableAdapter
End Class
