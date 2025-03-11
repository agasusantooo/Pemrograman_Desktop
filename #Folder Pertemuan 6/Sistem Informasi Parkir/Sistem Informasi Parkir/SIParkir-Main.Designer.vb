<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUtama
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
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        labelDisplayPlat = New Label()
        labelNomorPlat = New Label()
        textboxNomorPlat = New TextBox()
        labelJenis = New Label()
        comboboxJenis = New ComboBox()
        buttonMasuk = New Button()
        buttonKeluar = New Button()
        labelBiayaParkir = New Label()
        labelJumlahBiaya = New Label()
        labelInformasi = New Label()
        labelTanggal = New Label()
        TanggalMasuk = New DateTimePicker()
        JamMasuk = New DateTimePicker()
        labelJam = New Label()
        labelSedangParkir = New Label()
        labelKendaraanSedangParkir = New Label()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(28, 28)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 38)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(92, 34)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(225, 40)
        AturProfilToolStripMenuItem.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(225, 40)
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
        LanggananToolStripMenuItem.Size = New Size(315, 40)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(315, 40)
        LaporanToolStripMenuItem.Text = "Laporan"
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
        BantuanToolStripMenuItem1.Size = New Size(315, 40)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(315, 40)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' labelDisplayPlat
        ' 
        labelDisplayPlat.BackColor = SystemColors.ButtonHighlight
        labelDisplayPlat.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDisplayPlat.Location = New Point(27, 52)
        labelDisplayPlat.Name = "labelDisplayPlat"
        labelDisplayPlat.Size = New Size(741, 150)
        labelDisplayPlat.TabIndex = 1
        labelDisplayPlat.Text = "AA 1234 AA"
        labelDisplayPlat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelNomorPlat
        ' 
        labelNomorPlat.AutoSize = True
        labelNomorPlat.Location = New Point(27, 228)
        labelNomorPlat.Name = "labelNomorPlat"
        labelNomorPlat.Size = New Size(119, 30)
        labelNomorPlat.TabIndex = 2
        labelNomorPlat.Text = "Nomor Plat"
        ' 
        ' textboxNomorPlat
        ' 
        textboxNomorPlat.Location = New Point(152, 225)
        textboxNomorPlat.Name = "textboxNomorPlat"
        textboxNomorPlat.Size = New Size(278, 35)
        textboxNomorPlat.TabIndex = 3
        ' 
        ' labelJenis
        ' 
        labelJenis.AutoSize = True
        labelJenis.Location = New Point(27, 273)
        labelJenis.Name = "labelJenis"
        labelJenis.Size = New Size(58, 30)
        labelJenis.TabIndex = 4
        labelJenis.Text = "Jenis"
        ' 
        ' comboboxJenis
        ' 
        comboboxJenis.FormattingEnabled = True
        comboboxJenis.Location = New Point(152, 270)
        comboboxJenis.Name = "comboboxJenis"
        comboboxJenis.Size = New Size(278, 38)
        comboboxJenis.TabIndex = 5
        ' 
        ' buttonMasuk
        ' 
        buttonMasuk.Font = New Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonMasuk.Location = New Point(152, 314)
        buttonMasuk.Name = "buttonMasuk"
        buttonMasuk.Size = New Size(133, 37)
        buttonMasuk.TabIndex = 6
        buttonMasuk.Text = "Masuk"
        buttonMasuk.UseVisualStyleBackColor = True
        ' 
        ' buttonKeluar
        ' 
        buttonKeluar.Font = New Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        buttonKeluar.Location = New Point(291, 314)
        buttonKeluar.Name = "buttonKeluar"
        buttonKeluar.Size = New Size(139, 37)
        buttonKeluar.TabIndex = 7
        buttonKeluar.Text = "Keluar"
        buttonKeluar.UseVisualStyleBackColor = True
        ' 
        ' labelBiayaParkir
        ' 
        labelBiayaParkir.AutoSize = True
        labelBiayaParkir.Location = New Point(27, 362)
        labelBiayaParkir.Name = "labelBiayaParkir"
        labelBiayaParkir.Size = New Size(119, 30)
        labelBiayaParkir.TabIndex = 8
        labelBiayaParkir.Text = "Biaya Parkir"
        ' 
        ' labelJumlahBiaya
        ' 
        labelJumlahBiaya.BackColor = SystemColors.ButtonHighlight
        labelJumlahBiaya.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelJumlahBiaya.Location = New Point(152, 362)
        labelJumlahBiaya.Name = "labelJumlahBiaya"
        labelJumlahBiaya.Size = New Size(278, 89)
        labelJumlahBiaya.TabIndex = 9
        labelJumlahBiaya.Text = "RP 5.000"
        labelJumlahBiaya.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelInformasi
        ' 
        labelInformasi.AutoSize = True
        labelInformasi.Location = New Point(27, 468)
        labelInformasi.Name = "labelInformasi"
        labelInformasi.Size = New Size(100, 30)
        labelInformasi.TabIndex = 10
        labelInformasi.Text = "Informasi"
        ' 
        ' labelTanggal
        ' 
        labelTanggal.AutoSize = True
        labelTanggal.Location = New Point(29, 515)
        labelTanggal.Name = "labelTanggal"
        labelTanggal.Size = New Size(102, 30)
        labelTanggal.TabIndex = 11
        labelTanggal.Text = "Tanggal : "
        ' 
        ' TanggalMasuk
        ' 
        TanggalMasuk.Enabled = False
        TanggalMasuk.Format = DateTimePickerFormat.Short
        TanggalMasuk.Location = New Point(124, 515)
        TanggalMasuk.Name = "TanggalMasuk"
        TanggalMasuk.Size = New Size(150, 35)
        TanggalMasuk.TabIndex = 12
        ' 
        ' JamMasuk
        ' 
        JamMasuk.Enabled = False
        JamMasuk.Format = DateTimePickerFormat.Time
        JamMasuk.Location = New Point(124, 556)
        JamMasuk.Name = "JamMasuk"
        JamMasuk.Size = New Size(150, 35)
        JamMasuk.TabIndex = 14
        ' 
        ' labelJam
        ' 
        labelJam.AutoSize = True
        labelJam.Location = New Point(29, 556)
        labelJam.Name = "labelJam"
        labelJam.Size = New Size(61, 30)
        labelJam.TabIndex = 13
        labelJam.Text = "Jam :"
        ' 
        ' labelSedangParkir
        ' 
        labelSedangParkir.AutoSize = True
        labelSedangParkir.Location = New Point(27, 593)
        labelSedangParkir.Name = "labelSedangParkir"
        labelSedangParkir.Size = New Size(403, 30)
        labelSedangParkir.TabIndex = 15
        labelSedangParkir.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Spd, 0 Bis/Truk"
        ' 
        ' labelKendaraanSedangParkir
        ' 
        labelKendaraanSedangParkir.AutoSize = True
        labelKendaraanSedangParkir.Location = New Point(472, 228)
        labelKendaraanSedangParkir.Name = "labelKendaraanSedangParkir"
        labelKendaraanSedangParkir.Size = New Size(248, 30)
        labelKendaraanSedangParkir.TabIndex = 16
        labelKendaraanSedangParkir.Text = "Kendaraan sedang parkir:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(472, 261)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.Size = New Size(296, 362)
        DataGridView1.TabIndex = 17
        ' 
        ' formUtama
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 632)
        Controls.Add(DataGridView1)
        Controls.Add(labelKendaraanSedangParkir)
        Controls.Add(labelSedangParkir)
        Controls.Add(JamMasuk)
        Controls.Add(labelJam)
        Controls.Add(TanggalMasuk)
        Controls.Add(labelTanggal)
        Controls.Add(labelInformasi)
        Controls.Add(labelJumlahBiaya)
        Controls.Add(labelBiayaParkir)
        Controls.Add(buttonKeluar)
        Controls.Add(buttonMasuk)
        Controls.Add(comboboxJenis)
        Controls.Add(labelJenis)
        Controls.Add(textboxNomorPlat)
        Controls.Add(labelNomorPlat)
        Controls.Add(labelDisplayPlat)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "formUtama"
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents labelDisplayPlat As Label
    Friend WithEvents labelNomorPlat As Label
    Friend WithEvents textboxNomorPlat As TextBox
    Friend WithEvents labelJenis As Label
    Friend WithEvents comboboxJenis As ComboBox
    Friend WithEvents buttonMasuk As Button
    Friend WithEvents buttonKeluar As Button
    Friend WithEvents labelBiayaParkir As Label
    Friend WithEvents labelJumlahBiaya As Label
    Friend WithEvents labelInformasi As Label
    Friend WithEvents labelTanggal As Label
    Friend WithEvents TanggalMasuk As DateTimePicker
    Friend WithEvents JamMasuk As DateTimePicker
    Friend WithEvents labelJam As Label
    Friend WithEvents labelSedangParkir As Label
    Friend WithEvents labelKendaraanSedangParkir As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
