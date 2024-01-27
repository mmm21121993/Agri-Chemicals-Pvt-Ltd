<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPassword))
        Me.tlpCPassword = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOld = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ptbChangePassword = New System.Windows.Forms.PictureBox()
        Me.tlpCPassword.SuspendLayout()
        CType(Me.ptbChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpCPassword
        '
        Me.tlpCPassword.ColumnCount = 3
        Me.tlpCPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpCPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tlpCPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpCPassword.Controls.Add(Me.lblOld, 1, 0)
        Me.tlpCPassword.Controls.Add(Me.lblNew, 1, 2)
        Me.tlpCPassword.Controls.Add(Me.lblConfirm, 1, 4)
        Me.tlpCPassword.Controls.Add(Me.txtOld, 1, 1)
        Me.tlpCPassword.Controls.Add(Me.txtNew, 1, 3)
        Me.tlpCPassword.Controls.Add(Me.txtConfirm, 1, 5)
        Me.tlpCPassword.Controls.Add(Me.btnChange, 1, 6)
        Me.tlpCPassword.Controls.Add(Me.btnCancel, 2, 6)
        Me.tlpCPassword.Controls.Add(Me.ptbChangePassword, 0, 0)
        Me.tlpCPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCPassword.Location = New System.Drawing.Point(9, 9)
        Me.tlpCPassword.Name = "tlpCPassword"
        Me.tlpCPassword.RowCount = 7
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpCPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCPassword.Size = New System.Drawing.Size(441, 214)
        Me.tlpCPassword.TabIndex = 0
        '
        'lblOld
        '
        Me.lblOld.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOld.AutoSize = True
        Me.tlpCPassword.SetColumnSpan(Me.lblOld, 2)
        Me.lblOld.Location = New System.Drawing.Point(135, 6)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(164, 14)
        Me.lblOld.TabIndex = 0
        Me.lblOld.Text = "Enter Current Password:"
        '
        'lblNew
        '
        Me.lblNew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNew.AutoSize = True
        Me.tlpCPassword.SetColumnSpan(Me.lblNew, 2)
        Me.lblNew.Location = New System.Drawing.Point(135, 60)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(144, 14)
        Me.lblNew.TabIndex = 0
        Me.lblNew.Text = "Enter New Password:"
        '
        'lblConfirm
        '
        Me.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblConfirm.AutoSize = True
        Me.tlpCPassword.SetColumnSpan(Me.lblConfirm, 2)
        Me.lblConfirm.Location = New System.Drawing.Point(135, 114)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(161, 14)
        Me.lblConfirm.TabIndex = 0
        Me.lblConfirm.Text = "Re-Type New Password:"
        '
        'txtOld
        '
        Me.txtOld.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOld.BackColor = System.Drawing.Color.Ivory
        Me.tlpCPassword.SetColumnSpan(Me.txtOld, 2)
        Me.txtOld.Location = New System.Drawing.Point(135, 30)
        Me.txtOld.MaxLength = 16
        Me.txtOld.Name = "txtOld"
        Me.txtOld.ShortcutsEnabled = False
        Me.txtOld.Size = New System.Drawing.Size(303, 22)
        Me.txtOld.TabIndex = 1
        Me.txtOld.UseSystemPasswordChar = True
        '
        'txtNew
        '
        Me.txtNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNew.BackColor = System.Drawing.Color.Ivory
        Me.tlpCPassword.SetColumnSpan(Me.txtNew, 2)
        Me.txtNew.Location = New System.Drawing.Point(135, 84)
        Me.txtNew.MaxLength = 16
        Me.txtNew.Name = "txtNew"
        Me.txtNew.ShortcutsEnabled = False
        Me.txtNew.Size = New System.Drawing.Size(303, 22)
        Me.txtNew.TabIndex = 2
        Me.txtNew.UseSystemPasswordChar = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirm.BackColor = System.Drawing.Color.Ivory
        Me.tlpCPassword.SetColumnSpan(Me.txtConfirm, 2)
        Me.txtConfirm.Location = New System.Drawing.Point(135, 138)
        Me.txtConfirm.MaxLength = 16
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.ShortcutsEnabled = False
        Me.txtConfirm.Size = New System.Drawing.Size(303, 22)
        Me.txtConfirm.TabIndex = 3
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'btnChange
        '
        Me.btnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChange.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(135, 170)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(192, 36)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change Password"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(338, 170)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ptbChangePassword
        '
        Me.ptbChangePassword.Image = Global.ACL.My.Resources.Resources.Change_Password
        Me.ptbChangePassword.Location = New System.Drawing.Point(3, 3)
        Me.ptbChangePassword.Name = "ptbChangePassword"
        Me.tlpCPassword.SetRowSpan(Me.ptbChangePassword, 6)
        Me.ptbChangePassword.Size = New System.Drawing.Size(126, 156)
        Me.ptbChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbChangePassword.TabIndex = 8
        Me.ptbChangePassword.TabStop = False
        '
        'frmCPassword
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 232)
        Me.Controls.Add(Me.tlpCPassword)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(475, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(475, 270)
        Me.Name = "frmCPassword"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chane Account Password"
        Me.tlpCPassword.ResumeLayout(False)
        Me.tlpCPassword.PerformLayout()
        CType(Me.ptbChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpCPassword As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOld As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ptbChangePassword As System.Windows.Forms.PictureBox
End Class
