Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class frmManageUser

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim Title As String = "Agri Chemicals Limited"
    Dim Username, Status As String

    Public Sub Employee_Autosuggest()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim NameAutosuggest As New AutoCompleteStringCollection()
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT FName + ' ' + LName FROM UserDetail"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        NameAutosuggest.Add(DR.GetValue(0).ToString())
                    End While
                    DR.Close()
                    txtName.AutoCompleteCustomSource = NameAutosuggest
                Catch Ex As Exception
                    If DR.Read() Then
                        DR.Close()
                    End If
                    MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub Employee_Load()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Name, Gender, Type, Status As String
                If Trim(txtName.Text) = "" Then
                    Name = ""
                Else
                    Name = txtName.Text
                End If
                Gender = ""
                For Each Item As Object In cblGender.CheckedItems
                    Gender = Gender & "'" & Item.ToString() & "', "
                Next
                If Gender <> "" Then
                    Gender = Gender.Remove(Gender.Length() - 2, 2)
                End If
                Type = ""
                For Each Item As Object In cblType.CheckedItems
                    Type = Type & "'" & Item.ToString() & "', "
                Next
                If Type <> "" Then
                    Type = Type.Remove(Type.Length() - 2, 2)
                End If
                Status = ""
                For Each Item As Object In cblStatus.CheckedItems
                    Status = Status & "'" & Item.ToString() & "', "
                Next
                If Status <> "" Then
                    Status = Status.Remove(Status.Length() - 2, 2)
                End If
                Cmd.CommandText = "SELECT Photo, (FName + ' ' + LName), Username, Gender, Phone, Email, Type, Status FROM UserDetail "
                If Name = "" And Gender = "" And Type = "Any" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText
                ElseIf Name = "" And Gender = "" And Type = "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Status IN(" & Status & ")"
                ElseIf Name = "" And Gender = "" And Type <> "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Type IN(" & Type & ")"
                ElseIf Name = "" And Gender = "" And Type <> "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Type IN(" & Type & ") AND Status IN(" & Status & ")"
                ElseIf Name = "" And Gender <> "" And Type = "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Gender IN(" & Gender & ")"
                ElseIf Name = "" And Gender <> "" And Type = "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Gender IN(" & Gender & ") AND Status IN(" & Status & ")"
                ElseIf Name = "" And Gender <> "" And Type <> "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Gender IN(" & Gender & ") AND Type IN(" & Type & ")"
                ElseIf Name = "" And Gender <> "" And Type <> "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE Gender IN(" & Gender & ") AND Type IN(" & Type & ") AND Status IN(" & Status & ")"
                ElseIf Name <> "" And Gender = "" And Type = "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name"
                ElseIf Name <> "" And Gender = "" And Type = "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Status IN(" & Status & ")"
                ElseIf Name <> "" And Gender = "" And Type <> "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Type IN(" & Type & ")"
                ElseIf Name <> "" And Gender = "" And Type <> "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Type IN(" & Type & ") AND Status IN(" & Status & ")"
                ElseIf Name <> "" And Gender <> "" And Type = "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Gender IN(" & Gender & ")"
                ElseIf Name <> "" And Gender <> "" And Type = "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Gender IN(" & Gender & ") AND Status IN(" & Status & ")"
                ElseIf Name <> "" And Gender <> "" And Type <> "" And Status = "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Gender IN(" & Gender & ") AND Type IN(" & Type & ")"
                ElseIf Name <> "" And Gender <> "" And Type <> "" And Status <> "" Then
                    Cmd.CommandText = Cmd.CommandText & "WHERE (FName + ' ' + LName) = @Name AND Gender IN(" & Gender & ") AND Type IN(" & Type & ") AND Status IN(" & Status & ")"
                End If
                Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = Name
                lsvEmployee.Items.Clear()
                Dim User As New ImageList
                User.ColorDepth = ColorDepth.Depth32Bit
                User.ImageSize = New Size(90, 100)
                lsvEmployee.LargeImageList = User
                lsvEmployee.SmallImageList = User
                DA = New SqlDataAdapter(Cmd)
                DT = New DataTable
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    For Each Row As DataRow In DT.Rows
                        Dim Profile As String = Guid.NewGuid().ToString()
                        Dim Photo As Byte()
                        Dim MS As New MemoryStream
                        Photo = Row.Item(0)
                        MS = New MemoryStream(Photo)
                        If Not MS Is Nothing Then
                            User.Images.Add(Profile, Image.FromStream(MS))
                        Else
                            User.Images.Add(Profile, My.Resources.Profile)
                        End If
                        lsvEmployee.Columns.AddRange(New ColumnHeader() {New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader(), New ColumnHeader()})
                        Dim Item As New ListViewItem(New String() {Row.Item(1).ToString(), "User Name : " & Row.Item(2).ToString(), "Gender : " & Row.Item(3).ToString(), "Phone : " & Row.Item(4).ToString(), "Email : " & Row.Item(5).ToString(), "Account Type :" & Row.Item(6).ToString(), "Account Status : " & Row.Item(7).ToString()}, Profile)
                        lsvEmployee.Items.Add(Item)
                    Next
                Else
                    MsgBox("Sorry, no record(s) found for your search criteria.", MsgBoxStyle.Information, Title)
                End If
                Cmd.Parameters.Clear()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Public Sub Employee_Update()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Update As SqlTransaction
                Update = Con.BeginTransaction("Update")
                Cmd.Connection = Con
                Cmd.Transaction = Update
                Try
                    Cmd.CommandText = "UPDATE UserDetail SET Status = @Status WHERE Username = @Username"
                    Cmd.Parameters.Add(New SqlParameter("@Status", SqlDbType.VarChar)).Value = Status
                    Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = Username
                    Cmd.ExecuteNonQuery()
                    Update.Commit()
                    Cmd.Parameters.Clear()
                    MsgBox("Employee Status changed successfully.", MsgBoxStyle.Information, Title)
                    Con.Close()
                    Employee_Load()
                Catch Ex As Exception
                    Update.Rollback()
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
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

    Public Sub Employee_Delete()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Delete As SqlTransaction
                Delete = Con.BeginTransaction("Delete")
                Cmd.Connection = Con
                Cmd.Transaction = Delete
                Try
                    Cmd.CommandText = "DELETE FROM UserDetail WHERE Username = @Username"
                    Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = Username
                    Cmd.ExecuteNonQuery()
                    Delete.Commit()
                    MsgBox("User Details Deleted Successfully.", MsgBoxStyle.Information, Title)
                    Cmd.Parameters.Clear()
                    Con.Close()
                    Employee_Load()
                Catch Ex As Exception
                    Delete.Rollback()
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    Cmd.Parameters.Clear()
                    Delete.Dispose()
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

    Public Sub Reset()
        txtName.Text = ""
        For Gender As Integer = 0 To cblGender.Items.Count - 1
            cblGender.SetItemCheckState(Gender, False)
        Next
        cblGender.ClearSelected()
        For Type As Integer = 0 To cblType.Items.Count - 1
            cblType.SetItemCheckState(Type, False)
        Next
        cblType.ClearSelected()
        For Status As Integer = 0 To cblStatus.Items.Count - 1
            cblStatus.SetItemCheckState(Status, False)
        Next
        cblStatus.ClearSelected()
        txtName.Focus()
        lsvEmployee.Items.Clear()
    End Sub

    Private Sub frmManageUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Employee_Autosuggest()
        Employee_Load()
    End Sub

    Private Sub tlpUserDetails_CellPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TableLayoutCellPaintEventArgs) Handles tlpUserDetails.CellPaint
        If e.Column < 2 Then
            e.Graphics.FillRectangle(Brushes.FloralWhite, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.Transparent, e.CellBounds)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Employee_Load()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Reset()
        Employee_Load()
    End Sub

    Private Sub cmsEmployee_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsEmployee.Opening
        If lsvEmployee.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuApprove.Click
        If lsvEmployee.SelectedItems.Count > 0 Then
            Username = lsvEmployee.SelectedItems(0).SubItems(1).Text.ToString().Replace("User Name : ", "").ToString()
            Status = mnuApprove.Text.ToString()
            Employee_Update()
        End If
    End Sub

    Private Sub mnuReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReject.Click
        If lsvEmployee.SelectedItems.Count > 0 Then
            Username = lsvEmployee.SelectedItems(0).SubItems(1).Text.ToString().Replace("User Name : ", "").ToString()
            Status = mnuReject.Text.ToString()
            Employee_Update()
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If lsvEmployee.SelectedItems.Count > 0 Then
            Dim Name As String = lsvEmployee.SelectedItems(0).Text.ToString
            If MessageBox.Show("Do you want to remove " & Name & " account details?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Username = lsvEmployee.SelectedItems(0).SubItems(1).Text.ToString().Replace("User Name : ", "").ToString()
                MsgBox(Username)
                Employee_Delete()
            Else
                Exit Sub
            End If
        End If
    End Sub

End Class