Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmlogin
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim connect As New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Dim sqladapter As New SqlDataAdapter("select * from TaiKhoan where USERNAME='" & txtuser.Text & "' and PASSWORD = '" & txtpwd.Text & "'", connect)
        Try
            connect.Open()
            sqladapter.Fill(db)
            If db.Rows.Count > 0 Then
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Application.Exit()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnlogin
        If My.Settings.Check = True Then
            txtuser.Text = My.Settings.Username
            txtpwd.Text = My.Settings.Password
        Else
            txtuser.Text = ""
            txtpwd.Text = ""
        End If
    End Sub
    Private Sub frmlogin_close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        If cbsavepwd.Checked = True Then
            My.Settings.Username = txtuser.Text
            My.Settings.Password = txtpwd.Text
            My.Settings.Check = True
            My.Settings.Save()
        Else
            My.Settings.Username = ""
            My.Settings.Password = ""
            My.Settings.Check = False
            My.Settings.Save()
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmtaotk.Show()
    End Sub
End Class
