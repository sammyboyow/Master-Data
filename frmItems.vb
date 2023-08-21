Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc


Public Class frmItems
    Dim whs As String = ""

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If txtOdbc.Text = "" Then Exit Sub
            Dim db As String = "LIS-" & Trim(txtOdbc.Text)
            Dim cn As New OdbcConnection("DSN=" & db & ";Uid=HCLAB;Pwd=HCLAB;")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = "select * from item_masterh"
            Dim cmd As OdbcCommand = New Odbc.OdbcCommand(str, cn)
            Dim dr As OdbcDataReader = cmd.ExecuteReader
            Dim i As Integer = 0
            Dim ii As Integer = 0
            '   dPack.Columns.Clear()
            dPack.Rows.Clear()
            If dr.HasRows Then
                MsgBox("Connected")
                'For i = 0 To dr.FieldCount - 1
                '    dPack.Columns.Add(dr.GetName(i), dr.GetName(i))
                'Next
                'dPack.Columns.Add("imh_code", "imh_code")
                'dPack.Columns.Add("imh_Desc", "imh_Desc")
                i = 0
                While dr.Read
                    dPack.Rows.Add()
                    dPack(0, i).Value = i + 1

                    dPack(1, i).Value = dr("imh_code")
                    dPack(2, i).Value = dr("imh_Desc")
                    dPack(3, i).Value = whs
                    i += 1
                    Me.Refresh()
                End While
                MsgBox("Loading Done...")
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub


    Private Sub chkODBc()
        Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog= '" & dbCommon & "';Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = "Select * from icpcod"
        Dim cmd As SqlCommand = New SqlClient.SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read

            End While
        End If
    End Sub
    Private Sub LoadODbc()
        Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog= '" & DbCommon & "';Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = "Select whsname,code,lis from sapset order by code"
        Dim cmd As SqlCommand = New SqlClient.SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        dlist.Columns.Clear()
        dlist.Rows.Clear()
        Dim i As Integer
        If dr.HasRows Then
            dlist.Columns.Add("whs", "Code")
            dlist.Columns.Add("Ave", "Branch")
            dlist.Columns.Add("Lis", "ODBC")

            While dr.Read
                dlist.Rows.Add()
                dlist(0, i).Value = dr(0)
                dlist(1, i).Value = dr(1)
                dlist(2, i).Value = dr(2)
                i += 1
            End While
        End If
        dr.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prbProcess.Minimum = 0
        prbProcess.Maximum = 10
        prbProcess.Step = 1
        LoadODbc()
        ' LoadArchive()
    End Sub

    Private Sub dlist_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dlist.MouseClick
        txtOdbc.Text = dlist(2, dlist.CurrentRow.Index).Value
        whs = dlist(1, dlist.CurrentRow.Index).Value
    End Sub


    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        prbProcess.Value = 0
        Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog= '" & DbCommon & "';Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim cmd As SqlCommand
        Dim str As String
        Dim i As Integer = 0
        Dim desc As String = ""
        prbProcess.Minimum = 0
        prbProcess.Maximum = dPack.RowCount - 1
        prbProcess.Step = 1


        For i = 0 To dPack.RowCount - 1
            If dPack("ln", i).Value.ToString = "" Then Exit For
            desc = CStr(dPack(2, i).Value.ToString)
            desc = Replace(desc, "'", "''")
            str = "if not exists(select * from icpcod where pricelist='" & dPack(1, i).Value & "' and branch='" & dPack(3, i).Value & "') insert into icpcod values('" & dPack(1, i).Value & "','" & desc & "','" & dPack(3, i).Value & "') " & _
                        " update icpcod set [desc]='" & desc & "' where pricelist='" & dPack(1, i).Value & "' and branch='" & dPack(3, i).Value & "'"
            cmd = New SqlClient.SqlCommand(str, cn)
            cmd.ExecuteNonQuery()
            prbProcess.PerformStep()
            Me.Refresh()
        Next i
        MsgBox("Done...")


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPop.Click

        Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog= '" & Db & "';Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim cmd As SqlCommand
        Dim str As String = ""
        '    After updating all branches

        '--Delete Temp Table
        'Drop Table  '"& dbCommon &"'..icpcod4
        str = "Drop Table  '" & DbCommon & "'..icpcod4"
        cmd = New SqlCommand(str, cn)
        cmd.ExecuteNonQuery()

        '--Populate Used Package Codes
        'select distinct U_PackageNo,whscode into  '"& dbCommon &"'..icpcod4 from INV1 where DocDate > '7/1/2012'
        str = "select distinct U_PackageNo,whscode into  '" & DbCommon & "'..icpcod4 from hpcommon..INV1 where DocDate > '" & dtDate.Value & "'"
        cmd = New SqlCommand(str, cn)
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        '--Clear Null/Blank Package/WhsCodes
        'DELETE  '"& dbCommon &"'..icpcod4 WHERE isnull(U_PackageNo,'') = ''
        'DELETE  '"& dbCommon &"'..icpcod4 WHERE isnull(whscode,'') = ''
        str = "DELETE  '" & DbCommon & "'..icpcod4 WHERE isnull(U_PackageNo,'') = ''"
        cmd = New SqlCommand(str, cn)
        cmd.ExecuteNonQuery()

        str = "DELETE  '" & DbCommon & "'..icpcod4 WHERE isnull(whscode,'') = ''"
        cmd = New SqlCommand(str, cn)
        cmd.ExecuteNonQuery()


        '--Insert New and used Packages per Warehouse
        'INSERT INTO  '"& dbCommon &"'..ICPCOD
        'SELECT I.* FROM  '"& dbCommon &"'..ICPCOD2 I INNER JOIN (
        'select I.* from  '"& dbCommon &"'..icpcod o 
        'RIGHT join  '"& dbCommon &"'..icpcod4 i on PriceList = U_PackageNo and o.Branch = WhsCode
        'WHERE O.PriceList IS NULL) T ON I.PriceList = T.U_PackageNo AND I.Branch = T.WhsCode
        str = "INSERT INTO  '" & DbCommon & "'..ICPCOD " & _
                "SELECT I.* FROM  '" & DbCommon & "'..ICPCOD2 I INNER JOIN ( " & _
                "select I.* from  '" & DbCommon & "'..icpcod o " & _
                "RIGHT join  '" & DbCommon & "'..icpcod4 i on PriceList = U_PackageNo and o.Branch = WhsCode " & _
                "WHERE O.PriceList IS NULL) T ON I.PriceList = T.U_PackageNo AND I.Branch = T.WhsCode "
        cmd = New SqlCommand(str, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub frmPackage_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub
End Class
