Imports System.Drawing.Drawing2D
Public Class RoundPictureBox
    Inherits PictureBox

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub
    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim g As GraphicsPath = New GraphicsPath()
        g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(g)
    End Sub
End Class
