Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class frmAPanel

    Public ID As Integer = frmLogin.ID

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader

    Dim Title As String = "Agri Chemicals Ltd."
    Dim Log As Boolean = False

    Private Sub frmAPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = lblStatus.Text & frmLogin.Employee
    End Sub

    Private Sub mnuHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHome.Click
        If frmAHome.Visible Then
            frmAHome.Close()
        End If
        frmAHome.MdiParent = Me
        frmAHome.WindowState = FormWindowState.Maximized
        frmAHome.Show()
    End Sub

    Private Sub mnuNewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewEmployee.Click
        If frmUserDetails.Visible Then
            frmUserDetails.Close()
        End If
        frmUserDetails.MdiParent = Me
        frmUserDetails.Text = "New Employee Registration"
        frmUserDetails.WindowState = FormWindowState.Maximized
        frmUserDetails.Show()
    End Sub

    Private Sub mnuManageEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManageEmployee.Click
        If frmManageUser.Visible Then
            frmManageUser.Close()
        End If
        frmManageUser.MdiParent = Me
        frmManageUser.WindowState = FormWindowState.Maximized
        frmManageUser.Show()
    End Sub

    Private Sub mnuViewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuViewEmployee.Click
        If frmUserActivity.Visible Then
            frmUserActivity.Close()
        End If
        frmUserActivity.MdiParent = Me
        frmUserActivity.WindowState = FormWindowState.Maximized
        frmUserActivity.Show()
    End Sub

    Private Sub mnuBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackup.Click
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim SaveBackup As New SaveFileDialog()
                    SaveBackup.AddExtension = True
                    SaveBackup.CheckPathExists = True
                    SaveBackup.Filter = "Backup File (*.bak) | *.bak"
                    SaveBackup.FileName = "AgriChemDB_" & Today.ToString("dd_MMM_yyyy")
                    SaveBackup.Title = "Select Location to Store the Database Backup"
                    SaveBackup.DefaultExt = "bak"
                    If SaveBackup.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Cmd.Connection = Con
                        Cmd.CommandText = "BACKUP DATABASE AgriChemDB TO DISK = @Path"
                        Cmd.Parameters.Add(New SqlParameter("@Path", SqlDbType.NVarChar)).Value = System.IO.Path.GetFullPath(SaveBackup.FileName).ToString()
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        MsgBox("Database Backup Created Successfully.", MsgBoxStyle.Information, Title)
                    End If
                Catch Ex As Exception
                    Cmd.Parameters.Clear()
                    If Err.Number = 5 Then
                        Con.Close()
                        MsgBox(Ex.Message)
                        MsgBox("Access to the current location is denied.", MsgBoxStyle.Exclamation, Title)
                        mnuBackup_Click(sender, e)
                    Else
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    End If
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

    Private Sub mnuRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRestore.Click
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim OpenRestore As New OpenFileDialog()
                    OpenRestore.AddExtension = True
                    OpenRestore.CheckPathExists = True
                    OpenRestore.Filter = "Backup File (*.bak) | *.bak"
                    OpenRestore.Title = "Select Backup File to Restore Database"
                    If OpenRestore.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Cmd.Connection = Con
                        Cmd.CommandText = "USE Master ALTER DATABASE AgriChemDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE AgriChemDB FROM DISK = @Path WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10"
                        Cmd.Parameters.Add(New SqlParameter("@Path", SqlDbType.NVarChar)).Value = System.IO.Path.GetFullPath(OpenRestore.FileName).ToString()
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        Con.Close()
                        MsgBox("Database Restoration done Successfully." & vbCrLf & "To apply changes application will now shut down.", MsgBoxStyle.Information, Title)
                        Call mnuLogout_Click(sender, e)
                        Application.Exit()
                    End If
                Catch Ex As Exception
                    Cmd.Parameters.Clear()
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
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

    Private Sub mnuProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProfile.Click
        If frmUserDetails.Visible Then
            frmUserDetails.Close()
        End If
        frmUserDetails.MdiParent = Me
        frmUserDetails.Text = "Edit Profile"
        frmUserDetails.WindowState = FormWindowState.Maximized
        frmUserDetails.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frmUserDetails.btnSave.Text = "Edit Details"
        frmUserDetails.btnReset.Text = "Restore Details"
        frmUserDetails.btnReset.Enabled = False
        frmUserDetails.Show()
    End Sub

    Private Sub mnuPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPassword.Click
        If frmCPassword.Visible Then
            frmCPassword.Close()
        End If
        For Each Form As Form In Me.MdiChildren
            Form.WindowState = FormWindowState.Minimized
        Next
        frmCPassword.MdiParent = Me
        frmCPassword.Show()
    End Sub

    Private Sub mnuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogout.Click
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Logout As SqlTransaction
                Logout = Con.BeginTransaction
                Cmd.Transaction = Logout
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "UPDATE UserLogin SET Logout = @Logout WHERE ID = " & ID & " AND Login = (SELECT MAX(Login) FROM UserLogin WHERE ID = " & ID & ")"
                    Cmd.Parameters.Add(New SqlParameter("@Logout", SqlDbType.DateTime)).Value = Now
                    Cmd.ExecuteNonQuery()
                    Cmd.Parameters.Clear()
                    Logout.Commit()
                    MsgBox("You have Successfully logged out.", MsgBoxStyle.Information, Title)
                    Logout.Dispose()
                    frmLogin.Show()
                    Con.Close()
                    Log = True
                    Me.Close()
                Catch Ex As Exception
                    Logout.Rollback()
                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
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

    Private Sub frmAPanel_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Log = False Then
            mnuLogout_Click(sender, e)
        End If
    End Sub

End Class