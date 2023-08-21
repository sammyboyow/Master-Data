Imports Microsoft.Office.Interop
Imports System.Data.SqlClient

Public Class frmMstrDoc
    Sub Egrid()
        DgridDoc.Columns("ClmHosp").HeaderText = "Hospital Name"
        DgridDoc.Columns("ClmHospLoc").Visible = True
        DgridDoc.Columns("ClmAddr").Visible = True
        DgridDoc.Columns("ClmSched").Visible = True
        DgridDoc.Columns("ClmSlpCode").Visible = True
        DgridDoc.Columns("CLmSlpName").Visible = True
        DgridDoc.Columns("ClmSpclization").Visible = True
        DgridDoc.Columns("ClmAcct").Visible = True
        DgridDoc.Columns("ClmBdate").Visible = True
        DgridDoc.Columns("ClmTel").Visible = True
        DgridDoc.Columns("ClmEmail").Visible = True
        DgridDoc.Columns("ClmRmarks").Visible = True
    End Sub

    Sub Dgrid()
        DgridDoc.Columns("ClmHosp").HeaderText = "Branch Code"
        DgridDoc.Columns("ClmHospLoc").Visible = False
        DgridDoc.Columns("ClmAddr").Visible = False
        DgridDoc.Columns("ClmSched").Visible = False
        DgridDoc.Columns("ClmSlpCode").Visible = False
        DgridDoc.Columns("CLmSlpName").Visible = False
        DgridDoc.Columns("ClmSpclization").Visible = False
        DgridDoc.Columns("ClmAcct").Visible = False
        DgridDoc.Columns("ClmBdate").Visible = False
        DgridDoc.Columns("ClmTel").Visible = False
        DgridDoc.Columns("ClmEmail").Visible = False
        DgridDoc.Columns("ClmRmarks").Visible = False
    End Sub
    Sub iEdit()
        iDCode = (DgridDoc("ClmDCode", DgridDoc.CurrentRow.Index).Value)
        frmDoctors.txtDocCode.Enabled = False
        frmDoctors.FindDocCode()
        frmDoctors.ShowDialog()
    End Sub

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

    Private Function chkImport(ByVal code As String) As String
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = ""
        str = "SElect top 1 SLPCODE from hpcommoN..odrs where Dcode='" & code & "'"
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

    Sub FindDoc()
        Try
            Dim iGreater As String = ""

            DgridDoc.Columns("ClmCurr").Visible = False
            CmdProcess.Enabled = False
            lblPrces.Text = "------"

            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = ""

            If txtDocName.Text <> "" Then str = "and DName like '" & txtDocName.Text & "%' "
            If txtHospName.Text <> "" Then str = "and Hosp like '" & txtHospName.Text & "%' "
            If txtAddr.Text <> "" Then str = "and add1 like '" & txtAddr.Text & "%' "
            If txtSlpCode.Text <> "" Then str = "and SlpCode like '" & txtSlpCode.Text & "%' "

            str = "Select isnull(SlpCode,'')sp,* from ODRS where DCode like '" & txtDocCode.Text & "%' " & str & "order by dcode"
            Dim cmd As SqlCommand = New SqlCommand(str, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            Dim i As Integer = 0

            Dim cn2 As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn2.State = ConnectionState.Closed Then cn2.Open()
            Dim str2 As String = ""

            'select * from LisDoc
            DgridDoc.Rows.Clear()

            If dr.HasRows Then
                While dr.Read
                    DgridDoc.Rows.Add()

                    DgridDoc("ClmDCode", i).Value = dr("DCode")
                    DgridDoc("ClmDName", i).Value = dr("DName")
                    DgridDoc("ClmHosp", i).Value = dr("Hosp")
                    DgridDoc("ClmHospLoc", i).Value = dr("U_Location")
                    DgridDoc("ClmAddr", i).Value = dr("Add1")
                    DgridDoc("ClmSched", i).Value = dr("Sched")
                    DgridDoc("ClmSlpCode", i).Value = dr("sp")
                    DgridDoc("CLmSlpName", i).Value = LoadSlpName(dr("sp"))
                    DgridDoc("ClmSpclization", i).Value = dr("Specialization")
                    DgridDoc("ClmAcct", i).Value = dr("AcctNo")
                    If dr("Bdate") Is DBNull.Value = True Then DgridDoc("ClmBdate", i).Value = "" Else DgridDoc("ClmBdate", i).Value = Format(dr("Bdate"), "MM/dd/yyyy")
                    DgridDoc("ClmTel", i).Value = dr("Phone1")
                    DgridDoc("ClmEmail", i).Value = dr("Email")
                    DgridDoc("ClmRmarks", i).Value = dr("Remarks")

                    Egrid()

                    i += 1

                    If iGreater <> "true" Then
                        If DgridDoc.RowCount > 100 Then
                            If MsgBox("Records is Greater than 1000, Load all Data?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                CmdEdit.Enabled = True
                                CmdDelete.Enabled = True
                                Exit Sub
                            Else
                                iGreater = "true"
                            End If
                        End If
                    End If

                End While
                CmdEdit.Enabled = True
                CmdDelete.Enabled = True

            Else
                If MsgBox("No Doctor Found. Get Doctor to Other Branchs", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If txtDocName.Text <> "" Then str = "and Name like '" & txtDocName.Text & "%' " 'group by Code"
                    str2 = "Select * from LisDoc where Code like '" & txtDocCode.Text & "%' " & str '& "order by Code" 'max(Name)
                    Dim cmd2 As SqlCommand = New SqlCommand(str2, cn2)
                    Dim dr2 As SqlDataReader = cmd2.ExecuteReader


                    If dr2.HasRows Then

                        While dr2.Read
                            DgridDoc.Rows.Add()
                            DgridDoc("ClmDCode", i).Value = dr2("Code")
                            DgridDoc("ClmDName", i).Value = dr2("Name")
                            DgridDoc("ClmHosp", i).Value = dr2("Brnch")

                            Dgrid()

                            i += 1
                        End While

                        CmdEdit.Enabled = False
                        CmdDelete.Enabled = False
                    Else
                        MsgBox("No Data Found")
                    End If
                End If
            End If

            cn.Close()

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub txtDocCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocCode.KeyDown, txtDocName.KeyDown, txtHospName.KeyDown, txtAddr.KeyDown, txtSlpCode.KeyDown
        If e.KeyCode = Keys.Return Then
            FindDoc()
        End If
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        frmDoctors.CmdAdd.Text = "Save"
        frmDoctors.ShowDialog()
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        If DgridDoc.RowCount <> 0 Then iEdit()
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If DgridDoc.RowCount <> 0 Then
            If MsgBox("Are you sure you want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    iDCode = (DgridDoc("ClmDCode", DgridDoc.CurrentRow.Index).Value)

                    Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    Dim str As String = "Delete from ODRS where DCode = '" & iDCode & "'"
                    Dim cmd As SqlCommand = New SqlCommand(str, cn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted")

                Catch EX As Exception
                    MsgBox(EX.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdLoadExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoadExcel.Click
        lblPrces.Text = "------"
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        xlWS.Activate()

        xlWS.Cells.ClearContents()

        xlApp.Visible = True

        xlWS.Cells(1, 1).Value = "Dcode"
        xlWS.Cells(1, 2).Value = "DName"
        xlWS.Cells(1, 3).Value = "Hosp"
        xlWS.Cells(1, 4).Value = "U_Location"
        xlWS.Cells(1, 5).Value = "Add1"
        xlWS.Cells(1, 6).Value = "Sched"
        xlWS.Cells(1, 7).Value = "SlpCode"
        xlWS.Cells(1, 8).Value = "Specialization"
        xlWS.Cells(1, 9).Value = "AcctNo"
        xlWS.Cells(1, 10).Value = "BDate"
        xlWS.Cells(1, 11).Value = "Phone1"
        xlWS.Cells(1, 12).Value = "Email"
        xlWS.Cells(1, 13).Value = "Remarks"


        xlApp.ActiveWorkbook.Save()

    End Sub

    Private Sub CmdImnport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdImnport.Click
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
        Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
        Dim i As Integer = 0
        Dim ii As Integer = 0
        DgridDoc.Rows.Clear()
        Dim str As String

        DgridDoc.Columns("CLmCurr").Visible = True
        Egrid()

        CmdProcess.Enabled = True

        If DgridDoc.Rows.Count = 0 Then
            CmdProcess.Enabled = True
        End If

        For i = 2 To xlWS.Rows.Count - 1
            If CStr(xlWS.Cells(i, 1).value) = "" Then Exit For
            DgridDoc.Rows.Add()

            DgridDoc("CLmDcode", ii).Value = xlWS.Cells(i, 1).Value
            DgridDoc("CLmDname", ii).Value = xlWS.Cells(i, 2).Value
            DgridDoc("CLmHosp", ii).Value = xlWS.Cells(i, 3).Value
            DgridDoc("CLmHospLoc", ii).Value = xlWS.Cells(i, 4).Value
            DgridDoc("CLmAddr", ii).Value = xlWS.Cells(i, 5).Value
            DgridDoc("CLmSched", ii).Value = xlWS.Cells(i, 6).Value
            DgridDoc("CLmSlpCode", ii).Value = xlWS.Cells(i, 7).Value
            DgridDoc("ClmSpclization", ii).Value = xlWS.Cells(i, 8).Value
            DgridDoc("ClmAcct", ii).Value = xlWS.Cells(i, 9).Value
            DgridDoc("ClmBdate", ii).Value = Format(xlWS.Cells(i, 10).Value, "MM/dd/yyyy")
            DgridDoc("ClmTel", ii).Value = xlWS.Cells(i, 11).Value
            DgridDoc("ClmEmail", ii).Value = xlWS.Cells(i, 12).Value
            DgridDoc("CLmRmarks", ii).Value = xlWS.Cells(i, 13).Value

            str = chkImport(Trim(xlWS.Cells(i, 1).value))

            If str <> "" Then DgridDoc.Rows(ii).DefaultCellStyle.BackColor = Color.Yellow
            DgridDoc("ClmCurr", ii).Value = str
            str = LoadSlpName(xlWS.Cells(i, 7).value)

            If str = "" Then DgridDoc.Rows(ii).Cells("CLmSlpcode").Style.BackColor = Color.Red : DgridDoc("CLmtag", ii).Value = "F"
            DgridDoc("CLmSlpName", ii).Value = LoadSlpName(xlWS.Cells(i, 3).value)

            ii += 1

            lblPrces.Text = "Importing : " & xlWS.Cells(i, 1).value & " - " & xlWS.Cells(i, 2).value

            Me.Refresh()
        Next

        lblPrces.Text = "Done : Total Import : " & ii
        MsgBox("Done...")

        xlWB.Close(Application.StartupPath + "\Book1.xlsx")
        xlApp.DisplayAlerts = False
        xlApp.Quit()

        xlWS = Nothing
        xlWB = Nothing
        xlApp = Nothing
        If DgridDoc.Rows.Count = 0 Then MsgBox("No Records Found")

    End Sub

    Private Sub frmMstrDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    oCompany = New SAPbobsCOM.Company
        '    oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
        '    oCompany.Server = "SAP-PRODSVRx"
        '    oCompany.DbUserName = "sa"
        '    oCompany.DbPassword = "12345"
        '    oCompany.UserName = "manager"
        '    oCompany.Password = "12345"
        '    oCompany.CompanyDB = "HPDI"

        '    If oCompany.Connected = True Then
        '        oCompany.Disconnect()
        '    End If
        '    LRet = oCompany.Connect
        '    If LRet Then
        '        MsgBox(oCompany.GetLastErrorDescription)
        '        End
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    End
        'End Try
    End Sub

    Private Sub DgridDoc_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgridDoc.MouseDoubleClick
        If DgridDoc.RowCount <> 0 Then
            iEdit()
        End If
    End Sub

    Private Sub CmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProcess.Click
        Try
            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = ""
            Dim iSave As String = 0
            Dim iUpdate As String = 0

            Dim i As Integer = 0

            If DgridDoc.Rows.Count <> 0 Then

                For i = 0 To DgridDoc.Rows.Count - 1

                    iDCode = (DgridDoc("ClmDCode", i).Value)

                    If DgridDoc("ClmTag", i).Value <> "F" Then
                        str = "Select * from ODRS where DCode = '" & iDCode & "'"
                        Dim cmd As SqlCommand = New SqlCommand(str, cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader

                        If dr.HasRows Then
                            str = "UPDATE ODRS SET DName = '" & DgridDoc("ClmDName", i).Value & "', " _
                                            & " Hosp = '" & DgridDoc("CLmHosp", i).Value & "', " _
                                            & " U_Location = '" & DgridDoc("CLmHospLoc", i).Value & "', " _
                                            & " Add1 = '" & DgridDoc("CLmAddr", i).Value & "', " _
                                            & " Sched = '" & DgridDoc("CLmSched", i).Value & "', " _
                                            & " SlpCode = '" & DgridDoc("CLmSlpCode", i).Value & "', " _
                                            & " Specialization = '" & DgridDoc("ClmSpclization", i).Value & "', " _
                                            & " AcctNo = '" & DgridDoc("ClmAcct", i).Value & "', " _
                                            & " BDate = '" & DgridDoc("ClmBdate", i).Value & "', " _
                                            & " Phone1 = '" & DgridDoc("ClmTel", i).Value & "', " _
                                            & " Email = '" & DgridDoc("ClmEmail", i).Value & "', " _
                                            & " Remarks = '" & DgridDoc("CLmRmarks", i).Value & "', " _
                                            & " Createdate = '" & Format(Now, "MM/dd/yyyy") & "'" _
                                            & " where DCode = '" & iDCode & "';"

                            iUpdate += 1

                        Else

                            str = "insert into ODRS (Dcode,DName,Hosp,U_Location,Add1,Sched,SlpCode,Specialization,AcctNo,BDate,Phone1,Email,Remarks,Createdate) values " _
                                            & " ('" & DgridDoc("ClmDCode", i).Value & "', " _
                                            & " '" & DgridDoc("ClmDName", i).Value & "', " _
                                            & " '" & DgridDoc("CLmHosp", i).Value & "', " _
                                            & " '" & DgridDoc("CLmHospLoc", i).Value & "', " _
                                            & " '" & DgridDoc("CLmAddr", i).Value & "', " _
                                            & " '" & DgridDoc("CLmSched", i).Value & "', " _
                                            & " '" & DgridDoc("CLmSlpCode", i).Value & "', " _
                                            & " '" & DgridDoc("ClmSpclization", i).Value & "', " _
                                            & " '" & DgridDoc("ClmAcct", i).Value & "', " _
                                            & " '" & DgridDoc("ClmBdate", i).Value & "', " _
                                            & " '" & DgridDoc("ClmTel", i).Value & "', " _
                                            & " '" & DgridDoc("ClmEmail", i).Value & "', " _
                                            & " '" & DgridDoc("CLmRmarks", i).Value & "', " _
                                            & " '" & Format(Now, "MM/dd/yyyy") & "')"

                            iSave += 1
                        End If

                        dr.Close()
                        cmd = New SqlCommand(str, cn)
                        cmd.ExecuteNonQuery()
                    End If

                    lblPrces.Text = "(Save Count : " & iSave & ") (Update Count : " & iUpdate & ")  " & DgridDoc("ClmDCode", i).Value & " - " & DgridDoc("ClmDName", i).Value

                    Me.Refresh()

                Next i

                lblPrces.Text = "Done: Total Process = " & i & " (Save Count = " & iSave & ") (Update Count = " & iUpdate & ")"
                MsgBox("Done...")
                CmdProcess.Enabled = False
                'DgridDoc.Rows.Clear()
            Else
                MsgBox("No Rows")
            End If

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub CmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoad.Click
        frmLoadPck.ShowDialog()
    End Sub

    Private Sub CmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExportExcel.Click
        Try
            If DgridDoc.RowCount <> 0 Then
                Dim row As Integer = 1
                Dim xlApp As Excel.Application = New Excel.Application
                Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
                Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Doctor")
                xlApp.Visible = True
                Dim i As Integer
                For i = 0 To DgridDoc.Columns.Count - 1
                    xlWS.Cells(row, i + 1) = DgridDoc.Columns(i).HeaderText
                Next
                xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
                row += 1
                Dim x As Integer = 0
                For x = 0 To DgridDoc.Rows.Count - 1
                    For i = 0 To DgridDoc.Columns.Count - 1

                        If i = 0 Then
                            xlWS.Cells(row, i + 1).Value = DgridDoc(i, x).Value
                        Else
                            xlWS.Cells(row, i + 1) = DgridDoc(i, x).Value
                        End If
                    Next
                    row += 1
                Next
                xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
                xlWS.Range("a2").Select()
                xlWS.Application.ActiveWindow.FreezePanes = True
                MsgBox("Export Done...")
            End If

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

    Private Sub txtDocCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocCode.TextChanged

    End Sub
End Class