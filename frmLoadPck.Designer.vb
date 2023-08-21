<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadPck
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
        Me.CmdLoad = New System.Windows.Forms.Button
        Me.DgridOdbcList = New System.Windows.Forms.DataGridView
        Me.ClmOCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmOBrnch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmOdbc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DgridDoc = New System.Windows.Forms.DataGridView
        Me.ClmNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDBrnch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CmdProcess = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        Me.lblprcs = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lblLoad = New System.Windows.Forms.Label
        Me.CboPrces = New System.Windows.Forms.ComboBox
        CType(Me.DgridOdbcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdLoad
        '
        Me.CmdLoad.Enabled = False
        Me.CmdLoad.Location = New System.Drawing.Point(12, 494)
        Me.CmdLoad.Name = "CmdLoad"
        Me.CmdLoad.Size = New System.Drawing.Size(67, 24)
        Me.CmdLoad.TabIndex = 5
        Me.CmdLoad.Text = "Load"
        Me.CmdLoad.UseVisualStyleBackColor = True
        '
        'DgridOdbcList
        '
        Me.DgridOdbcList.AllowUserToAddRows = False
        Me.DgridOdbcList.AllowUserToDeleteRows = False
        Me.DgridOdbcList.AllowUserToResizeColumns = False
        Me.DgridOdbcList.AllowUserToResizeRows = False
        Me.DgridOdbcList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridOdbcList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmOCode, Me.ClmOBrnch, Me.ClmOdbc})
        Me.DgridOdbcList.Location = New System.Drawing.Point(12, 12)
        Me.DgridOdbcList.MultiSelect = False
        Me.DgridOdbcList.Name = "DgridOdbcList"
        Me.DgridOdbcList.ReadOnly = True
        Me.DgridOdbcList.RowHeadersVisible = False
        Me.DgridOdbcList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridOdbcList.Size = New System.Drawing.Size(379, 449)
        Me.DgridOdbcList.TabIndex = 9
        '
        'ClmOCode
        '
        Me.ClmOCode.HeaderText = "Code"
        Me.ClmOCode.Name = "ClmOCode"
        Me.ClmOCode.ReadOnly = True
        Me.ClmOCode.Width = 200
        '
        'ClmOBrnch
        '
        Me.ClmOBrnch.HeaderText = "Branch"
        Me.ClmOBrnch.Name = "ClmOBrnch"
        Me.ClmOBrnch.ReadOnly = True
        Me.ClmOBrnch.Width = 50
        '
        'ClmOdbc
        '
        Me.ClmOdbc.HeaderText = "Odbc"
        Me.ClmOdbc.Name = "ClmOdbc"
        Me.ClmOdbc.ReadOnly = True
        '
        'DgridDoc
        '
        Me.DgridDoc.AllowUserToAddRows = False
        Me.DgridDoc.AllowUserToDeleteRows = False
        Me.DgridDoc.AllowUserToResizeColumns = False
        Me.DgridDoc.AllowUserToResizeRows = False
        Me.DgridDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmNo, Me.ClmDcode, Me.ClmDname, Me.ClmDBrnch})
        Me.DgridDoc.Location = New System.Drawing.Point(400, 12)
        Me.DgridDoc.Name = "DgridDoc"
        Me.DgridDoc.ReadOnly = True
        Me.DgridDoc.RowHeadersVisible = False
        Me.DgridDoc.Size = New System.Drawing.Size(577, 476)
        Me.DgridDoc.TabIndex = 10
        '
        'ClmNo
        '
        Me.ClmNo.HeaderText = "No."
        Me.ClmNo.Name = "ClmNo"
        Me.ClmNo.ReadOnly = True
        Me.ClmNo.Width = 50
        '
        'ClmDcode
        '
        Me.ClmDcode.HeaderText = "Code"
        Me.ClmDcode.Name = "ClmDcode"
        Me.ClmDcode.ReadOnly = True
        '
        'ClmDname
        '
        Me.ClmDname.HeaderText = "Name"
        Me.ClmDname.Name = "ClmDname"
        Me.ClmDname.ReadOnly = True
        Me.ClmDname.Width = 300
        '
        'ClmDBrnch
        '
        Me.ClmDBrnch.HeaderText = "Branch"
        Me.ClmDBrnch.Name = "ClmDBrnch"
        Me.ClmDBrnch.ReadOnly = True
        Me.ClmDBrnch.Visible = False
        '
        'CmdProcess
        '
        Me.CmdProcess.Enabled = False
        Me.CmdProcess.Location = New System.Drawing.Point(400, 495)
        Me.CmdProcess.Name = "CmdProcess"
        Me.CmdProcess.Size = New System.Drawing.Size(111, 24)
        Me.CmdProcess.TabIndex = 11
        Me.CmdProcess.Text = "Process"
        Me.CmdProcess.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(910, 496)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(67, 24)
        Me.CmdClose.TabIndex = 12
        Me.CmdClose.Text = "&Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(517, 496)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(387, 23)
        Me.prbProcess.TabIndex = 13
        '
        'lblprcs
        '
        Me.lblprcs.AutoSize = True
        Me.lblprcs.BackColor = System.Drawing.SystemColors.Control
        Me.lblprcs.Location = New System.Drawing.Point(526, 500)
        Me.lblprcs.MaximumSize = New System.Drawing.Size(373, 13)
        Me.lblprcs.Name = "lblprcs"
        Me.lblprcs.Size = New System.Drawing.Size(25, 13)
        Me.lblprcs.TabIndex = 14
        Me.lblprcs.Text = "------"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(85, 495)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(306, 23)
        Me.ProgressBar1.TabIndex = 15
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.BackColor = System.Drawing.SystemColors.Control
        Me.lblLoad.Location = New System.Drawing.Point(94, 500)
        Me.lblLoad.MaximumSize = New System.Drawing.Size(292, 13)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(22, 13)
        Me.lblLoad.TabIndex = 16
        Me.lblLoad.Text = "-----"
        '
        'CboPrces
        '
        Me.CboPrces.FormattingEnabled = True
        Me.CboPrces.Items.AddRange(New Object() {"Doc", "Cust", "Items"})
        Me.CboPrces.Location = New System.Drawing.Point(12, 467)
        Me.CboPrces.Name = "CboPrces"
        Me.CboPrces.Size = New System.Drawing.Size(379, 21)
        Me.CboPrces.TabIndex = 17
        Me.CboPrces.Text = "---Select---"
        '
        'frmLoadPck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 524)
        Me.Controls.Add(Me.CboPrces)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblprcs)
        Me.Controls.Add(Me.prbProcess)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdProcess)
        Me.Controls.Add(Me.DgridDoc)
        Me.Controls.Add(Me.DgridOdbcList)
        Me.Controls.Add(Me.CmdLoad)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MinimumSize = New System.Drawing.Size(994, 558)
        Me.Name = "frmLoadPck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Package"
        CType(Me.DgridOdbcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdLoad As System.Windows.Forms.Button
    Friend WithEvents DgridOdbcList As System.Windows.Forms.DataGridView
    Friend WithEvents DgridDoc As System.Windows.Forms.DataGridView
    Friend WithEvents ClmOCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmOBrnch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmOdbc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmdProcess As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents lblprcs As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents ClmNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDBrnch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboPrces As System.Windows.Forms.ComboBox
End Class
