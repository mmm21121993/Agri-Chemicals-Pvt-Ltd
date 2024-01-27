Public Class frmPOPO

    Public ID As Integer

    Private Sub frmPOPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OPODataSet.OPO' table. You can move, or remove it, as needed.
        Me.OPOTableAdapter.Fill(Me.OPODataSet.OPO, ID)
        'TODO: This line of code loads data into the 'OPODataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.OPODataSet.Supplier, ID)
        'TODO: This line of code loads data into the 'OPODataSet.Quotation' table. You can move, or remove it, as needed.
        Me.QuotationTableAdapter.Fill(Me.OPODataSet.Quotation, ID)
        'TODO: This line of code loads data into the 'OPODataSet.Attachment' table. You can move, or remove it, as needed.
        Me.AttachmentTableAdapter.Fill(Me.OPODataSet.Attachment, ID)

        Me.rtpOPO.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.rtpOPO.LocalReport.DisplayName = Me.Text

        Me.rtpOPO.RefreshReport()
    End Sub

End Class