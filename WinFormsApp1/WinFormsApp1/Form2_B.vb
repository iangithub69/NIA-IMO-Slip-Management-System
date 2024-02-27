
Imports System.Drawing.Printing
Public Class Form2_B

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Form2_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim font As New Font("Arial", 10)
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

        ' Draw labels on the page with adjusted layout
        e.Graphics.DrawString(Label1.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label2.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label3.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label4.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label5.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label6.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label7.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label8.Text, font, brush, x, y)
        y += lineHeight
        e.Graphics.DrawString(Label9.Text, font, brush, x, y)

        ' Restore the graphics state to its original settings
        e.Graphics.Restore(oldState)
    End Sub

End Class