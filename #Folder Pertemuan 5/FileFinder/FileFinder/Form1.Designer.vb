﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportFileListToToolStripMenuItem = New ToolStripMenuItem()
        RefreshFolderToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenExecuteFileToolStripMenuItem = New ToolStripMenuItem()
        OpenAndSelectFileInFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyFullPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        lblFind = New Label()
        cbFind = New ComboBox()
        txtExtension = New TextBox()
        btnSearch = New Button()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        Panel2 = New Panel()
        Label3 = New Label()
        lblInfo = New Label()
        tvDrive = New TreeView()
        lvFile = New ListView()
        Named = New ColumnHeader()
        Extension = New ColumnHeader()
        FileSize = New ColumnHeader()
        LastModified = New ColumnHeader()
        LastAccessed = New ColumnHeader()
        CreatedDate = New ColumnHeader()
        Attributes = New ColumnHeader()
        FullPath = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 593)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 12, 0)
        StatusStrip1.Size = New Size(1005, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(902, 17)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(88, 16)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1005, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportFileListToToolStripMenuItem, RefreshFolderToolStripMenuItem, ToolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExportFileListToToolStripMenuItem
        ' 
        ExportFileListToToolStripMenuItem.Name = "ExportFileListToToolStripMenuItem"
        ExportFileListToToolStripMenuItem.Size = New Size(209, 22)
        ExportFileListToToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshFolderToolStripMenuItem
        ' 
        RefreshFolderToolStripMenuItem.Name = "RefreshFolderToolStripMenuItem"
        RefreshFolderToolStripMenuItem.Size = New Size(209, 22)
        RefreshFolderToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(206, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(209, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, ToolStripSeparator1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(107, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(104, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp")
        ImageList1.Images.SetKeyName(1, "folder.bmp")
        ImageList1.Images.SetKeyName(2, "file.bmp")
        ImageList1.Images.SetKeyName(3, "exe.bmp")
        ImageList1.Images.SetKeyName(4, "image.ico")
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenExecuteFileToolStripMenuItem, OpenAndSelectFileInFolderToolStripMenuItem, CopyFullPathToClipboardToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(235, 92)
        ' 
        ' OpenExecuteFileToolStripMenuItem
        ' 
        OpenExecuteFileToolStripMenuItem.Name = "OpenExecuteFileToolStripMenuItem"
        OpenExecuteFileToolStripMenuItem.Size = New Size(234, 22)
        OpenExecuteFileToolStripMenuItem.Text = "Open/Execute File"
        ' 
        ' OpenAndSelectFileInFolderToolStripMenuItem
        ' 
        OpenAndSelectFileInFolderToolStripMenuItem.Name = "OpenAndSelectFileInFolderToolStripMenuItem"
        OpenAndSelectFileInFolderToolStripMenuItem.Size = New Size(234, 22)
        OpenAndSelectFileInFolderToolStripMenuItem.Text = "Open and Select file in Folder"
        ' 
        ' CopyFullPathToClipboardToolStripMenuItem
        ' 
        CopyFullPathToClipboardToolStripMenuItem.Name = "CopyFullPathToClipboardToolStripMenuItem"
        CopyFullPathToClipboardToolStripMenuItem.Size = New Size(234, 22)
        CopyFullPathToClipboardToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(234, 22)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Copy Folder Path to Clipboard"
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(10, 17)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(33, 15)
        lblFind.TabIndex = 3
        lblFind.Text = "Find:"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(62, 15)
        cbFind.Margin = New Padding(3, 2, 3, 2)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(533, 23)
        cbFind.TabIndex = 4
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(601, 14)
        txtExtension.Margin = New Padding(3, 2, 3, 2)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(37, 23)
        txtExtension.TabIndex = 5
        txtExtension.Text = "*.*"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(644, 6)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(91, 37)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblFind)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(txtExtension)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 24)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1005, 47)
        Panel1.TabIndex = 7
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 71)
        SplitContainer1.Margin = New Padding(3, 2, 3, 2)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel2)
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Size = New Size(1005, 522)
        SplitContainer1.SplitterDistance = 342
        SplitContainer1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblInfo)
        Panel2.Location = New Point(0, 391)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(356, 131)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(10, 8)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(121, 15)
        lblInfo.TabIndex = 0
        lblInfo.Text = "Free Fixed Disk Info:"
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Margin = New Padding(3, 2, 3, 2)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(342, 522)
        tvDrive.TabIndex = 0
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {Named, Extension, FileSize, LastModified, LastAccessed, CreatedDate, Attributes, FullPath})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.GridLines = True
        lvFile.Location = New Point(3, 8)
        lvFile.Margin = New Padding(3, 2, 3, 2)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(484, 385)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 0
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' Named
        ' 
        Named.Text = "Name"
        ' 
        ' Extension
        ' 
        Extension.Text = "Extension"
        ' 
        ' FileSize
        ' 
        FileSize.Text = "File Size"
        ' 
        ' LastModified
        ' 
        LastModified.Text = "Last Modified"
        ' 
        ' LastAccessed
        ' 
        LastAccessed.Text = "Last Accessed"
        ' 
        ' CreatedDate
        ' 
        CreatedDate.Text = "CreatedDate"
        ' 
        ' Attributes
        ' 
        Attributes.Text = "Attributes"
        ' 
        ' FullPath
        ' 
        FullPath.Text = "Full Path"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1005, 615)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFinder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportFileListToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenExecuteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAndSelectFileInFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFullPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFind As Label
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Label3 As Label
    Friend WithEvents lvFile As ListView
    Friend WithEvents Named As ColumnHeader
    Friend WithEvents Extension As ColumnHeader
    Friend WithEvents FileSize As ColumnHeader
    Friend WithEvents LastModified As ColumnHeader
    Friend WithEvents LastAccessed As ColumnHeader
    Friend WithEvents CreatedDate As ColumnHeader
    Friend WithEvents Attributes As ColumnHeader
    Friend WithEvents FullPath As ColumnHeader

End Class
