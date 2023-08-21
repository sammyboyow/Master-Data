<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCust
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
        Me.MotherName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tags = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtMother = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.lblPcount = New System.Windows.Forms.Label
        Me.btnProc = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnLoadExcel = New System.Windows.Forms.Button
        Me.btnImnport = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.lblPrces = New System.Windows.Forms.Label
        Me.D = New System.Windows.Forms.DataGridView
        Me.ln = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DCardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtMot = New System.Windows.Forms.TextBox
        Me.chkChange = New System.Windows.Forms.CheckBox
        Me.txtCardCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCardName = New System.Windows.Forms.TextBox
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dList
        '
        Me.dList.AllowUserToAddRows = False
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MotherName, Me.CardCode, Me.CardName, Me.tags})
        Me.dList.Location = New System.Drawing.Point(5, 37)
        Me.dList.Name = "dList"
        Me.dList.ReadOnly = True
        Me.dList.RowHeadersVisible = False
        Me.dList.Size = New System.Drawing.Size(544, 464)
        Me.dList.TabIndex = 17
        '
        'MotherName
        '
        Me.MotherName.HeaderText = "MotherName"
        Me.MotherName.Name = "MotherName"
        Me.MotherName.ReadOnly = True
        '
        'CardCode
        '
        Me.CardCode.HeaderText = "CardCode"
        Me.CardCode.Name = "CardCode"
        Me.CardCode.ReadOnly = True
        '
        'CardName
        '
        Me.CardName.HeaderText = "CardName"
        Me.CardName.Name = "CardName"
        Me.CardName.ReadOnly = True
        Me.CardName.Width = 300
        '
        'tags
        '
        Me.tags.HeaderText = "tag"
        Me.tags.Name = "tags"
        Me.tags.ReadOnly = True
        Me.tags.Visible = False
        '
        'txtMother
        '
        Me.txtMother.Location = New System.Drawing.Point(5, 10)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.Size = New System.Drawing.Size(100, 23)
        Me.txtMother.TabIndex = 27
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(205, 10)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(278, 23)
        Me.txtname.TabIndex = 28
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(111, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(88, 23)
        Me.txtCode.TabIndex = 29
        '
        'lblPcount
        '
        Me.lblPcount.AutoSize = True
        Me.lblPcount.Location = New System.Drawing.Point(623, 423)
        Me.lblPcount.Name = "lblPcount"
        Me.lblPcount.Size = New System.Drawing.Size(95, 15)
        Me.lblPcount.TabIndex = 33
        Me.lblPcount.Text = "Doctor Count : 0"
        '
        'btnProc
        '
        Me.btnProc.Location = New System.Drawing.Point(489, 8)
        Me.btnProc.Name = "btnProc"
        Me.btnProc.Size = New System.Drawing.Size(60, 24)
        Me.btnProc.TabIndex = 32
        Me.btnProc.Text = "&Find"
        Me.btnProc.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(905, 505)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(63, 24)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export "
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLoadExcel
        '
        Me.btnLoadExcel.Location = New System.Drawing.Point(5, 507)
        Me.btnLoadExcel.Name = "btnLoadExcel"
        Me.btnLoadExcel.Size = New System.Drawing.Size(69, 23)
        Me.btnLoadExcel.TabIndex = 39
        Me.btnLoadExcel.Text = "LoadExcel"
        Me.btnLoadExcel.UseVisualStyleBackColor = True
        '
        'btnImnport
        '
        Me.btnImnport.Location = New System.Drawing.Point(80, 507)
        Me.btnImnport.Name = "btnImnport"
        Me.btnImnport.Size = New System.Drawing.Size(67, 24)
        Me.btnImnport.TabIndex = 38
        Me.btnImnport.Text = "Import"
        Me.btnImnport.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(153, 507)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(63, 24)
        Me.btnProcess.TabIndex = 40
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(222, 508)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(327, 23)
        Me.prbProcess.TabIndex = 41
        '
        'lblPrces
        '
        Me.lblPrces.AutoSize = True
        Me.lblPrces.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrces.Location = New System.Drawing.Point(231, 512)
        Me.lblPrces.Name = "lblPrces"
        Me.lblPrces.Size = New System.Drawing.Size(31, 15)
        Me.lblPrces.TabIndex = 46
        Me.lblPrces.Text = "------"
        '
        'D
        '
        Me.D.AllowUserToAddRows = False
        Me.D.AllowUserToDeleteRows = False
        Me.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ln, Me.DCardCode, Me.DName})
        Me.D.Location = New System.Drawing.Point(559, 37)
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.RowHeadersVisible = False
        Me.D.Size = New System.Drawing.Size(469, 464)
        Me.D.TabIndex = 47
        '
        'ln
        '
        Me.ln.HeaderText = "#"
        Me.ln.Name = "ln"
        Me.ln.ReadOnly = True
        Me.ln.Width = 30
        '
        'DCardCode
        '
        Me.DCardCode.HeaderText = "CardCode"
        Me.DCardCode.Name = "DCardCode"
        Me.DCardCode.ReadOnly = True
        '
        'DName
        '
        Me.DName.HeaderText = "CardName"
        Me.DName.Name = "DName"
        Me.DName.ReadOnly = True
        Me.DName.Width = 300
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(974, 505)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 24)
        Me.btnClose.TabIndex = 48
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtMot
        '
        Me.txtMot.Location = New System.Drawing.Point(658, 506)
        Me.txtMot.Name = "txtMot"
        Me.txtMot.Size = New System.Drawing.Size(161, 23)
        Me.txtMot.TabIndex = 49
        '
        'chkChange
        '
        Me.chkChange.AutoSize = True
        Me.chkChange.Checked = True
        Me.chkChange.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChange.Location = New System.Drawing.Point(827, 508)
        Me.chkChange.Name = "chkChange"
        Me.chkChange.Size = New System.Drawing.Size(66, 19)
        Me.chkChange.TabIndex = 50
        Me.chkChange.Text = "Change"
        Me.chkChange.UseVisualStyleBackColor = True
        '
        'txtCardCode
        '
        Me.txtCardCode.Location = New System.Drawing.Point(586, 8)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.Size = New System.Drawing.Size(96, 23)
        Me.txtCardCode.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Set MotherName"
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(688, 8)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(299, 23)
        Me.txtCardName.TabIndex = 53
        '
        'frmCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 535)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardCode)
        Me.Controls.Add(Me.chkChange)
        Me.Controls.Add(Me.txtMot)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.lblPrces)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnLoadExcel)
        Me.Controls.Add(Me.btnImnport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblPcount)
        Me.Controls.Add(Me.btnProc)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtMother)
        Me.Controls.Add(Me.dList)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transmital Customer Setup"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents txtMother As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPcount As System.Windows.Forms.Label
    Friend WithEvents btnProc As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoadExcel As System.Windows.Forms.Button
    Friend WithEvents btnImnport As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPrces As System.Windows.Forms.Label
    Friend WithEvents MotherName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtMot As System.Windows.Forms.TextBox
    Friend WithEvents chkChange As System.Windows.Forms.CheckBox
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Friend WithEvents ln As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
