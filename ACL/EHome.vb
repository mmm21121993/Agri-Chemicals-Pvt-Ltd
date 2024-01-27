Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmEHome

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter
    Dim DS As DataSet

    Dim Title As String = "Agri Chemicals Limited"

    Public Sub Recent_Activity()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT CONVERT(VARCHAR(25), CD, 22) + ' - ' + LTRIM(RTRIM(OPR_No )) + ' document is Created by ' + CB + '.' FROM OPO WHERE CD > (SELECT TOP 1 Logout FROM UserLogin WHERE ID = @ID ORDER BY Logout DESC)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), ED, 22) + ' - ' + LTRIM(RTRIM(OPR_No )) + ' document is Edited by ' + EB + '.' FROM OPO WHERE ED > (SELECT TOP 1 Logout FROM UserLogin WHERE ID = @ID ORDER BY Logout DESC)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), CD, 22) + ' - ' + Name + ' suplier is Created by ' + CB + '.' FROM Supplier WHERE CD > (SELECT TOP 1 Logout FROM UserLogin WHERE ID = @ID ORDER BY Logout DESC)"
                    Cmd.CommandText = Cmd.CommandText & " UNION ALL "
                    Cmd.CommandText = Cmd.CommandText & "SELECT CONVERT(VARCHAR(25), ED, 22) + ' - ' + Name + ' supplier is Edited by ' + EB + '.' FROM Supplier WHERE ED > (SELECT TOP 1 Logout FROM UserLogin WHERE ID = @ID ORDER BY Logout DESC)"
                    Cmd.CommandText = Cmd.CommandText & " ORDER BY 1"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "UserLogin")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvRecent.DataSource = DS
                        dgvRecent.DataMember = "UserLogin"
                        dgvRecent.Columns(0).HeaderText = "Recent Activities performaed by other members :"
                        dgvRecent.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                        For Each Row As DataGridViewRow In dgvRecent.Rows
                            Row.HeaderCell.Value = CStr(Row.Index + 1)
                        Next
                        dgvRecent.ReadOnly = True
                        lblNoRecent.SendToBack()
                    Else
                        dgvRecent.DataSource = Nothing
                        dgvRecent.DataMember = Nothing
                        lblNoRecent.BringToFront()
                    End If
                    Cmd.Parameters.Clear()
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
    End Sub

    Public Sub Request_Load()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT ID AS'No.', LTRIM(RTRIM(OPR_NO)) AS 'OPR NO.', RD AS 'Request Date', Description AS 'Description', Status AS 'Status' FROM Request WHERE RID = @ID"
                    Dim Status As String
                    Status = ""
                    Select Case cmbStatus.SelectedIndex
                        Case 0
                            Status = ""
                        Case 1
                            Status = "Accepted"
                        Case 2
                            Status = "Pending"
                        Case 3
                            Status = "Rejected"
                        Case Else
                            MsgBox("Please, Select valid option from the Request Status list.", MsgBoxStyle.Critical, Title)
                    End Select
                    If Status = "" Then
                        Cmd.CommandText = Cmd.CommandText
                    Else
                        Cmd.CommandText = Cmd.CommandText & " AND Status = @Status"
                    End If
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                    Cmd.Parameters.Add(New SqlParameter("@Status", SqlDbType.VarChar)).Value = Status
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "Request")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvRequest.DataSource = DS
                        dgvRequest.DataMember = "Request"
                        dgvRequest.DefaultCellStyle.Padding = New Padding(4, 4, 4, 4)
                        dgvRequest.Columns(0).Width = 75
                        dgvRequest.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRequest.Columns(1).Width = 200
                        dgvRequest.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                        dgvRequest.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRequest.Columns(2).Width = 200
                        dgvRequest.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRequest.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
                        dgvRequest.Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        dgvRequest.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        dgvRequest.Columns(4).Width = 150
                        dgvRequest.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRequest.ReadOnly = True
                        lblNoRequest.SendToBack()
                    Else
                        dgvRequest.DataSource = Nothing
                        dgvRequest.DataMember = Nothing
                        dgvRequest.Rows.Clear()
                        lblNoRequest.BringToFront()
                    End If
                    Cmd.Parameters.Clear()
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
    End Sub

    Private Sub frmEHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbStatus.SelectedIndex = 0
        Request_Load()
        Recent_Activity()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        Request_Load()
    End Sub
End Class