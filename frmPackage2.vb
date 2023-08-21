Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Public Class frmPackage2

    Public isLoad As Boolean = False
    Dim TCat As String = "Hospital"
    Private Sub btnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDoctor()
    End Sub
    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then LoadDoctor()
    End Sub

    Private Sub LoadDoctor()
        'Dim rs As SAPbobsCOM.Recordset
        'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'Dim str As String = ""
        'If txtname.Text <> "" Then str = str & " and h.name like '" & txtname.Text & "%'"
        'If txtSlpcode.Text <> "" Then str = str & " and U_SalesRep  like '" & txtSlpcode.Text & "%'"
        'If txtSLpname.Text <> "" Then str = str & "and U_SaleName like '" & txtSLpname.Text & "%'"
        'If txtHosp.Text <> "" Then str = str & " and d.U_Hospital like '" & txtHosp.Text & "%'"
        'If txAdd.Text <> "" Then str = str & " and d.U_location like '" & txAdd.Text & "%'"
        'str = "select h.Code,h.Name,h.U_SalesRep,U_SaleName,d.U_Hospital,isnull(d.U_location,'') U_location,isnull(convert(varchar, U_Address),'') U_Address " & _
        '        "from [@FT_ODRS] h inner join [@FT_ODRS1] d on h.Code=d.Code where h.code like '" & txtCode.Text & "%' " & str & " order by code"
        'rs.DoQuery(str)
        'Dim i As Integer = 0
        'dList.Rows.Clear()
        'If rs.EoF = False Then
        '    While Not rs.EoF
        '        dList.Rows.Add()
        '        dList("dcode", i).Value = rs.Fields.Item("Code").Value
        '        dList("dName", i).Value = rs.Fields.Item("Name").Value
        '        dList("SlpCode", i).Value = rs.Fields.Item("u_salesrep").Value
        '        dList("Slpname", i).Value = rs.Fields.Item("u_salename").Value
        '        dList("hosp", i).Value = rs.Fields.Item("u_hospital").Value
        '        dList("LOc", i).Value = rs.Fields.Item("U_location").Value
        '        dList("Add1", i).Value = rs.Fields.Item("U_Address").Value
        '        i += 1
        '        rs.MoveNext()

        '    End While
        '    '  lblPcount.Text = " Doctor Count :" & i
        'End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Try
            Dim row As Integer = 1
            Dim xlApp As Excel.Application = New Excel.Application
            Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xltx")
            Dim xlWS As Excel.Worksheet = xlWB.Worksheets(1)
            xlApp.Visible = True
            Dim i As Integer
            For i = 0 To dList.Columns.Count - 1
                xlWS.Cells(row, i + 1) = dList.Columns(i).HeaderText
            Next
            xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
            row += 1
            Dim x As Integer = 0
            For x = 0 To dList.Rows.Count - 1
                For i = 0 To dList.Columns.Count - 1
                    If i = 0 Then
                        xlWS.Cells(row, i + 1).Value = dList(i, x).Value
                    Else
                        xlWS.Cells(row, i + 1) = dList(i, x).Value
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
        '  login()    
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnImnport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImnport.Click
        Dim curr As String = ""
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")

        'prbProcess.Value = 0


        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        'xlWS = xlWB.Worksheets(cboCat.Text).Activate
        Dim i As Integer = 0
        Dim ii As Integer = 0
        Dim PKCOde As String = ""
        Dim pdtl As String = ""
        Dim Ttal As Double = 0
        dList.Rows.Clear()
        For i = 2 To xlWS.Rows.Count - 11
            If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For

            If PKCOde <> xlWS.Cells(i, 1).value Then
                dList.Rows.Add()
                PKCOde = xlWS.Cells(i, 1).value
                dList("Pcode", ii).Value = xlWS.Cells(i, 1).value
                dList("pName", ii).Value = xlWS.Cells(i, 2).value
                dList("dtl", ii).Value = xlWS.Cells(i, 3).value
                dList("price", ii).Value = xlWS.Cells(i, 4).value
                If IsDate(xlWS.Cells(i, 5).value) Then
                    dList("pdate", ii).Value = Format(xlWS.Cells(i, 5).value, "MM/dd/yyyy")
                Else
                    dList("pdate", ii).Value = ""
                End If
                pdtl = xlWS.Cells(i, 3).value
                Ttal = xlWS.Cells(i, 4).value
                ii += 1

            Else
                Dim x As Integer = dList.Rows.Count - 1
                pdtl = pdtl & "," & xlWS.Cells(i, 3).value
                dList("dtl", x).Value = pdtl
                Ttal += xlWS.Cells(i, 4).value
                dList("price", x).Value = Ttal
            End If
        Next

        xlWB.Close(Application.StartupPath + "\Book1.xlsx")
        xlApp.DisplayAlerts = False
        xlApp.Quit()

        xlWS = Nothing
        xlWB = Nothing
        xlApp = Nothing
        If dList.Rows.Count = 0 Then MsgBox("No Records found in sheetname Doctor")
        '     lblPcount.Text = "Customer Count : " & dList.Rows.Count


        'select h.Code,Name,DocEntry,Canceled,h.Object,CreateDate,U_SalesRep,U_SaleName,
        '		U_Location,U_Address	
        ' from [@FT_ODRS] h inner join [@FT_ODRS1] d on h.code=d.code
    End Sub


    Private Sub btnLoadExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadExcel.Click

        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")

        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        xlWS.Activate()

        xlWS.Cells.ClearContents()
        xlApp.Visible = True
        xlWS.Cells(1, 1).Value = "PACKAGE CODE"
        xlWS.Cells(1, 2).Value = "PACKAGE NAME"
        xlWS.Cells(1, 3).Value = "PACKAGE_DTL"
        xlWS.Cells(1, 4).Value = "PRICE"
        xlWS.Cells(1, 5).Value = "PACKAGE DATE"
        xlApp.ActiveWorkbook.Save() 'As(Application.StartupPath + "\Book1.xlsx")
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim cntUpd As Integer = 0
        'Dim cntAdd As Integer = 0
        'Dim rs As SAPbobsCOM.Recordset
        'prbProcess.Minimum = 0
        'prbProcess.Maximum = dList.RowCount - 1
        'prbProcess.Step = 1
        'Dim i As Integer = 0

        'For i = 0 To dList.Rows.Count - 1
        '    '    If chkImport(dList(3, i).Value, 3) <> False Then
        '    rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        '    Dim str As String = "SELECT * FROM [@FT_odrs] where code='" & dList("Dcode", i).Value & "'"
        '    rs.DoQuery(str)
        '    If rs.EoF = True Then
        '        str = "insert into [@FT_ODRS]( Code,Name,DocEntry,Canceled,OBJECT,UserSign,Transfered,CreateDate,CreateTime,DataSource,U_SalesRep,U_SaleName )  " & _
        '                "  values('" & dList("dM/dd/yyyy") & "','" & Format(Now, "hhmm") & "',0,'" & dList("slpcode", i).Value & "','" & dList("slpname", i).Value & "')"
        '        rs.DoQuery(str)
        '        str = "insert into [@FT_ODRS1]( Code,LineId,U_Location,U_Hospital )  " & _
        '                "  values('" & dList("dcode", i).Value & "','1','" & dList("loc", i).Value & "','" & dList("hosp", i).Value & "')"
        '        rs.DoQuery(str)
        '        cntAdd += 1
        '    Else
        '        str = "update  [@FT_ODRS] set Name='" & dList("dname", i).Value & "',U_SalesRep='" & dList("slpcode", i).Value & "',U_SaleName='" & dList("slpname", i).Value & "'" & _
        '                   "where  code='" & dList("Dcode", i).Value & "'"
        '        rs.DoQuery(str)
        '        str = "update  [@FT_ODRS1] set U_Location='" & dList("loc", i).Value & "',U_Hospital='" & dList("hosp", i).Value & "'" & _
        '                   "where  code='" & dList("Dcode", i).Value & "'"
        '        rs.DoQuery(str)
        '        cntUpd += 1
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
        'lblPcount.Text = "Process Count : " & cntAdd + cntUpdcode", i).Value & "','" & dList("dname", i).Value & "',(select MAX(ISNULL(docentry,0))+1 from [@FT_ODRS]),'N','FTODRS','1','N'," & _
        '                " '" & Format(Now, "M
    End Sub

    Private Sub frmDoctor_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RegionChanged

    End Sub

    Private Sub frmDoctor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        dList.Height = Me.Height - 100
        dList.Width = Me.Width - 25
        'btnLoadExcel.Top = Me.Height - 60
        'btnImnport.Top = btnLoadExcel.Top
        'btnProcess.Top = btnLoadExcel.Top
        'prbProcess.Top = btnLoadExcel.Top
        'btnExport.Top = btnLoadExcel.Top
        ''     lblPcount.Top = btnLoadExcel.Top

    End Sub
End Class