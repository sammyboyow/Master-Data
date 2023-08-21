Imports System.Data.SqlClient
Public Class frmFind

    Private Sub frmPoSrch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPO()
        dList.Focus()
    End Sub
    Private Sub LoadPO()
        Try
            Dim cn As New SqlConnection("Data Source=SAP-PRODSVRx;Initial Catalog=" & Db & ";Integrated Security=False;UID=SA;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = ""
            If cboList.Text = "Hospital" Then
                '     If txtPO.Text <> "" Then str = str & " and docentry like '" & txtPO.Text & "%'"
                'str = "select distinct U_Hospital,U_Location,isnull(cast(U_Address as varchar(50)),'') U_Address from [@FT_ODRS1]  where u_hospital like '" & txtPO.Text & "%'  order by U_Hospital"
                str = "select distinct Hosp,U_Location,isnull(cast(add1 as varchar(50)),'') add1 from hpcommon..odrs  where Hosp like '" & txtPO.Text & "%'  order by Hosp"
                dList.Columns("hosp").HeaderText = "Hospital"
                dList.Columns("loc").HeaderText = "Location"
                dList.Columns("add1").HeaderText = "Address"
                dList.Columns("add1").Visible = True
            Else
                str = "select slpcode,slpname FROM OSLP where slpcode like '" & txtPO.Text & "%' ORDER BY SLPCODE"
                dList.Columns("hosp").HeaderText = "SlpCode"
                dList.Columns("loc").HeaderText = "Slpname"
                dList.Columns("add1").Visible = False
            End If

            Dim cmd As SqlCommand = New SqlClient.SqlCommand(str, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            Dim i As Integer
            dList.Rows.Clear()
            If dr.HasRows Then
                While dr.Read()
                    dList.Rows.Add()
                    dList("ln", i).Value = i + 1
                    If cboList.Text = "Hospital" Then
                        dList("hosp", i).Value = dr("Hosp")
                        dList("loc", i).Value = dr("U_Location")
                        dList("add1", i).Value = dr("add1")
                    Else
                        dList("hosp", i).Value = dr("slpcode")
                        dList("loc", i).Value = dr("slpname")
                    End If

                    i += 1
                End While
            End If
            dList.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SelectItem()
        If dList.Rows.Count > 0 Then
            Dim cnt As Integer = frmDoctor.dList.CurrentRow.Index
            If cboList.Text = "Hospital" Then
                frmDoctor.dList("hosp", cnt).Value = dList("hosp", dList.CurrentRow.Index).Value
                frmDoctor.dList("loc", cnt).Value = dList("loc", dList.CurrentRow.Index).Value
            Else
                frmDoctor.dList("slpcode", cnt).Value = dList("hosp", dList.CurrentRow.Index).Value
                frmDoctor.dList("slpname", cnt).Value = dList("loc", dList.CurrentRow.Index).Value
                frmDoctor.dList("tag", cnt).Value = "T"
                frmDoctor.dList.Rows(cnt).Cells("slpcode").Style.BackColor = Color.Empty
                '("slpname", cnt).Value = dList("loc", dList.CurrentRow.Index).Value

            End If

            'frmDoctor.dList("", cnt).Value = dList("hosp", dList.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        SelectItem()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        LoadPO()
    End Sub

    Private Sub txtPO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPO.KeyDown
        If e.KeyCode = Keys.Down Then
            dList.Focus()
        End If
        If e.KeyCode = Keys.Return Then LoadPO()
    End Sub

    Private Sub txtPO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPO.LostFocus
        LoadPO()
    End Sub

    Private Sub dList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dList.KeyDown
        If e.KeyCode = Keys.Return Then SelectItem()
        If e.KeyCode > 64 And e.KeyCode < 120 Then
            txtPO.Text = Chr(e.KeyCode)
            txtPO.Focus()
            txtPO.SelectionStart = 1
        End If
    End Sub


    Private Sub dList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dList.MouseDoubleClick
        SelectItem()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Me.Visible = False
        Me.Close()
    End Sub

    Private Sub dList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dList.CellContentClick

    End Sub

    Private Sub frmPoSrch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        dList.Height = Me.Height - 100
        dList.Width = Me.Width - 30
        'dList.Columns("desc").Width = dList.Width - 200

        btnSelect.Top = Me.Height - 60
        btnClose.Top = btnSelect.Top
        btnSelect.Left = Me.Width - 160
        btnClose.Left = Me.Width - 80

    End Sub

    Private Sub cboList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboList.SelectedIndexChanged
        txtPO.Text = ""
        ' LoadPO()
    End Sub
End Class