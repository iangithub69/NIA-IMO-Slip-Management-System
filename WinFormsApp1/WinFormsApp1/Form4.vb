Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()

        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        ' Instantiate Form3_A
        Dim form4 As New Form4_A

        ' Set the values of labels in Form3_A
        'for account numbers
        form4.Label1Text = TextBox9.Text
        form4.Label2Text = TextBox2.Text
        form4.Label3Text = TextBox10.Text
        form4.Label4Text = TextBox11.Text
        form4.Label5Text = TextBox12.Text
        form4.Label6Text = TextBox13.Text
        form4.Label7Text = TextBox14.Text
        form4.Label8Text = TextBox15.Text
        form4.Label9Text = TextBox16.Text
        form4.Label10Text = TextBox17.Text
        form4.Label11Text = TextBox18.Text
        form4.Label12Text = TextBox4.Text
        form4.Label19Text = RichTextBox1.Text
        form4.Label18Text = TextBox3.Text
        form4.Label20Text = TextBox8.Text
        form4.Label21Text = TextBox5.Text
        form4.Label22Text = TextBox7.Text
        form4.Label23Text = TextBox1.Text


        ' Check which RadioButton is selected and set Label12Text accordingly
        If RadioButton1.Checked Then
            form4.Label13Text = "/"
        ElseIf RadioButton2.Checked Then
            form4.Label14Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        ElseIf RadioButton3.Checked Then
            form4.Label15Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        ElseIf RadioButton4.Checked Then
            form4.Label16Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        ElseIf RadioButton5.Checked Then
            form4.Label17Text = "/"
            ' Add more ElseIf statements for additional RadioButtons if needed
        End If


        ' Show Form2_B
        form4.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MMMM dd yyyy")

        ' Set the formatted date to TextBox4
        TextBox9.Text = formattedDate
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox2.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox10.Focus()
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

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        ' Check if the length of the text is equal to 4
        If TextBox10.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox11.Focus()
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
        ' Check if the length of the text is equal to 4
        If TextBox17.TextLength = 1 Then
            ' If so, set focus to TextBox2
            TextBox18.Focus()
        End If
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

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If

        ' Check if textbox length is already 4 and the pressed key is not backspace
        If TextBox18.TextLength = 1 AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If so, suppress the key press
            e.Handled = True
        End If
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

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox8.Text = "****"
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Get the numeric value from TextBox8 (excluding asterisks)
            Dim numericValue As Decimal
            Dim inputValue As String = TextBox8.Text.Replace("*", "") ' Remove asterisks
            If Decimal.TryParse(inputValue, numericValue) Then
                ' Convert the numeric value to words in Philippine Peso format
                Dim words As String = ConvertToWords(numericValue)
                ' Display the Philippine Peso format in TextBox10
                RichTextBox1.Text = words
            Else
                ' Clear TextBox10 if the input in TextBox8 (excluding asterisks) is not a valid numeric value
                RichTextBox1.Clear()
            End If
        End If
    End Sub

    Private Function ConvertToWords(ByVal value As Decimal) As String
        ' Split the value into whole number and fractional part
        Dim wholeNumber As Decimal = Math.Truncate(value)
        Dim fractionalPart As Decimal = value - wholeNumber

        ' Convert the whole number part to words
        Dim wholeNumberWords As String = ConvertToWordsHelper(wholeNumber)

        ' Convert the fractional part to words (cents)
        Dim fractionalPartWords As String = ""
        If fractionalPart > 0 Then
            fractionalPartWords = "AND " & ConvertToWordsHelper(fractionalPart * 100) & " CENTAVOS"
        End If

        ' Combine the whole number and fractional part words
        Dim words As String = "**" & wholeNumberWords & " PESOS " & fractionalPartWords & " ONLY" & "**"

        Return words.Trim()
    End Function

    Private Function ConvertToWordsHelper(ByVal value As Decimal) As String
        ' Define arrays for Philippine Peso words
        Dim ones() As String = {"", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"}
        Dim teens() As String = {"", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"}
        Dim tens() As String = {"", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"}

        ' Convert the value to words
        Dim words As String = ""
        If value = 0 Then
            words = "ZERO"
        ElseIf value < 10 Then
            words = ones(value)
        ElseIf value < 20 Then
            words = teens(value - 10)
        ElseIf value < 100 Then
            Dim tensPlace As Integer = value \ 10
            Dim onesPlace As Integer = value Mod 10
            If onesPlace = 0 Then
                words = tens(tensPlace)
            Else
                words = tens(tensPlace) & " " & ones(onesPlace)
            End If
        ElseIf value < 1000 Then
            Dim hundredsPlace As Integer = value \ 100
            Dim remainder As Integer = value Mod 100
            If remainder = 0 Then
                words = ones(hundredsPlace) & " HUNDRED"
            Else
                words = ones(hundredsPlace) & " HUNDRED " & ConvertToWordsHelper(remainder)
            End If
        ElseIf value < 1000000 Then
            Dim thousandsPlace As Integer = value \ 1000
            Dim remainder As Integer = value Mod 1000
            If remainder = 0 Then
                words = ConvertToWordsHelper(thousandsPlace) & " THOUSAND"
            Else
                words = ConvertToWordsHelper(thousandsPlace) & " THOUSAND " & ConvertToWordsHelper(remainder)
            End If
        ElseIf value < 1000000000 Then
            Dim millionsPlace As Integer = value \ 1000000
            Dim remainder As Integer = value Mod 1000000
            If remainder = 0 Then
                words = ConvertToWordsHelper(millionsPlace) & " MILLION"
            Else
                words = ConvertToWordsHelper(millionsPlace) & " MILLION " & ConvertToWordsHelper(remainder)
            End If
        Else
            Dim billionsPlace As Integer = value \ 1000000000
            Dim remainder As Integer = value Mod 1000000000
            If remainder = 0 Then
                words = ConvertToWordsHelper(billionsPlace) & " BILLION"
            Else
                words = ConvertToWordsHelper(billionsPlace) & " BILLION " & ConvertToWordsHelper(remainder)
            End If
        End If

        Return words.Trim()
    End Function


End Class