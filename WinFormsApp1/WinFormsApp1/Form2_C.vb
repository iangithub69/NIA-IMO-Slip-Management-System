Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form2_C

    Private Sub details()
        connecttodb() ' Assuming this is your database connection function

        Dim sql As String = "SELECT * FROM details"
        Dim cmd As New MySqlCommand(sql, cn)

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView1.DataSource = dataTable

        ' Close the connection
        adapter.Dispose()
        cmd.Dispose()
        cn.Close()

        ' Alternate row coloring
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Index Mod 2 = 0 Then
                ' Set RGB coordinates for the color
                Dim red As Integer = 0 ' Red component
                Dim green As Integer = 128 ' Green component
                Dim blue As Integer = 0 ' Blue component
                row.DefaultCellStyle.BackColor = Color.FromArgb(4, 153, 53)
            End If
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Form2_C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        details()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class