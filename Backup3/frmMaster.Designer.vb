<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Me.dList = New System.Windows.Forms.DataGridView
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Terms = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cboCat = New System.Windows.Forms.ComboBox
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnProc = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.D = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblPcount = New System.Windows.Forms.Label
        Me.lblUpd = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtEdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtSdate = New System.Windows.Forms.DateTimePicker
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.lblType = New System.Windows.Forms.Label
        Me.cboList = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dList
        '
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardCode, Me.CardName, Me.SAP, Me.Terms})
        Me.dList.Location = New System.Drawing.Point(14, 38)
        Me.dList.Name = "dList"
        Me.dList.RowHeadersVisible = False
        Me.dList.Size = New System.Drawing.Size(714, 484)
        Me.dList.TabIndex = 17
        '
        'CardCode
        '
        Me.CardCode.HeaderText = "CardCode"
        Me.CardCode.Name = "CardCode"
        '
        'CardName
        '
        Me.CardName.HeaderText = "CardName"
        Me.CardName.Name = "CardName"
        Me.CardName.Width = 250
        '
        'SAP
        '
        Me.SAP.HeaderText = "SAP"
        Me.SAP.Name = "SAP"
        '
        'Terms
        '
        Me.Terms.HeaderText = "Terms"
        Me.Terms.Name = "Terms"
        '
        'cboCat
        '
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Items.AddRange(New Object() {"Terms", "CreditLine", "Customer SalesPerson", "Hospital", "DocTor SalesPerson", "Billing Cycle", "Special Item", "Special Package", "COA"})
        Me.cboCat.Location = New System.Drawing.Point(72, 7)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(159, 23)
        Me.cboCat.TabIndex = 16
        Me.cboCat.Text = "Billing Cycle"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(237, 7)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(85, 23)
        Me.btnExcel.TabIndex = 10
        Me.btnExcel.Text = "&Load Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnProc
        '
        Me.btnProc.Location = New System.Drawing.Point(14, 553)
        Me.btnProc.Name = "btnProc"
        Me.btnProc.Size = New System.Drawing.Size(87, 24)
        Me.btnProc.TabIndex = 18
        Me.btnProc.Text = "&Process"
        Me.btnProc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Category"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(951, 553)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 24)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.AllowUserToAddRows = False
        Me.D.AllowUserToDeleteRows = False
        Me.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D.Location = New System.Drawing.Point(734, 38)
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.RowHeadersVisible = False
        Me.D.Size = New System.Drawing.Size(284, 484)
        Me.D.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&Import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblPcount
        '
        Me.lblPcount.AutoSize = True
        Me.lblPcount.Location = New System.Drawing.Point(128, 558)
        Me.lblPcount.Name = "lblPcount"
        Me.lblPcount.Size = New System.Drawing.Size(110, 15)
        Me.lblPcount.TabIndex = 24
        Me.lblPcount.Text = "Customer Count : 0"
        '
        'lblUpd
        '
        Me.lblUpd.AutoSize = True
        Me.lblUpd.Location = New System.Drawing.Point(282, 558)
        Me.lblUpd.Name = "lblUpd"
        Me.lblUpd.Size = New System.Drawing.Size(159, 15)
        Me.lblUpd.TabIndex = 25
        Me.lblUpd.Text = "Updated Customer Count : 0"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(391, 8)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 24)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "C&lear List"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "To:"
        '
        'dtEdate
        '
        Me.dtEdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEdate.Location = New System.Drawing.Point(675, 6)
        Me.dtEdate.Name = "dtEdate"
        Me.dtEdate.Size = New System.Drawing.Size(98, 23)
        Me.dtEdate.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Date: From"
        '
        'dtSdate
        '
        Me.dtSdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSdate.Location = New System.Drawing.Point(558, 7)
        Me.dtSdate.Name = "dtSdate"
        Me.dtSdate.Size = New System.Drawing.Size(89, 23)
        Me.dtSdate.TabIndex = 85
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(12, 524)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(716, 23)
        Me.prbProcess.TabIndex = 89
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(885, 554)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(60, 23)
        Me.btnImport.TabIndex = 20
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        Me.btnImport.Visible = False
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(788, 553)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 23)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "&View History"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(980, 15)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 15)
        Me.lblType.TabIndex = 94
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboList
        '
        Me.cboList.FormattingEnabled = True
        Me.cboList.Items.AddRange(New Object() {"Customers", "Doctors", "Items", "Package", "Salesperson", "Terms"})
        Me.cboList.Location = New System.Drawing.Point(801, 525)
        Me.cboList.Name = "cboList"
        Me.cboList.Size = New System.Drawing.Size(217, 23)
        Me.cboList.TabIndex = 97
        Me.cboList.Text = "Billing Cycle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(734, 528)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Select List"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(856, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(951, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(779, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 24)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Update Transaction"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 581)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dList)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboList)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtEdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtSdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblUpd)
        Me.Controls.Add(Me.lblPcount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProc)
        Me.Controls.Add(Me.cboCat)
        Me.Controls.Add(Me.btnExcel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMaster"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents cboCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnProc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents D As System.Windows.Forms.DataGridView
    Friend WithEvents CardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Terms As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblPcount As System.Windows.Forms.Label
    Friend WithEvents lblUpd As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtEdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtSdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cboList As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
