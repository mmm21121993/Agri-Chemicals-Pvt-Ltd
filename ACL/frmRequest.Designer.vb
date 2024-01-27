<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequest))
        Me.tlpRequest = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOPR = New System.Windows.Forms.Label()
        Me.lblRequester = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblOPRNo = New System.Windows.Forms.Label()
        Me.lblRequesterName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tlpRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRequest
        '
        Me.tlpRequest.ColumnCount = 4
        Me.tlpRequest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpRequest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRequest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpRequest.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRequest.Controls.Add(Me.lblOPR, 0, 1)
        Me.tlpRequest.Controls.Add(Me.lblRequester, 0, 3)
        Me.tlpRequest.Controls.Add(Me.lblReason, 0, 5)
        Me.tlpRequest.Controls.Add(Me.txtRequest, 0, 7)
        Me.tlpRequest.Controls.Add(Me.btnCancel, 2, 9)
        Me.tlpRequest.Controls.Add(Me.lblOPRNo, 1, 1)
        Me.tlpRequest.Controls.Add(Me.lblRequesterName, 1, 3)
        Me.tlpRequest.Controls.Add(Me.btnSubmit, 0, 9)
        Me.tlpRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRequest.Location = New System.Drawing.Point(0, 0)
        Me.tlpRequest.Margin = New System.Windows.Forms.Padding(9)
        Me.tlpRequest.Name = "tlpRequest"
        Me.tlpRequest.RowCount = 10
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.tlpRequest.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpRequest.Size = New System.Drawing.Size(524, 302)
        Me.tlpRequest.TabIndex = 0
        '
        'lblOPR
        '
        Me.lblOPR.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPR.AutoSize = True
        Me.lblOPR.Location = New System.Drawing.Point(13, 15)
        Me.lblOPR.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblOPR.Name = "lblOPR"
        Me.lblOPR.Size = New System.Drawing.Size(124, 14)
        Me.lblOPR.TabIndex = 0
        Me.lblOPR.Text = "OPR Number :"
        '
        'lblRequester
        '
        Me.lblRequester.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequester.AutoSize = True
        Me.lblRequester.Location = New System.Drawing.Point(13, 51)
        Me.lblRequester.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblRequester.Name = "lblRequester"
        Me.lblRequester.Size = New System.Drawing.Size(124, 14)
        Me.lblRequester.TabIndex = 1
        Me.lblRequester.Text = "Requester Name :"
        '
        'lblReason
        '
        Me.lblReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReason.AutoSize = True
        Me.tlpRequest.SetColumnSpan(Me.lblReason, 4)
        Me.lblReason.Location = New System.Drawing.Point(13, 87)
        Me.lblReason.Margin = New System.Windows.Forms.Padding(13, 0, 3, 0)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(508, 14)
        Me.lblReason.TabIndex = 2
        Me.lblReason.Text = "Please, enter reason to delete the OPO details :"
        '
        'txtRequest
        '
        Me.txtRequest.BackColor = System.Drawing.Color.Ivory
        Me.tlpRequest.SetColumnSpan(Me.txtRequest, 4)
        Me.txtRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRequest.Location = New System.Drawing.Point(13, 120)
        Me.txtRequest.Margin = New System.Windows.Forms.Padding(13, 3, 13, 3)
        Me.txtRequest.Multiline = True
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequest.Size = New System.Drawing.Size(498, 125)
        Me.txtRequest.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpRequest.SetColumnSpan(Me.btnCancel, 2)
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(275, 264)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(13, 3, 3, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 31)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel Request"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblOPRNo
        '
        Me.lblOPRNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOPRNo.AutoSize = True
        Me.tlpRequest.SetColumnSpan(Me.lblOPRNo, 2)
        Me.lblOPRNo.Location = New System.Drawing.Point(143, 15)
        Me.lblOPRNo.Name = "lblOPRNo"
        Me.lblOPRNo.Size = New System.Drawing.Size(256, 14)
        Me.lblOPRNo.TabIndex = 8
        '
        'lblRequesterName
        '
        Me.lblRequesterName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequesterName.AutoSize = True
        Me.tlpRequest.SetColumnSpan(Me.lblRequesterName, 2)
        Me.lblRequesterName.Location = New System.Drawing.Point(143, 51)
        Me.lblRequesterName.Name = "lblRequesterName"
        Me.lblRequesterName.Size = New System.Drawing.Size(256, 14)
        Me.lblRequesterName.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tlpRequest.SetColumnSpan(Me.btnSubmit, 2)
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(119, 264)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 3, 13, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(130, 31)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit Request"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 302)
        Me.Controls.Add(Me.tlpRequest)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(540, 340)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(540, 340)
        Me.Name = "frmRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OPR Deletion Request Form"
        Me.tlpRequest.ResumeLayout(False)
        Me.tlpRequest.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpRequest As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOPR As System.Windows.Forms.Label
    Friend WithEvents lblRequester As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtRequest As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblOPRNo As System.Windows.Forms.Label
    Friend WithEvents lblRequesterName As System.Windows.Forms.Label
End Class
