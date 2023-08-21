Module Module1
    Public oCompany As SAPbobsCOM.Company
    Public oCust As SAPbobsCOM.BusinessPartners

    Public oItem As SAPbobsCOM.Items
    Public oDocuments As SAPbobsCOM.Documents
    Public oPurchaseOrders As SAPbobsCOM.Documents
    Public addvendor As Boolean = False
    Public oPurchaseInvoices As SAPbobsCOM.Documents

    Public LRet As Integer

    Public Db As String = "HPDI"
    Public DbCommon As String = "HPCommon"

    Public iDCode As String
    Public iSlpCode As String
    Public iOdbc As String
End Module
