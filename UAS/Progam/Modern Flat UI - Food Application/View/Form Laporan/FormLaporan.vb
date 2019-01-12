Public Class FormLaporan
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs) Handles btn_penjualan.Click
        FormLaporanPenjualan.Show()
    End Sub

    Private Sub btn_pembelian_Click(sender As Object, e As EventArgs) Handles btn_pembelian.Click
        FormLaporanPembelian.Show()
    End Sub

    Private Sub btn_labarugi_Click(sender As Object, e As EventArgs) Handles btn_labarugi.Click
        FormLaporanLabaRugi.Show()
    End Sub

    Private Sub btn_stokbarang_Click(sender As Object, e As EventArgs) Handles btn_stokbarang.Click
        FormLaporanStokBarang.Show()
    End Sub
End Class
