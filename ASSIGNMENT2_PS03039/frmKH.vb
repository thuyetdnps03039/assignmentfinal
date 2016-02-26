Imports System.Data.SqlClient
Imports System.Data
Public Class frmKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHHANG where MAKH = '" & txtMAKH.Text & "' or TENKH = N'" & txttenkh.Text & "'", connect)
        Dim db As DataTable = New DataTable
        connect.Open()
        probarkh.Value = 0
        Timer1.Start()

        Try
            If txtMAKH.Text = "" And txttenkh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập thông tin để tìm kiếm", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                query.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemkh.DataSource = db.DefaultView
                    connect.Close()
                Else
                    MessageBox.Show("Mã khách hàng hoặc tên khách hàng không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        probarkh.Value = 0
        Timer1.Start()
        Dim hienthi As New Class1
        dgvXemkh.DataSource = hienthi.Loadkhachang.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub dgvXemkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemkh.CellContentClick

    End Sub
    Private Sub txtMAKH_TextChanged(sender As Object, e As EventArgs) Handles txtMAKH.TextChanged

    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sttkh.Text = "Sẵn sàng !"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        probarkh.Increment(1)
        If probarkh.Value = 25 Or probarkh.Value = 50 Or probarkh.Value = 75 Then
            sttkh.Text = "Đang tìm!"
        End If
        If probarkh.Value = probarkh.Maximum Then
            sttkh.Text = "Hoàn tất!"
            Timer1.Stop()
        End If
    End Sub
End Class