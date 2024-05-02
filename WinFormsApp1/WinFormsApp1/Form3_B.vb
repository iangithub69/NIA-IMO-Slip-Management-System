Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form3_B
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MMMM dd yyyy")

        ' Set the formatted date to TextBox4
        TextBox17.Text = formattedDate
    End Sub

    Private Sub Form3_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox10.Text = "****"
        TextBox11.Text = "****"
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Instantiate Form3_C
        Dim form4 As New Form3_C

        ' Set the values of labels in Form3_A
        'for account numbers
        form4.Label1Text = TextBox1.Text
        form4.Label2Text = TextBox2.Text
        form4.Label3Text = TextBox3.Text
        form4.Label4Text = TextBox4.Text
        form4.Label5Text = TextBox5.Text
        form4.Label6Text = TextBox6.Text
        form4.Label7Text = TextBox7.Text
        form4.Label8Text = TextBox8.Text
        form4.Label9Text = TextBox9.Text
        form4.Label10Text = TextBox10.Text
        form4.Label11Text = TextBox18.Text
        form4.Label12Text = TextBox15.Text
        form4.Label13Text = TextBox17.Text
        form4.Label14Text = TextBox16.Text
        form4.Label15Text = TextBox19.Text
        form4.Label16Text = TextBox11.Text
        form4.Label17Text = TextBox12.Text
        form4.Label18Text = TextBox13.Text
        form4.Label19Text = TextBox14.Text

        form4.Show()
    End Sub
End Class