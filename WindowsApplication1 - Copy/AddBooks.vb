
Imports System.Data.SqlClient

Public Class AddBooks

    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=Library System Management;Integrated Security=True"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim title As String = txtTitle.Text.Trim()
        Dim author As String = txtAuthor.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()
        Dim year As String = txtYear.Text.Trim()


        If title = "" Or author = "" Or txtYear.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO [dbo].[Book] (Title, Author, Year_Publish, Genre) VALUES (@Title, @Author, @Year_Publish, @Genre)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Title", title)
                cmd.Parameters.AddWithValue("@Author", author)
                cmd.Parameters.AddWithValue("@Year_Publish", year)
                cmd.Parameters.AddWithValue("@Genre", genre)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtTitle.Clear()
                    txtAuthor.Clear()
                    txtYear.Clear()
                    txtGenre.Clear()

                Catch ex As Exception
                    MessageBox.Show("Error saving user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
