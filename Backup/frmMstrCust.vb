Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmMstrCust

    Sub LoadCust()
        Try
            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPDI;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()

            Dim str1 As String = ""

            If txtCardCode.Text <> "" Then str1 = "where CardCode like '" & txtCardCode.Text & "%'"
            If txtCardName.Text <> "" Then str1 = "where CardName like '" & txtCardName.Text & "%'"
            If txtSlpCode.Text <> "" Then str1 = "where o.SlpCode like '" & txtSlpCode.Text & "%'"

            Dim str As String = "select CardCode,CardName,o.SlpCode,os.SlpName,isnull([Address],'')Address, " _
                                        & " Phone1,MailAddres from  ocrd O " _
                                        & " inner join OSLP Os on o.SlpCode = os.SlpCode " & str1 & " order by CardCode"

            Dim cmd As SqlCommand = New SqlCommand(str, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            Dim i As Integer = 0

            D.Rows.Clear()
            If dr.HasRows Then
                While dr.Read
                    D.Rows.Add()
                    D("CardCode", i).Value = dr("CardCode")
                    D("CardName", i).Value = dr("CardName")
                    D("SlpCode", i).Value = dr("SlpCode")
                    D("SlpName", i).Value = Trim(dr("SlpName"))
                    D("Addr", i).Value = Trim(dr("Address"))
                    D("Phoneno", i).Value = dr("Phone1")
                    D("Email", i).Value = dr("MailAddres")

                    i += 1
                End While
            Else
                MsgBox("No Record Found")
            End If

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub txtDocCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCardCode.KeyDown, txtCardName.KeyDown, txtSlpCode.KeyDown
        If e.KeyCode = Keys.Return Then
            LoadCust()
        End If
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

    Private Sub CmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExportExcel.Click
        Try
            If D.RowCount <> 0 Then
                Dim row As Integer = 1
                Dim xlApp As Excel.Application = New Excel.Application
                Dim xlWB As Excel.Workbook = xlApp.Workbooks.Open(Application.StartupPath + "\Book1.xlsx")
                Dim xlWS As Excel.Worksheet = xlWB.Worksheets("Cust")
                xlApp.Visible = True
                Dim i As Integer
                For i = 0 To D.Columns.Count - 1
                    xlWS.Cells(row, i + 1) = D.Columns(i).HeaderText
                Next
                xlWS.Range("A:" & GetCol(i)).Columns.AutoFit()
                row += 1
                Dim x As Integer = 0
                For x = 0 To D.Rows.Count - 1
                    For i = 0 To D.Columns.Count - 1

                        If i = 0 Then
                            xlWS.Cells(row, i + 1).Value = D(i, x).Value
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
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmMstrCust_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        D.Height = Me.Height - 120
        D.Width = Me.Width - 40

        CmdClose.Top = P.Height - 35
        CmdClose.Left = P.Width - 90
        prbProcess.Width = P.Width - 200
    End Sub
End Class