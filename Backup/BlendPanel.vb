Imports System.Drawing.Drawing2D
Public Class BlendPanel
    'Inherits System.Windows.Forms.UserControl
    Inherits System.Windows.Forms.Panel
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'BlendPanel
        '
        Me.Name = "BlendPanel"
        Me.Size = New System.Drawing.Size(167, 152)

    End Sub

#End Region
    Dim c1 As Color = Color.FromKnownColor(KnownColor.ControlLightLight)
    Dim c2 As Color = Color.FromKnownColor(KnownColor.Control)
    Dim ISVerti As Boolean = False

    Public Property ColorStart() As Color
        Get
            Return c1
        End Get
        Set(ByVal value As Color)
            Me.c1 = value
            Me.Refresh()
        End Set
    End Property
    Public Property ColorEnd() As Color
        Get
            Return c2
        End Get
        Set(ByVal value As Color)
            Me.c2 = value
            Me.Refresh()
        End Set
    End Property
    Public Property BlendType() As Boolean
        Get
            Return ISVerti
        End Get
        Set(ByVal value As Boolean)
            Me.ISVerti = value
            Me.Refresh()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Try
            Dim myrect As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim mypen As New Pen(Color.Transparent)
            Dim mybrushh As New LinearGradientBrush(myrect, c1, c2, LinearGradientMode.Horizontal)
            Dim mybrushv As New LinearGradientBrush(myrect, c1, c2, LinearGradientMode.Vertical)
            e.Graphics.DrawRectangle(mypen, myrect)
            If BlendType = True Then
                e.Graphics.FillRectangle(mybrushv, myrect)
            Else
                e.Graphics.FillRectangle(mybrushh, myrect)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BlendPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub
End Class
