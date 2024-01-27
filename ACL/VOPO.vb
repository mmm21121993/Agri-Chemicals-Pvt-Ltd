Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmVOPO

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter

    Dim Title As String = "Agri Chemical Limted"

    Public Sub OPO_Autosuggest()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim OPONO, AGL, Invoice As New AutoCompleteStringCollection()
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT LTRIM(RTRIM(OPR_No)) FROM OPO"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        OPONO.Add(DR.GetValue(0).ToString())
                    End While
                    DR.Close()
                    txtOPONo.AutoCompleteCustomSource = OPONO
                    Cmd.CommandText = "SELECT LTRIM(RTRIM(AGLPO)) FROM OPO"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        AGL.Add(DR.GetValue(0).ToString())
                    End While
                    DR.Close()
                    txtAGLPO.AutoCompleteCustomSource = AGL
                    Cmd.CommandText = "SELECT LTRIM(RTRIM(Invoice_No)) FROM OPO"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        Invoice.Add(DR.GetValue(0).ToString())
                    End While
                    DR.Close()
                    txtInvoice.AutoCompleteCustomSource = Invoice
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE ID IN (SELECT DISTINCT(Supplier) FROM OPO) ORDER BY Name ASC"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        cblSupplier.Items.Add(DR.GetValue(0).ToString())
                    End While
                    DR.Close()
                Catch Ex As Exception
                    If DR.Read() Then
                        DR.Close()
                    End If
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub Reset()
        txtOPONo.Text = ""
        txtAGLPO.Text = ""
        txtInvoice.Text = ""
        For Supplier As Integer = 0 To cblSupplier.Items.Count - 1
            cblSupplier.SetItemCheckState(Supplier, False)
        Next
        cblSupplier.ClearSelected()
        txtOPONo.Focus()
        lsvOPO.Items.Clear()
        Dim OPO As New ImageList()
        OPO.ColorDepth = ColorDepth.Depth32Bit
        OPO.ImageSize = New Size(48, 60)
        OPO.TransparentColor = Color.Empty
        OPO.Images.Add(My.Resources.PO)
        lsvOPO.LargeImageList = OPO
        lsvOPO.SmallImageList = OPO
    End Sub

    Public Sub Search()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim OPR, AGL, Invoice, Supplier As String
                    If Trim(txtOPONo.Text) = "" Then
                        OPR = ""
                    Else
                        OPR = txtOPONo.Text.ToString()
                    End If
                    If Trim(txtAGLPO.Text) = "" Then
                        AGL = ""
                    Else
                        AGL = txtAGLPO.Text.ToString()
                    End If
                    If Trim(txtInvoice.Text) = "" Then
                        Invoice = ""
                    Else
                        Invoice = txtInvoice.Text.ToString()
                    End If
                    Supplier = ""
                    For Each Item As Object In cblSupplier.CheckedItems
                        Supplier = Supplier & "'" & Item.ToString() & "', "
                    Next
                    If Supplier <> "" Then
                        Supplier = Supplier.Remove(Supplier.Length - 2, 2).ToString()
                    End If
                    Cmd.Connection = Con
                    If OPR = "" And AGL = "" And Invoice = "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO"
                    ElseIf OPR = "" And AGL = "" And Invoice = "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR = "" And AGL = "" And Invoice <> "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE Invoice_NO = @Invoice"
                    ElseIf OPR = "" And AGL = "" And Invoice <> "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE Invoice_No = @Invoice AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR = "" And AGL <> "" And Invoice = "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE AGLPO = @AGL"
                    ElseIf OPR = "" And AGL <> "" And Invoice = "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE AGLPO = @AGL AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR = "" And AGL <> "" And Invoice <> "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE AGLPO = @AGL AND Invoice_No = @Invoice"
                    ElseIf OPR = "" And AGL <> "" And Invoice <> "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE AGLPO = @AGL AND Invoice_No = @Invoice AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR <> "" And AGL = "" And Invoice = "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR"
                    ElseIf OPR <> "" And AGL = "" And Invoice = "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR <> "" And AGL = "" And Invoice <> "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND Invoice_No = @Invoice"
                    ElseIf OPR <> "" And AGL = "" And Invoice <> "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND Invoice_No = @Invoice AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR <> "" And AGL <> "" And Invoice = "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND AGLPO = @AGL"
                    ElseIf OPR <> "" And AGL <> "" And Invoice = "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND AGLPO = @AGL AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    ElseIf OPR <> "" And AGL <> "" And Invoice <> "" And Supplier = "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND AND AGLPO = @AGL AND Invoice_No = @Invoice"
                    ElseIf OPR <> "" And AGL <> "" And Invoice <> "" And Supplier <> "" Then
                        Cmd.CommandText = "SELECT OPR_NO FROM OPO WHERE OPR_No = @OPR AND AGLPO = @AGL AND Invoice_No = @Invoice AND Supplier IN(SELECT ID FROM Supplier WHERE Name IN(" & Supplier & "))"
                    End If
                    Cmd.Parameters.Add(New SqlParameter("@OPR", SqlDbType.Char)).Value = txtOPONo.Text
                    Cmd.Parameters.Add(New SqlParameter("@AGL", SqlDbType.Char)).Value = txtAGLPO.Text
                    Cmd.Parameters.Add(New SqlParameter("@Invoice", SqlDbType.Char)).Value = txtInvoice.Text
                    lsvOPO.Items.Clear()
                    Dim OPO As New ImageList()
                    OPO.ColorDepth = ColorDepth.Depth32Bit
                    OPO.ImageSize = New Size(48, 60)
                    OPO.TransparentColor = Color.Empty
                    OPO.Images.Add(My.Resources.PO)
                    lsvOPO.LargeImageList = OPO
                    lsvOPO.SmallImageList = OPO
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        lsvOPO.Items.Add(Trim(DR.GetValue(0).ToString()), 0)
                    End While
                    DR.Close()
                    If lsvOPO.Items.Count = 0 Then
                        lblNone.BringToFront()
                    Else
                        lblNone.SendToBack()
                    End If
                Catch Ex As Exception
                    If DR.Read() Then
                        DR.Close()
                    End If
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub frmVOPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPO_Autosuggest()
        Reset()
        Search()
    End Sub

    Private Sub tlpOPO_CellPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TableLayoutCellPaintEventArgs) Handles tlpOPO.CellPaint
        If e.Column < 2 Then
            e.Graphics.FillRectangle(Brushes.FloralWhite, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.Transparent, e.CellBounds)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Reset()
        Search()
    End Sub

    Private Sub cmsOPO_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsOPO.Opening
        If lsvOPO.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If lsvOPO.SelectedItems.Count > 0 Then
            If frmOPO.Visible Then
                frmOPO.Close()
            End If
            frmOPO.MdiParent = frmEPanel
            frmOPO.Text = lsvOPO.SelectedItems(0).Text.ToString()
            frmOPO.txtOPRNo.Text = frmOPO.Text
            If frmOPO.OPO_Search() = True Then
                frmOPO.OPO_Load()
            End If
            frmOPO.txtOPRNo.Enabled = False
            frmOPO.Show()
            frmOPO.btnSave.Focus()
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        If lsvOPO.SelectedItems.Count > 0 Then
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "SELECT ID FROM OPO WHERE OPR_No = @OPR"
                        Cmd.Parameters.Add(New SqlParameter("@OPR", SqlDbType.Char)).Value = lsvOPO.SelectedItems(0).Text.ToString()
                        frmPOPO.ID = Cmd.ExecuteScalar()
                        If frmPOPO.Visible Then
                            frmPOPO.Close()
                        End If
                        frmPOPO.TopMost = True
                        frmPOPO.Text = Trim(lsvOPO.SelectedItems(0).Text.ToString())
                        frmPOPO.WindowState = FormWindowState.Normal
                        frmPOPO.StartPosition = FormStartPosition.CenterScreen
                        frmPOPO.Show()
                    Catch Ex As Exception
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            Catch Ex As Exception
                MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                Cmd.Parameters.Clear()
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub mnuRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRequest.Click
        If lsvOPO.SelectedItems.Count > 0 Then
            frmRequest.OPR = Trim(lsvOPO.SelectedItems(0).Text.ToString())
            If frmRequest.Visible Then
                frmRequest.Close()
            End If
            frmRequest.TopMost = True
            frmRequest.WindowState = FormWindowState.Normal
            frmRequest.Show()
        End If
    End Sub

End Class