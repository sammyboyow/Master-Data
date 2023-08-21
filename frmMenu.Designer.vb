<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnPack = New System.Windows.Forms.Button
        Me.btnDoct = New System.Windows.Forms.Button
        Me.btnUpTran = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(13, 13)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(188, 34)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update Customer"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnPack
        '
        Me.btnPack.Location = New System.Drawing.Point(13, 55)
        Me.btnPack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPack.Name = "btnPack"
        Me.btnPack.Size = New System.Drawing.Size(188, 34)
        Me.btnPack.TabIndex = 1
        Me.btnPack.Text = "Branch Package"
        Me.btnPack.UseVisualStyleBackColor = True
        '
        'btnDoct
        '
        Me.btnDoct.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDoct.Location = New System.Drawing.Point(13, 139)
        Me.btnDoct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoct.Name = "btnDoct"
        Me.btnDoct.Size = New System.Drawing.Size(188, 34)
        Me.btnDoct.TabIndex = 2
        Me.btnDoct.Text = "Doctor"
        Me.btnDoct.UseVisualStyleBackColor = True
        '
        'btnUpTran
        '
        Me.btnUpTran.Location = New System.Drawing.Point(13, 97)
        Me.btnUpTran.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpTran.Name = "btnUpTran"
        Me.btnUpTran.Size = New System.Drawing.Size(188, 34)
        Me.btnUpTran.TabIndex = 3
        Me.btnUpTran.Text = "&Update Transaction"
        Me.btnUpTran.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDoct
        Me.ClientSize = New System.Drawing.Size(207, 181)
        Me.Controls.Add(Me.btnUpTran)
        Me.Controls.Add(Me.btnDoct)
        Me.Controls.Add(Me.btnPack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER DATA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnPack As System.Windows.Forms.Button
    Friend WithEvents btnDoct As System.Windows.Forms.Button
    Friend WithEvents btnUpTran As System.Windows.Forms.Button
End Class
