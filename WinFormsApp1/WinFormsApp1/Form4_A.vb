Imports System.Drawing.Printing

Public Class Form4_A

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


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Form4_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim label1X As Single = 480 ' date
        Dim label1Y As Single = 360 ' 
        e.Graphics.DrawString(Label1.Text, font1, brush, label1X, label1Y)
        y += lineHeight

        Dim label2X As Single = 269 ' account number 1
        Dim label2Y As Single = 400 ' 
        e.Graphics.DrawString(Label2.Text, font, brush, label2X, label2Y)
        y += lineHeight

        Dim label3X As Single = 285 ' account number 2
        Dim label3Y As Single = 400 '
        e.Graphics.DrawString(Label3.Text, font, brush, label3X, label3Y)
        y += lineHeight

        Dim label4X As Single = 303 ' account number 3
        Dim label4Y As Single = 400 '
        e.Graphics.DrawString(Label4.Text, font, brush, label4X, label4Y)
        y += lineHeight

        Dim label5X As Single = 321 ' account number 4
        Dim label5Y As Single = 400 '
        e.Graphics.DrawString(Label5.Text, font, brush, label5X, label5Y)
        y += lineHeight

        Dim label6X As Single = 340 ' account number 5
        Dim label6Y As Single = 400 '
        e.Graphics.DrawString(Label6.Text, font, brush, label6X, label6Y)
        y += lineHeight

        Dim label7X As Single = 360 ' account number 6
        Dim label7Y As Single = 400 '
        e.Graphics.DrawString(Label7.Text, font, brush, label7X, label7Y)
        y += lineHeight

        Dim label8X As Single = 380 ' account number 7
        Dim label8Y As Single = 400 '
        e.Graphics.DrawString(Label8.Text, font, brush, label8X, label8Y)
        y += lineHeight

        Dim label9X As Single = 400 ' account number 8
        Dim label9Y As Single = 400 '
        e.Graphics.DrawString(Label9.Text, font, brush, label9X, label9Y)
        y += lineHeight

        Dim label10X As Single = 420 ' account number 9
        Dim label10Y As Single = 400 '
        e.Graphics.DrawString(Label10.Text, font, brush, label10X, label10Y)
        y += lineHeight

        Dim label11X As Single = 440 ' account number 10
        Dim label11Y As Single = 400 '
        e.Graphics.DrawString(Label11.Text, font, brush, label11X, label11Y)
        y += lineHeight

        Dim label12X As Single = 460 ' branch of account
        Dim label12Y As Single = 410 '
        e.Graphics.DrawString(Label12.Text, font3, brush, label12X, label12Y)
        y += lineHeight

        Dim label13X As Single = 275 ' peso radiobutton
        Dim label13Y As Single = 450 '
        e.Graphics.DrawString(Label13.Text, font2, brush, label13X, label13Y)
        y += lineHeight

        Dim label14X As Single = 275 ' euro radiobutton
        Dim label14Y As Single = 470 '
        e.Graphics.DrawString(Label14.Text, font2, brush, label14X, label14Y)
        y += lineHeight

        Dim label15X As Single = 355 ' jpy radiobutton
        Dim label15Y As Single = 450 '
        e.Graphics.DrawString(Label15.Text, font2, brush, label15X, label15Y)
        y += lineHeight

        Dim label16X As Single = 355 ' usd radiobutton
        Dim label16Y As Single = 470 '
        e.Graphics.DrawString(Label16.Text, font2, brush, label16X, label16Y)
        y += lineHeight

        Dim label17X As Single = 430 ' others radiobutton
        Dim label17Y As Single = 450 '
        e.Graphics.DrawString(Label17.Text, font2, brush, label17X, label17Y)
        y += lineHeight

        Dim label18X As Single = 480 ' other define
        Dim label18Y As Single = 455 '
        e.Graphics.DrawString(Label18.Text, font, brush, label18X, label18Y)
        y += lineHeight



        Dim label19X As Single = 310 ' total deposit
        Dim label19Y As Single = 505 '
        Dim maxLineWidth As Single = 200 ' Example maximum width for wrapping
        Dim lineSpacing As Single = -18 ' Example line spacing
        Dim labelText As String = Label19.Text
        Dim lines As New List(Of String)()
        Dim currentLine As String = ""

        ' Splitting the text into lines based on the maximum width
        For Each word As String In labelText.Split(" "c)
            If currentLine.Length + word.Length < 40 Then ' Checking if adding the word exceeds the maximum width
                currentLine &= word & " "
            Else
                lines.Add(currentLine.Trim()) ' Add the current line to the list of lines
                currentLine = word & " " ' Start a new line with the current word
            End If
        Next

        If currentLine.Trim() <> "" Then
            lines.Add(currentLine.Trim()) ' Add the last line if it's not empty
        End If

        ' Drawing each line separately
        Dim yPos As Single = label19Y
        For Each line As String In lines
            e.Graphics.DrawString(line, font3, brush, label19X, yPos)
            yPos += font.Height + lineSpacing ' Incrementing the Y position for the next line
        Next



        Dim label20X As Single = 320 ' in figures
        Dim label20Y As Single = 535 '
        e.Graphics.DrawString(Label20.Text, font, brush, label20X, label20Y)
        y += lineHeight

        Dim label21X As Single = 110 ' contact number
        Dim label21Y As Single = 550 '
        e.Graphics.DrawString(Label21.Text, font, brush, label21X, label21Y)
        y += lineHeight

        Dim label22X As Single = 285 ' account name
        Dim label22Y As Single = 360 '
        e.Graphics.DrawString(Label22.Text, font, brush, label22X, label22Y)
        y += lineHeight

        Dim label23X As Single = 60 ' depositor name
        Dim label23Y As Single = 475 '
        e.Graphics.DrawString(Label23.Text, font1, brush, label23X, label23Y)
        y += lineHeight

        ' Repeat for the remaining labels, adjusting x and y coordinates as needed

        ' Restore the graphics state to its original settings
        e.Graphics.Restore(oldState)
    End Sub

End Class