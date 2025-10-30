Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ModernButton
    Inherits Button

    Private _borderRadius As Integer = 10
    Private _borderColor As Color = Color.Gray
    Private _borderSize As Integer = 1
    Private _backgroundColor As Color = Color.FromArgb(52, 152, 219)
    Private _hoverColor As Color = Color.FromArgb(41, 128, 185)
    Private _textColor As Color = Color.White
    Private _isHovering As Boolean = False

    <Category("Appearance")> _
    Public Property BorderRadius() As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            _borderRadius = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property BorderSize() As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)
            _borderSize = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property BackgroundColor() As Color
        Get
            Return _backgroundColor
        End Get
        Set(ByVal value As Color)
            _backgroundColor = value
            Me.BackColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property HoverColor() As Color
        Get
            Return _hoverColor
        End Get
        Set(ByVal value As Color)
            _hoverColor = value
        End Set
    End Property

    <Category("Appearance")> _
    Public Property TextColor() As Color
        Get
            Return _textColor
        End Get
        Set(ByVal value As Color)
            _textColor = value
            Me.ForeColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.Size = New Size(150, 45)
        Me.BackColor = _backgroundColor
        Me.ForeColor = _textColor
        Me.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        _isHovering = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        _isHovering = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim g As Graphics = pevent.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As GraphicsPath = GetRoundPath(rect, _borderRadius)

        ' 🟠 This line makes the actual button shape rounded (not just drawn)
        Me.Region = New Region(path)

        ' Clear background behind the rounded edges
        g.Clear(Me.Parent.BackColor)

        ' Fill button background
        Using brush As New SolidBrush(If(_isHovering, _hoverColor, _backgroundColor))
            g.FillPath(brush, path)
        End Using

        ' Draw border if needed
        If _borderSize > 0 Then
            Using pen As New Pen(_borderColor, _borderSize)
                pen.Alignment = PenAlignment.Inset
                g.DrawPath(pen, path)
            End Using
        End If

        ' Draw centered text
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        Using textBrush As New SolidBrush(_textColor)
            g.DrawString(Me.Text, Me.Font, textBrush, rect, sf)
        End Using
    End Sub



    Private Function GetRoundPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        If radius <= 0 Then
            path.AddRectangle(rect)
            path.CloseFigure()
            Return path
        End If

        Dim diameter As Integer = radius * 2
        If diameter > rect.Height Then diameter = rect.Height
        If diameter > rect.Width Then diameter = rect.Width

        ' Use explicit parentheses and continuation lines for VB compatibility
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function

End Class
