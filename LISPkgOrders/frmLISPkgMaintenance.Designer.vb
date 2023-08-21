<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLISPkgMaintenance
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtPkgCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPkgDesc = New System.Windows.Forms.TextBox()
        Me.rbtAY = New System.Windows.Forms.RadioButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbtAN = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtBcode = New System.Windows.Forms.TextBox()
        Me.txtstdc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtListP = New System.Windows.Forms.TextBox()
        Me.txtPrev3 = New System.Windows.Forms.TextBox()
        Me.txtPrev1 = New System.Windows.Forms.TextBox()
        Me.txtPrev2 = New System.Windows.Forms.TextBox()
        Me.txtEfd3 = New System.Windows.Forms.TextBox()
        Me.txtEfd1 = New System.Windows.Forms.TextBox()
        Me.txtEfd2 = New System.Windows.Forms.TextBox()
        Me.txtCurrp3 = New System.Windows.Forms.TextBox()
        Me.txtCurrp1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCurrp2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.D = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplaySeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rev = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboBlk = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblWhsCode = New System.Windows.Forms.Label()
        Me.btnAddLine = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblBillDesc = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPkgCode
        '
        Me.txtPkgCode.Location = New System.Drawing.Point(102, 50)
        Me.txtPkgCode.MaxLength = 6
        Me.txtPkgCode.Name = "txtPkgCode"
        Me.txtPkgCode.Size = New System.Drawing.Size(134, 22)
        Me.txtPkgCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Package Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description :"
        '
        'txtPkgDesc
        '
        Me.txtPkgDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPkgDesc.Location = New System.Drawing.Point(102, 78)
        Me.txtPkgDesc.MaxLength = 50
        Me.txtPkgDesc.Name = "txtPkgDesc"
        Me.txtPkgDesc.Size = New System.Drawing.Size(345, 22)
        Me.txtPkgDesc.TabIndex = 2
        '
        'rbtAY
        '
        Me.rbtAY.AutoSize = True
        Me.rbtAY.Location = New System.Drawing.Point(3, 3)
        Me.rbtAY.Name = "rbtAY"
        Me.rbtAY.Size = New System.Drawing.Size(40, 17)
        Me.rbtAY.TabIndex = 4
        Me.rbtAY.TabStop = True
        Me.rbtAY.Text = "Yes"
        Me.rbtAY.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rbtAN)
        Me.GroupPanel1.Controls.Add(Me.rbtAY)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(524, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(100, 50)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 5
        Me.GroupPanel1.Text = "Active Package"
        '
        'rbtAN
        '
        Me.rbtAN.AutoSize = True
        Me.rbtAN.Location = New System.Drawing.Point(49, 3)
        Me.rbtAN.Name = "rbtAN"
        Me.rbtAN.Size = New System.Drawing.Size(40, 17)
        Me.rbtAN.TabIndex = 5
        Me.rbtAN.TabStop = True
        Me.rbtAN.Text = "No"
        Me.rbtAN.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 387)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblBillDesc)
        Me.TabPage1.Controls.Add(Me.txtBcode)
        Me.TabPage1.Controls.Add(Me.txtstdc)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtListP)
        Me.TabPage1.Controls.Add(Me.txtPrev3)
        Me.TabPage1.Controls.Add(Me.txtPrev1)
        Me.TabPage1.Controls.Add(Me.txtPrev2)
        Me.TabPage1.Controls.Add(Me.txtEfd3)
        Me.TabPage1.Controls.Add(Me.txtEfd1)
        Me.TabPage1.Controls.Add(Me.txtEfd2)
        Me.TabPage1.Controls.Add(Me.txtCurrp3)
        Me.TabPage1.Controls.Add(Me.txtCurrp1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtCurrp2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(604, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Package Price"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtBcode
        '
        Me.txtBcode.Location = New System.Drawing.Point(112, 206)
        Me.txtBcode.Name = "txtBcode"
        Me.txtBcode.Size = New System.Drawing.Size(100, 22)
        Me.txtBcode.TabIndex = 22
        '
        'txtstdc
        '
        Me.txtstdc.Enabled = False
        Me.txtstdc.Location = New System.Drawing.Point(112, 178)
        Me.txtstdc.Name = "txtstdc"
        Me.txtstdc.Size = New System.Drawing.Size(100, 22)
        Me.txtstdc.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Billing Group :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Standard Cost :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "List Price :"
        '
        'txtListP
        '
        Me.txtListP.Location = New System.Drawing.Point(112, 150)
        Me.txtListP.Name = "txtListP"
        Me.txtListP.Size = New System.Drawing.Size(100, 22)
        Me.txtListP.TabIndex = 8
        '
        'txtPrev3
        '
        Me.txtPrev3.Location = New System.Drawing.Point(436, 97)
        Me.txtPrev3.Name = "txtPrev3"
        Me.txtPrev3.Size = New System.Drawing.Size(124, 22)
        Me.txtPrev3.TabIndex = 18
        '
        'txtPrev1
        '
        Me.txtPrev1.Location = New System.Drawing.Point(176, 97)
        Me.txtPrev1.Name = "txtPrev1"
        Me.txtPrev1.Size = New System.Drawing.Size(124, 22)
        Me.txtPrev1.TabIndex = 17
        '
        'txtPrev2
        '
        Me.txtPrev2.Location = New System.Drawing.Point(306, 97)
        Me.txtPrev2.Name = "txtPrev2"
        Me.txtPrev2.Size = New System.Drawing.Size(124, 22)
        Me.txtPrev2.TabIndex = 16
        '
        'txtEfd3
        '
        Me.txtEfd3.Location = New System.Drawing.Point(436, 69)
        Me.txtEfd3.Name = "txtEfd3"
        Me.txtEfd3.Size = New System.Drawing.Size(124, 22)
        Me.txtEfd3.TabIndex = 15
        '
        'txtEfd1
        '
        Me.txtEfd1.Location = New System.Drawing.Point(176, 69)
        Me.txtEfd1.Name = "txtEfd1"
        Me.txtEfd1.Size = New System.Drawing.Size(124, 22)
        Me.txtEfd1.TabIndex = 14
        '
        'txtEfd2
        '
        Me.txtEfd2.Location = New System.Drawing.Point(306, 69)
        Me.txtEfd2.Name = "txtEfd2"
        Me.txtEfd2.Size = New System.Drawing.Size(124, 22)
        Me.txtEfd2.TabIndex = 13
        '
        'txtCurrp3
        '
        Me.txtCurrp3.Location = New System.Drawing.Point(436, 41)
        Me.txtCurrp3.Name = "txtCurrp3"
        Me.txtCurrp3.Size = New System.Drawing.Size(124, 22)
        Me.txtCurrp3.TabIndex = 12
        '
        'txtCurrp1
        '
        Me.txtCurrp1.Location = New System.Drawing.Point(176, 41)
        Me.txtCurrp1.Name = "txtCurrp1"
        Me.txtCurrp1.Size = New System.Drawing.Size(124, 22)
        Me.txtCurrp1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Group III"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(342, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Group II"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Group I"
        '
        'txtCurrp2
        '
        Me.txtCurrp2.Location = New System.Drawing.Point(306, 41)
        Me.txtCurrp2.Name = "txtCurrp2"
        Me.txtCurrp2.Size = New System.Drawing.Size(124, 22)
        Me.txtCurrp2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Effective Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Previous Price :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Price :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.D)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Package Items"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.AllowUserToAddRows = False
        Me.D.AllowUserToDeleteRows = False
        Me.D.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.TestName, Me.Price, Me.DisplaySeq, Me.Rev})
        Me.D.Location = New System.Drawing.Point(6, 6)
        Me.D.Name = "D"
        Me.D.RowHeadersVisible = False
        Me.D.Size = New System.Drawing.Size(590, 349)
        Me.D.TabIndex = 0
        '
        'Code
        '
        Me.Code.HeaderText = "CODE"
        Me.Code.Name = "Code"
        Me.Code.Width = 80
        '
        'TestName
        '
        Me.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TestName.HeaderText = "TESTNAME"
        Me.TestName.Name = "TestName"
        Me.TestName.ReadOnly = True
        '
        'Price
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.Price.HeaderText = "PRICE"
        Me.Price.Name = "Price"
        '
        'DisplaySeq
        '
        Me.DisplaySeq.HeaderText = "DISPLAYSEQ"
        Me.DisplaySeq.Name = "DisplaySeq"
        '
        'Rev
        '
        Me.Rev.HeaderText = "X"
        Me.Rev.Name = "Rev"
        Me.Rev.ReadOnly = True
        Me.Rev.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Rev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Rev.Text = "X"
        Me.Rev.Width = 30
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(12, 499)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(549, 499)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboBlk
        '
        Me.cboBlk.FormattingEnabled = True
        Me.cboBlk.Location = New System.Drawing.Point(102, 12)
        Me.cboBlk.Name = "cboBlk"
        Me.cboBlk.Size = New System.Drawing.Size(134, 21)
        Me.cboBlk.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Branch :"
        '
        'lblWhsCode
        '
        Me.lblWhsCode.AutoSize = True
        Me.lblWhsCode.Location = New System.Drawing.Point(242, 15)
        Me.lblWhsCode.Name = "lblWhsCode"
        Me.lblWhsCode.Size = New System.Drawing.Size(19, 13)
        Me.lblWhsCode.TabIndex = 10
        Me.lblWhsCode.Text = "---"
        '
        'btnAddLine
        '
        Me.btnAddLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLine.Location = New System.Drawing.Point(468, 499)
        Me.btnAddLine.Name = "btnAddLine"
        Me.btnAddLine.Size = New System.Drawing.Size(75, 23)
        Me.btnAddLine.TabIndex = 11
        Me.btnAddLine.Text = "Add Line"
        Me.btnAddLine.UseVisualStyleBackColor = True
        Me.btnAddLine.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(93, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(388, 501)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(19, 21)
        Me.lbltotal.TabIndex = 13
        Me.lbltotal.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(326, 501)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 21)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total :"
        '
        'lblBillDesc
        '
        Me.lblBillDesc.AutoSize = True
        Me.lblBillDesc.Location = New System.Drawing.Point(218, 209)
        Me.lblBillDesc.Name = "lblBillDesc"
        Me.lblBillDesc.Size = New System.Drawing.Size(23, 13)
        Me.lblBillDesc.TabIndex = 23
        Me.lblBillDesc.Text = "----"
        '
        'frmLISPkgMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 534)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddLine)
        Me.Controls.Add(Me.lblWhsCode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboBlk)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPkgDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPkgCode)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLISPkgMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package Order"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPkgCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPkgDesc As System.Windows.Forms.TextBox
    Friend WithEvents rbtAY As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtAN As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtPrev3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrev1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrev2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEfd3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEfd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEfd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCurrp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtBcode As System.Windows.Forms.TextBox
    Friend WithEvents txtstdc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtListP As System.Windows.Forms.TextBox
    Friend WithEvents D As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboBlk As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblWhsCode As System.Windows.Forms.Label
    Friend WithEvents btnAddLine As System.Windows.Forms.Button
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisplaySeq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rev As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBillDesc As System.Windows.Forms.Label
End Class
