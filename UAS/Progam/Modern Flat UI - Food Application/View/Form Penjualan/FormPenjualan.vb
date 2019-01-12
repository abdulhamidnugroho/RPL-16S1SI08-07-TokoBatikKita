Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormPenjualan1
    Dim table As New DataTable("Table")

    Dim SubTotal As Double
    Dim Total As Double
    Dim Hargajual = txt_hargabarang
    Dim Jumlah = txt_jumlah
    Dim Dibayar = txt_dibayar
    Dim kembali = txt_kembali
    Dim grandtotal = txt_grandtotal

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_diskon.Enabled = False
        txt_idnota.Enabled = False
        txt_namabarang.Enabled = False
        txt_username.Enabled = False
        cmb_iduser.Enabled = False
        txt_namapelanggan.Enabled = False
        txt_hargabarang.Enabled = False
        txt_jumlahbarang.Enabled = False
        txt_total.Enabled = False
        txt_kembali.Enabled = False
        txt_grandtotal.Enabled = False
        Call idnotaOtomatis()
        lbl_tanggal.Text = Today
        Call KondisiAwal()
        Call KondisiAwal2()
        Call KondisiAwal3()
        'Me.MdiParent = FormUtama
        table.Columns.Add("ID BARANG", Type.GetType("System.Int32"))
        table.Columns.Add("NAMA BARANG", Type.GetType("System.String"))
        table.Columns.Add("HARGA JUAL", Type.GetType("System.String"))
        table.Columns.Add("JUMLAH", Type.GetType("System.Int32"))
        table.Columns.Add("SUB TOTAL", Type.GetType("System.Int32"))
        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Me.dtp_tanggal.Value.ToShortDateString()
    End Sub
    Sub idnotaOtomatis()

        CMD = New OleDbCommand("select ID_NOTAJUAL from PENJUALAN order by ID_NOTAJUAL desc", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If Not DTR.HasRows Then
            txt_idnota.Text = Format(Today, "yyMMdd") + "0001"

        Else
            If Microsoft.VisualBasic.Left(DTR.Item("ID_NOTAJUAL"), 6) = Format(Today, "yyMMdd") Then
                txt_idnota.Text = DTR.Item("ID_NOTAJUAL") + 1

            Else

                txt_idnota.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
    End Sub
    Sub KondisiAwal()

        DTA = New OleDbDataAdapter("Select * from Pelanggan", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "Pelanggan")
        'DataGridView1.DataSource = (DTS.Tables("Pelanggan"))

        CMD = New OleDbCommand("select * FROM Pelanggan", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_idpelanggan.Items.Add(DTR.Item(0))
        Loop

    End Sub
    Sub KondisiAwal2()

        DTA = New OleDbDataAdapter("Select * from KARYAWAN", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "KARYAWAN")
        'DataGridView1.DataSource = (DTS.Tables("KARYAWAN"))

        CMD = New OleDbCommand("select * FROM KARYAWAN", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_iduser.Items.Add(DTR.Item(0))
        Loop
        'cmb_iduser.Text = FormUtama.lbl_id.Text
        'txt_username.Text = FormUtama.lbl_nama.Text
    End Sub
    Sub KondisiAwal3()

        DTA = New OleDbDataAdapter("Select * from barang", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "barang")
        'DataGridView1.DataSource = (DTS.Tables("barang"))

        CMD = New OleDbCommand("select * FROM barang", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_idbarang.Items.Add(DTR.Item(0))
        Loop

    End Sub

    Private Sub cmb_idpelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_idpelanggan.SelectedIndexChanged
        CMD = New OleDbCommand("Select * from Pelanggan where id_pelanggan='" & cmb_idpelanggan.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_namapelanggan.Text = DTR.Item("Nama")
        End If
    End Sub

    Private Sub cmb_idbarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_idbarang.SelectedIndexChanged
        CMD = New OleDbCommand("Select * from barang where id_barang='" & cmb_idbarang.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_namabarang.Text = DTR.Item("nama_barang")
            txt_hargabarang.Text = DTR.Item("harga_jual")
        End If
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If txt_jumlah.Text = "" Or txt_idnota.Text = "" Then
            MsgBox("Ada Data yang kosong")
            Exit Sub
        Else

            table.Rows.Add(cmb_idbarang.Text, txt_namabarang.Text, txt_hargabarang.Text, txt_jumlah.Text, (txt_hargabarang.Text * txt_jumlah.Text))

            DataGridView1.DataSource = table

            Dim sum As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(3).Value
            Next

            txt_jumlahbarang.Text = sum.ToString()

            DataGridView1.DataSource = table
            Dim sum2 As Double = 0
            For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum2 = sum2 + DataGridView1.Rows(i).Cells(4).Value
            Next

            txt_total.Text = sum2.ToString()



        End If

        cmb_iduser.Text = FormUtama.lbl_id.Text
        txt_username.Text = FormUtama.lbl_nama.Text
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        If (txt_total.Text) >= 10000000 Then
            txt_diskon.Text = 300000
            txt_grandtotal.Text = (txt_total.Text - txt_diskon.Text)
        Else
            txt_diskon.Text = 0
            txt_grandtotal.Text = (txt_total.Text - txt_diskon.Text)
        End If
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        If txt_dibayar.Text = "" Or txt_grandtotal.Text = "" Then
            MsgBox("Anda harus memasukkan pembayaran terlebih dahulu")
            Exit Sub
        Else
            txt_kembali.Text = txt_dibayar.Text - txt_grandtotal.Text

        End If
    End Sub
    Sub Bersihkan()

        cmb_idpelanggan.Text = ""
        txt_namapelanggan.Text = ""


        cmb_idbarang.Text = ""
        txt_namabarang.Text = ""
        txt_hargabarang.Text = ""
        txt_jumlah.Text = ""
        txt_jumlahbarang.Text = ""
        txt_total.Text = 0

        txt_diskon.Text = 0
        txt_grandtotal.Text = 0
        txt_dibayar.Text = 0
        txt_kembali.Text = 0
        Me.DataGridView1.DataSource.clear()
        txt_idnota.Focus()

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Call Bersihkan()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)

        DataGridView1.DataSource = table
        Dim sum3 As Double = 0
        For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum3 = sum3 + DataGridView1.Rows(i).Cells(3).Value
        Next

        txt_jumlahbarang.Text = sum3.ToString()

        DataGridView1.DataSource = table
        Dim sum4 As Double = 0
        For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum4 = sum4 + DataGridView1.Rows(i).Cells(4).Value
        Next

        txt_total.Text = sum4.ToString()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If cmb_idpelanggan.Text = "" Or txt_idnota.Text = "" Or cmb_iduser.Text = "" Or txt_dibayar.Text = "" Or txt_total.Text = "" Or txt_grandtotal.Text = "" Or txt_kembali.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan ID NOTA  dan Semua form terisi")
            Exit Sub
        Else

            Dim simpan As String = "insert into PENJUALAN values ('" & txt_idnota.Text & "','" & lbl_tanggal.Text & "','" & txt_grandtotal.Text & "','" & cmb_idpelanggan.Text & "','" & cmb_iduser.Text & "','" & txt_dibayar.Text & "','" & txt_kembali.Text & "','" & txt_jumlahbarang.Text & "','" & txt_diskon.Text & "')"
            CMD = New OleDbCommand(simpan, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2



                'simpan ke tabel detail
                Dim sqlsimpan As String = "Insert into ITEM_PENJUALAN (ID_NOTAJUAL,ID_BARANG,NAMA_BARANG,HARGA_JUAL,JUMLAH,SUBTOTAL) values " &
                "('" & txt_idnota.Text & "','" & DataGridView1.Rows(baris).Cells(0).Value &
                "','" & DataGridView1.Rows(baris).Cells(1).Value & "','" &
                DataGridView1.Rows(baris).Cells(2).Value & "','" & DataGridView1.Rows(baris).Cells(3).Value & "','" &
                DataGridView1.Rows(baris).Cells(4).Value & "')"
                CMD = New OleDbCommand(sqlsimpan, BUKAKONEKSI)
                CMD.ExecuteNonQuery()



                'kurangi stok barang
                CMD = New OleDbCommand("select * from barang where ID_BARANG='" &
    DataGridView1.Rows(baris).Cells(0).Value & "'", BUKAKONEKSI)
                DTR = CMD.ExecuteReader
                DTR.Read()
                If DTR.HasRows Then

                    Dim tambahstok As String = "update barang set STOK=
 '" & DTR.Item(4) - DataGridView1.Rows(baris).Cells(3).Value & "' where ID_BARANG='" &
     DataGridView1.Rows(baris).Cells(0).Value & "'"
                    CMD = New OleDbCommand(tambahstok, BUKAKONEKSI)
                    CMD.ExecuteNonQuery()

                End If

            Next baris
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

        End If

        'simpan ke operasional
        Dim simpanop As String = "insert into OPERASIONAL values ('" & cmb_iduser.Text & "','" & lbl_tanggal.Text & "','" & lbl_penjualan.Text & "','" & lbl_0.Text & "','" & txt_grandtotal.Text & "')"
        CMD = New OleDbCommand(simpanop, BUKAKONEKSI)
        CMD.ExecuteNonQuery()

        Call Bersihkan()
        Call idnotaOtomatis()

        If MessageBox.Show("Cetak Nota..?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim ReportKu As New ReportDocument
            ReportKu.Load("D:\Perkuliahan\Tugas Kuliah Sem 5\Rekeyaya Perangkat Lunak\Afrig (2018-2019)\Final Project\Progam\Modern Flat UI - Food Application\Modern Flat UI - Food Application\Laporan\NotaPenjualan.rpt")
            FormNotaPenjualan.Show()
            FormNotaPenjualan.CRV.ReportSource = Nothing
            FormNotaPenjualan.CRV.ReportSource = ReportKu
            FormNotaPenjualan.CRV.RefreshReport()
            FormNotaPenjualan.CRV.RefreshReport()



        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        cmb_idbarang.Items.Clear()
        KondisiAwal3()
        cmb_idpelanggan.Items.Clear()
        KondisiAwal()
        cmb_iduser.Items.Clear()
        KondisiAwal2()

        cmb_iduser.Text = FormUtama.lbl_id.Text
        txt_username.Text = FormUtama.lbl_nama.Text

    End Sub
End Class
