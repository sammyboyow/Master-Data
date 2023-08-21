<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpTran
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
        Me.dtSdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtEdate = New System.Windows.Forms.DateTimePicker
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtSdate
        '
        Me.dtSdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSdate.Location = New System.Drawing.Point(86, 34)
        Me.dtSdate.Name = "dtSdate"
        Me.dtSdate.Size = New System.Drawing.Size(94, 22)
        Me.dtSdate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'dtEdate
        '
        Me.dtEdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEdate.Location = New System.Drawing.Point(86, 62)
        Me.dtEdate.Name = "dtEdate"
        Me.dtEdate.Size = New System.Drawing.Size(94, 22)
        Me.dtEdate.TabIndex = 2
        '
        'txtDocCode
        '
        Me.txtDocCode.Location = New System.Drawing.Point(86, 6)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(94, 22)
        Me.txtDocCode.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DoctorCode:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(59, 103)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(62, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(127, 103)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmUpTran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(206, 138)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDocCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtEdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtSdate)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpTran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtSdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtEdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
