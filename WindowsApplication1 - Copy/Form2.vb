Imports System.Data.SqlClient
Imports System.IO

Public Class Form2
    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=Library System Management;Integrated Security=True"

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadRecentStudents()
        LoadRecentBooks()
    End Sub

    ' 🧑‍🎓 Load recently added students (max 3)
    Private Sub LoadRecentStudents()
        PanelRecentStudents.Controls.Clear()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT TOP 3 StudentID, Name, Course, StudentImage FROM Student ORDER BY StudentID DESC"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim xOffset As Integer = 10
            While reader.Read()
                Dim card As New Panel()
                card.Width = 180
                card.Height = 220
                card.Left = xOffset
                card.Top = 10
                card.BackColor = Color.WhiteSmoke
                card.BorderStyle = BorderStyle.FixedSingle

                ' 🖼️ Student image
                Dim pic As New PictureBox()
                pic.Width = 120
                pic.Height = 120
                pic.Top = 10
                pic.Left = 30
                pic.SizeMode = PictureBoxSizeMode.Zoom

                If Not IsDBNull(reader("StudentImage")) Then
                    Dim imgBytes As Byte() = DirectCast(reader("StudentImage"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        pic.Image = Image.FromStream(ms)
                    End Using
                End If

                ' 👤 Student name
                Dim lblName As New Label()
                lblName.Text = reader("StudentName").ToString()
                lblName.Top = 135
                lblName.Left = 10
                lblName.Width = 160
                lblName.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                lblName.TextAlign = ContentAlignment.MiddleCenter

                ' 🎓 Course
                Dim lblCourse As New Label()
                lblCourse.Text = reader("Course").ToString()
                lblCourse.Top = 160
                lblCourse.Left = 10
                lblCourse.Width = 160
                lblCourse.Font = New Font("Segoe UI", 8, FontStyle.Regular)
                lblCourse.TextAlign = ContentAlignment.MiddleCenter

                card.Controls.Add(pic)
                card.Controls.Add(lblName)
                card.Controls.Add(lblCourse)
                PanelRecentStudents.Controls.Add(card)

                xOffset += 190
            End While
        End Using
    End Sub

    ' 📚 Load recently added books (max 3)
    Private Sub LoadRecentBooks()
        PanelRecentBooks.Controls.Clear()

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT TOP 3 BookID, Title, Author, YearPublished, Genre, CoverImage FROM Book ORDER BY BookID DESC"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim xOffset As Integer = 10
            While reader.Read()
                Dim card As New Panel()
                card.Width = 180
                card.Height = 220
                card.Left = xOffset
                card.Top = 10
                card.BackColor = Color.WhiteSmoke
                card.BorderStyle = BorderStyle.FixedSingle

                ' 📖 Book cover
                Dim pic As New PictureBox()
                pic.Width = 120
                pic.Height = 120
                pic.Top = 10
                pic.Left = 30
                pic.SizeMode = PictureBoxSizeMode.Zoom

                If Not IsDBNull(reader("CoverImage")) Then
                    Dim imgBytes As Byte() = DirectCast(reader("CoverImage"), Byte())
                    Using ms As New MemoryStream(imgBytes)
                        pic.Image = Image.FromStream(ms)
                    End Using
                End If

                ' 📚 Book title
                Dim lblTitle As New Label()
                lblTitle.Text = reader("Title").ToString()
                lblTitle.Top = 135
                lblTitle.Left = 10
                lblTitle.Width = 160
                lblTitle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                lblTitle.TextAlign = ContentAlignment.MiddleCenter

                ' ✍️ Author
                Dim lblAuthor As New Label()
                lblAuthor.Text = reader("Author").ToString()
                lblAuthor.Top = 160
                lblAuthor.Left = 10
                lblAuthor.Width = 160
                lblAuthor.Font = New Font("Segoe UI", 8, FontStyle.Regular)
                lblAuthor.TextAlign = ContentAlignment.MiddleCenter

                card.Controls.Add(pic)
                card.Controls.Add(lblTitle)
                card.Controls.Add(lblAuthor)
                PanelRecentBooks.Controls.Add(card)

                xOffset += 190
            End While
        End Using
    End Sub
End Class
