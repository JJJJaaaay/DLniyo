<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.RoundPictureBox1 = New WindowsApplication1.RoundPictureBox
        Me.PanelRecentStudents = New System.Windows.Forms.Panel
        Me.PanelRecentBooks = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(12, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 320)
        Me.Panel1.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel10.Location = New System.Drawing.Point(3, 278)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(194, 39)
        Me.Panel10.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel9.Location = New System.Drawing.Point(3, 233)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(194, 39)
        Me.Panel9.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Location = New System.Drawing.Point(3, 188)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(194, 39)
        Me.Panel8.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Location = New System.Drawing.Point(3, 143)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(194, 39)
        Me.Panel7.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Location = New System.Drawing.Point(3, 98)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(194, 39)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Location = New System.Drawing.Point(3, 53)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(194, 39)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Location = New System.Drawing.Point(224, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(548, 113)
        Me.Panel4.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Recently Added Student"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Silver
        Me.Panel12.Controls.Add(Me.Label1)
        Me.Panel12.Location = New System.Drawing.Point(511, 147)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(261, 29)
        Me.Panel12.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recently Added Book"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Silver
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Location = New System.Drawing.Point(224, 147)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(261, 29)
        Me.Panel11.TabIndex = 2
        '
        'RoundPictureBox1
        '
        Me.RoundPictureBox1.BackgroundImage = CType(resources.GetObject("RoundPictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.RoundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RoundPictureBox1.Location = New System.Drawing.Point(40, 12)
        Me.RoundPictureBox1.Name = "RoundPictureBox1"
        Me.RoundPictureBox1.Size = New System.Drawing.Size(142, 96)
        Me.RoundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RoundPictureBox1.TabIndex = 3
        Me.RoundPictureBox1.TabStop = False
        '
        'PanelRecentStudents
        '
        Me.PanelRecentStudents.BackColor = System.Drawing.Color.LightGray
        Me.PanelRecentStudents.Location = New System.Drawing.Point(224, 198)
        Me.PanelRecentStudents.Name = "PanelRecentStudents"
        Me.PanelRecentStudents.Size = New System.Drawing.Size(261, 248)
        Me.PanelRecentStudents.TabIndex = 2
        '
        'PanelRecentBooks
        '
        Me.PanelRecentBooks.BackColor = System.Drawing.Color.LightGray
        Me.PanelRecentBooks.Location = New System.Drawing.Point(511, 198)
        Me.PanelRecentBooks.Name = "PanelRecentBooks"
        Me.PanelRecentBooks.Size = New System.Drawing.Size(261, 248)
        Me.PanelRecentBooks.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.PanelRecentBooks)
        Me.Controls.Add(Me.PanelRecentStudents)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.RoundPictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RoundPictureBox1 As WindowsApplication1.RoundPictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents PanelRecentStudents As System.Windows.Forms.Panel
    Friend WithEvents PanelRecentBooks As System.Windows.Forms.Panel
End Class
