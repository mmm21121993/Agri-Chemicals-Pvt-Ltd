Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class frmUserActivity

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter
    Dim DS As DataSet
    Dim DT As New DataTable

    Dim Title As String = "Agri Chemicals Limited"
    Dim Username As String

    Public Sub Employee_List()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT Photo, (FName + ' ' + LName), Username FROM Userdetail WHERE Type = 'Employee' ORDER BY ID"
                    DA = New SqlDataAdapter(Cmd)
                    DA.Fill(DT)
                    If DT.Rows.Count > 0 Then
                        lsvEmployee.Items.Clear()
                        Dim Employee As New ImageList()
                        Employee.ColorDepth = ColorDepth.Depth32Bit
                        Employee.ImageSize = New Size(155, 155)
                        For Each Row As DataRow In DT.Rows
                            Dim Key As String = Guid.NewGuid().ToString()
                            Dim Profile As Byte()
                            Dim MS As New MemoryStream
                            Profile = Row.Item(0)
                            MS = New MemoryStream(Profile)
                            If Not MS Is Nothing Then
                                Employee.Images.Add(Key, Image.FromStream(MS))
                            Else
                                Employee.Images.Add(Key, My.Resources.Profile)
                            End If
                            Dim Info As String
                            lsvEmployee.LargeImageList = Employee
                            lsvEmployee.SmallImageList = Employee
                            Info = Row.Item(1).ToString() & vbCrLf & "[" & Row.Item(2).ToString() & "]"
                            Dim Item As New ListViewItem(Info, Key)
                            lsvEmployee.Items.Add(Item)
                        Next
                    Else
                        MsgBox("No Employee records found in the database.", MsgBoxStyle.Information, "Agri Chemicals Pvt. Ltd.")
                    End If
                    Cmd.Parameters.Clear()
                Catch Ex As Exception
                    MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
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

    Public Sub Count()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT (SELECT COUNT(CID) FROM OPO WHERE CID = (SELECT ID FROM UserDetail WHERE Username = @User)) AS 'COPO', (SELECT COUNT(EID) FROM OPO WHERE EID = (SELECT ID FROM UserDetail WHERE Username = @User)) AS 'EOPO', (SELECT COUNT(CID) FROM Supplier WHERE CID = (SELECT ID FROM UserDetail WHERE Username = @User)) AS 'CSupplier', (SELECT COUNT(EID) FROM Supplier WHERE CID = (SELECT ID FROM UserDetail WHERE Username = @User)) AS 'ESupplier', (SELECT COUNT(RID) FROM Request WHERE RID = (SELECT ID FROM UserDetail WHERE Username = @User)) AS 'Request'"
                    Cmd.Parameters.Add(New SqlParameter("@User", SqlDbType.VarChar)).Value = Username
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "UserDetail")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvCount.DataSource = DS
                        dgvCount.DataMember = "UserDetail"
                        dgvCount.ReadOnly = True
                        dgvCount.Visible = True
                    End If
                    Cmd.Parameters.Clear()
                Catch Ex As Exception
                    MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
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

    Public Sub Activity()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT CONVERT(VARCHAR(25), CD, 22) AS 'Date', ' New OPO Document ' + LTRIM(RTRIM(OPR_No )) + ' is Created by ' + CB + '.' AS 'Activity' FROM OPO WHERE CID = (SELECT ID FROM UserDetail WHERE Username = @User)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), ED, 22) AS 'Date', ' Stored OPO document ' + LTRIM(RTRIM(OPR_No )) + ' is Edited by ' + EB + '.' AS 'Activity' FROM OPO WHERE EID = (SELECT ID FROM UserDetail WHERE Username = @User)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), CD, 22) AS 'Date', ' New Supplier details named ' + Name + ' is Created by ' + CB + '.' AS 'Activity' FROM Supplier WHERE CID = (SELECT ID FROM UserDetail WHERE Username = @User)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), ED, 22) AS 'Date', ' Stored Supplier details named ' + Name + ' is Edited by ' + EB + '.' AS 'Activity' FROM Supplier WHERE EID = (SELECT ID FROM UserDetail WHERE Username = @User)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), RD, 22) AS 'Date', ' New OPO Deletion Request for the OPO - ' + LTRIM(RTRIM(OPR_No)) + ' is generated by ' + RB + '.' AS 'Activity' FROM Request WHERE RID = (SELECT ID FROM UserDetail WHERE Username = @User)"
                    Cmd.CommandText = Cmd.CommandText & " ORDER BY 1 DESC"
                    Cmd.Parameters.Add(New SqlParameter("@User", SqlDbType.VarChar)).Value = Username
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "UserLogin")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvRecent.DataSource = DS
                        dgvRecent.DataMember = "UserLogin"
                        dgvRecent.Columns(0).HeaderText = "Date of Activity"
                        dgvRecent.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvRecent.Columns(0).DataPropertyName = "Date"
                        dgvRecent.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvRecent.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRecent.Columns(0).Width = 200
                        dgvRecent.Columns(1).HeaderText = "Description of Activities"
                        dgvRecent.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvRecent.Columns(1).DataPropertyName = "Activity"
                        dgvRecent.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        For Each Row As DataGridViewRow In dgvRecent.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        dgvRecent.ReadOnly = True
                        dgvRecent.Visible = True
                        lblActivity.Visible = True
                        lblNoActivity.SendToBack()
                    Else
                        dgvRecent.Visible = True
                        lblNoActivity.Visible = True
                        lblNoActivity.BringToFront()
                        dgvRecent.DataSource = Nothing
                        dgvRecent.DataMember = Nothing
                    End If
                    Cmd.Parameters.Clear()
                Catch Ex As Exception
                    MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
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

    Private Sub frmUserActivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Employee_List()
    End Sub

    Private Sub lsvEmployee_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvEmployee.DoubleClick
        If lsvEmployee.SelectedItems.Count > 0 Then
            Dim Emp As String = lsvEmployee.SelectedItems(0).SubItems(0).Text.ToString()
            Emp = Emp.Remove(0, Emp.IndexOf("[") + 1).ToString()
            Emp = Emp.Remove(Emp.Length - 1).ToString()
            Username = Emp
            Count()
            Activity()
        End If
    End Sub

End Class