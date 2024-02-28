Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Asn1.Tsp
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.ComboBox

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


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to the database
        connecttodb()

        ' Clear the ComboBox
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox6.Items.Clear()

        ' Populate ComboBoxes
        PopulateComboBoxes()

        TextBox8.Text = "****"
        TextBox9.Text = "****"
    End Sub

    Private Sub PopulateComboBoxes()
        ' SQL queries to select data from the desired columns
        Dim sqlAccountTypes As String = "SELECT account_name FROM account_types"

        Dim sqlTillers As String = "SELECT tiller_name FROM tillers"
        Dim sqlTillerDesignation As String = "SELECT description FROM tillers"

        Dim sqlOfficers As String = "SELECT officer_name FROM officers"
        Dim sqlOfficerDesignation As String = "SELECT description FROM officers"
        Dim sqlBranch As String = "SELECT branch FROM officers"

        ' Add other SQL queries for ComboBox3, ComboBox5, ComboBox6 if needed

        ' Execute queries and populate ComboBoxes
        PopulateComboBox(sqlAccountTypes, ComboBox1)

        PopulateComboBox(sqlTillers, ComboBox2)
        PopulateComboBox(sqlTillerDesignation, ComboBox3)

        PopulateComboBox(sqlOfficers, ComboBox4)
        PopulateComboBox(sqlOfficerDesignation, ComboBox5)
        PopulateComboBox(sqlBranch, ComboBox6)
        ' Populate other ComboBoxes similarly
    End Sub

    Private Sub PopulateComboBox(query As String, comboBox As System.Windows.Forms.ComboBox)
        Try
            cmd = New MySqlCommand(query, cn)
            dr = cmd.ExecuteReader()

            ' Read each row and add the value to the ComboBox
            While dr.Read()
                comboBox.Items.Add(dr(0).ToString())
            End While

            ' Close the reader
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        ' Instantiate Form2_B
        Dim form2 As New Form2_B()

        ' Set the values of labels in Form2_B
        form2.Label1Text = TextBox5.Text
        form2.Label2Text = TextBox8.Text
        form2.Label3Text = TextBox9.Text
        form2.Label4Text = TextBox10.Text
        form2.Label5Text = ComboBox2.Text
        form2.Label6Text = ComboBox3.Text
        form2.Label7Text = ComboBox4.Text
        form2.Label8Text = ComboBox5.Text
        form2.Label9Text = ComboBox6.Text

        ' Show Form2_B
        form2.Show()
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
        Dim formattedDate As String = currentDate.ToString("mm    dd    yyyy")

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

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Connect to the database
        connecttodb()

        ' Insert data into the database
        Dim sqlInsert As String = "INSERT INTO details (check_no, account_no, account_name, date, amount, pay_to, pesos, cashier_name, cashier_designation, officer_name, officer_designation, branch) VALUES (@check_no, @account_no, @account_name, @date, @amount, @pay_to, @pesos, @cashier_name, @cashier_designation, @officer_name, @officer_designation, @branch)"

        Try
            Using cmd As New MySqlCommand(sqlInsert, cn)
                ' Set parameters for the database insertion
                With cmd.Parameters
                    .AddWithValue("@check_no", TextBox4.Text)
                    .AddWithValue("@account_no", TextBox2.Text)
                    .AddWithValue("@account_name", TextBox3.Text)
                    .AddWithValue("@date", TextBox5.Text)
                    .AddWithValue("@amount", TextBox8.Text)
                    .AddWithValue("@pay_to", TextBox9.Text)
                    .AddWithValue("@pesos", TextBox10.Text)
                    .AddWithValue("@cashier_name", ComboBox2.Text)
                    .AddWithValue("@cashier_designation", ComboBox3.Text)
                    .AddWithValue("@officer_name", ComboBox4.Text)
                    .AddWithValue("@officer_designation", ComboBox5.Text)
                    .AddWithValue("@branch", ComboBox6.Text)
                End With

                ' Execute the database insertion
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error inserting data: " & ex.Message)
        Finally
            ' Close database connections
            cn.Close()
        End Try
    End Sub

    Private Sub connecttodb()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error connecting to database: " & ex.Message)
        End Try
    End Sub

End Class