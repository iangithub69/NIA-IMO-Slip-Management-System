Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2



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
            words = tens(value \ 10) & " " & ones(value Mod 10)
        ElseIf value < 1000 Then
            words = ones(value \ 100) & " HUNDRED " & ConvertToWordsHelper(value Mod 100)
        ElseIf value < 1000000 Then
            words = ConvertToWordsHelper(value \ 1000) & " THOUSAND " & ConvertToWordsHelper(value Mod 1000)
        ElseIf value < 1000000000 Then
            words = ConvertToWordsHelper(value \ 1000000) & " MILLION " & ConvertToWordsHelper(value Mod 1000000)
        Else
            words = ConvertToWordsHelper(value \ 1000000000) & " BILLION " & ConvertToWordsHelper(value Mod 1000000000)
        End If

        Return words.Trim()
    End Function



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to the database
        connecttodb()

        ' Clear the ComboBox
        ComboBox1.Items.Clear()

        ' SQL query to select data from the desired column
        Dim sql As String = "SELECT account_name FROM account_types"

        ' Execute the query
        Try
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            ' Read each row and add the value to the ComboBox
            While dr.Read()
                ComboBox1.Items.Add(dr("account_name").ToString())
            End While

            ' Close the reader
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBox8.Text = "****"
        TextBox9.Text = "****"
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the connection is open before closing it
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2_B.Show()

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the pressed key is a digit or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or control key, suppress it
            e.Handled = True
        End If
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
                TextBox10.Text = words
            Else
                ' Clear TextBox10 if the input in TextBox8 (excluding asterisks) is not a valid numeric value
                TextBox10.Clear()
            End If
        End If
    End Sub


    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        ' Get the current date and format it
        Dim currentDate As Date = Date.Now
        Dim formattedDate As String = currentDate.ToString("MMMM dd yyyy")

        ' Set the formatted date to TextBox4
        TextBox5.Text = formattedDate
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Retrieve the selected item from ComboBox
        Dim selectedAccount As String = ComboBox1.SelectedItem.ToString()

        ' SQL query to select all data for the selected account_name
        Dim query As String = $"SELECT * FROM account_types WHERE account_name = '{selectedAccount}'"

        ' Execute the query
        Try
            cmd = New MySqlCommand(query, cn)
            dr = cmd.ExecuteReader()

            ' Check if there are rows
            If dr.Read() Then
                ' Display data in TextBoxes
                TextBox2.Text = dr("account_no").ToString() ' Replace "column1" with the actual column name
                TextBox3.Text = dr("account_name").ToString() ' Replace "column2" with the actual column name
                ' Add more TextBoxes as needed
            End If

            ' Close the reader
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Preserve the asterisks if they exist
        Dim asterisks As String = New String("*"c, TextBox8.TextLength - TextBox8.Text.Replace("*", "").Length)
        TextBox8.Text = asterisks
        TextBox9.Text = asterisks
        TextBox10.Text = asterisks

        TextBox5.Clear()
        'TextBox8.Clear()
        'TextBox9.Clear()
        'TextBox10.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    'this is a test
    'this is a test
    'this is a test
    'this is a test

End Class