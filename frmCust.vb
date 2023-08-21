Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmCust

    Public isLoad As Boolean = False
    Dim TCat As String = "Hospital"
    Private Sub btnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProc.Click
        LoadDoctor()
    End Sub
    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMother.KeyDown, txtname.KeyDown, txtCode.KeyDown
        If e.KeyCode = Keys.Return Then LoadDoctor()
    End Sub

    Private Sub LoadDoctor()
        'Dim rs As SAPbobsCOM.Recordset
        'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=hpdi;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        If txtCode.Text <> "" Then str = str & " and CardCode like '" & txtCode.Text & "%'"
        If txtname.Text <> "" Then str = str & " and CardName  like '" & txtname.Text & "%'"
        str = "Select * from hpcommon..OCrdTrans where MotherName like '" & txtMother.Text & "%'" & str & " order by MotherName,CardCode"
        Dim cmd As New SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        dList.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                dList.Rows.Add()
                dList("Mothername", i).Value = dr("MotherName")
                dList("CardCode", i).Value = dr("CardCode")
                dList("CardName", i).Value = dr("CardName")
                i += 1
            End While
            lblPcount.Text = " Customer Count :" & i
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Try

            Dim row As Integer = 1
            Dim xlApp As Excel.Application = New Excel.Application
            Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xltx")
            Dim xlWS As Excel.Worksheet = xlWB.Worksheets(1)
            xlApp.Visible = True
            Dim i As Integer
            For i = 0 To D.Columns.Count - 1
                xlWS.Cells(row, i + 1) = dList.Columns(i).HeaderText
            Next
            xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
            row += 1
            Dim x As Integer = 0
            For x = 0 To D.Rows.Count - 1
                For i = 0 To D.Columns.Count - 1
                    If i = 0 Then
                        xlWS.Cells(row, i + 1).Value = txtMot.Text.ToUpper
                    Else
                        xlWS.Cells(row, i + 1) = D(i, x).Value
                    End If
                Next
                row += 1
            Next
            xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
            xlWS.Range("a2").Select()
            xlWS.Application.ActiveWindow.FreezePanes = True
            MsgBox("Export Done...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function GetCol(ByVal Col As Integer) As String
        GetCol = ""
        If Col > 13 Then
            GetCol = ""
        End If
        Dim A As Integer
        Dim B As Integer
        Dim str As String
        str = ((Col - 1) / 26).ToString
        If str.IndexOf(".") > 0 Then
            A = str.Substring(0, str.IndexOf("."))
        Else
            A = CInt(str)
        End If

        If A = 0 Then
            GetCol = ""
        Else
            GetCol = Chr(64 + A)
        End If
        B = Col - (A * 26)
        GetCol = GetCol & Chr(64 + B)
    End Function
    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadTerms()
        '   login()
        LoadCust()
    End Sub
    Private Sub LoadCust()
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=hpdi;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        If txtCardCode.Text <> "" Then str = " and cardcode like '" & txtCardCode.Text & "'"
        If txtCardName.Text <> "" Then str = str & " and cardName like '" & txtCardName.Text & "%'"
        str = "select cardCode,Cardname from ocrd where cardtype='C' " & str
        Dim cmd As New SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        D.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                D.Rows.Add()
                D("ln", i).Value = i + 1
                D("dcardCode", i).Value = dr("Cardcode")
                D("dname", i).Value = dr("Cardname")
                i += 1
            End While
        End If

    End Sub
    Private Sub login()
        Try
            oCompany = New SAPbobsCOM.Company
            oCompany.Server = "SAP-PRODSVRx"
            oCompany.DbUserName = "sa"
            oCompany.DbPassword = "12345"
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            oCompany.UserName = "manager"
            oCompany.Password = "12345"
            oCompany.CompanyDB = Db
            If oCompany.Connected = True Then
                oCompany.Disconnect()
            End If
            LRet = oCompany.Connect
            isLoad = True
            '   Me.Text = "Update Customers [" & cboCat.Text & "]"
            If LRet Then
                MsgBox(oCompany.GetLastErrorDescription)
                End
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub









    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub btnLoadExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadExcel.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        xlWS.Activate()

        xlWS.Cells.ClearContents()

        xlApp.Visible = True

        'DocCode	DocName	U_SalesRep	U_Hospital	U_location	U_Address

        xlWS.Cells(1, 1).Value = "MotherName"
        xlWS.Cells(1, 2).Value = "CardCode"
        xlWS.Cells(1, 3).Value = "CardName"
        xlApp.ActiveWorkbook.Save()



    End Sub
    Private Function chkImport(ByVal code As String) As String
        ' Dim rs As SAPbobsCOM.Recordset
        'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=hpdi;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        str = "SElect top 1 cardname from ocrd where cardcode='" & Trim(code) & "'"
        Dim cmd As New SqlCommand(str, cn)
        str = ""
        str = cmd.ExecuteScalar
        'If str <> "" Then
        '    rs.DoQuery(str)
        '    If rs.EoF = False Then
        '        str = rs.Fields.Item(0).Value
        '    Else
        '        str = ""
        '    End If
        'End If
        Return str
    End Function
    Private Function LoadSlpName(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If IsNumeric(code) Then
            str = "SElect top 1 slpName   from OSLP where Cast(slpcode as Varchar)='" & code & "'"
        Else
            str = "SElect top  1 slpName   from OSLP where slpName ='" & code & "'"
        End If

        If str <> "" Then
            rs.DoQuery(str)
            If rs.EoF = False Then
                str = rs.Fields.Item(0).Value
            Else
                str = ""
            End If
        End If
        Return str
    End Function
    Private Sub btnImnport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImnport.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        Dim i As Integer = 0
        Dim ii As Integer = 0
        dList.Rows.Clear()
        Dim str As String

        dList.Columns("Curr").Visible = True
        For i = 2 To xlWS.Rows.Count - 1
            If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For
            dList.Rows.Add()
            dList("MotherName", ii).Value = Trim(xlWS.Cells(i, 1).value)
            dList("CardCode", ii).Value = xlWS.Cells(i, 2).value
            dList("CardName", ii).Value = xlWS.Cells(i, 3).value
            'dList("Hosp", ii).Value = xlWS.Cells(i, 4).value
            'dList("Loc", ii).Value = xlWS.Cells(i, 5).value
            'dList("Add1", ii).Value = xlWS.Cells(i, 6).value
            str = chkImport(Trim(xlWS.Cells(i, 2).value))
            If str = "" Then dList.Rows(ii).DefaultCellStyle.BackColor = Color.Red : dList("tag", ii).Value = "F"
            'dList("Curr", ii).Value = str
            'str = LoadSlpName(xlWS.Cells(i, 3).value)
            If str = "" Then dList("tag", ii).Value = "F"
            'dList("SlpName", ii).Value = LoadSlpName(xlWS.Cells(i, 3).value)

            ii += 1
        Next

        xlWB.Close(Application.StartupPath + "\Book1.xlsx")
        xlApp.DisplayAlerts = False
        xlApp.Quit()

        xlWS = Nothing
        xlWB = Nothing
        xlApp = Nothing
        If dList.Rows.Count = 0 Then MsgBox("No Records found in sheetname Doctor")
        lblPcount.Text = "Customer Count : " & dList.Rows.Count
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        ' Try
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim iSave As String = 0
        Dim iUpdate As String = 0

        Dim i As Integer = 0

        If dList.Rows.Count <> 0 Then

            For i = 0 To dList.Rows.Count - 1

                iDCode = (dList("CardCode", i).Value)

                If dList("Tags", i).Value <> "F" Then
                    str = "if not exists(Select * from OCRDTrans where  CardCode= '" & iDCode & "' and MotherName='" & dList("MotherName", i).Value & "') " & _
                                "Insert into OCRDTrans values('" & dList("MotherName", i).Value & "','" & iDCode & "','" & dList("CardName", i).Value & "')"
                    Dim cmd As SqlCommand = New SqlCommand(str, cn)
                    cmd.ExecuteNonQuery()
                    'Dim dr As SqlDataReader = cmd.ExecuteReader

                    'If dr.HasRows Then
                    '    str = "UPDATE ODRS SET DName = '" & dList("DName", i).Value & "', " _
                    '                    & " Hosp = '" & dList("Hosp", i).Value & "', " _
                    '                    & " U_Location = '" & dList("Loc", i).Value & "', " _
                    '                    & " Add1 = '" & dList("Add1", i).Value & "', " _
                    '                    & " SlpCode = '" & dList("SlpCode", i).Value & "', " _
                    '                    & " Createdate = '" & Format(Now, "MM/dd/yyyy") & "'" _
                    '                    & " where DCode = '" & iDCode & "';"

                    '    '& " Sched = '" & dList("CLmSched", i).Value & "', " _
                    '    '& " Specialization = '" & dList("ClmSpclization", i).Value & "', " _
                    '    '& " AcctNo = '" & dList("ClmAcct", i).Value & "', " _
                    '    '& " BDate = '" & dList("ClmBdate", i).Value & "', " _
                    '    '& " Phone1 = '" & dList("ClmTel", i).Value & "', " _
                    '    '& " Email = '" & dList("ClmEmail", i).Value & "', " _
                    '    '& " Remarks = '" & dList("CLmRmarks", i).Value & "', " _

                    '    iUpdate += 1

                    'Else

                    '    str = "insert into ODRS (Dcode,DName,Hosp,U_Location,Add1,SlpCode,Createdate) values " _
                    '                    & " ('" & dList("DCode", i).Value & "', " _
                    '                    & " '" & dList("DName", i).Value & "', " _
                    '                    & " '" & dList("Hosp", i).Value & "', " _
                    '                    & " '" & dList("Loc", i).Value & "', " _
                    '                    & " '" & dList("Add1", i).Value & "', " _
                    '                    & " '" & dList("SlpCode", i).Value & "', " _
                    '                    & " '" & Format(Now, "MM/dd/yyyy") & "')"

                    '    '& " '" & dList("CLmSched", i).Value & "', " _
                    '    '& " '" & dList("ClmSpclization", i).Value & "', " _
                    '    '& " '" & dList("ClmAcct", i).Value & "', " _
                    '    '& " '" & dList("ClmBdate", i).Value & "', " _
                    '& " '" & dList("ClmTel", i).Value & "', " _
                    '& " '" & dList("ClmEmail", i).Value & "', " _
                    '& " '" & dList("CLmRmarks", i).Value & "', " _


                    iSave += 1
                    ' End If

                    ''     dr.Close()
                    'cmd = New SqlCommand(str, cn)
                    'cmd.ExecuteNonQuery()
                End If

                '  lblPrces.Text = "(Save Count : " & iSave & ") (Update Count : " & iUpdate & ")  " & dList("DCode", i).Value & " - " & dList("DName", i).Value

                Me.Refresh()

            Next i

            lblPrces.Text = "Done: Total Process = " & i & " (Save Count = " & iSave & ") " '(Update Count = " & iUpdate & ")"
            MsgBox("Done...")
            'CmdProcess.Enabled = False
            'DgridDoc.Rows.Clear()
        Else
            MsgBox("No Rows")
        End If

        'Catch EX As Exception
        '    MsgBox(EX.Message)
        'End Try

        '---------------------------------------------------------------------------------------------
        'Dim cntUpd As Integer = 0
        'Dim cntAdd As Integer = 0
        'Dim rs As SAPbobsCOM.Recordset
        'prbProcess.Minimum = 0
        'prbProcess.Maximum = dList.RowCount - 1
        'prbProcess.Step = 1
        'Dim i As Integer = 0

        'For i = 0 To dList.Rows.Count - 1
        '    If CStr(dList("dcode", i).Value) = "" Then Exit For
        '    '    If chkImport(dList(3, i).Value, 3) <> False Then
        '    Dim aa As String = Db
        '    If dList("tag", i).Value <> "F" Then
        '        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        '        Dim str As String = "SELECT * FROM [@FT_odrs] where code='" & dList("Dcode", i).Value & "'"
        '        rs.DoQuery(str)
        '        If rs.EoF = True Then
        '            str = "insert into [@FT_ODRS]( Code,Name,DocEntry,Canceled,OBJECT,UserSign,Transfered,CreateDate,CreateTime,DataSource,U_SalesRep,U_SaleName )  " & _
        '                    "  values('" & dList("dcode", i).Value & "','" & Replace(dList("dname", i).Value, "'", "") & "',(select MAX(ISNULL(docentry,0))+1 from [@FT_ODRS]),'N','FTODRS','1','N'," & _
        '                       "'" & Format(Now, "MM/dd/yyyy") & "','" & Format(Now, "hhmm") & "',0,'" & dList("slpcode", i).Value & "','" & dList("slpname", i).Value & "')"
        '            rs.DoQuery(str)
        '            str = "insert into [@FT_ODRS1]( Code,LineId,U_Location,U_Hospital,u_city )  " & _
        '                    "  values('" & dList("dcode", i).Value & "','1','" & dList("loc", i).Value & "','" & dList("hosp", i).Value & "','" & Replace(dList("add1", i).Value, "'", "") & "')"
        '            rs.DoQuery(str)
        '            cntAdd += 1
        '        Else
        '            str = "update  [@FT_ODRS] set Name='" & Replace(dList("dname", i).Value, "'", "") & "',U_SalesRep='" & dList("slpcode", i).Value & "',U_SaleName='" & dList("slpname", i).Value & "'" & _
        '                       "where  code='" & dList("Dcode", i).Value & "'"
        '            rs.DoQuery(str)
        '            str = "update  [@FT_ODRS1] set U_Location='" & dList("loc", i).Value & "',U_Hospital='" & dList("hosp", i).Value & "'" & _
        '                       " , u_city ='" & Replace(dList("add1", i).Value, "'", "") & "' where  code='" & dList("Dcode", i).Value & "'"
        '            rs.DoQuery(str)
        '            cntUpd += 1
        '        End If
        '    End If
        '    '  End If
        '    prbProcess.PerformStep()
        '    Me.Refresh()
        '    lblPcount.Text = "Process Doctor Count : " & cntAdd + cntUpd
        '    lblPcount.Refresh()
        'Next i
        'Dim msg As String = "Total Process : " & dList.Rows.Count & vbNewLine & "Total Updated Doctor : " & cntUpd
        'If cntAdd <> 0 Then msg = msg & vbNewLine & "Total Added Doctor : " & cntAdd
        'MsgBox(msg)
        'lblPcount.Text = "Process Count : " & cntAdd + cntUpd
        '", i).Value & "','" & dList("dname", i).Value & "',(select MAX(ISNULL(docentry,0))+1 from [@FT_ODRS]),'N','FTODRS','1','N'," & _
        '                       " '" & Format(Now, "M
    End Sub

    Private Sub dList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dList.CellContentClick

    End Sub

    Private Sub dList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dList.KeyDown
        If dList.Rows.Count = 0 Then Exit Sub
        If e.KeyCode = Keys.F5 Then
            frmFind.ShowDialog()
        End If
    End Sub

    Private Sub txtMother_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMother.LostFocus, txtCode.LostFocus, txtname.LostFocus
        If txtMother.Text <> "" Then LoadDoctor() : Exit Sub
        If txtCode.Text <> "" Then LoadDoctor() : Exit Sub
        If txtname.Text <> "" Then LoadDoctor() : Exit Sub
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMother.TextChanged

    End Sub

    Private Sub txtSLpname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkChange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChange.CheckedChanged
        If chkChange.Checked = True Then
            txtMot.Enabled = False
        Else
            txtMot.Enabled = True
        End If
    End Sub

    Private Sub txtMot_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMot.LostFocus
        txtMot.Enabled = False
        chkChange.Checked = True
    End Sub

    Private Sub txtMot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMot.TextChanged

    End Sub

    Private Sub D_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D.CellContentClick

    End Sub

    Private Sub D_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles D.KeyDown
        If D.Rows.Count = 0 Then Exit Sub
        If e.KeyCode = Keys.Space Then
            If txtMot.Text = "" Then MsgBox("Set MotherName first") : Exit Sub
            Dim i As Integer = dList.Rows.Count
            dList.Rows.Add()
            dList("Mothername", i).Value = txtMot.Text.ToUpper
            dList("CardCode", i).Value = D("DCardCode", D.CurrentRow.Index).Value
            dList("CardName", i).Value = D("DName", D.CurrentRow.Index).Value


        End If
    End Sub

    Private Sub txtCardCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCardCode.KeyDown, txtCardName.KeyDown
        If e.KeyCode = Keys.Return Then LoadCust()


    End Sub

    Private Sub txtCardCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardCode.LostFocus, txtCardName.LostFocus
        If txtCardCode.Text <> "" Then LoadCust() : Exit Sub
        If txtCardName.Text <> "" Then LoadCust() : Exit Sub
    End Sub

    Private Sub txtCardCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardCode.TextChanged

    End Sub
End Class