Imports System.Drawing.Printing

Public Class Form3_C

    Public Property Label1Text As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property

    Public Property Label2Text As String
        Get
            Return Label2.Text
        End Get
        Set(value As String)
            Label2.Text = value
        End Set
    End Property

    Public Property Label3Text As String
        Get
            Return Label3.Text
        End Get
        Set(value As String)
            Label3.Text = value
        End Set
    End Property

    Public Property Label4Text As String
        Get
            Return Label4.Text
        End Get
        Set(value As String)
            Label4.Text = value
        End Set
    End Property

    Public Property Label5Text As String
        Get
            Return Label5.Text
        End Get
        Set(value As String)
            Label5.Text = value
        End Set
    End Property

    Public Property Label6Text As String
        Get
            Return Label6.Text
        End Get
        Set(value As String)
            Label6.Text = value
        End Set
    End Property

    Public Property Label7Text As String
        Get
            Return Label7.Text
        End Get
        Set(value As String)
            Label7.Text = value
        End Set
    End Property

    Public Property Label8Text As String
        Get
            Return Label8.Text
        End Get
        Set(value As String)
            Label8.Text = value
        End Set
    End Property

    Public Property Label9Text As String
        Get
            Return Label9.Text
        End Get
        Set(value As String)
            Label9.Text = value
        End Set
    End Property

    Public Property Label10Text As String
        Get
            Return Label10.Text
        End Get
        Set(value As String)
            Label10.Text = value
        End Set
    End Property

    Public Property Label11Text As String
        Get
            Return Label11.Text
        End Get
        Set(value As String)
            Label11.Text = value
        End Set
    End Property

    Public Property Label12Text As String
        Get
            Return Label12.Text
        End Get
        Set(value As String)
            Label12.Text = value
        End Set
    End Property

    Public Property Label13Text As String
        Get
            Return Label13.Text
        End Get
        Set(value As String)
            Label13.Text = value
        End Set
    End Property

    Public Property Label14Text As String
        Get
            Return Label14.Text
        End Get
        Set(value As String)
            Label14.Text = value
        End Set
    End Property

    Public Property Label15Text As String
        Get
            Return Label15.Text
        End Get
        Set(value As String)
            Label15.Text = value
        End Set
    End Property

    Public Property Label16Text As String
        Get
            Return Label16.Text
        End Get
        Set(value As String)
            Label16.Text = value
        End Set
    End Property

    Public Property Label17Text As String
        Get
            Return Label17.Text
        End Get
        Set(value As String)
            Label17.Text = value
        End Set
    End Property

    Public Property Label18Text As String
        Get
            Return Label18.Text
        End Get
        Set(value As String)
            Label18.Text = value
        End Set
    End Property

    Public Property Label19Text As String
        Get
            Return Label19.Text
        End Get
        Set(value As String)
            Label19.Text = value
        End Set
    End Property

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Form3_C_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' create printdocument instance
        Dim pd As New PrintDocument

        ' set printer settings
        pd.DefaultPageSettings.PrinterSettings.PrinterName = "epson tm-h6000iv slipe4"
        ' pd.DefaultPageSettings.PrinterSettings.PrinterName = "epson tm-h6000iv slip"
        pd.DefaultPageSettings.PaperSize = New PaperSize("custom", Convert.ToInt32(6.25 * 100), Convert.ToInt32(2.75 * 100)) ' size in hundredths of an inch (600 x 275)

        ' add printpage event handler
        AddHandler pd.PrintPage, AddressOf PrintContent

        ' start printing
        pd.Print()
    End Sub

    Private Sub PrintContent(sender As Object, e As PrintPageEventArgs)
        ' Define font and brush for drawing
        Dim font As New Font("Epilogue", 10)
        Dim font1 As New Font("Epilogue", 8)
        Dim font2 As New Font("Epilogue", 12)
        Dim font3 As New Font("Epilogue", 20, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        ' Define positions for labels
        Dim x As Single = 110 ' Adjust the x position based on your layout
        Dim y As Single = 300 ' Adjust the starting y position
        Dim lineHeight As Single = font.GetHeight()

        ' Save the current graphics state to restore it later
        Dim oldState As Drawing2D.GraphicsState = e.Graphics.Save()

        ' Rotate the graphics context 90 degrees clockwise
        e.Graphics.RotateTransform(90)

        ' Translate to adjust for the rotation (swap width and height)
        e.Graphics.TranslateTransform(0, -e.PageBounds.Width)

        Dim label1X As Single = 30 ' pieces 1
        Dim label1Y As Single = 345 ' 
        e.Graphics.DrawString(Label1.Text, font, brush, label1X, label1Y)
        y += lineHeight

        Dim label2X As Single = 30 ' pieces 2
        Dim label2Y As Single = 365 ' 
        e.Graphics.DrawString(Label2.Text, font, brush, label2X, label2Y)
        y += lineHeight

        Dim label3X As Single = 30 ' pieces 3
        Dim label3Y As Single = 390 '
        e.Graphics.DrawString(Label3.Text, font, brush, label3X, label3Y)
        y += lineHeight

        Dim label4X As Single = 30 ' pieces 4
        Dim label4Y As Single = 415 '
        e.Graphics.DrawString(Label4.Text, font, brush, label4X, label4Y)
        y += lineHeight

        Dim label5X As Single = 30 ' pieces 5
        Dim label5Y As Single = 440 '
        e.Graphics.DrawString(Label5.Text, font, brush, label5X, label5Y)
        y += lineHeight

        Dim label6X As Single = 30 ' pieces 6
        Dim label6Y As Single = 460 '
        e.Graphics.DrawString(Label6.Text, font, brush, label6X, label6Y)
        y += lineHeight

        Dim label7X As Single = 30 ' pieces 7
        Dim label7Y As Single = 485 '
        e.Graphics.DrawString(Label7.Text, font, brush, label7X, label7Y)
        y += lineHeight

        Dim label8X As Single = 360 ' branch
        Dim label8Y As Single = 315 '
        e.Graphics.DrawString(Label8.Text, font, brush, label8X, label8Y)
        y += lineHeight

        Dim label9X As Single = 370 ' check number
        Dim label9Y As Single = 360 '
        e.Graphics.DrawString(Label9.Text, font, brush, label9X, label9Y)
        y += lineHeight

        Dim label10X As Single = 530 ' amount
        Dim label10Y As Single = 360 '
        e.Graphics.DrawString(Label10.Text, font, brush, label10X, label10Y)
        y += lineHeight

        Dim label11X As Single = 390 ' address
        Dim label11Y As Single = 480 '
        e.Graphics.DrawString(Label11.Text, font1, brush, label11X, label11Y)
        y += lineHeight

        Dim label12X As Single = 375 ' tel
        Dim label12Y As Single = 505 '
        e.Graphics.DrawString(Label12.Text, font, brush, label12X, label12Y)
        y += lineHeight

        Dim label13X As Single = 530 ' date
        Dim label13Y As Single = 505 '
        e.Graphics.DrawString(Label13.Text, font, brush, label13X, label13Y)
        y += lineHeight

        Dim label14X As Single = 180 ' account name
        Dim label14Y As Single = 570 '
        e.Graphics.DrawString(Label14.Text, font, brush, label14X, label14Y)
        y += lineHeight

        Dim label15X As Single = 445 ' account number
        Dim label15Y As Single = 570 '
        e.Graphics.DrawString(Label15.Text, font, brush, label15X, label15Y)
        y += lineHeight

        Dim label16X As Single = 580 ' amount
        Dim label16Y As Single = 570 '
        e.Graphics.DrawString(Label16.Text, font, brush, label16X, label16Y)
        y += lineHeight

        Dim label17X As Single = 180 ' checked by
        Dim label17Y As Single = 635 '
        e.Graphics.DrawString(Label17.Text, font1, brush, label17X, label17Y)
        y += lineHeight

        Dim label18X As Single = 355 ' approved by
        Dim label18Y As Single = 635 '
        e.Graphics.DrawString(Label18.Text, font1, brush, label18X, label18Y)
        y += lineHeight

        Dim label19X As Single = 510 ' posted by
        Dim label19Y As Single = 635 '
        e.Graphics.DrawString(Label19.Text, font1, brush, label19X, label19Y)
        y += lineHeight

        ' Repeat for the remaining labels, adjusting x and y coordinates as needed

        ' Restore the graphics state to its original settings
        e.Graphics.Restore(oldState)
    End Sub

End Class