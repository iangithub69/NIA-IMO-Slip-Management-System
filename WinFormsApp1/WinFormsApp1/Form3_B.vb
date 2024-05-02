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

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox16.KeyPress
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

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
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

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
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
End Class