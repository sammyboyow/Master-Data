Imports System.Data.SqlClient
Public Class frmHist

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        showVendor()
    End Sub
    Private Sub showVendor()
        ' Try
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        Dim str As String = ""
        If txtname.Text <> "" Then str = str & " and o.cardname like '%" & txtname.Text & "%'"
        str = str & " and encDt between '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' and  '" & Format(dtEdate.Value, "MM/dd/yyyy") & "'"
        str = str & " and c.cat='" & cboCat.Text & "'"
        str = "select o.cardcode,o.CardName,c.* from ocrd o inner join " & DbCommon & "..custhist c on o.CardCode=c.cardcode " & _
        " where o.cardCode like '" & txtCod.Text & "%' " & str & " order by o.cardname,encDt" '" & str

        rs.DoQuery(str)
        dList.Rows.Clear()
        Dim i As Integer = 0
        While Not rs.EoF
            dList.Rows.Add()
            dList("ln", i).Value = i + 1
            dList("cardcode", i).Value = rs.Fields.Item("cardcode").Value
            dList("cname", i).Value = rs.Fields.Item("cardname").Value
            dList("dtupd", i).Value = Format(rs.Fields.Item("encDt").Value, "MM/dd/yyyy")
            dList("old", i).Value = rs.Fields.Item("prev").Value
            dList("cNew", i).Value = rs.Fields.Item("new").Value
            i += 1
            rs.MoveNext()
        End While
        dList.Focus()

        ' Catch ex As Exception
        'MsgBox(ex.Message)
        '  End Try
    End Sub


    Private Sub VendorList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCod.Text = ""
        txtname.Text = ""
        showVendor()
    End Sub



    Private Sub dList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dList.KeyDown
        
        If e.KeyCode > 64 And e.KeyCode < 120 Then
            txtname.Text = Chr(e.KeyCode)
            txtname.Focus()
            txtname.SelectionStart = 1
        End If
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCod.KeyDown, txtname.KeyDown
        If e.KeyCode = Keys.Down Then
            dList.Focus()
        End If
        If e.KeyCode = Keys.Return Then showVendor()
    End Sub

    Private Sub txtCod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCod.LostFocus, txtname.LostFocus
        showVendor()
    End Sub
End Class