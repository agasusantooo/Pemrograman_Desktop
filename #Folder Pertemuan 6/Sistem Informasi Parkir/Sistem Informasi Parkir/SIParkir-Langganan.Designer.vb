<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLangganan
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
        labelNamaPelanggan = New Label()
        textboxNamaPelanggan = New TextBox()
        textboxNomorPlat = New TextBox()
        labelNomorPlat = New Label()
        textboxTarifLangganan = New TextBox()
        labelTarifLangganan = New Label()
        labelBerlakuHingga = New Label()
        labelIDPelanggan = New Label()
        labelJenis = New Label()
        ComboBox1 = New ComboBox()
        buttonTambah = New Button()
        buttonEdit = New Button()
        buttonHapus = New Button()
        DateTimePicker1 = New DateTimePicker()
        labelKendaraanTerdaftarLangganan = New Label()
        DataGridView1 = New DataGridView()
        buttonTutup = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelNamaPelanggan
        ' 
        labelNamaPelanggan.AutoSize = True
        labelNamaPelanggan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelNamaPelanggan.Location = New Point(35, 38)
        labelNamaPelanggan.Name = "labelNamaPelanggan"
        labelNamaPelanggan.Size = New Size(175, 30)
        labelNamaPelanggan.TabIndex = 0
        labelNamaPelanggan.Text = "Nama Pelanggan"
        ' 
        ' textboxNamaPelanggan
        ' 
        textboxNamaPelanggan.Location = New Point(237, 35)
        textboxNamaPelanggan.Name = "textboxNamaPelanggan"
        textboxNamaPelanggan.Size = New Size(257, 35)
        textboxNamaPelanggan.TabIndex = 1
        ' 
        ' textboxNomorPlat
        ' 
        textboxNomorPlat.Location = New Point(237, 91)
        textboxNomorPlat.Name = "textboxNomorPlat"
        textboxNomorPlat.Size = New Size(170, 35)
        textboxNomorPlat.TabIndex = 3
        ' 
        ' labelNomorPlat
        ' 
        labelNomorPlat.AutoSize = True
        labelNomorPlat.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelNomorPlat.Location = New Point(35, 94)
        labelNomorPlat.Name = "labelNomorPlat"
        labelNomorPlat.Size = New Size(124, 30)
        labelNomorPlat.TabIndex = 2
        labelNomorPlat.Text = "Nomor Plat"
        ' 
        ' textboxTarifLangganan
        ' 
        textboxTarifLangganan.Location = New Point(237, 152)
        textboxTarifLangganan.Name = "textboxTarifLangganan"
        textboxTarifLangganan.Size = New Size(170, 35)
        textboxTarifLangganan.TabIndex = 5
        ' 
        ' labelTarifLangganan
        ' 
        labelTarifLangganan.AutoSize = True
        labelTarifLangganan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTarifLangganan.Location = New Point(35, 155)
        labelTarifLangganan.Name = "labelTarifLangganan"
        labelTarifLangganan.Size = New Size(165, 30)
        labelTarifLangganan.TabIndex = 4
        labelTarifLangganan.Text = "Tarif Langganan"
        ' 
        ' labelBerlakuHingga
        ' 
        labelBerlakuHingga.AutoSize = True
        labelBerlakuHingga.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelBerlakuHingga.Location = New Point(35, 216)
        labelBerlakuHingga.Name = "labelBerlakuHingga"
        labelBerlakuHingga.Size = New Size(159, 30)
        labelBerlakuHingga.TabIndex = 6
        labelBerlakuHingga.Text = "Berlaku Hingga"
        ' 
        ' labelIDPelanggan
        ' 
        labelIDPelanggan.AutoSize = True
        labelIDPelanggan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelIDPelanggan.Location = New Point(444, 95)
        labelIDPelanggan.Name = "labelIDPelanggan"
        labelIDPelanggan.Size = New Size(139, 30)
        labelIDPelanggan.TabIndex = 8
        labelIDPelanggan.Text = "ID Pelanggan"
        ' 
        ' labelJenis
        ' 
        labelJenis.AutoSize = True
        labelJenis.Location = New Point(444, 131)
        labelJenis.Name = "labelJenis"
        labelJenis.Size = New Size(58, 30)
        labelJenis.TabIndex = 9
        labelJenis.Text = "Jenis"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 25
        ComboBox1.Location = New Point(508, 132)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(108, 33)
        ComboBox1.TabIndex = 10
        ' 
        ' buttonTambah
        ' 
        buttonTambah.Location = New Point(441, 211)
        buttonTambah.Name = "buttonTambah"
        buttonTambah.Size = New Size(101, 40)
        buttonTambah.TabIndex = 11
        buttonTambah.Text = "Tambah"
        buttonTambah.UseVisualStyleBackColor = True
        ' 
        ' buttonEdit
        ' 
        buttonEdit.Location = New Point(548, 211)
        buttonEdit.Name = "buttonEdit"
        buttonEdit.Size = New Size(101, 40)
        buttonEdit.TabIndex = 12
        buttonEdit.Text = "Edit"
        buttonEdit.UseVisualStyleBackColor = True
        ' 
        ' buttonHapus
        ' 
        buttonHapus.Location = New Point(655, 211)
        buttonHapus.Name = "buttonHapus"
        buttonHapus.Size = New Size(101, 40)
        buttonHapus.TabIndex = 13
        buttonHapus.Text = "Hapus"
        buttonHapus.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(237, 212)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(170, 35)
        DateTimePicker1.TabIndex = 14
        ' 
        ' labelKendaraanTerdaftarLangganan
        ' 
        labelKendaraanTerdaftarLangganan.AutoSize = True
        labelKendaraanTerdaftarLangganan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelKendaraanTerdaftarLangganan.Location = New Point(35, 278)
        labelKendaraanTerdaftarLangganan.Name = "labelKendaraanTerdaftarLangganan"
        labelKendaraanTerdaftarLangganan.Size = New Size(323, 30)
        labelKendaraanTerdaftarLangganan.TabIndex = 15
        labelKendaraanTerdaftarLangganan.Text = "Kendaraan terdaftar langganan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(35, 311)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.Size = New Size(721, 262)
        DataGridView1.TabIndex = 16
        ' 
        ' buttonTutup
        ' 
        buttonTutup.Location = New Point(655, 579)
        buttonTutup.Name = "buttonTutup"
        buttonTutup.Size = New Size(101, 40)
        buttonTutup.TabIndex = 17
        buttonTutup.Text = "Tutup"
        buttonTutup.UseVisualStyleBackColor = True
        ' 
        ' formLangganan
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 635)
        Controls.Add(buttonTutup)
        Controls.Add(DataGridView1)
        Controls.Add(labelKendaraanTerdaftarLangganan)
        Controls.Add(DateTimePicker1)
        Controls.Add(buttonHapus)
        Controls.Add(buttonEdit)
        Controls.Add(buttonTambah)
        Controls.Add(ComboBox1)
        Controls.Add(labelJenis)
        Controls.Add(labelIDPelanggan)
        Controls.Add(labelBerlakuHingga)
        Controls.Add(textboxTarifLangganan)
        Controls.Add(labelTarifLangganan)
        Controls.Add(textboxNomorPlat)
        Controls.Add(labelNomorPlat)
        Controls.Add(textboxNamaPelanggan)
        Controls.Add(labelNamaPelanggan)
        Name = "formLangganan"
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelNamaPelanggan As Label
    Friend WithEvents textboxNamaPelanggan As TextBox
    Friend WithEvents textboxNomorPlat As TextBox
    Friend WithEvents labelNomorPlat As Label
    Friend WithEvents textboxTarifLangganan As TextBox
    Friend WithEvents labelTarifLangganan As Label
    Friend WithEvents labelBerlakuHingga As Label
    Friend WithEvents labelIDPelanggan As Label
    Friend WithEvents labelJenis As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents buttonTambah As Button
    Friend WithEvents buttonEdit As Button
    Friend WithEvents buttonHapus As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents labelKendaraanTerdaftarLangganan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonTutup As Button
End Class
