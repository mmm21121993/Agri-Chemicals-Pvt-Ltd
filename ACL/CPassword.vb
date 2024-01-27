Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmCPassword

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader

    Dim ID As Integer
    Dim Title As String = "Agri Chemicals Limited"

    Public Sub Password_Reset()
        txtOld.Text = ""
        txtNew.Text = ""
        txtConfirm.Text = ""
        txtOld.Focus()
    End Sub

    Public Function Password_Validate()
        Dim Result As String = ""
        If txtOld.Text = "" Then
            Result = Result & "-  Enter Current Password" & vbCrLf
        Else
            If txtOld.Text.Length < 5 Then
                Result = Result & "-  Current Password is Invalid" & vbCrLf & "   (Password must contain more than 5 characters)" & vbCrLf
            End If
        End If
        If txtNew.Text = "" Then
            Result = Result & "-  Enter New Password" & vbCrLf
        Else
            If txtNew.Text.Length < 5 Then
                Result = Result & "-  New Password is Invalid" & vbCrLf & "   (Password must contain more than 5 characters)" & vbCrLf
            Else
                If txtOld.Text = txtNew.Text Then
                    Result = Result & "-  The New Password must be different from the Current Password" & vbCrLf
                End If
            End If
        End If
        If txtConfirm.Text = "" Then
            Result = Result & "-  Enter Confirm Password" & vbCrLf
        Else
            If txtNew.Text <> txtConfirm.Text Then
                Result = Result & "-  Your New Password and Conformation Password do not match" & vbCrLf
            End If
        End If
        Return Result
    End Function

    Public Sub ChangePassword()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim ChangePass As SqlTransaction
                ChangePass = Con.BeginTransaction
                Cmd.Transaction = ChangePass
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "SELECT ID FROM UserDetail WHERE ID = @ID AND Password = @Old COLLATE LATIN1_GENERAL_CS_AS"
                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = ID
                    Cmd.Parameters.Add(New SqlParameter("@Old", SqlDbType.VarChar)).Value = txtOld.Text
                    DR = Cmd.ExecuteReader
                    Cmd.Parameters.Clear()
                    If DR.Read() Then
                        DR.Close()
                        Cmd.CommandText = "UPDATE UserDetail SET Password = @New COLLATE LATIN1_GENERAL_CS_AS WHERE ID = @ID"
                        Cmd.Parameters.Add(New SqlParameter("@New", SqlDbType.VarChar)).Value = txtNew.Text
                        Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = ID
                        Cmd.ExecuteNonQuery()
                        Cmd.Parameters.Clear()
                        MsgBox("Your account password updated successfully." & vbCrLf & "You can use your New Password from next time you login.", MsgBoxStyle.Information, Title)
                        ChangePass.Commit()
                        Password_Reset()
                        Me.Close()
                    Else
                        DR.Close()
                        MsgBox("The Current Password is wrong.", MsgBoxStyle.Exclamation, Title)
                    End If
                Catch Ex As Exception
                    DR.Close()
                    Cmd.Parameters.Clear()
                    ChangePass.Rollback()
                    MsgBox(Ex.Message & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Finally
                    ChangePass.Dispose()
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub frmCPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ID = frmAPanel.ID
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If Password_Validate() <> "" Then
            MsgBox("Please enter valid information in the following:" & vbCrLf & Password_Validate(), MsgBoxStyle.Critical, Title)
        Else
            ChangePassword()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Do you really want to cancel the operation?", Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Password_Reset()
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

End Class