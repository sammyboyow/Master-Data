<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackage2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dList = New System.Windows.Forms.DataGridView
        Me.PCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dtl = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnImnport = New System.Windows.Forms.Button
        Me.btnLoadExcel = New System.Windows.Forms.Button
        CType(Me.dList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dList
        '
        Me.dList.AllowUserToAddRows = False
        Me.dList.AllowUserToDeleteRows = False
        Me.dList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCode, Me.PName, Me.Dtl, Me.Price, Me.PDate})
        Me.dList.Location = New System.Drawing.Point(12, 37)
        Me.dList.Name = "dList"
        Me.dList.RowHeadersVisible = False
        Me.dList.Size = New System.Drawing.Size(842, 464)
        Me.dList.TabIndex = 17
        '
        'PCode
        '
        Me.PCode.HeaderText = "PCode"
        Me.PCode.Name = "PCode"
        '
        'PName
        '
        Me.PName.HeaderText = "PName"
        Me.PName.Name = "PName"
        Me.PName.Width = 250
        '
        'Dtl
        '
        Me.Dtl.HeaderText = "PK_Dtl"
        Me.Dtl.Name = "Dtl"
        Me.Dtl.Width = 300
        '
        'Price
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Price.DefaultCellStyle = DataGridViewCellStyle1
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Width = 70
        '
        'PDate
        '
        Me.PDate.HeaderText = "PDate"
        Me.PDate.Name = "PDate"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(160, 6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(99, 24)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImnport
        '
        Me.btnImnport.Location = New System.Drawing.Point(87, 7)
        Me.btnImnport.Name = "btnImnport"
        Me.btnImnport.Size = New System.Drawing.Size(67, 24)
        Me.btnImnport.TabIndex = 36
        Me.btnImnport.Text = "Import"
        Me.btnImnport.UseVisualStyleBackColor = True
        '
        'btnLoadExcel
        '
        Me.btnLoadExcel.Location = New System.Drawing.Point(12, 7)
        Me.btnLoadExcel.Name = "btnLoadExcel"
        Me.btnLoadExcel.Size = New System.Drawing.Size(69, 23)
        Me.btnLoadExcel.TabIndex = 37
        Me.btnLoadExcel.Text = "LoadExcel"
        Me.btnLoadExcel.UseVisualStyleBackColor = True
        '
        'frmPackage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 506)
        Me.Controls.Add(Me.btnLoadExcel)
        Me.Controls.Add(Me.btnImnport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dList)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPackage2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pakcage List"
        CType(Me.dList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dList As System.Windows.Forms.DataGridView
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnImnport As System.Windows.Forms.Button
    Friend WithEvents btnLoadExcel As System.Windows.Forms.Button
    Friend WithEvents PCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dtl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
