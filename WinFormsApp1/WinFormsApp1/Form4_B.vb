Public Class Form4_B
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Instantiate Form3_A
        Dim form4 As New Form4_C

        ' Set the values of labels in Form3_A
        'for account numbers
        form4.Label1Text = TextBox2.Text
        form4.Label2Text = TextBox3.Text
        form4.Label3Text = TextBox4.Text
        form4.Label4Text = TextBox6.Text
        form4.Label5Text = TextBox7.Text
        form4.Label6Text = TextBox8.Text
        form4.Label7Text = TextBox9.Text
        form4.Label8Text = TextBox10.Text
        form4.Label9Text = TextBox11.Text
        form4.Label10Text = TextBox12.Text
        form4.Label11Text = TextBox23.Text
        form4.Label12Text = TextBox22.Text
        form4.Label13Text = TextBox21.Text
        form4.Label14Text = TextBox20.Text
        form4.Label15Text = TextBox19.Text
        form4.Label16Text = TextBox18.Text
        form4.Label17Text = TextBox17.Text
        form4.Label18Text = TextBox16.Text
        form4.Label19Text = TextBox15.Text
        form4.Label20Text = TextBox5.Text
        form4.Label21Text = TextBox14.Text
        form4.Label23Text = TextBox35.Text
        form4.Label22Text = TextBox1.Text
        form4.Label24Text = TextBox34.Text
        form4.Label25Text = TextBox33.Text
        form4.Label26Text = TextBox32.Text
        form4.Label27Text = TextBox31.Text
        form4.Label28Text = TextBox30.Text
        form4.Label29Text = TextBox29.Text
        form4.Label30Text = TextBox28.Text
        form4.Label31Text = TextBox27.Text
        form4.Label32Text = TextBox26.Text
        form4.Label33Text = TextBox25.Text
        form4.Label34Text = TextBox44.Text
        form4.Label35Text = TextBox43.Text
        form4.Label36Text = TextBox42.Text
        form4.Label37Text = TextBox41.Text
        form4.Label38Text = TextBox40.Text
        form4.Label39Text = TextBox39.Text
        form4.Label40Text = TextBox38.Text
        form4.Label41Text = TextBox37.Text
        form4.Label42Text = TextBox36.Text
        form4.Label43Text = TextBox24.Text
        form4.Label44Text = TextBox13.Text
        form4.Label45Text = TextBox56.Text
        form4.Label46Text = TextBox55.Text
        form4.Label47Text = TextBox54.Text
        form4.Label48Text = TextBox53.Text
        form4.Label49Text = TextBox52.Text
        form4.Label50Text = TextBox50.Text
        form4.Label51Text = TextBox49.Text
        form4.Label52Text = TextBox48.Text
        form4.Label53Text = TextBox47.Text
        form4.Label54Text = TextBox46.Text
        form4.Label55Text = TextBox45.Text
        form4.Label56Text = TextBox57.Text
        form4.Label57Text = TextBox58.Text

        form4.Show()
    End Sub

    Private Sub Form4_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox57.Text = "****"
        TextBox58.Text = "****"
    End Sub
End Class