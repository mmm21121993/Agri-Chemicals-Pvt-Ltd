Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmVSupplier

    Dim Con As New SqlConnection(frmSplashScreen.CS)
    Dim Cmd As New SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter

    Dim Title As String = "Agri Chemicals Limited"

    Public Sub Supplier_Autosuggest()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Try
                    Dim SupplierAutoSuggest As New AutoCompleteStringCollection()
                    Cmd.Connection = Con
                    Cmd.CommandText = "SELECT Name FROM Supplier"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        SupplierAutoSuggest.Add(Trim(DR.GetValue(0)))
                    End While
                    DR.Close()
                    txtName.AutoCompleteCustomSource = SupplierAutoSuggest
                    Cmd.CommandText = "SELECT DISTINCT Type FROM Supplier"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        cblType.Items.Add(Trim(DR.GetValue(0)))
                    End While
                    DR.Close()
                    Cmd.CommandText = "SELECT DISTINCT Country FROM Supplier"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        cblCountry.Items.Add(Trim(DR.GetValue(0)))
                    End While
                    DR.Close()
                    Cmd.CommandText = "SELECT DISTINCT City FROM Supplier"
                    DR = Cmd.ExecuteReader()
                    While DR.Read()
                        cblCity.Items.Add(Trim(DR.GetValue(0)))
                    End While
                    DR.Close()
                Catch Ex As Exception
                    If DR.Read() Then
                        DR.Close()
                    End If
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

    Public Sub Reset()
        txtName.Text = ""
        For Type As Integer = 0 To cblType.Items.Count - 1
            cblType.SetItemCheckState(Type, False)
        Next
        cblType.ClearSelected()
        For Country As Integer = 0 To cblCountry.Items.Count - 1
            cblCountry.SetItemCheckState(Country, False)
        Next
        cblCountry.ClearSelected()
        For City As Integer = 0 To cblCity.Items.Count - 1
            cblCity.SetItemCheckState(City, False)
        Next
        cblCity.ClearSelected()
        lsvSupplier.Items.Clear()
        txtName.Focus()
    End Sub

    Public Sub Search()
        Try
            Con.Open()
            If Not Con.State = ConnectionState.Open Then
                MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
            Else
                Dim Name, Type, Country, City As String
                If Trim(txtName.Text) = "" Then
                    Name = ""
                Else
                    Name = txtName.Text.ToString()
                End If
                Type = ""
                For Each Item As Object In cblType.CheckedItems
                    Type = Type & "'" & Item.ToString() & "', "
                Next
                Country = ""
                For Each Item As Object In cblCountry.CheckedItems
                    Country = Country & "'" & Item.ToString() & "', "
                Next
                City = ""
                For Each Item As Object In cblCity.CheckedItems
                    City = City & "'" & Item.ToString() & "', "
                Next
                If Type <> "" Then
                    Type = Type.Remove(Type.Length - 2, 2).ToString()
                End If
                If Country <> "" Then
                    Country = Country.Remove(Country.Length - 2, 2).ToString()
                End If
                If City <> "" Then
                    City = City.Remove(City.Length - 2, 2).ToString()
                End If
                Cmd.Connection = Con
                If Name = "" And Type = "" And Country = "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier"
                ElseIf Name <> "" And Type = "" And Country = "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%'"
                ElseIf Name = "" And Type <> "" And Country = "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Type IN(" & Type & ")"
                ElseIf Name <> "" And Type <> "" And Country = "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Type IN(" & Type & ")"
                ElseIf Name = "" And Type = "" And Country <> "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Country IN(" & Country & ")"
                ElseIf Name <> "" And Type = "" And Country <> "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Country IN(" & Country & ")"
                ElseIf Name = "" And Type <> "" And Country <> "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Type IN(" & Type & ") AND Country IN(" & Country & ")"
                ElseIf Name <> "" And Type <> "" And Country <> "" And City = "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Type IN(" & Type & ") AND Country IN(" & Country & ")"
                ElseIf Name = "" And Type = "" And Country = "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE City IN(" & City & ")"
                ElseIf Name <> "" And Type = "" And Country = "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND City IN(" & City & ")"
                ElseIf Name = "" And Type <> "" And Country = "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Type IN(" & Type & ") AND City IN(" & City & ")"
                ElseIf Name <> "" And Type <> "" And Country = "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Type IN(" & Type & ") AND City IN(" & City & ")"
                ElseIf Name = "" And Type = "" And Country <> "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Country IN(" & Country & ") AND City IN(" & City & ")"
                ElseIf Name <> "" And Type = "" And Country <> "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Country IN(" & Country & ") AND City IN(" & City & ")"
                ElseIf Name = "" And Type <> "" And Country <> "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Type IN(" & Type & ") AND Country IN(" & Country & ") AND City IN(" & City & ")"
                ElseIf Name <> "" And Type <> "" And Country <> "" And City <> "" Then
                    Cmd.CommandText = "SELECT Name FROM Supplier WHERE Name LIKE @Name + '%' AND Type IN(" & Type & ") AND Country IN(" & Country & ") AND City IN(" & City & ")"
                End If
                Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = txtName.Text
                DR = Cmd.ExecuteReader()
                lsvSupplier.Items.Clear()
                Dim Supplier As New ImageList()
                Supplier.ColorDepth = ColorDepth.Depth32Bit
                Supplier.ImageSize = New Size(160, 130)
                Supplier.TransparentColor = Color.Empty
                Supplier.Images.Add(My.Resources.Supplier)
                lsvSupplier.LargeImageList = Supplier
                lsvSupplier.SmallImageList = Supplier
                While DR.Read()
                    lsvSupplier.Items.Add(DR.GetValue(0).ToString(), 0)
                End While
                DR.Close()
                If lsvSupplier.Items.Count = 0 Then
                    lblNone.BringToFront()
                Else
                    lblNone.SendToBack()
                End If
            End If
        Catch Ex As Exception
            If DR.Read() Then
                DR.Close()
            End If
            MsgBox(Ex.Message & vbCrLf & Ex.StackTrace, MsgBoxStyle.Critical, Title)
        Finally
            Cmd.Parameters.Clear()
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub frmVSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Supplier_Autosuggest()
        Reset()
        Search()
    End Sub

    Private Sub tlpSupplier_CellPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TableLayoutCellPaintEventArgs) Handles tlpSupplier.CellPaint
        If e.Column < 2 Then
            e.Graphics.FillRectangle(Brushes.FloralWhite, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.Transparent, e.CellBounds)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Reset()
        Search()
    End Sub

    Private Sub cmsSupplier_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsSupplier.Opening
        If lsvSupplier.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If lsvSupplier.SelectedItems.Count > 0 Then
            If frmSupplier.Visible Then
                frmSupplier.Close()
            End If
            frmSupplier.MdiParent = frmEPanel
            frmSupplier.Text = lsvSupplier.SelectedItems(0).Text.ToString()
            frmSupplier.txtName.Text = frmSupplier.Text
            If frmSupplier.Supplier_Search() = True Then
                frmSupplier.Supplier_Load()
            End If
            frmSupplier.txtName.Enabled = False
            frmSupplier.Show()
            frmSupplier.btnSave.Focus()
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        If lsvSupplier.SelectedItems.Count > 0 Then
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "SELECT ID FROM Supplier WHERE Name = @Name"
                        Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = lsvSupplier.SelectedItems(0).Text.ToString()
                        frmPSupplier.ID = Cmd.ExecuteScalar()
                        If frmPSupplier.Visible Then
                            frmPSupplier.Close()
                        End If
                        frmPSupplier.TopMost = True
                        frmPSupplier.Text = lsvSupplier.SelectedItems(0).Text.ToString()
                        frmPSupplier.WindowState = FormWindowState.Normal
                        frmPSupplier.StartPosition = FormStartPosition.CenterScreen
                        frmPSupplier.Show()
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
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Dim Delete As Boolean = False
        If lsvSupplier.SelectedItems.Count > 0 Then
            Try
                Con.Open()
                If Not Con.State = ConnectionState.Open Then
                    MsgBox("Cannot connect to server. Try again later.", MsgBoxStyle.Critical, Title)
                Else
                    Try
                        Cmd.Connection = Con
                        Cmd.CommandText = "DELETE FROM Supplier WHERE Name = @Name"
                        Cmd.Parameters.Add(New SqlParameter("@Name", SqlDbType.VarChar)).Value = lsvSupplier.SelectedItems(0).Text.ToString()
                        Cmd.ExecuteNonQuery()
                        MsgBox("Supplier Details Deleted Successfully.", MsgBoxStyle.Information, Title)
                        Delete = True
                    Catch Ex As Exception
                        If Ex.Message.Contains("FK_OPO_Supplier_ID") Then
                            MsgBox("The supplier is currently attach to some OPOs." & vbCrLf & "Sorry, But you cannot delete supplier details at the moment.", MsgBoxStyle.Exclamation, Title)
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
        End If
        If Delete = True Then
            Search()
        End If
    End Sub

End Class