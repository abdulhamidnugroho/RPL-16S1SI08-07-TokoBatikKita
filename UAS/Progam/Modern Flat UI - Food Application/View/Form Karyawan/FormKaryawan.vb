Public Class FormKaryawan
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
                txt_idkaryawan.Text = .Cells(0).Value.ToString
                txt_nama.Text = .Cells(1).Value.ToString
                txt_pass.Text = .Cells(2).Value.ToString
                cmb_hak.Text = .Cells(3).Value.ToString

            End With
            LblBaris.Text = "Date ke-" & br + 1 & " dari " & DataGridView1.RowCount - 1 & " data "
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolKaryawan.tampilData.ToTable
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
        DTGrid = KontrolKaryawan.cariData(kunci).ToTable

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
    Sub TampilStatus()
        cmb_hak.Items.Clear()
        cmb_hak.Items.Add("OWNER")
        cmb_hak.Items.Add("KARYAWAN")
    End Sub
    Private Sub FormKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        DataGridView1.Columns(1).Width = 183
        txt_idkaryawan.Enabled = False
        TampilStatus()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        AturButton(False)
        modeProses = 1

        txt_nama.Text = ""
        txt_pass.Text = ""
        cmb_hak.Text = ""


        txt_idkaryawan.Text = KontrolKaryawan.kodeBaru
        txt_nama.Focus()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        AturButton(False)
        modeProses = 2
        txt_nama.Focus()
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
        If txt_idkaryawan.Text = "" Or txt_nama.Text = "" Or txt_pass.Text = "" Or cmb_hak.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan ID USER  dan Semua form terisi")
            Exit Sub
        Else
            With EntitasKaryawan
                .idkaryawan = txt_idkaryawan.Text
                .namakaryawan = txt_nama.Text
                .passwords = txt_pass.Text
                .hakakses = cmb_hak.Text

            End With

            If modeProses = 1 Then
                KontrolKaryawan.InsertData(EntitasKaryawan)
            ElseIf modeProses = 2 Then
                KontrolKaryawan.updateData(EntitasKaryawan)
            End If
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        End If

        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim status_referensi As Boolean
        Dim status_referensi2 As Boolean
        status_referensi = KontrolKaryawan.cekKaryawanDireferensi(txt_idkaryawan.Text)
        status_referensi2 = KontrolKaryawan.cekKaryawanDireferensi2(txt_idkaryawan.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        If status_referensi2 Then
            MsgBox("Data masih digunakan tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txt_idkaryawan.Text & "-" & txt_nama.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKaryawan.deleteData(txt_idkaryawan.Text)

        End If
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs) Handles txt_nama.TextChanged

    End Sub
End Class
