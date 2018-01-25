Imports System.Drawing.Drawing2D
Public Class TaskControl
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(145, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 19)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "^"
        '
        'TaskControl
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Label1})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TaskControl"
        Me.Size = New System.Drawing.Size(170, 138)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private TpLabel1 As String = "Taskpane"
    Private IsExpanded As Boolean = False
    Private oldheight As Integer = 100
    Public Property HeaderText() As String
        Get
            Return TpLabel1
        End Get
        Set(ByVal value As String)
            TpLabel1 = value
            Label1.Text = TpLabel1
            Me.Refresh()
        End Set
    End Property
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsExpanded = False Then
            Button1.Text = "v"
            IsExpanded = True
            oldheight = Me.Height
            Me.Height = 32
            Exit Sub
        End If
        If IsExpanded = True Then
            IsExpanded = False
            Button1.Text = "^"
            Me.Height = oldheight
            Exit Sub
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If IsExpanded = False Then
            Button1.Text = "v"
            IsExpanded = True
            oldheight = Me.Height
            Me.Height = 32
            Exit Sub
        End If
        If IsExpanded = True Then
            IsExpanded = False
            Button1.Text = "^"
            Me.Height = oldheight
            Exit Sub
        End If
    End Sub

    Private Sub TaskControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Refresh()
    End Sub

    Private Sub TaskControl_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim c1 As Color = Color.White
        Dim c2 As Color = Color.FromArgb(197, 209, 244)
        Dim myrect1 As New Rectangle(0, 0, Me.Width, 32)
        Dim mypen1 As New Pen(Color.Transparent)
        Dim mybrush1 As New LinearGradientBrush(myrect1, c1, c2, LinearGradientMode.Horizontal)
        e.Graphics.DrawRectangle(mypen1, myrect1)
        e.Graphics.FillRectangle(mybrush1, myrect1)
        Dim mypen2 As New Pen(Color.White, 1)
        Dim myrect2 As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        e.Graphics.DrawRectangle(mypen2, myrect2)
        Me.BackColor = Color.FromArgb(214, 223, 247)
    End Sub
End Class
