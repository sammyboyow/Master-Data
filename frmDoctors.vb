Imports System.Data.SqlClient

Public Class frmDoctors
    Sub Clrtxt()

        txtDocCode.Enabled = True
        txtDocCode.Text = ""
        txtDocname.Text = ""
        txtHospName.Text = ""
        txtHospLoc.Text = ""
        txtAddr.Text = ""
        txtSched.Text = ""
        txtSlpCode.Text = ""
        txtSpcliz.Text = ""
        txtAccnt.Text = ""
        DpBdate.Value = Format(Now, "MM/dd/yyyy")
        txtTel.Text = ""
        txtEmail.Text = ""
        txtRmarks.Text = ""
    End Sub

    Sub iCmdadd()
        If txtDocCode.Text <> "" And txtDocname.Text <> "" And txtSlpCode.Text <> "" Then CmdAdd.Enabled = True Else CmdAdd.Enabled = False
        'CmdAdd.Enabled = True
        'Else
        'CmdAdd.Enabled = False
        'End If
    End Sub

    Sub iCodeChck()
        If CmdAdd.Text = "Save" Then
            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = "select top 1 DCode from odrs where DCode ='" & txtDocCode.Text & "'"
            Dim cmd As SqlCommand = New SqlCommand(str, cn)
            str = cmd.ExecuteScalar()

            If str Is Nothing Then
                SaveUpdate()
            Else
                MsgBox("Code Is in Used, Replace Code")
                txtDocCode.Text = ""
            End If
            cn.Close()
        End If
    End Sub

    Sub SaveUpdate()
        Try
            Dim i As String
            Dim str As String = ""
            Dim cmd As SqlCommand
            i = Format(Now, "MM/dd/yyyy")

            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()

            If CmdAdd.Text = "Save" Then

                str = "Insert into ODRS(Dcode,DName,Hosp,U_Location,Add1,Sched,SlpCode,Specialization,AcctNo,BDate,Phone1,Email,Remarks,Createdate) values " _
                                & " ('" & txtDocCode.Text & "', " _
                                & " '" & txtDocname.Text & "', " _
                                & " '" & txtHospName.Text & "', " _
                                & " '" & txtHospLoc.Text & "', " _
                                & " '" & txtAddr.Text & "', " _
                                & " '" & txtSched.Text & "', " _
                                & " '" & txtSlpCode.Text & "', " _
                                & " '" & txtSpcliz.Text & "', " _
                                & " '" & txtAccnt.Text & "', " _
                                & " '" & Format(DpBdate.Value, "MM/dd/yyyy") & "', " _
                                & " '" & txtTel.Text & "', " _
                                & " '" & txtEmail.Text & "'," _
                                & " '" & txtRmarks.Text & "', " _
                                & " '" & i & "')"

                MsgBox("Data Save")
                Clrtxt()

            ElseIf CmdAdd.Text = "Update" Then

                str = "UPDATE ODRS SET DName ='" & txtDocname.Text & "', " _
                                & " Hosp = '" & txtHospName.Text & "', " _
                                & " U_Location = '" & txtHospLoc.Text & "', " _
                                & " SlpCode = '" & txtSlpCode.Text & "', " _
                                & " Add1 = '" & txtAddr.Text & "', " _
                                & " Sched = '" & txtSched.Text & "', " _
                                & " Specialization = '" & txtSpcliz.Text & "', " _
                                & " AcctNo = '" & txtAccnt.Text & "', " _
                                & " BDate = '" & Format(DpBdate.Value, "MM/dd/yyyy") & "', " _
                                & " Phone1 = '" & txtTel.Text & "', " _
                                & " Email = '" & txtEmail.Text & "', " _
                                & " Remarks = '" & txtRmarks.Text & "', " _
                                & " Createdate = '" & i & "' " _
                                & " where DCode = '" & txtDocCode.Text & "';"

                MsgBox("Data Updated")
                CmdAdd.Text = "Save"
                Clrtxt()

            End If

            cmd = New SqlCommand(str, cn)
            cmd.ExecuteNonQuery()
            cn.Close()

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Public Sub FindDocCode()
        Try
            Dim cn As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn.State = ConnectionState.Closed Then cn.Open()
            Dim str As String = "Select isnull(Remarks,'')RM, " _
                                        & " isnull(Phone1,'')Phno, " _
                                        & " isnull(Specialization,'')Spcliztion, " _
                                        & " isnull(Add1,'')Addr, " _
                                        & " isnull(Email,'')Eml, " _
                                        & " isnull(Hosp,'')Hspt, " _
                                        & " isnull(U_Location,'')Loc, " _
                                        & " isnull(Sched,'')Schd, " _
                                        & " isnull(AcctNo,'')Actno, " _
                                        & " isnull(Bdate,'')Bdy, " _
                                        & " * from ODRS where DCode = '" & iDCode & "'"
            Dim cmd As SqlCommand = New SqlCommand(str, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader

            Dim cn2 As New SqlConnection("Data Source=sap-prodsvrx;Initial Catalog=HPCommon;Integrated Security=False;UID=sa;PWD=12345")
            If cn2.State = ConnectionState.Closed Then cn2.Open()
            Dim str2 As String = ""

            If dr.HasRows Then
                While dr.Read
                    txtDocCode.Text = dr("DCode")
                    txtDocname.Text = dr("Dname")
                    txtSlpCode.Text = dr("SlpCode")
                    txtRmarks.Text = dr("RM") ' dr("Remarks")
                    txtTel.Text = dr("Phno") 'dr("Phone1")
                    txtSpcliz.Text = dr("Spcliztion") 'dr("Specialization")
                    txtAddr.Text = dr("Addr") ' dr("Add1")
                    txtEmail.Text = dr("Eml") 'dr("Email")
                    txtHospName.Text = dr("Hspt") 'dr("Hosp")
                    txtHospLoc.Text = dr("Loc") 'dr("U_Location")
                    txtSched.Text = dr("Schd") 'dr("Sched")
                    DpBdate.Text = dr("Bdy")
                    txtAccnt.Text = dr("Actno") 'dr("AcctNo")
                End While

                CmdAdd.Text = "Update"

            Else
                str2 = "Select * from LisDoc where Code = '" & iDCode & "'"
                Dim cmd2 As SqlCommand = New SqlCommand(str2, cn2)
                Dim dr2 As SqlDataReader = cmd2.ExecuteReader

                If dr2.HasRows Then
                    While dr2.Read
                        txtDocCode.Text = dr2("Code")
                        txtDocname.Text = dr2("name")
                    End While
                End If

                CmdAdd.Text = "Save"
            End If
            cn.Close()

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub txtDocCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDocCode.LostFocus
        iDCode = txtDocCode.Text
        FindDocCode()
    End Sub

    Private Sub txtDocCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocCode.TextChanged
        iCmdadd()
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        If CmdAdd.Text = "Save" Then
            iCodeChck()
        ElseIf CmdAdd.Text = "Update" Then
            SaveUpdate()
        End If
    End Sub

    Private Sub CmdFindSlp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFindSlp.Click
        frmFindSlp.ShowDialog()
    End Sub

    Private Sub txtDocname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocname.TextChanged
        iCmdadd()
    End Sub

    Private Sub txtSlpCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSlpCode.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) Then e.Handled = True
        If (e.KeyChar < Chr(97) Or e.KeyChar > Chr(122)) Then e.Handled = True
    End Sub

    Private Sub txtSlpCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSlpCode.TextChanged
        iCmdadd()
    End Sub

    Private Sub frmDoctors_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Clrtxt()
    End Sub
End Class
