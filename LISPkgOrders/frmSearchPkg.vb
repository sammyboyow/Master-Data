Imports System.Data.SqlClient
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess
Imports System.Data.Odbc
Imports System.Reflection
Public Class frmSearchPkg
    Public PkgSearch As String = ""
    Private Sub frmSearchPkg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub frmSearchPkg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
    Sub LoadTest(ByVal Keyword As String)
        Dim cnstr As String =
          "Driver={Microsoft ODBC for Oracle};Server=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST =" & GetIP(frmLISPkgMaintenance.lblWhsCode.Text) & ")(PORT = 1521)) " & _
          "(CONNECT_DATA =(SID = HCLAB)));UID=HCLAB;PWD=HCLAB"
        Dim cn As New OdbcConnection(cnstr)
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""
        Dim cmd As New OdbcCommand
        Dim dr As OdbcDataReader
        Dim i As Integer = 0
        Keyword = Keyword.ToUpper
        If PkgSearch = "PACKAGE" Then
            str = "SELECT IMH_CODE,IMH_DESC FROM ITEM_MASTERH WHERE IMH_TYPE = 'P' AND (UPPER(IMH_CODE) LIKE '%" & Keyword & "%' OR UPPER(IMH_DESC) LIKE '%" & Keyword & "%') "
        ElseIf PkgSearch = "PACKAGEBR" Then
            str = "SELECT IMH_CODE,IMH_DESC FROM ITEM_MASTERH WHERE IMH_TYPE = 'S' AND (UPPER(IMH_CODE) LIKE '%" & Keyword & "%' OR UPPER(IMH_DESC) LIKE '%" & Keyword & "%') "
        End If
        cmd = New OdbcCommand(str, cn)
        cmd.CommandTimeout = 0
        dr = cmd.ExecuteReader
        D.Rows.Clear()
        If dr.HasRows Then
            While dr.Read
                D.Rows.Add()
                D("IMH_CODE", i).Value = dr("IMH_CODE")
                D("IMH_DESC", i).Value = dr("IMH_DESC")
                i += 1
            End While
        Else
            MsgBox("Cannot find test based in keyword!")
        End If
        dr.Close()
        cmd.Dispose()
        cn.Dispose()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        LoadTest(txtTCode.Text)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If D.Rows.Count = 0 Then Exit Sub
        Dim i As Integer = D.CurrentRow.Index

        With frmLISPkgMaintenance
            If PkgSearch = "PACKAGE" Then
                .txtPkgCode.Text = D("IMH_CODE", i).Value
                .txtPkgDesc.Text = D("IMH_DESC", i).Value
                .load_packageHDR()
            ElseIf PkgSearch = "PACKAGEBR" Then
                Dim ii As Integer = frmLISPkgMaintenance.D.CurrentRow.Index
                .D("CODE", ii).Value = D("IMH_CODE", i).Value
                .D("TESTNAME", ii).Value = D("IMH_DESC", i).Value
            End If
            
        End With
        Me.Dispose()
    End Sub

    Private Sub txtTCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTCode.KeyDown
        If e.KeyCode = Keys.Return Then
            btnFind.PerformClick()
        End If
    End Sub

    Private Sub txtTCode_TextChanged(sender As Object, e As EventArgs) Handles txtTCode.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class