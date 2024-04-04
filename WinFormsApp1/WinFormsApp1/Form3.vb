Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    '    'to fetch date and time on current device
    '    ' Use "MMMM" in the format string to display the full month name
    '    TextBox4.Text = Date.Now.ToString("MMMM dd yyyy")

    'End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MMMM dd yyyy")

        ' Set the formatted date to TextBox4
        TextBox4.Text = formattedDate
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Instantiate Form3_A
        Dim form3 As New Form3_A()

        ' Set the values of labels in Form3_A
        form3.Label1Text = TextBox1.Text
        form3.Label2Text = TextBox2.Text
        form3.Label3Text = TextBox3.Text
        form3.Label5Text = TextBox7.Text
        form3.Label6Text = TextBox8.Text
        form3.Label7Text = TextBox9.Text
        form3.Label8Text = TextBox10.Text
        form3.Label9Text = TextBox4.Text
        form3.Label10Text = TextBox5.Text
        form3.Label11Text = TextBox6.Text



        ' Show Form2_B
        form3.Show()
    End Sub
End Class