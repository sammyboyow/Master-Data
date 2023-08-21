Imports System.Data.SqlClient

Public Class frmFindSlp
    Public iSlp As String
    Sub FindSlp()
        Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPDI;Integrated Security=False;UID=sa;PWD=12345")
        If cn.State = ConnectionState.Closed Then cn.Open()
        Dim str As String = ""

        If txtSlpName.Text <> "" Then str = "and " & "SlpName like '" & txtSlpName.Text & "%'"
        str = "Select * from oslp where SlpCode like '" & txtSlpCode.Text & "%'" & str
        Dim cmd As SqlCommand = New SqlCommand(str, cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader

        Dim i As Integer = 0

        DgridSlp.Rows.Clear()
        If dr.HasRows Then
            While dr.Read

                DgridSlp.Rows.Add()
                DgridSlp("ClmSlpCode", i).Value = dr("SlpCode")
                DgridSlp("ClmSlpName", i).Value = dr("SlpName")

                i += 1
            End While
        Else
            DgridSlp.Rows.Clear()
        End If
        cn.Close()
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub txtSlpCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSlpCode.KeyDown, txtSlpName.KeyDown
        If e.KeyCode = Keys.Return Then
            FindSlp()
        End If
    End Sub

    Private Sub DgridSlp_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgridSlp.MouseDoubleClick
        If DgridSlp.RowCount = 0 Then Exit Sub
        iSlpCode = (DgridSlp("ClmSlpCode", DgridSlp.CurrentRow.Index).Value)
        frmDoctors.txtSlpCode.Text = iSlpCode
        frmDoctors.Enabled = True
        Me.Close()
    End Sub
End Class