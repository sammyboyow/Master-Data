<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstrCust
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
        Me.txtSlpCode = New System.Windows.Forms.TextBox
        Me.D = New System.Windows.Forms.DataGridView
        Me.CardCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CardName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlpCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlpName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Addr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phoneno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCardName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCardCode = New System.Windows.Forms.TextBox
        Me.P = New System.Windows.Forms.Panel
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdExportExcel = New System.Windows.Forms.Button
        Me.lblPrces = New System.Windows.Forms.Label
        Me.prbProcess = New System.Windows.Forms.ProgressBar
        CType(Me.D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSlpCode
        '
        Me.txtSlpCode.Location = New System.Drawing.Point(312, 8)
        Me.txtSlpCode.Name = "txtSlpCode"
        Me.txtSlpCode.Size = New System.Drawing.Size(68, 20)
        Me.txtSlpCode.TabIndex = 55
        '
        'D
        '
        Me.D.AllowUserToAddRows = False
        Me.D.AllowUserToDeleteRows = False
        Me.D.AllowUserToResizeColumns = False
        Me.D.AllowUserToResizeRows = False
        Me.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardCode, Me.CardName, Me.SlpCode, Me.SlpName, Me.Addr, Me.Phoneno, Me.Email})
        Me.D.Location = New System.Drawing.Point(12, 34)
        Me.D.MultiSelect = False
        Me.D.Name = "D"
        Me.D.RowHeadersVisible = False
        Me.D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.D.Size = New System.Drawing.Size(1053, 322)
        Me.D.TabIndex = 53
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
        Me.CardName.Width = 150
        '
        'SlpCode
        '
        Me.SlpCode.HeaderText = "SlpCode"
        Me.SlpCode.Name = "SlpCode"
        Me.SlpCode.ReadOnly = True
        Me.SlpCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'SlpName
        '
        Me.SlpName.HeaderText = "SlpName"
        Me.SlpName.Name = "SlpName"
        Me.SlpName.ReadOnly = True
        Me.SlpName.Width = 150
        '
        'Addr
        '
        Me.Addr.HeaderText = "Address"
        Me.Addr.Name = "Addr"
        Me.Addr.ReadOnly = True
        Me.Addr.Width = 200
        '
        'Phoneno
        '
        Me.Phoneno.HeaderText = "Phone no"
        Me.Phoneno.Name = "Phoneno"
        Me.Phoneno.ReadOnly = True
        Me.Phoneno.Width = 90
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 90
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(140, 8)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(166, 20)
        Me.txtCardName.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Customer"
        '
        'txtCardCode
        '
        Me.txtCardCode.Location = New System.Drawing.Point(66, 8)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.Size = New System.Drawing.Size(68, 20)
        Me.txtCardCode.TabIndex = 50
        '
        'P
        '
        Me.P.Controls.Add(Me.CmdClose)
        Me.P.Controls.Add(Me.CmdExportExcel)
        Me.P.Controls.Add(Me.lblPrces)
        Me.P.Controls.Add(Me.prbProcess)
        Me.P.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P.Location = New System.Drawing.Point(0, 485)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(1077, 39)
        Me.P.TabIndex = 63
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(996, 3)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(69, 24)
        Me.CmdClose.TabIndex = 66
        Me.CmdClose.Text = "Close"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'CmdExportExcel
        '
        Me.CmdExportExcel.Location = New System.Drawing.Point(12, 3)
        Me.CmdExportExcel.Name = "CmdExportExcel"
        Me.CmdExportExcel.Size = New System.Drawing.Size(82, 24)
        Me.CmdExportExcel.TabIndex = 65
        Me.CmdExportExcel.Text = "ExportExcel"
        Me.CmdExportExcel.UseVisualStyleBackColor = True
        '
        'lblPrces
        '
        Me.lblPrces.AutoSize = True
        Me.lblPrces.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrces.Location = New System.Drawing.Point(109, 9)
        Me.lblPrces.MaximumSize = New System.Drawing.Size(721, 13)
        Me.lblPrces.Name = "lblPrces"
        Me.lblPrces.Size = New System.Drawing.Size(25, 13)
        Me.lblPrces.TabIndex = 64
        Me.lblPrces.Text = "------"
        '
        'prbProcess
        '
        Me.prbProcess.Location = New System.Drawing.Point(100, 3)
        Me.prbProcess.Name = "prbProcess"
        Me.prbProcess.Size = New System.Drawing.Size(890, 24)
        Me.prbProcess.TabIndex = 63
        '
        'frmMstrCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 524)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.txtSlpCode)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCardCode)
        Me.MinimumSize = New System.Drawing.Size(1085, 558)
        Me.Name = "frmMstrCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMstrCust"
        CType(Me.D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P.ResumeLayout(False)
        Me.P.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSlpCode As System.Windows.Forms.TextBox
    Friend WithEvents D As System.Windows.Forms.DataGridView
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents CardCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlpCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Addr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phoneno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents P As System.Windows.Forms.Panel
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdExportExcel As System.Windows.Forms.Button
    Friend WithEvents lblPrces As System.Windows.Forms.Label
    Friend WithEvents prbProcess As System.Windows.Forms.ProgressBar
End Class
