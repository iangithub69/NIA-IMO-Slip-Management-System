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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub
End Class