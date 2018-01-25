'Mail me at guruparan@hotmail.com or 
'guruparan@rediffmail.com
'Visit my web at http://www.geocities.com/gurusted
'And I Blog at http://spaces.msn.com/members/guruparan
'Copyright and terms of use notice at
'http://www.geocities.com/gurusted/codeuse.html

Option Explicit On 
Imports System.IO
Imports System.Threading
Imports Audio
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents PanelTop1 As System.Windows.Forms.Panel
    Friend WithEvents PanelBottom1 As System.Windows.Forms.Panel
    Friend WithEvents BlendPanelLeft1 As MyComputer.BlendPanel
    Friend WithEvents PanelFiller1 As System.Windows.Forms.Panel
    Friend WithEvents PanelL1 As System.Windows.Forms.Panel
    Friend WithEvents PanelL2 As System.Windows.Forms.Panel
    Friend WithEvents PanelT1 As System.Windows.Forms.Panel
    Friend WithEvents TaskControl1 As MyComputer.TaskControl
    Friend WithEvents PanelT2 As System.Windows.Forms.Panel
    Friend WithEvents TaskControl2 As MyComputer.TaskControl
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BlendPanel2 As MyComputer.BlendPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents ilMain As System.Windows.Forms.ImageList
    Friend WithEvents cm1 As System.Windows.Forms.ContextMenu
    Public WithEvents ilSmall As System.Windows.Forms.ImageList
    Friend WithEvents tmTimer As System.Timers.Timer
    Public WithEvents tvTreeView As System.Windows.Forms.TreeView
    Friend WithEvents spSplitter As System.Windows.Forms.Splitter
    Public WithEvents lvListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Public WithEvents sbStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents PanelWbTop1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblpath As System.Windows.Forms.TextBox
    Friend WithEvents wb1 As AxSHDocVw.AxWebBrowser
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents button1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents addr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents PanelTemp1 As System.Windows.Forms.Panel
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents tbtype As System.Windows.Forms.TextBox
    Friend WithEvents tbmodified As System.Windows.Forms.TextBox
    Friend WithEvents tbsize As System.Windows.Forms.TextBox
    Friend WithEvents it As System.Windows.Forms.TextBox
    Friend WithEvents mnufile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuopen As System.Windows.Forms.MenuItem
    Friend WithEvents mnusep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuexit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuhelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuabout As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TaskControl3 As MyComputer.TaskControl
    Friend WithEvents adfilename As System.Windows.Forms.Label
    Friend WithEvents adfiletype As System.Windows.Forms.Label
    Friend WithEvents adfilesize As System.Windows.Forms.Label
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbfilename As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Four", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "One", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "OneTwo"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "OneThree"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "OneFour")}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Three", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Two", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Me.PanelTop1 = New System.Windows.Forms.Panel()
        Me.BlendPanel2 = New MyComputer.BlendPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblpath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBottom1 = New System.Windows.Forms.Panel()
        Me.sbStatusBar = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.BlendPanelLeft1 = New MyComputer.BlendPanel()
        Me.tbfilename = New System.Windows.Forms.TextBox()
        Me.TaskControl3 = New MyComputer.TaskControl()
        Me.img1 = New System.Windows.Forms.PictureBox()
        Me.adfilesize = New System.Windows.Forms.Label()
        Me.adfiletype = New System.Windows.Forms.Label()
        Me.adfilename = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTemp1 = New System.Windows.Forms.Panel()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.tbtype = New System.Windows.Forms.TextBox()
        Me.tbmodified = New System.Windows.Forms.TextBox()
        Me.tbsize = New System.Windows.Forms.TextBox()
        Me.it = New System.Windows.Forms.TextBox()
        Me.TaskControl2 = New MyComputer.TaskControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelT2 = New System.Windows.Forms.Panel()
        Me.TaskControl1 = New MyComputer.TaskControl()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PanelT1 = New System.Windows.Forms.Panel()
        Me.PanelL2 = New System.Windows.Forms.Panel()
        Me.PanelL1 = New System.Windows.Forms.Panel()
        Me.PanelFiller1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.cm1 = New System.Windows.Forms.ContextMenu()
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.ilSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.spSplitter = New System.Windows.Forms.Splitter()
        Me.tvTreeView = New System.Windows.Forms.TreeView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.wb1 = New AxSHDocVw.AxWebBrowser()
        Me.PanelWbTop1 = New System.Windows.Forms.Panel()
        Me.addr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmTimer = New System.Timers.Timer()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnufile = New System.Windows.Forms.MenuItem()
        Me.mnuopen = New System.Windows.Forms.MenuItem()
        Me.mnusep1 = New System.Windows.Forms.MenuItem()
        Me.mnuexit = New System.Windows.Forms.MenuItem()
        Me.mnuhelp = New System.Windows.Forms.MenuItem()
        Me.mnuabout = New System.Windows.Forms.MenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelTop1.SuspendLayout()
        Me.BlendPanel2.SuspendLayout()
        Me.PanelBottom1.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlendPanelLeft1.SuspendLayout()
        Me.TaskControl3.SuspendLayout()
        Me.PanelTemp1.SuspendLayout()
        Me.TaskControl2.SuspendLayout()
        Me.TaskControl1.SuspendLayout()
        Me.PanelFiller1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.wb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelWbTop1.SuspendLayout()
        CType(Me.tmTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop1
        '
        Me.PanelTop1.Controls.AddRange(New System.Windows.Forms.Control() {Me.BlendPanel2})
        Me.PanelTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop1.Name = "PanelTop1"
        Me.PanelTop1.Size = New System.Drawing.Size(852, 35)
        Me.PanelTop1.TabIndex = 1
        '
        'BlendPanel2
        '
        Me.BlendPanel2.BlendType = False
        Me.BlendPanel2.ColorEnd = System.Drawing.SystemColors.Control
        Me.BlendPanel2.ColorStart = System.Drawing.SystemColors.ControlLightLight
        Me.BlendPanel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.lblpath, Me.Label1})
        Me.BlendPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BlendPanel2.Location = New System.Drawing.Point(0, 2)
        Me.BlendPanel2.Name = "BlendPanel2"
        Me.BlendPanel2.Size = New System.Drawing.Size(852, 33)
        Me.BlendPanel2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(18, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hide Taskpane"
        '
        'lblpath
        '
        Me.lblpath.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.lblpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpath.Location = New System.Drawing.Point(205, 7)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.ReadOnly = True
        Me.lblpath.Size = New System.Drawing.Size(641, 21)
        Me.lblpath.TabIndex = 2
        Me.lblpath.Text = "Click on the Harddrives listed below in My computer Tab to explore"
        '
        'Label1
        '
        Me.Label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(146, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Address:"
        '
        'PanelBottom1
        '
        Me.PanelBottom1.Controls.AddRange(New System.Windows.Forms.Control() {Me.sbStatusBar})
        Me.PanelBottom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom1.Location = New System.Drawing.Point(0, 628)
        Me.PanelBottom1.Name = "PanelBottom1"
        Me.PanelBottom1.Size = New System.Drawing.Size(852, 23)
        Me.PanelBottom1.TabIndex = 2
        '
        'sbStatusBar
        '
        Me.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sbStatusBar.Name = "sbStatusBar"
        Me.sbStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.sbStatusBar.ShowPanels = True
        Me.sbStatusBar.Size = New System.Drawing.Size(852, 23)
        Me.sbStatusBar.SizingGrip = False
        Me.sbStatusBar.TabIndex = 17
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Width = 652
        '
        'BlendPanelLeft1
        '
        Me.BlendPanelLeft1.AutoScroll = True
        Me.BlendPanelLeft1.BlendType = True
        Me.BlendPanelLeft1.ColorEnd = System.Drawing.Color.DodgerBlue
        Me.BlendPanelLeft1.ColorStart = System.Drawing.Color.LightSkyBlue
        Me.BlendPanelLeft1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbfilename, Me.TaskControl3, Me.Label3, Me.PanelTemp1, Me.TaskControl2, Me.PanelT2, Me.TaskControl1, Me.PanelT1, Me.PanelL2, Me.PanelL1})
        Me.BlendPanelLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BlendPanelLeft1.Location = New System.Drawing.Point(0, 35)
        Me.BlendPanelLeft1.Name = "BlendPanelLeft1"
        Me.BlendPanelLeft1.Size = New System.Drawing.Size(201, 593)
        Me.BlendPanelLeft1.TabIndex = 3
        '
        'tbfilename
        '
        Me.tbfilename.Location = New System.Drawing.Point(20, 541)
        Me.tbfilename.Name = "tbfilename"
        Me.tbfilename.TabIndex = 9
        Me.tbfilename.Text = "null"
        Me.tbfilename.Visible = False
        '
        'TaskControl3
        '
        Me.TaskControl3.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.TaskControl3.Controls.AddRange(New System.Windows.Forms.Control() {Me.img1, Me.adfilesize, Me.adfiletype, Me.adfilename})
        Me.TaskControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TaskControl3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskControl3.HeaderText = "Details"
        Me.TaskControl3.Location = New System.Drawing.Point(11, 283)
        Me.TaskControl3.Name = "TaskControl3"
        Me.TaskControl3.Size = New System.Drawing.Size(180, 212)
        Me.TaskControl3.TabIndex = 8
        '
        'img1
        '
        Me.img1.Location = New System.Drawing.Point(27, 108)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(121, 96)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img1.TabIndex = 5
        Me.img1.TabStop = False
        '
        'adfilesize
        '
        Me.adfilesize.Location = New System.Drawing.Point(8, 88)
        Me.adfilesize.Name = "adfilesize"
        Me.adfilesize.Size = New System.Drawing.Size(148, 14)
        Me.adfilesize.TabIndex = 4
        Me.adfilesize.Text = "File Size"
        '
        'adfiletype
        '
        Me.adfiletype.Location = New System.Drawing.Point(8, 65)
        Me.adfiletype.Name = "adfiletype"
        Me.adfiletype.Size = New System.Drawing.Size(161, 15)
        Me.adfiletype.TabIndex = 3
        Me.adfiletype.Text = "Filetype"
        '
        'adfilename
        '
        Me.adfilename.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adfilename.Location = New System.Drawing.Point(5, 43)
        Me.adfilename.Name = "adfilename"
        Me.adfilename.Size = New System.Drawing.Size(163, 19)
        Me.adfilename.TabIndex = 2
        Me.adfilename.Text = "Filename"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(11, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 16)
        Me.Label3.TabIndex = 7
        '
        'PanelTemp1
        '
        Me.PanelTemp1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Text1, Me.tbtype, Me.tbmodified, Me.tbsize, Me.it})
        Me.PanelTemp1.Location = New System.Drawing.Point(84, 410)
        Me.PanelTemp1.Name = "PanelTemp1"
        Me.PanelTemp1.Size = New System.Drawing.Size(98, 31)
        Me.PanelTemp1.TabIndex = 6
        Me.PanelTemp1.Visible = False
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(64, 7)
        Me.Text1.Name = "Text1"
        Me.Text1.TabIndex = 2
        Me.Text1.Text = "TextBox1"
        Me.Text1.Visible = False
        '
        'tbtype
        '
        Me.tbtype.Location = New System.Drawing.Point(132, 7)
        Me.tbtype.Name = "tbtype"
        Me.tbtype.TabIndex = 4
        Me.tbtype.Text = "TextBox1"
        '
        'tbmodified
        '
        Me.tbmodified.Location = New System.Drawing.Point(5, 21)
        Me.tbmodified.Name = "tbmodified"
        Me.tbmodified.TabIndex = 5
        Me.tbmodified.Text = "TextBox1"
        '
        'tbsize
        '
        Me.tbsize.Location = New System.Drawing.Point(302, 10)
        Me.tbsize.Name = "tbsize"
        Me.tbsize.TabIndex = 3
        Me.tbsize.Text = "TextBox1"
        '
        'it
        '
        Me.it.Location = New System.Drawing.Point(218, 11)
        Me.it.Name = "it"
        Me.it.TabIndex = 1
        Me.it.Text = "TextBox1"
        Me.it.Visible = False
        '
        'TaskControl2
        '
        Me.TaskControl2.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.TaskControl2.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox2, Me.PictureBox1, Me.Button7, Me.Button6, Me.Button5, Me.Button4, Me.Button3})
        Me.TaskControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TaskControl2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskControl2.HeaderText = "Musicplayer Tasks"
        Me.TaskControl2.Location = New System.Drawing.Point(11, 130)
        Me.TaskControl2.Name = "TaskControl2"
        Me.TaskControl2.Size = New System.Drawing.Size(180, 137)
        Me.TaskControl2.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(87, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Location = New System.Drawing.Point(11, 70)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(61, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "&Resume"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(122, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "&Stop"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(62, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(53, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "P&ause"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(9, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Play"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(81, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Open a File..."
        '
        'PanelT2
        '
        Me.PanelT2.BackColor = System.Drawing.Color.Transparent
        Me.PanelT2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT2.Enabled = False
        Me.PanelT2.Location = New System.Drawing.Point(11, 115)
        Me.PanelT2.Name = "PanelT2"
        Me.PanelT2.Size = New System.Drawing.Size(180, 15)
        Me.PanelT2.TabIndex = 4
        '
        'TaskControl1
        '
        Me.TaskControl1.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.TaskControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.LinkLabel2, Me.LinkLabel1})
        Me.TaskControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TaskControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskControl1.HeaderText = "File Folder Tasks"
        Me.TaskControl1.Location = New System.Drawing.Point(11, 13)
        Me.TaskControl1.Name = "TaskControl1"
        Me.TaskControl1.Size = New System.Drawing.Size(180, 102)
        Me.TaskControl1.TabIndex = 3
        '
        'LinkLabel2
        '
        Me.LinkLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LinkLabel2.Image = CType(resources.GetObject("LinkLabel2.Image"), System.Drawing.Bitmap)
        Me.LinkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(11, 72)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(159, 22)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Play Selected File"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel2.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), System.Drawing.Bitmap)
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(11, 43)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Open Selected File"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelT1
        '
        Me.PanelT1.BackColor = System.Drawing.Color.Transparent
        Me.PanelT1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT1.Location = New System.Drawing.Point(11, 0)
        Me.PanelT1.Name = "PanelT1"
        Me.PanelT1.Size = New System.Drawing.Size(180, 13)
        Me.PanelT1.TabIndex = 2
        '
        'PanelL2
        '
        Me.PanelL2.BackColor = System.Drawing.Color.Transparent
        Me.PanelL2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelL2.Location = New System.Drawing.Point(191, 0)
        Me.PanelL2.Name = "PanelL2"
        Me.PanelL2.Size = New System.Drawing.Size(10, 593)
        Me.PanelL2.TabIndex = 1
        '
        'PanelL1
        '
        Me.PanelL1.BackColor = System.Drawing.Color.Transparent
        Me.PanelL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelL1.Name = "PanelL1"
        Me.PanelL1.Size = New System.Drawing.Size(11, 593)
        Me.PanelL1.TabIndex = 0
        '
        'PanelFiller1
        '
        Me.PanelFiller1.AutoScroll = True
        Me.PanelFiller1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1})
        Me.PanelFiller1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFiller1.Location = New System.Drawing.Point(201, 35)
        Me.PanelFiller1.Name = "PanelFiller1"
        Me.PanelFiller1.Size = New System.Drawing.Size(651, 593)
        Me.PanelFiller1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2})
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(651, 593)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lvListView, Me.spSplitter, Me.tvTreeView})
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(643, 567)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File Explorer"
        '
        'lvListView
        '
        Me.lvListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvListView.ContextMenu = Me.cm1
        Me.lvListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvListView.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lvListView.LargeImageList = Me.ilMain
        Me.lvListView.Location = New System.Drawing.Point(173, 0)
        Me.lvListView.MultiSelect = False
        Me.lvListView.Name = "lvListView"
        Me.lvListView.Size = New System.Drawing.Size(470, 567)
        Me.lvListView.SmallImageList = Me.ilSmall
        Me.lvListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvListView.TabIndex = 23
        Me.lvListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Modified"
        '
        'ilMain
        '
        Me.ilMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilMain.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
        '
        'ilSmall
        '
        Me.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilSmall.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilSmall.ImageStream = CType(resources.GetObject("ilSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSmall.TransparentColor = System.Drawing.Color.Transparent
        '
        'spSplitter
        '
        Me.spSplitter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.spSplitter.Location = New System.Drawing.Point(169, 0)
        Me.spSplitter.MinSize = 100
        Me.spSplitter.Name = "spSplitter"
        Me.spSplitter.Size = New System.Drawing.Size(4, 567)
        Me.spSplitter.TabIndex = 22
        Me.spSplitter.TabStop = False
        '
        'tvTreeView
        '
        Me.tvTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvTreeView.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvTreeView.ImageList = Me.ilMain
        Me.tvTreeView.Name = "tvTreeView"
        Me.tvTreeView.Size = New System.Drawing.Size(169, 567)
        Me.tvTreeView.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.wb1, Me.PanelWbTop1})
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(643, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Web Browser"
        '
        'wb1
        '
        Me.wb1.ContainingControl = Me
        Me.wb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb1.Enabled = True
        Me.wb1.Location = New System.Drawing.Point(0, 64)
        Me.wb1.OcxState = CType(resources.GetObject("wb1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wb1.Size = New System.Drawing.Size(643, 503)
        Me.wb1.TabIndex = 1
        '
        'PanelWbTop1
        '
        Me.PanelWbTop1.Controls.AddRange(New System.Windows.Forms.Control() {Me.addr, Me.Label2, Me.button1, Me.ToolBar1})
        Me.PanelWbTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWbTop1.Name = "PanelWbTop1"
        Me.PanelWbTop1.Size = New System.Drawing.Size(643, 64)
        Me.PanelWbTop1.TabIndex = 0
        '
        'addr
        '
        Me.addr.AcceptsReturn = True
        Me.addr.AcceptsTab = True
        Me.addr.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.addr.Location = New System.Drawing.Point(71, 34)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(503, 21)
        Me.addr.TabIndex = 11
        Me.addr.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Address:"
        '
        'button1
        '
        Me.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.button1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton5})
        Me.button1.Dock = System.Windows.Forms.DockStyle.None
        Me.button1.DropDownArrows = True
        Me.button1.ImageList = Me.ImageList1
        Me.button1.Location = New System.Drawing.Point(580, 29)
        Me.button1.Name = "button1"
        Me.button1.ShowToolTips = True
        Me.button1.Size = New System.Drawing.Size(56, 25)
        Me.button1.TabIndex = 10
        Me.button1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 2
        Me.ToolBarButton5.Text = "GO"
        Me.ToolBarButton5.ToolTipText = "Click to load the address specified in the address bar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton6})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(80, 25)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(643, 28)
        Me.ToolBar1.TabIndex = 9
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Text = "Back"
        Me.ToolBarButton1.ToolTipText = "Takes you back the last page you browsed for"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Text = "Forward"
        Me.ToolBarButton2.ToolTipText = "Go forward"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 4
        Me.ToolBarButton3.Text = "Stop"
        Me.ToolBarButton3.ToolTipText = "Stop the current page from loading"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 5
        Me.ToolBarButton4.Text = "Refresh"
        Me.ToolBarButton4.ToolTipText = "Reloads the current page"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 6
        Me.ToolBarButton6.Text = "Open File"
        '
        'tmTimer
        '
        Me.tmTimer.Enabled = True
        Me.tmTimer.Interval = 10000
        Me.tmTimer.SynchronizingObject = Me
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnufile, Me.mnuhelp})
        '
        'mnufile
        '
        Me.mnufile.Index = 0
        Me.mnufile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuopen, Me.mnusep1, Me.mnuexit})
        Me.mnufile.Text = "&File"
        '
        'mnuopen
        '
        Me.mnuopen.Index = 0
        Me.mnuopen.Text = "&Open"
        '
        'mnusep1
        '
        Me.mnusep1.Index = 1
        Me.mnusep1.Text = "-"
        '
        'mnuexit
        '
        Me.mnuexit.Index = 2
        Me.mnuexit.Text = "E&xit"
        '
        'mnuhelp
        '
        Me.mnuhelp.Index = 1
        Me.mnuhelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuabout})
        Me.mnuhelp.Text = "&Help"
        '
        'mnuabout
        '
        Me.mnuabout.Index = 0
        Me.mnuabout.Text = "&About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Web Files|*.html;*.htm;*.jpeg;*.jpg;*.txt|All Files|*.*"
        Me.OpenFileDialog1.Title = "Open WebFiles"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "Audio Files|*.mp3;*.wav;*.wma"
        Me.OpenFileDialog2.Title = "Open Audio Files"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(640, 480)
        Me.ClientSize = New System.Drawing.Size(852, 651)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelFiller1, Me.BlendPanelLeft1, Me.PanelBottom1, Me.PanelTop1})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyComputer [File Explorer]"
        Me.PanelTop1.ResumeLayout(False)
        Me.BlendPanel2.ResumeLayout(False)
        Me.PanelBottom1.ResumeLayout(False)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlendPanelLeft1.ResumeLayout(False)
        Me.TaskControl3.ResumeLayout(False)
        Me.PanelTemp1.ResumeLayout(False)
        Me.TaskControl2.ResumeLayout(False)
        Me.TaskControl1.ResumeLayout(False)
        Me.PanelFiller1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.wb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelWbTop1.ResumeLayout(False)
        CType(Me.tmTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ShowTP As Boolean = True
    Private currtab As Single = 0
    Private AudFilename As String = "Null"
    Dim Audio As New Audio.audio()
    Private Declare Auto Function GetDriveType Lib "KERNEL32" _
            (ByVal lpRootPathName As String) As Integer
    Private Const DRIVE_FIXED As Integer = 3

    Private Declare Function AssocQueryString Lib "shlwapi.dll" _
         Alias "AssocQueryStringA" (ByVal flags As Integer, _
         ByVal stringType As Integer, ByVal pszAssoc As String, _
         ByVal pszExtra As String, ByVal pszOut As String, ByRef pcchOut As Integer) _
         As Integer
    Private Const ASSOCSTR_FRIENDLYDOCNAME As Integer = 3


    Private Sub InitMYComp()

    End Sub

    Private Sub tmTimer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles tmTimer.Elapsed
        ' OPT: Date and time must be explicitly set on .NET StatusBar. Timer was added
        '     to facilitate time update.
        On Error GoTo err
        SetStatusBarDateTime()
err:
        Exit Sub
    End Sub

    Private Sub tvTreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvTreeView.AfterSelect
        ' OPT: The AfterSelect event is richer than the ActiveX TreeView's NodeClick
        '     event. It occurs after the tree node is selected, and provides information on
        '     which node was selected and how it was selected.

        'Dim currFldr As Scripting.Folder
        ' OPT: Use DirectoryInfo object instead of Scripting.Folder
        lvListView.Visible = True
        LinkLabel2.Visible = False
        adfilename.Text = ""
        adfilesize.Text = ""
        adfiletype.Text = ""
        Dim currFldr As DirectoryInfo

        'Dim fldr As Scripting.Folder
        ' OPT: Use DirectoryInfo object instead of Scripting.Folder
        Dim fldr As DirectoryInfo

        ' OPT: No need for FileSystemObject. We'll use DirectoryInfo object instead.
        'Dim fso As Scripting.FileSystemObject
        'fso = New Scripting.FileSystemObject()

        'currFldr = fso.GetFolder(eventArgs.node.FullPath)
        ' OPT: Use DirectoryInfo object
        currFldr = New DirectoryInfo(e.Node.FullPath)

        'lblPath.Text = eventArgs.node.FullPath
        ' OPT: Remove "\\" from TreeView's FullPath
        lblpath.Text = CleanupPath(e.Node.FullPath)

        DoHourglass(True)

        ' Add child nodes only if there aren't any now
        'If eventArgs.node.Children = 0 Then
        ' OPT: There's no Children property, so check number of nodes in this node's
        '     Nodes collection.
        If e.Node.Nodes.Count = 0 Then
            ' OPT: GetDirectories method provides an array of subfolders
            Try
                For Each fldr In currFldr.GetDirectories
                    AddTVNode(e.Node, fldr.Name)
                Next fldr
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
                GoTo err
            End Try

        End If

        ' OPT: Expand the folder to reveal its subfolders.
        e.Node.Expand()

        ' Add files to the ListView
        'lvListView.ListItems.Clear()
        ' OPT: Items property has replaced ListItems
        lvListView.Items.Clear()

        'Dim fl As Scripting.File
        ' OPT: Use FileInfo object instead of Scripting.File
        Dim fl As FileInfo
        Dim fext
        Dim totalFileSize As Long
        ' OPT: GetFiles method returns an array of files in the current folder
        Try
            For Each fl In currFldr.GetFiles
                ' OPT: Length property provides file size
                Try
                    totalFileSize = totalFileSize + fl.Length
                Catch ex As OverflowException
                    MsgBox("Total file size exceeds the size of a Long variable. Displayed total file size will be incorrect.")
                End Try
                fext = fl.Extension()
                ' OPT: File type is not available from the FileInfo object, so we'll 

                '     use an API function call.
                AddListItem("", fl.Name, fl.Length, GetFileType(fl), fl.LastWriteTime.ToShortDateString, fext)

            Next fl
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            DoHourglass(False)
            GoTo err
        End Try

        ' Show total files and space occupied
        Dim fileCtr As Short
        Dim message As String

        'fileCtr = currFldr.Files.Count
        ' OPT: Length property provides file count
        Try
            fileCtr = currFldr.GetFiles.Length
            message = fileCtr & " file" & IIf(fileCtr = 1, "  ", "s  ")

            'message = message & VB6.Format(totalFileSize, "###,###,##0") & " bytes"
            ' OPT: Use the .NET Format function, which has very compact syntax
            message = message & Format(totalFileSize, "n0") & " byte" & IIf(totalFileSize = 1, "  ", "s  ")

            'sbStatusBar.Panels(1).Text = message
            ' OPT: StatusBar's first panel has an index of zero
            sbStatusBar.Panels(0).Text = message
            it.Text = fileCtr
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            DoHourglass(False)
            GoTo err
        End Try

        DoHourglass(False)
        Application.DoEvents()
        Exit Sub
err:
        DoHourglass(False)
        lvListView.Items.Clear()
    End Sub
    Private Sub AddTVNode(ByRef parentNode As TreeNode, ByVal nodeText As String)
        ' Add a new TreeView node.

        'Dim newNode As MSComctlLib.Node
        ' OPT: Use TreeNode instead of ActiveX control's Node
        Dim newNode As TreeNode

        'newNode = tvTreeView.Nodes.Add(ParentNode, MSComctlLib.TreeRelationshipConstants.tvwChild, nodeKey, nodeText, "fldrClosed", "fldrOpen")
        ' OPT: Create the new node, then add it. The Add method allows a limited number
        '     of parameters.
        newNode = New TreeNode(nodeText, ImageIndex:=0, SelectedImageIndex:=1)
        parentNode.Nodes.Add(newNode)
    End Sub

    Private Function CleanupPath(ByVal path As String) As String
        ' OPT: The paths created by the Treeview control for its Node objects have
        '     ":\\" after the drive letter. This cleans up the extra backslash.
        Return path.Replace("\\", "\")
    End Function

    Private Sub DoHourglass(ByVal showHourglass As Boolean)
        ' Turns hourglass display on/off.
        ' Keeps track of how many nested calls have been made to the hourglass function.

        ' Was the cursor already an hourglass?
        Dim isHourglassPrev As Boolean
        ' Is the cursor an hourglass now?
        Dim isHourglassNow As Boolean
        ' How many nested routines have turned on the hourglass?
        Static hourGlassCtr As Short

        ' Note the current state of the cursor, then
        ' update the hourglass counter.
        isHourglassPrev = (hourGlassCtr > 0)
        If showHourglass Then
            hourGlassCtr = hourGlassCtr + 1
        Else
            hourGlassCtr = hourGlassCtr - 1
        End If
        If hourGlassCtr < 0 Then hourGlassCtr = 0

        ' Set the cursor, but only if it's different from what it is now.
        isHourglassNow = (hourGlassCtr > 0)
        If isHourglassNow <> isHourglassPrev Then
            If hourGlassCtr > 0 Then
                Me.Cursor = Cursors.AppStarting
            Else
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Function GetFileType(ByRef fl As FileInfo) As String
        ' OPT: Get a file's Friendly Document Name. 

        ' OPT: Create a 260 char string
        Dim strRet As New String(CChar(" "), 260)
        Dim lngRet As Integer = Len(strRet)

        ' OPT: Call the API function
        AssocQueryString(0, ASSOCSTR_FRIENDLYDOCNAME, fl.Extension, vbNullString, strRet, lngRet)
        strRet = strRet.Substring(0, lngRet - 1).Trim

        If Len(strRet) > 0 Then
            Return strRet
        ElseIf Len(fl.Extension) > 0 Then
            Return Mid(fl.Extension, 2) & " File"
        Else
            Return "File"
        End If
    End Function

    Private Sub SetStatusBarDateTime()
        ' OPT: Update the date and time on the StatusBar explicitly.
        sbStatusBar.Panels(1).Text = DateTime.Now.ToShortTimeString()
        sbStatusBar.Panels(2).Text = DateTime.Now.ToShortDateString()
    End Sub


    Private Sub lvListView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvListView.Click
        Try


            Dim a, b, cu
            Dim fa, fb, fn

            a = lvListView.FocusedItem.Text
            cu = Microsoft.VisualBasic.Right(lblpath.Text, 1)
            If cu = "\" Then
                b = lblpath.Text & a
            Else
                b = lblpath.Text & "\" & a
            End If
            fn = b
            fb = Microsoft.VisualBasic.Right(fn, 3)
            fa = Microsoft.VisualBasic.LCase(fb)
            Text1.Text = fn
            tbfilename.Text = lvListView.FocusedItem.SubItems(0).Text
            tbsize.Text = lvListView.FocusedItem.SubItems(1).Text
            tbtype.Text = lvListView.FocusedItem.SubItems(2).Text
            tbmodified.Text = lvListView.FocusedItem.SubItems(3).Text
            dotpaction()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            Exit Sub
        End Try

    End Sub

    Private Sub AddListItem(ByVal itemKey As String, ByVal itemText As String, ByVal itemSize As Long, ByVal itemType As String, ByVal itemModified As DateTime, ByVal extension As String)
        ' Add a ListViewItem, then additional columns as SubItems.

        'Dim liListItem As MSComctlLib.ListItem
        ' OPT: ListViewItem replaces ListItem
        Dim lvItem As ListViewItem
        Dim inkb, inmb, indkb
        Dim rkb, rmb
        Dim ft
        inkb = itemSize
        indkb = inkb / 1024
        inmb = (inkb / 1024) / 1024
        rkb = Math.Round(indkb)
        rmb = Math.Round(inmb)
        ft = Microsoft.VisualBasic.LCase(extension)
        'liListItem = lvListView.ListItems.Add(, , itemText, "genericMedium", "genericSmall")
        ' OPT: The .NET TreeView's Add method has different arguments
        If ft = ".bmp" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=1)
            GoTo cont
        End If
        If ft = ".gif" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=1)
            GoTo cont
        End If
        If ft = ".jpg" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=1)
            GoTo cont
        End If
        If ft = ".jpeg" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=1)
            GoTo cont
        End If
        If ft = ".psd" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=16)
            GoTo cont
        End If
        If ft = ".tiff" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=1)
            GoTo cont
        End If
        'Sound files
        If ft = ".wma" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=19)
            GoTo cont
        End If
        If ft = ".mp3" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=19)
            GoTo cont
        End If
        If ft = ".wav" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=19)
            GoTo cont
        End If
        'Video files
        If ft = ".mpg" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=7)
            GoTo cont
        End If
        If ft = ".avi" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=7)
            GoTo cont
        End If
        If ft = ".mpeg" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=7)
            GoTo cont
        End If
        If ft = ".wmv" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=7)
            GoTo cont
        End If
        'Text files
        If ft = ".txt" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=2)
            GoTo cont
        End If
        If ft = ".rtf" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=2)
            GoTo cont
        End If
        'Dlls
        If ft = ".dll" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=4)
            GoTo cont
        End If
        'Infs
        If ft = ".inf" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=6)
            GoTo cont
        End If
        'Inis
        If ft = ".ini" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=6)
            GoTo cont
        End If
        'zip,cabs
        If ft = ".zip" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=8)
            GoTo cont
        End If
        If ft = ".cab" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=8)
            GoTo cont
        End If
        'Htmls
        If ft = ".html" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=5)
            GoTo cont
        End If
        If ft = ".htm" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=5)
            GoTo cont
        End If
        If ft = ".asp" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=4)
            GoTo cont
        End If
        If ft = ".aspx" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=5)
            GoTo cont
        End If
        If ft = ".exe" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=0)
            GoTo cont
        End If
        If ft = ".hlp" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=10)
            GoTo cont
        End If
        If ft = ".chm" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=11)
            GoTo cont
        End If
        If ft = ".doc" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=12)
            GoTo cont
        End If
        If ft = ".mdb" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=13)
            GoTo cont
        End If
        If ft = ".msi" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=14)
            GoTo cont
        End If
        If ft = ".ppt" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=15)
            GoTo cont
        End If
        If ft = ".pdf" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=16)
            GoTo cont
        End If
        If ft = ".xls" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=17)
            GoTo cont
        End If
        If ft = ".swf" Then
            lvItem = lvListView.Items.Add(Text:=itemText, imageindex:=18)
            GoTo cont
        End If
        lvItem = lvListView.Items.Add(Text:=itemText, ImageIndex:=9)
cont:
        If inmb <= 1 Then
            With lvItem.SubItems
                .Add(Text:=rkb & " KB")
                .Add(Text:=itemType)
                .Add(Text:=itemModified)
            End With
        Else
            With lvItem.SubItems
                .Add(Text:=rmb & " MB")
                .Add(Text:=itemType)
                .Add(Text:=itemModified)
            End With
        End If
    End Sub
    Private Sub dotpaction()
        Dim fa, fb, fn
        fn = Text1.Text
        If fn = "null" Then
            Exit Sub
        End If
        fb = Microsoft.VisualBasic.Right(fn, 3)
        fa = LCase(fb)
        adfilename.Text = tbfilename.Text
        adfilesize.Text = tbsize.Text
        adfiletype.Text = tbtype.Text
        If fa = "mp3" Then
            GoTo showmp
        ElseIf fa = "wma" Then
            GoTo showmp
        ElseIf fa = "wav" Then
            GoTo showmp
        End If
        LinkLabel2.Visible = False
        Dim shouldshowpic As Boolean = False
        If fa = "bmp" Then
            shouldshowpic = True
        ElseIf fa = "jpg" Then
            shouldshowpic = True
        ElseIf fa = "peg" Then
            shouldshowpic = True
        ElseIf fa = "gif" Then
            shouldshowpic = True
        ElseIf fa = "png" Then
            shouldshowpic = True
        ElseIf fa = "iff" Then
            shouldshowpic = True
        Else
            shouldshowpic = False
        End If
        If shouldshowpic = True Then
            GoTo cont
        Else
            GoTo noimg
        End If
cont:
        Try
            img1.Image = Image.FromFile(Text1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Exit Sub
noimg:
        Try
            img1.Image = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Exit Sub
showmp:
        LinkLabel2.Visible = True
    End Sub

    Private Sub lvListView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvListView.KeyUp
        If e.KeyCode = Keys.Up Then
            GoTo handled
        End If
        If e.KeyCode = Keys.Down Then
            GoTo handled
        End If
        Exit Sub
handled:
        lvListView_Click(Me, e)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' OPT: Use .NET's native objects instead of COM-based objects

        'Dim currFldr As Scripting.Folder
        ' OPT: Use DirectoryInfo object instead of Scripting.Folder
        mnuopen.Visible = False
        mnusep1.Visible = False
        Label1.Visible = True
        lblpath.Visible = True
        Try


            Dim currFldr As DirectoryInfo

            'Dim drv As Scripting.Drive
            ' OPT: GetLogicalDrives (below) returns a string array, so declare drv as a string
            Dim drv As String

            'Dim fldr As Scripting.Folder
            ' OPT: Use DirectoryInfo object instead of Scripting.Folder
            Dim fldr As DirectoryInfo

            'Dim nodRoot As MSComctlLib.Node
            ' OPT: Use TreeNode object instead ActiveX control Node object
            Dim nodRoot As TreeNode

            ' OPT: No need for FileSystemObject. We'll use Directory object instead.
            'Dim fso As Scripting.FileSystemObject
            'fso = New Scripting.FileSystemObject()

            ' OPT: Set the TreeView's Sorted property once for all levels.
            tvTreeView.Sorted = True
            With lvListView
                .Columns(0).Width = 198
                .Columns(1).Width = 66
                .Columns(2).Width = 180
                .Columns(3).Width = 78
            End With
            ' Populate level 1 of the TreeView
            DoHourglass(True)
            'For Each drv In fso.Drives
            ' OPT: Use System.IO.Directory instead of Scripting.FileSystemObject
            For Each drv In Directory.GetLogicalDrives()
                'If drv.IsReady Then
                ' OPT: Instead of checking for drive readiness, include only fixed drives
                If GetDriveType(drv) = DRIVE_FIXED Then
                    'nodRoot = tvTreeView.Nodes.Add(, , drv.RootFolder.Path, drv.DriveLetter & ":")
                    ' OPT: Add method takes fewer parameters, Text or Node only.
                    nodRoot = tvTreeView.Nodes.Add(drv)
                    'With nodRoot
                    '    .Image = "drive"
                    '    .Sorted = True
                    'End With
                    ' OPT: Use numeric Index. Key not available.
                    With nodRoot
                        .ImageIndex = 2
                        ' OPT: Must set SelectedImageIndex or it will default to first image in
                        '     ImageList. No need to set Sorted on  a per-node basis, as above.
                        .SelectedImageIndex = 2
                    End With

                    ' Get a pointer to the root folder
                    'currFldr = drv.RootFolder
                    ' OPT: Handled below

                    ' Populate level 2 of the TreeView
                    currFldr = New DirectoryInfo(nodRoot.FullPath)
                    ' OPT: GetDirectories method provides an array of subfolders
                    For Each fldr In currFldr.GetDirectories
                        AddTVNode(nodRoot, fldr.Name)
                    Next fldr
                End If
            Next drv
            ' OPT: Date and time must be explicitly set on .NET StatusBar
            SetStatusBarDateTime()

            DoHourglass(False)
            Application.DoEvents()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            lvListView.Visible = False
            Exit Sub
        End Try
        lvListView.Visible = False
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                goback()
            Case 1
                goforward()
            Case 2
                gostop()
            Case 3
                gorefresh()
            Case 4
                If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    openhtml(OpenFileDialog1.FileName)
                End If
        End Select
    End Sub
    Private Sub goback()
        Try
            wb1.GoBack()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub
    Private Sub goforward()
        Try
            wb1.GoForward()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub
    Private Sub gostop()
        Try
            wb1.Stop()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub
    Private Sub gorefresh()
        Try
            wb1.Refresh()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub button1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles button1.ButtonClick
        donavi()
    End Sub
    Private Sub donavi()
        If addr.Text = "" Then
            Exit Sub
        End If
        On Error Resume Next
        wb1.Navigate2(addr.Text)
    End Sub
    Public Sub openhtml(ByVal file As String)
        Try
            wb1.Navigate2(file)
            addr.Text = file
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ShowTP = True Then
            ShowTP = False
            BlendPanelLeft1.Visible = False
            Button2.Text = "Show Taskpane"
            Exit Sub
        End If
        If ShowTP = False Then
            ShowTP = True
            BlendPanelLeft1.Visible = True
            BlendPanelLeft1.Refresh()
            Button2.Text = "Hide Taskpane"
            Exit Sub
        End If
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Me.Text = "MyComputer [" & TabControl1.SelectedTab.Text & "]"
        currtab = TabControl1.SelectedIndex.ToString
        If currtab = 0 Then
            mnuopen.Visible = False
            mnusep1.Visible = False
            Label1.Visible = True
            lblpath.Visible = True
        ElseIf currtab = 1 Then
            mnuopen.Visible = True
            mnusep1.Visible = True
            Label1.Visible = False
            lblpath.Visible = False
        End If
    End Sub

    Private Sub mnuopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuopen.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            openhtml(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub mnuexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuexit.Click
        Application.Exit()
    End Sub

    Private Sub mnuabout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuabout.Click
        MessageBox.Show("MyComputer version " & Application.ProductVersion & vbCrLf & "(C) Copyright Gurusted,2003-2005 " & vbCrLf & "email: guruparan@rediffmail.com", "About MyComputer", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            Audio.audioFile = OpenFileDialog2.FileName
            Audio.audioPlay()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Audio.audioPlay()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Audio.audioPause()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Audio.audioStop()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Audio.audioResume()
    End Sub
    Private Sub HandleTextofmenu(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuopen.Select, mnuexit.Select, mnuabout.Select, mnufile.Select, mnuhelp.Select
        Dim strText As String = "Done"
        If sender Is mnuopen Then
            strText = "Open a File"
        ElseIf sender Is mnuexit Then
            strText = "Click to Exit this Application"
        ElseIf sender Is mnuabout Then
            strText = "View the Product Information"
        Else
            strText = "Done"
        End If
        WriteStatus(strText)
    End Sub

    Private Sub wb1_StatusTextChange(ByVal sender As Object, ByVal e As AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent) Handles wb1.StatusTextChange
        Dim Te As String = e.text
        StatusBarPanel1.Text = Te
    End Sub
    Private Sub WriteStatus(ByVal DText As String)
        StatusBarPanel1.Text = DText
    End Sub
    Private Sub ClearStatusBar()
        StatusBarPanel1.Text = "Done"
    End Sub

    Private Sub adfilename_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles adfilename.TextChanged
        Dim totallen As Integer = Len(adfilename.Text)
        If totallen >= 18 Then
            adfilename.Text = Microsoft.VisualBasic.Left(adfilename.Text, 15) & "..."
        End If
    End Sub

    Private Sub adfiletype_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles adfiletype.TextChanged
        Dim totallen1 As Integer = Len(adfiletype.Text)
        If totallen1 >= 25 Then
            adfiletype.Text = Microsoft.VisualBasic.Left(adfiletype.Text, 22) & "..."
        End If
    End Sub

    Private Sub LinkLabel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel2.Click
        Audio.audioFile = Text1.Text
        Audio.audioPlay()
    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        Try
            System.Diagnostics.Process.Start(Text1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lvListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvListView.DoubleClick
        Dim fa, fb, fn
        fn = Text1.Text
        If fn = "null" Then
            Exit Sub
        End If
        fb = Microsoft.VisualBasic.Right(fn, 3)
        fa = LCase(fb)
        If fa = "mp3" Then
            ShowMPd()
            Exit Sub
        ElseIf fa = "wma" Then
            ShowMPd()
            Exit Sub
        ElseIf fa = "wav" Then
            ShowMPd()
            Exit Sub
        End If
        Try
            System.Diagnostics.Process.Start(Text1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ShowMPd()
        Dim a As DialogResult
        a = MessageBox.Show("Do you want to play with our inbuilt player", "Play with Inbuilt Player", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then
            Audio.audioFile = Text1.Text
            Audio.audioPlay()
        ElseIf a = DialogResult.No Then
            GoTo ext
        End If
        Exit Sub
ext:
        Try
            System.Diagnostics.Process.Start(Text1.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
