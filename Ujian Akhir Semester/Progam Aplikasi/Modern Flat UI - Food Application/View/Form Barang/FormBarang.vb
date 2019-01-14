Public Class FormBarang
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btn_tambah.Enabled = st
        btn_update.Enabled = st
        btn_hapus.Enabled = st
        btn_simpan.Enabled = Not st
        btn_batal.Enabled = Not st

        gb_ataskiri.Enabled = Not st
        gb_cari.Enabled = st
        gb_ataskanan.Enabled = Not st

    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DataGridView1.Rows(br)
                txt_idbarang.Text = .Cells(0).Value.ToString
                txt_namabarang.Text = .Cells(1).Value.ToString
                txt_hargabeli.Text = .Cells(2).Value.ToString
                txt_hargajual.Text = .Cells(3).Value.ToString
                txt_jumlahstok.Text = .Cells(4).Value.ToString
            End With
            LblBaris.Text = "Date ke-" & br + 1 & " dari " & DataGridView1.RowCount - 1 & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DataGridView1.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DataGridView1.Rows(DTGrid.Rows.Count - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DataGridView1.DataSource = DTGrid
            DataGridView1.Rows(DTGrid.Rows.Count - 1).Selected = True
            DataGridView1.CurrentCell = DataGridView1.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If


    End Sub
    Private Sub FormBarang1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        'DataGridView1.Columns(1).Width = 215
        txt_idbarang.Enabled = False
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        AturButton(False)
        modeProses = 1

        txt_namabarang.Text = ""
        txt_hargabeli.Text = ""
        txt_hargajual.Text = ""
        txt_jumlahstok.Text = ""

        txt_idbarang.Text = KontrolBarang.kodeBaru
        txt_namabarang.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        AturButton(False)
        modeProses = 2
        txt_namabarang.Focus()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Call RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DataGridView1.Rows(baris).Selected = True
            IsiBox(baris)

        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        If txt_cari.Text = "" Then
            Call RefreshGrid()

        Else
            Call TampilCari(txt_cari.Text)
            txt_cari.Focus()
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_idbarang.Text = "" Or txt_namabarang.Text = "" Or txt_hargabeli.Text = "" Or txt_hargajual.Text = "" Or txt_jumlahstok.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan ID BARANG  dan Semua form terisi")
            Exit Sub
        Else
            With EntitasBarang
                .idbarang = txt_idbarang.Text
                .namabarang = txt_namabarang.Text
                .hargabeliBarang = txt_hargabeli.Text
                .hargajualBarang = txt_hargajual.Text
                .stokBarang = txt_jumlahstok.Text
            End With

            If modeProses = 1 Then
                KontrolBarang.InsertData(EntitasBarang)
            ElseIf modeProses = 2 Then
                KontrolBarang.updateData(EntitasBarang)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        End If

        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim status_referensi As Boolean
        Dim status_referensi2 As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txt_idbarang.Text)
        status_referensi2 = KontrolBarang.cekBarangDireferensi2(txt_idbarang.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        If status_referensi2 Then
            MsgBox("Data masih digunakan tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txt_idbarang.Text & "-" & txt_namabarang.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(txt_idbarang.Text)

        End If
        RefreshGrid()
        modeProses = 0
    End Sub
End Class
