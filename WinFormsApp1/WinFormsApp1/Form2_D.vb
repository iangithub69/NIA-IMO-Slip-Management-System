Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form2_D

    Private connectionString As String = "server=localhost; user id =root; password=2020301243; database=slipsdb; port=3306"

    Private Sub tellers()
        connecttodb() ' Assuming this is your database connection function

        ' Specify the ID you want to exclude
        Dim excludedID As Integer = 4 ' Replace 123 with the ID you want to exclude

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

End Class