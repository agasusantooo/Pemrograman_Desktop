Public Class formUtama

    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Dim formUbahProfil As New formUbahProfil()
        formUbahProfil.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim formLogin As New formLogin()
        Me.Hide()
        formLogin.Show()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim formLangganan As New formLangganan()
        formLangganan.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim formLaporan As New formLaporanPendapatanParkir()
        formLaporan.Show()
    End Sub
End Class