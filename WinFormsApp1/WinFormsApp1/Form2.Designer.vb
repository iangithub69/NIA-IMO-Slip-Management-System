<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox8 = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        TextBox9 = New TextBox()
        Label15 = New Label()
        TextBox10 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        PictureBox1 = New PictureBox()
        TextBox5 = New TextBox()
        PictureBox8 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label1.Location = New Point(511, 7)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(454, 54)
        Label1.TabIndex = 0
        Label1.Text = "CHECK PROGRAM SLIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(-18, 52)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(1440, 25)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label3.Location = New Point(109, 118)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 30)
        Label3.TabIndex = 2
        Label3.Text = "ID:"
        Label3.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(162, 117)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(154, 34)
        TextBox1.TabIndex = 3
        TextBox1.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label4.Location = New Point(23, 167)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 30)
        Label4.TabIndex = 4
        Label4.Text = "Account No:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(162, 167)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(346, 34)
        TextBox2.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label5.Location = New Point(506, 116)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 30)
        Label5.TabIndex = 6
        Label5.Text = "Choose Account:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(688, 116)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 36)
        ComboBox1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label6.Location = New Point(520, 167)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(165, 30)
        Label6.TabIndex = 8
        Label6.Text = "Account Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(688, 167)
        TextBox3.Margin = New Padding(2, 2, 2, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(346, 34)
        TextBox3.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label7.Location = New Point(1039, 113)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 30)
        Label7.TabIndex = 10
        Label7.Text = "Check No:"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(1155, 113)
        TextBox4.Margin = New Padding(2, 2, 2, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(296, 34)
        TextBox4.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label8.Location = New Point(1085, 167)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 30)
        Label8.TabIndex = 12
        Label8.Text = "Date:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label9.Location = New Point(1184, 203)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 30)
        Label9.TabIndex = 16
        Label9.Text = "Month"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label10.Location = New Point(1279, 203)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 30)
        Label10.TabIndex = 17
        Label10.Text = "Day"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label11.Location = New Point(1355, 203)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 30)
        Label11.TabIndex = 18
        Label11.Text = "Year"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label12.Location = New Point(1052, 266)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 30)
        Label12.TabIndex = 19
        Label12.Text = "Amount:"
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(1155, 264)
        TextBox8.Margin = New Padding(2, 2, 2, 2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(296, 34)
        TextBox8.TabIndex = 20
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label13.Location = New Point(23, 317)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 30)
        Label13.TabIndex = 21
        Label13.Text = "PAY TO THE"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label14.Location = New Point(38, 346)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(122, 30)
        Label14.TabIndex = 22
        Label14.Text = "ORDER OF:"
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox9.BorderStyle = BorderStyle.FixedSingle
        TextBox9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(163, 334)
        TextBox9.Margin = New Padding(2, 2, 2, 2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(936, 39)
        TextBox9.TabIndex = 23
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Label15.Location = New Point(76, 404)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 30)
        Label15.TabIndex = 24
        Label15.Text = "PESOS:"
        ' 
        ' TextBox10
        ' 
        TextBox10.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox10.BorderStyle = BorderStyle.FixedSingle
        TextBox10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox10.Location = New Point(163, 397)
        TextBox10.Margin = New Padding(2, 2, 2, 2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(1288, 39)
        TextBox10.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(162, 483)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(345, 42)
        Button1.TabIndex = 26
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(9, 502)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 42)
        Button2.TabIndex = 27
        Button2.Text = "Add Record"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(163, 548)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(344, 42)
        Button3.TabIndex = 28
        Button3.Text = "View Check Issued"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(521, 547)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(206, 42)
        Button4.TabIndex = 29
        Button4.Text = "Print Duplicate"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(84), CByte(154), CByte(21))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(521, 483)
        Button5.Margin = New Padding(2, 2, 2, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(206, 42)
        Button5.TabIndex = 30
        Button5.Text = "Print Check"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(763, 481)
        ComboBox2.Margin = New Padding(2, 2, 2, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(336, 40)
        ComboBox2.TabIndex = 31
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(763, 548)
        ComboBox3.Margin = New Padding(2, 2, 2, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(336, 40)
        ComboBox3.TabIndex = 32
        ' 
        ' ComboBox4
        ' 
        ComboBox4.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(1115, 464)
        ComboBox4.Margin = New Padding(2, 2, 2, 2)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(336, 40)
        ComboBox4.TabIndex = 33
        ' 
        ' ComboBox5
        ' 
        ComboBox5.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(1115, 523)
        ComboBox5.Margin = New Padding(2, 2, 2, 2)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(336, 40)
        ComboBox5.TabIndex = 34
        ' 
        ' ComboBox6
        ' 
        ComboBox6.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        ComboBox6.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(1115, 580)
        ComboBox6.Margin = New Padding(2, 2, 2, 2)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(336, 40)
        ComboBox6.TabIndex = 35
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1452, 0)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.FromArgb(CByte(220), CByte(239), CByte(197))
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(1155, 167)
        TextBox5.Margin = New Padding(2, 2, 2, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(268, 34)
        TextBox5.TabIndex = 37
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Cursor = Cursors.Hand
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(1428, 168)
        PictureBox8.Margin = New Padding(2, 2, 2, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(23, 33)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 38
        PictureBox8.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(250), CByte(236))
        ClientSize = New Size(1488, 646)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox5)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox10)
        Controls.Add(Label15)
        Controls.Add(TextBox9)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(TextBox8)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 2, 2, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
