Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form5
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MM / dd / yyyy")

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged

    End Sub

    Private Sub TextBox32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox32.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged

    End Sub

    Private Sub TextBox33_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox33.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox13.Text = "****"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox2.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox3.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox4.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox5.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox6.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox7.Focus()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox7.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox8.Focus()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox8.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox9.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox10.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox2.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox3.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox4.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox5.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox6.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox7.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox8.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox9.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox10.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox11.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub
End Class