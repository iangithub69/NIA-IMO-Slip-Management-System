Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form2_E

    Private connectionString As String = "server=localhost; user id =root; password=2020301243; database=slipsdb; port=3306"

    Private Sub officers()
        connecttodb() ' Assuming this is your database connection function

        ' Specify the ID you want to exclude
        Dim excludedID As Integer = 1 ' Replace 123 with the ID you want to exclude

        Dim sql As String = "SELECT officer_id AS 'Officer ID', officer_name AS 'Officer Name', description AS 'Description', branch AS 'Branch' FROM officers WHERE officer_id <> @excludedID"
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

    Private Sub Form2_E_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        officers()
    End Sub
End Class