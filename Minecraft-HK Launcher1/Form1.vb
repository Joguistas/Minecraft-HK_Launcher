Imports System.Net
Imports System.IO

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim R = HttpWebRequest.Create(String.Format("http://login.minecraft.net/?user={0}&password={1}&version=13", TextBox1.Text, TextBox2.Text))
        Dim S As Stream = R.GetResponse().GetResponseStream()
        Dim SR As New StreamReader(S)
        Dim C() As String
        C = SR.ReadToEnd().Split(":")
       Select Case  C(0).Trim.ToLower
            Case "bad request"
                MsgBox("Bad login")
            Case "user not premium"
                MsgBox("Not paid user")
            Case "old version"
                MsgBox("Old Version")
            Case Else
                MsgBox(C(0).Trim.ToLower)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
