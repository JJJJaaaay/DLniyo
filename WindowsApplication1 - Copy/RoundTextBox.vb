﻿Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class RoundTextBox
    Inherits UserControl

    Private WithEvents innerTextBox As New TextBox()
    Private _placeholderText As String = "Enter text..."
    Private _borderRadius As Integer = 15
    Public Property UseSystemPasswordChar() As Boolean
        Get
            Return innerTextBox.UseSystemPasswordChar
        End Get
        Set(ByVal value As Boolean)
            innerTextBox.UseSystemPasswordChar = value
        End Set
    End Property

    Public Sub New()
        Me.DoubleBuffered = True
        Me.BackColor = Color.White
        Me.Padding = New Padding(5)

        innerTextBox.BorderStyle = BorderStyle.None
        innerTextBox.Dock = DockStyle.Fill
        innerTextBox.ForeColor = Color.Black
        innerTextBox.BackColor = Color.White

        Me.Controls.Add(innerTextBox)
        AddHandler Me.Load, AddressOf RoundTextBox_Load
    End Sub

    Private Sub RoundTextBox_Load(ByVal sender As Object, ByVal e As EventArgs)
        SetPlaceholder()
    End Sub


    <Category("Appearance")> _
    Public Property PlaceholderText() As String
        Get
            Return _placeholderText
        End Get
        Set(ByVal value As String)
            _placeholderText = value
            SetPlaceholder()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property BorderRadius() As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            _borderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")> _
    Public Property TextValue() As String
        Get
            If innerTextBox.ForeColor = Color.Gray Then
                Return ""
            Else
                Return innerTextBox.Text
            End If
        End Get
        Set(ByVal value As String)
            innerTextBox.Text = value
        End Set
    End Property

    <Category("Appearance")> _
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return innerTextBox.TextAlign
        End Get
        Set(ByVal value As HorizontalAlignment)
            innerTextBox.TextAlign = value
        End Set
    End Property



    Private Sub innerTextBox_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles innerTextBox.GotFocus
        If innerTextBox.Text = _placeholderText AndAlso innerTextBox.ForeColor = Color.Gray Then
            innerTextBox.Text = ""
            innerTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub innerTextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles innerTextBox.LostFocus
        SetPlaceholder()
    End Sub

    Private Sub SetPlaceholder()
        If innerTextBox.Text Is Nothing OrElse innerTextBox.Text.Trim() = "" Then
            innerTextBox.Text = _placeholderText
            innerTextBox.ForeColor = Color.Gray
        End If
    End Sub



    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)


        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic


        Dim rect As RectangleF = New RectangleF(0, 0, Me.Width - 1, Me.Height - 1)
        Dim path As New GraphicsPath()
        Dim radius As Single = _borderRadius
        Dim diameter As Single = radius * 2


        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()


        Me.Region = New Region(path)

        e.Graphics.Clear(Me.Parent.BackColor)


        Using brush As New SolidBrush(Me.BackColor)
            e.Graphics.FillPath(brush, path)
        End Using


        Using pen As New Pen(Color.Gray, 1.6F)
            pen.Alignment = PenAlignment.Inset
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub





End Class
