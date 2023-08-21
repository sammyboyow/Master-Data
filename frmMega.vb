Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Data.Odbc
Imports System.Data.OleDb
Public Class frmMega
    Public oCompany As SAPbobsCOM.Company
    Public oCust As SAPbobsCOM.BusinessPartners
    Public LRet As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    oCompany = New SAPbobsCOM.Company
        '    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
        '    oCompany.Server = "SAP-PRODSVRx"
        '    oCompany.DbUserName = "sa"
        '    oCompany.DbPassword = "12345"
        '    oCompany.UserName = "manager"
        '    oCompany.Password = "12345"
        '    oCompany.CompanyDB = " '" & Db & "'"
        '    If oCompany.Connected = True Then
        '        oCompany.Disconnect()
        '    End If
        '    LRet = oCompany.Connect
        '    If LRet Then
        '        MsgBox(oCompany.GetLastErrorDescription)
        '        End
        '    End If
        '    '   LoadPyment()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    End
        'End Try

    End Sub

    Private Sub txtCardCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCardCode.LostFocus
        'Dim rs As SAPbobsCOM.Recordset
        'rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        'rs.DoQuery("Select Top 1 CardName,GroupNum from OCRD Where CardCode = '" & txtCardCode.Text & "'")
        'If Not rs.EoF Then
        '    txtCardName.Text = rs.Fields.Item(0).Value
        '    txtTerms.Text = rs.Fields.Item(1).Value
        'Else
        '    txtCardCode.Text = ""
        '    txtCardName.Text = ""
        '    txtTerms.Text = ""
        'End If
    End Sub

    Private Sub txtCardCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardCode.TextChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        oCust = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        If oCust.GetByKey(txtCardCode.Text) = True Then
            oCust.PayTermsGrpCode = txtTerms.Text
            oCust.Update()
        End If
    End Sub

    Private Sub txtTerms_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTerms.TextChanged

    End Sub
    Private Sub LoadPyment()
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        rs.DoQuery("Select distinct(PymntGroup) from OCTG ")
        If Not rs.EoF Then
            While Not rs.EoF
                cboTermName.Items.Add(rs.Fields.Item(0).Value)
            End While
        Else
            txtTerms.Text = ""
            'txtTermName.Text = ""
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Dim MyConnection As System.Data.OleDb.OleDbConnection
        'Dim DtSet As System.Data.DataSet
        'Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        'MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='c:\ExImp.xls';Extended Properties=Excel 8.0;")
        '' MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\ExImp.xlxs';Extended Properties=Excel 12.0;")
        'MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        'DtSet = New System.Data.DataSet
        'MyCommand.Fill(DtSet)
        'dList.DataSource = DtSet.Tables(0)
        'MyConnection.Close()

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



    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim i As Integer = 0
        For i = 0 To dList.RowCount - 1
            oCust = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)

            If oCust.GetByKey(dList(0, i).Value) = True Then
                oCust.PayTermsGrpCode = dList(2, i).Value
                oCust.Update()
            End If
        Next i
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        '  Try

        Dim db As String = "LIS-HPMEGA"
        Dim cn As New OdbcConnection("DSN=" & db & ";Uid=HCLAB;Pwd=HCLAB;")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = "select clinic_desc  as Account,id_trx_dt PostDate,  id_lab_tno as Lab,rh_remark as Patient, itd_item_code as Test, itd_gross_amt as Amount, id_med_his1 as pn from inv_dtl  " & _
            "inner join inv_hdr on ih_invno = id_invno  " & _
            "inner join receipt_hdr on rh_ref = id_tno " & _
            "inner join hfclinic on clinic_code = id_source_code " & _
            "inner join inv_itemdtl on itd_tno = id_tno " & _
            "where id_trx_dt BETWEEN to_date('" & Format(dtSdate.Value, "MM-dd-yyyy") & " 00:00:00','MM-DD-YYYY HH24:MI:SS') " & _
            "AND TO_DATE('" & Format(dtEdate.Value, "MM-dd-yyyy") & " 23:59:59','MM-DD-YYYY HH24:MI:SS') " & _
            "order by clinic_desc,id_lab_tno"

        Dim cmd As OdbcCommand = New Odbc.OdbcCommand(str, cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Dim i As Integer = 0
        Dim ii As Integer = 0
        Dim PKCOde As String = ""
        Dim pdtl As String = ""
        Dim Ttal As Double = 0
        '   dPack.Columns.Clear()
        dList.Rows.Clear()
        If dr.HasRows Then
            While dr.Read

                If PKCOde <> Trim(dr("Lab")) Then
                    dList.Rows.Add()
                    PKCOde = Trim(dr("Lab"))
                    dList("Account", ii).Value = dr("Account")
                    dList("Postdate", ii).Value = Format(dr("PostDate"), "MM/dd/yyyy")
                    dList("lab", ii).Value = dr("lab")
                    dList("patient", ii).Value = dr("patient")
                    dList("pn", ii).Value = dr("pn")
                    dList("test", ii).Value = dr("test")
                    dList("amt", ii).Value = dr("Amount")
                    pdtl = dr("test")
                    Ttal = dr("Amount")
                    ii += 1

                Else
                    Dim x As Integer = dList.Rows.Count - 1
                    pdtl = pdtl & "," & dr("test")
                    dList("test", x).Value = pdtl
                    Ttal += dr("Amount")
                    dList("amt", x).Value = Ttal
                End If

                '       MsgBox("Connected")
                'For i = 0 To dr.FieldCount - 1
                '    dList.Columns.Add(dr.GetName(i), dr.GetName(i))
                'Next
                'i = 0
                'While dr.Read
                '    dList.Rows.Add()
                '    For i = 0 To dr.FieldCount - 1
                '        dList(i, ii).Value = dr(i)
                '    Next
                '    ii += 1
                '    Me.Refresh()
            End While
            MsgBox("Loading Done...")
        End If
        'Catch EX As Exception
        '    MsgBox(EX.Message)
        'End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        '      Try
        Dim whr As String = ""
        Dim cn2 As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=hpdi;Integrated Security=False;UID=sa;PWD=12345")
        If cn2.State = ConnectionState.Closed Then cn2.Open()
        Dim str As String = "select distinct pricelist from hpcommon..dlist"
        Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand(str, cn2)
        Dim dr1 As SqlClient.SqlDataReader = cmd1.ExecuteReader

        If dr1.HasRows Then

            Dim db As String = "LIS-HPDIAG" ' & Trim(txtOdbc.Text)
            Dim cn As New OdbcConnection("DSN=" & db & ";Uid=HCLAB;Pwd=HCLAB;")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim cmd As OdbcCommand
            Dim dr As OdbcDataReader
            Dim i As Integer = 0
            Dim ii As Integer = 0

            While dr1.Read
                On Error Resume Next
                str = "select * from hfresource where resource_code='" & dr1(0) & "'"
                cmd = New Odbc.OdbcCommand(str, cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        If ii = 0 Then
                            dList.Columns.Add("ln", "#")
                            dList.Columns("ln").Width = 30
                            For i = 0 To dr.FieldCount - 1
                                dList.Columns.Add(dr.GetName(i), dr.GetName(i))
                            Next
                        End If

                        For i = 0 To dr.FieldCount - 1
                            dList(i + 1, ii).Value = (dr(i))
                        Next
                        dList.Rows.Add()
                        dList("ln", ii).Value = ii + 1
                        For i = 0 To dr.FieldCount - 1
                            dList(i + 1, ii).Value = (dr(i))
                        Next
                        ii += 1
                        Me.Refresh()

                    End While

                End If
                dr.Close()

            End While
        End If



        'Dim db As String = "LIS-HPDIAG" ' & Trim(txtOdbc.Text)
        'Dim cn As New OdbcConnection("DSN=" & db & ";Uid=HCLAB;Pwd=HCLAB;")
        'If cn.State = ConnectionState.Closed Then cn.Open()
        'str = "select * from hfresource where resource_code in (" & whr & ")"
        'Dim cmd As OdbcCommand = New Odbc.OdbcCommand(str, cn)
        'Dim dr As OdbcDataReader = cmd.ExecuteReader
        'Dim i As Integer = 0
        'Dim ii As Integer = 0
        ''   dlist.Columns.Clear()
        'dList.Rows.Clear()
        'If dr.HasRows Then
        '    ' MsgBox("Connected")
        '    dList.Columns.Add("ln", "#")
        '    dList.Columns("ln").Width = 30
        '    For i = 0 To dr.FieldCount - 1
        '        dList.Columns.Add(dr.GetName(i), dr.GetName(i))
        '    Next
        '    'dlist.Columns.Add("imh_code", "imh_code")
        '    'dlist.Columns.Add("imh_Desc", "imh_Desc")
        '    i = 0
        '    While dr.Read
        '        dList.Rows.Add()
        '        dList("ln", ii).Value = ii + 1
        '        For i = 0 To dr.FieldCount - 1
        '            'dList.Columns.Add(dr.GetName(i), dr.GetName(i))
        '            dList(i + 1, ii).Value = (dr(i))
        '        Next
        '        '   dList(3, i).Value = whs
        '        ii += 1
        '        Me.Refresh()
        '    End While
        '    MsgBox("Loading Done...")
        'End If
        'Catch EX As Exception
        '    MsgBox(EX.Message)
        'End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        If DLIST.Rows.Count = 0 Then MsgBox("No Records") : Exit Sub
        Dim x As Integer = 0
        Dim row As Integer = 1
        Dim i As Integer = 0
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xltx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets(1)
        xlApp.Visible = True
        For i = 0 To DLIST.Columns.Count - 1
            xlWS.Cells(row, i + 1) = DLIST.Columns(i).HeaderText
        Next
        row += 1
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

        xlWS.Range("A:" & GetCol(i)).Font.Size = 9
        xlWS.Range("A:" & GetCol(i)).Font.Name = "Calibri"
        xlWS.Range("F:" & GetCol(i)).Style = "Comma"
        xlWS.Range("F:" & GetCol(i)).NumberFormat = "0.00"
        xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
        xlWS.Range("A1").Font.Size = 12
        ' xlWS.Range("A:A").Font.Bold = True
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
End Class
