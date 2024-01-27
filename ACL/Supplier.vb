Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmSupplier

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter
    Dim DS As DataSet

    Dim Post As New Regex("^[0-9]+$")
    Dim Phone1 As New Regex("^(\+[0-9]{2}[\-\s]?)\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")
    Dim Phone2 As New Regex("^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")
    Dim Email As New Regex("^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$")

    Dim Title As String = "Agri Chemicals Limited"
    Dim SName As String
    Dim SID, UID, Search As Integer

    Public Sub Supplier()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim SupplierAutoSuggest As New AutoCompleteStringCollection()
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT Name FROM Supplier"
                    DR = Cmd.ExecuteReader()
                    Do While DR.Read()
                        SupplierAutoSuggest.Add(Trim(DR.GetValue(0)))
                    Loop
                    DR.Close()
                    txtName.AutoCompleteCustomSource = SupplierAutoSuggest
                Catch Ex As Exception
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    If DR.Read() Then
                        DR.Close()
                    End If
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

    Public Sub Type()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim TypeAutoSuggest As New AutoCompleteStringCollection()
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT DISTINCT Type FROM Supplier"
                    DR = Cmd.ExecuteReader
                    Do While DR.Read()
                        TypeAutoSuggest.Add(Trim(DR.GetValue(0)))
                    Loop
                    DR.Close()
                    txtType.AutoCompleteCustomSource = TypeAutoSuggest
                Catch Ex As Exception
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    If DR.Read() Then
                        DR.Close()
                    End If
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

    Public Sub City()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT DISTINCT City FROM Supplier"
                    DR = Cmd.ExecuteReader
                    Do While DR.Read()
                        If Not txtCity.AutoCompleteCustomSource.Contains(DR.GetValue(0).ToString) Then
                            txtCity.AutoCompleteCustomSource.Add(DR.GetValue(0).ToString)
                        End If
                    Loop
                    DR.Close()
                Catch Ex As Exception
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    If DR.Read() Then
                        DR.Close()
                    End If
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

    Public Sub Supplier_ReadOnly()
        For Each C As Control In tlpSupplier.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is ComboBox Or TypeOf (C) Is DataGridView Or TypeOf (C) Is Button Then
                C.Enabled = False
            End If
        Next
    End Sub

    Public Sub Supplier_ReadWrite()
        For Each C As Control In tlpSupplier.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is ComboBox Or TypeOf (C) Is DataGridView Or TypeOf (C) Is Button Then
                C.Enabled = True
            End If
        Next
    End Sub

    Public Sub Supplier_Reset()
        txtName.Text = ""
        txtType.Text = ""
        txtWebsite.Text = ""
        txtComment.Text = ""
        txtAddress.Text = ""
        txtCountry.Text = ""
        txtCity.Text = ""
        txtCode.Text = ""
        dgvPhone.DataSource = Nothing
        dgvPhone.Rows.Clear()
        dgvFax.DataSource = Nothing
        dgvFax.Rows.Clear()
        dgvContact.DataSource = Nothing
        dgvContact.Rows.Clear()
        txtName.Focus()
    End Sub

    Public Function Supplier_Validation() As String
        Dim Result As String = ""
        If Trim(txtName.Text) = "" Then
            txtName.Text = ""
            Result = Result & "-  Supplier's Name" & vbCrLf
        End If
        If Trim(txtType.Text) = "" Then
            txtType.Text = ""
            Result = Result & "-  Supplier's Type" & vbCrLf
        End If
        If Trim(txtAddress.Text) = "" Then
            txtAddress.Text = ""
            Result = Result & "-  Supplier's Address" & vbCrLf
        End If
        If Trim(txtCountry.Text) = "" Then
            txtCountry.Text = ""
            Result = Result & "-  Supplier's Country" & vbCrLf
        Else
            If Not txtCountry.AutoCompleteCustomSource.Contains(txtCountry.Text) Then
                Result = Result & "-  Supplier's Country is not valid" & vbCrLf
            End If
        End If
        If Trim(txtCity.Text) = "" Then
            txtCity.Text = ""
            Result = Result & "-  Supplier's City" & vbCrLf
        End If
        If Trim(txtCode.Text) = "" Then
            txtCode.Text = ""
            Result = Result & "-  Supplier's Postal Code" & vbCrLf
        Else
            If Not Post.IsMatch(txtCode.Text) Then
                Result = Result & "-  Supplier's Postal Code is not valid" & vbCrLf
            End If
        End If
        If Trim(txtWebsite.Text) = "" Then
            txtWebsite.Text = ""
            Result = Result & "-  Supplier's Website" & vbCrLf
        End If
        If Trim(txtComment.Text) = "" Then
            txtComment.Text = ""
            Result = Result & "-  Supplier's Comments" & vbCrLf
        End If
        If dgvPhone.RowCount < 2 Then
            Result = Result & "-  Supplier's Phone Number" & vbCrLf
        End If
        If dgvFax.RowCount < 2 Then
            Result = Result & "-  Supplier's Fax Number" & vbCrLf
        End If
        If dgvContact.RowCount < 2 Then
            Result = Result & "-  Supplier's Contact Person Detail" & vbCrLf
        End If
        Return Result
    End Function

    Public Function Phone_Validation() As String
        Dim Result As String = ""
        For Each Row As DataGridViewRow In dgvPhone.Rows
            If Row.Cells(0).Value = Nothing Then
                Row.Cells(0).Value = ""
            End If
            If Not Row.IsNewRow Then
                If IsDBNull(Row.Cells(0).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(0).Value)) Then
                    Row.Cells(0).Style.BackColor = Color.LightPink
                    Row.Cells(0).Value = ""
                    Result = "Error"
                Else
                    If Phone1.IsMatch(Row.Cells(0).Value.ToString()) Or Phone2.IsMatch(Row.Cells(0).Value.ToString()) Then
                        Row.Cells(0).Style.BackColor = Color.Empty
                    Else
                        Row.Cells(0).Style.BackColor = Color.LightPink
                        Result = "Error"
                    End If
                End If
            End If
        Next
        Return Result
    End Function

    Public Function Fax_Validation() As String
        Dim Result As String = ""
        For Each Row As DataGridViewRow In dgvFax.Rows
            If Row.Cells(0).Value = Nothing Then
                Row.Cells(0).Value = ""
            End If
            If Not Row.IsNewRow Then
                If IsDBNull(Row.Cells(0).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(0).Value)) Then
                    Row.Cells(0).Style.BackColor = Color.LightPink
                    Row.Cells(0).Value = ""
                    Result = "Error"
                Else
                    If Phone1.IsMatch(Row.Cells(0).Value.ToString()) Or Phone2.IsMatch(Row.Cells(0).Value.ToString()) Then
                        Row.Cells(0).Style.BackColor = Color.Empty
                    Else
                        Row.Cells(0).Style.BackColor = Color.LightPink
                        Result = "Error"
                    End If
                End If
            End If
        Next
        Return Result
    End Function

    Public Function Contact_Validation() As String
        Dim Result As String = ""
        For Each Row As DataGridViewRow In dgvContact.Rows
            If Row.Cells(0).Value = Nothing Then
                Row.Cells(0).Value = ""
            End If
            If Row.Cells(1).Value = Nothing Then
                Row.Cells(1).Value = ""
            End If
            If Row.Cells(2).Value = Nothing Then
                Row.Cells(2).Value = ""
            End If
            If Not Row.IsNewRow Then
                If IsDBNull(Row.Cells(0).Value) Or String.IsNullOrEmpty(Trim(Row.Cells(0).Value.ToString())) Then
                    Row.Cells(0).Style.BackColor = Color.LightPink
                    Row.Cells(0).Value = ""
                    Result = "Error"
                Else
                    Row.Cells(0).Style.BackColor = Color.Empty
                End If
                If IsDBNull(Row.Cells(1).Value) Or String.IsNullOrEmpty(Row.Cells(1).Value.ToString()) Then
                    Row.Cells(1).Style.BackColor = Color.LightPink
                    Row.Cells(1).Value = ""
                    Result = "Error"
                Else
                    If Not Email.IsMatch(Row.Cells(1).Value.ToString()) Then
                        Row.Cells(1).Style.BackColor = Color.LightPink
                        Result = "Error"
                    Else
                        Row.Cells(1).Style.BackColor = Color.Empty
                    End If
                End If
                If IsDBNull(Row.Cells(2).Value) Or String.IsNullOrEmpty(Row.Cells(2).Value.ToString()) Then
                    Row.Cells(2).Style.BackColor = Color.LightPink
                    Row.Cells(2).Value = ""
                    Result = "Error"
                Else
                    If Phone2.IsMatch(Row.Cells(2).Value.ToString()) Or Phone2.IsMatch(Row.Cells(2).Value.ToString()) Then
                        Row.Cells(2).Style.BackColor = Color.Empty
                    Else
                        Row.Cells(2).Style.BackColor = Color.LightPink
                        Result = "Error"
                    End If
                End If
            End If
        Next
        Return Result
    End Function

    Public Function Supplier_Search() As Boolean
        Dim Result As Boolean
        If Trim(txtName.Text) = "" Then
            txtName.Text = ""
            MsgBox("Please, enter Supplier Name.", MsgBoxStyle.Critical, Title)
            txtName.Focus()
        Else
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "SELECT ID FROM Supplier WHERE Name = @Name"
                        Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtName.Text
                        DR = Cmd.ExecuteReader()
                        If DR.Read() Then
                            Search = DR.GetValue(0)
                            DR.Close()
                            Result = True
                        Else
                            DR.Close()
                            Result = False
                            MsgBox("Sorry, Supplier details not found.", MsgBoxStyle.Information, Title)
                            Supplier_Reset()
                            Supplier_ReadOnly()
                            txtName.Enabled = True
                            txtName.Focus()
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

    Public Sub Supplier_Load()
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
                    Cmd.CommandText = "SELECT Name, Type, Address, Country, City, Post, Website, Comment FROM Supplier WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.VarChar)).Value = Search
                    DR = Cmd.ExecuteReader()
                    If DR.Read() Then
                        txtName.Text = DR.GetValue(0)
                        SName = DR.GetValue(0)
                        txtType.Text = DR.GetValue(1)
                        txtAddress.Text = DR.GetValue(2)
                        txtCountry.Text = DR.GetValue(3)
                        txtCity.Text = DR.GetValue(4)
                        txtCode.Text = DR.GetValue(5)
                        txtWebsite.Text = DR.GetValue(6)
                        txtComment.Text = DR.GetValue(7)
                        DR.Close()
                        Cmd.Parameters.Clear()
                        Cmd.CommandText = "SELECT Phone FROM Phone WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                        DA = New SqlDataAdapter(Cmd)
                        DS = New DataSet
                        DA.Fill(DS, "Phone")
                        dgvPhone.DataSource = DS
                        dgvPhone.DataMember = "Phone"
                        Cmd.Parameters.Clear()
                        For Each Row As DataGridViewRow In dgvPhone.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        Cmd.CommandText = "SELECT Fax FROM Fax WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                        DA = New SqlDataAdapter(Cmd)
                        DS = New DataSet
                        DA.Fill(DS, "Fax")
                        dgvFax.DataSource = DS
                        dgvFax.DataMember = "Fax"
                        Cmd.Parameters.Clear()
                        For Each Row As DataGridViewRow In dgvFax.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        Cmd.CommandText = "SELECT Name, Email, Mobile FROM Contact WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                        DA = New SqlDataAdapter(Cmd)
                        DS = New DataSet
                        DA.Fill(DS, "Contact")
                        dgvContact.DataSource = DS
                        dgvContact.DataMember = "Contact"
                        Cmd.Parameters.Clear()
                        For Each Row As DataGridViewRow In dgvContact.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        Load.Commit()
                        Supplier_ReadOnly()
                        txtName.Enabled = True
                        btnSearch.Enabled = True
                        Me.AcceptButton = btnSave
                        btnSave.Text = "Edit Details"
                        btnSave.Enabled = True
                        btnReset.Text = "Restore Details"
                    End If
                Catch Ex As Exception
                    If Not DR.IsClosed Then
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

    Public Sub Supplier_Save()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim PCount, FCount, CCount As Integer
                UID = frmEPanel.ID
                Dim Save As SqlTransaction
                Save = Con.BeginTransaction
                Cmd.Transaction = Save
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "INSERT INTO Supplier(Name, Type, Address, Country, City, Post, Website, Comment, CID, CB, CD) VALUES(@Name, @Type, @Address, @Country, @City, @Post, @Website, @Comment, @CID, @CB, @CD)"
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Type", SqlDbType.VarChar)).Value = txtType.Text
                    Cmd.Parameters.Add(New SqlParameter("@Address", SqlDbType.NVarChar)).Value = txtAddress.Text
                    Cmd.Parameters.Add(New SqlParameter("@Country", SqlDbType.VarChar)).Value = txtCountry.Text
                    Cmd.Parameters.Add(New SqlParameter("@City", SqlDbType.VarChar)).Value = txtCity.Text
                    Cmd.Parameters.Add(New SqlParameter("@Post", SqlDbType.NVarChar)).Value = txtCode.Text
                    Cmd.Parameters.Add(New SqlParameter("@Website", SqlDbType.VarChar)).Value = txtWebsite.Text
                    Cmd.Parameters.Add(New SqlParameter("@Comment", SqlDbType.VarChar)).Value = txtComment.Text
                    Cmd.Parameters.Add(New SqlParameter("@CID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    Cmd.Parameters.Add(New SqlParameter("@CB", SqlDbType.VarChar)).Value = frmEPanel.Employee
                    Cmd.Parameters.Add(New SqlParameter("@CD", SqlDbType.DateTime)).Value = Now
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "SELECT ID FROM Supplier WHERE Name = @Name"
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtName.Text
                    SID = Cmd.ExecuteScalar()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Phone(ID, Phone) VALUES(@ID, @Phone)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Phone", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvPhone.Rows
                        If Not Row.IsNewRow Then
                            PCount = Row.Index
                            Cmd.Parameters("@ID").Value = SID
                            Cmd.Parameters("@Phone").Value = Row.Cells(0).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvPhone.Rows
                        dgvPhone.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.CommandText = "INSERT INTO Fax(ID, Fax) VALUES(@ID, @Fax)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Fax", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvFax.Rows
                        If Not Row.IsNewRow Then
                            FCount = Row.Index
                            Cmd.Parameters("@ID").Value = SID
                            Cmd.Parameters("@Fax").Value = Row.Cells(0).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvFax.Rows
                        dgvFax.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.CommandText = "INSERT INTO Contact(ID, Name, Email, Mobile) VALUES(@ID, @Name, @Email, @Mobile)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Email", SqlDbType.VarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Mobile", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvContact.Rows
                        If Not Row.IsNewRow Then
                            CCount = Row.Index
                            Cmd.Parameters("@ID").Value = SID
                            Cmd.Parameters("@Name").Value = Row.Cells(0).Value
                            Cmd.Parameters("@Email").Value = Row.Cells(1).Value
                            Cmd.Parameters("@Mobile").Value = Row.Cells(2).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvContact.Rows
                        dgvContact.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.Parameters.Clear()
                    Save.Commit()
                    MsgBox("The Supplier details saved successfully.", MsgBoxStyle.Information, Title)
                    Supplier_Reset()
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_Supplier_Name") Then
                        MsgBox("The Supplier Name you entered is already belongs to another Supplier." & vbCrLf & "Please, enter different Supplier Name.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_Phone_Phone") Then
                        MsgBox("The Phone Number you entered is already in use." & vbCrLf & "Please, enter different Phone Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvPhone.Rows(PCount).Cells(0).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Fax_Fax") Then
                        MsgBox("The Fax Number you entered is already in use." & vbCrLf & "Please, enter different Fax Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvFax.Rows(FCount).Cells(0).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Contact_Email") Then
                        MsgBox("The Contact Person Email Address you entered is already in use." & vbCrLf & "Please, enter different Contact Person Email Address in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvContact.Rows(CCount).Cells(1).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Contact_Mobile") Then
                        MsgBox("The Contact Person Mobile Number you entered is already in use." & vbCrLf & "Please, enter different Contact Person Mobile Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvContact.Rows(CCount).Cells(2).Style.BackColor = Color.LightPink
                    Else
                        MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
                    End If
                    Save.Rollback()
                Finally
                    Cmd.Parameters.Clear()
                    Save.Dispose()
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

    Public Sub Supplier_Update()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim PCount, FCount, CCount As Integer
                UID = frmEPanel.ID
                Dim Update As SqlTransaction
                Update = Con.BeginTransaction
                Cmd.Transaction = Update
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "UPDATE Supplier SET Name = @Name, Type = @Type, Address = @Address, Country = @Country, City = @City, Post = @Post, Website = @Website, Comment = @Comment, EID = @EID, EB = @EB, ED = @ED WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Type", SqlDbType.VarChar)).Value = txtType.Text
                    Cmd.Parameters.Add(New SqlParameter("@Address", SqlDbType.NVarChar)).Value = txtAddress.Text
                    Cmd.Parameters.Add(New SqlParameter("@Country", SqlDbType.VarChar)).Value = txtCountry.Text
                    Cmd.Parameters.Add(New SqlParameter("@City", SqlDbType.VarChar)).Value = txtCity.Text
                    Cmd.Parameters.Add(New SqlParameter("@Post", SqlDbType.NVarChar)).Value = txtCode.Text
                    Cmd.Parameters.Add(New SqlParameter("@Website", SqlDbType.VarChar)).Value = txtWebsite.Text
                    Cmd.Parameters.Add(New SqlParameter("@Comment", SqlDbType.VarChar)).Value = txtComment.Text
                    Cmd.Parameters.Add(New SqlParameter("@EID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    Cmd.Parameters.Add(New SqlParameter("@EB", SqlDbType.VarChar)).Value = frmEPanel.Employee
                    Cmd.Parameters.Add(New SqlParameter("@ED", SqlDbType.DateTime)).Value = Now
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "DELETE FROM Phone WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Phone(ID, Phone) VALUES(@ID, @Phone)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Phone", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvPhone.Rows
                        If Not Row.IsNewRow Then
                            PCount = Row.Index
                            Cmd.Parameters("@ID").Value = Search
                            Cmd.Parameters("@Phone").Value = Row.Cells(0).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvPhone.Rows
                        dgvPhone.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.CommandText = "DELETE FROM Fax WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Fax(ID, Fax) VALUES(@ID, @Fax)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Fax", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvFax.Rows
                        If Not Row.IsNewRow Then
                            FCount = Row.Index
                            Cmd.Parameters("@ID").Value = Search
                            Cmd.Parameters("@Fax").Value = Row.Cells(0).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvFax.Rows
                        dgvFax.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.CommandText = "DELETE FROM Contact WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.VarChar)).Value = Search
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Cmd.CommandText = "INSERT INTO Contact(ID, Name, Email, Mobile) VALUES(@ID, @Name, @Email, @Mobile)"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt))
                    Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Email", SqlDbType.VarChar))
                    Cmd.Parameters.Add(New SqlParameter("@Mobile", SqlDbType.VarChar))
                    For Each Row As DataGridViewRow In dgvContact.Rows
                        If Not Row.IsNewRow Then
                            CCount = Row.Index
                            Cmd.Parameters("@ID").Value = Search
                            Cmd.Parameters("@Name").Value = Row.Cells(0).Value
                            Cmd.Parameters("@Email").Value = Row.Cells(1).Value
                            Cmd.Parameters("@Mobile").Value = Row.Cells(2).Value
                            Cmd.ExecuteNonQuery()
                        End If
                    Next
                    Cmd.Parameters.Clear()
                    For Each Row As DataGridViewRow In dgvContact.Rows
                        dgvContact.RowsDefaultCellStyle.BackColor = Color.Empty
                    Next
                    Cmd.Parameters.Clear()
                    Update.Commit()
                    MsgBox("The Supplier details updated successfully.", MsgBoxStyle.Information, Title)
                    Supplier_Reset()
                    Supplier_ReadOnly()
                    txtName.Enabled = True
                    txtName.Focus()
                    btnSearch.Enabled = True
                    Me.AcceptButton = btnSearch
                    btnSave.Text = "Edit Details"
                    btnReset.Text = "Restore Details"
                    If Me.Text <> "Edit Supplier Details" Then
                        Me.Close()
                    End If
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_Supplier_Name") Then
                        MsgBox("The Supplier Name you entered is already belongs to another Supplier." & vbCrLf & "Please, enter different Supplier Name.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_Phone_Phone") Then
                        MsgBox("The Phone Number you entered is already in use." & vbCrLf & "Please, enter different Phone Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvPhone.Rows(PCount).Cells(0).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Fax_Fax") Then
                        MsgBox("The Fax Number you entered is already in use." & vbCrLf & "Please, enter different Fax Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvFax.Rows(FCount).Cells(0).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Contact_Email") Then
                        MsgBox("The Contact Person Email Address you entered is already in use." & vbCrLf & "Please, enter different Contact Person Email Address in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvContact.Rows(CCount).Cells(1).Style.BackColor = Color.LightPink
                    ElseIf Ex.Message.Contains("UK_Contact_Mobile") Then
                        MsgBox("The Contact Person Mobile Number you entered is already in use." & vbCrLf & "Please, enter different Contact Person Mobile Number in the highlighted field.", MsgBoxStyle.Exclamation, Title)
                        dgvContact.Rows(CCount).Cells(2).Style.BackColor = Color.LightPink
                    Else
                        MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
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

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Supplier()
        Type()
        City()
    End Sub

    Private Sub dgvPhone_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPhone.RowEnter
        dgvPhone.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub dgvFax_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFax.RowEnter
        dgvFax.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub dgvContact_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvContact.RowEnter
        dgvContact.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Supplier_Search() = True Then
            Supplier_Load()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case btnSave.Text.ToString
            Case "Edit Details"
                If MessageBox.Show("Do you really want to edit " & SName & " details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Supplier_ReadWrite()
                    btnSave.Text = "Update Details"
                    btnReset.Enabled = True
                Else
                    Exit Sub
                End If
            Case Else
                If Supplier_Validation() <> "" Then
                    MsgBox("Please enter valid information for the following:" & vbCrLf & Supplier_Validation(), MsgBoxStyle.Critical, Title)
                Else
                    If Phone_Validation() = "" Then
                        If Fax_Validation() = "" Then
                            If Contact_Validation() = "" Then
                                If btnSave.Text = "Save Details" Then
                                    Supplier_Save()
                                ElseIf btnSave.Text = "Update Details" Then
                                    Supplier_Update()
                                End If
                            Else
                                MsgBox("Please, enter valid details in the highlighted fields of Contact Person Details.", MsgBoxStyle.Critical, Title)
                            End If
                        Else
                            MsgBox("Please, enter valid details in the highlighted fields of Fax Details.", MsgBoxStyle.Critical, Title)
                        End If
                    Else
                        MsgBox("Please, enter valid details in the highlighted fields of Phone Details.", MsgBoxStyle.Critical, Title)
                    End If
                End If
        End Select
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Select Case btnReset.Text.ToString
            Case "Reset Details"
                If MessageBox.Show("Do you want to reset all the details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Supplier_Reset()
                End If
            Case "Restore Details"
                If MessageBox.Show("Do you want to restore supplier details?" & vbCrLf & "Caution: This action undo all the unsaved changes on the form.", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Supplier_Reset()
                    Supplier_Load()
                End If
        End Select
    End Sub
End Class