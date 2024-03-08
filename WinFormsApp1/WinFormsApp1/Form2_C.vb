Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2_C

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

            TextBox1.Text = selectedRow.Cells(1).Value.ToString()
            TextBox2.Text = selectedRow.Cells(2).Value.ToString()
            TextBox3.Text = selectedRow.Cells(3).Value.ToString()

            TextBox4.Text = selectedRow.Cells(4).Value.ToString()
            TextBox5.Text = selectedRow.Cells(5).Value.ToString()
            TextBox6.Text = selectedRow.Cells(6).Value.ToString()
        End If
    End Sub
End Class