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
        Dim excludedID As Integer = 999999 ' Replace 123 with the ID you want to exclude

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
    End Sub

    Private Sub DeleteSelectedItems()
        If DataGridView1.SelectedRows.Count > 0 Then
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
        Else
            MessageBox.Show("Please select rows to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpdateData()
        tellers()
    End Sub

    Private Sub UpdateData()
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
    End Sub

    Private Sub InsertData()
        Try

            connecttodb()
            'Insert data into the database
            sql = "Insert into tellers (teller_name, description) values (@teller_name, @description)"
            cmd = New MySqlCommand(sql, cn)

            With cmd
                ' Set parameters for the database insertion
                '.Parameters.AddWithValue("@session_id", CStr(Int(Rnd() * 100)))
                .Parameters.AddWithValue("@teller_name", TextBox3.Text)
                .Parameters.AddWithValue("@description", TextBox4.Text)

                ' Execute the database insertion
                .ExecuteReader()
            End With

            ' Close database connections
            dr = Nothing
            cmd.Dispose()
            cn.Close()

            ' Show success message
            MessageBox.Show("Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class