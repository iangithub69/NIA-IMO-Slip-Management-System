Imports System.Drawing.Printing

Public Class Form5_A

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

    Public Property Label23Text As String
        Get
            Return Label23.Text
        End Get
        Set(value As String)
            Label23.Text = value
        End Set
    End Property

    Public Property Label24Text As String
        Get
            Return Label24.Text
        End Get
        Set(value As String)
            Label24.Text = value
        End Set
    End Property

    Public Property Label25Text As String
        Get
            Return Label25.Text
        End Get
        Set(value As String)
            Label25.Text = value
        End Set
    End Property

    Public Property Label26Text As String
        Get
            Return Label26.Text
        End Get
        Set(value As String)
            Label26.Text = value
        End Set
    End Property

    Public Property Label27Text As String
        Get
            Return Label27.Text
        End Get
        Set(value As String)
            Label27.Text = value
        End Set
    End Property

    Public Property Label28Text As String
        Get
            Return Label28.Text
        End Get
        Set(value As String)
            Label28.Text = value
        End Set
    End Property

    Public Property Label29Text As String
        Get
            Return Label29.Text
        End Get
        Set(value As String)
            Label29.Text = value
        End Set
    End Property

    Public Property Label30Text As String
        Get
            Return Label30.Text
        End Get
        Set(value As String)
            Label30.Text = value
        End Set
    End Property

    Public Property Label31Text As String
        Get
            Return Label31.Text
        End Get
        Set(value As String)
            Label31.Text = value
        End Set
    End Property

    'Public Property Label32Text As String
    '    Get
    '        Return Label32.Text
    '    End Get
    '    Set(value As String)
    '        Label32.Text = value
    '    End Set
    'End Property

    'Public Property Label33Text As String
    '    Get
    '        Return Label33.Text
    '    End Get
    '    Set(value As String)
    '        Label33.Text = value
    '    End Set
    'End Property

    Public Property Label34Text As String
        Get
            Return Label34.Text
        End Get
        Set(value As String)
            Label34.Text = value
        End Set
    End Property

    Public Property Label35Text As String
        Get
            Return Label35.Text
        End Get
        Set(value As String)
            Label35.Text = value
        End Set
    End Property

    Public Property Label36Text As String
        Get
            Return Label36.Text
        End Get
        Set(value As String)
            Label36.Text = value
        End Set
    End Property

    Public Property Label37Text As String
        Get
            Return Label37.Text
        End Get
        Set(value As String)
            Label37.Text = value
        End Set
    End Property

    Public Property Label38Text As String
        Get
            Return Label38.Text
        End Get
        Set(value As String)
            Label38.Text = value
        End Set
    End Property

    Public Property Label39Text As String
        Get
            Return Label39.Text
        End Get
        Set(value As String)
            Label39.Text = value
        End Set
    End Property

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Form5_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' create printdocument instance
        Dim pd As New PrintDocument

        ' set printer settings
        pd.DefaultPageSettings.PrinterSettings.PrinterName = "epson tm-h6000iv slipe4"
        'pd.DefaultPageSettings.PrinterSettings.PrinterName = "epson tm-h6000iv slip"
        pd.DefaultPageSettings.PaperSize = New PaperSize("custom", Convert.ToInt32(6.25 * 100), Convert.ToInt32(2.75 * 100)) ' size in hundredths of an inch (600 x 275)

        ' add printpage event handler
        AddHandler pd.PrintPage, AddressOf PrintContent

        ' start printing
        pd.Print()
    End Sub

    Private Sub PrintContent(sender As Object, e As PrintPageEventArgs)
        ' Define font and brush for drawing
        Dim font As New Font("Epilogue", 10)
        Dim font1 As New Font("Epilogue", 9)
        Dim font2 As New Font("Epilogue", 15, FontStyle.Bold)
        Dim font3 As New Font("Epilogue", 7)
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

        Dim label1X As Single = 45 ' account # 1
        Dim label1Y As Single = 400 ' 
        e.Graphics.DrawString(Label1.Text, font, brush, label1X, label1Y)
        y += lineHeight

        Dim label2X As Single = 60 ' account # 2
        Dim label2Y As Single = 400 ' 
        e.Graphics.DrawString(Label2.Text, font, brush, label2X, label2Y)
        y += lineHeight

        Dim label3X As Single = 85 ' account # 3
        Dim label3Y As Single = 400 ' 
        e.Graphics.DrawString(Label3.Text, font, brush, label3X, label3Y)
        y += lineHeight

        Dim label4X As Single = 100 ' account # 4
        Dim label4Y As Single = 400 ' 
        e.Graphics.DrawString(Label4.Text, font, brush, label4X, label4Y)
        y += lineHeight

        Dim label5X As Single = 125 ' account # 5
        Dim label5Y As Single = 400 ' 
        e.Graphics.DrawString(Label5.Text, font, brush, label5X, label5Y)
        y += lineHeight

        Dim label6X As Single = 145 ' account # 6
        Dim label6Y As Single = 400 ' 
        e.Graphics.DrawString(Label6.Text, font, brush, label6X, label6Y)
        y += lineHeight

        Dim label7X As Single = 165 ' account # 7
        Dim label7Y As Single = 400 ' 
        e.Graphics.DrawString(Label7.Text, font, brush, label7X, label7Y)
        y += lineHeight

        Dim label8X As Single = 185 ' account # 8
        Dim label8Y As Single = 400 ' 
        e.Graphics.DrawString(Label8.Text, font, brush, label8X, label8Y)
        y += lineHeight

        Dim label9X As Single = 200 ' account # 9
        Dim label9Y As Single = 400 ' 
        e.Graphics.DrawString(Label9.Text, font, brush, label9X, label9Y)
        y += lineHeight

        Dim label10X As Single = 220 ' account # 10
        Dim label10Y As Single = 400 ' 
        e.Graphics.DrawString(Label10.Text, font, brush, label10X, label10Y)
        y += lineHeight

        Dim label11X As Single = 260 ' branch of account
        Dim label11Y As Single = 400 ' 
        e.Graphics.DrawString(Label11.Text, font, brush, label11X, label11Y)
        y += lineHeight

        Dim label12X As Single = 100 ' depositor/representative
        Dim label12Y As Single = 500 ' 
        e.Graphics.DrawString(Label12.Text, font, brush, label12X, label12Y)
        y += lineHeight

        Dim label13X As Single = 145 ' contact number
        Dim label13Y As Single = 550 ' 
        e.Graphics.DrawString(Label13.Text, font, brush, label13X, label13Y)
        y += lineHeight

        Dim label14X As Single = 410 ' On-Us
        Dim label14Y As Single = 350 ' 
        e.Graphics.DrawString(Label14.Text, font2, brush, label14X, label14Y)
        y += lineHeight

        Dim label15X As Single = 290 ' date
        Dim label15Y As Single = 350 ' 
        e.Graphics.DrawString(Label15.Text, font, brush, label15X, label15Y)
        y += lineHeight

        Dim label16X As Single = 485 ' other bank
        Dim label16Y As Single = 350 ' 
        e.Graphics.DrawString(Label16.Text, font2, brush, label16X, label16Y)
        y += lineHeight

        Dim label17X As Single = 570 ' cts
        Dim label17Y As Single = 320 ' 
        e.Graphics.DrawString(Label17.Text, font, brush, label17X, label17Y)
        y += lineHeight

        Dim label18X As Single = 420 ' name of bank # 1
        Dim label18Y As Single = 410 ' 
        e.Graphics.DrawString(Label18.Text, font, brush, label18X, label18Y)
        y += lineHeight

        Dim label19X As Single = 510 ' check number # 1
        Dim label19Y As Single = 410 ' 
        e.Graphics.DrawString(Label19.Text, font, brush, label19X, label19Y)
        y += lineHeight

        Dim label20X As Single = 585 ' amount # 1
        Dim label20Y As Single = 410 ' 
        e.Graphics.DrawString(Label20.Text, font, brush, label20X, label20Y)
        y += lineHeight

        Dim label21X As Single = 420 ' name of bank # 2
        Dim label21Y As Single = 425 ' 
        e.Graphics.DrawString(Label21.Text, font, brush, label21X, label21Y)
        y += lineHeight

        Dim label23X As Single = 510 ' check number # 2
        Dim label23Y As Single = 425 ' 
        e.Graphics.DrawString(Label23.Text, font, brush, label23X, label23Y)
        y += lineHeight

        Dim label24X As Single = 585 ' amount # 2
        Dim label24Y As Single = 425 ' 
        e.Graphics.DrawString(Label24.Text, font, brush, label24X, label24Y)
        y += lineHeight

        Dim label30X As Single = 420 ' name of bank # 3
        Dim label30Y As Single = 445 ' 
        e.Graphics.DrawString(Label30.Text, font, brush, label30X, label30Y)
        y += lineHeight

        Dim label29X As Single = 510 ' check number # 3
        Dim label29Y As Single = 445 ' 
        e.Graphics.DrawString(Label29.Text, font, brush, label29X, label29Y)
        y += lineHeight

        Dim label28X As Single = 585 ' amount # 3
        Dim label28Y As Single = 445 ' 
        e.Graphics.DrawString(Label28.Text, font, brush, label28X, label28Y)
        y += lineHeight

        Dim label27X As Single = 420 ' name of bank # 4
        Dim label27Y As Single = 460 ' 
        e.Graphics.DrawString(Label27.Text, font, brush, label27X, label27Y)
        y += lineHeight

        Dim label26X As Single = 510 ' check number # 4
        Dim label26Y As Single = 460 ' 
        e.Graphics.DrawString(Label26.Text, font, brush, label26X, label26Y)
        y += lineHeight

        Dim label25X As Single = 585 ' amount # 4
        Dim label25Y As Single = 460 ' 
        e.Graphics.DrawString(Label25.Text, font, brush, label25X, label25Y)
        y += lineHeight

        Dim label36X As Single = 420 ' name of bank # 5
        Dim label36Y As Single = 475 ' 
        e.Graphics.DrawString(Label36.Text, font, brush, label36X, label36Y)
        y += lineHeight

        Dim label35X As Single = 510 ' check number # 5
        Dim label35Y As Single = 475 ' 
        e.Graphics.DrawString(Label35.Text, font, brush, label35X, label35Y)
        y += lineHeight

        Dim label34X As Single = 585 ' amount # 5
        Dim label34Y As Single = 475 ' 
        e.Graphics.DrawString(Label34.Text, font, brush, label34X, label34Y)
        y += lineHeight

        Dim label39X As Single = 420 ' name of bank # 6
        Dim label39Y As Single = 495 ' 
        e.Graphics.DrawString(Label39.Text, font, brush, label39X, label39Y)
        y += lineHeight

        Dim label38X As Single = 510 ' check number # 6
        Dim label38Y As Single = 495 ' 
        e.Graphics.DrawString(Label38.Text, font, brush, label38X, label38Y)
        y += lineHeight

        Dim label37X As Single = 585 ' amount # 6
        Dim label37Y As Single = 495 ' 
        e.Graphics.DrawString(Label37.Text, font, brush, label37X, label37Y)
        y += lineHeight

        Dim label31X As Single = 585 ' amount # 7
        Dim label31Y As Single = 550 ' 
        e.Graphics.DrawString(Label31.Text, font, brush, label31X, label31Y)
        y += lineHeight


        ' Repeat for the remaining labels, adjusting x and y coordinates as needed

        ' Restore the graphics state to its original settings
        e.Graphics.Restore(oldState)
    End Sub

End Class