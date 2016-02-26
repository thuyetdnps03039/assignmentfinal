Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        probar.Value = 0
        Timer1.Start()
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim tim As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP='" & txtMASP.Text & "' or SANPHAM.TENSP = N'" & txttensp.Text & "'", connect)
        Dim db As DataTable = New DataTable
        connect.Open()
        Timer1.Start()
        probar.Value = 0
        Try
            If txtMASP.Text = "" And txttensp.Text = "" Then
                MessageBox.Show("Bạn chưa nhập thông tin về sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                tim.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                Else
                    MessageBox.Show("Mã SP hoặc Tên SP không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
        connect.Close()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        probar.Increment(1)
        If probar.Value = 25 Or probar.Value = 50 Or probar.Value = 75 Then
            stt.Text = "Đang tìm!"
        End If
        If probar.Value = probar.Maximum Then
            stt.Text = "Hoàn tất!"
            Timer1.Stop()
        End If
    End Sub
End Class