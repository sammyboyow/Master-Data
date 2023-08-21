Imports System.Data.SqlClient
Public Class frmUpTran

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog=HPDI;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = "Update HPCOMMON..INV1 Set SLPCode = d.Slpcode from hpcommon..odrs d,HPDI..OCRD c  " & _
                            "Where c.CardCode = HPCOMMON..INV1.basecard and d.DCode = HPCOMMON..INV1.U_DoctorCode and c.GroupCode = '102' " & _
                            "and HPCOMMON..INV1.docdate between '" & Format(dtSdate.Value, "MM/dd/yyyy") & "' and '" & Format(dtEdate.Value, "MM/dd/yyyy") & "'  " & _
                            "and U_DoctorCode = '" & txtDocCode.Text & "' and U_SalesRep <> HPCOMMON..INV1.SLPCode"
        Dim cmd As SqlCommand = New SqlClient.SqlCommand(str, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Done...")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class