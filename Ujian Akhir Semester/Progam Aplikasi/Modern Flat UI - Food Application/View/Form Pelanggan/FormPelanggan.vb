Public Class FormPelanggan
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
    Sub TampilStatus()
        cmb_jk.Items.Clear()
        cmb_jk.Items.Add("LAKI-LAKI")
        cmb_jk.Items.Add("WANITA")
    End Sub
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DataGridView1.Rows(br)
                txt_idpelanggan.Text = .Cells(0).Value.ToString
                txt_nama.Text = .Cells(1).Value.ToString
                txt_alamat.Text = .Cells(2).Value.ToString
                txt__notelepon.Text = .Cells(3).Value.ToString
                cmb_jk.Text = .Cells(4).Value.ToString
            End With
            LblBaris.Text = "Date ke-" & br + 1 & " dari " & DataGridView1.RowCount - 1 & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolPelanggan.tampilData.ToTable
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
        DTGrid = KontrolPelanggan.cariData(kunci).ToTable

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
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        Call TampilStatus()
        txt_idpelanggan.Enabled = False
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        AturButton(False)
        modeProses = 1

        txt_nama.Text = ""
        txt_alamat.Text = ""
        txt__notelepon.Text = ""
        cmb_jk.Text = ""

        txt_idpelanggan.Text = KontrolPelanggan.kodeBaru
        txt_nama.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        AturButton(False)
        modeProses = 2
        txt_idpelanggan.Focus()
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

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_idpelanggan.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Or txt__notelepon.Text = "" Or cmb_jk.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan ID PELANGGAN  dan Semua form terisi")
            Exit Sub
        Else
            With EntitasPelanggan
                .idpelanggan = txt_idpelanggan.Text
                .namapelanggan = txt_nama.Text
                .alamatpelanggan = txt_alamat.Text
                .no_hp = txt__notelepon.Text
                .jeniskelamin = cmb_jk.Text
            End With

            If modeProses = 1 Then
                KontrolPelanggan.InsertData(EntitasPelanggan)
            ElseIf modeProses = 2 Then
                KontrolPelanggan.updateData(EntitasPelanggan)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        End If

        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolPelanggan.cekPelangganDireferensi(txt_idpelanggan.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txt_idpelanggan.Text & "-" & txt_nama.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolPelanggan.deleteData(txt_idpelanggan.Text)

        End If
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        If txt_cari.Text = "" Then
            Call RefreshGrid()

        Else
            Call TampilCari(txt_cari.Text)
            txt_cari.Focus()
        End If
    End Sub
End Class
