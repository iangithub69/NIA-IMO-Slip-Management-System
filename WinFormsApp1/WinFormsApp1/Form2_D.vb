Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Org.BouncyCastle.Asn1.Tsp
Imports System.Windows.Forms.VisualStyles

Public Class Form2_D

    Private connectionString As String = "server=localhost; user id =root; password=2020301243; database=slipsdb; port=3306"

    Private Sub tellers()
        connecttodb() ' Assuming this is your database connection function

        ' Specify the ID you want to exclude
        Dim excludedID As Integer = 1 ' Replace 123 with the ID you want to exclude

        Dim sql As String = "SELECT teller_id AS 'Teller ID', teller_name AS 'Teller Name', description AS 'Description' FROM tellers WHERE teller_id <> @excludedID"
        Dim cmd As New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@excludedID", excludedID)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView1.DataSource = dataTable

        ' Close the connection 
        adapter.Dispose()
        cmd.Dispose()
        cn.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Form2_D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tellers()

        Panel3.Visible = False
        Panel3.BackColor = Color.FromArgb(0, Panel3.BackColor)

        Panel4.Visible = False
        Panel4.BackColor = Color.FromArgb(0, Panel3.BackColor)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not in the header row
        If e.RowIndex >= 0 Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(index)
            Label1.Text = selectedRow.Cells(0).Value.ToString()

            TextBox1.Text = selectedRow.Cells(1).Value.ToString()
            TextBox2.Text = selectedRow.Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        PictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteSelectedItems()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub DeleteSelectedItems()
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Ask for confirmation before deleting
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                connecttodb() ' Connect to database

                Try
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim tellerID As String = selectedRow.Cells(0).Value.ToString() ' Assuming teller_id is in the first column

                        ' SQL query to delete the selected row based on the teller_id
                        Dim sql As String = "DELETE FROM tellers WHERE teller_id = @tellerID"
                        Dim cmd As New MySqlCommand(sql, cn)
                        cmd.Parameters.AddWithValue("@tellerID", tellerID)

                        ' Execute the delete command
                        cmd.ExecuteNonQuery()

                        ' Remove the selected row from the DataGridView
                        DataGridView1.Rows.Remove(selectedRow)
                    Next
                Catch ex As Exception
                    MessageBox.Show("An error occurred while deleting rows: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Close database connections
                    cn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdateData()
        tellers()
    End Sub

    Private Sub UpdateData()
        ' Check if TextBox1 and TextBox2 have values
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim sql As String = "UPDATE tellers SET teller_name=@teller_name, description=@description WHERE teller_id = @teller_id"
                    Dim command As New MySqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@teller_name", TextBox1.Text)
                    command.Parameters.AddWithValue("@description", TextBox2.Text)
                    command.Parameters.AddWithValue("@teller_id", DataGridView1.SelectedRows(0).Cells(0).Value.ToString()) ' Assuming detail_id is in the first column
                    command.ExecuteNonQuery()
                End Using

                TextBox1.Clear()
                TextBox2.Clear()

                ' Show success message
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InsertData()
        tellers()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub InsertData()
        ' Check if TextBox3 and TextBox4 have values
        If String.IsNullOrWhiteSpace(TextBox3.Text) Or String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        connecttodb() ' Connect to database

        Try
            ' SQL query to insert data into the database
            Dim sql As String = "INSERT INTO tellers (teller_name, description) VALUES (@teller_name, @description)"
            Dim cmd As New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@teller_name", TextBox3.Text)
            cmd.Parameters.AddWithValue("@description", TextBox4.Text)

            ' Execute the insert command
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close database connections
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Panel3.Visible = True
            Panel3.BackColor = Color.FromArgb(100, Panel3.BackColor)
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Panel3.Visible = True
            Panel3.BackColor = Color.FromArgb(100, Panel3.BackColor)
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            Panel4.Visible = True
            Panel4.BackColor = Color.FromArgb(100, Panel4.BackColor)
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> "" Then
            Panel4.Visible = True
            Panel4.BackColor = Color.FromArgb(100, Panel4.BackColor)
        Else
            Panel4.Visible = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Check if the pressed key is a lowercase letter
        If Char.IsLower(e.KeyChar) Then
            ' Convert the lowercase letter to uppercase
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class