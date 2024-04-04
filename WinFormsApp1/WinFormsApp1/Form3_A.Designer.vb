<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3_A))
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Button5 = New Button()
        Label9 = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1887, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 48)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 39
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(186, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 45)
        Label1.TabIndex = 59
        Label1.Text = "#"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(377, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 45)
        Label2.TabIndex = 60
        Label2.Text = "#"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(570, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 45)
        Label3.TabIndex = 61
        Label3.Text = "#"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(300, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 45)
        Label5.TabIndex = 63
        Label5.Text = "ref number 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(300, 356)
        Label6.Name = "Label6"
        Label6.Size = New Size(215, 45)
        Label6.TabIndex = 64
        Label6.Text = "ref number 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(300, 452)
        Label7.Name = "Label7"
        Label7.Size = New Size(215, 45)
        Label7.TabIndex = 65
        Label7.Text = "ref number 3"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(340, 547)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 45)
        Label8.TabIndex = 66
        Label8.Text = "amount"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(1038, 156)
        Label10.Name = "Label10"
        Label10.Size = New Size(252, 45)
        Label10.TabIndex = 68
        Label10.Text = "merchant name"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(1047, 250)
        Label11.Name = "Label11"
        Label11.Size = New Size(221, 45)
        Label11.TabIndex = 69
        Label11.Text = "printed name"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.Maroon
        Button5.Location = New Point(12, 761)
        Button5.Name = "Button5"
        Button5.Size = New Size(268, 54)
        Button5.TabIndex = 70
        Button5.Text = "Print Slip"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(1229, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 45)
        Label9.TabIndex = 71
        Label9.Text = "date"
        ' 
        ' Form3_A
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1934, 827)
        Controls.Add(Label9)
        Controls.Add(Button5)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3_A"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3_A"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
End Class
