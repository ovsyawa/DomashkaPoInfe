Public Class Form1
    Private Sub Start(s As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub
    Private Sub FindPrice(s As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        Dim summary As Integer
        If CheckBox1.Checked Then summary += 200
        If CheckBox2.Checked Then summary += 200
        If CheckBox3.Checked Then summary += 300
        If CheckBox4.Checked Then summary += 300
        For i As Integer = 13 To 19
            If ComboBox1.SelectedItem IsNot Nothing And ComboBox1.SelectedItem.ToString.Substring(0, 2) = i Then summary += 500
        Next
        If RadioButton2.Checked Then summary *= 2
        TextBox3.Text = summary
    End Sub
    Private Sub Tick(s As Object, e As EventArgs) Handles Timer1.Tick
        TextBox4.Text = Now
    End Sub
End Class