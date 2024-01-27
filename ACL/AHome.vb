Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmAHome

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DA As SqlDataAdapter
    Dim DR As SqlDataReader
    Dim DS As DataSet

    Dim Title As String = "Agri Chemicals Limied"
    Dim ID As Integer

    Public Sub Request_Load()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT ID AS 'No.', LTRIM(RTRIM(OPR_NO)) AS 'OPR NO.', RD AS 'Request Date', Description AS 'Description', Status AS 'Status' FROM Request"
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
                        Cmd.CommandText = Cmd.CommandText & " WHERE Status = @Status"
                    End If
                    Cmd.Parameters.Add(New SqlParameter("@Status", SqlDbType.VarChar)).Value = Status
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "Request")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvRequest.Columns.Clear()
                        dgvRequest.DataSource = DS
                        dgvRequest.DataMember = "Request"
                        dgvRequest.DefaultCellStyle.Padding = New Padding(4, 4, 4, 4)
                        dgvRequest.Columns(0).Width = 75
                        dgvRequest.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        dgvRequest.Columns(0).Name = "ID"
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
                        Dim Accept As New DataGridViewLinkColumn()
                        Accept.Width = 75
                        Accept.Name = "Accept"
                        Accept.Text = "Accept"
                        Accept.UseColumnTextForLinkValue = True
                        Accept.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        Accept.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns.Add(Accept)
                        Dim Reject As New DataGridViewLinkColumn()
                        Reject.Width = 75
                        Reject.Name = "Reject"
                        Reject.Text = "Reject"
                        Reject.UseColumnTextForLinkValue = True
                        Reject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        Reject.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
                        dgvRequest.Columns.Add(Reject)
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

    Public Sub Employee()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT RID AS 'ID', RB AS 'Name', (SELECT COUNT(ID) FROM Request) AS 'Request', (SELECT COUNT(ID) FROM Request WHERE Status = 'Pending') AS 'Pending', (SELECT COUNT(ID) FROM Request WHERE Status = 'Accepted') AS 'Accept', (SELECT COUNT(ID) FROM Request WHERE Status = 'Rejected') AS 'Reject' FROM Request GROUP BY RID, RB"
                    DA = New SqlDataAdapter(Cmd)
                    DS = New DataSet
                    DA.Fill(DS, "Request")
                    If DS.Tables.Count > 0 And DS.Tables(0).Rows.Count > 0 Then
                        dgvEmployee.DataSource = DS
                        dgvEmployee.DataMember = "Request"
                        dgvEmployee.ReadOnly = True
                        lblNoEmployee.SendToBack()
                    Else
                        dgvEmployee.DataSource = Nothing
                        dgvEmployee.DataMember = Nothing
                        dgvEmployee.Rows.Clear()
                        lblNoEmployee.BringToFront()
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
    End Sub

    Public Sub Accept()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Dim Delete As SqlTransaction
                    Delete = Con.BeginTransaction("Delete")
                    Cmd.Connection = Con
                    Cmd.Transaction = Delete
                    Try
                        Cmd.CommandText = "UPDATE Request SET Status = 'Accepted' WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = ID
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        MsgBox("Request table updated successfully.")
                        Cmd.CommandText = "SELECT OPR_NO FROM Request WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = ID
                        Dim OPR As String = Cmd.ExecuteScalar()
                        Cmd.Parameters.Clear()
                        MsgBox(OPR)
                        Cmd.CommandText = "DELETE FROM OPO WHERE OPR_No = @OPR"
                        Cmd.Parameters.Add(New SqlParameter("@OPR", SqlDbType.VarChar)).Value = OPR
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        Delete.Commit()
                        MsgBox("OPO deleted successfully", MsgBoxStyle.Information, Title)
                    Catch Ex As Exception
                        Delete.Rollback()
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    Finally
                        Delete.Dispose()
                    End Try
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

    Public Sub Reject()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, "Error")
            Else
                Try
                    Cmd.Connection = Con
                    Cmd.CommandText = "UPDATE Request SET Status = 'Rejected' WHERE ID = @ID"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.Int)).Value = ID
                    Cmd.ExecuteNonQuery()
                    MsgBox("The OPO deletion request Rejected Successfully.", MsgBoxStyle.Information, Title)
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

    Private Sub frmAHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbStatus.SelectedIndex = 2
        Request_Load()
        Employee()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        Request_Load()
    End Sub

    Private Sub dgvRequest_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRequest.CellContentClick
        If sender.Columns(e.ColumnIndex).Name = "Accept" Then
            If dgvRequest.Rows(e.RowIndex).Cells("Status").Value.ToString() = "Pending" Then
                ID = dgvRequest.Rows(e.RowIndex).Cells("ID").Value.ToString()
                If MessageBox.Show("Do you really want to accept this OPO deletion request?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Accept()
                    Request_Load()
                    Employee()
                Else
                    Exit Sub
                End If
            Else
                MsgBox("The OPO deletion request for the particular OPO is already " & dgvRequest.Rows(e.RowIndex).Cells("Status").Value.ToString() & ".", MsgBoxStyle.Critical, Title)
            End If
        ElseIf sender.Columns(e.ColumnIndex).Name = "Reject" Then
            If dgvRequest.Rows(e.RowIndex).Cells("Status").Value.ToString() = "Pending" Then
                ID = dgvRequest.Rows(e.RowIndex).Cells("ID").Value.ToString()
                If MessageBox.Show("Do you really want to reject this OPO deletion request?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Reject()
                    Request_Load()
                    Employee()
                Else
                    Exit Sub
                End If
            Else
                MsgBox("The OPO deletion request for the particular OPO is already " & dgvRequest.Rows(e.RowIndex).Cells("Status").Value.ToString() & ".", MsgBoxStyle.Critical, Title)
            End If
        End If
    End Sub

End Class