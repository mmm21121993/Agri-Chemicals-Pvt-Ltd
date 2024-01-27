<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.tlpSupplier = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPost = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvPhone = New System.Windows.Forms.DataGridView()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFax = New System.Windows.Forms.DataGridView()
        Me.colFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvContact = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpSupplier.SuspendLayout()
        CType(Me.dgvPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpSupplier
        '
        Me.tlpSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpSupplier.ColumnCount = 5
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.tlpSupplier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.0!))
        Me.tlpSupplier.Controls.Add(Me.txtName, 1, 1)
        Me.tlpSupplier.Controls.Add(Me.lblName, 0, 1)
        Me.tlpSupplier.Controls.Add(Me.lblPhone, 0, 11)
        Me.tlpSupplier.Controls.Add(Me.lblFax, 3, 11)
        Me.tlpSupplier.Controls.Add(Me.lblContact, 0, 14)
        Me.tlpSupplier.Controls.Add(Me.btnReset, 3, 16)
        Me.tlpSupplier.Controls.Add(Me.btnSave, 0, 16)
        Me.tlpSupplier.Controls.Add(Me.lblType, 3, 1)
        Me.tlpSupplier.Controls.Add(Me.txtType, 4, 1)
        Me.tlpSupplier.Controls.Add(Me.lblAddress, 0, 3)
        Me.tlpSupplier.Controls.Add(Me.lblCountry, 3, 3)
        Me.tlpSupplier.Controls.Add(Me.txtAddress, 1, 3)
        Me.tlpSupplier.Controls.Add(Me.lblCity, 3, 5)
        Me.tlpSupplier.Controls.Add(Me.lblPost, 3, 7)
        Me.tlpSupplier.Controls.Add(Me.txtCountry, 4, 3)
        Me.tlpSupplier.Controls.Add(Me.txtCity, 4, 5)
        Me.tlpSupplier.Controls.Add(Me.txtCode, 4, 7)
        Me.tlpSupplier.Controls.Add(Me.txtComment, 4, 9)
        Me.tlpSupplier.Controls.Add(Me.lblComments, 3, 9)
        Me.tlpSupplier.Controls.Add(Me.txtWebsite, 1, 9)
        Me.tlpSupplier.Controls.Add(Me.lblWebsite, 0, 9)
        Me.tlpSupplier.Controls.Add(Me.btnSearch, 2, 0)
        Me.tlpSupplier.Controls.Add(Me.dgvPhone, 1, 11)
        Me.tlpSupplier.Controls.Add(Me.dgvFax, 4, 11)
        Me.tlpSupplier.Controls.Add(Me.dgvContact, 0, 15)
        Me.tlpSupplier.Location = New System.Drawing.Point(16, 9)
        Me.tlpSupplier.Name = "tlpSupplier"
        Me.tlpSupplier.RowCount = 18
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpSupplier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSupplier.Size = New System.Drawing.Size(902, 564)
        Me.tlpSupplier.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.BackColor = System.Drawing.Color.Ivory
        Me.txtName.Location = New System.Drawing.Point(97, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 22)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 14)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblPhone
        '
        Me.lblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(3, 183)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(88, 14)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone No:"
        '
        'lblFax
        '
        Me.lblFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(474, 183)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(88, 14)
        Me.lblFax.TabIndex = 0
        Me.lblFax.Text = "Fax No:"
        '
        'lblContact
        '
        Me.lblContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContact.AutoSize = True
        Me.tlpSupplier.SetColumnSpan(Me.lblContact, 2)
        Me.lblContact.Location = New System.Drawing.Point(3, 307)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(423, 14)
        Me.lblContact.TabIndex = 0
        Me.lblContact.Text = "Contact Information:"
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpSupplier.SetColumnSpan(Me.btnReset, 2)
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(480, 522)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(9, 3, 3, 3)
        Me.btnReset.Name = "btnReset"
        Me.tlpSupplier.SetRowSpan(Me.btnReset, 2)
        Me.btnReset.Size = New System.Drawing.Size(160, 36)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset Details"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tlpSupplier.SetColumnSpan(Me.btnSave, 2)
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(260, 522)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 3, 9, 3)
        Me.btnSave.Name = "btnSave"
        Me.tlpSupplier.SetRowSpan(Me.btnSave, 2)
        Me.btnSave.Size = New System.Drawing.Size(160, 36)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Details"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(474, 13)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(88, 14)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type:"
        '
        'txtType
        '
        Me.txtType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtType.BackColor = System.Drawing.Color.Ivory
        Me.txtType.Location = New System.Drawing.Point(568, 10)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(331, 22)
        Me.txtType.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(3, 47)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(88, 14)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address:"
        '
        'lblCountry
        '
        Me.lblCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(474, 47)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(88, 14)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.Text = "Country:"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.Color.Ivory
        Me.txtAddress.Location = New System.Drawing.Point(97, 45)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.tlpSupplier.SetRowSpan(Me.txtAddress, 5)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(329, 86)
        Me.txtAddress.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(474, 81)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(88, 14)
        Me.lblCity.TabIndex = 0
        Me.lblCity.Text = "City:"
        '
        'lblPost
        '
        Me.lblPost.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPost.AutoSize = True
        Me.lblPost.Location = New System.Drawing.Point(474, 115)
        Me.lblPost.Name = "lblPost"
        Me.lblPost.Size = New System.Drawing.Size(88, 14)
        Me.lblPost.TabIndex = 0
        Me.lblPost.Text = "Postal Code:"
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCountry.AutoCompleteCustomSource.AddRange(New String() {"Afghanistan", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei ", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Curacao", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa ", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain ", "Sri Lanka", "Sudan", "Suriname", "Swaziland ", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand ", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCountry.BackColor = System.Drawing.Color.Ivory
        Me.txtCountry.Location = New System.Drawing.Point(568, 44)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(331, 22)
        Me.txtCountry.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.AutoCompleteCustomSource.AddRange(New String() {"Agra", "Ahmedabad", "Ajanta", "Ajmer", "Alleppey", "Ambalangoda", "Ambon", "Ampara", "Amritsar", "Anshan", "Anuradhapura", "Anyang", "Aurangabad", "Avissawella", "Ayodhya", "Badulla", "Balangoda", "Balikpapan", "Banda Aceh", "Bandar Lampung", "Bandarawela", "Bandhavgarh", "Bandhavgarh", "Bandung", "Bangalore", "Banjar", "Banjarbaru", "Banjarmasin", "Baoding", "Baotou", "Barmer", "Baroda", "Batam", "Batticaloa", "Batu", "Baturaja", "Bau-Bau", "Beijing", "Bekasi", "Belur", "Bengkulu", "Benxi", "Beruwala", "Bharatpur", "Bhavnagar", "Bhopal", "Bhubaneshwar", "Bhuj", "Bikaner", "Bima", "Binjai", "Bitung", "Blitar", "Bodhgaya", "Bogor", "Bontang", "Bukittinggi", "Bundi", "Changchun", "Changde", "Changsha", "Changzhou", "Chavakacheri", "Chengdu", "Chennai", "Chettinad", "Chiayi", "Chilaw", "Chittorgarh", "Chongqing", "Cilegon", "Cimahi", "Cirebon", "Cochin", "Coimbatore", "Colombo", "Coonoor", "Coorg", "Corbett", "Dalhousie", "Dalian", "Dambulla", "Darjeeling", "Datong", "Dehiwala-Mount Lavinia", "Dehradun", "Delhi", "Denpasar", "Depok", "Dharamsala", "Dispur", "Dudhwa", "Dumai", "Ellora", "Eravur", "Foshan", "Fushun", "Fuzhou", "Galle", "Gampaha", "Gampola", "Gandhi Nagar", "Gangtok", "Gondal", "Gorakhpur", "Gorontalo", "Guangzhou", "Guiyang", "Guwahati", "Gwalior", "Halebid", "Hambantota", "Hampi", "Handan", "Hangzhou", "Haputale", "Harbin", "Haridwar", "Harispattuwa", "Hatton", "Hefei", "Hengyang", "Hohhot", "Hong Kong", "Horana", "Hsinchu", "Huai'an", "Huainan", "Hyderabad", "Imphal", "Indore", "Itanagar", "Ja-Ela", "Jabalpur", "Jaffna", "Jaipur", "Jaisalmer", "Jakarta", "Jambi", "Jayapura", "Jember", "Jilin City", "Jinan", "Jingzhou", "Jodhpur", "Kadugannawa", "Kalimpong", "Kalmunai", "Kalutara", "Kanchipuram", "Kandy", "Kanha", "Kanyakumari", "Kaohsiung", "Kattankudy", "Katunayake", "Kaziranga", "Kedarnath", "Kediri", "Keelung", "Kegalle", "Kelaniya", "Kendari", "Khajuraho", "Kodaikanal", "Kohima", "Kolkata", "Kolonnawa", "konark", "Kota", "Kovalam", "Kudus", "Kuliyapitiya", "Kullu", "Kumarakom", "Kumbhalgarh", "Kunming", "Kupang", "Kurunegala", "Kushinagar", "Ladakh", "Langsa", "Lanzhou", "Leh", "Lhokseumawe", "Liuzhou", "Lubuklinggau", "Lucknow", "Luoyang", "Luzhou", "Macau", "Madiun", "Madurai", "Magelang", "Mahabalipuram", "Makassar", "Malang", "Manado", "Manali", "Mandawa", "Mangalore", "Mannar", "Matale", "Matara", "Mataram", "Matheran", "Medan", "Metro", "Mianyang", "Minuwangoda", "Mojokerto", "Moneragala", "Moratuwa", "Mount Abu", "Mukundgarh", "Mumbai", "Munnar", "Mysore", "Nagpur", "Nainital", "Nalanda", "Nanchang", "Nanchong", "Nanjing", "Nanning", "Nanyang", "Nawalapitiya", "Nawalgarh", "Negombo", "Neijiang", "New Taipei", "Ningbo", "Noida", "Nuwara Eliya", "Ooty", "Orchha", "Padang", "Padang Panjang", "Padang Sidempuan", "Pagar Alam", "Palangkaraya", "Palembang", "Palopo", "Palu", "Panadura", "Panaji", "Pangkal Pinang", "Pare-Pare", "Pariaman", "Pasuruan", "Patna", "Payakumbuh", "Pekalongan", "Pekanbaru", "Peliyagoda", "Pematang Siantar", "Periyar", "Point Pedro", "Pontianak", "Prabumulih", "Probolinggo", "Puri", "Purwokerto", "Pushkar", "Puttalam", "Qingdao", "Quanzhou", "Rajgir", "Ranakpur", "Ranchi", "Ranthambore", "Ratnapura", "Rishikesh", "Rohtang Pass", "Sabang", "Salatiga", "Samarinda", "Samode", "Sanchi", "Sariska", "Sarnath", "Sasangir", "Sawah Lunto", "Sawai Madhopur", "Seethawakapura/", "Semarang", "Serang", "Shanghai", "Shangqiu", "Shantou", "Shekhawati", "Shenyang", "Shenzhen", "Shijiazhuang", "Shimla", "Sibolga", "Sidoarjo", "Sigiriya", "Siliguri", "Silvassa", "Singkawang", "Solok", "Sorong", "South Tangerang", "Sravasti", "Sri Jayawardenapura Kotte", "Srinagar", "Sukabumi", "Surabaya", "Surakarta", "Surat", "Suzhou", "Taichung", "Tainan", "Taipei", "Taiyuan", "Talawakele", "Tangalle", "Tangerang", "Tangshan", "Tanjore", "Tanjung Balai", "Tanjung Pinang", "Taoyuan", "Tarakan", "Tasikmalaya", "Tebing Tinggi", "Tegal", "Tenggarong", "Ternate", "Thrissur", "Tianjin", "Tidore", "Tomohon", "Trichy", "Trincomalee", "Trivandrum", "Udaipur", "Umaria", "Ürümqi", "Utelia", "Uttarkashi", "Vaishali", "Valvettithurai", "Varanasi", "Varkala", "Vavuniya", "Vizag", "Wattala", "Wattegama", "Weifang", "Weligama", "Wuhan", "Wuxi", "Xi'an", "Xiamen", "Xiangyang", "Xining", "Xuzhou", "Yantai", "Yichang", "Yinchuan", "Yiyang", "Yogyakarta", "Zainabad", "Zhengzhou"})
        Me.txtCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCity.BackColor = System.Drawing.Color.Ivory
        Me.txtCity.Location = New System.Drawing.Point(568, 78)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(331, 22)
        Me.txtCity.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.BackColor = System.Drawing.Color.Ivory
        Me.txtCode.Location = New System.Drawing.Point(568, 112)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(331, 22)
        Me.txtCode.TabIndex = 6
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComment.AutoCompleteCustomSource.AddRange(New String() {"None"})
        Me.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComment.BackColor = System.Drawing.Color.Ivory
        Me.txtComment.Location = New System.Drawing.Point(568, 146)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(331, 22)
        Me.txtComment.TabIndex = 8
        '
        'lblComments
        '
        Me.lblComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(474, 149)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(88, 14)
        Me.lblComments.TabIndex = 0
        Me.lblComments.Text = "Comments:"
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWebsite.AutoCompleteCustomSource.AddRange(New String() {"None"})
        Me.txtWebsite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtWebsite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtWebsite.BackColor = System.Drawing.Color.Ivory
        Me.txtWebsite.Location = New System.Drawing.Point(97, 146)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(329, 22)
        Me.txtWebsite.TabIndex = 7
        '
        'lblWebsite
        '
        Me.lblWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(3, 149)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(88, 14)
        Me.lblWebsite.TabIndex = 0
        Me.lblWebsite.Text = "Website:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.Image = Global.ACL.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(432, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.tlpSupplier.SetRowSpan(Me.btnSearch, 3)
        Me.btnSearch.Size = New System.Drawing.Size(35, 35)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.UseVisualStyleBackColor = True
        Me.btnSearch.Visible = False
        '
        'dgvPhone
        '
        Me.dgvPhone.AllowUserToResizeColumns = False
        Me.dgvPhone.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPhone.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPhone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPhone.BackgroundColor = System.Drawing.Color.White
        Me.dgvPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPhone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPhone})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPhone.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPhone.Location = New System.Drawing.Point(97, 180)
        Me.dgvPhone.Name = "dgvPhone"
        Me.dgvPhone.RowHeadersWidth = 54
        Me.dgvPhone.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.dgvPhone.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.tlpSupplier.SetRowSpan(Me.dgvPhone, 2)
        Me.dgvPhone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPhone.Size = New System.Drawing.Size(329, 111)
        Me.dgvPhone.TabIndex = 9
        '
        'colPhone
        '
        Me.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPhone.DataPropertyName = "Phone"
        Me.colPhone.HeaderText = "Phone Number"
        Me.colPhone.Name = "colPhone"
        '
        'dgvFax
        '
        Me.dgvFax.AllowUserToResizeColumns = False
        Me.dgvFax.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFax.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFax.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFax.BackgroundColor = System.Drawing.Color.White
        Me.dgvFax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFax.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFax.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFax})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFax.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFax.Location = New System.Drawing.Point(568, 180)
        Me.dgvFax.Name = "dgvFax"
        Me.dgvFax.RowHeadersWidth = 54
        Me.dgvFax.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.dgvFax.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.tlpSupplier.SetRowSpan(Me.dgvFax, 2)
        Me.dgvFax.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFax.Size = New System.Drawing.Size(331, 111)
        Me.dgvFax.TabIndex = 10
        '
        'colFax
        '
        Me.colFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFax.DataPropertyName = "Fax"
        Me.colFax.HeaderText = "Fax Number"
        Me.colFax.Name = "colFax"
        '
        'dgvContact
        '
        Me.dgvContact.AllowUserToResizeColumns = False
        Me.dgvContact.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvContact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContact.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContact.BackgroundColor = System.Drawing.Color.White
        Me.dgvContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContact.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colEmail, Me.colMobile})
        Me.tlpSupplier.SetColumnSpan(Me.dgvContact, 5)
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContact.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvContact.Location = New System.Drawing.Point(3, 331)
        Me.dgvContact.Name = "dgvContact"
        Me.dgvContact.RowHeadersWidth = 54
        Me.dgvContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.dgvContact.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvContact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvContact.Size = New System.Drawing.Size(896, 183)
        Me.dgvContact.TabIndex = 11
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.DataPropertyName = "Name"
        Me.colName.HeaderText = "Contact Person Name"
        Me.colName.Name = "colName"
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.DataPropertyName = "Email"
        Me.colEmail.HeaderText = "Email Address"
        Me.colEmail.Name = "colEmail"
        '
        'colMobile
        '
        Me.colMobile.DataPropertyName = "Mobile"
        Me.colMobile.HeaderText = "Mobile Number"
        Me.colMobile.Name = "colMobile"
        '
        'frmSupplier
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 582)
        Me.Controls.Add(Me.tlpSupplier)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 620)
        Me.Name = "frmSupplier"
        Me.Padding = New System.Windows.Forms.Padding(16, 7, 16, 7)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Supplier Registration"
        Me.tlpSupplier.ResumeLayout(False)
        Me.tlpSupplier.PerformLayout()
        CType(Me.dgvPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSupplier As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblWebsite As System.Windows.Forms.Label
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblPost As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvPhone As System.Windows.Forms.DataGridView
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvFax As System.Windows.Forms.DataGridView
    Friend WithEvents colFax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvContact As System.Windows.Forms.DataGridView
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobile As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
