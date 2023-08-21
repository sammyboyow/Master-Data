<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctors
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDocname = New System.Windows.Forms.TextBox
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.txtSlpCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSpcliz = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddr = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHospName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtHospLoc = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRmarks = New System.Windows.Forms.TextBox
        Me.CmdFindSlp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAccnt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSched = New System.Windows.Forms.TextBox
        Me.DpBdate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtDocCode
        '
        Me.txtDocCode.Location = New System.Drawing.Point(97, 12)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(83, 20)
        Me.txtDocCode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Doctor :"
        '
        'txtDocname
        '
        Me.txtDocname.Location = New System.Drawing.Point(186, 12)
        Me.txtDocname.Name = "txtDocname"
        Me.txtDocname.Size = New System.Drawing.Size(215, 20)
        Me.txtDocname.TabIndex = 1
        '
        'CmdAdd
        '
        Me.CmdAdd.Enabled = False
        Me.CmdAdd.Location = New System.Drawing.Point(96, 246)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(54, 24)
        Me.CmdAdd.TabIndex = 14
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(347, 246)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(54, 24)
        Me.CmdClose.TabIndex = 15
        Me.CmdClose.Text = "Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(195, 42)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Specialization :"
        '
        'txtSlpCode
        '
        Me.txtSlpCode.Location = New System.Drawing.Point(97, 39)
        Me.txtSlpCode.Name = "txtSlpCode"
        Me.txtSlpCode.Size = New System.Drawing.Size(53, 20)
        Me.txtSlpCode.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SlpCode :"
        '
        'txtSpcliz
        '
        Me.txtSpcliz.Location = New System.Drawing.Point(279, 39)
        Me.txtSpcliz.Name = "txtSpcliz"
        Me.txtSpcliz.Size = New System.Drawing.Size(122, 20)
        Me.txtSpcliz.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tel no. :"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(97, 64)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(112, 20)
        Me.txtTel.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address :"
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(97, 90)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(304, 20)
        Me.txtAddr.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Hospital Name :"
        '
        'txtHospName
        '
        Me.txtHospName.Location = New System.Drawing.Point(97, 168)
        Me.txtHospName.Name = "txtHospName"
        Me.txtHospName.Size = New System.Drawing.Size(304, 20)
        Me.txtHospName.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Hospital Loc :"
        '
        'txtHospLoc
        '
        Me.txtHospLoc.Location = New System.Drawing.Point(97, 194)
        Me.txtHospLoc.Name = "txtHospLoc"
        Me.txtHospLoc.Size = New System.Drawing.Size(304, 20)
        Me.txtHospLoc.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Remarks :"
        '
        'txtRmarks
        '
        Me.txtRmarks.Location = New System.Drawing.Point(97, 220)
        Me.txtRmarks.Name = "txtRmarks"
        Me.txtRmarks.Size = New System.Drawing.Size(304, 20)
        Me.txtRmarks.TabIndex = 13
        '
        'CmdFindSlp
        '
        Me.CmdFindSlp.Location = New System.Drawing.Point(156, 39)
        Me.CmdFindSlp.Name = "CmdFindSlp"
        Me.CmdFindSlp.Size = New System.Drawing.Size(24, 20)
        Me.CmdFindSlp.TabIndex = 2
        Me.CmdFindSlp.Text = "..."
        Me.CmdFindSlp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Email :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(279, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(122, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Birthday :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Sched :"
        '
        'txtAccnt
        '
        Me.txtAccnt.Location = New System.Drawing.Point(279, 116)
        Me.txtAccnt.Name = "txtAccnt"
        Me.txtAccnt.Size = New System.Drawing.Size(122, 20)
        Me.txtAccnt.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(200, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Account No. :"
        '
        'txtSched
        '
        Me.txtSched.Location = New System.Drawing.Point(97, 142)
        Me.txtSched.Name = "txtSched"
        Me.txtSched.Size = New System.Drawing.Size(304, 20)
        Me.txtSched.TabIndex = 10
        '
        'DpBdate
        '
        Me.DpBdate.CustomFormat = "MM/dd/yyyy"
        Me.DpBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DpBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DpBdate.Location = New System.Drawing.Point(97, 116)
        Me.DpBdate.Name = "DpBdate"
        Me.DpBdate.Size = New System.Drawing.Size(97, 20)
        Me.DpBdate.TabIndex = 30
        '
        'frmDoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 274)
        Me.Controls.Add(Me.DpBdate)
        Me.Controls.Add(Me.txtSched)
        Me.Controls.Add(Me.txtAccnt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdFindSlp)
        Me.Controls.Add(Me.txtRmarks)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHospLoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHospName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSpcliz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSlpCode)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.txtDocname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDocCode)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 308)
        Me.Name = "frmDoctors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDocname As System.Windows.Forms.TextBox
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txtSlpCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSpcliz As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHospName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHospLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRmarks As System.Windows.Forms.TextBox
    Friend WithEvents CmdFindSlp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAccnt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSched As System.Windows.Forms.TextBox
    Friend WithEvents DpBdate As System.Windows.Forms.DateTimePicker

End Class
