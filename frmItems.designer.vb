<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button
        Me.txtOdbc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.dlist = New System.Windows.Forms.DataGridView
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Branch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ODBC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lstQuery = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dPack = New System.Windows.Forms.DataGridView
        Me.btnProcess = New System.Windows.Forms.Button
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.btnPop = New System.Windows.Forms.Button
        Me.dtDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ICODE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDESC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iBranch = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dPack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(242, 21)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "&Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtOdbc
        '
        Me.txtOdbc.Location = New System.Drawing.Point(74, 23)
        Me.txtOdbc.Name = "txtOdbc"
        Me.txtOdbc.Size = New System.Drawing.Size(162, 20)
        Me.txtOdbc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Set ODBC"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(857, 494)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dlist
        '
        Me.dlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.Branch, Me.ODBC})
        Me.dlist.Location = New System.Drawing.Point(37, 50)
        Me.dlist.Name = "dlist"
        Me.dlist.RowHeadersVisible = False
        Me.dlist.Size = New System.Drawing.Size(374, 438)
        Me.dlist.TabIndex = 4
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.Name = "code"
        Me.code.Width = 70
        '
        'Branch
        '
        Me.Branch.HeaderText = "Branch"
        Me.Branch.Name = "Branch"
        Me.Branch.Width = 200
        '
        'ODBC
        '
        Me.ODBC.HeaderText = "ODBC"
        Me.ODBC.Name = "ODBC"
        '
        'lstQuery
        '
        Me.lstQuery.FormattingEnabled = True
        Me.lstQuery.Location = New System.Drawing.Point(619, 146)
        Me.lstQuery.Name = "lstQuery"
        Me.lstQuery.Size = New System.Drawing.Size(116, 277)
        Me.lstQuery.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(633, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dPack
        '
        Me.dPack.AllowUserToAddRows = False
        Me.dPack.AllowUserToDeleteRows = False
        Me.dPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dPack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LN, Me.ICODE, Me.IDESC, Me.iBranch})
        Me.dPack.Location = New System.Drawing.Point(417, 50)
        Me.dPack.Name = "dPack"
        Me.dPack.ReadOnly = True
        Me.dPack.RowHeadersVisible = False
        Me.dPack.Size = New System.Drawing.Size(504, 438)
        Me.dPack.TabIndex = 7
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(776, 494)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 8
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(37, 494)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(733, 23)
        Me.prbProcess.TabIndex = 9
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(848, 22)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 23)
        Me.btnPop.TabIndex = 10
        Me.btnPop.Text = "Populate"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(721, 24)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(121, 20)
        Me.dtDate.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(666, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Populate"
        '
        'LN
        '
        Me.LN.HeaderText = "#"
        Me.LN.Name = "LN"
        Me.LN.ReadOnly = True
        Me.LN.Width = 30
        '
        'ICODE
        '
        Me.ICODE.HeaderText = "ICODE"
        Me.ICODE.Name = "ICODE"
        Me.ICODE.ReadOnly = True
        '
        'IDESC
        '
        Me.IDESC.HeaderText = "IDESC"
        Me.IDESC.Name = "IDESC"
        Me.IDESC.ReadOnly = True
        Me.IDESC.Width = 300
        '
        'iBranch
        '
        Me.iBranch.HeaderText = "Branch"
        Me.iBranch.Name = "iBranch"
        Me.iBranch.ReadOnly = True
        Me.iBranch.Width = 70
        '
        'frmPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 529)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.dPack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstQuery)
        Me.Controls.Add(Me.dlist)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOdbc)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmPackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Package"
        CType(Me.dlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dPack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtOdbc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dlist As System.Windows.Forms.DataGridView
    Friend WithEvents lstQuery As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dPack As System.Windows.Forms.DataGridView
    Friend WithEvents code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ODBC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents btnPop As System.Windows.Forms.Button
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ICODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iBranch As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
