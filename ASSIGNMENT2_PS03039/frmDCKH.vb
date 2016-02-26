Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDieuchinhKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub frmDieuchinhKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DataTable
        Dim connect As New SqlConnection(chuoiketnoi)
        Dim truyvan As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL, ImageData as 'Hình ảnh' from KHACHHANG", connect)

        connect.Open()
        truyvan.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        probar.Value = 0
        Timer1.Start()
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL, ImageData as 'Hình ảnh' from KHACHHANG where MAKH=N'" & txtMaKH.Text & "'", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        probar.Value = 0
        Timer1.Start()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL,@IMAGE)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        Dim db As DataTable = New DataTable
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtAdd.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtEmail.Focus()
                        Else
                            If txtduongdanoffline.Text = "" Then
                                save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                save.Parameters.AddWithValue("@IMAGE", "")
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                conn.Close() 'đóng kết nối
                            Else
                                save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                save.Parameters.AddWithValue("@IMAGE", txtduongdanoffline.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtduongdan.Text = Nothing
                                txtduongdanoffline.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL, IMAGEDATA as 'Hình ảnh' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        probar.Value = 0
        Timer1.Start()
        Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtTenkh.Text = Nothing
                    txtAdd.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEmail.Text = Nothing
                    txtduongdan.Text = Nothing
                    txtduongdanoffline.Text = Nothing
                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL, ImageData as 'Hình ảnh' from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        probar.Value = 0
        Timer1.Start()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL, ImageData=@IMAGE where MAKH=@MAKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenkh.Focus()
                    If txtAdd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtAdd.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                If txtduongdanoffline.Text = "" Then
                                    addupdate.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                    addupdate.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                                    addupdate.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                    addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                    addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                    addupdate.Parameters.AddWithValue("@IMAGE", "")
                                    addupdate.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                Else
                                    addupdate.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
                                    addupdate.Parameters.AddWithValue("@TENKH", txtTenkh.Text)
                                    addupdate.Parameters.AddWithValue("@DIACHI", txtAdd.Text)
                                    addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                    addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                    addupdate.Parameters.AddWithValue("@IMAGE", txtduongdanoffline.Text)
                                    addupdate.ExecuteNonQuery()
                                    conn.Close() 'đóng kết nối
                                End If
                                
                                MessageBox.Show("Cập nhật thành công")
                                txtMaKH.Text = Nothing
                                txtTenkh.Text = Nothing
                                txtAdd.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtduongdan.Text = Nothing
                                txtduongdanoffline.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Try
            Dim hang As Integer = dgvKH.CurrentRow.Index
            txtMaKH.Text = dgvKH.Item(0, hang).Value
            txtTenkh.Text = dgvKH.Item(1, hang).Value
            txtAdd.Text = dgvKH.Item(2, hang).Value
            txtSDT.Text = dgvKH.Item(3, hang).Value
            txtEmail.Text = dgvKH.Item(4, hang).Value
            txtduongdan.Text = dgvKH.Item(5, hang).Value
            pbavatar.Image = Image.FromFile(txtduongdan.Text)
        Catch ex As Exception
            pbavatar.Image = Nothing
        End Try
       

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Dim browse As New OpenFileDialog
        browse.Title = "Chọn hình ảnh"
        browse.Filter = "PNG|*.png|JPEG|*.jpg;*jpeg|All files|*"
        browse.ShowDialog()
        txtduongdanoffline.Text = browse.FileName.ToString
        If txtduongdanoffline.Text = Nothing Then
            pbavatar.Image = Nothing
        Else
            pbavatar.Image = Image.FromFile(txtduongdanoffline.Text)
        End If
    End Sub

    Private Sub pbavatar_Click_1(sender As Object, e As EventArgs) Handles pbavatar.Click
        
    End Sub


    Private Sub btnnhaplai_Click(sender As Object, e As EventArgs) Handles btnnhaplai.Click
        txtAdd.Text = ""
        txtEmail.Text = ""
        txtMaKH.Text = ""
        txtSDT.Text = ""
        txtTenkh.Text = ""
        txtduongdan.Text = Nothing
        txtduongdanoffline.Text = Nothing
        pbavatar.Image = Nothing
        txtMaKH.Focus()
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