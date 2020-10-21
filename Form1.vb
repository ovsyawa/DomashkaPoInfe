Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        Dim s As Single
        If CheckBox1.Checked = True Then s = s + 200
        If CheckBox2.Checked = True Then s = s + 200
        If CheckBox3.Checked = True Then s = s + 300
        If CheckBox4.Checked = True Then s = s + 300
        If ComboBox1.SelectedItem = "13'" Then s = s + 500
        If ComboBox1.SelectedItem = "14'" Then s = s + 500
        If ComboBox1.SelectedItem = "15'" Then s = s + 500
        If ComboBox1.SelectedItem = "16'" Then s = s + 500
        If ComboBox1.SelectedItem = "17'" Then s = s + 500
        If ComboBox1.SelectedItem = "18'" Then s = s + 500
        If ComboBox1.SelectedItem = "19'" Then s = s + 500
        If RadioButton2.Checked = True Then s = s * 2
        TextBox3.Text = s
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim t As Date
        t = Now
        TextBox4.Text = t
    End Sub
End Class
