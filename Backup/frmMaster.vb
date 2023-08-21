Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class frmMaster
    Dim vCode As String = ""
    Public isLoad As Boolean = False
    Dim TCat As String = "Hospital"

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")

        If cboCat.Text = "DocTor SalesPerson" Then
            TCat = "SalesPersons"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            TCat = "SlpCode"
        Else
            TCat = cboCat.Text
        End If

        Dim xlWS As Excel.Worksheet = xlWB.Worksheets(TCat)
        xlWS.Activate()

        xlWS.Cells.ClearContents()
    
        xlApp.Visible = True
        If cboCat.Text = "Hospital" Or cboCat.Text = "DocTor SalesPerson" Then
            xlWS.Cells(1, 1).Value = "DocCode"
            xlWS.Cells(1, 2).Value = cboCat.Text
        ElseIf cboCat.Text = "Special Item" Or cboCat.Text = "Special Package" Then
            xlWS.Cells(1, 1).Value = "Code"
            xlWS.Cells(1, 2).Value = "Name"
            xlWS.Cells(1, 3).Value = "Rate"
            xlWS.Cells(1, 4).Value = "Amt"
            xlWS.Cells(1, 5).Value = "CardCode"
            xlWS.Cells(1, 6).Value = "Source"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            xlWS.Cells(1, 1).Value = "CardCode"
            xlWS.Cells(1, 2).Value = "SlpCode"
        Else
            xlWS.Cells(1, 1).Value = "CardCode"
            xlWS.Cells(1, 2).Value = "CardName"
            xlWS.Cells(1, 3).Value = cboCat.Text
        End If


        xlApp.ActiveWorkbook.Save() 'As(Application.StartupPath + "\Book1.xlsx")
        LoadChoices()
    End Sub

    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadChoices()
        '   login()
        Me.Text = "Update Customers [" & cboCat.Text & "]"
        isLoad = False

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
            Me.Text = "Update Customers [" & cboCat.Text & "]"
            If LRet Then
                MsgBox(oCompany.GetLastErrorDescription)
                End
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub

    Private Sub LoadChoices()
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "Terms" Then
            str = "Select Groupnum,PymntGroup Terms from OCTG "
            lblType.Text = "Terms"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            str = "select slpcode,slpname from OSLP"
            lblType.Text = "Salesperson"
        ElseIf cboCat.Text = "DocTor SalesPerson" Then
            str = "select slpcode,slpname from OSLP"
            lblType.Text = "Salesperson"
        ElseIf cboCat.Text = "Billing Cycle" Then
            str = "select * from  [@FT_OCCS]"
            lblType.Text = "Billing Cycle"
        ElseIf cboCat.Text = "Special Item" Then
            str = "select * from oitm where invntitem='N'"
            lblType.Text = "Items"
        ElseIf cboCat.Text = "Special Package" Then
            lblType.Text = "Package"
            str = "select distinct PriceList,[desc] from  hpcommon..icpcod"
        Else
            D.Rows.Clear()
        End If
        D.Rows.Clear()
        D.Columns.Clear()
        If str <> "" Then
            rs.DoQuery(str)
            
            D.Columns.Add(rs.Fields.Item(0).Name, rs.Fields.Item(0).Name)
            D.Columns.Add(rs.Fields.Item(1).Name, rs.Fields.Item(1).Name)
            D.Columns(1).Width = 200

            Dim i As Integer = 0
            If rs.EoF = False Then
                While Not rs.EoF
                    D.Rows.Add()
                    D(0, i).Value = rs.Fields.Item(0).Value
                    D(1, i).Value = rs.Fields.Item(1).Value.ToString.ToUpper
                    rs.MoveNext()
                    i += 1
                End While
            End If
        End If
    End Sub
    
  
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim cn As New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='" & Application.StartupPath & "\Book1.xlsx';Extended Properties=Excel 12.0;")
        cn.Open()
        Dim cmd As OleDbCommand = New OleDb.OleDbCommand("select  * from [Sheet1$]", cn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        Dim ii As Integer = 0
        '    dList.Columns.Clear()
        dList.Rows.Clear()
        If dr.HasRows Then
            dList.Columns("Terms").HeaderText = cboCat.Text
            While dr.Read
                dList.Rows.Add()
                dList(0, i).Value = dr(0)
                dList(1, i).Value = dr(1)
                dList(3, i).Value = dr(2)

                If chkImport(dr(0), 4) = False Then
                    dList.Rows(i).Cells(0).Style.BackColor = Color.Red
                Else
                    dList(2, i).Value = LoadSaP(dr(0))
                End If

                If cboCat.Text = "Terms" Then
                    If chkImport(dr(2), 1) = False Then
                        dList.Rows(i).Cells(3).Style.BackColor = Color.Red
                    End If
                ElseIf cboCat.Text = "Customer SalesPerson Then" Then
                    If chkImport(dr(2), 2) = "" Then
                        dList.Rows(i).Cells(3).Style.BackColor = Color.Red
                    End If
                End If
                'Next
                i += 1
            End While
        Else
            MsgBox("No records to Load")
        End If
    End Sub
    Private Function LoadSaP2(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""

        If lblType.Text = "Customers" Then
            str = "SElect top 1 S.slpname from ocrd "
            str = "SElect top 1 g.PymntGroup from ocrd o inner join OCTG g on o.GroupNum=g.GroupNum where o.cardcode='" & code & "'"
        ElseIf cboCat.Text = "CreditLine" Then
            str = "SElect top 1 creditline from ocrd where cardcode='" & code & "'"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            str = "SElect top 1 S.slpname from ocrd o inner join OSLP s on o.SlpCode=s.SlpCode where o.cardcode='" & code & "'"
        ElseIf cboCat.Text = "DocTor SalesPerson" Then
            str = "SElect top 1 Slpcode from HPCommon..odrs where Dcode='" & code & "'"
        Else
            str = "SElect top 1 o.code from [@FT_OCCS1] o  where o.u_cardcode='" & code & "'"
        End If

        rs.DoQuery(str)
        str = ""
        If rs.EoF = False Then
            str = rs.Fields.Item(0).Value
        End If
        Return str
    End Function
    Private Function LoadSaP(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""

        If cboCat.Text = "Terms" Then
            str = "SElect top 1 g.PymntGroup from ocrd o inner join OCTG g on o.GroupNum=g.GroupNum where o.cardcode='" & code & "'"
        ElseIf cboCat.Text = "CreditLine" Then
            str = "SElect top 1 creditline from ocrd where cardcode='" & code & "'"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            str = "SElect top 1 S.slpname from ocrd o inner join OSLP s on o.SlpCode=s.SlpCode where o.cardcode='" & code & "'"
        ElseIf cboCat.Text = "DocTor SalesPerson" Then
            str = "SElect top 1 slpcode from hpcommon..odrs where dcode='" & code & "'"
        Else
            str = "SElect top 1 o.code from [@FT_OCCS1] o  where o.u_cardcode='" & code & "' and code<>'MEGA-ALL'"
        End If
        rs.DoQuery(str)
        str = ""
        If rs.EoF = False Then
            str = rs.Fields.Item(0).Value
        End If
        Return str
        vCode = ""


    End Function

    Private Function ActLev(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "COA" Then
            str = "SElect top 1 Levels from [OACT] where Formatcode='" & code & "'"
        Else
            str = "SElect top 1 CardName from ocrd where cardcode='" & code & "'"
        End If
        rs.DoQuery(str)
        ActLev = ""
        If rs.EoF = False Then
            ActLev = rs.Fields.Item(0).Value
        End If
        'Return str
    End Function

    Private Function ActCod(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "COA" Then
            str = "SElect top 1 AcctCode from [OACT] where Formatcode='" & code & "'"
        Else
            str = "SElect top 1 CardName from ocrd where cardcode='" & code & "'"
        End If
        rs.DoQuery(str)
        ActCod = ""
        If rs.EoF = False Then
            ActCod = rs.Fields.Item(0).Value
        End If
        'Return str
    End Function

    Private Function AcctName(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "COA" Then
            str = "SElect top 1 AcctName from [OACT] where Formatcode='" & code & "'"
        Else
            str = "SElect top 1 CardName from ocrd where cardcode='" & code & "'"
        End If
        rs.DoQuery(str)
        AcctName = ""
        If rs.EoF = False Then
            AcctName = rs.Fields.Item(0).Value
        End If
        'Return str
    End Function

    Private Function LoadName(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "DocTor SalesPerson" Then
            str = "SElect top 1 dName from HPcommon..odrs where dcode='" & code & "'"
        Else
            str = "SElect top 1 CardName from ocrd where cardcode='" & code & "'"
        End If
        If cboCat.Text = "Special Item" Or cboCat.Text = "Special Package" Then
            If dList("source", dList.CurrentRow.Index).Value.ToString = "" Then
                str = "SElect '' CName"
            ElseIf CStr(dList("source", dList.CurrentRow.Index).Value.ToString).ToUpper = "CLINICIAN" Then
                str = "SElect top 1 DName from HPCommon..odrs where Dcode='" & code & "'"
            Else
                str = "SElect top 1 CardName from ocrd where cardcode='" & code & "'"
            End If
        End If
        rs.DoQuery(str)
        LoadName = ""
        If rs.EoF = False Then
            LoadName = rs.Fields.Item(0).Value
        End If
        'Return str
    End Function
    

    Private Function chkImport(ByVal code As String, ByVal chkType As Integer) As Boolean
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If chkType = 1 Then ' terms
            str = "SElect top 1 PymntGroup from OCTG where PymntGroup='" & code & "'"

        ElseIf chkType = 2 Then 'slpcode
            If IsNumeric(code) Then
                str = "SElect top 1 * from OSLP where Cast(slpcode as Varchar)='" & code & "'"
            Else
                str = "SElect top 1 * from OSLP where slpName ='" & code & "'"
            End If
        ElseIf chkType = 3 Then ' billcycle
            str = "SElect top 1 * from [@ft_occs] where code='" & code & "'"

        ElseIf chkType = 4 Then 'cardcode
            str = "SElect top 1 cardcode from ocrd where cardcode='" & code & "'"

        ElseIf chkType = 5 Then 'special item
            If cboCat.Text = "Special Item" Then
                str = "select * from oitm where invntitem='N' and itemcode='" & code & "'"
            ElseIf cboCat.Text = "Special Package" Then 'special package
                str = "select * from hpcommon..icpcod where pricelist='" & code & "'"
            End If
        End If
        If str <> "" Then
            rs.DoQuery(str)
            If rs.EoF = False Then
                Return True
            Else
                Return False
            End If
        Else : Return False
        End If
    End Function
    'Private Function GetSlpName(ByVal code As String) As String
    '    Dim rs As SAPbobsCOM.Recordset
    '    rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
    '    Dim str As String = "SElect top 1 slpname from OSLP where slpcode='" & code & "'"
    '    rs.DoQuery(str)
    '    If rs.EoF = False Then
    '        Return rs.Fields.Item(0).Value
    '    Else
    '        Return ""
    '    End If
    'End Function


    Private Sub btnProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProc.Click
        Dim oCOA As SAPbobsCOM.ChartOfAccounts

        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=" & Db & ";Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        'oCOA = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts)
        'If oCOA.GetByKey(ActCod("14101011000")) = True Then
        '    MsgBox(oCOA.Name)
        '    oCOA.FatherAccountKey = "14101"

        '    'oCOA.AccountLevel(ActLev(dList(0, 0).Value))
        '    'oCOA. .AccountLevel = ActLev(dList(0, 0).Value)
        '    LRet = oCOA.Update()
        '    If LRet Then
        '        MsgBox(oCompany.GetLastErrorDescription)
        '    End If
        'End If

        'Exit Sub
        oCust = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        Dim cnt1 As Integer = 0
        Dim cntAdd As Integer = 0
        Dim rs As SAPbobsCOM.Recordset
        prbProcess.Minimum = 0
        prbProcess.Maximum = dList.RowCount - 1
        prbProcess.Step = 1

        Dim i As Integer = 0
        For i = 0 To dList.Rows.Count - 1
            If CStr(dList(0, i).Value) = "" Then Exit For
            If cboCat.Text = "Hospital" Then
                rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                Dim str As String = "select * from HPCommon..odrs where Dcode='" & dList(0, i).Value & "'"
                rs.DoQuery(str)
                If Not rs.EoF = False Then
                    str = "Insert into HPCommon..odrs values('" & dList(0, i).Value & "','1','FTODRS',NULL,'" & dList(1, i).Value & "','" & dList(1, i).Value & "'," & _
                          "NULL,'','','','','0','0','0')"
                    rs.DoQuery(str)
                    cntAdd += 1
                Else
                    str = "Update HPCommon..odrs set U_LOCATION='" & dList(1, i).Value & "',Hosp='" & dList(1, i).Value & "' where Dcode='" & dList(0, i).Value & "'"
                End If
                rs.DoQuery(str)
                cnt1 += 1
            ElseIf cboCat.Text = "COA" Then
                'Dim oCOA As SAPbobsCOM.ChartOfAccounts

                oCOA = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oChartOfAccounts)
                If oCOA.GetByKey(ActCod(dList(0, 0).Value)) = True Then
                    oCOA.FatherAccountKey = dList(2, 0).Value
                    'oCOA.AccountLevel(ActLev(dList(0, 0).Value))
                    'oCOA. .AccountLevel = ActLev(dList(0, 0).Value)
                    oCOA.Update()
                End If
                'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                'Dim str As String = "select * from [@ft_odrs] where code='" & dList(0, i).Value & "'"
                'rs.DoQuery(str)
                'If rs.EoF = False Then
                '    str = "Update [@ft_odrs] set U_SalesRep='" & dList(3, i).Value & "',U_SaleName='" & LoadName(dList(3, i).Value) & "' where code='" & dList(0, i).Value & "'"
                '    rs.DoQuery(str)
                '    UpdateInv(dList(0, i).Value)
                '    cnt1 += 1
                'End If


            ElseIf cboCat.Text = "DocTor SalesPerson" Then
                If GetCode(dList(3, i).Value) <> "" Then
                    Dim str As String = "select * from HPCOMMON..ODRS where Dcode='" & dList(0, i).Value & "'"
                    Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(str, cn)
                    str = cmd.ExecuteScalar
                    If Not str Is Nothing Then
                        str = "Update hpcommon..odrs set slpcode='" & dList(3, i).Value & "' where dcode='" & dList(0, i).Value & "'"
                        cmd = New SqlClient.SqlCommand(str, cn)
                        cmd.ExecuteNonQuery()
                        '    rs1.DoQuery(str)
                        UpdateInv2(dList(0, i).Value)
                        '    cnt1 += 1
                    End If


                    'Dim rs1 As SAPbobsCOM.Recordset
                    'rs1 = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

                    'rs1.DoQuery(str)
                    'If rs1.EoF = False Then
                    '    str = "Update hpcommon..odrs set slpcode='" & dList(3, i).Value & "' where dcode='" & dList(0, i).Value & "'"
                    '    rs1.DoQuery(str)
                    '    UpdateInv2(dList(0, i).Value)
                    '    cnt1 += 1
                    'End If
                End If
            ElseIf cboCat.Text = "Special Item" Or cboCat.Text = "Special Package" Then
                If dList("Rate", i).Value.ToString <> "" And dList("Amt", i).Value.ToString <> "" And dList("Source", i).Value.ToString <> "" Then
                    If chkImport(dList("Itemcode", i).Value, 5) <> False And chkImport(dList("CardCode", i).Value, 4) <> False Then
                        Dim MxCode As Integer = 0
                        Dim str As String = ""
                        If dList("Source", i).Value = "5" Then
                            str = "Select code from [@ft_osrs] where  U_SCode = 5" '5- All Account	
                        ElseIf dList("Source", i).Value = "4" Then
                            str = "Select code from [@ft_osrs] where U_SCode = 4" '4-All Clinician
                        ElseIf dList("Source", i).Value = "3" Then
                            If dList("CardCode", i).Value.ToString <> "" Then str = "Select code from [@ft_osrs] where U_CardCode = '" & dList("CardCode", i).Value & "' and U_SCode = 3" '3-Account	
                        ElseIf dList("Source", i).Value = "2" Then
                            If dList("CardCode", i).Value.ToString <> "" Then str = "Select code from [@ft_osrs] where U_CardCode = '" & dList("CardCode", i).Value & "' and U_SCode = 2" '2-Clinician	
                        ElseIf dList("Source", i).Value = "1" Then
                            str = "Select code from [@ft_osrs] where U_SCode = 1" '2-Account
                        End If
                        If str <> "" Then
                            'Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=" & Db & ";Integrated Security=False;UID=sa;PWD=12345")
                            'If cn.State = ConnectionState.Closed Then cn.Open()
                            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(str, cn)
                            Dim dr As SqlDataReader
                            str = cmd.ExecuteScalar
                            If str Is Nothing Then
                                str = "Select Max(Cast(Code as Int)) +1 From [@FT_OSRS]"
                                cmd = New SqlClient.SqlCommand(str, cn)
                                str = cmd.ExecuteScalar
                                MxCode = str
                                If dList("Source", i).Value.ToString.ToUpper = "ACCOUNT" Then
                                    str = "Insert Into [@FT_OSRS] Values ('" & str & "',NULL,'" & str & "','N','FTOSRS',NULL,1,'N',GETDATE(),'1505',GETDATE(),'1505','I',3,'" & dList("CardCode", i).Value & "','" & dList("Cardname", i).Value & "','1/1/2011',NULL)"
                                Else
                                    str = "Insert Into [@FT_OSRS] Values ('" & str & "',NULL,'" & str & "','N','FTOSRS',NULL,1,'N',GETDATE(),'1505',GETDATE(),'1505','I',2,'" & dList("CardCode", i).Value & "','" & dList("Cardname", i).Value & "','1/1/2011',NULL)"
                                End If
                                cmd = New SqlClient.SqlCommand(str, cn)
                                cmd.ExecuteNonQuery()
                            Else
                                MxCode = str
                            End If

                            str = "Select code from [@ft_osrs] "
                            If dList("Source", i).Value = "3" Then
                                str = str & " where  U_SCode = 3 and U_CardCode = '" & dList("CardCode", i).Value & "'" '3-Account	

                            ElseIf dList("Source", i).Value = "2" Then
                                str = str & " where  U_SCode = 2 and U_CardCode = '" & dList("CardCode", i).Value & "'" ' Clinician

                            ElseIf dList("Source", i).Value = "4" Then
                                str = str & " where  U_SCode = 2"

                            ElseIf dList("Source", i).Value = "5" Then
                                str = str & " where  U_SCode = 3"

                            ElseIf dList("Source", i).Value = "1" Then
                                str = "Select code from [@ft_osrs] "
                            End If
                            If str <> "" Then
                                cmd = New SqlCommand(str, cn)
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                                    While dr.Read
                                        MxCode = dr("code")
                                        If cboCat.Text = "Special Item" Then
                                            str = "If Exists(select 1 from hpdi..[@FT_OSRS1] Where Code = '" & MxCode & "' and U_TestCode = '" & dList("ItemCode", i).Value & "') " & _
                                                " Update HPDI..[@FT_OSRS1] Set U_TestName = '" & Replace(dList("Itemname", i).Value, "'", "''") & "', U_Rate = '" & dList("Rate", i).Value & "', U_Amount = '" & dList("Amt", i).Value & "' Where Code = '" & MxCode & "' and U_TestCode = '" & dList("ItemCode", i).Value & "' Else " & _
                                                " Insert Into [@FT_OSRS1] Values('" & MxCode & "',isnull((Select Max(Cast(LineID as int)) +1 From HPDI..[@FT_OSRS1] Where Code = '" & MxCode & "'),1),'FTOSRS',NULL,'" & dList("ItemCode", i).Value & "','" & Replace(dList("Itemname", i).Value, "'", "''") & "','" & dList("Rate", i).Value & "','" & dList("Amt", i).Value & "')"
                                            rs.DoQuery(str)
                                            cnt1 += 1
                                        ElseIf cboCat.Text = "Special Package" Then
                                            str = "If Exists(select 1 from hpdi..[@FT_OSRS2] Where Code = '" & MxCode & "' and U_Package = '" & dList("ItemCode", i).Value & "') " & _
                                                " Update HPDI..[@FT_OSRS2] Set U_PackName = '" & Replace(dList("Itemname", i).Value, "'", "''") & "', U_Rate = '" & dList("Rate", i).Value & "', U_Amount = '" & dList("Amt", i).Value & "' Where Code = '" & MxCode & "' and U_Package = '" & dList("ItemCode", i).Value & "' Else " & _
                                                " Insert Into [@FT_OSRS2] Values('" & MxCode & "',isnull((Select Max(Cast(LineID as int)) +1 From HPDI..[@FT_OSRS2] Where Code = '" & MxCode & "'),1),'FTOSRS',NULL,'" & dList("ItemCode", i).Value & "','" & Replace(dList("Itemname", i).Value, "'", "''") & "','" & dList("Rate", i).Value & "','" & dList("Amt", i).Value & "')"
                                            rs.DoQuery(str)
                                            cnt1 += 1
                                        End If
                                    End While
                                    dr.Close()
                                End If
                            End If
                        End If
                    End If
                End If

            ElseIf cboCat.Text = "Billing Cycle" Then
                If chkImport(dList(3, i).Value, 3) <> False Then
                    rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                    Dim str As String = "SELECT * FROM [@FT_OCCS1] where U_CARDCODE='" & dList("CardCode", i).Value & "' AND CODE<>'MEGA-ALL' and CODE<>'MH-ALL'"
                    rs.DoQuery(str)
                    If rs.EoF = False Then
                        str = "UPDATE [@FT_OCCS1] SET  CODE='" & dList("Shouldbe", i).Value & "',LineId=(select isnull(MAX(lineid),0)+1 from [@FT_OCCS1] where CODE='" & dList(3, i).Value & "') " & _
                             " where U_CARDCODE='" & dList("CardCode", i).Value & "' AND  CODE<>'MEGA-ALL' and CODE<>'MH-ALL'"
                        'values('" & dList(3, i).Value & "',(select isnull(MAX(lineid),0)+1 from [@FT_OCCS1] where CODE='" & dList(3, i).Value & "'),'FTOCCS',NULL,'" & dList(0, i).Value & "','" & Replace(dList(1, i).Value, "'", "") & "')"
                        rs.DoQuery(str)
                        cntAdd += 1
                    Else
                        str = "INSERT INTO [@FT_OCCS1] values('" & dList(3, i).Value & "',(select isnull(MAX(lineid),0)+1 from [@FT_OCCS1] where CODE='" & dList(3, i).Value & "'),'FTOCCS',NULL,'" & dList(0, i).Value & "','" & Replace(dList(1, i).Value, "'", "") & "')"
                        rs.DoQuery(str)
                        cnt1 += 1
                    End If
                End If
            Else
                Dim CUST As Boolean = False
                If oCust.GetByKey(dList(0, i).Value) = True Then
                    If cboCat.Text = "CreditLine" Then
                        oCust.CreditLimit = dList(3, i).Value
                    Else
                        Dim Grp As String = GetCode(dList(3, i).Value)
                        If Grp <> "" Then
                            If cboCat.Text = "Terms" Then
                                oCust.PayTermsGrpCode = Grp
                            ElseIf cboCat.Text = "Customer SalesPerson" Then
                                oCust.SalesPersonCode = Grp
                                '  oCust.BILL()
                                CUST = True
                            End If
                        End If
                    End If
                    oCust.Update()
                    If CUST = True Then UpdateInv(dList(0, i).Value)
                    cnt1 += 1
                End If
                'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                ''saving of history
                'Dim str As String = "INSERT INTO " & DbCommon & "..CustHist VALUES((SELECT ISNULL(max(docentry),0)+1 FROM " & DbCommon & "..CustHist),'" & dList(0, i).Value & "'," & _
                '        "'" & Format(Now, "MM/dd/yyyy") & "','" & dList(2, i).Value & "','" & dList(3, i).Value & "','" & cboCat.Text & "')"
                'rs.DoQuery(str)
            End If
            prbProcess.PerformStep()
            Me.Refresh()
            lblUpd.Text = "Updated Customer Count : " & cnt1
            lblUpd.Refresh()
        Next i
        Dim msg As String = "Total Process : " & dList.Rows.Count & vbNewLine & "Total Updated Customer : " & cnt1
        If cntAdd <> 0 Then msg = msg & vbNewLine & "Total Added Customer : " & cntAdd
        MsgBox(msg)
        lblUpd.Text = "Updated Customer Count : " & cnt1

    End Sub

    Private Sub UpdateInv(ByVal DocCode As String)
        Dim rs As SAPbobsCOM.Recordset
        Dim str As String = ""

        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        str = "Select top 1 * from ocrd where cardcode = '" & DocCode & "' and cardtype ='C'"
        rs.DoQuery(str)
        If rs.EoF = False Then

            If rs.Fields.Item("GroupCode").Value = "100" Then
                str = "Update HPCommon..inv1 Set SLPCode = c.slpcode from ocrd c where c.CardCode = HPCommon..inv1.basecard and c.GroupCode = '100' " & _
                               "and basecard = '" & DocCode & "' and docdate between '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' and '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' "
            ElseIf rs.Fields.Item("GroupCode").Value = "102" Then
                str = "Update HPCommon..inv1 Set SLPCode = d.Slpcode from ocrd c, hpcommon..odrs d where c.CardCode = HPCommon..inv1.basecard and c.GroupCode = '102' " & _
                                   "and d.DCode = HPCommon..inv1.U_DoctorCode	and U_DoctorCode =  '" & DocCode & "' and docdate between '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' and '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' "
            End If
        End If
        rs.DoQuery(str)
        'str = "update inv1 set slpcode='" & slpcode & "' where docdate between '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' and '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' " & str
    End Sub
    Private Sub UpdateInv2(ByVal DocCode As String)
        Dim rs As SAPbobsCOM.Recordset
        Dim str As String = ""

        If cboCat.Text = "Customer SalesPerson" Then
            str = "Update HPCommon..inv1 Set SLPCode = c.slpcode from ocrd c where c.CardCode = HPCommon..inv1.basecard and c.GroupCode = '100' " & _
                "and basecard = '" & DocCode & "' and docdate between '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' and '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' "
        ElseIf cboCat.Text = "DocTor SalesPerson" Then
            str = "Update HPCommon..inv1 Set SLPCode = d.slpcode from ocrd c, hpcommon..odrs d where c.CardCode = HPCommon..inv1.basecard and c.GroupCode = '102' " & _
                    "and d.dCode = HPCommon..inv1.U_DoctorCode	and U_DoctorCode =  '" & DocCode & "' and docdate between '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' and '" & Format(dtEdate.Value, "MM/dd/yyyy") & "' "
        End If
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery(str)
        'str = "update inv1 set slpcode='" & slpcode & "' where docdate between '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' and '" & Format(dtSdate.Value, "MMMM/dd/yyyy") & "' " & str
    End Sub

    Private Function GetCode(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If cboCat.Text = "Terms" Then
            str = "SElect TOP 1 GroupNum from OCTG where PymntGroup='" & code & "'"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            If IsNumeric(code) Then
                str = " SLPCODE='" & code & "'"
            Else
                str = " SLPNAME='" & code & "'"
            End If

            str = "SElect top 1 * from OSlp where " & str
        ElseIf cboCat.Text = "DocTor SalesPerson" Then
            str = "SElect top 1 * from OSlp where slpcode='" & code & "'"
        End If
        rs.DoQuery(str)
        If rs.EoF = False Then
            Return rs.Fields.Item(0).Value
        Else
            Return ""
        End If
    End Function

    Private Sub dList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dList.CellEndEdit
        Try
            If e.ColumnIndex = 3 Then
                If cboCat.Text = "Terms" Then
                    If chkImport(dList(3, dList.CurrentRow.Index).Value, 1) = False Then
                        dList.Rows(dList.CurrentRow.Index).Cells(2).Style.BackColor = Color.Red
                    Else
                        dList.Rows(dList.CurrentRow.Index).Cells(2).Style.BackColor = Color.Empty
                    End If
                End If
            ElseIf e.ColumnIndex = 0 Then
                Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPDI;Integrated Security=False;UID=sa;PWD=12345")
                If cn.State = ConnectionState.Closed Then cn.Open()

                Dim str As String = "SELECT TOP 1 CardCode,CardName,SlpCode FROM OCRD where CardCode = '" & dList("CardCode", dList.CurrentRow.Index).Value & "'"
                Dim cmd As SqlCommand = New SqlCommand(str, cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
                    dList("CardName", dList.CurrentRow.Index).Value = dr("CardName")
                    dList("SAP", dList.CurrentRow.Index).Value = dr("SlpCode")
                Else
                    dList("CardName", dList.CurrentRow.Index).Value = ""
                    dList("SAP", dList.CurrentRow.Index).Value = ""

                    If chkImport(dList(0, dList.CurrentRow.Index).Value, 4) = False Then
                        dList.Rows(dList.CurrentRow.Index).Cells(2).Style.BackColor = Color.Red
                    Else
                        dList.Rows(dList.CurrentRow.Index).Cells(2).Style.BackColor = Color.Empty
                        dList(2, dList.CurrentRow.Index).Value = LoadSaP(dList(0, dList.CurrentRow.Index).Value)
                    End If
                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dList.KeyDown
        Try
            If dList.Rows.Count = 0 Then Exit Sub
            If e.KeyCode = Keys.F6 Then
                If lblType.Text = "SlpCode" Or lblType.Text = "Billing Cycle" Then
                    dList("Shouldbe", dList.CurrentRow.Index).Value = D(0, D.CurrentRow.Index).Value
                    dList.Rows(dList.CurrentRow.Index).Cells("Shouldbe").Style.BackColor = Color.Empty
                ElseIf lblType.Text = "Terms" Then
                    dList("Shouldbe", dList.CurrentRow.Index).Value = D(1, D.CurrentRow.Index).Value
                    dList.Rows(dList.CurrentRow.Index).Cells("Shouldbe").Style.BackColor = Color.Empty
                ElseIf lblType.Text = "Items" Or lblType.Text = "Package" Then
                    dList("ItemCode", dList.CurrentRow.Index).Value = D(0, D.CurrentRow.Index).Value
                    dList("Itemname", dList.CurrentRow.Index).Value = D(1, D.CurrentRow.Index).Value
                    dList.Rows(dList.CurrentRow.Index).Cells(3).Style.BackColor = Color.Empty
                ElseIf lblType.Text = "Customers" Or lblType.Text = "Doctors" Then
                    dList("CardCode", dList.CurrentRow.Index).Value = D(0, D.CurrentRow.Index).Value
                    dList("CardName", dList.CurrentRow.Index).Value = D(1, D.CurrentRow.Index).Value
                    dList.Rows(dList.CurrentRow.Index).Cells("CardCode").Style.BackColor = Color.Empty
                    dList("Sap", dList.CurrentRow.Index).Value = LoadSaP(dList("CardCode", dList.CurrentRow.Index).Value)
                End If
                'Else
                '    dList(3, dList.CurrentRow.Index).Value = D(1, D.CurrentRow.Index).Value
                '    dList.Rows(dList.CurrentRow.Index).Cells(3).Style.BackColor = Color.Empty
            End If

            'ElseIf e.KeyCode = Keys.Delete Then
            '    If MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then dList.Rows.Remove(dList.CurrentRow)
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboCat_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCat.SelectedValueChanged
        If isLoad = False Then isLoad = True : Exit Sub
        LoadChoices()
        Me.Text = "Update Customers [" & cboCat.Text & "]"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")

        prbProcess.Value = 0
        If cboCat.Text = "DocTor SalesPerson" Then
            TCat = "SalesPersons"
        ElseIf cboCat.Text = "Customer SalesPerson" Then
            TCat = "SlpCode"
        Else
            TCat = cboCat.Text
        End If

        Dim xlWS As Excel.Worksheet = xlWB.Worksheets(TCat)
        'xlWS = xlWB.Worksheets(cboCat.Text).Activate
        Dim i As Integer = 0
        Dim ii As Integer = 0
        dList.Rows.Clear()
        For i = 2 To xlWS.Rows.Count - 1
            If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For
            dList.Rows.Add()


            If cboCat.Text = "Hospital" Then
                dList(0, ii).Value = xlWS.Cells(i, 1).value
                dList(1, ii).Value = xlWS.Cells(i, 2).value
            ElseIf cboCat.Text = "DocTor SalesPerson" Then
                dList(0, ii).Value = xlWS.Cells(i, 1).value
                dList(1, ii).Value = LoadName(xlWS.Cells(i, 1).value)
                dList(2, ii).Value = LoadSaP(xlWS.Cells(i, 1).value)
                dList(3, ii).Value = xlWS.Cells(i, 2).value

                If chkImport(xlWS.Cells(i, 2).value, 2) = False Then
                    dList.Rows(ii).Cells(1).Style.BackColor = Color.Red
                End If
            ElseIf cboCat.Text = "Special Item" Or cboCat.Text = "Special Package" Then
                dList("Source", ii).Value = xlWS.Cells(i, 6).value
                dList("ItemCode", ii).Value = xlWS.Cells(i, 1).value
                dList("ItemName", ii).Value = xlWS.Cells(i, 2).value
                dList("Rate", ii).Value = xlWS.Cells(i, 3).value
                dList("Amt", ii).Value = xlWS.Cells(i, 4).value
                dList("CardCode", ii).Value = xlWS.Cells(i, 5).value
                '  dList("CardName", ii).Value = LoadName(dList("CardCode", ii).Value)
                '  If chkImport(xlWS.Cells(i, 1).value, 5) = False Then dList.Rows(ii).Cells("ItemCode").Style.BackColor = Color.Red
                '  If chkImport(xlWS.Cells(i, 5).value, 4) = False Then dList.Rows(ii).Cells("CardCode").Style.BackColor = Color.Red

            ElseIf cboCat.Text = "COA" Then
                dList(0, ii).Value = xlWS.Cells(i, 1).value
                dList(1, ii).Value = AcctName(xlWS.Cells(i, 1).value)
                dList(2, ii).Value = xlWS.Cells(i, 3).value
            ElseIf cboCat.Text = "Customer SalesPerson" Then
                dList(0, ii).Value = xlWS.Cells(i, 1).value
                dList(1, ii).Value = LoadName(xlWS.Cells(i, 1).value)
                dList(2, ii).Value = LoadSaP(xlWS.Cells(i, 1).value)
                dList(3, ii).Value = xlWS.Cells(i, 2).value

                If chkImport(xlWS.Cells(i, 2).value, 2) = False Then
                    dList.Rows(ii).Cells(3).Style.BackColor = Color.Red
                End If
                If chkImport(xlWS.Cells(i, 2).value, 4) = False Then
                    dList.Rows(ii).Cells(3).Style.BackColor = Color.Red
                End If
            Else
                dList(0, ii).Value = xlWS.Cells(i, 1).value
                dList(1, ii).Value = xlWS.Cells(i, 2).value
                If dList(1, ii).Value.ToString = "" Then dList(1, ii).Value = LoadName(xlWS.Cells(i, 1).value)
                dList(3, ii).Value = xlWS.Cells(i, 3).value

                If chkImport(CStr(xlWS.Cells(i, 1).value), 4) = False Then
                    dList.Rows(ii).Cells(0).Style.BackColor = Color.Red
                Else
                    If cboCat.Text = "Billing Cycle" Then vCode = xlWS.Cells(i, 3).value
                    dList(2, ii).Value = LoadSaP(CStr(xlWS.Cells(i, 1).value))

                End If

                If cboCat.Text = "Terms" Then
                    If chkImport(xlWS.Cells(i, 3).value, 1) = False Then
                        dList.Rows(ii).Cells(3).Style.BackColor = Color.Red
                    End If
                ElseIf cboCat.Text = "Customer SalesPerson" Then
                    If chkImport(xlWS.Cells(i, 3).value, 2) = True Then
                        dList.Rows(ii).Cells(3).Style.BackColor = Color.Red
                    End If
                ElseIf cboCat.Text = "Billing Cycle" Then
                    If chkImport(xlWS.Cells(i, 3).value, 3) = False Then
                        dList.Rows(ii).Cells(3).Style.BackColor = Color.Red
                    End If
                End If

            End If
            ii += 1
        Next

        xlWB.Close(Application.StartupPath + "\Book1.xlsx")
        xlApp.DisplayAlerts = False
        xlApp.Quit()

        xlWS = Nothing
        xlWB = Nothing
        xlApp = Nothing
        If dList.Rows.Count = 0 Then MsgBox("No Records found in sheetname " & cboCat.Text)
        lblPcount.Text = "Customer Count : " & dList.Rows.Count


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dList.Rows.Clear()
        ''     MsgBox(GetSlpName(-1))
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmHist.ShowDialog()
    End Sub

    Private Sub cboCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCat.SelectedIndexChanged
        If isLoad = False Then isLoad = True : Exit Sub
        LoadChoices()
        dList.Columns.Clear()
        If cboCat.Text = "Hospital" Or cboCat.Text = "DocTor SalesPerson" Then
            dList.Columns.Add("CardCode", "DocCode")
            dList.Columns.Add("CardName", "DocName")
            dList.Columns.Add("SAP", "SAP")
            dList.Columns.Add("Shouldbe", cboCat.Text)
        ElseIf cboCat.Text = "Special Item" Or cboCat.Text = "Special Package" Then
            dList.Columns.Add("ItemCode", "Code")
            dList.Columns.Add("ItemName", "Name")
            dList.Columns.Add("Rate", "Rate")
            dList.Columns.Add("Amt", "Amt")
            dList.Columns.Add("CardCode", "CardCode")
            dList.Columns.Add("CardName", "CardName")
            dList.Columns.Add("Source", "Source")
        Else
            dList.Columns.Add("CardCode", "CardCode")
            dList.Columns.Add("CardName", "CardName")
            dList.Columns.Add("SAP", "SAP")
            dList.Columns.Add("Shouldbe", cboCat.Text)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        D.Columns(0).HeaderText = "#"
        Me.Close()
        'prbProcess.Value = 0
    End Sub


    Private Sub Loadlist(ByVal btnName As String)
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        If btnName = "Customers" Then
            str = "select cardcode,cardname from ocrd where  cardtype='C'"
            lblType.Text = "Customers"
        ElseIf btnName = "Doctors" Then
            str = "select Dcode,Dname from hpcommon..odrs"
            lblType.Text = "Doctors"
        ElseIf btnName = "Items" Then
            str = "select itemCode,Itemname from oitm where invntitem='N'"
            lblType.Text = "Items"
        ElseIf btnName = "Package" Then
            lblType.Text = "Package"
            str = "select distinct PriceList,[desc] from  hpcommon..icpcod"
        ElseIf btnName = "Salesperson" Then
            lblType.Text = "Salesperson"
            str = "select slpcode,slpname from OSLP"
        ElseIf btnName = "Terms" Then
            lblType.Text = "Terms"
            str = "Select Groupnum,PymntGroup Terms from OCTG "
        End If
        D.Rows.Clear()
        D.Columns.Clear()
        If str <> "" Then
            rs.DoQuery(str)
            D.Columns.Add(rs.Fields.Item(0).Name, rs.Fields.Item(0).Name)
            D.Columns.Add(rs.Fields.Item(1).Name, rs.Fields.Item(1).Name)
            D.Columns(1).Width = 200
            Dim i As Integer = 0
            If rs.EoF = False Then
                While Not rs.EoF
                    D.Rows.Add()
                    D(0, i).Value = rs.Fields.Item(0).Value
                    D(1, i).Value = rs.Fields.Item(1).Value.ToString.ToUpper
                    rs.MoveNext()
                    i += 1
                End While
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboList.SelectedIndexChanged
        Loadlist(cboList.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        Dim i As Integer
        Dim II As Integer = 0
        For i = 0 To dList.Rows.Count - 1

            str = "insert into hpcommon..doclist values('" & dList(0, i).Value & "', " _
                            & " '" & Replace(dList(1, i).Value, "'", "") & "', " _
                            & " '" & dList(2, i).Value & "', " _
                            & " '" & dList(3, i).Value & "', " _
                            & " '" & dList(4, i).Value & "', " _
                            & " '" & dList(5, i).Value & "', " _
                            & " '" & dList(6, i).Value & "', " _
                            & " '" & dList(7, i).Value & "', " _
                            & " '" & dList(8, i).Value & "', " _
                            & " '" & Replace(dList(9, i).Value, "'", "") & "', " _
                            & " '" & Replace(dList(10, i).Value, "'", "") & "', " _
                            & " '" & Replace(dList(11, i).Value, "'", "") & "', " _
                            & " '" & Replace(dList(12, i).Value, "'", "") & "', " _
                            & " '" & dList(13, i).Value & "', " _
                            & " '" & dList(14, i).Value & "', " _
                            & " '" & dList(15, i).Value & "', " _
                            & " '" & dList(16, i).Value & "', " _
                            & " '" & dList(17, i).Value & "')"
            rs.DoQuery(str)

        Next
        MsgBox("done")
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim cn As New SqlConnection("Data Source=DM-SQLSERVER;Initial Catalog=db_MacroHealth;Integrated Security=False;UID=sapdb;PWD=sapdb")
        Dim cn As New SqlConnection("Data Source=CL-ARCHIVE\MSSQLSERVER2008;Initial Catalog=consultrw;Integrated Security=False;UID=sapdb;PWD=sapdb")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String
        Dim cmd As SqlCommand
        'If txtCert.Text <> nwCod Then
        '    str = "Delete from tblcent where DocEntry='" & txtCert.Text & "'"
        '    cmd = New SqlClient.SqlCommand(str, cn)
        '    cmd.ExecuteNonQuery()
        '    IsUpd = True
        'End If

        ' '********************************************************** saving calibration information **************************************

        Dim i As Integer = 0
        Dim ii As String = ""
        Dim iii As String = 0
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("hehe")


        For i = 1 To xlWS.Rows.Count - 1
            If CStr(xlWS.Cells(i, 1).Value) = "" Then Exit For
            If CStr(xlWS.Cells(i, 12).Value) <> "" Then
                'DocDate	CardName	SOANo	Patient	Quantity	LineTotal	PRocFee	PF	ItemCode	DCode	Dname	LabNO

                '2	    3	    4	    5	    6	7	    8	9	10	    11	    12	    13	    14
                'date	cust	soan	patien	qty	amt	prcfee	pf	item 	pdate	docname	dcod	labno

                str = "Insert into DOinv VALUES('" & xlWS.Cells(i, 2).VALUE & "','" & Trim(xlWS.Cells(i, 3).VALUE) & "'," & _
                                "'" & Trim(xlWS.Cells(i, 4).VALUE) & "','" & Replace(Trim(xlWS.Cells(i, 5).VALUE), "'", "") & "','" & Trim(xlWS.Cells(i, 6).VALUE) & "','" & Trim(xlWS.Cells(i, 7).VALUE) & "'," & _
                                "'" & Trim(xlWS.Cells(i, 8).VALUE) & "','" & Trim(xlWS.Cells(i, 9).VALUE) & "','" & Trim(xlWS.Cells(i, 10).VALUE) & "','" & Trim(xlWS.Cells(i, 13).Value) & "'," & _
                                "'" & Trim(xlWS.Cells(i, 12).Value) & "','" & Trim(xlWS.Cells(i, 14).Value) & "','" & Trim(xlWS.Cells(i, 11).Value) & "')"
                cmd = New SqlClient.SqlCommand(str, cn)
                cmd.ExecuteNonQuery()
            End If
        Next

        'For i = 0 To dList.Rows.Count - 1
        '    If dList(3, i).Value = "" Then Exit For
        '    If CStr(dList(12, i).Value) <> "" Then
        '        ' If dList(2, i).Value.ToString = "" Then dList(3, i).Value = 0
        '        'DocDate,CardName,SOANo,Patient,Quantity,LineTotal,LineTotal PRocFee,Linetotal PF,ItemCode,DCode 
        '        '1	2	3	4	5	6	7	8	9	10	11	12
        '        '1	03/25/12	INTELLICARE (ASALUS)                                        	CN-RW-00027           	BASINILIO, ALEKSI ANTONIO                                   	 1 	 300.00 	 (30.00)	 270.00 	 CNPED8 	NISHIYAMA-CASTILLO, KAREN MAE M.D.                          	11320

        '        str = "Insert into DOinv values('" & dList(2, i).Value & "','" & dList(3, i).Value & "'," & _
        '                        "'" & dList(4, i).Value & "','" & dList(5, i).Value & "','" & dList(6, i).Value & "'" & _
        '                        "'" & dList(8, i).Value & "','" & dList(9, i).Value & "','" & dList(10, i).Value & "','" & dList(11, i).Value & "')"
        '        cmd = New SqlClient.SqlCommand(str, cn)
        '        cmd.ExecuteNonQuery()
        '    End If
        'Next
        

        'Dim xlApp As Excel.Application = New Excel.Application
        'Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        'Dim xlWS As Excel.Worksheet = xlWB.Worksheets("doc")
        'Dim i As Integer = 0
        'Dim ii As Integer = 0


        'Dim rs As SAPbobsCOM.Recordset
        'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'Dim str As String = ""
        'dList.Columns.Add("Code", "Code")
        'For i = 2 To xlWS.Rows.Count - 1
        '    If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For
        '    str = "select * from hpcommon..doclist where RESOURCE_CODE='" & Trim(xlWS.Cells(i, 1).value) & "'"
        '    rs.DoQuery(str)
        '    If rs.EoF = True Then
        '        ' While Not rs.EoF
        '        dList.Rows.Add()
        '        dList(0, ii).Value = xlWS.Cells(i, 1).value
        '        ' rs.MoveNext()
        '        ii += 1
        '        '  End While
        '    End If
        'Next





        'Dim i As Integer
        'Dim II As Integer = 0
        'For i = 0 To dList.Rows.Count - 1

        '    str = "insert into hpcommon..doclist values('" & dList(0, i).Value & "','" & Replace(dList(1, i).Value, "'", "") & "','" & dList(2, i).Value & "','" & dList(3, i).Value & "','" & dList(4, i).Value & "','" & dList(5, i).Value & "','" & dList(6, i).Value & "', " & _
        '        "'" & dList(7, i).Value & " ','" & dList(8, i).Value & "','" & Replace(dList(9, i).Value, "'", "") & "','" & Replace(dList(10, i).Value, "'", "") & "','" & Replace(dList(11, i).Value, "'", "") & "','" & Replace(dList(12, i).Value, "'", "") & "', " & _
        '    "'" & dList(13, i).Value & "','" & dList(14, i).Value & "','" & dList(15, i).Value & "','" & dList(16, i).Value & "','" & dList(17, i).Value & "' " & _
        '    ")"
        '    rs.DoQuery(str)
        'Next
        MsgBox("done")

        'dList.Columns.Clear()
        'For i = 1 To xlWS.Columns.Count - 1
        '    If xlWS.Cells(1, i).value.ToString = "" Then Exit For
        '    dList.Columns.Add(xlWS.Cells(1, i).value, xlWS.Cells(1, i).value)
        'Next





        'For i = 2 To xlWS.Rows.Count - 1



        '    If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For



        '    dList.Rows.Add()
        '    dList(0, ii).Value = xlWS.Cells(i, 1).value
        '    dList(1, ii).Value = xlWS.Cells(i, 2).value
        '    dList(2, ii).Value = xlWS.Cells(i, 3).value
        '    dList(3, ii).Value = xlWS.Cells(i, 4).value
        '    dList(4, ii).Value = xlWS.Cells(i, 5).value
        '    dList(5, ii).Value = xlWS.Cells(i, 6).value
        '    dList(6, ii).Value = xlWS.Cells(i, 7).value
        '    dList(7, ii).Value = xlWS.Cells(i, 8).value
        '    dList(8, ii).Value = xlWS.Cells(i, 9).value
        '    dList(9, ii).Value = xlWS.Cells(i, 10).value
        '    dList(10, ii).Value = xlWS.Cells(i, 11).value()
        '    dList(11, ii).Value = xlWS.Cells(i, 12).value
        '    dList(12, ii).Value = xlWS.Cells(i, 13).value
        '    dList(13, ii).Value = xlWS.Cells(i, 14).value
        '    dList(14, ii).Value = xlWS.Cells(i, 15).value
        '    dList(15, ii).Value = xlWS.Cells(i, 16).value
        '    dList(16, ii).Value = xlWS.Cells(i, 17).value
        '    dList(17, ii).Value = xlWS.Cells(i, 18).value
        '    ii += 1
        'Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer = 0
        For i = 0 To dList.RowCount - 1
            If CStr(dList(0, i).Value) = "" Then Exit For
            UpdateInv2(dList(0, i).Value)
        Next
        MsgBox("Done")

    End Sub

    Private Sub dList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dList.CellContentClick

    End Sub
End Class