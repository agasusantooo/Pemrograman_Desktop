<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLaporanPendapatanParkir
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
        labelPeriode = New Label()
        comboboxBulan = New ComboBox()
        buttonTampilkan = New Button()
        TextBox1 = New TextBox()
        labelLaporan = New Label()
        DataGridView1 = New DataGridView()
        buttonTutup = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelPeriode
        ' 
        labelPeriode.AutoSize = True
        labelPeriode.Location = New Point(23, 22)
        labelPeriode.Name = "labelPeriode"
        labelPeriode.Size = New Size(82, 30)
        labelPeriode.TabIndex = 0
        labelPeriode.Text = "Periode"
        ' 
        ' comboboxBulan
        ' 
        comboboxBulan.FormattingEnabled = True
        comboboxBulan.Location = New Point(111, 19)
        comboboxBulan.Name = "comboboxBulan"
        comboboxBulan.Size = New Size(92, 38)
        comboboxBulan.TabIndex = 1
        ' 
        ' buttonTampilkan
        ' 
        buttonTampilkan.Location = New Point(324, 17)
        buttonTampilkan.Name = "buttonTampilkan"
        buttonTampilkan.Size = New Size(131, 40)
        buttonTampilkan.TabIndex = 3
        buttonTampilkan.Text = "Tampilkan"
        buttonTampilkan.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(214, 19)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Tahun"
        TextBox1.Size = New Size(104, 35)
        TextBox1.TabIndex = 4
        ' 
        ' labelLaporan
        ' 
        labelLaporan.AutoSize = True
        labelLaporan.Location = New Point(23, 72)
        labelLaporan.Name = "labelLaporan"
        labelLaporan.Size = New Size(99, 30)
        labelLaporan.TabIndex = 5
        labelLaporan.Text = "Laporan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ButtonHighlight
        DataGridView1.Location = New Point(31, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 72
        DataGridView1.Size = New Size(739, 277)
        DataGridView1.TabIndex = 6
        ' 
        ' buttonTutup
        ' 
        buttonTutup.Location = New Point(639, 373)
        buttonTutup.Name = "buttonTutup"
        buttonTutup.Size = New Size(131, 40)
        buttonTutup.TabIndex = 7
        buttonTutup.Text = "Tutup"
        buttonTutup.UseVisualStyleBackColor = True
        ' 
        ' formLaporanPendapatanParkir
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(buttonTutup)
        Controls.Add(DataGridView1)
        Controls.Add(labelLaporan)
        Controls.Add(TextBox1)
        Controls.Add(buttonTampilkan)
        Controls.Add(comboboxBulan)
        Controls.Add(labelPeriode)
        Name = "formLaporanPendapatanParkir"
        Text = "SIParkir - Laporan Pendapatan Parkir"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelPeriode As Label
    Friend WithEvents comboboxBulan As ComboBox
    Friend WithEvents buttonTampilkan As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labelLaporan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonTutup As Button
End Class
