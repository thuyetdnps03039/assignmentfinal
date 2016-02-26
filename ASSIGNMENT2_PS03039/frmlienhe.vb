Imports System.Data.SqlClient
Public Class frmlienhe
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into LIENHE values (@TENNGUOIGUI,@DIACHI,@SDT,@EMAIL,@YKIEN)"
        Dim themyk As SqlCommand = New SqlCommand(query, connect)
        connect.Open()
        If txtsender.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtdiachi.Text = "" Then
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtsdt.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập SĐT", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If txtemail.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If rtbcmt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ý kiến", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            themyk.Parameters.AddWithValue("@TENNGUOIGUI", txtsender.Text)
                            themyk.Parameters.AddWithValue("@DIACHI", txtdiachi.Text)
                            themyk.Parameters.AddWithValue("@SDT", txtsdt.Text)
                            themyk.Parameters.AddWithValue("@EMAIL", txtemail.Text)
                            themyk.Parameters.AddWithValue("@YKIEN", rtbcmt.Text)
                            themyk.ExecuteNonQuery()
                            connect.Close()
                            MessageBox.Show("Đã gửi phản hồi")
                            txtsender.Text = Nothing
                            txtdiachi.Text = Nothing
                            txtsdt.Text = Nothing
                            txtemail.Text = Nothing
                            rtbcmt.Text = Nothing
                        End If
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmlienhe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class