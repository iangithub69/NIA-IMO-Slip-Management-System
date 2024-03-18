
Imports System.Drawing.Printing
Imports System.Windows.Forms.PrintPreviewDialog

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

        Try
            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to print to actual check? if so, please insert check to printer accordingly", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Define font and brush for drawing
                Dim font As New Font("Epilogue", 10)
                Dim font2 As New Font("Epilogue", 9)
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

                Dim label1X As Single = 580 ' Adjust x coordinate for Label1
                Dim label1Y As Single = 310 ' Adjust y coordinate for Label1 /date
                e.Graphics.DrawString(Label1.Text, font, brush, label1X, label1Y)
                y += lineHeight
                ' Adjust x and y coordinates for Label2
                Dim label2X As Single = 585 ' Adjust x coordinate for Label2
                Dim label2Y As Single = 340 ' Adjust y coordinate for Label2 /amount
                e.Graphics.DrawString(Label2.Text, font, brush, label2X, label2Y)
                y += lineHeight
                ' Adjust x and y coordinates for Label3
                Dim label3X As Single = 80 ' Adjust x coordinate for Label3
                Dim label3Y As Single = 340 ' Adjust y coordinate for Label3 /pay to
                e.Graphics.DrawString(Label3.Text, font2, brush, label3X, label3Y)
                y += lineHeight

                Dim label4X As Single = 50 ' Adjust x coordinate for Label3
                Dim label4Y As Single = 370 ' Adjust y coordinate for Label3 /pesos
                e.Graphics.DrawString(Label4.Text, font2, brush, label4X, label4Y)
                y += lineHeight

                Dim label5X As Single = 330 ' Adjust x coordinate for Label3
                Dim label5Y As Single = 460 ' Adjust y coordinate for Label3 /cashier name
                e.Graphics.DrawString(Label5.Text, font2, brush, label5X, label5Y)
                y += lineHeight

                Dim label6X As Single = 330 ' Adjust x coordinate for Label3
                Dim label6Y As Single = 477 ' Adjust y coordinate for Label3 /cashier designation
                e.Graphics.DrawString(Label6.Text, font2, brush, label6X, label6Y)
                y += lineHeight

                Dim label7x As Single = 530 ' adjust x coordinate for label3
                Dim label7y As Single = 460 ' adjust y coordinate for label3 / officer name
                e.Graphics.DrawString(Label7.Text, font2, brush, label7x, label7y)
                y += lineHeight

                Dim label8X As Single = 530 ' Adjust x coordinate for Label3
                Dim label8Y As Single = 477 ' Adjust y coordinate for Label3 / designation
                e.Graphics.DrawString(Label8.Text, font2, brush, label8X, label8Y)
                y += lineHeight

                Dim label9X As Single = 530 ' Adjust x coordinate for Label3
                Dim label9Y As Single = 498 ' Adjust y coordinate for Label3 branch
                e.Graphics.DrawString(Label9.Text, font2, brush, label9X, label9Y)
                y += lineHeight
                ' Repeat for the remaining labels, adjusting x and y coordinates as needed

                ' Restore the graphics state to its original settings
                e.Graphics.Restore(oldState)

            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()

    End Sub
End Class