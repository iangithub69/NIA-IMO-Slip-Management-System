Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form5
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MMMM dd yyyy")

        ' Set the formatted date to TextBox4
        TextBox35.Text = formattedDate
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Instantiate Form3_A
        Dim form5 As New Form5_A

        ' Set the values of labels in Form3_A
        'for account numbers
        form5.Label1Text = TextBox2.Text
        form5.Label2Text = TextBox3.Text
        form5.Label3Text = TextBox4.Text
        form5.Label4Text = TextBox5.Text
        form5.Label5Text = TextBox6.Text
        form5.Label6Text = TextBox7.Text
        form5.Label7Text = TextBox8.Text
        form5.Label8Text = TextBox9.Text
        form5.Label9Text = TextBox10.Text
        form5.Label10Text = TextBox11.Text

        form5.Label11Text = TextBox12.Text
        form5.Label12Text = TextBox32.Text
        form5.Label13Text = TextBox33.Text


        ' Check which RadioButton is selected and set Label12Text accordingly
        If RadioButton1.Checked Then
            form5.Label14Text = "/"
        ElseIf RadioButton2.Checked Then
            form5.Label16Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        End If

        form5.Label15Text = TextBox35.Text
        form5.Label17Text = TextBox13.Text
        form5.Label18Text = TextBox14.Text
        form5.Label19Text = TextBox20.Text
        form5.Label20Text = TextBox26.Text
        form5.Label21Text = TextBox15.Text
        form5.Label22Text = TextBox1.Text
        form5.Label23Text = TextBox21.Text
        form5.Label24Text = TextBox27.Text
        form5.Label25Text = TextBox29.Text
        form5.Label26Text = TextBox23.Text
        form5.Label27Text = TextBox17.Text
        form5.Label28Text = TextBox28.Text
        form5.Label29Text = TextBox22.Text
        form5.Label30Text = TextBox16.Text
        form5.Label31Text = TextBox34.Text
        form5.Label34Text = TextBox30.Text
        form5.Label35Text = TextBox24.Text
        form5.Label36Text = TextBox18.Text
        form5.Label37Text = TextBox31.Text
        form5.Label38Text = TextBox25.Text
        form5.Label39Text = TextBox19.Text

        ' Show Form2_B
        form5.Show()
    End Sub
End Class