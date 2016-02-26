Imports System.Data.SqlClient
Public Class frmThongtinAccount
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Private Sub frmThongtinAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As SqlDataAdapter = New SqlDataAdapter("select USERNAME,TEN,EMAIL,SDT from TaiKhoan where USERNAME = '" & frmlogin.txtuser.Text & "'", connect)
        Dim db As DataTable = New DataTable
        connect.Open()
        query.Fill(db)
        dgvAccount.DataSource = db.DefaultView
        If db.Rows.Count > 0 Then
            txtuser.Text = dgvAccount.Item(0, 0).Value
            txtten.Text = dgvAccount.Item(1, 0).Value
            txtemail.Text = dgvAccount.Item(2, 0).Value
            txtsdt.Text = dgvAccount.Item(3, 0).Value
        End If
    End Sub

    Private Sub dgvAccount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtemail.ReadOnly = False
        txtsdt.ReadOnly = False
        txtten.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim capnhat As String = "update TaiKhoan set TEN = @TEN,SDT =@SDT, EMAIL =@EMAIL where USERNAME = '" & txtuser.Text & "'"
        Dim query As SqlCommand = New SqlCommand(capnhat, connect)
        connect.Open()
        Try
            If txtten.Text = "" Then
                MessageBox.Show("Bạn chưa điền họ tên vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtsdt.Text = "" Then
                    MessageBox.Show("Bạn chưa điền SĐT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtemail.Text = "" Then
                        MessageBox.Show("Bạn chưa điền email vào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        query.Parameters.AddWithValue("@TEN", txtten.Text)
                        query.Parameters.AddWithValue("@SDT", txtsdt.Text)
                        query.Parameters.AddWithValue("@EMAIL", txtemail.Text)
                        query.ExecuteNonQuery()
                        MsgBox("Cập nhật thành công")
                        txtten.ReadOnly = True
                        txtemail.ReadOnly = True
                        txtsdt.ReadOnly = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class