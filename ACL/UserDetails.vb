Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmUserDetails

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader

    Dim Names As New Regex("^[a-zA-Z]*$")
    Dim Phone1 As New Regex("^(\+[0-9]{2}[\-\s]?)\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")
    Dim Phone2 As New Regex("^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")
    Dim Email As New Regex("^[\w\.\-]+@[a-zA-Z0-9\-]+(\.[a-zA-Z0-9\-]{1,})*(\.[a-zA-Z]{2,3}){1,2}$")
    Dim Username As New Regex("^[a-zA-Z0-9_-]{6,16}$")

    Dim ID As Integer
    Dim Title As String = "Agri Chemicals Ltd."

    Public Sub Employee_ReadOnly()
        For Each C As Control In tlpUserDetails.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is ComboBox Or TypeOf (C) Is Button Then
                C.Enabled = False
            End If
        Next
        btnSave.Enabled = True
    End Sub

    Public Sub Employee_ReadWrite()
        For Each C As Control In tlpUserDetails.Controls
            If TypeOf (C) Is TextBox Or TypeOf (C) Is ComboBox Or TypeOf (C) Is Button Then
                C.Enabled = True
            End If
        Next
        btnSave.Text = "Update Details"
        cmbType.Enabled = False
        txtPassword.Enabled = False
        txtConfirm.Enabled = False
        txtFName.Focus()
    End Sub

    Public Sub Employee_Reset()
        txtFName.Text = ""
        txtLName.Text = ""
        cmbGender.Text = ""
        ptbPhoto.Image = My.Resources.Profile
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        cmbType.Text = ""
        cmbQuestion.Text = ""
        txtAnswer.Text = ""
        txtConfirm.Text = ""
        txtFName.Focus()
    End Sub

    Public Function Employee_Validation() As String
        Dim Result As String = ""
        If Trim(txtFName.Text) = "" Then
            txtFName.Text = ""
            Result = Result & "-  Employee's First Name" & vbCrLf
        Else
            If Names.IsMatch(Trim(txtFName.Text)) = False Then
                Result = Result & "-  Employee's First Name is not valid" & vbCrLf
            End If
        End If
        If Trim(txtLName.Text) = "" Then
            txtLName.Text = ""
            Result = Result & "-  Employee's Last Name" & vbCrLf
        Else
            If Names.IsMatch(Trim(txtLName.Text)) = False Then
                Result = Result & "-  Employee's Last Name is not valid" & vbCrLf
            End If
        End If
        If cmbGender.SelectedIndex = -1 Then
            Result = Result & "-  Select Employee's Gender" & vbCrLf
        End If
        If ptbPhoto.Image Is Nothing Then
            Result = Result & "-  Employee's Profile Photo" & vbCrLf
        End If
        If Trim(txtAddress.Text) = "" Then
            txtAddress.Text = ""
            Result = Result & "-  Employee's Resedential Address" & vbCrLf
        End If
        If Trim(txtPhone.Text) = "" Then
            txtPhone.Text = ""
            Result = Result & "-  Employee's Contact Number" & vbCrLf
        Else
            If Phone1.IsMatch(Trim(txtPhone.Text.ToString)) Or Phone2.IsMatch(Trim(txtPhone.Text.ToString)) Then
            Else
                Result = Result & "-  Employee's Contact Number is not valid" & vbCrLf
            End If
        End If
        If Trim(txtEmail.Text) = "" Then
            txtEmail.Text = ""
            Result = Result & "-  Employee's Email Address" & vbCrLf
        Else
            If Email.IsMatch(Trim(txtEmail.Text)) = False Or Trim(txtEmail.Text) = "" Then
                Result = Result & "-  Employee's Email Address is not valid" & vbCrLf
            End If
        End If
        If Trim(txtUserName.Text) = "" Then
            txtUserName.Text = ""
            Result = Result & "-  Employee's User Name" & vbCrLf
        Else
            If Username.IsMatch(Trim(txtUserName.Text)) = False Then
                Result = Result & "-  Employee's Username must be 6-16 characters long and it must " & vbCrLf & "    contain lower and upper case letters, digits and special symbols" & vbCrLf & "    '_' or '-' only" & vbCrLf
            End If
        End If
        If txtPassword.Text = "" Then
            Result = Result & "-  Employee's Password" & vbCrLf
        Else
            If txtPassword.Text.Length <= 5 Then
                Result = Result & "-  Employee's Password must contain 6-16 characters" & vbCrLf
            End If
        End If
        If txtConfirm.Text = "" Then
            Result = Result & "-  Employee's Confirm Password" & vbCrLf
        Else
            If txtPassword.Text <> txtConfirm.Text Then
                Result = Result & "-  Employee's Account Password and Confirm Password do not match" & vbCrLf
            End If
        End If
        If cmbType.SelectedIndex = -1 Then
            Result = Result & "-  Select Employee's Account Type" & vbCrLf
        End If
        If cmbQuestion.SelectedIndex = -1 Then
            Result = Result & "-  Select Security Question for Employee's Account" & vbCrLf
        End If
        If Trim(txtAnswer.Text) = "" Then
            txtAnswer.Text = ""
            Result = Result & "-  Enter Security Answer for Employee's Account" & vbCrLf
        End If
        Return Result
    End Function

    Public Sub Employee_LoadProfile()
        If Me.Text = "Edit Profile" Then
            cmbType.Enabled = False
            txtPassword.Enabled = False
            txtConfirm.Enabled = False
            If frmLogin.Type = "Administrator" Then
                ID = frmAPanel.ID
            Else
                ID = frmEPanel.ID
            End If
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Dim Load As SqlTransaction
                    Load = Con.BeginTransaction
                    Cmd.Transaction = Load
                    Cmd.Connection = Con
                    Try
                        Cmd.CommandText = "SELECT * FROM UserDetail WHERE ID = " & ID
                        DR = Cmd.ExecuteReader
                        If DR.Read() Then
                            Dim Profile As Byte()
                            Dim MS As New MemoryStream
                            Profile = DR.Item("Photo")
                            MS = New MemoryStream(Profile)
                            If Not MS Is Nothing Then
                                ptbPhoto.Image = Image.FromStream(MS)
                            Else
                                ptbPhoto.Image = My.Resources.Profile
                            End If
                            txtFName.Text = DR.GetValue(1)
                            txtLName.Text = DR.GetValue(2)
                            cmbGender.Text = DR.GetValue(3)
                            txtAddress.Text = DR.GetValue(5)
                            txtPhone.Text = DR.GetValue(6)
                            txtEmail.Text = DR.GetValue(7)
                            txtUserName.Text = DR.GetValue(9)
                            txtPassword.Text = DR.GetValue(10)
                            txtConfirm.Text = DR.GetValue(10)
                            cmbType.Text = DR.GetValue(8)
                            cmbQuestion.Text = DR.GetValue(11)
                            txtAnswer.Text = DR.GetValue(12)
                            txtFName.Focus()
                        Else
                            MsgBox("Sorry, system cannot load Employee's Profile.", MsgBoxStyle.Critical, "Error")
                        End If
                        DR.Close()
                        Load.Commit()
                    Catch Ex As Exception
                        MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
                        If DR.IsClosed = False Then
                            DR.Close()
                        End If
                        Load.Rollback()
                    Finally
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
        End If
    End Sub

    Public Sub Employee_SaveDetail()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Save As SqlTransaction
                Save = Con.BeginTransaction
                Cmd.Transaction = Save
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "INSERT INTO UserDetail(FName, LName, Gender, Photo, Address, Phone, Email, Type, Username, Password, SQuestion, SAnswer) VALUES(@FName, @LName, @Gender, @Photo, @Address, @Phone, @Email, @Type, @Username, @Password, @SQuestion, @SAnswer)"
                    Cmd.Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar)).Value = txtFName.Text
                    Cmd.Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar)).Value = txtLName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Gender", SqlDbType.VarChar)).Value = cmbGender.Text
                    Dim MS As New MemoryStream()
                    ptbPhoto.Image.Save(MS, ptbPhoto.Image.RawFormat)
                    Dim Profile As Byte() = MS.GetBuffer()
                    Cmd.Parameters.Add(New SqlParameter("@Photo", SqlDbType.Image)).Value = Profile
                    Cmd.Parameters.Add(New SqlParameter("@Address", SqlDbType.NVarChar)).Value = txtAddress.Text
                    Cmd.Parameters.Add(New SqlParameter("@Phone", SqlDbType.VarChar)).Value = txtPhone.Text
                    Cmd.Parameters.Add(New SqlParameter("@Email", SqlDbType.VarChar)).Value = txtEmail.Text
                    Cmd.Parameters.Add(New SqlParameter("@Type", SqlDbType.VarChar)).Value = cmbType.Text
                    Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = txtUserName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Password", SqlDbType.VarChar)).Value = txtPassword.Text
                    Cmd.Parameters.Add(New SqlParameter("@SQuestion", SqlDbType.VarChar)).Value = cmbQuestion.Text
                    Cmd.Parameters.Add(New SqlParameter("@SAnswer", SqlDbType.VarChar)).Value = txtAnswer.Text
                    Cmd.ExecuteNonQuery()
                    Save.Commit()
                    MsgBox("The Employee details saved successfully.", MsgBoxStyle.Information, Title)
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_UserDetail_Phone") Then
                        MsgBox("The Phone Number you entered is already belongs to another Employee." & vbCrLf & "Please, enter different Phone Number.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_UserDetail_Email") Then
                        MsgBox("The Email Address you entered is already belongs to another Employee." & vbCrLf & "Please, enter different Email Address.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_UserDetail_Username") Then
                        MsgBox("The User Name you entered is already belongs to another Employee." & vbCrLf & "Please, enter different User Name.", MsgBoxStyle.Exclamation, Title)
                    Else
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
                    Save.Rollback()
                Finally
                    Save.Dispose()
                    Cmd.Parameters.Clear()
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

    Public Sub Employee_UpdateDetail()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Update As SqlTransaction
                Update = Con.BeginTransaction
                Cmd.Transaction = Update
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "UPDATE UserDetail SET FName = @FName, LName = @LName, Gender = @Gender, Photo = @Photo, Address = @Address, Phone = @Phone, Email = @Email, Type = @Type, Username = @Username, Password = @Password, SQuestion = @SQuestion, SAnswer = @SAnswer WHERE ID = " & ID
                    Cmd.Parameters.Add(New SqlParameter("@FName", SqlDbType.VarChar)).Value = txtFName.Text
                    Cmd.Parameters.Add(New SqlParameter("@LName", SqlDbType.VarChar)).Value = txtLName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Gender", SqlDbType.VarChar)).Value = cmbGender.Text
                    Dim MS As New MemoryStream()
                    ptbPhoto.Image.Save(MS, ptbPhoto.Image.RawFormat)
                    Dim Profile As Byte() = MS.GetBuffer()
                    Cmd.Parameters.Add(New SqlParameter("@Photo", SqlDbType.Image)).Value = Profile
                    Cmd.Parameters.Add(New SqlParameter("@Address", SqlDbType.NVarChar)).Value = txtAddress.Text
                    Cmd.Parameters.Add(New SqlParameter("@Phone", SqlDbType.VarChar)).Value = txtPhone.Text
                    Cmd.Parameters.Add(New SqlParameter("@Email", SqlDbType.VarChar)).Value = txtEmail.Text
                    Cmd.Parameters.Add(New SqlParameter("@Type", SqlDbType.VarChar)).Value = cmbType.Text
                    Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = txtUserName.Text
                    Cmd.Parameters.Add(New SqlParameter("@Password", SqlDbType.VarChar)).Value = txtPassword.Text
                    Cmd.Parameters.Add(New SqlParameter("@SQuestion", SqlDbType.VarChar)).Value = cmbQuestion.Text
                    Cmd.Parameters.Add(New SqlParameter("@SAnswer", SqlDbType.VarChar)).Value = txtAnswer.Text
                    Cmd.ExecuteNonQuery()
                    Update.Commit()
                    MsgBox("The Employee details updated successfully.", MsgBoxStyle.Information, Title)
                    btnSave.Text = "Edit Details"
                Catch Ex As Exception
                    If Ex.Message.Contains("UK_UserDetail_Phone") Then
                        MsgBox("The Phone Number you entered is already belongs to another Employee." & vbCrLf & "Please, enter different Phone Number.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_UserDetail_Email") Then
                        MsgBox("The Email Address you entered is already belongs to another Employee." & vbCrLf & "Please, enter different Email Address.", MsgBoxStyle.Exclamation, Title)
                    ElseIf Ex.Message.Contains("UK_UserDetail_Username") Then
                        MsgBox("The User Name you entered is already belongs to another Employee." & vbCrLf & "Please, enter different User Name.", MsgBoxStyle.Exclamation, Title)
                    Else
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
                    Update.Rollback()
                Finally
                    Update.Dispose()
                    Cmd.Parameters.Clear()
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

    Private Sub frmUserDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Edit Profile" Then
            Employee_LoadProfile()
            Employee_ReadOnly()
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Dim Profile As New OpenFileDialog
        Try
            Profile.CheckFileExists = True
            Profile.Multiselect = False
            Profile.ValidateNames = True
            Profile.Title = "Agri Chemicals Limited - Upload Profile Picture"
            Profile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            If Profile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ptbPhoto.Image = Image.FromFile(Profile.FileName)
            End If
        Catch Ex As Exception
            MsgBox("Sorry, we canont load the profile picture.", MsgBoxStyle.Critical, Title)
            ptbPhoto.Image = My.Resources.Profile
        Finally
            Profile.Dispose()
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Do you want to remove the profile picture?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ptbPhoto.Image = My.Resources.Profile
            ptbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Select Case btnSave.Text.ToString
            Case "Save Details"
                If Employee_Validation() <> "" Then
                    MsgBox("Please enter valid information for the following:" & vbCrLf & Employee_Validation(), MsgBoxStyle.Critical, Title)
                Else
                    Employee_SaveDetail()
                    Employee_Reset()
                    If Me.Text = "New Employee Registration Form" Then
                        MsgBox("Your Account is created successfully. You can log into the system after receiving an admin's approval.", MsgBoxStyle.Information, Title)
                        frmLogin.Show()
                        Me.Close()
                    End If
                End If
            Case "Edit Details"
                If MessageBox.Show("Do you really want to edit your profile?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Employee_ReadWrite()
                Else
                    Exit Sub
                End If
            Case "Update Details"
                If Employee_Validation() <> "" Then
                    MsgBox("Please enter valid information for the following:" & vbCrLf & Employee_Validation(), MsgBoxStyle.Critical, Title)
                Else
                    Employee_UpdateDetail()
                    Employee_ReadOnly()
                End If
        End Select
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Select Case btnReset.Text.ToString
            Case "Reset Details"
                If MessageBox.Show("Do you want to reset all the details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Employee_Reset()
                End If
            Case "Restore Details"
                If MessageBox.Show("Do you want to restore employee details?" & vbCrLf & "Caution: This action undo all the unsaved changes on the form.", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Employee_Reset()
                    Employee_LoadProfile()
                End If
        End Select
    End Sub

    Private Sub frmUserDetails_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.Text = "New Employee Registration Form" Then
            frmLogin.Show()
        End If
    End Sub

End Class