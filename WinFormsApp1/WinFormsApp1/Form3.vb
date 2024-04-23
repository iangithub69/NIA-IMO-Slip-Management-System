Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()

        Me.Close()

    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    '    'to fetch date and time on current device
    '    ' Use "MMMM" in the format string to display the full month name
    '    TextBox4.Text = Date.Now.ToString("MMMM dd yyyy")

    'End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True

        TextBox10.Text = "****"

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
        Dim form3 As New Form3_A

        ' Set the values of labels in Form3_A
        'for account numbers
        form3.Label1Text = TextBox1.Text
        form3.Label2Text = TextBox2.Text
        form3.Label3Text = TextBox3.Text
        form3.Label14Text = TextBox11.Text
        form3.Label16Text = TextBox12.Text
        form3.Label17Text = TextBox13.Text
        form3.Label18Text = TextBox14.Text
        form3.Label19Text = TextBox15.Text
        form3.Label21Text = TextBox16.Text
        form3.Label22Text = TextBox17.Text
        'for reference 1, 2, and 3. For amount, date, merchant, and printed name
        form3.Label5Text = TextBox7.Text
        form3.Label6Text = TextBox8.Text
        form3.Label7Text = TextBox9.Text
        form3.Label8Text = TextBox10.Text
        form3.Label9Text = TextBox4.Text
        form3.Label10Text = TextBox5.Text
        form3.Label11Text = TextBox6.Text

        ' Check which RadioButton is selected and set Label12Text accordingly
        If RadioButton3.Checked Then
            form3.Label4Text = "/"
        ElseIf RadioButton2.Checked Then
            form3.Label12Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        ElseIf RadioButton1.Checked Then
            form3.Label13Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        End If

        ' Show Form2_B
        form3.Show
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox1.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox1.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox2.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox3.Focus()
        End If
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
        ' Allow digits, comma, period, and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "," AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit, comma, period, or backspace, suppress the key press
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso TextBox1.Text.Contains(".") Then
            ' If decimal point already exists, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox3.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox11.Focus()
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

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox11.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox12.Focus()
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

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox12.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox13.Focus()
        End If
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox12.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox13.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox14.Focus()
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox13.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox14.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox15.Focus()
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox14.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox15.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox16.Focus()
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox15.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox16.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox17.Focus()
        End If
    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox16.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox17.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form3_B.Show()

    End Sub
End Class