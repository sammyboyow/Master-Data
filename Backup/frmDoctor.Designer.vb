<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctor
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
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtSlpcode = New System.Windows.Forms.TextBox
        Me.lblPcount = New System.Windows.Forms.Label
        Me.btnProc = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnLoadExcel = New System.Windows.Forms.Button
        Me.btnImnport = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.lblPrces = New System.Windows.Forms.Label
        Me.DCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardName = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dList
        '
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DCode, Me.CardCode, Me.CardName})
        Me.dList.Location = New System.Drawing.Point(5, 37)
        Me.dList.Name = "dList"
        Me.dList.RowHeadersVisible = False
        Me.dList.Size = New System.Drawing.Size(513, 356)
        Me.dList.TabIndex = 17
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(5, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 23)
        Me.txtCode.TabIndex = 27
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(205, 10)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(247, 23)
        Me.txtname.TabIndex = 28
        '
        'txtSlpcode
        '
        Me.txtSlpcode.Location = New System.Drawing.Point(111, 10)
        Me.txtSlpcode.Name = "txtSlpcode"
        Me.txtSlpcode.Size = New System.Drawing.Size(88, 23)
        Me.txtSlpcode.TabIndex = 29
        '
        'lblPcount
        '
        Me.lblPcount.AutoSize = True
        Me.lblPcount.Location = New System.Drawing.Point(677, 398)
        Me.lblPcount.Name = "lblPcount"
        Me.lblPcount.Size = New System.Drawing.Size(95, 15)
        Me.lblPcount.TabIndex = 33
        Me.lblPcount.Text = "Doctor Count : 0"
        '
        'btnProc
        '
        Me.btnProc.Location = New System.Drawing.Point(458, 9)
        Me.btnProc.Name = "btnProc"
        Me.btnProc.Size = New System.Drawing.Size(60, 24)
        Me.btnProc.TabIndex = 32
        Me.btnProc.Text = "&Find"
        Me.btnProc.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(558, 393)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 24)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLoadExcel
        '
        Me.btnLoadExcel.Location = New System.Drawing.Point(4, 398)
        Me.btnLoadExcel.Name = "btnLoadExcel"
        Me.btnLoadExcel.Size = New System.Drawing.Size(69, 23)
        Me.btnLoadExcel.TabIndex = 39
        Me.btnLoadExcel.Text = "LoadExcel"
        Me.btnLoadExcel.UseVisualStyleBackColor = True
        '
        'btnImnport
        '
        Me.btnImnport.Location = New System.Drawing.Point(79, 398)
        Me.btnImnport.Name = "btnImnport"
        Me.btnImnport.Size = New System.Drawing.Size(67, 24)
        Me.btnImnport.TabIndex = 38
        Me.btnImnport.Text = "Import"
        Me.btnImnport.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(152, 398)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(63, 24)
        Me.btnProcess.TabIndex = 40
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(221, 399)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(297, 23)
        Me.prbProcess.TabIndex = 41
        '
        'lblPrces
        '
        Me.lblPrces.AutoSize = True
        Me.lblPrces.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrces.Location = New System.Drawing.Point(230, 403)
        Me.lblPrces.Name = "lblPrces"
        Me.lblPrces.Size = New System.Drawing.Size(31, 15)
        Me.lblPrces.TabIndex = 46
        Me.lblPrces.Text = "------"
        '
        'DCode
        '
        Me.DCode.HeaderText = "Code"
        Me.DCode.Name = "DCode"
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
        'frmDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 430)
        Me.Controls.Add(Me.lblPrces)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnLoadExcel)
        Me.Controls.Add(Me.btnImnport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblPcount)
        Me.Controls.Add(Me.btnProc)
        Me.Controls.Add(Me.txtSlpcode)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.dList)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor List"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtSlpcode As System.Windows.Forms.TextBox
    Friend WithEvents lblPcount As System.Windows.Forms.Label
    Friend WithEvents btnProc As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoadExcel As System.Windows.Forms.Button
    Friend WithEvents btnImnport As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPrces As System.Windows.Forms.Label
    Friend WithEvents DCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
