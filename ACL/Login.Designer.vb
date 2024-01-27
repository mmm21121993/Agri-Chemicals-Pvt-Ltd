<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ptbLogin = New System.Windows.Forms.PictureBox()
        Me.lnkAccount = New System.Windows.Forms.LinkLabel()
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(149, 19)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(81, 14)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "User Name:"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Ivory
        Me.txtUserName.Location = New System.Drawing.Point(152, 36)
        Me.txtUserName.MaxLength = 16
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ShortcutsEnabled = False
        Me.txtUserName.Size = New System.Drawing.Size(270, 22)
        Me.txtUserName.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(149, 69)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(74, 14)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Ivory
        Me.txtPassword.Location = New System.Drawing.Point(152, 86)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(270, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(292, 123)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(75, 0, 85, 0)
        Me.btnLogin.Size = New System.Drawing.Size(130, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Sign In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'ptbLogin
        '
        Me.ptbLogin.BackColor = System.Drawing.Color.Transparent
        Me.ptbLogin.Image = Global.ACL.My.Resources.Resources.Client_Login
        Me.ptbLogin.Location = New System.Drawing.Point(15, 19)
        Me.ptbLogin.Name = "ptbLogin"
        Me.ptbLogin.Size = New System.Drawing.Size(120, 140)
        Me.ptbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbLogin.TabIndex = 0
        Me.ptbLogin.TabStop = False
        '
        'lnkAccount
        '
        Me.lnkAccount.AutoSize = True
        Me.lnkAccount.Location = New System.Drawing.Point(12, 179)
        Me.lnkAccount.Name = "lnkAccount"
        Me.lnkAccount.Size = New System.Drawing.Size(123, 14)
        Me.lnkAccount.TabIndex = 4
        Me.lnkAccount.TabStop = True
        Me.lnkAccount.Text = "Create an Account"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 212)
        Me.Controls.Add(Me.lnkAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.ptbLogin)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(450, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 250)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACL Login"
        CType(Me.ptbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lnkAccount As System.Windows.Forms.LinkLabel

End Class
