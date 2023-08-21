<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstrDoc
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
        Me.txtDocName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.CmdLoadExcel = New System.Windows.Forms.Button
        Me.CmdImnport = New System.Windows.Forms.Button
        Me.CmdProcess = New System.Windows.Forms.Button
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.DgridDoc = New System.Windows.Forms.DataGridView
        Me.ClmDCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmHosp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmHospLoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAddr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSched = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCurr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSlpCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSlpName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSpclization = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAcct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmBdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEmail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmRmarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTag = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblPrces = New System.Windows.Forms.Label
        Me.CmdLoad = New System.Windows.Forms.Button
        Me.txtSlpCode = New System.Windows.Forms.TextBox
        Me.txtHospName = New System.Windows.Forms.TextBox
        Me.txtAddr = New System.Windows.Forms.TextBox
        Me.CmdExportExcel = New System.Windows.Forms.Button
        CType(Me.DgridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDocName
        '
        Me.txtDocName.Location = New System.Drawing.Point(132, 8)
        Me.txtDocName.Name = "txtDocName"
        Me.txtDocName.Size = New System.Drawing.Size(166, 20)
        Me.txtDocName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Doctor :"
        '
        'txtDocCode
        '
        Me.txtDocCode.Location = New System.Drawing.Point(58, 8)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(68, 20)
        Me.txtDocCode.TabIndex = 0
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(996, 464)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(69, 24)
        Me.CmdClose.TabIndex = 5
        Me.CmdClose.Text = "Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(12, 464)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(67, 24)
        Me.CmdAdd.TabIndex = 2
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdEdit
        '
        Me.CmdEdit.Enabled = False
        Me.CmdEdit.Location = New System.Drawing.Point(85, 464)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(69, 24)
        Me.CmdEdit.TabIndex = 3
        Me.CmdEdit.Text = "Edit"
        Me.CmdEdit.UseVisualStyleBackColor = True
        '
        'CmdDelete
        '
        Me.CmdDelete.Enabled = False
        Me.CmdDelete.Location = New System.Drawing.Point(160, 464)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(69, 24)
        Me.CmdDelete.TabIndex = 4
        Me.CmdDelete.Text = "Delete"
        Me.CmdDelete.UseVisualStyleBackColor = True
        '
        'CmdLoadExcel
        '
        Me.CmdLoadExcel.Location = New System.Drawing.Point(12, 494)
        Me.CmdLoadExcel.Name = "CmdLoadExcel"
        Me.CmdLoadExcel.Size = New System.Drawing.Size(67, 24)
        Me.CmdLoadExcel.TabIndex = 41
        Me.CmdLoadExcel.Text = "LoadExcel"
        Me.CmdLoadExcel.UseVisualStyleBackColor = True
        '
        'CmdImnport
        '
        Me.CmdImnport.Location = New System.Drawing.Point(85, 494)
        Me.CmdImnport.Name = "CmdImnport"
        Me.CmdImnport.Size = New System.Drawing.Size(69, 24)
        Me.CmdImnport.TabIndex = 40
        Me.CmdImnport.Text = "Import"
        Me.CmdImnport.UseVisualStyleBackColor = True
        '
        'CmdProcess
        '
        Me.CmdProcess.Enabled = False
        Me.CmdProcess.Location = New System.Drawing.Point(160, 494)
        Me.CmdProcess.Name = "CmdProcess"
        Me.CmdProcess.Size = New System.Drawing.Size(69, 24)
        Me.CmdProcess.TabIndex = 43
        Me.CmdProcess.Text = "&Process"
        Me.CmdProcess.UseVisualStyleBackColor = True
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(323, 494)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(742, 24)
        Me.prbProcess.TabIndex = 44
        '
        'DgridDoc
        '
        Me.DgridDoc.AllowUserToAddRows = False
        Me.DgridDoc.AllowUserToDeleteRows = False
        Me.DgridDoc.AllowUserToResizeColumns = False
        Me.DgridDoc.AllowUserToResizeRows = False
        Me.DgridDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmDCode, Me.ClmDName, Me.ClmHosp, Me.ClmHospLoc, Me.ClmAddr, Me.ClmSched, Me.ClmCurr, Me.ClmSlpCode, Me.ClmSlpName, Me.ClmSpclization, Me.ClmAcct, Me.ClmBdate, Me.ClmTel, Me.ClmEmail, Me.ClmRmarks, Me.ClmTag})
        Me.DgridDoc.Location = New System.Drawing.Point(12, 34)
        Me.DgridDoc.MultiSelect = False
        Me.DgridDoc.Name = "DgridDoc"
        Me.DgridDoc.RowHeadersVisible = False
        Me.DgridDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridDoc.Size = New System.Drawing.Size(1055, 424)
        Me.DgridDoc.TabIndex = 6
        '
        'ClmDCode
        '
        Me.ClmDCode.HeaderText = "Code"
        Me.ClmDCode.Name = "ClmDCode"
        Me.ClmDCode.ReadOnly = True
        '
        'ClmDName
        '
        Me.ClmDName.HeaderText = "Name"
        Me.ClmDName.Name = "ClmDName"
        Me.ClmDName.ReadOnly = True
        Me.ClmDName.Width = 150
        '
        'ClmHosp
        '
        Me.ClmHosp.HeaderText = "Hospital Name"
        Me.ClmHosp.Name = "ClmHosp"
        Me.ClmHosp.ReadOnly = True
        Me.ClmHosp.Width = 150
        '
        'ClmHospLoc
        '
        Me.ClmHospLoc.HeaderText = "Hospital Location"
        Me.ClmHospLoc.Name = "ClmHospLoc"
        Me.ClmHospLoc.ReadOnly = True
        Me.ClmHospLoc.Width = 150
        '
        'ClmAddr
        '
        Me.ClmAddr.HeaderText = "Address"
        Me.ClmAddr.Name = "ClmAddr"
        Me.ClmAddr.ReadOnly = True
        Me.ClmAddr.Width = 200
        '
        'ClmSched
        '
        Me.ClmSched.HeaderText = "Sched"
        Me.ClmSched.Name = "ClmSched"
        Me.ClmSched.ReadOnly = True
        Me.ClmSched.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ClmCurr
        '
        Me.ClmCurr.HeaderText = "Curr"
        Me.ClmCurr.Name = "ClmCurr"
        Me.ClmCurr.ReadOnly = True
        Me.ClmCurr.Visible = False
        Me.ClmCurr.Width = 30
        '
        'ClmSlpCode
        '
        Me.ClmSlpCode.HeaderText = "SlpCode"
        Me.ClmSlpCode.Name = "ClmSlpCode"
        Me.ClmSlpCode.ReadOnly = True
        Me.ClmSlpCode.Width = 50
        '
        'ClmSlpName
        '
        Me.ClmSlpName.HeaderText = "SlpNAme"
        Me.ClmSlpName.Name = "ClmSlpName"
        Me.ClmSlpName.ReadOnly = True
        Me.ClmSlpName.Width = 150
        '
        'ClmSpclization
        '
        Me.ClmSpclization.HeaderText = "Specialization"
        Me.ClmSpclization.Name = "ClmSpclization"
        '
        'ClmAcct
        '
        Me.ClmAcct.HeaderText = "Account"
        Me.ClmAcct.Name = "ClmAcct"
        '
        'ClmBdate
        '
        Me.ClmBdate.HeaderText = "Birthday"
        Me.ClmBdate.Name = "ClmBdate"
        '
        'ClmTel
        '
        Me.ClmTel.HeaderText = "Phone"
        Me.ClmTel.Name = "ClmTel"
        '
        'ClmEmail
        '
        Me.ClmEmail.HeaderText = "Email"
        Me.ClmEmail.Name = "ClmEmail"
        '
        'ClmRmarks
        '
        Me.ClmRmarks.HeaderText = "Remarks"
        Me.ClmRmarks.Name = "ClmRmarks"
        '
        'ClmTag
        '
        Me.ClmTag.HeaderText = "Tag"
        Me.ClmTag.Name = "ClmTag"
        Me.ClmTag.ReadOnly = True
        Me.ClmTag.Visible = False
        Me.ClmTag.Width = 30
        '
        'lblPrces
        '
        Me.lblPrces.AutoSize = True
        Me.lblPrces.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrces.Location = New System.Drawing.Point(334, 500)
        Me.lblPrces.MaximumSize = New System.Drawing.Size(721, 13)
        Me.lblPrces.Name = "lblPrces"
        Me.lblPrces.Size = New System.Drawing.Size(25, 13)
        Me.lblPrces.TabIndex = 45
        Me.lblPrces.Text = "------"
        '
        'CmdLoad
        '
        Me.CmdLoad.Location = New System.Drawing.Point(921, 464)
        Me.CmdLoad.Name = "CmdLoad"
        Me.CmdLoad.Size = New System.Drawing.Size(69, 24)
        Me.CmdLoad.TabIndex = 46
        Me.CmdLoad.Text = "Branch"
        Me.CmdLoad.UseVisualStyleBackColor = True
        '
        'txtSlpCode
        '
        Me.txtSlpCode.Location = New System.Drawing.Point(648, 8)
        Me.txtSlpCode.Name = "txtSlpCode"
        Me.txtSlpCode.Size = New System.Drawing.Size(68, 20)
        Me.txtSlpCode.TabIndex = 47
        '
        'txtHospName
        '
        Me.txtHospName.Location = New System.Drawing.Point(304, 8)
        Me.txtHospName.Name = "txtHospName"
        Me.txtHospName.Size = New System.Drawing.Size(166, 20)
        Me.txtHospName.TabIndex = 48
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(476, 8)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(166, 20)
        Me.txtAddr.TabIndex = 49
        '
        'CmdExportExcel
        '
        Me.CmdExportExcel.Location = New System.Drawing.Point(235, 494)
        Me.CmdExportExcel.Name = "CmdExportExcel"
        Me.CmdExportExcel.Size = New System.Drawing.Size(82, 24)
        Me.CmdExportExcel.TabIndex = 50
        Me.CmdExportExcel.Text = "ExportExcel"
        Me.CmdExportExcel.UseVisualStyleBackColor = True
        '
        'frmMstrDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 524)
        Me.Controls.Add(Me.CmdExportExcel)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.txtHospName)
        Me.Controls.Add(Me.txtSlpCode)
        Me.Controls.Add(Me.CmdLoad)
        Me.Controls.Add(Me.lblPrces)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.CmdProcess)
        Me.Controls.Add(Me.CmdLoadExcel)
        Me.Controls.Add(Me.CmdImnport)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.CmdEdit)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.DgridDoc)
        Me.Controls.Add(Me.txtDocName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDocCode)
        Me.MinimumSize = New System.Drawing.Size(1085, 558)
        Me.Name = "frmMstrDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors Master Data"
        CType(Me.DgridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDocName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents CmdLoadExcel As System.Windows.Forms.Button
    Friend WithEvents CmdImnport As System.Windows.Forms.Button
    Friend WithEvents CmdProcess As System.Windows.Forms.Button
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents DgridDoc As System.Windows.Forms.DataGridView
    Friend WithEvents lblPrces As System.Windows.Forms.Label
    Friend WithEvents CmdLoad As System.Windows.Forms.Button
    Friend WithEvents ClmDCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmHosp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmHospLoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAddr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSched As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCurr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSlpCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSlpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSpclization As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAcct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmBdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmRmarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSlpCode As System.Windows.Forms.TextBox
    Friend WithEvents txtHospName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents CmdExportExcel As System.Windows.Forms.Button
End Class
