Public Class frmPSupplier

    Public ID As Integer

    Private Sub frmPSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier, ID)
        'TODO: This line of code loads data into the 'SupplierDataSet.Phone' table. You can move, or remove it, as needed.
        Me.PhoneTableAdapter.Fill(Me.SupplierDataSet.Phone, ID)
        'TODO: This line of code loads data into the 'SupplierDataSet.Fax' table. You can move, or remove it, as needed.
        Me.FaxTableAdapter.Fill(Me.SupplierDataSet.Fax, ID)
        'TODO: This line of code loads data into the 'SupplierDataSet.Contact' table. You can move, or remove it, as needed.
        Me.ContactTableAdapter.Fill(Me.SupplierDataSet.Contact, ID)

        Me.rtpSupplier.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.rtpSupplier.LocalReport.DisplayName = Me.Text

        Me.rtpSupplier.RefreshReport()
    End Sub

End Class