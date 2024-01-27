Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmEPanel

    Public ID As Integer = frmLogin.ID

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader

    Dim Title As String = "Agri Chemicals Ltd."
    Dim Log As Boolean = False

    Public Employee As String = frmLogin.Employee

    Private Sub frmEPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblStatus.Text = lblStatus.Text & Employee
    End Sub

    Private Sub mnuHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHome.Click
        If frmEHome.Visible Then
            frmEHome.Close()
        End If
        frmEHome.MdiParent = Me
        frmEHome.WindowState = FormWindowState.Maximized
        frmEHome.Show()
    End Sub

    Private Sub mnuNOPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNOPO.Click
        If frmOPO.Visible Then
            frmOPO.Close()
        End If
        frmOPO.MdiParent = Me
        frmOPO.WindowState = FormWindowState.Maximized
        frmOPO.Show()
    End Sub

    Private Sub mnuNSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNSupplier.Click
        If frmSupplier.Visible Then
            frmSupplier.Close()
        End If
        frmSupplier.MdiParent = Me
        frmSupplier.WindowState = FormWindowState.Maximized
        frmSupplier.Show()
    End Sub

    Private Sub mnuEOPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEOPO.Click
        If frmOPO.Visible Then
            frmOPO.Close()
        End If
        frmOPO.MdiParent = Me
        frmOPO.WindowState = FormWindowState.Maximized
        frmOPO.Text = "Edit OPO Details"
        frmOPO.OPO_ReadOnly()
        frmOPO.txtOPRNo.Enabled = True
        frmOPO.txtOPRNo.Focus()
        frmOPO.btnSearch.Enabled = True
        frmOPO.AcceptButton = frmOPO.btnSearch
        frmOPO.btnSearch.Visible = True
        frmOPO.btnSave.Text = "Edit Details"
        frmOPO.btnReset.Text = "Restore Details"
        frmOPO.Show()
    End Sub

    Private Sub mnuESupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuESupplier.Click
        If frmSupplier.Visible Then
            frmSupplier.Close()
        End If
        frmSupplier.MdiParent = Me
        frmSupplier.WindowState = FormWindowState.Maximized
        frmSupplier.Text = "Edit Supplier Details"
        frmSupplier.Supplier_ReadOnly()
        frmSupplier.txtName.Enabled = True
        frmSupplier.txtName.Focus()
        frmSupplier.btnSearch.Enabled = True
        frmSupplier.AcceptButton = frmSupplier.btnSearch
        frmSupplier.btnSearch.Visible = True
        frmSupplier.btnSave.Text = "Edit Details"
        frmSupplier.btnReset.Text = "Restore Details"
        frmSupplier.Show()
    End Sub

    Private Sub mnuVOPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVOPO.Click
        If frmVOPO.Visible Then
            frmVOPO.Close()
        End If
        frmVOPO.MdiParent = Me
        frmVOPO.WindowState = FormWindowState.Maximized
        frmVOPO.Show()
    End Sub

    Private Sub mnuVSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVSupplier.Click
        If frmVSupplier.Visible Then
            frmVSupplier.Close()
        End If
        frmVSupplier.MdiParent = Me
        frmVSupplier.WindowState = FormWindowState.Maximized
        frmVSupplier.Show()
    End Sub

    Private Sub mnuProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProfile.Click
        If frmUserDetails.Visible Then
            frmUserDetails.Close()
        End If
        frmUserDetails.MdiParent = Me
        frmUserDetails.Text = "Edit Profile"
        frmUserDetails.WindowState = FormWindowState.Maximized
        frmUserDetails.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frmUserDetails.AcceptButton = frmUserDetails.btnSave
        frmUserDetails.btnSave.Text = "Edit Details"
        frmUserDetails.btnReset.Text = "Restore Details"
        frmUserDetails.btnReset.Enabled = True
        frmSupplier.btnSearch.Visible = True
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

    Private Sub frmEPanel_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If frmPOPO.Visible Then
                frmPOPO.Close()
            End If
            If frmPSupplier.Visible Then
                frmPSupplier.Close()
            End If
            If frmRequest.Visible Then
                frmRequest.Close()
            End If
            If Log = False Then
                mnuLogout_Click(sender, e)
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

End Class