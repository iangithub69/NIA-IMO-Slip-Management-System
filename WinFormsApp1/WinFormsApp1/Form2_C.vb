Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2_C

    Private connectionString As String = "server=localhost; user id =root; password=2020301243; database=slipsdb; port=3306"

    Private Sub details()
        connecttodb() ' Assuming this is your database connection function

        Dim sql As String = "SELECT detail_id AS 'Detail ID', check_no AS 'Check Number', account_no AS 'Account Number', account_name AS 'Account Name', date AS 'Date Issued', amount AS 'Amount', pay_to AS 'Pay To The Order Of', pesos AS 'Pesos', cashier_name AS 'Tiller Name', cashier_designation AS 'Tiller Designation', officer_name AS 'Officer Name', officer_designation AS 'Officer Designation', branch AS 'Branch' FROM details"
        Dim cmd As New MySqlCommand(sql, cn)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView1.DataSource = dataTable

        ' Close the connection 
        adapter.Dispose()
        cmd.Dispose()
        cn.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Form2_C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        details()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not in the header row
        If e.RowIndex >= 0 Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)

            Label1.Text = selectedRow.Cells(0).Value.ToString()

            TextBox1.Text = selectedRow.Cells(1).Value.ToString()
            TextBox2.Text = selectedRow.Cells(2).Value.ToString()
            TextBox3.Text = selectedRow.Cells(3).Value.ToString()

            TextBox4.Text = selectedRow.Cells(4).Value.ToString()
            TextBox5.Text = selectedRow.Cells(5).Value.ToString()
            TextBox6.Text = selectedRow.Cells(6).Value.ToString()

            TextBox7.Text = selectedRow.Cells(7).Value.ToString()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a digit or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or control key, suppress it
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the pressed key is a digit or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or control key, suppress it
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        ' Check if the pressed key is a digit or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or control key, suppress it
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the pressed key is a digit or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a digit or control key, suppress it
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateData
        details
    End Sub

    ' Method to update the database with changes made in the textboxes
    Private Sub UpdateData()
        Try
            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim sql As String = "UPDATE details SET check_no=@check_no, account_no=@account_no, account_name=@account_name, date=@date, amount=@amount, pay_to=@pay_to, pesos=@pesos WHERE detail_id = @detail_id"
                    Dim command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@check_no", TextBox1.Text)
                    command.Parameters.AddWithValue("@account_no", TextBox2.Text)
                    command.Parameters.AddWithValue("@account_name", TextBox3.Text)
                    command.Parameters.AddWithValue("@date", TextBox4.Text) ' Assuming TextBox4 is a DateTimePicker
                    command.Parameters.AddWithValue("@amount", TextBox5.Text) ' Assuming TextBox5 contains the amount
                    command.Parameters.AddWithValue("@pay_to", TextBox6.Text)
                    command.Parameters.AddWithValue("@pesos", TextBox7.Text) ' Assuming TextBox6 contains the pesos
                    ' Replace "@detail_id" with the parameterized column name for the detail_id
                    command.Parameters.AddWithValue("@detail_id", DataGridView1.SelectedRows(0).Cells(0).Value.ToString()) ' Assuming detail_id is in the first column
                    command.ExecuteNonQuery()
                End Using

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()

                ' Show success message
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if any cell is selected
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim clipboardContent As New System.Text.StringBuilder()

            ' Iterate through selected cells
            For Each cell As DataGridViewCell In DataGridView1.SelectedCells
                ' Append cell value to the clipboard content
                clipboardContent.Append(cell.Value.ToString())

                ' Separate cells with tab
                clipboardContent.Append(vbTab)

                ' If it's the last cell in the row, add newline character
                If cell.ColumnIndex = DataGridView1.Columns.Count - 1 Then
                    clipboardContent.AppendLine()
                End If
            Next

            ' Copy the content to the clipboard
            Clipboard.SetText(clipboardContent.ToString())

            MessageBox.Show("Selected data copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No data selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class