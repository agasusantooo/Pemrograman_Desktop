<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        pnlPlat = New DataGridView()
        pnlGrid = New DataGridView()
        pnlHarga = New DataGridView()
        lblInfoUser = New Label()
        lblTgl = New Label()
        lblJmlKendaraan = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        lblPlat = New Label()
        lblHarga = New Label()
        DataGridView1 = New DataGridView()
        lblInputPlat = New Label()
        txtNoPlat = New TextBox()
        lblJenis = New Label()
        lblTekan = New Label()
        lblInfoJenis = New Label()
        DataGridView2 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(pnlPlat, ComponentModel.ISupportInitialize).BeginInit()
        CType(pnlGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(pnlHarga, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(1050, 40)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "Sistem"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(92, 34)
        ToolStripMenuItem1.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(196, 40)
        AturProfilToolStripMenuItem.Text = "Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(196, 40)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(92, 34)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(339, 40)
        LanggananToolStripMenuItem.Text = "Kendaraan Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(339, 40)
        LaporanToolStripMenuItem.Text = "Laporan Pendapatan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(108, 34)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(208, 40)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(208, 40)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pnlPlat.Dock = DockStyle.Top
        pnlPlat.GridColor = Color.Gray
        pnlPlat.Location = New Point(0, 40)
        pnlPlat.Margin = New Padding(4)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.RowHeadersWidth = 51
        pnlPlat.Size = New Size(1050, 142)
        pnlPlat.TabIndex = 1
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BorderStyle = BorderStyle.Fixed3D
        pnlGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pnlGrid.Location = New Point(363, 194)
        pnlGrid.Margin = New Padding(4)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.RowHeadersWidth = 51
        pnlGrid.Size = New Size(687, 440)
        pnlGrid.TabIndex = 10
        ' 
        ' pnlHarga
        ' 
        pnlHarga.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pnlHarga.Location = New Point(0, 196)
        pnlHarga.Margin = New Padding(4)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.RowHeadersWidth = 51
        pnlHarga.Size = New Size(354, 110)
        pnlHarga.TabIndex = 11
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoUser.Location = New Point(18, 506)
        lblInfoUser.Margin = New Padding(4, 0, 4, 0)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(127, 30)
        lblInfoUser.TabIndex = 12
        lblInfoUser.Text = "Informasi - "
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(18, 540)
        lblTgl.Margin = New Padding(4, 0, 4, 0)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(102, 30)
        lblTgl.TabIndex = 13
        lblTgl.Text = "Tanggal:  "
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Location = New Point(18, 572)
        lblJmlKendaraan.Margin = New Padding(4, 0, 4, 0)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(254, 60)
        lblJmlKendaraan.TabIndex = 14
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Tasksi," & vbCrLf & "0 Sepeda, 0 Bis/Truk"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "Delete"
        ContextMenuStrip1.Size = New Size(271, 78)
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblPlat.FlatStyle = FlatStyle.Flat
        lblPlat.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlat.Location = New Point(360, 52)
        lblPlat.Margin = New Padding(4, 0, 4, 0)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(455, 112)
        lblPlat.TabIndex = 17
        lblPlat.Text = "R 6872 ZH"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblHarga.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(18, 214)
        lblHarga.Margin = New Padding(4, 0, 4, 0)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(124, 70)
        lblHarga.TabIndex = 18
        lblHarga.Text = "Rp. "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 321)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(354, 176)
        DataGridView1.TabIndex = 20
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.Location = New Point(14, 342)
        lblInputPlat.Margin = New Padding(4, 0, 4, 0)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(103, 30)
        lblInputPlat.TabIndex = 21
        lblInputPlat.Text = "Input Plat"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNoPlat.Location = New Point(135, 330)
        txtNoPlat.Margin = New Padding(4)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(184, 45)
        txtNoPlat.TabIndex = 22
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(14, 390)
        lblJenis.Margin = New Padding(4, 0, 4, 0)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(317, 60)
        lblJenis.TabIndex = 23
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi," & vbCrLf & "F4 - Sepeda, F5 - Bis/Truk "
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Location = New Point(14, 450)
        lblTekan.Margin = New Padding(4, 0, 4, 0)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(312, 30)
        lblTekan.TabIndex = 24
        lblTekan.Text = "Tekan Enter untuk Masuk/Keluar"
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(412, 336)
        lblInfoJenis.Margin = New Padding(4, 0, 4, 0)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 30)
        lblInfoJenis.TabIndex = 25
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, ColJenis, Column1})
        DataGridView2.ContextMenuStrip = ContextMenuStrip1
        DataGridView2.Location = New Point(363, 194)
        DataGridView2.Margin = New Padding(4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(687, 438)
        DataGridView2.TabIndex = 26
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.MinimumWidth = 6
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.Width = 125
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.MinimumWidth = 6
        ColMasuk.Name = "ColMasuk"
        ColMasuk.Width = 125
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.MinimumWidth = 6
        ColKeluar.Name = "ColKeluar"
        ColKeluar.Width = 125
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.Width = 125
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 6
        ColJenis.Name = "ColJenis"
        ColJenis.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        Column1.Width = 125
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(270, 36)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1050, 633)
        Controls.Add(DataGridView2)
        Controls.Add(lblInfoJenis)
        Controls.Add(lblTekan)
        Controls.Add(lblJenis)
        Controls.Add(txtNoPlat)
        Controls.Add(lblInputPlat)
        Controls.Add(DataGridView1)
        Controls.Add(lblHarga)
        Controls.Add(lblPlat)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblTgl)
        Controls.Add(lblInfoUser)
        Controls.Add(pnlHarga)
        Controls.Add(pnlGrid)
        Controls.Add(pnlPlat)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pnlPlat, ComponentModel.ISupportInitialize).EndInit()
        CType(pnlGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(pnlHarga, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As DataGridView
    Friend WithEvents pnlGrid As DataGridView
    Friend WithEvents pnlHarga As DataGridView
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
