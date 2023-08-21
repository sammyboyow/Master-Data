<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindSlp
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSlpCode = New System.Windows.Forms.TextBox
        Me.DgridSlp = New System.Windows.Forms.DataGridView
        Me.ClmSlpCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSlpName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSlpName = New System.Windows.Forms.TextBox
        Me.CmdClose = New System.Windows.Forms.Button
        CType(Me.DgridSlp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Slp :"
        '
        'txtSlpCode
        '
        Me.txtSlpCode.Location = New System.Drawing.Point(43, 11)
        Me.txtSlpCode.Name = "txtSlpCode"
        Me.txtSlpCode.Size = New System.Drawing.Size(52, 20)
        Me.txtSlpCode.TabIndex = 0
        '
        'DgridSlp
        '
        Me.DgridSlp.AllowUserToAddRows = False
        Me.DgridSlp.AllowUserToDeleteRows = False
        Me.DgridSlp.AllowUserToOrderColumns = True
        Me.DgridSlp.AllowUserToResizeColumns = False
        Me.DgridSlp.AllowUserToResizeRows = False
        Me.DgridSlp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgridSlp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmSlpCode, Me.ClmSlpName})
        Me.DgridSlp.Location = New System.Drawing.Point(12, 37)
        Me.DgridSlp.MultiSelect = False
        Me.DgridSlp.Name = "DgridSlp"
        Me.DgridSlp.RowHeadersVisible = False
        Me.DgridSlp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgridSlp.Size = New System.Drawing.Size(230, 397)
        Me.DgridSlp.TabIndex = 2
        '
        'ClmSlpCode
        '
        Me.ClmSlpCode.HeaderText = "Code"
        Me.ClmSlpCode.Name = "ClmSlpCode"
        Me.ClmSlpCode.ReadOnly = True
        Me.ClmSlpCode.Width = 50
        '
        'ClmSlpName
        '
        Me.ClmSlpName.HeaderText = "Name"
        Me.ClmSlpName.Name = "ClmSlpName"
        Me.ClmSlpName.ReadOnly = True
        Me.ClmSlpName.Width = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'txtSlpName
        '
        Me.txtSlpName.Location = New System.Drawing.Point(103, 11)
        Me.txtSlpName.Name = "txtSlpName"
        Me.txtSlpName.Size = New System.Drawing.Size(139, 20)
        Me.txtSlpName.TabIndex = 1
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(188, 440)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(54, 24)
        Me.CmdClose.TabIndex = 5
        Me.CmdClose.Text = "Close"
        Me.CmdClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'frmFindSlp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 469)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.txtSlpName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgridSlp)
        Me.Controls.Add(Me.txtSlpCode)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(262, 503)
        Me.Name = "frmFindSlp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Slp"
        CType(Me.DgridSlp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSlpCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSlpName As System.Windows.Forms.TextBox
    Friend WithEvents DgridSlp As System.Windows.Forms.DataGridView
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents ClmSlpCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSlpName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
