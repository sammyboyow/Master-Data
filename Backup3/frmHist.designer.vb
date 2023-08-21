<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHist
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dList = New System.Windows.Forms.DataGridView
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.Ln = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtUpd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Old = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cNew = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCat = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtEdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtSdate = New System.Windows.Forms.DateTimePicker
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dList
        '
        Me.dList.AllowUserToAddRows = False
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ln, Me.CardCode, Me.cName, Me.dtUpd, Me.Old, Me.cNew})
        Me.dList.Location = New System.Drawing.Point(8, 69)
        Me.dList.Name = "dList"
        Me.dList.ReadOnly = True
        Me.dList.RowHeadersVisible = False
        Me.dList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dList.Size = New System.Drawing.Size(746, 416)
        Me.dList.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(534, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(453, 419)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 24)
        Me.btnSelect.TabIndex = 54
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Card Code:"
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(80, 40)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(155, 22)
        Me.txtCod.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(239, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 14)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Name:"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(285, 40)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(270, 22)
        Me.txtname.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(577, 40)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(64, 23)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "&Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Ln
        '
        Me.Ln.HeaderText = "#"
        Me.Ln.Name = "Ln"
        Me.Ln.ReadOnly = True
        Me.Ln.Width = 30
        '
        'CardCode
        '
        Me.CardCode.HeaderText = "CardCode"
        Me.CardCode.Name = "CardCode"
        Me.CardCode.ReadOnly = True
        '
        'cName
        '
        Me.cName.HeaderText = "Name"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        Me.cName.Width = 350
        '
        'dtUpd
        '
        Me.dtUpd.HeaderText = "Date Updated"
        Me.dtUpd.Name = "dtUpd"
        Me.dtUpd.ReadOnly = True
        Me.dtUpd.Width = 120
        '
        'Old
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Old.DefaultCellStyle = DataGridViewCellStyle5
        Me.Old.HeaderText = "Old"
        Me.Old.Name = "Old"
        Me.Old.ReadOnly = True
        Me.Old.Width = 70
        '
        'cNew
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.cNew.DefaultCellStyle = DataGridViewCellStyle6
        Me.cNew.HeaderText = "New"
        Me.cNew.Name = "cNew"
        Me.cNew.ReadOnly = True
        Me.cNew.Width = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Category"
        '
        'cboCat
        '
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Items.AddRange(New Object() {"Terms", "CreditLine", "SalesPersons"})
        Me.cboCat.Location = New System.Drawing.Point(377, 12)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(140, 22)
        Me.cboCat.TabIndex = 64
        Me.cboCat.Text = "Terms"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 14)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "To:"
        '
        'dtEdate
        '
        Me.dtEdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEdate.Location = New System.Drawing.Point(206, 12)
        Me.dtEdate.Name = "dtEdate"
        Me.dtEdate.Size = New System.Drawing.Size(98, 22)
        Me.dtEdate.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Date: From"
        '
        'dtSdate
        '
        Me.dtSdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSdate.Location = New System.Drawing.Point(82, 12)
        Me.dtSdate.Name = "dtSdate"
        Me.dtSdate.Size = New System.Drawing.Size(89, 22)
        Me.dtSdate.TabIndex = 85
        '
        'frmHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(761, 488)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtEdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtSdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCat)
        Me.Controls.Add(Me.dList)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Update History"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Ln As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtUpd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Old As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNew As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtEdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtSdate As System.Windows.Forms.DateTimePicker
End Class
