Public Class Form1
    Const xorNum = 177451812
    Const addNum = 8728348608
    Const table = "fZodR9XQDSUm21yCkr6zBqiveYah8bt4xsWpHnJE7jL5VG3guMTKNPAwcF"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tr() As String
        ReDim tr(0 To Len(table))
        For i = 0 To Len(table)
            tr(i) = Mid(table, i + 1, 1)
        Next '将字符放入数组
        Dim r As Double
        Dim S() As Integer = {11, 10, 3, 8, 4, 6}
        Dim x() As String '定义BV号
        ReDim x(0 To TextBox1.TextLength)
        For i = 0 To TextBox1.TextLength
            x(i) = Mid(TextBox1.Text, i + 1, 1)
        Next
        For i = 0 To 5
            r = r + (InStrRev(table, x(S(i))) - 1) * (58 ^ i)
        Next
        TextBox2.Text = "av" & ((r - addNum) Xor xorNum)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double '定义av号
        Dim S() As Integer = {5, 4, 0, 3, 1, 2} '对应位置
        x = (Val(Mid(TextBox2.Text, 3)) Xor xorNum) + addNum
        Dim r() As String = {"", "", "", "", "", ""}
        For i = 0 To 5
            r(S(i)) = table(Math.Floor(x / (58 ^ i)) Mod 58) '答题卡
        Next
        TextBox1.Text = "BV1" & r(0) & r(1) & "4" & r(2) & "1" & r(3) & "7" & r(4) & r(5) '完形填空
    End Sub
End Class
