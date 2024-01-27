Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmRequest

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader

    Dim Title As String = "Agri Chemicals Limited"

    Public OPR As String

    Private Sub frmRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOPRNo.Text = OPR
        lblRequesterName.Text = frmEPanel.Employee
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If Trim(txtRequest.Text) = "" Then
            MsgBox("Please, ente  reason to delete the OPR details.", MsgBoxStyle.Critical, "Agri Chemicals Limited")
            txtRequest.Focus()
        Else
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "INSERT INTO Request(OPR_No, RID, RB, RD, Description) VALUES(@OPR, @RID, @RB, @RD, @Description)"
                        Cmd.Parameters.Add(New SqlParameter("@OPR", SqlDbType.Char)).Value = lblOPRNo.Text
                        Cmd.Parameters.Add(New SqlParameter("@RID", SqlDbType.TinyInt)).Value = frmEPanel.ID
                        Cmd.Parameters.Add(New SqlParameter("@RB", SqlDbType.VarChar)).Value = frmEPanel.Employee
                        Cmd.Parameters.Add(New SqlParameter("@RD", SqlDbType.DateTime)).Value = Now
                        Cmd.Parameters.Add(New SqlParameter("@Description", SqlDbType.NVarChar)).Value = txtRequest.Text
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        MsgBox("OPR deletion request submitted successfully.", MsgBoxStyle.Information, Title)
                        txtRequest.Text = ""
                        Con.Close()
                        Me.Close()
                    Catch Ex As Exception
                        MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                    Finally
                        Cmd.Parameters.Clear()
                        Con.Close()
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Do you want to cancel the deletion request?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txtRequest.Text = ""
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class