Public Class Form1
    Public 版本 As String = "0.0.1"
    Public Sub 顯示(視窗 As Form, Optional 清除其他 As Boolean = True)
        視窗.TopLevel = False
        If 清除其他 = True Then Panel1.Controls.Clear()
        Panel1.Controls.Add(視窗)
        Panel1.Controls.SetChildIndex(視窗, 0)
        視窗.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + " " + 版本
        PictureBox1.ImageLocation = "http://forum.minecraft-hk.com/static/image/minecraft-hkstyle/logo.png"
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown, Button1.Click
        顯示(HOME)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        顯示(Server_List)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        顯示(About)
    End Sub
End Class
