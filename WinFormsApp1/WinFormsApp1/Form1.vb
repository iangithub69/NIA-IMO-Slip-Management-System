Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class Form1

    'Private Sub LoadDetails() 'this is where the refresh button is declared
    '    connecttodb() 'Connect to database

    '    sql = "SELECT * FROM fertigation_table" 'Selecting all information on the table
    '    'sql = "SELECT * FROM userccounts" 'online database
    '    cmd = New MySqlCommand(sql, cn)
    '    dr = cmd.ExecuteReader

    '    ListView1.Items.Clear()


    '    While dr.Read

    '        'This will show to listview
    '        'values must be identical to database table

    '        newLine = ListView1.Items.Add(dr("session_id"))
    '        newLine.SubItems.Add(dr("connection_name"))
    '        newLine.SubItems.Add(dr("device_name"))
    '        newLine.SubItems.Add(dr("os_info"))

    '        newLine.SubItems.Add(dr("rtc_time"))
    '        newLine.SubItems.Add(dr("rtc_date"))

    '        newLine.SubItems.Add(dr("water_level"))
    '        newLine.SubItems.Add(dr("temp_level"))

    '        newLine.SubItems.Add(dr("load1_status"))
    '        newLine.SubItems.Add(dr("load1_hourOn"))
    '        newLine.SubItems.Add(dr("load1_minuteOn"))
    '        newLine.SubItems.Add(dr("load1_hourOff"))
    '        newLine.SubItems.Add(dr("load1_minuteOff"))

    '        newLine.SubItems.Add(dr("load2_status"))
    '        newLine.SubItems.Add(dr("load2_hourOn"))
    '        newLine.SubItems.Add(dr("load2_minuteOn"))
    '        newLine.SubItems.Add(dr("load2_hourOff"))
    '        newLine.SubItems.Add(dr("load2_minuteOff"))

    '        newLine.SubItems.Add(dr("load3_status"))
    '        newLine.SubItems.Add(dr("load3_hourOn"))
    '        newLine.SubItems.Add(dr("load3_minuteOn"))
    '        newLine.SubItems.Add(dr("load3_hourOff"))
    '        newLine.SubItems.Add(dr("load3_minuteOff"))

    '        newLine.SubItems.Add(dr("load4_status"))
    '        newLine.SubItems.Add(dr("load4_hourOn"))
    '        newLine.SubItems.Add(dr("load4_minuteOn"))
    '        newLine.SubItems.Add(dr("load4_hourOff"))
    '        newLine.SubItems.Add(dr("load4_minuteOff"))

    '        newLine.SubItems.Add(dr("login_time"))

    '        newLine.SubItems.Add(dr("rain_sensor"))
    '        newLine.SubItems.Add(dr("day_counter"))

    '        newLine.SubItems.Add(dr("fdevice_name"))
    '        newLine.SubItems.Add(dr("version"))
    '    End While
    '    'i dont know what this is
    '    cmd = Nothing
    '    dr.Close()
    '    cn.Close()
    '    ' Assuming ListView1 is your ListView control
    '    Dim i As Integer = 0

    '    For Each item As ListViewItem In ListView1.Items
    '        If i Mod 2 = 0 Then
    '            item.BackColor = Drawing.Color.PowderBlue
    '            item.UseItemStyleForSubItems = True
    '        End If
    '        i += 1
    '    Next

    'End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class
