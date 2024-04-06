Imports System.Drawing.Printing

Public Class Form3_A

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

    Public Property Label4Text As String
        Get
            Return Label4.Text
        End Get
        Set(value As String)
            Label4.Text = value
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

    Public Property Label20Text As String
        Get
            Return Label20.Text
        End Get
        Set(value As String)
            Label20.Text = value
        End Set
    End Property

    Public Property Label21Text As String
        Get
            Return Label21.Text
        End Get
        Set(value As String)
            Label21.Text = value
        End Set
    End Property

    Public Property Label22Text As String
        Get
            Return Label22.Text
        End Get
        Set(value As String)
            Label22.Text = value
        End Set
    End Property

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Form3_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' create printdocument instance
        Dim pd As New PrintDocument

        ' set printer settings
        pd.DefaultPageSettings.PrinterSettings.PrinterName = "epson tm-h6000iv slip"
        pd.DefaultPageSettings.PaperSize = New PaperSize("custom", Convert.ToInt32(6.25 * 100), Convert.ToInt32(2.75 * 100)) ' size in hundredths of an inch (600 x 275)

        ' add printpage event handler
        AddHandler pd.PrintPage, AddressOf PrintContent

        ' start printing
        pd.Print()
    End Sub

    Private Sub PrintContent(sender As Object, e As PrintPageEventArgs)
        ' Define font and brush for drawing
        Dim font As New Font("Epilogue", 10)
        Dim font2 As New Font("Epilogue", 9)
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

        Dim label1X As Single = 109 ' account number
        Dim label1Y As Single = 395 ' 
        e.Graphics.DrawString(Label1.Text, font, brush, label1X, label1Y)
        y += lineHeight
        ' Adjust x and y coordinates for Label2
        Dim label2X As Single = 130 ' account number
        Dim label2Y As Single = 395 ' 
        e.Graphics.DrawString(Label2.Text, font, brush, label2X, label2Y)
        y += lineHeight
        ' Adjust x and y coordinates for Label3
        Dim label3X As Single = 155 ' account number
        Dim label3Y As Single = 395 '
        e.Graphics.DrawString(Label3.Text, font2, brush, label3X, label3Y)
        y += lineHeight

        Dim label14X As Single = 175 ' account number
        Dim label14Y As Single = 395 '
        e.Graphics.DrawString(Label14.Text, font2, brush, label14X, label14Y)
        y += lineHeight

        Dim label16X As Single = 210 ' account number
        Dim label16Y As Single = 395 '
        e.Graphics.DrawString(Label16.Text, font2, brush, label16X, label16Y)
        y += lineHeight

        Dim label17X As Single = 235 ' account number
        Dim label17Y As Single = 395 '
        e.Graphics.DrawString(Label17.Text, font2, brush, label17X, label17Y)
        y += lineHeight

        Dim label18X As Single = 255 ' account number
        Dim label18Y As Single = 395 '
        e.Graphics.DrawString(Label18.Text, font2, brush, label18X, label18Y)
        y += lineHeight

        Dim label19X As Single = 280 ' account number
        Dim label19Y As Single = 395 '
        e.Graphics.DrawString(Label19.Text, font2, brush, label19X, label19Y)
        y += lineHeight

        Dim label21X As Single = 310 ' account number
        Dim label21Y As Single = 395 '
        e.Graphics.DrawString(Label21.Text, font2, brush, label21X, label21Y)
        y += lineHeight

        Dim label22X As Single = 330 ' account number
        Dim label22Y As Single = 395 '
        e.Graphics.DrawString(Label22.Text, font2, brush, label22X, label22Y)
        y += lineHeight

        Dim label4X As Single = 100
        Dim label4Y As Single = 336 ' Radio button 3 - label4
        e.Graphics.DrawString(Label4.Text, font3, brush, label4X, label4Y)
        y += lineHeight

        Dim label12X As Single = 215
        Dim label12Y As Single = 336 ' Radio button 2 - label12
        e.Graphics.DrawString(Label12.Text, font3, brush, label12X, label12Y)
        y += lineHeight

        Dim label13X As Single = 350
        Dim label13Y As Single = 336 ' Radio button 1 - label13
        e.Graphics.DrawString(Label13.Text, font3, brush, label13X, label13Y)
        y += lineHeight

        Dim label5X As Single = 150 ' Adjust x coordinate for Label3
        Dim label5Y As Single = 445 ' Adjust y coordinate for Label3 /cashier name
        e.Graphics.DrawString(Label5.Text, font2, brush, label5X, label5Y)
        y += lineHeight

        Dim label6X As Single = 150 ' Adjust x coordinate for Label3
        Dim label6Y As Single = 485 ' Adjust y coordinate for Label3 /cashier designation
        e.Graphics.DrawString(Label6.Text, font2, brush, label6X, label6Y)
        y += lineHeight

        Dim label7x As Single = 150 ' adjust x coordinate for label3
        Dim label7y As Single = 525 ' adjust y coordinate for label3 / officer name
        e.Graphics.DrawString(Label7.Text, font2, brush, label7x, label7y)
        y += lineHeight

        Dim label8X As Single = 150 ' Adjust x coordinate for Label3
        Dim label8Y As Single = 560 ' Adjust y coordinate for Label3 / designation
        e.Graphics.DrawString(Label8.Text, font2, brush, label8X, label8Y)
        y += lineHeight

        Dim label9X As Single = 560 ' Adjust x coordinate for Label3
        Dim label9Y As Single = 350 ' Adjust y coordinate for Label3 / designation
        e.Graphics.DrawString(Label9.Text, font2, brush, label9X, label9Y)
        y += lineHeight

        Dim label10X As Single = 490 ' Adjust x coordinate for Label1
        Dim label10Y As Single = 390 ' Adjust y coordinate for Label1 /date
        e.Graphics.DrawString(Label10.Text, font, brush, label10X, label10Y)
        y += lineHeight

        Dim label11X As Single = 490 ' Adjust x coordinate for Label1
        Dim label11Y As Single = 440 ' Adjust y coordinate for Label1 /date
        e.Graphics.DrawString(Label11.Text, font, brush, label11X, label11Y)
        y += lineHeight

        ' Repeat for the remaining labels, adjusting x and y coordinates as needed

        ' Restore the graphics state to its original settings
        e.Graphics.Restore(oldState)
    End Sub

End Class