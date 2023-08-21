Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class frmLoadPck
    Sub LoadOdbc()
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = "Select * from sapset order by code"
        Dim cmd As SqlCommand = New SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        DgridOdbcList.Rows.Clear()

        Dim i As Integer = 0

        If dr.HasRows Then
            While dr.Read
                DgridOdbcList.Rows.Add()
                DgridOdbcList("ClmOCode", i).Value = dr("Whsname")
                DgridOdbcList("ClmOBrnch", i).Value = dr("Code")
                DgridOdbcList("ClmOdbc", i).Value = dr("LIS")
                i += 1
            End While
        End If
        dr.Close()
    End Sub


    Private Sub frmBrchPack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadOdbc()
        iOdbc = ""
    End Sub

    Private Sub CmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoad.Click
        Try
            If iOdbc = "" Then Exit Sub
            DgridOdbcList.Enabled = False

            Dim cn As New OdbcConnection("DSN=LIS-" & Trim(iOdbc) & ";Uid=HCLAB;Pwd=HCLAB;")
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim str As String = ""

            If CboPrces.Text = "Doc" Or CboPrces.Text = "Cust" Then
                str = "select resource_code DCode, resource_name DName from hfresource"
            ElseIf CboPrces.Text = "Items" Then
                str = "SELECT IMH_CODE, IMH_DESC, BL_DESC FROM ITEM_MASTERH INNER JOIN BILLCODE ON IMH_BILLCODE = BL_CODE"
            End If

            Dim cmd As OdbcCommand = New Odbc.OdbcCommand(str, cn)
            Dim dr As OdbcDataReader = cmd.ExecuteReader

            Dim i As Integer = 0
            Dim ii As Integer = 0

            DgridDoc.Rows.Clear()

            If dr.HasRows Then
                MsgBox("Connected")

                i = 0
                While dr.Read
                    DgridDoc.Rows.Add()
                    DgridDoc("ClmNo", i).Value = i + 1

                    If CboPrces.Text = "Doc" Or CboPrces.Text = "Cust" Then
                        DgridDoc("ClmDcode", i).Value = dr("DCode")
                        DgridDoc("ClmDName", i).Value = dr("DName")
                        DgridDoc("ClmDBrnch", i).Value = (DgridOdbcList("ClmOBrnch", DgridOdbcList.CurrentRow.Index).Value)

                        lblLoad.Text = "Loading : " & dr("DCode") & " - " & dr("Dname")

                    ElseIf CboPrces.Text = "Items" Then
                        DgridDoc("ClmDcode", i).Value = dr("imh_code")
                        DgridDoc("ClmDName", i).Value = dr("imh_Desc")
                        DgridDoc("ClmDBrnch", i).Value = dr("BL_DESC")

                        lblLoad.Text = "Loading : " & dr("imh_code") & " - " & dr("imh_Desc")
                    End If

                    i += 1

                    Me.Refresh()
                End While

                lblLoad.Text = "Done : Total Loads = " & i
                CmdProcess.Enabled = True
                DgridOdbcList.Enabled = True
                MsgBox("Done...")
            End If

        Catch EX As Exception
            MsgBox(EX.Message)
            DgridOdbcList.Enabled = True
            lblLoad.Text = "------"
        End Try
    End Sub

    Private Sub DgridOdbcList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgridOdbcList.MouseClick
        iOdbc = (DgridOdbcList("ClmOdbc", DgridOdbcList.CurrentRow.Index).Value)
    End Sub

    Private Sub CmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProcess.Click
        Try
            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim cmd As SqlCommand
            Dim str As String = ""
            Dim i As Integer = 0
            Dim desc As String = ""

            For i = 0 To DgridDoc.RowCount - 1
                If DgridDoc("CLmNo", i).Value.ToString = "" Then Exit For
                desc = CStr(DgridDoc("ClmDName", i).Value.ToString)

                desc = Replace(desc, "'", "''")

                If CboPrces.Text = "Doc" Then
                    str = "if not exists(select * from LisDoc where Code='" & DgridDoc("ClmDcode", i).Value & "' and brnch='" & DgridDoc("ClmDBrnch", i).Value & "') " & _
                                            " insert into LisDoc (Code,Name,Brnch) values " _
                                                        & " ('" & DgridDoc("ClmDCode", i).Value & "', " _
                                                        & " '" & desc & "', " _
                                                        & " '" & DgridDoc("ClmDBrnch", i).Value & "') " & _
                                            " update LisDoc set Name='" & desc & "' " _
                                                        & " where Code='" & DgridDoc("ClmDcode", i).Value & "' " _
                                                        & " and Brnch='" & DgridDoc("ClmDBrnch", i).Value & "'"

                ElseIf CboPrces.Text = "Cust" Then
                    str = "if not exists(select * from LisCust where Code='" & DgridDoc("ClmDcode", i).Value & "' and brnch='" & DgridDoc("ClmDBrnch", i).Value & "') " & _
                                            " insert into LisCust (DBCode,DBName,WhsCode) values " _
                                                        & " ('" & DgridDoc("ClmDCode", i).Value & "', " _
                                                        & " '" & desc & "', " _
                                                        & " '" & DgridDoc("ClmDBrnch", i).Value & "') " & _
                                            " update LisCust set DBName='" & desc & "' " _
                                                        & " where DBCode='" & DgridDoc("ClmDcode", i).Value & "' " _
                                                        & " and WhsCode='" & DgridDoc("ClmDBrnch", i).Value & "'"

                ElseIf CboPrces.Text = "Items" Then
                    str = "if not exists(select * from icpcod where pricelist='" & DgridDoc("ClmDCode", i).Value & "' and branch='" & DgridOdbcList("ClmOBrnch", DgridOdbcList.CurrentRow.Index).Value & "')" & _
                                            " insert into icpcod (pricelist,[desc],branch,BLDesc) values " _
                                                    & " ('" & DgridDoc("ClmDCode", i).Value & "', " _
                                                    & " '" & desc & "', " _
                                                    & " '" & DgridOdbcList("ClmOBrnch", DgridOdbcList.CurrentRow.Index).Value & "', " _
                                                    & " '" & DgridDoc("ClmDbrnch", i).Value & "') " & _
                                            " update icpcod set [Desc]='" & desc & "', " _
                                                    & " BLDesc='" & DgridDoc("ClmDBrnch", i).Value & "' " _
                                                    & " where pricelist='" & DgridDoc("ClmDCode", i).Value & "' " _
                                                    & " and branch='" & DgridOdbcList("ClmOBrnch", DgridOdbcList.CurrentRow.Index).Value & "'"
                End If

                cmd = New SqlClient.SqlCommand(str, cn)
                cmd.ExecuteNonQuery()

                lblprcs.Text = DgridDoc("ClmDcode", i).Value & " - " & desc

                CmdProcess.Enabled = True
                Me.Refresh()
            Next i

            lblprcs.Text = "Done : Total Process = " & i
            MsgBox("Done...")

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CboPrces_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboPrces.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) Then e.Handled = True
        If (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122)) Then e.Handled = True
    End Sub

    Private Sub CboPrces_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboPrces.TextChanged
        lblLoad.Text = "------"
        lblprcs.Text = "-----"

        If CboPrces.Text = "Doc" Or CboPrces.Text = "Cust" Then
            If CboPrces.Text = "Doc" Then
                CmdProcess.Text = "Process Doc"
                CmdLoad.Text = "Load Doc"
            ElseIf CboPrces.Text = "Cust" Then
                CmdProcess.Text = "Process Cust"
                CmdLoad.Text = "Load Cust"
            End If

            DgridDoc.Columns("ClmDcode").HeaderText = "Code"
            DgridDoc.Columns("ClmDName").HeaderText = "Name"
            DgridDoc.Columns("ClmDBrnch").Visible = False
            CmdLoad.Enabled = True

        ElseIf CboPrces.Text = "Items" Then
            If CboPrces.Text = "Items" Then
                CmdProcess.Text = "Process Items"
                CmdLoad.Text = "Load Items"
            End If

            DgridDoc.Columns("ClmDcode").HeaderText = "ICode"
            DgridDoc.Columns("ClmDName").HeaderText = "IDecs"
            DgridDoc.Columns("ClmDBrnch").Visible = True
            DgridDoc.Columns("ClmDBrnch").HeaderText = "BLDesc"
            CmdLoad.Enabled = True

        ElseIf CboPrces.Text = "---Select---" Then
            CmdLoad.Enabled = False

        ElseIf CboPrces.Text = "" Then
            CboPrces.Text = "---Select---"
        Else
            CmdLoad.Enabled = False
        End If
    End Sub
End Class