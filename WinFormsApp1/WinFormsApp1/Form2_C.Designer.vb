<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2_C))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label10 = New Label()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2835, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(57, 57)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(2772, 1176)
        DataGridView1.TabIndex = 40
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(2030, 1268)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(453, 50)
        TextBox1.TabIndex = 41
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(382, 1271)
        Label1.Name = "Label1"
        Label1.Size = New Size(29, 45)
        Label1.TabIndex = 47
        Label1.Text = "."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(227, 1271)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 45)
        Label2.TabIndex = 48
        Label2.Text = "Detail ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(1785, 1271)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 45)
        Label3.TabIndex = 49
        Label3.Text = "Check Number:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(437, 1352)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(453, 50)
        TextBox2.TabIndex = 50
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(227, 1352)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 45)
        Label4.TabIndex = 51
        Label4.Text = "Acc Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(987, 1355)
        Label5.Name = "Label5"
        Label5.Size = New Size(238, 45)
        Label5.TabIndex = 52
        Label5.Text = "Account Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(1231, 1352)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(453, 50)
        TextBox3.TabIndex = 53
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(1855, 1355)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 45)
        Label6.TabIndex = 54
        Label6.Text = "Issued On:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(2030, 1355)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(453, 50)
        TextBox4.TabIndex = 55
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(1882, 1441)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 45)
        Label7.TabIndex = 56
        Label7.Text = "Amount:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(2030, 1438)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(453, 50)
        TextBox5.TabIndex = 57
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(437, 1513)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(1587, 50)
        TextBox6.TabIndex = 58
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(250, 1485)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 45)
        Label8.TabIndex = 59
        Label8.Text = "Pay To The"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(437, 1598)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(1587, 50)
        TextBox7.TabIndex = 60
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(320, 1601)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 45)
        Label9.TabIndex = 61
        Label9.Text = "Pesos"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.icons8_check_48
        Button1.Location = New Point(2168, 1530)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 58)
        Button1.TabIndex = 62
        Button1.Text = "Update"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Image = My.Resources.Resources.icons8_cancel_48
        Button2.Location = New Point(2393, 1530)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 58)
        Button2.TabIndex = 63
        Button2.Text = "Cancel"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(266, 1530)
        Label10.Name = "Label10"
        Label10.Size = New Size(145, 45)
        Label10.TabIndex = 64
        Label10.Text = "Order Of"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Image = My.Resources.Resources.icons8_copy_to_clipboard_45
        Button3.Location = New Point(2168, 1612)
        Button3.Name = "Button3"
        Button3.Size = New Size(418, 58)
        Button3.TabIndex = 65
        Button3.Text = "Copy to Clipboard"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2_C
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2882, 1703)
        Controls.Add(Button3)
        Controls.Add(Label10)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2_C"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2_C"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
End Class
