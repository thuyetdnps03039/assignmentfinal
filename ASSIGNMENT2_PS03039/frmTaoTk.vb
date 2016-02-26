Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Text.RegularExpressions
Public Class frmtaotk
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into TaiKhoan values (@USERNAME,@PWD,@TEN,@EMAIL,@SDT)"
        Dim themvao As SqlCommand = New SqlCommand(query, connect)
        connect.Open()
        Try
            If txtten.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtuser.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtpwd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mật khẩu", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If txtpwdagain.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập lai mật khẩu", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If txtemail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                If KiemTraEmail(txtemail.Text) = False Then
                                    MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    If txtsdt.Text = "" Then
                                        MessageBox.Show("Bạn chưa nhập SĐT", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Else
                                        If txtpwd.Text <> txtpwdagain.Text Then
                                            MessageBox.Show("Mật khẩu không trùng khớp, mời bạn nhập lại", "Thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Else
                                            themvao.Parameters.AddWithValue("@USERNAME", txtuser.Text)
                                            themvao.Parameters.AddWithValue("@PWD", txtpwd.Text)
                                            themvao.Parameters.AddWithValue("@TEN", txtten.Text)
                                            themvao.Parameters.AddWithValue("@EMAIL", txtemail.Text)
                                            themvao.Parameters.AddWithValue("@SDT", txtsdt.Text)
                                            themvao.ExecuteNonQuery()
                                            MsgBox("Đăng ký thành công")
                                            txtuser.Text = Nothing
                                            txtpwd.Text = Nothing
                                            txtpwdagain.Text = Nothing
                                            txtten.Text = Nothing
                                            txtemail.Text = Nothing
                                            txtsdt.Text = Nothing
                                            pbcheckx.Image = Nothing
                                            pbemail.Image = Nothing
                                            pbpwd.Image = Nothing
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Tài khoản đã có người sử dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        connect.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Hide()
        frmlogin.Show()
    End Sub
    Private Sub frmtaotk_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As DataTable = New DataTable
        Dim timuser As SqlDataAdapter = New SqlDataAdapter("select USERNAME from TaiKhoan where USERNAME = '" & txtuser.Text & "'", connect)
        connect.Open()
        Try
            db.Clear()
            timuser.Fill(db)
            If txtuser.Text = "" Then
                pbcheckx.Visible = True
                pbcheckx.Image = My.Resources.x
                btncheck.Visible = False
            Else
                If db.Rows.Count > 0 Then
                    pbcheckx.Visible = True
                    pbcheckx.Image = My.Resources.x
                    btncheck.Visible = False
                Else
                    pbcheckx.Visible = True
                    pbcheckx.Image = My.Resources.check
                    btncheck.Visible = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        btncheck.Visible = True
        pbcheckx.Visible = False
    End Sub

    Private Sub txtpwdagain_TextChanged(sender As Object, e As EventArgs) Handles txtpwdagain.TextChanged
        If txtpwd.Text <> txtpwdagain.Text Then
            pbpwd.Visible = True
            pbpwd.Image = My.Resources.x
        Else
            pbpwd.Visible = True
            pbpwd.Image = My.Resources.check
        End If
    End Sub

    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        If txtpwd.Text <> txtpwdagain.Text Then
            pbpwd.Visible = True
            pbpwd.Image = My.Resources.x
        Else
            pbpwd.Visible = True
            pbpwd.Image = My.Resources.check
        End If
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged
        If KiemTraEmail(txtemail.Text) = True Then
            pbemail.Visible = True
            pbemail.Image = My.Resources.check
        Else
            pbemail.Visible = True
            pbemail.Image = My.Resources.x
        End If
    End Sub
    Function KiemTraEmail(ByVal DiaChiEmail As String) As Boolean
        Dim chuoikiemtra As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim EmailMatch As Match = Regex.Match(DiaChiEmail, chuoikiemtra)
        If EmailMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmtaotk_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btncreate
    End Sub
End Class