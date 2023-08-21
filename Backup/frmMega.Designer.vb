<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMega
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCardCode = New System.Windows.Forms.TextBox
        Me.txtCardName = New System.Windows.Forms.TextBox
        Me.txtTerms = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnLoad = New System.Windows.Forms.Button
        Me.cboTermName = New System.Windows.Forms.ComboBox
        Me.dList = New System.Windows.Forms.DataGridView
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Patient = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Test = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtEdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtSdate = New System.Windows.Forms.DateTimePicker
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(35, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'txtCardCode
        '
        Me.txtCardCode.Location = New System.Drawing.Point(68, 61)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.Size = New System.Drawing.Size(57, 22)
        Me.txtCardCode.TabIndex = 2
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(131, 61)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(148, 22)
        Me.txtCardName.TabIndex = 3
        '
        'txtTerms
        '
        Me.txtTerms.Location = New System.Drawing.Point(100, 139)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.Size = New System.Drawing.Size(57, 22)
        Me.txtTerms.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(131, 219)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 25)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load Excel"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'cboTermName
        '
        Me.cboTermName.FormattingEnabled = True
        Me.cboTermName.Location = New System.Drawing.Point(68, 110)
        Me.cboTermName.Name = "cboTermName"
        Me.cboTermName.Size = New System.Drawing.Size(121, 22)
        Me.cboTermName.TabIndex = 8
        '
        'dList
        '
        Me.dList.AllowUserToAddRows = False
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Account, Me.PostDate, Me.Lab, Me.Patient, Me.Test, Me.Amt, Me.PN})
        Me.dList.Location = New System.Drawing.Point(12, 38)
        Me.dList.Name = "dList"
        Me.dList.ReadOnly = True
        Me.dList.RowHeadersVisible = False
        Me.dList.Size = New System.Drawing.Size(913, 474)
        Me.dList.TabIndex = 9
        '
        'Account
        '
        Me.Account.HeaderText = "AccountName"
        Me.Account.Name = "Account"
        Me.Account.ReadOnly = True
        '
        'PostDate
        '
        Me.PostDate.HeaderText = "PostDate"
        Me.PostDate.Name = "PostDate"
        Me.PostDate.ReadOnly = True
        '
        'Lab
        '
        Me.Lab.HeaderText = "LabNumber"
        Me.Lab.Name = "Lab"
        Me.Lab.ReadOnly = True
        '
        'Patient
        '
        Me.Patient.HeaderText = "Patient"
        Me.Patient.Name = "Patient"
        Me.Patient.ReadOnly = True
        '
        'Test
        '
        Me.Test.HeaderText = "Test"
        Me.Test.Name = "Test"
        Me.Test.ReadOnly = True
        Me.Test.Width = 300
        '
        'Amt
        '
        Me.Amt.HeaderText = "Amount"
        Me.Amt.Name = "Amt"
        Me.Amt.ReadOnly = True
        '
        'PN
        '
        Me.PN.HeaderText = "PN Number"
        Me.PN.Name = "PN"
        Me.PN.ReadOnly = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(114, 356)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 25)
        Me.btnProcess.TabIndex = 10
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(308, 6)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 25)
        Me.btnImport.TabIndex = 11
        Me.btnImport.Text = "Load"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(760, 518)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 25)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "&Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(841, 518)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 14)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "To:"
        '
        'dtEdate
        '
        Me.dtEdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEdate.Location = New System.Drawing.Point(204, 9)
        Me.dtEdate.Name = "dtEdate"
        Me.dtEdate.Size = New System.Drawing.Size(98, 22)
        Me.dtEdate.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Date: From"
        '
        'dtSdate
        '
        Me.dtSdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSdate.Location = New System.Drawing.Point(80, 10)
        Me.dtSdate.Name = "dtSdate"
        Me.dtSdate.Size = New System.Drawing.Size(89, 22)
        Me.dtSdate.TabIndex = 89
        '
        'frmMega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 546)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtEdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtSdate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dList)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.cboTermName)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtTerms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.txtCardCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Sales of Mega"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents cboTermName As System.Windows.Forms.ComboBox
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtEdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtSdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Patient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PN As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
