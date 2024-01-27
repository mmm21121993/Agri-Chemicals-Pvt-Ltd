Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmLogin

    Public ID As Integer
    Public Type, Employee As String

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim Title As String = "Agri Chemicals Ltd."

    Public Sub Update_Login()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Cmd.Connection = Con
                Cmd.CommandText = "UPDATE UserLogin SET Logout = Login WHERE Logout IS NULL"
                Cmd.ExecuteNonQuery()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Con.Close()
        End Try
    End Sub

    Public Sub Validate_Login()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Cmd.Connection = Con
                Try
                    Cmd.CommandText = "SELECT ID, Status FROM UserDetail WHERE Username = @Username COLLATE LATIN1_GENERAL_CS_AS"
                    Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = txtUserName.Text
                    DR = Cmd.ExecuteReader()
                    Cmd.Parameters.Clear()
                    If DR.Read() Then
                        If DR.GetValue(1) = "Approved" Then
                            DR.Close()
                            Cmd.CommandText = "SELECT ID, FName + ' ' + LName, Type FROM UserDetail WHERE Username = @Username COLLATE LATIN1_GENERAL_CS_AS AND Password = @Password COLLATE LATIN1_GENERAL_CS_AS"
                            Cmd.Parameters.Add(New SqlParameter("@Username", SqlDbType.VarChar)).Value = txtUserName.Text
                            Cmd.Parameters.Add(New SqlParameter("@Password", SqlDbType.VarChar)).Value = txtPassword.Text
                            DR = Cmd.ExecuteReader()
                            Cmd.Parameters.Clear()
                            If DR.Read() Then
                                ID = DR.GetValue(0)
                                Employee = DR.GetValue(1).ToString
                                Type = DR.GetValue(2).ToString
                                DR.Close()
                                MsgBox("You have successfully logged in.", MsgBoxStyle.Information, Title)
                                Try
                                    Cmd.CommandText = "INSERT INTO UserLogin(ID, Login) VALUES(@ID, @Login)"
                                    Cmd.Parameters.Add(New SqlParameter("@ID", SqlDbType.TinyInt)).Value = ID
                                    Cmd.Parameters.Add(New SqlParameter("@Login", SqlDbType.DateTime)).Value = Now
                                    Cmd.ExecuteNonQuery()
                                    Cmd.Parameters.Clear()
                                Catch Ex As Exception
                                    MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
                                End Try
                                Reset_Login()
                                Me.Hide()
                                If Type = "Administrator" Then
                                    frmAPanel.Show()
                                Else
                                    frmEPanel.Show()
                                End If
                            Else
                                DR.Close()
                                MsgBox("The Username or Password is incorrect." & vbCrLf & "In case if you fogot your password use 'Forgot your Password' link to recover it.", MsgBoxStyle.Critical, Title)
                            End If
                        Else
                            DR.Close()
                            MsgBox("Your account is not yet approved by administrator." & vbCrLf & "To sign in, please contact administrator.", MsgBoxStyle.Critical, Title)
                        End If
                    Else
                        DR.Close()
                        MsgBox("The Username that you've entered does not belong to any account." & vbCrLf & "Use 'Create an Account' link to create a new account.", MsgBoxStyle.Critical, Title)
                    End If
                Catch Ex As Exception
                    MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Con.Close()
        End Try
    End Sub

    Public Sub Reset_Login()
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtUserName.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Update_Login()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Trim(txtUserName.Text) = "" Then
            MsgBox("Please, enter User Name.", MsgBoxStyle.Critical, Title)
            txtUserName.Text = ""
            txtUserName.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please, enter Password.", MsgBoxStyle.Critical, Title)
            txtPassword.Focus()
        ElseIf Trim(txtUserName.Text) <> "" And txtPassword.Text <> "" Then
            Validate_Login()
        End If
    End Sub

    Private Sub lnkAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAccount.LinkClicked
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                frmUserDetails.Show()
                Reset_Login()
                Me.Hide()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Con.Close()
        End Try
    End Sub

End Class
