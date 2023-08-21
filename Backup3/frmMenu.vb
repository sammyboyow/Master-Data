Public Class frmMenu

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmMaster.ShowDialog()
    End Sub

    Private Sub btnPack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPack.Click
        frmPackage.ShowDialog()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oCompany = New SAPbobsCOM.Company
            oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008
            oCompany.Server = "SAP-PRODSVRx"
            oCompany.DbUserName = "sa"
            oCompany.DbPassword = "12345"
            oCompany.UserName = "manager"
            oCompany.Password = "12345"
            oCompany.CompanyDB = "HPDI"
            If oCompany.Connected = True Then
                oCompany.Disconnect()
            End If
            LRet = oCompany.Connect
            If LRet Then
                MsgBox(oCompany.GetLastErrorDescription)
                End
            End If
            ' LoadCycle()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub
    Private Sub LoadCycle()
        Dim rs As SAPbobsCOM.Recordset
        rs = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        Dim str As String = "SElect TOP 1 * from  [@FT_OCCS]"
        rs.DoQuery(str)

        If rs.EoF = False Then
            While Not rs.EoF
                MsgBox(rs.Fields.Item(0).Value())
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub btnDoct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoct.Click
        frmMstrDoc.ShowDialog()
    End Sub

    Private Sub btnUpTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpTran.Click
        frmUpTran.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMstrCust.ShowDialog()
    End Sub
End Class