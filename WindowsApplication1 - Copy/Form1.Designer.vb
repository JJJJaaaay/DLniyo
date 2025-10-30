<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblLtitle = New System.Windows.Forms.Label
        Me.lblLusername = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRemind = New System.Windows.Forms.Label
        Me.btnSubmit = New WindowsApplication1.ModernButton
        Me.txtPassword = New WindowsApplication1.RoundTextBox
        Me.txtUsername = New WindowsApplication1.RoundTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(837, 411)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = ""
        '
        'lblLtitle
        '
        Me.lblLtitle.AutoSize = True
        Me.lblLtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblLtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLtitle.Location = New System.Drawing.Point(114, 61)
        Me.lblLtitle.Name = "lblLtitle"
        Me.lblLtitle.Size = New System.Drawing.Size(75, 32)
        Me.lblLtitle.TabIndex = 1
        Me.lblLtitle.Text = "Login"
        '
        'lblLusername
        '
        Me.lblLusername.AutoSize = True
        Me.lblLusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblLusername.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLusername.ForeColor = System.Drawing.Color.IndianRed
        Me.lblLusername.Location = New System.Drawing.Point(48, 107)
        Me.lblLusername.Name = "lblLusername"
        Me.lblLusername.Size = New System.Drawing.Size(141, 16)
        Me.lblLusername.TabIndex = 3
        Me.lblLusername.Text = "Enter Your Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(48, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Your Password"
        '
        'lblRemind
        '
        Me.lblRemind.AutoSize = True
        Me.lblRemind.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblRemind.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemind.ForeColor = System.Drawing.Color.IndianRed
        Me.lblRemind.Location = New System.Drawing.Point(52, 234)
        Me.lblRemind.Name = "lblRemind"
        Me.lblRemind.Size = New System.Drawing.Size(0, 16)
        Me.lblRemind.TabIndex = 11
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSubmit.BorderColor = System.Drawing.Color.Gray
        Me.btnSubmit.BorderRadius = 20
        Me.btnSubmit.BorderSize = 0
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverColor = System.Drawing.Color.Tomato
        Me.btnSubmit.Location = New System.Drawing.Point(51, 234)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(220, 30)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Login"
        Me.btnSubmit.TextColor = System.Drawing.Color.White
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderRadius = 13
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(51, 197)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(5)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.Size = New System.Drawing.Size(220, 31)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.TextValue = ""
        Me.txtPassword.UseSystemPasswordChar = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderRadius = 13
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(51, 126)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(5)
        Me.txtUsername.PlaceholderText = "Enter Your Username"
        Me.txtUsername.Size = New System.Drawing.Size(220, 29)
        Me.txtUsername.TabIndex = 8
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsername.TextValue = ""
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 411)
        Me.Controls.Add(Me.lblRemind)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLusername)
        Me.Controls.Add(Me.lblLtitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLtitle As System.Windows.Forms.Label
    Friend WithEvents lblLusername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As WindowsApplication1.RoundTextBox
    Friend WithEvents txtPassword As WindowsApplication1.RoundTextBox
    Friend WithEvents btnSubmit As WindowsApplication1.ModernButton
    Friend WithEvents lblRemind As System.Windows.Forms.Label

End Class
