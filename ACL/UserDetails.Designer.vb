<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserDetails))
        Me.tlpUserDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.ptbPhoto = New System.Windows.Forms.PictureBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblCPassword = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.cmbQuestion = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.tlpUserDetails.SuspendLayout()
        CType(Me.ptbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpUserDetails
        '
        Me.tlpUserDetails.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserDetails.ColumnCount = 6
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5!))
        Me.tlpUserDetails.Controls.Add(Me.lblFName, 1, 0)
        Me.tlpUserDetails.Controls.Add(Me.txtFName, 1, 1)
        Me.tlpUserDetails.Controls.Add(Me.lblLName, 1, 2)
        Me.tlpUserDetails.Controls.Add(Me.txtLName, 1, 3)
        Me.tlpUserDetails.Controls.Add(Me.lblGender, 1, 4)
        Me.tlpUserDetails.Controls.Add(Me.lblAddress, 1, 7)
        Me.tlpUserDetails.Controls.Add(Me.btnSave, 1, 18)
        Me.tlpUserDetails.Controls.Add(Me.txtPassword, 1, 15)
        Me.tlpUserDetails.Controls.Add(Me.lblPassword, 1, 14)
        Me.tlpUserDetails.Controls.Add(Me.txtUserName, 1, 13)
        Me.tlpUserDetails.Controls.Add(Me.lblUserName, 1, 12)
        Me.tlpUserDetails.Controls.Add(Me.txtAddress, 1, 8)
        Me.tlpUserDetails.Controls.Add(Me.ptbPhoto, 3, 1)
        Me.tlpUserDetails.Controls.Add(Me.lblPhoto, 3, 0)
        Me.tlpUserDetails.Controls.Add(Me.lblPhone, 3, 7)
        Me.tlpUserDetails.Controls.Add(Me.txtPhone, 3, 8)
        Me.tlpUserDetails.Controls.Add(Me.lblEmail, 3, 9)
        Me.tlpUserDetails.Controls.Add(Me.txtEmail, 3, 10)
        Me.tlpUserDetails.Controls.Add(Me.btnReset, 3, 18)
        Me.tlpUserDetails.Controls.Add(Me.btnUpload, 4, 1)
        Me.tlpUserDetails.Controls.Add(Me.btnRemove, 4, 4)
        Me.tlpUserDetails.Controls.Add(Me.lblCPassword, 1, 16)
        Me.tlpUserDetails.Controls.Add(Me.txtConfirm, 1, 17)
        Me.tlpUserDetails.Controls.Add(Me.cmbQuestion, 3, 15)
        Me.tlpUserDetails.Controls.Add(Me.cmbType, 3, 13)
        Me.tlpUserDetails.Controls.Add(Me.txtAnswer, 3, 17)
        Me.tlpUserDetails.Controls.Add(Me.lblAnswer, 3, 16)
        Me.tlpUserDetails.Controls.Add(Me.lblQuestion, 3, 14)
        Me.tlpUserDetails.Controls.Add(Me.lblType, 3, 12)
        Me.tlpUserDetails.Controls.Add(Me.cmbGender, 1, 5)
        Me.tlpUserDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserDetails.Location = New System.Drawing.Point(16, 16)
        Me.tlpUserDetails.Name = "tlpUserDetails"
        Me.tlpUserDetails.RowCount = 19
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpUserDetails.Size = New System.Drawing.Size(762, 540)
        Me.tlpUserDetails.TabIndex = 0
        '
        'lblFName
        '
        Me.lblFName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(60, 6)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(79, 14)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name:"
        '
        'txtFName
        '
        Me.txtFName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFName.BackColor = System.Drawing.Color.Ivory
        Me.txtFName.Location = New System.Drawing.Point(60, 30)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(298, 22)
        Me.txtFName.TabIndex = 1
        '
        'lblLName
        '
        Me.lblLName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(60, 60)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(79, 14)
        Me.lblLName.TabIndex = 0
        Me.lblLName.Text = "Last Name:"
        '
        'txtLName
        '
        Me.txtLName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLName.BackColor = System.Drawing.Color.Ivory
        Me.txtLName.Location = New System.Drawing.Point(60, 84)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(298, 22)
        Me.txtLName.TabIndex = 2
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(60, 114)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(58, 14)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender:"
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(60, 195)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(136, 14)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Residential Address:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(198, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 36)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save Details"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.Ivory
        Me.txtPassword.Location = New System.Drawing.Point(60, 408)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(298, 22)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(60, 384)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 14)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Pasword:"
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.BackColor = System.Drawing.Color.Ivory
        Me.txtUserName.Location = New System.Drawing.Point(60, 354)
        Me.txtUserName.MaxLength = 16
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ShortcutsEnabled = False
        Me.txtUserName.Size = New System.Drawing.Size(298, 22)
        Me.txtUserName.TabIndex = 9
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(60, 330)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(81, 14)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User Name:"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.Color.Ivory
        Me.txtAddress.Location = New System.Drawing.Point(60, 219)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.tlpUserDetails.SetRowSpan(Me.txtAddress, 3)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(298, 75)
        Me.txtAddress.TabIndex = 6
        '
        'ptbPhoto
        '
        Me.ptbPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbPhoto.BackColor = System.Drawing.Color.Transparent
        Me.ptbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbPhoto.Image = Global.ACL.My.Resources.Resources.Profile
        Me.ptbPhoto.InitialImage = Nothing
        Me.ptbPhoto.Location = New System.Drawing.Point(429, 30)
        Me.ptbPhoto.Name = "ptbPhoto"
        Me.tlpUserDetails.SetRowSpan(Me.ptbPhoto, 5)
        Me.ptbPhoto.Size = New System.Drawing.Size(129, 129)
        Me.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbPhoto.TabIndex = 29
        Me.ptbPhoto.TabStop = False
        '
        'lblPhoto
        '
        Me.lblPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Location = New System.Drawing.Point(402, 6)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(124, 14)
        Me.lblPhoto.TabIndex = 0
        Me.lblPhoto.Text = "Employee's Photo:"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(402, 195)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(114, 14)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Contact Number:"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.txtPhone, 2)
        Me.txtPhone.Location = New System.Drawing.Point(402, 219)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(298, 22)
        Me.txtPhone.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(402, 249)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 14)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email Address:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.txtEmail, 2)
        Me.txtEmail.Location = New System.Drawing.Point(402, 273)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(298, 22)
        Me.txtEmail.TabIndex = 8
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpUserDetails.SetColumnSpan(Me.btnReset, 2)
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(402, 495)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 36)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset Details"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpload.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(594, 36)
        Me.btnUpload.Name = "btnUpload"
        Me.tlpUserDetails.SetRowSpan(Me.btnUpload, 2)
        Me.btnUpload.Size = New System.Drawing.Size(104, 36)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemove.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(594, 117)
        Me.btnRemove.Name = "btnRemove"
        Me.tlpUserDetails.SetRowSpan(Me.btnRemove, 2)
        Me.btnRemove.Size = New System.Drawing.Size(104, 36)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblCPassword
        '
        Me.lblCPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCPassword.AutoSize = True
        Me.tlpUserDetails.SetColumnSpan(Me.lblCPassword, 2)
        Me.lblCPassword.Location = New System.Drawing.Point(60, 438)
        Me.lblCPassword.Name = "lblCPassword"
        Me.lblCPassword.Size = New System.Drawing.Size(239, 14)
        Me.lblCPassword.TabIndex = 0
        Me.lblCPassword.Text = "Re-Type Password for Conformation:"
        '
        'txtConfirm
        '
        Me.txtConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirm.BackColor = System.Drawing.Color.Ivory
        Me.txtConfirm.Location = New System.Drawing.Point(60, 462)
        Me.txtConfirm.MaxLength = 16
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.ShortcutsEnabled = False
        Me.txtConfirm.Size = New System.Drawing.Size(298, 22)
        Me.txtConfirm.TabIndex = 11
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'cmbQuestion
        '
        Me.cmbQuestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbQuestion.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.cmbQuestion, 2)
        Me.cmbQuestion.FormattingEnabled = True
        Me.cmbQuestion.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbQuestion.Location = New System.Drawing.Point(402, 408)
        Me.cmbQuestion.Name = "cmbQuestion"
        Me.cmbQuestion.Size = New System.Drawing.Size(298, 22)
        Me.cmbQuestion.TabIndex = 13
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbType.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.cmbType, 2)
        Me.cmbType.Items.AddRange(New Object() {"Administrator", "Employee"})
        Me.cmbType.Location = New System.Drawing.Point(402, 354)
        Me.cmbType.MaxDropDownItems = 2
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(298, 22)
        Me.cmbType.Sorted = True
        Me.cmbType.TabIndex = 12
        '
        'txtAnswer
        '
        Me.txtAnswer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnswer.BackColor = System.Drawing.Color.Ivory
        Me.tlpUserDetails.SetColumnSpan(Me.txtAnswer, 2)
        Me.txtAnswer.Location = New System.Drawing.Point(402, 462)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(298, 22)
        Me.txtAnswer.TabIndex = 14
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAnswer.AutoSize = True
        Me.tlpUserDetails.SetColumnSpan(Me.lblAnswer, 2)
        Me.lblAnswer.Location = New System.Drawing.Point(402, 438)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(233, 14)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.Text = "Enter Answer for Security Question:"
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(402, 384)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(165, 14)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Select Security Question:"
        '
        'lblType
        '
        Me.lblType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(402, 330)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(95, 14)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Account Type:"
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGender.BackColor = System.Drawing.Color.Ivory
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(60, 138)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(298, 22)
        Me.cmbGender.Sorted = True
        Me.cmbGender.TabIndex = 3
        '
        'frmUserDetails
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.tlpUserDetails)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(810, 610)
        Me.Name = "frmUserDetails"
        Me.Padding = New System.Windows.Forms.Padding(16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Employee Registration Form"
        Me.tlpUserDetails.ResumeLayout(False)
        Me.tlpUserDetails.PerformLayout()
        CType(Me.ptbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpUserDetails As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents cmbQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents ptbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents lblCPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
End Class
