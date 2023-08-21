Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess
Imports System.Data.Odbc
Imports System.Reflection

Public Class frmLISPkgMaintenance

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If D.Rows.Count = 0 Then MsgBox("No Package Break Down!") : Exit Sub
        If Val(lbltotal.Text) <> Val(txtCurrp1.Text) Then
            MsgBox("Total amount is not equal in Current Price 1!") : Exit Sub
        ElseIf Val(lbltotal.Text) <> Val(txtCurrp2.Text) Then
            MsgBox("Total amount is not equal in Current Price 2!") : Exit Sub
        ElseIf Val(lbltotal.Text) <> Val(txtCurrp3.Text) Then
            MsgBox("Total amount is not equal in Current Price 3!") : Exit Sub
        End If
        Dim ErrCurrP As String = ""
        If Val(txtListP.Text) <> Val(txtCurrp1.Text) Then
            ErrCurrP = "1"
        ElseIf Val(txtListP.Text) <> Val(txtCurrp2.Text) Then
            ErrCurrP = "2"
        ElseIf Val(txtListP.Text) <> Val(txtCurrp3.Text) Then
            ErrCurrP = "3"
        End If
        If ErrCurrP <> "" Then
            If MsgBox("List Price is not equal in Current Price " & ErrCurrP & "!", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If
        If MsgBox("Do you want to save package details?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim IMH_TABLE As String = ""

        Dim cnstr As String =
            "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(lblWhsCode.Text) & ")(PORT = 1521)) " & _
            "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        Dim Tran As OdbcTransaction
        str =
            "SELECT 1 FROM ITEM_MASTERH WHERE ROWNUM = 1 AND IMH_CODE =  '" & txtPkgCode.Text & "' "
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        str = cmd.ExecuteScalar
        Tran = cn.BeginTransaction()
        If lblWhsCode.Text = "011" Then
            IMH_TABLE = "ITEM_MASTERH"
        Else
            IMH_TABLE = "ITEM_MASTERH_A"
        End If
        If str = 1 Then
            Try
                str =
                    "UPDATE " & IMH_TABLE & " SET IMH_DESC = '" & txtPkgDesc.Text.Replace("'", "''") & "', IMH_REC_FLAG = '" & IIf(rbtAY.Checked = True, "N", "X") & "', " & _
                    "IMH_CURR_P1 = '" & txtCurrp1.Text & "', IMH_EFD_P1 = to_date ('" & txtEfd1.Text & "','MM-DD-YYYY') , IMH_PREV_P1 = '" & txtPrev1.Text & "', " & _
                    "IMH_CURR_P2 = '" & txtCurrp2.Text & "', IMH_EFD_P2 = to_date ('" & txtEfd2.Text & "','MM-DD-YYYY'), IMH_PREV_P2 = '" & txtPrev2.Text & "', " & _
                    "IMH_CURR_P3 = '" & txtCurrp3.Text & "', IMH_EFD_P3 = to_date ('" & txtEfd3.Text & "','MM-DD-YYYY'), IMH_PREV_P3 = '" & txtPrev3.Text & "', " & _
                    "IMH_BILLCODE = '" & txtBcode.Text & "' " & _
                    "WHERE IMH_CODE = '" & txtPkgCode.Text & "' "
                cmd = New OdbcCommand(str, cn, Tran)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
                str =
                    "DELETE ITEM_MASTERD_A WHERE IMD_PKG_CODE = '" & txtPkgCode.Text & "' "
                cmd = New OdbcCommand(str, cn, Tran)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
                For i As Integer = 0 To D.Rows.Count - 1
                    str =
                    "INSERT INTO ITEM_MASTERD_A (IMD_PKG_CODE, IMD_PKG_ITEM, IMD_DISP_SEQ, IMD_PKG_PRICE, MODIFIED_ON ) " & _
                    "VALUES('" & txtPkgCode.Text & "','" & D("CODE", i).Value & "','" & D("DISPLAYSEQ", i).Value & "','" & D("PRICE", i).Value & "',SYSDATE) "
                    cmd = New OdbcCommand(str, cn, Tran)
                    cmd.CommandTimeout = 0
                    cmd.ExecuteNonQuery()
                Next
                If InsertPkgLogs() = False Then
                    Tran.Commit()
                Else
                    Tran.Rollback()
                End If
            Catch ex As Exception
                Tran.Rollback()
                MsgBox("Opps error encountered! " + ex.Message)

            End Try
        Else
            Try
                str =
                    "INSERT INTO " & IMH_TABLE & " (IMH_CODE,IMH_DESC,IMH_TYPE,IMH_PDGROUP,IMH_BILLCODE,IMH_STKITEM_FLAG,IMH_TAXABLE,IMH_YTD_SAMT, " & _
                    "IMH_STD_COST,IMH_CURR_P1,IMH_EFD_P1,IMH_PREV_P1,IMH_CURR_P2,IMH_EFD_P2,IMH_PREV_P2,IMH_CURR_P3,IMH_EFD_P3,IMH_PREV_P3, " & _
                    "IMH_FIXED_PRICE,IMH_REC_FLAG,IMH_UPDATE_BY,IMH_UPDATE_ON, MODIFIED_ON) " & _
                    "VALUES('" & txtPkgCode.Text & "','" & txtPkgDesc.Text.Replace("'", "''") & "','P','90','" & txtBcode.Text & "','N','N','" & txtListP.Text & "','0', " & _
                    "'" & txtCurrp1.Text & "',to_date ('" & txtEfd1.Text & "','MM-DD-YYYY'),'" & txtPrev1.Text & "', " & _
                    "'" & txtCurrp2.Text & "',to_date ('" & txtEfd2.Text & "','MM-DD-YYYY'),'" & txtPrev2.Text & "', " & _
                    "'" & txtCurrp3.Text & "',to_date ('" & txtEfd3.Text & "','MM-DD-YYYY'),'" & txtPrev3.Text & "', " & _
                    "'N','" & IIf(rbtAY.Checked = True, "N", "X") & "', '" & Mnu.LIS_UNAME & "',SYSDATE,SYSDATE) "
                cmd = New OdbcCommand(str, cn, Tran)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
                str =
                    "DELETE ITEM_MASTERD_A WHERE IMD_PKG_CODE = '" & txtPkgCode.Text & "' "
                cmd = New OdbcCommand(str, cn, Tran)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
                For i As Integer = 0 To D.Rows.Count - 1
                    str =
                    "INSERT INTO ITEM_MASTERD_A (IMD_PKG_CODE, IMD_PKG_ITEM, IMD_DISP_SEQ, IMD_PKG_PRICE, MODIFIED_ON ) " & _
                    "VALUES('" & txtPkgCode.Text & "','" & D("CODE", i).Value & "','" & D("DISPLAYSEQ", i).Value & "','" & D("PRICE", i).Value & "',SYSDATE) "
                    cmd = New OdbcCommand(str, cn, Tran)
                    cmd.CommandTimeout = 0
                    cmd.ExecuteNonQuery()
                Next
                If InsertPkgLogs() = False Then
                    Tran.Commit()
                Else
                    Tran.Rollback()
                End If

            Catch ex As Exception
                Tran.Rollback()
            End Try
        End If

        cmd.Dispose()
        cn.Dispose()
    End Sub

    Private Sub frmLISPkgMaintenance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmLISPkgMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWhsList()
    End Sub

    Public Sub LoadWhsList()
        Dim dtBlk As DataTable = Nothing

        Dim cn As New SqlConnection(cnCommon)
        If cn.State = ConnectionState.Closed Then cn.Open()
        If dtBlk Is Nothing Then
            dtBlk = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = ""
            str =
                "SELECT CODE, BLK FROM SAPSET WHERE STAT = 'O' AND SLSSTAT= 'O' ORDER BY 2"
            Dim cmd As New SqlCommand(str, cn)
            cmd.CommandTimeout = 0
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dtBlk.Load(dr)
            dr.Close()
            cmd.Dispose()
            cn.Dispose()
        End If

        cboBlk.Items.Add("")
        cboBlk.DataSource = dtBlk
        cboBlk.DisplayMember = "BLK"
        cboBlk.ValueMember = "CODE"
        cboBlk.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboBlk.AutoCompleteSource = AutoCompleteSource.ListItems



    End Sub

    Private Sub cboBlk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBlk.SelectedIndexChanged
        If txtPkgCode.Text <> "" Then
            If MsgBox("Changing Branch will clear all fields, do you still want to proceed?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ClearAll()
            End If
        End If

    End Sub

    Private Sub cboBlk_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboBlk.SelectedValueChanged
        If cboBlk.SelectedIndex <> -1 Then
            lblWhsCode.Text = cboBlk.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtPkgCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPkgCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            load_packageHDR()
        ElseIf e.KeyCode = Keys.F9 Then
            frmSearchPkg.PkgSearch = "PACKAGE"
            frmSearchPkg.ShowDialog()
        End If
    End Sub

    Sub load_packageHDR()

        Dim cnstr As String =
            "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(lblWhsCode.Text) & ")(PORT = 1521)) " & _
            "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        Dim dr As OdbcDataReader
        Dim i As Integer = 0
        str =
            "select IMH_CODE, IMH_DESC,'P'IMH_TYPE, '90'IMH_PDGROUP,'6500' IMH_BILLCODE,  'N' IMH_STKITEM_FLAG, 'N'IMH_TAXABLE, " & _
            "IMH_YTD_SAMT,'0' IMH_STD_COST, IMH_CURR_P1, IMH_EFD_P1, IMH_PREV_P1, IMH_CURR_P2, IMH_EFD_P2, IMH_PREV_P2, IMH_CURR_P3, IMH_EFD_P3, IMH_PREV_P3, " & _
            "'N' IMH_FIXED_PRICE, NVL(IMH_REC_FLAG, 'N') IMH_REC_FLAG, 'EMPID'IMH_UPDATE_BY " & _
            "from ITEM_MASTERH WHERE IMH_TYPE = 'P' AND IMH_CODE = '" & txtPkgCode.Text & "'"
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        dr = cmd.ExecuteReader
        txtPkgCode.Clear()
        txtPkgDesc.Clear()
        rbtAN.Checked = True
        rbtAY.Checked = False
        txtCurrp1.Clear()
        txtCurrp2.Clear()
        txtCurrp3.Clear()
        txtEfd1.Clear()
        txtEfd2.Clear()
        txtEfd3.Clear()
        txtPrev1.Clear()
        txtPrev2.Clear()
        txtPrev3.Clear()
        txtListP.Clear()
        txtBcode.Clear()
        lblBillDesc.Text = "----"
        If dr.HasRows Then
            While dr.Read
                txtPkgCode.Text = dr("IMH_CODE")
                txtPkgDesc.Text = dr("IMH_DESC")
                txtCurrp1.Text = dr("IMH_CURR_P1")
                txtCurrp2.Text = dr("IMH_CURR_P2")
                txtCurrp3.Text = dr("IMH_CURR_P3")
                txtEfd1.Text = dr("IMH_EFD_P1")
                txtEfd2.Text = dr("IMH_EFD_P2")
                txtEfd3.Text = dr("IMH_EFD_P3")
                txtPrev1.Text = dr("IMH_PREV_P1")
                txtPrev2.Text = dr("IMH_PREV_P2")
                txtPrev3.Text = dr("IMH_PREV_P3")
                txtListP.Text = dr("IMH_YTD_SAMT")
                txtBcode.Text = dr("IMH_BILLCODE")
                lblBillDesc.Text = loadbcode(dr("IMH_BILLCODE"))
                If dr("IMH_REC_FLAG") = "X" Then
                    rbtAN.Checked = True
                    rbtAY.Checked = False
                ElseIf dr("IMH_REC_FLAG") = "N" Then
                    rbtAN.Checked = False
                    rbtAY.Checked = True
                End If
            End While
            load_packageDTL()
        Else
            MsgBox("Package does not exists.")
        End If

        dr.Close()
        cmd.Dispose()
        cn.Dispose()

    End Sub
    Sub load_packageDTL()
        Dim cnstr As String =
           "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(lblWhsCode.Text) & ")(PORT = 1521)) " & _
           "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        Dim dr As OdbcDataReader
        Dim i As Integer = 0
        Dim total As String = 0
        str =
            "SELECT D.IMD_PKG_CODE, D.IMD_PKG_ITEM,H.IMH_DESC, D.IMD_DISP_SEQ, D.IMD_PKG_PRICE, D.MODIFIED_ON " & _
            "FROM ITEM_MASTERD D " & _
            "LEFT JOIN ITEM_MASTERH H ON H.IMH_CODE = D.IMD_PKG_ITEM " & _
            "WHERE D.IMD_PKG_CODE = '" & txtPkgCode.Text & "'  ORDER BY D.IMD_DISP_SEQ  "
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        dr = cmd.ExecuteReader
        D.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                D.Rows.Add()
                D("CODE", i).Value = dr("IMD_PKG_ITEM")
                D("TESTNAME", i).Value = dr("IMH_DESC")
                D("DISPLAYSEQ", i).Value = dr("IMD_DISP_SEQ")
                D("PRICE", i).Value = dr("IMD_PKG_PRICE")
                D("REV", i).Value = "X"
                total = total + Val(D("PRICE", i).Value)
                i += 1

            End While
        End If
        lbltotal.Text = total
        Totalall()
        dr.Close()
        cmd.Dispose()
        cn.Dispose()
    End Sub
    Sub Totalall()
        Dim total As String = 0
        For i As Integer = 0 To D.Rows.Count - 1
            total = total + Val(D("PRICE", i).Value)
        Next

        lbltotal.Text = total
    End Sub
    Private Sub txtPkgCode_TextChanged(sender As Object, e As EventArgs) Handles txtPkgCode.TextChanged

    End Sub

    Private Sub D_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles D.CellContentClick
        If D.Rows.Count < 1 Then Exit Sub
        If D.CurrentRow.Index < 0 Then Exit Sub
        Dim x As Integer = D.CurrentRow.Index
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex = x Then
            D.Rows.Remove(D.Rows(x))
        End If
    End Sub

    Private Sub D_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles D.CellEndEdit
        If D.CurrentCell.ColumnIndex = D.Columns("CODE").Index Then
            Dim i As Integer = D.CurrentRow.Index
            load_packageBRDown(D("CODE", i).Value)
        End If
        Totalall()
    End Sub
    Sub load_packageBRDown(ByVal Stest As String)
        Dim cnstr As String =
           "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(lblWhsCode.Text) & ")(PORT = 1521)) " & _
           "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        Dim dr As OdbcDataReader
        Dim i As Integer = D.CurrentRow.Index
        str =
            "SELECT IMH_CODE,IMH_DESC FROM ITEM_MASTERH WHERE IMH_CODE = '" & Stest & "' AND IMH_REC_FLAG = 'N'"
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                D("CODE", i).Value = dr("IMH_CODE")
                D("TESTNAME", i).Value = dr("IMH_DESC")
            End While
        Else
            MsgBox("Invalid Code")
            D("CODE", i).Value = ""
            D("TESTNAME", i).Value = ""
        End If

        dr.Close()
        cmd.Dispose()
        cn.Dispose()
    End Sub

    Private Sub btnAddLine_Click(sender As Object, e As EventArgs) Handles btnAddLine.Click
        Dim i As Integer = D.Rows.Count
        D.Rows.Add()
        D("PRICE", i).Value = "0"
        D("REV", i).Value = "X"
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            btnAddLine.Show()
        Else
            btnAddLine.Hide()
        End If
    End Sub
    Function InsertPkgLogs()
        Dim cn As New SqlConnection(cnCommon)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New SqlCommand
        Dim docentry As String = ""
        Dim ERR As Boolean = False
        Try
            str = "BEGIN TRAN"
            cmd = New SqlCommand(str, cn)
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()

            str =
                    "INSERT INTO ITEM_MASTERH_LIS_LOG (WHSCODE,IMH_CODE,IMH_DESC,IMH_TYPE,IMH_PDGROUP,IMH_BILLCODE,IMH_STKITEM_FLAG,IMH_TAXABLE,IMH_YTD_SAMT, " & _
                    "IMH_STD_COST,IMH_CURR_P1,IMH_EFD_P1,IMH_PREV_P1,IMH_CURR_P2,IMH_EFD_P2,IMH_PREV_P2,IMH_CURR_P3,IMH_EFD_P3,IMH_PREV_P3, " & _
                    "IMH_FIXED_PRICE,IMH_REC_FLAG,IMH_UPDATE_BY,IMH_UPDATE_ON, MODIFIED_ON) " & _
                    "VALUES('" & lblWhsCode.Text & "','" & txtPkgCode.Text & "','" & txtPkgDesc.Text.Replace("'", "''") & "','P','90','" & txtBcode.Text & "','N','N','" & txtListP.Text & "','0', " & _
                    "'" & txtCurrp1.Text & "','" & txtEfd1.Text & "','" & txtPrev1.Text & "', " & _
                    "'" & txtCurrp2.Text & "','" & txtEfd2.Text & "','" & txtPrev2.Text & "', " & _
                    "'" & txtCurrp3.Text & "','" & txtEfd3.Text & "','" & txtPrev3.Text & "', " & _
                    "'N','" & IIf(rbtAY.Checked = True, "N", "X") & "', '" & Mnu.LIS_UNAME & "',GETDATE(),GETDATE()) " & _
                    "SELECT @@IDENTITY "
            cmd = New SqlCommand(str, cn)
            cmd.CommandTimeout = 0
            docentry = cmd.ExecuteScalar

            For i As Integer = 0 To D.Rows.Count - 1
                str =
                "INSERT INTO ITEM_MASTERD_LIS_LOG (DOCENTRY,WHSCODE,IMD_PKG_CODE, IMD_PKG_ITEM, IMD_DISP_SEQ, IMD_PKG_PRICE, DATEMODIFIED ) " & _
                "VALUES('" & docentry & "','" & lblWhsCode.Text & "','" & txtPkgCode.Text & "','" & D("CODE", i).Value & "','" & D("DISPLAYSEQ", i).Value & "','" & D("PRICE", i).Value & "',GETDATE()) "
                cmd = New SqlCommand(str, cn)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
            Next
            str = "COMMIT"
            cmd = New SqlCommand(str, cn)
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ERR = True
            str = "IF @@TRANCOUNT > 0 ROLLBACK TRAN"
            cmd = New SqlCommand(str, cn)
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
        End Try
        cmd.Dispose()
        cn.Dispose()
        Return ERR
    End Function

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub
    Sub ClearAll()
        txtPkgCode.Clear()
        txtPkgDesc.Clear()
        txtCurrp1.Clear()
        txtCurrp2.Clear()
        txtCurrp3.Clear()
        txtEfd1.Clear()
        txtEfd2.Clear()
        txtEfd3.Clear()
        txtPrev1.Clear()
        txtPrev2.Clear()
        txtPrev3.Clear()
        txtListP.Clear()
        txtstdc.Clear()
        txtBcode.Clear()
        lbltotal.Text = 0
        D.Rows.Clear()
        rbtAN.Checked = True
        rbtAY.Checked = False
        lblBillDesc.Text = "----"
    End Sub

    Private Sub D_KeyDown(sender As Object, e As KeyEventArgs) Handles D.KeyDown
        If e.KeyCode = Keys.F9 Then
            frmSearchPkg.PkgSearch = "PACKAGEBR"
            frmSearchPkg.ShowDialog()
        End If
    End Sub

    Private Sub txtBcode_LostFocus(sender As Object, e As EventArgs) Handles txtBcode.LostFocus
        lblBillDesc.Text = loadbcode(txtBcode.Text)
    End Sub

    Private Sub txtBcode_TextChanged(sender As Object, e As EventArgs) Handles txtBcode.TextChanged

    End Sub
    Function loadbcode(ByVal Billcode As String)
        Dim cnstr As String =
         "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(lblWhsCode.Text) & ")(PORT = 1521)) " & _
         "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        str = "SELECT BL_DESC FROM BILLCODE WHERE BL_CODE = '" & Billcode & "'"
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        str = cmd.ExecuteScalar
        If str = "" Then str = "----"
        Return str
        cmd.Dispose()
        cn.Dispose()
    End Function
End Class