<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.btnSelect = New System.Windows.Forms.Button
        Me.dList = New System.Windows.Forms.DataGridView
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtPO = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboList = New System.Windows.Forms.ComboBox
        Me.Ln = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HOSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Loc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ADD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(463, 436)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 24)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'dList
        '
        Me.dList.AllowUserToAddRows = False
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ln, Me.HOSP, Me.Loc, Me.ADD1})
        Me.dList.Location = New System.Drawing.Point(6, 38)
        Me.dList.Name = "dList"
        Me.dList.ReadOnly = True
        Me.dList.RowHeadersVisible = False
        Me.dList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dList.Size = New System.Drawing.Size(597, 396)
        Me.dList.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(534, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(64, 23)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtPO
        '
        Me.txtPO.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(268, 10)
        Me.txtPO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(261, 22)
        Me.txtPO.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Find:"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(543, 437)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Select List"
        '
        'cboList
        '
        Me.cboList.FormattingEnabled = True
        Me.cboList.Items.AddRange(New Object() {"Salesperson", "Hospital"})
        Me.cboList.Location = New System.Drawing.Point(80, 12)
        Me.cboList.Name = "cboList"
        Me.cboList.Size = New System.Drawing.Size(145, 22)
        Me.cboList.TabIndex = 99
        Me.cboList.Text = "Hospital"
        '
        'Ln
        '
        Me.Ln.HeaderText = "#"
        Me.Ln.Name = "Ln"
        Me.Ln.ReadOnly = True
        Me.Ln.Width = 40
        '
        'HOSP
        '
        Me.HOSP.HeaderText = "HOSP"
        Me.HOSP.Name = "HOSP"
        Me.HOSP.ReadOnly = True
        '
        'Loc
        '
        Me.Loc.HeaderText = "LOCATION"
        Me.Loc.Name = "Loc"
        Me.Loc.ReadOnly = True
        Me.Loc.Width = 150
        '
        'ADD1
        '
        Me.ADD1.HeaderText = "ADDRESS"
        Me.ADD1.Name = "ADD1"
        Me.ADD1.ReadOnly = True
        Me.ADD1.Width = 300
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(610, 462)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboList)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtPO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dList)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Hospital"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboList As System.Windows.Forms.ComboBox
    Friend WithEvents Ln As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADD1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
