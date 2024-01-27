Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmOPO

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter
    Dim DS As DataSet

    Dim SID, UID, Search As Integer
    Dim Title As String = "Agri Chemicals Limited"
    Dim OPR As New Regex("(O)(P)(R)(-)(\d+)(-)([A-Z]+)(-)(\d+)")
    Dim OPO As New Regex("(O)(P)(O)(-)(\d+)(-)([A-Z]+)(-)(\d+)")
    Dim Invoice As New Regex("(N)(-)(\d+)")
    Dim BLAWB As New Regex("(B)(-)(\d+)")
    Dim AGL As New Regex("(A)(G)(L)(-)(\d+)")
    Dim LPO As New Regex("(L)(P)(O)(-)(\d+)")
    Dim Number As New Regex("^[0-9]+\.?[0-9]*$")

    Dim Unit, Currency As New AutoCompleteStringCollection()

    Dim Attachment As New OpenFileDialog
    Dim Quotation As New SaveFileDialog

    Public Sub OPO_ReadOnly()
        For Each C As Control In tlpOPO.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is DateTimePicker Or TypeOf (C) Is DataGridView Or TypeOf (C) Is Panel Or TypeOf (C) Is ListView Or TypeOf (C) Is ListView Or TypeOf (C) Is LinkLabel Or TypeOf (C) Is Button Then
                C.Enabled = False
            End If
        Next
    End Sub

    Public Sub OPO_ReadWrite()
        For Each C As Control In tlpOPO.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is DateTimePicker Or TypeOf (C) Is DataGridView Or TypeOf (C) Is Panel Or TypeOf (C) Is ListView Or TypeOf (C) Is ListView Or TypeOf (C) Is LinkLabel Or TypeOf (C) Is Button Then
                C.Enabled = True
            End If
        Next
    End Sub

    Public Sub OPO_Reset()
        txtOPRNo.Text = ""
        dtpOPRDate.Text = Today
        txtOPONo.Text = ""
        dtpOPODate.Text = Today
        txtInvoiceNo.Text = ""
        dtpInvoiceDate.Text = Today
        txtBLNo.Text = ""
        dtpBLDate.Text = Today
        txtAGL.Text = ""
        txtLPO.Text = ""
        dgvQuotation.DataSource = Nothing
        dgvQuotation.Rows.Clear()
        txtTotal.Text = "0"
        txtFreight.Text = "0"
        txtFOB.Text = "0"
        txtCommission.Text = "0"
        txtGrand.Text = "0"
        lsvAttachment.Items.Clear()
        txtSupplier.Text = ""
        txtComment.Text = ""
        txtOPRNo.Focus()
    End Sub

    Public Function OPO_Validation() As String
        Dim Result As String = ""
        If Trim(txtOPRNo.Text) = "" Then
            txtOPRNo.Text = ""
            Result = Result & vbCrLf & "-  OPR Number"
        Else
            If OPR.IsMatch(Trim(txtOPRNo.Text)) = False Then
                Result = Result & vbCrLf & "-  OPR Number is not valid" & vbCrLf & "   Format: OPR-00-XXX-000      eg.: OPR-10-CNG-0016"
            End If
        End If
        If dtpOPRDate.Value > dtpOPODate.Value Or dtpOPRDate.Value > dtpInvoiceDate.Value Or dtpOPRDate.Value > dtpBLDate.Value Then
            dtpOPRDate.Focus()
            Result = Result & vbCrLf & "- OPR Date must be earlier than the OPO, Invoice or B/L/AWB Date"
        End If
        If Trim(txtOPONo.Text) = "" Then
            txtOPONo.Text = ""
            Result = Result & vbCrLf & "-  OPO Number"
        Else
            If OPO.IsMatch(Trim(txtOPONo.Text)) = False Then
                Result = Result & vbCrLf & "-  OPO Number is not valid" & vbCrLf & "   Format: OPO-00-XXX-000      eg.: OPO-111-ADG-0016"
            End If
        End If
        If dtpOPODate.Value < dtpOPRDate.Value Or dtpOPODate.Value < dtpInvoiceDate.Value Or dtpOPODate.Value < dtpBLDate.Value Then
            dtpOPODate.Focus()
            Result = Result & vbCrLf & "- OPO Date must be later than the OPR, Invoice and B/L/AWB Date"
        End If
        If Trim(txtInvoiceNo.Text) = "" Then
            txtInvoiceNo.Text = ""
            Result = Result & vbCrLf & "-  Invoice Number"
        Else
            If Invoice.IsMatch(Trim(txtInvoiceNo.Text)) = False Then
                Result = Result & vbCrLf & "-  Invoice Number is not valid" & vbCrLf & "   Format: N-000      eg.: N-0016"
            End If
        End If
        If dtpInvoiceDate.Value < dtpOPRDate.Value Or dtpInvoiceDate.Value > dtpOPODate.Value Or dtpInvoiceDate.Value > dtpBLDate.Value Then
            dtpInvoiceDate.Focus()
            Result = Result & vbCrLf & "- Invoice Date must be later the OPR Date and earlier than the OPO and B/L/AWB Date"
        End If
        If Trim(txtBLNo.Text) = "" Then
            txtBLNo.Text = ""
            Result = Result & vbCrLf & "-  B/L/AWB Number"
        Else
            If BLAWB.IsMatch(Trim(txtBLNo.Text)) = False Then
                Result = Result & vbCrLf & "-  B/L/AWB Number is not valid" & vbCrLf & "   Format: B-000      eg.: B-1016"
            End If
        End If
        If dtpBLDate.Value < dtpOPRDate.Value Or dtpBLDate.Value < dtpInvoiceDate.Value Or dtpBLDate.Value > dtpOPODate.Value Then
            dtpBLDate.Focus()
            Result = Result & vbCrLf & "- B/L/AWB Date must be later than the OPR and Invoice Date and earlier than the OPO Date"
        End If
        If Trim(txtAGL.Text) = "" Then
            txtAGL.Text = ""
            Result = Result & vbCrLf & "-  AGLPO Number"
        Else
            If AGL.IsMatch(Trim(txtAGL.Text)) = False Then
                Result = Result & vbCrLf & "-  AGLPO Number is not valid" & vbCrLf & "   Format: AGL-000      eg.: AGL-31475"
            End If
        End If
        If Trim(txtLPO.Text) = "" Then
            txtLPO.Text = ""
            Result = Result & vbCrLf & "-  LPO Number"
        Else
            If LPO.IsMatch(Trim(txtLPO.Text)) = False Then
                Result = Result & vbCrLf & "-  LPO Number is not valid" & vbCrLf & "   Format: LPO-000      eg.: LPO-5017"
            End If
        End If
        If dgvQuotation.RowCount < 2 Then
            Result = Result & vbCrLf & "-  Enter at least one item in the quotation list"
        End If
        If Trim(txtFreight.Text) = "" Then
            txtFreight.Text = ""
            Result = Result & vbCrLf & "-  Freight Charges"
        Else
            If IsNumeric(Trim(txtFreight.Text)) = False Then
                Result = Result & vbCrLf & "-  Freight Charges are not valid" & vbCrLf & "   Freight Charge value must be in numeric format"
            Else
                If txtFreight.Text < 0 Then
                    Result = Result & vbCrLf & "-  Freight Charges are not valid" & vbCrLf & "   Freight Charge value must be greater than or equal to 0"
                End If
            End If
        End If
        If Trim(txtFOB.Text) = "" Then
            txtFOB.Text = ""
            Result = Result & vbCrLf & "-  FOB Charges"
        Else
            If IsNumeric(Trim(txtFOB.Text)) = False Then
                Result = Result & vbCrLf & "-  FOB Charges are not valid" & vbCrLf & "   FOB Charge value must be in numeric format"
            Else
                If txtFOB.Text < 0 Then
                    Result = Result & vbCrLf & "-  FOB Charges are not valid" & vbCrLf & "   FOB Charge value must be greater than or equal to 0"
                End If
            End If
        End If
        If Trim(txtCommission.Text) = "" Then
            txtCommission.Text = ""
            Result = Result & vbCrLf & "-  Commission Duties"
        Else
            If IsNumeric(Trim(txtCommission.Text)) = False Then
                Result = Result & vbCrLf & "-  Commission Duties are not valid" & vbCrLf & "   Commission Duties value must be in numeric format"
            Else
                If txtCommission.Text < 0 Then
                    Result = Result & vbCrLf & "-  Commission Duties are not valid" & vbCrLf & "   Commission Duties value must be greater than or equal to 0"
                End If
            End If
        End If
        If Trim(txtSupplier.Text) = "" Then
            txtSupplier.Text = ""
            Result = Result & vbCrLf & "-  Supplier Name"
        End If
        If Trim(txtComment.Text) = "" Then
            txtComment.Text = ""
            Result = Result & vbCrLf & "-  Comments for the OPO"
        End If
        Return Result
    End Function

    Public Function Quotation_Validation() As String
        Dim Result As String = ""
        For Each Row As DataGridViewRow In dgvQuotation.Rows
            If Row.Cells(0).Value = Nothing Then
                Row.Cells(0).Value = ""
            End If
            If Row.Cells(1).Value = Nothing Then
                Row.Cells(1).Value = ""
            End If
            If Row.Cells(2).Value = Nothing Then
                Row.Cells(2).Value = ""
            End If
            If Row.Cells(3).Value = Nothing Then
                Row.Cells(3).Value = ""
            End If
            If Row.Cells(4).Value = Nothing Then
                Row.Cells(4).Value = ""
            End If
            If Not Row.IsNewRow Then
                If IsDBNull(Row.Cells(0).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(0).Value.ToString())) Then
                    Row.Cells(0).Style.BackColor = Color.LightPink
                    Row.Cells(0).Value = ""
                    Result = "Error"
                Else
                    Row.Cells(0).Style.BackColor = Color.Empty
                End If
                If IsDBNull(Row.Cells(1).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(1).Value.ToString())) Then
                    Row.Cells(1).Style.BackColor = Color.LightPink
                    Row.Cells(1).Value = ""
                    Result = "Error"
                Else
                    If Not Number.IsMatch(Row.Cells(1).Value) Then
                        Row.Cells(1).Style.BackColor = Color.LightPink
                        Result = "Error"
                    Else
                        If Row.Cells(1).Value <= 0 Then
                            Row.Cells(1).Style.BackColor = Color.LightPink
                            Result = "Error"
                        Else
                            Row.Cells(1).Style.BackColor = Color.Empty
                        End If
                    End If
                End If
                If IsDBNull(Row.Cells(2).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(2).Value.ToString())) Then
                    Row.Cells(2).Style.BackColor = Color.LightPink
                    Row.Cells(2).Value = ""
                    Result = "Error"
                Else
                    Row.Cells(2).Style.BackColor = Color.Empty
                End If
                If IsDBNull(Row.Cells(3).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(3).Value.ToString())) Then
                    Row.Cells(3).Style.BackColor = Color.LightPink
                    Row.Cells(3).Value = ""
                    Result = "Error"
                Else
                    If Not Number.IsMatch(Row.Cells(3).Value) Then
                        Row.Cells(3).Style.BackColor = Color.LightPink
                        Result = "Error"
                    Else
                        If Row.Cells(3).Value < 0 Then
                            Row.Cells(3).Style.BackColor = Color.LightPink
                            Result = "Error"
                        Else
                            Row.Cells(3).Style.BackColor = Color.Empty
                        End If
                    End If
                End If
                If IsDBNull(Row.Cells(4).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(4).Value.ToString())) Then
                    Row.Cells(4).Style.BackColor = Color.LightPink
                    Row.Cells(4).Value = ""
                    Result = "Error"
                Else
                    Row.Cells(4).Style.BackColor = Color.Empty
                End If
            End If
        Next
        Return Result
    End Function

    Public Sub OPRNO()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim OPRAutosuggestion As New AutoCompleteStringCollection()
                Cmd.Connection = Con
                Cmd.CommandText = "SELECT OPR_No FROM OPO"
                DR = Cmd.ExecuteReader()
                While DR.Read()
                    OPRAutosuggestion.Add(Trim(DR.GetValue(0)))
                End While
                DR.Close()
                txtOPRNo.AutoCompleteCustomSource = OPRAutosuggestion
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
            If DR.Read() Then
                DR.Close()
            End If
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub Supplier()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim SupplierAutosuggestion As New AutoCompleteStringCollection()
                Cmd.Connection = Con
                Cmd.CommandText = "SELECT Name FROM Supplier"
                DR = Cmd.ExecuteReader()
                While DR.Read()
                    SupplierAutosuggestion.Add(Trim(DR.GetValue(0)))
                End While
                DR.Close()
                txtSupplier.AutoCompleteCustomSource = SupplierAutosuggestion
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
            If DR.Read() Then
                DR.Close()
            End If
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub UnitAutoSuggestion()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Unit.AddRange(New String() {"Meters", "Kilometers", "Grams", "Kilograms", "Nos", "Lots", "Sets", "Boxes", "Amperes", _
                                            "Kelvins", "Moles", "Candelas", "Square Meters", "Cubic Meters", "Meters per Second", _
                                            "Meters per Second Square", "Radians", "Hertzs", "Newtons", "Pascals", "Joules", "Watts", _
                                            "Coloumbs", "Volts", "Farads", "Ohms"})
                Cmd.Connection = Con
                Cmd.CommandText = "SELECT DISTINCT(Unit) FROM Quotation"
                DR = Cmd.ExecuteReader()
                While DR.Read()
                    If Not Unit.Contains(DR.GetValue(0)) Then
                        Unit.Add(DR.GetValue(0).ToString)
                    End If
                End While
                DR.Close()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
            If DR.Read() Then
                DR.Close()
            End If
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub CurrencyAutoSuggestion()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Currency.AddRange(New String() {"Abkhazian Apsar", "Afghan Afghani", "Algerian Dinar", "US Dollar", "South African Rand", _
                                                "Euro", "British Pound", "Australian dollar", "West African CFA Franc", "Tanzanian Shilling", _
                                                "Syrian Pound", "Swiss Franc", "Russian Ruble", "Sri Lankan Rupee", "Somaliland Shilling", _
                                                "Chinese Yuan", "Hong Kong Dollar", "Somali Shilling", "Japanese Yen", "North Korean Won", "South Korean Won", _
                                                "Kuwaiti Dinar", "Indian Rupee", "Malaysian Ringgit", "Peso", "Pound", "Krone", "Ruble", _
                                                "Franc", "Shilling", "Dinar", "Manat", "Som", "Won", "Dirham"})
                Cmd.Connection = Con
                Cmd.CommandText = "SELECT DISTINCT(Currency) FROM Quotation"
                DR = Cmd.ExecuteReader()
                While DR.Read()
                    If Not Currency.Contains(DR.GetValue(0)) Then
                        Currency.Add(DR.GetValue(0).ToString)
                    End If
                End While
                DR.Close()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
            If DR.Read() Then
                DR.Close()
            End If
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub Total()
        Try
            Dim Total As Double = 0
            Dim Quantity, Price As Double
            Dim Result As String = ""
            For Each Row As DataGridViewRow In dgvQuotation.Rows
                If Row.Cells(1).Value = Nothing Then
                    Row.Cells(1).Value = ""
                End If
                If Row.Cells(3).Value = Nothing Then
                    Row.Cells(3).Value = ""
                End If
                If Not Row.IsNewRow Then
                    If IsDBNull(Row.Cells(1).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(1).Value.ToString())) Then
                        Row.Cells(1).Style.BackColor = Color.LightPink
                        Row.Cells(1).Value = ""
                        Result = "Error"
                    Else
                        If Not Number.IsMatch(Row.Cells(1).Value) Then
                            Row.Cells(1).Style.BackColor = Color.LightPink
                            Result = "Error"
                        Else
                            If Row.Cells(1).Value <= 0 Then
                                Row.Cells(1).Style.BackColor = Color.LightPink
                                Result = "Error"
                            Else
                                Row.Cells(1).Style.BackColor = Color.Empty
                                Quantity = Row.Cells(1).Value
                            End If
                        End If
                    End If
                    If IsDBNull(Row.Cells(3).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(3).Value.ToString())) Then
                        Row.Cells(3).Style.BackColor = Color.LightPink
                        Row.Cells(3).Value = ""
                        Result = "Error"
                    Else
                        If Not Number.IsMatch(Row.Cells(3).Value) Then
                            Row.Cells(3).Style.BackColor = Color.LightPink
                            Result = "Error"
                        Else
                            If Row.Cells(3).Value < 0 Then
                                Row.Cells(3).Style.BackColor = Color.LightPink
                                Result = "Error"
                            Else
                                Row.Cells(3).Style.BackColor = Color.Empty
                                Price = Row.Cells(3).Value
                            End If
                        End If
                    End If
                    If Result = "" Then
                        Total = Total + (Quantity * Price)
                    Else
                        Exit For
                    End If
                End If
            Next
            txtTotal.Text = Total.ToString("00.00")
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Grand()
        Try
            Dim Freight, FOB, Commission As Double
            Dim Result As String = ""
            If Trim(txtFreight.Text) = "" Then
                txtFreight.Text = "0"
            End If
            If Trim(txtFOB.Text) = "" Then
                txtFOB.Text = "0"
            End If
            If Trim(txtCommission.Text) = "" Then
                txtCommission.Text = "0"
            End If
            If Not Number.IsMatch(Trim(txtFreight.Text)) Then
                txtFreight.BackColor = Color.LightPink
                Result = "Error"
            Else
                Freight = txtFreight.Text
                txtFreight.BackColor = Color.Ivory
                If Not Number.IsMatch(Trim(txtFOB.Text)) Then
                    txtFOB.BackColor = Color.LightPink
                    Result = "Error"
                Else
                    FOB = txtFOB.Text
                    txtFOB.BackColor = Color.Ivory
                    If Not Number.IsMatch(Trim(txtCommission.Text)) Then
                        txtCommission.BackColor = Color.LightPink
                        Result = "Error"
                    Else
                        Commission = txtCommission.Text
                        txtCommission.BackColor = Color.Ivory
                    End If
                End If
            End If
            If Result = "" Then
                txtGrand.Text = (CDbl(txtTotal.Text) + Freight + FOB + ((Commission / 100) * CDbl(txtTotal.Text))).ToString("00.00")
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Show_Attachment()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Name As String = lsvAttachment.SelectedItems(0).SubItems(0).Text.ToString
                Cmd.Connection = Con
                Cmd.CommandText = "SELECT FContent FROM Attachment WHERE FName = @Name AND ID = @ID"
                Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = Name
                Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                Dim Data As Byte() = DirectCast(Cmd.ExecuteScalar(), Byte())
                Dim Temp As String = Application.StartupPath & "\" & Name
                MsgBox(Temp)
                If Not Data Is Nothing Then
                    Using FS As New FileStream(Name, FileMode.OpenOrCreate, FileAccess.Write)
                        FS.Write(Data, 0, Data.Length)
                        FS.Flush()
                        FS.Close()
                    End Using
                    Process.Start(Name)
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Function OPO_Search() As Boolean
        Dim Result As Boolean
        If Trim(txtOPRNo.Text) = "" Then
            txtOPRNo.Text = ""
            MsgBox("Plase, enter OPR Number.", MsgBoxStyle.Critical, Title)
            txtOPRNo.Focus()
        Else
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "SELECT ID FROM OPO WHERE OPR_No = @OPRN"
                        Cmd.Parameters.Add(New SqlParameter("@OPRN", SqlDbType.Char)).Value = txtOPRNo.Text
                        Search = Cmd.ExecuteScalar()
                        Cmd.Parameters.Clear()
                        If Search <> 0 Then
                            Result = True
                        Else
                            Result = False
                            MsgBox("Sorry, OPO details not found", MsgBoxStyle.Information, Title)
                            OPO_Reset()
                            OPO_ReadOnly()
                            txtOPRNo.Enabled = True
                            txtOPRNo.Focus()
                            btnSearch.Enabled = True
                            Me.AcceptButton = btnSearch
                            btnSave.Text = "Edit Details"
                            btnReset.Text = "Restore Details"
                        End If
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
        Return Result
    End Function

    Public Sub OPO_Load()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Load As SqlTransaction
                Load = Con.BeginTransaction
                Cmd.Connection = Con
                Cmd.Transaction = Load
                Try
                    Cmd.CommandText = "SELECT O.OPR_No, O.OPR_Date, O.OPO_No, O.OPO_Date, O.Invoice_No, O.Invoice_Date, O.BL_No, O.BL_Date, O.AGLPO, O.LPO, O.Total, O.Freight, O.FOB, O.Commission, O.Grand, S.Name, O.Comment FROM OPO O, Supplier S WHERE O.ID = @ID AND S.ID = (SELECT Supplier FROM OPO WHERE ID = @ID)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                    DR = Cmd.ExecuteReader()
                    If DR.Read() Then
                        txtOPRNo.Text = DR.GetValue(0)
                        dtpOPRDate.Text = DR.GetValue(1)
                        txtOPONo.Text = DR.GetValue(2)
                        dtpOPODate.Text = DR.GetValue(3)
                        txtInvoiceNo.Text = DR.GetValue(4)
                        dtpInvoiceDate.Text = DR.GetValue(5)
                        txtBLNo.Text = DR.GetValue(6)
                        dtpBLDate.Text = DR.GetValue(7)
                        txtAGL.Text = DR.GetValue(8)
                        txtLPO.Text = DR.GetValue(9)
                        txtTotal.Text = DR.GetValue(10)
                        txtFreight.Text = DR.GetValue(11)
                        txtFOB.Text = DR.GetValue(12)
                        txtCommission.Text = DR.GetValue(13)
                        txtGrand.Text = DR.GetValue(14)
                        txtSupplier.Text = DR.GetValue(15)
                        txtComment.Text = DR.GetValue(16)
                        DR.Close()
                        Cmd.Parameters.Clear()
                        Cmd.CommandText = "SELECT Items, Quantity, Unit, Price, Currency FROM Quotation WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                        DA = New SqlDataAdapter(Cmd)
                        DS = New DataSet
                        DA.Fill(DS, "Quotation")
                        dgvQuotation.DataSource = DS
                        dgvQuotation.DataMember = "Quotation"
                        Cmd.Parameters.Clear()
                        For Each Row As DataGridViewRow In dgvQuotation.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        Dim Temp As New DataGridView()
                        If Not dgvQuotation.DataSource.Equals(Nothing) Then
                            Try
                                If Temp.Columns.Count = 0 Then
                                    For Each Col As DataGridViewColumn In dgvQuotation.Columns
                                        Temp.Columns.Add(TryCast(Col.Clone(), DataGridViewColumn))
                                    Next
                                End If
                                Dim Copy As New DataGridViewRow()
                                For Each Row As DataGridViewRow In dgvQuotation.Rows
                                    If Not Row.IsNewRow Then
                                        Copy = DirectCast(Row.Clone(), DataGridViewRow)
                                        Dim CIndex As Integer = 0
                                        For Each Cell As DataGridViewCell In Row.Cells
                                            Copy.Cells(CIndex).Value = Cell.Value
                                            CIndex = CIndex + 1
                                        Next
                                        Temp.Rows.Add(Copy)
                                    End If
                                Next
                                dgvQuotation.DataSource = Nothing
                                dgvQuotation.Rows.Clear()
                                If dgvQuotation.Columns.Count = 0 Then
                                    For Each Col As DataGridViewColumn In Temp.Columns
                                        dgvQuotation.Columns.Add(TryCast(Col.Clone(), DataGridViewColumn))
                                    Next
                                End If
                                Dim Original As New DataGridViewRow()
                                For Each Row As DataGridViewRow In Temp.Rows
                                    If Not Row.IsNewRow Then
                                        Original = DirectCast(Row.Clone(), DataGridViewRow)
                                        Dim CIndex As Integer = 0
                                        For Each Cell As DataGridViewCell In Row.Cells
                                            Original.Cells(CIndex).Value = Cell.Value
                                            CIndex += 1
                                        Next
                                        dgvQuotation.Rows.Add(Original)
                                    End If
                                Next
                                Temp.DataSource = Nothing
                                Temp.Rows.Clear()
                            Catch Ex As Exception
                                MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                            End Try
                        End If
                        Cmd.CommandText = "SELECT FName FROM Attachment WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                        DR = Cmd.ExecuteReader()
                        While DR.Read()
                            Dim FName As String = DR.GetValue(0)
                            lsvAttachment.Items.Add(FName)
                        End While
                        DR.Close()
                        Load.Commit()
                        OPO_ReadOnly()
                        txtOPRNo.Enabled = True
                        btnSearch.Enabled = True
                        Me.AcceptButton = btnSave
                        btnSave.Text = "Edit Details"
                        btnSave.Enabled = True
                        btnReset.Text = "Restore Details"
                    End If
                Catch Ex As Exception
                    If DR.Read() Then
                        DR.Close()
                    End If
                    Load.Rollback()
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    Cmd.Parameters.Clear()
                    Load.Dispose()
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub OPO_Save()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Save As SqlTransaction = Con.BeginTransaction("Save")
                Cmd.Connection = Con
                Cmd.Transaction = Save
                Try
                    Cmd.CommandText = "SELECT ID FROM Supplier WHERE Name = @Name"
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtSupplier.Text
                    Dim SID As Integer = Cmd.ExecuteScalar()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO OPO(OPR_No, OPR_Date, OPO_No, OPO_Date, Invoice_No, Invoice_Date, BL_No, BL_Date, AGLPO, LPO, Total, Freight, FOB, Commission, Grand, Supplier, Comment, CID, CB, CD) VALUES(@OPRN, @OPRD, @OPON, @OPOD, @INN, @IND, @BLN, @BLD, @AGL, @LPO, @Total, @Freight, @FOB, @Commission, @Grand, @Supplier, @Comment, @CID, @CB, @CD)"
                    Cmd.Parameters.Add(New SqlParameter("@OPRN", SqlDbType.Char)).Value = txtOPRNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPRD", SqlDbType.Date)).Value = dtpOPRDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPON", SqlDbType.Char)).Value = txtOPONo.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPOD", SqlDbType.Date)).Value = dtpOPODate.Text
                    Cmd.Parameters.Add(New SqlParameter("@INN", SqlDbType.Char)).Value = txtInvoiceNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@IND", SqlDbType.Date)).Value = dtpInvoiceDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@BLN", SqlDbType.Char)).Value = txtBLNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@BLD", SqlDbType.Date)).Value = dtpBLDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@AGL", SqlDbType.Char)).Value = txtAGL.Text
                    Cmd.Parameters.Add(New SqlParameter("@LPO", SqlDbType.Char)).Value = txtLPO.Text
                    Cmd.Parameters.Add(New SqlParameter("@Total", SqlDbType.Money)).Value = txtTotal.Text
                    Cmd.Parameters.Add(New SqlParameter("@Freight", SqlDbType.SmallMoney)).Value = txtFreight.Text
                    Cmd.Parameters.Add(New SqlParameter("@FOB", SqlDbType.SmallMoney)).Value = txtFOB.Text
                    Cmd.Parameters.Add(New SqlParameter("@Commission", SqlDbType.TinyInt)).Value = txtCommission.Text
                    Cmd.Parameters.Add(New SqlParameter("@Grand", SqlDbType.Money)).Value = txtGrand.Text
                    Cmd.Parameters.Add(New SqlParameter("@Supplier", SqlDbType.TinyInt)).Value = SID
                    Cmd.Parameters.Add(New SqlParameter("@Comment", SqlDbType.NVarChar)).Value = txtComment.Text
                    Cmd.Parameters.Add(New SqlParameter("@CID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    Cmd.Parameters.Add(New SqlParameter("@CB", SqlDbType.VarChar)).Value = frmEPanel.Employee
                    Cmd.Parameters.Add(New SqlParameter("@CD", SqlDbType.DateTime)).Value = Now
                    Cmd.ExecuteNonQuery()
                    Cmd.CommandText = "SELECT TOP 1 ID FROM OPO ORDER BY ID DESC"
                    Dim OPO As Integer = Cmd.ExecuteScalar()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Quotation(ID, Items, Quantity, Unit, Price, Currency) VALUES(@ID, @Items, @Quantity, @Unit, @Price, @Currency)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int))
                    Cmd.Parameters.Add(New SqlParameter("@Items", SqlDbType.NVarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Quantity", SqlDbType.Decimal))
                    Cmd.Parameters.Add(New SqlParameter("@Unit", SqlDbType.NVarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Price", SqlDbType.Money))
                    Cmd.Parameters.Add(New SqlParameter("@Currency", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvQuotation.Rows
                        If Not Row.IsNewRow Then
                            Cmd.Parameters("@ID").Value = OPO
                            Cmd.Parameters("@Items").Value = Row.Cells(0).Value
                            Cmd.Parameters("@Quantity").Value = Row.Cells(1).Value
                            Cmd.Parameters("@Unit").Value = Row.Cells(2).Value
                            Cmd.Parameters("@Price").Value = Row.Cells(3).Value
                            Cmd.Parameters("@Currency").Value = Row.Cells(4).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    Dim Path, Name, Extension As String
                    Dim Size As Long
                    Dim Content As Byte() = Nothing
                    For Each File As ListViewItem In lsvAttachment.Items
                        Path = File.SubItems(0).Text
                        Extension = System.IO.Path.GetExtension(Path)
                        Name = System.IO.Path.GetFileName(Path)
                        Dim FInfo As New FileInfo(Path)
                        Size = FInfo.Length
                        Dim FStream As New FileStream(Path, FileMode.Open, FileAccess.Read)
                        Dim BR As New BinaryReader(FStream)
                        Content = BR.ReadBytes(CInt(Size))
                        Cmd.CommandText = "INSERT INTO Attachment(ID, FName, FType, FContent) VALUES(@ID, @FName, @FType, @FContent)"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = OPO
                        Cmd.Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar)).Value = Name
                        Cmd.Parameters.Add(New SqlParameter("@FType", SqlDbType.VarChar)).Value = Extension
                        Cmd.Parameters.Add(New SqlParameter("@FContent", DirectCast(Content, Object)))
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        File.ForeColor = Color.DodgerBlue
                    Next
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "SELECT * FROM Attachment A ORDER BY A.ID, A.FType"
                    Cmd.ExecuteNonQuery()
                    Cmd.CommandText = "DELETE FROM Attachment WHERE Attachment.%%physloc%% NOT IN(SELECT MIN(B.%%physloc%%) FROM Attachment B GROUP BY B.ID, B.FName)"
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    MsgBox("The OPO Details saved successfully.", MsgBoxStyle.Information, Title)
                    Save.Commit()
                    OPO_Reset()
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_OPO_OPR") Then
                        MsgBox("The OPR Number is already present in the database. Please, enter different OPR Number.", MsgBoxStyle.Critical, Title)
                        txtOPRNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_OPO") Then
                        MsgBox("The OPO Number is already present in the database. Please, enter different OPO Number.", MsgBoxStyle.Critical, Title)
                        txtOPONo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_INVOICE") Then
                        MsgBox("The Invoice Number is already present in the database. Please, enter different Invoice Number.", MsgBoxStyle.Critical, Title)
                        txtInvoiceNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_BLAWB") Then
                        MsgBox("The B\L\AWB Number is already present in the database. Please, enter different B\L\AWB Number.", MsgBoxStyle.Critical, Title)
                        txtBLNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_AGLPO") Then
                        MsgBox("The AGLPO Number is already present in the database. Please, enter different AGLPO Number.", MsgBoxStyle.Critical, Title)
                        txtAGL.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_LPO") Then
                        MsgBox("The LPO Number is already present in the database. Please, enter different LPO Number.", MsgBoxStyle.Critical, Title)
                        txtLPO.Focus()
                    ElseIf Ex.Message.Contains("FK_OPO_Supplier_ID") Then
                        MsgBox("Specified Supplier Details are not found in database." & vbCrLf & "Please, first enter Supplier Details to save OPR Details.", MsgBoxStyle.Critical, Title)
                        If frmSupplier.Visible Then
                            frmSupplier.Close()
                        End If
                        frmSupplier.txtName.Text = txtSupplier.Text
                        frmSupplier.WindowState = FormWindowState.Maximized
                        frmSupplier.MdiParent = frmEPanel
                        frmSupplier.Show()
                    ElseIf Ex.Message.Contains("FK_Quotation_OPO_ID") Then
                        MsgBox("The OPO details are not present in the database for the specified Quotation details." & vbCrLf & "Please, first enter OPO details to save Quotation.", MsgBoxStyle.Critical, Title)
                        dgvQuotation.Focus()
                    ElseIf Ex.Message.Contains("FK_Attachment_OPO_ID") Then
                        MsgBox("The OPO Details are not present in the database for the specified Attachment details." & vbCrLf & "Please, first enter OPO details to save Attachments.", MsgBoxStyle.Critical, Title)
                        lsvAttachment.Focus()
                    Else
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
                    Save.Rollback()
                Finally
                    Cmd.Parameters.Clear()
                    Save.Dispose()
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub OPO_Update()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Update As SqlTransaction
                Update = Con.BeginTransaction
                Cmd.Connection = Con
                Cmd.Transaction = Update
                Try
                    Cmd.CommandText = "UPDATE OPO SET OPR_No = @OPRN, OPR_Date = @OPRD, OPO_No = @OPON, OPO_Date = @OPOD, Invoice_No = @INN, Invoice_Date = @IND, BL_No = @BLN, BL_Date = @BLD, AGLPO = @AGL, LPO = @LPO, Total = @Total, Freight = @Freight, FOB = @FOB, Commission = @Commission, Grand = @Grand, Supplier = (SELECT ID FROM Supplier WHERE Name = LTRIM(RTRIM(@Supplier))), Comment = @Comment, EID = @EID, EB = @EB, ED = @ED WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@OPRN", SqlDbType.Char)).Value = txtOPRNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPRD", SqlDbType.Date)).Value = dtpOPRDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPON", SqlDbType.Char)).Value = txtOPONo.Text
                    Cmd.Parameters.Add(New SqlParameter("@OPOD", SqlDbType.Date)).Value = dtpOPODate.Text
                    Cmd.Parameters.Add(New SqlParameter("@INN", SqlDbType.Char)).Value = txtInvoiceNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@IND", SqlDbType.Date)).Value = dtpInvoiceDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@BLN", SqlDbType.Char)).Value = txtBLNo.Text
                    Cmd.Parameters.Add(New SqlParameter("@BLD", SqlDbType.Date)).Value = dtpBLDate.Text
                    Cmd.Parameters.Add(New SqlParameter("@AGL", SqlDbType.Char)).Value = txtAGL.Text
                    Cmd.Parameters.Add(New SqlParameter("@LPO", SqlDbType.Char)).Value = txtLPO.Text
                    Cmd.Parameters.Add(New SqlParameter("@Total", SqlDbType.Money)).Value = txtTotal.Text
                    Cmd.Parameters.Add(New SqlParameter("@Freight", SqlDbType.SmallMoney)).Value = txtFreight.Text
                    Cmd.Parameters.Add(New SqlParameter("@FOB", SqlDbType.SmallMoney)).Value = txtFOB.Text
                    Cmd.Parameters.Add(New SqlParameter("@Commission", SqlDbType.TinyInt)).Value = txtCommission.Text
                    Cmd.Parameters.Add(New SqlParameter("@Grand", SqlDbType.Money)).Value = txtGrand.Text
                    Cmd.Parameters.Add(New SqlParameter("@Supplier", SqlDbType.VarChar)).Value = txtSupplier.Text
                    Cmd.Parameters.Add(New SqlParameter("@Comment", SqlDbType.NVarChar)).Value = txtComment.Text
                    Cmd.Parameters.Add(New SqlParameter("@EID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    Cmd.Parameters.Add(New SqlParameter("@EB", SqlDbType.VarChar)).Value = frmEPanel.Employee
                    Cmd.Parameters.Add(New SqlParameter("@ED", SqlDbType.DateTime)).Value = Now
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "DELETE FROM Quotation WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Quotation(ID, Items, Quantity, Unit, Price, Currency) VALUES(@ID, @Items, @Quantity, @Unit, @Price, @Currency)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int))
                    Cmd.Parameters.Add(New SqlParameter("@Items", SqlDbType.NVarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Quantity", SqlDbType.Decimal))
                    Cmd.Parameters.Add(New SqlParameter("@Unit", SqlDbType.NVarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Price", SqlDbType.Money))
                    Cmd.Parameters.Add(New SqlParameter("@Currency", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvQuotation.Rows
                        If Not Row.IsNewRow Then
                            Cmd.Parameters("@ID").Value = Search
                            Cmd.Parameters("@Items").Value = Row.Cells(0).Value
                            Cmd.Parameters("@Quantity").Value = Row.Cells(1).Value
                            Cmd.Parameters("@Unit").Value = Row.Cells(2).Value
                            Cmd.Parameters("@Price").Value = Row.Cells(3).Value
                            Cmd.Parameters("@Currency").Value = Row.Cells(4).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    Dim Path, Name, Extension As String
                    Dim Size As Long
                    Dim Content As Byte() = Nothing
                    For Each File As ListViewItem In lsvAttachment.Items
                        Path = File.SubItems(0).Text
                        Extension = System.IO.Path.GetExtension(Path)
                        Name = System.IO.Path.GetFileName(Path)
                        Dim FInfo As New FileInfo(Path)
                        Try
                            Size = FInfo.Length
                        Catch
                            Continue For
                        End Try
                        Dim FStream As New FileStream(Path, FileMode.Open, FileAccess.Read)
                        Dim BR As New BinaryReader(FStream)
                        Content = BR.ReadBytes(CInt(Size))
                        Cmd.CommandText = "INSERT INTO Attachment(ID, FName, FType, FContent) VALUES(@ID, @FName, @FType, @FContent)"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                        Cmd.Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar)).Value = Name
                        Cmd.Parameters.Add(New SqlParameter("@FType", SqlDbType.VarChar)).Value = Extension
                        Cmd.Parameters.Add(New SqlParameter("@FContent", DirectCast(Content, Object)))
                        Try
                            Cmd.ExecuteNonQuery()
                        Catch Ex As SqlException
                            Continue For
                        Finally
                            Cmd.Parameters.Clear()
                            File.ForeColor = Color.DodgerBlue
                        End Try
                    Next
                    Cmd.Parameters.Clear()
                    Dim Data As New ArrayList
                    Cmd.CommandText = "SELECT FName FROM Attachment WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        Data.Add(DR.GetValue(0).ToString)
                    End While
                    DR.Close()
                    Cmd.Parameters.Clear()
                    Dim Attach As New ArrayList
                    For Each Row As ListViewItem In lsvAttachment.Items
                        Attach.Add(System.IO.Path.GetFileName(Row.SubItems(0).Text.ToString))
                    Next
                    For Each File In Data
                        If Not Attach.Contains(File) Then
                            Cmd.CommandText = "DELETE FROM Attachment WHERE FName = @Removed AND ID = @ID"
                            Cmd.Parameters.Add(New SqlParameter("@Removed", SqlDbType.VarChar)).Value = File
                            Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = Search
                            Cmd.ExecuteNonQuery()
                            Cmd.Parameters.Clear()
                        End If
                    Next
                    Cmd.CommandText = "SELECT * FROM Attachment A ORDER BY A.ID, A.FType"
                    Cmd.ExecuteNonQuery()
                    Cmd.CommandText = "DELETE FROM Attachment WHERE Attachment.%%physloc%% NOT IN(SELECT MIN(B.%%physloc%%) FROM Attachment B GROUP BY B.ID, B.FName)"
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Update.Commit()
                    MsgBox("The OPO Details updated successfully.", MsgBoxStyle.Information, Title)
                    OPO_Reset()
                    OPO_ReadOnly()
                    txtOPRNo.Enabled = True
                    txtOPRNo.Focus()
                    btnSearch.Enabled = True
                    btnSave.Text = "Edit Details"
                    btnReset.Text = "Restore Details"
                    If Me.Text <> "Edit OPO Details" Then
                        Me.Close()
                    End If
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_OPO_OPR") Then
                        MsgBox("The OPR Number is already present in the database. Please, enter different OPR Number.", MsgBoxStyle.Critical, Title)
                        txtOPRNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_OPO") Then
                        MsgBox("The OPO Number is already present in the database. Please, enter different OPO Number.", MsgBoxStyle.Critical, Title)
                        txtOPONo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_INVOICE") Then
                        MsgBox("The Invoice Number is already present in the database. Please, enter different Invoice Number.", MsgBoxStyle.Critical, Title)
                        txtInvoiceNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_BLAWB") Then
                        MsgBox("The B\L\AWB Number is already present in the database. Please, enter different B\L\AWB Number.", MsgBoxStyle.Critical, Title)
                        txtBLNo.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_AGLPO") Then
                        MsgBox("The AGLPO Number is already present in the database. Please, enter different AGLPO Number.", MsgBoxStyle.Critical, Title)
                        txtAGL.Focus()
                    ElseIf Ex.Message.Contains("UK_OPO_LPO") Then
                        MsgBox("The LPO Number is already present in the database. Please, enter different LPO Number.", MsgBoxStyle.Critical, Title)
                        txtLPO.Focus()
                    ElseIf Ex.Message.Contains("FK_OPO_Supplier_ID") Then
                        MsgBox("Specified Supplier Details are not found in database." & vbCrLf & "Please, first enter Supplier Details to save OPR Details.", MsgBoxStyle.Critical, Title)
                        If frmSupplier.Visible Then
                            frmSupplier.Close()
                        End If
                        frmSupplier.txtName.Text = txtSupplier.Text
                        frmSupplier.WindowState = FormWindowState.Maximized
                        frmSupplier.MdiParent = frmEPanel
                        frmSupplier.Show()
                    ElseIf Ex.Message.Contains("FK_Quotation_OPO_ID") Then
                        MsgBox("The OPO details are not present in the database for the specified Quotation details." & vbCrLf & "Please, first enter OPO details to save Quotation.", MsgBoxStyle.Critical, Title)
                        dgvQuotation.Focus()
                    ElseIf Ex.Message.Contains("FK_Attachment_OPO_ID") Then
                        MsgBox("The OPO Details are not present in the database for the specified Attachment details." & vbCrLf & "Please, first enter OPO details to save Attachments.", MsgBoxStyle.Critical, Title)
                        lsvAttachment.Focus()
                    Else
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
                    Update.Rollback()
                Finally
                    Cmd.Parameters.Clear()
                    Update.Dispose()
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub frmOPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OPRNO()
        Supplier()
    End Sub

    Private Sub dgvQuotation_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvQuotation.RowEnter
        dgvQuotation.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub dgvQuotation_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvQuotation.DataError
        e.Cancel = False
    End Sub

    Private Sub dgvQuotation_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvQuotation.EditingControlShowing
        If dgvQuotation.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is TextBox Then
            UnitAutoSuggestion()
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteCustomSource = Unit
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        ElseIf dgvQuotation.CurrentCell.ColumnIndex = 4 AndAlso TypeOf e.Control Is TextBox Then
            CurrencyAutoSuggestion()
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteCustomSource = Currency
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        Else
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.None
            End With
        End If
    End Sub

    Private Sub lnkUpload_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpload.LinkClicked
        Attachment.CheckFileExists = True
        Attachment.Multiselect = False
        Attachment.ValidateNames = True
        Attachment.Title = "Agri Chemicals Limited - Upload Quotation Details"
        Attachment.Filter = Nothing
        Attachment.Filter = "Excel File(*.xlt, *.xls, *.xlsx) | *.xlt; *.xls; *.xlsx"
        If Attachment.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As New Excel.Application
            Dim xlWorkbook As Excel.Workbook
            Dim xlWorksheet As Excel.Worksheet
            Dim xlRange As Excel.Range
            Dim i As Integer
            Try
                xlWorkbook = GetObject(Attachment.FileName)
                xlWorksheet = xlWorkbook.Worksheets(1)
                xlRange = xlWorksheet.UsedRange
                Dim Item As Integer = dgvQuotation.NewRowIndex
                For i = 2 To xlRange.Rows.Count
                    dgvQuotation.RowCount = dgvQuotation.RowCount + 1
                    dgvQuotation.Rows(Item).Cells(0).Value = xlWorksheet.Cells(i, 2).value.ToString
                    dgvQuotation.Rows(Item).Cells(1).Value = xlWorksheet.Cells(i, 3).value.ToString
                    dgvQuotation.Rows(Item).Cells(2).Value = xlWorksheet.Cells(i, 4).value.ToString
                    dgvQuotation.Rows(Item).Cells(3).Value = xlWorksheet.Cells(i, 5).value.ToString
                    dgvQuotation.Rows(Item).Cells(4).Value = xlWorksheet.Cells(i, 6).value.ToString
                    Item = Item + 1
                Next
                GC.Collect()
                GC.WaitForPendingFinalizers()
                Marshal.FinalReleaseComObject(xlRange)
                Marshal.FinalReleaseComObject(xlWorksheet)
                xlWorkbook.Close(Type.Missing, Type.Missing, Type.Missing)
                Marshal.FinalReleaseComObject(xlWorkbook)
                xlApp.Quit()
                Marshal.FinalReleaseComObject(xlApp)
                For Each Row As DataGridViewRow In dgvQuotation.Rows
                    Row.HeaderCell.Value = CStr(Row.Index + 1)
                Next
            Catch Ex As Exception
                MsgBox(Ex.Message & Ex.StackTrace)
                dgvQuotation.DataSource = Nothing
                dgvQuotation.Rows.Clear()
                MsgBox("The selected quotation details file is not in proper format.", MsgBoxStyle.Critical, Title)
            End Try
        End If
    End Sub

    Private Sub lnkUnload_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUnload.LinkClicked
        If MessageBox.Show("Do you really want to unload the quotation?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            dgvQuotation.DataSource = Nothing
            dgvQuotation.Rows.Clear()
            txtTotal.Text = "0"
            txtFreight.Text = "0"
            txtFOB.Text = "0"
            txtCommission.Text = "0"
            txtGrand.Text = "0"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lnkExport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkExport.LinkClicked
        If dgvQuotation.RowCount < 2 Then
            MsgBox("There are not enough items to generate an Excel Sheet.", MsgBoxStyle.Critical, Title)
        Else
            If Quotation_Validation() = "" Then
                Dim Row, Col, i, j, Count As Short
                Dim xlApp As New Excel.Application
                Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add
                Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Worksheets(1), Excel.Worksheet)
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                xlApp.Visible = True
                Row = dgvQuotation.RowCount - 1
                Col = dgvQuotation.ColumnCount - 1
                Try
                    With xlWorksheet
                        .Cells.Select()
                        .Cells.Delete()
                        For Count = 0 To Col
                            .Cells(1, Count + 1).Value = dgvQuotation.Columns(Count).HeaderText
                        Next
                        For i = 0 To Row - 1
                            For j = 0 To Col
                                .Cells(i + 2, j + 1).Value = dgvQuotation.Rows(i).Cells(j).Value
                            Next j
                        Next i
                        .Rows("1:1").Font.FontStyle = "Bold"
                        .Rows("1:1").Font.Size = "12"
                        .Cells.Columns.AutoFit()
                        .Cells.Select()
                        .Cells.EntireColumn.AutoFit()
                        .Cells(1, 1).Select()
                        .Cells.Rows.AutoFit()
                        .Cells.EntireRow.AutoFit()
                    End With
                Catch Ex As Exception
                    MsgBox("Export Quotation to Excel Error" & vbCrLf & Ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                    xlApp = Nothing
                End Try
            Else
                MsgBox("Please, enter valid information in the highlighted field(s) of the Quotation details.", MsgBoxStyle.Critical, Title)
            End If
        End If
    End Sub

    Private Sub txtTotal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.GotFocus
        Total()
    End Sub

    Private Sub txtGrand_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrand.GotFocus
        Grand()
    End Sub

    Private Sub lnkAttach_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach.LinkClicked
        Attachment.CheckFileExists = True
        Attachment.Multiselect = False
        Attachment.ValidateNames = True
        Attachment.Title = "Agri Chemicals Limited - Upload OPO Attachment"
        Attachment.Filter = Nothing
        Attachment.Filter = "Image Files(*.jpg, *.jpeg, *.bmp, *.png, *.gif, *.exif,)|*.jpg; *.jpeg; *.bmp; *.png; *.gif; *.exif|" & "PDF Files (*.pdf)|*.pdf|" & "Office Files (*.doc, *.docx, *.odf, *.xlt, *.xls, *.xlsx, *.ppt, *.pptx) | *.doc; *.docx; *.odf; *.xlt; *.xls; *.xlsx; *.ppt; *.pptx | " & "Text Files (*.txt) | *.txt | " & "Rich Text Document (*.rtf) | *.rtf | " & "All Files (*.*) | *.*"
        Try
            If Attachment.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim Path As String = Attachment.FileName
                If lsvAttachment.Items.Count > 0 Then
                    Dim Attach As Boolean
                    For Each File As ListViewItem In lsvAttachment.Items
                        If Path = File.SubItems(0).Text Then
                            MsgBox("The selected file is already attached to the current OPR details." & vbCrLf & "You cannot attach file with same name in a single OPR details.", MsgBoxStyle.Critical, Title)
                            Attach = False
                            Exit For
                        Else
                            Attach = True
                        End If
                    Next
                    If Attach = True Then
                        lsvAttachment.Items.Add(Path)
                    End If
                Else
                    lsvAttachment.Items.Add(Path)
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub lsvAttachment_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsvAttachment.MouseDoubleClick
        Try
            For Each File As ListViewItem In lsvAttachment.Items
                Dim Path As String = File.SubItems(0).Text.ToString
                If File.Selected = True Then
                    Process.Start(Path)
                End If
            Next
        Catch Ex As Exception
            Show_Attachment()
        End Try
    End Sub

    Private Sub lnkRemove_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRemove.LinkClicked
        Dim i As Integer
        If lsvAttachment.Items.Count = 0 Then
            MsgBox("There is no attached file in the OPO to be removed.", MsgBoxStyle.Critical, Title)
        ElseIf lsvAttachment.SelectedItems.Count = 0 Then
            MsgBox("Please, select the appropriate file to remove from OPO details.", MsgBoxStyle.Critical, Title)
        Else
            For i = 0 To lsvAttachment.SelectedItems.Count - 1
                lsvAttachment.Items.Remove(lsvAttachment.SelectedItems(i))
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If OPO_Search() = True Then
            OPO_Load()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case btnSave.Text
            Case "Edit Details"
                If MessageBox.Show("Do you really want to edit OPO details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    OPO_ReadWrite()
                    btnSave.Text = "Update Details"
                    btnReset.Enabled = True
                Else
                    Exit Sub
                End If
            Case Else
                If OPO_Validation() = "" Then
                    If Quotation_Validation() = "" Then
                        Total()
                        Grand()
                        If btnSave.Text = "Save Details" Then
                            OPO_Save()
                        ElseIf btnSave.Text = "Update Details" Then
                            OPO_Update()
                        End If
                    Else
                        MsgBox("Please, enter valid information in the highlighted field(s) of Quotation detail", MsgBoxStyle.Critical, Title)
                    End If
                Else
                    MsgBox("Please enter valid information in the following:" & OPO_Validation(), MsgBoxStyle.Critical, Title)
                End If
        End Select
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Select Case btnReset.Text
            Case "Reset Details"
                If MessageBox.Show("Do you really want to reset OPO details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    OPO_Reset()
                Else
                    Exit Sub
                End If
            Case "Restore Details"
                If MessageBox.Show("Do you want to restore OPO details?" & vbCrLf & "Caution: This action undo all the unsaved changes on the form.", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    OPO_Reset()
                    OPO_Load()
                Else
                    Exit Sub
                End If
        End Select
    End Sub
End Class