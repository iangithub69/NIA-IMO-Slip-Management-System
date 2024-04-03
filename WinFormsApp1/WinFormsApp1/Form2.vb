Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Org.BouncyCastle.Asn1.Tsp
Imports System.Windows.Forms.VisualStyles
Imports Mysqlx
Imports System.Windows.Forms

Public Class Form2

    Private connectionString As String = "server=localhost; user id =root; password=2020301243; database=slipsdb; port=3306"

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
        Dim formattedDate As String = currentDate.ToString("MM     dd     yyyy")

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Preserve the asterisks if they exist
        Dim asterisks As String = New String("*"c, TextBox8.TextLength - TextBox8.Text.Replace("*", "").Length)
        TextBox8.Text = asterisks
        TextBox9.Text = asterisks
        TextBox10.Text = asterisks

        TextBox3.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        'TextBox9.Clear()
        'TextBox10.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2_C.Show()

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim errorMessage As String = "Please fill in the following fields: "
        Dim missingFields As New List(Of String)

        ' Check for missing fields
        If String.IsNullOrEmpty(TextBox4.Text) Then
            missingFields.Add("Check Number")
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            missingFields.Add("Account Number")
        End If
        If String.IsNullOrEmpty(TextBox3.Text) Then
            missingFields.Add("Account Name")
        End If
        If String.IsNullOrEmpty(TextBox5.Text) Then
            missingFields.Add("Date")
        End If
        If String.IsNullOrEmpty(TextBox8.Text) Then
            missingFields.Add("Amount")
        End If
        If String.IsNullOrEmpty(TextBox9.Text) Then
            missingFields.Add("Pay To")
        End If
        If String.IsNullOrEmpty(TextBox10.Text) Then
            missingFields.Add("Pesos")
        End If
        If String.IsNullOrEmpty(ComboBox2.Text) Then
            missingFields.Add("Teller Name")
        End If
        If String.IsNullOrEmpty(ComboBox3.Text) Then
            missingFields.Add("Teller Designation")
        End If
        If String.IsNullOrEmpty(ComboBox4.Text) Then
            missingFields.Add("Officer Name")
        End If
        If String.IsNullOrEmpty(ComboBox5.Text) Then
            missingFields.Add("Officer Designation")
        End If
        If String.IsNullOrEmpty(ComboBox6.Text) Then
            missingFields.Add("Branch")
        End If

        ' If any fields are missing, display error message
        If missingFields.Count > 0 Then
            errorMessage &= String.Join(", ", missingFields)
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' If all fields are filled, proceed with insertion
        Dim successMessage As String = "Check Information Successfully Saved to Database."

        Try
            connecttodb()
            Dim sql As String = "INSERT INTO details (check_no, account_no, account_name, date, amount, pay_to, pesos, teller_name, teller_designation, officer_name, officer_designation, branch) VALUES (@check_no, @account_no, @account_name, @date, @amount, @pay_to, @pesos, @teller_name, @teller_designation, @officer_name, @officer_designation, @branch)"
            Dim cmd As New MySqlCommand(sql, cn)

            With cmd
                .Parameters.AddWithValue("@check_no", TextBox4.Text)
                .Parameters.AddWithValue("@account_no", TextBox2.Text)
                .Parameters.AddWithValue("@account_name", TextBox3.Text)
                .Parameters.AddWithValue("@date", TextBox5.Text)
                .Parameters.AddWithValue("@amount", TextBox8.Text)
                .Parameters.AddWithValue("@pay_to", TextBox9.Text)
                .Parameters.AddWithValue("@pesos", TextBox10.Text)
                .Parameters.AddWithValue("@teller_name", ComboBox2.Text)
                .Parameters.AddWithValue("@teller_designation", ComboBox3.Text)
                .Parameters.AddWithValue("@officer_name", ComboBox4.Text)
                .Parameters.AddWithValue("@officer_designation", ComboBox5.Text)
                .Parameters.AddWithValue("@branch", ComboBox6.Text)

                .ExecuteNonQuery()
            End With

            ' Display success message
            MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cmd IsNot Nothing Then cmd.Dispose()
            If cn IsNot Nothing AndAlso cn.State <> ConnectionState.Closed Then cn.Close()
        End Try
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve the last saved data from the database
        Dim query As String = "SELECT * FROM details WHERE detail_id = (SELECT MAX(detail_id) FROM details)
"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate textboxes with data from the database
                    TextBox1.Text = reader("detail_id").ToString()
                    TextBox2.Text = reader("account_no").ToString()
                    TextBox3.Text = reader("account_name").ToString()
                    TextBox4.Text = reader("check_no").ToString()
                    TextBox5.Text = reader("date").ToString()
                    TextBox8.Text = reader("amount").ToString()
                    TextBox9.Text = reader("pay_to").ToString()
                    TextBox10.Text = reader("pesos").ToString()
                    ' Populate comboboxes
                    ComboBox2.SelectedItem = reader("teller_name").ToString()
                    ComboBox3.SelectedItem = reader("teller_designation").ToString()
                    ComboBox4.SelectedItem = reader("officer_name").ToString()
                    ComboBox5.SelectedItem = reader("officer_designation").ToString()
                    ComboBox6.SelectedItem = reader("branch").ToString()
                End If

                reader.Close()
            End Using
        End Using

        'TextBox8.Text = "****"
        'TextBox9.Text = "****"
        'ComboBox2.Items.Add("Add more")
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the connection is open before closing it
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedAccount As String = ComboBox1.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM account_types WHERE account_name = @account_name"

        Try
            connecttodb()
            cmd = New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@account_name", selectedAccount)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                TextBox2.Text = dr("account_no").ToString()
                TextBox3.Text = dr("account_name").ToString()
                ' Add more TextBoxes as needed
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox1}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT account_name FROM account_types"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox1.Items.Add(dr("account_name").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox2}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT teller_name FROM tellers"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox2.Items.Add(dr("teller_name").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox3_DropDown(sender As Object, e As EventArgs) Handles ComboBox3.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox3}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT description FROM tellers"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox3.Items.Add(dr("description").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox4_DropDown(sender As Object, e As EventArgs) Handles ComboBox4.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox4}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT officer_name FROM officers"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox4.Items.Add(dr("officer_name").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox5_DropDown(sender As Object, e As EventArgs) Handles ComboBox5.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox5}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT description FROM officers"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox5.Items.Add(dr("description").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub ComboBox6_DropDown(sender As Object, e As EventArgs) Handles ComboBox6.DropDown
        Try
            ' Connect to the database
            connecttodb()

            ' Clear all ComboBoxes
            For Each cb As System.Windows.Forms.ComboBox In {ComboBox6}
                cb.Items.Clear()
            Next

            ' SQL queries for each ComboBox
            Dim sqlQueries() As String = {
            "SELECT branch FROM officers"
        }

            ' Execute queries and populate ComboBoxes
            For i As Integer = 0 To 0
                Dim sql As String = sqlQueries(i)
                cmd = New MySqlCommand(sql, cn)
                dr = cmd.ExecuteReader()

                While dr.Read()
                    ' Add items to respective ComboBoxes
                    Select Case i
                        Case 0
                            ComboBox6.Items.Add(dr("branch").ToString())
                    End Select
                End While

                dr.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Instantiate Form2_B
        Dim form2 As New Form2_A()

        ' Set the values of labels in Form2_B
        form2.Label12Text = TextBox4.Text
        form2.Label11Text = TextBox3.Text
        form2.Label10Text = TextBox2.Text
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Check if the "more option..." option is selected
        If ComboBox2.SelectedItem.ToString() = "more option..." Then
            ' Show a new form
            Dim newForm As New Form2_D()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ' Check if the "more option..." option is selected
        If ComboBox3.SelectedItem.ToString() = "more option..." Then
            ' Show a new form
            Dim newForm As New Form2_D()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ' Check if the "more option..." option is selected
        If ComboBox4.SelectedItem.ToString() = "more option..." Then
            ' Show a new form
            Dim newForm As New Form2_E()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        ' Check if the "more option..." option is selected
        If ComboBox5.SelectedItem.ToString() = "more option..." Then
            ' Show a new form
            Dim newForm As New Form2_E()
            newForm.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        ' Check if the "more option..." option is selected
        If ComboBox6.SelectedItem.ToString() = "more option..." Then
            ' Show a new form
            Dim newForm As New Form2_E()
            newForm.ShowDialog()
        End If
    End Sub
End Class