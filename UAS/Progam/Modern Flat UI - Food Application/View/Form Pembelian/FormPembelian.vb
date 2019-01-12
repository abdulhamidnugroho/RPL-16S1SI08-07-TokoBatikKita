Imports System.Data.OleDb
Public Class FormPembelian
    Dim table As New DataTable("Table")

    Dim SubTotal As Double
    Dim Total As Double
    Dim Hargajual = txt_hargabarang
    Dim Jumlah = txt_jumlah
    Dim Dibayar = txt_dibayar
    Dim kembali = txt_kembali
    Dim grandtotal = txt_grandtotal
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_idnota.Enabled = False
        txt_namabarang.Enabled = False
        txt_username.Enabled = False
        cmb_iduser.Enabled = False
        txt_namasupplier.Enabled = False
        txt_hargabarang.Enabled = False
        txt_jumlahbarang.Enabled = False
        txt_total.Enabled = False
        txt_kembali.Enabled = False
        Call idnotaOtomatis()
        lbl_tanggal.Text = Today
        Call KondisiAwal()
        Call KondisiAwal2()
        Call KondisiAwal3()

        'Me.MdiParent = FormUtama

        'Me.dtp_tanggal.Value.ToShortDateString()

        table.Columns.Add("ID BARANG", Type.GetType("System.Int32"))
        table.Columns.Add("NAMA BARANG", Type.GetType("System.String"))
        table.Columns.Add("HARGA BELI", Type.GetType("System.String"))
        table.Columns.Add("JUMLAH", Type.GetType("System.Int32"))
        table.Columns.Add("SUB TOTAL", Type.GetType("System.Int32"))
        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub idnotaOtomatis()

        CMD = New OleDbCommand("select ID_NOTABELI from PEMBELIAN order by ID_NOTABELI desc", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If Not DTR.HasRows Then
            txt_idnota.Text = Format(Today, "yyMMdd") + "0001"

        Else
            If Microsoft.VisualBasic.Left(DTR.Item("ID_NOTABELI"), 6) = Format(Today, "yyMMdd") Then
                txt_idnota.Text = DTR.Item("ID_NOTABELI") + 1

            Else

                txt_idnota.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
    End Sub
    Sub KondisiAwal()

        DTA = New OleDbDataAdapter("Select * from Supplier", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "Supplier")
        'DataGridView1.DataSource = (DTS.Tables("Supplier"))

        CMD = New OleDbCommand("select * FROM Supplier", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_idsupplier.Items.Add(DTR.Item(0))
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

    Private Sub cmb_idsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_idsupplier.SelectedIndexChanged
        CMD = New OleDbCommand("Select * from Supplier where id_Supplier='" & cmb_idsupplier.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_namasupplier.Text = DTR.Item("Nama")
        End If
    End Sub

    Private Sub cmb_iduser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_iduser.SelectedIndexChanged
        'CMD = New OleDbCommand("Select * from USERS where USERS='" & cmb_iduser.Text & "'", BUKAKONEKSI)
        'DTR = CMD.ExecuteReader
        'DTR.Read()
        'If DTR.HasRows Then
        '   txt_username.Text = DTR.Item("nama")
        'End If
    End Sub

    Private Sub cmb_idbarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_idbarang.SelectedIndexChanged
        CMD = New OleDbCommand("Select * from barang where id_barang='" & cmb_idbarang.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_namabarang.Text = DTR.Item("nama_barang")
            txt_hargabarang.Text = DTR.Item("harga_beli")
        End If
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If txt_jumlah.Text = "" Or txt_idnota.Text = "" Then
            MsgBox("Anda Data yang kurang")
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

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        If txt_dibayar.Text = "" Then
            MsgBox("Anda harus memasukkan pembayaran terlebih dahulu")
            Exit Sub
        Else
            txt_grandtotal.Text = (txt_total.Text - txt_diskon.Text)
            txt_kembali.Text = txt_dibayar.Text - txt_grandtotal.Text

        End If
    End Sub
    Sub Bersihkan()

        cmb_idsupplier.Text = ""
        txt_namasupplier.Text = ""


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
        If cmb_idsupplier.Text = "" Or txt_idnota.Text = "" Or cmb_iduser.Text = "" Or txt_total.Text = "" Or txt_kembali.Text = "" Or txt_dibayar.Text = "" Then
            MsgBox("Data belum lengkap, Pastikan ID NOTA  dan Semua form terisi")
            Exit Sub
        Else


            Dim simpan As String = "insert into PEMBELIAN values ('" & txt_idnota.Text & "','" & lbl_tanggal.Text & "','" & txt_grandtotal.Text & "','" & cmb_idsupplier.Text & "','" & cmb_iduser.Text & "','" & txt_dibayar.Text & "','" & txt_kembali.Text & "','" & txt_diskon.Text & "')"

            CMD = New OleDbCommand(simpan, BUKAKONEKSI)
            CMD.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                'simpan ke tabel detail
                Dim sqlsimpan As String = "Insert into ITEM_PEMBELIAN (ID_NOTABELI,ID_BARANG,NAMA_BARANG,HARGA_BELI,JUMLAH,SUBTOTAL) values " &
                "('" & txt_idnota.Text & "','" & DataGridView1.Rows(baris).Cells(0).Value &
                "','" & DataGridView1.Rows(baris).Cells(1).Value & "','" &
                DataGridView1.Rows(baris).Cells(2).Value & "','" & DataGridView1.Rows(baris).Cells(3).Value & "','" &
                DataGridView1.Rows(baris).Cells(4).Value & "')"
                CMD = New OleDbCommand(sqlsimpan, BUKAKONEKSI)
                CMD.ExecuteNonQuery()
                'CMD = New OleDbCommand(sqlsimpan, Conn)

                'tambah stok barang
                CMD = New OleDbCommand("select * from barang where ID_BARANG='" &
    DataGridView1.Rows(baris).Cells(0).Value & "'", BUKAKONEKSI)
                DTR = CMD.ExecuteReader
                DTR.Read()
                If DTR.HasRows Then

                    Dim tambahstok As String = "update barang set STOK=
 '" & DTR.Item(4) + DataGridView1.Rows(baris).Cells(3).Value & "' where ID_BARANG='" &
     DataGridView1.Rows(baris).Cells(0).Value & "'"
                    CMD = New OleDbCommand(tambahstok, BUKAKONEKSI)
                    CMD.ExecuteNonQuery()

                End If

            Next baris
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

        End If

        'simpan ke operasional
        Dim simpanop As String = "insert into OPERASIONAL values ('" & cmb_iduser.Text & "','" & lbl_tanggal.Text & "','" & lbl_pembelian.Text & "','" & txt_grandtotal.Text & "','" & lbl_0.Text & "')"
        CMD = New OleDbCommand(simpanop, BUKAKONEKSI)
        CMD.ExecuteNonQuery()




        Call Bersihkan()
        Call idnotaOtomatis()
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_grandtotal.Text = (txt_total.Text - txt_diskon.Text)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        cmb_idbarang.Items.Clear()
        KondisiAwal3()
        cmb_idsupplier.Items.Clear()
        KondisiAwal()
        cmb_iduser.Items.Clear()
        KondisiAwal2()

        cmb_iduser.Text = FormUtama.lbl_id.Text
        txt_username.Text = FormUtama.lbl_nama.Text
    End Sub
End Class
