Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmMain
    Dim chuoiketnoi As String = "workstation id=PS03039.mssql.somee.com;packet size=4096;user id=thuyetthemen_SQLLogin_1;pwd=558232h24d;data source=PS03039.mssql.somee.com;persist security info=False;initial catalog=PS03039"

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        frmCapnhatsanpham.Show()
    End Sub

    Private Sub XemKhácHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemKhácHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub ChỉnhSữaKHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChỉnhSữaKHToolStripMenuItem.Click
        frmDieuchinhKH.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btncapnhatkh.Click
        frmDieuchinhKH.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btncapnhatsp.Click
        frmCapnhatsanpham.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btntimsp.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        frmGioithieu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btninfo.Click
        frmGioithieu.Show()
    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiênHệToolStripMenuItem.Click
        frmlienhe.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btntimkh.Click
        frmKH.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncontact.Click
        frmlienhe.Show()
    End Sub


    Private Sub CậpNhậtKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtKháchHàngToolStripMenuItem.Click
        frmDieuchinhKH.Show()
    End Sub

    Private Sub TìmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKháchHàngToolStripMenuItem.Click
        frmKH.Show()
    End Sub

    Private Sub CậpNhậtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtSảnPhẩmToolStripMenuItem.Click
        frmCapnhatsanpham.Show()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem1.Click
        frmXemsanpham.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnaccount.Click
        frmThongtinAccount.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn đăng nhập lại?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Application.Restart()
        Else
            If result = Windows.Forms.DialogResult.No Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub frmMain_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim chaomung As SqlDataAdapter = New SqlDataAdapter("select USERNAME, REVERSE(LEFT(REVERSE(TEN),CHARINDEX(' ',REVERSE(TEN))-1)) from TaiKhoan where USERNAME = '" & frmlogin.txtuser.Text & "'", connect)
        Dim db As DataTable = New DataTable
        connect.Open()
        Try
            chaomung.Fill(db)
            dgvchaomung.DataSource = db.DefaultView
            txtluuten.Text = dgvchaomung.Item(1, 0).Value
            txtadmin.text = dgvchaomung.Item(0, 0).Value
            If txtadmin.Text.Contains("admin") Then
                sttchaomung.Text = "Xin chúc Đại ca " & txtluuten.Text & " một ngày tốt lành!"
            Else
                sttchaomung.Text = "Xin chúc " & txtluuten.Text & " một ngày tốt lành!"
            End If
        Catch ex As Exception
        End Try
        connect.Close()
    End Sub
    Private Sub frmMain_Load_2(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
