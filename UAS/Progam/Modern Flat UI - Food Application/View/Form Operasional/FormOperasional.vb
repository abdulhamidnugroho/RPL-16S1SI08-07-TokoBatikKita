Imports System.Data.OleDb
Public Class FormOperasional
    Dim table As New DataTable("Table")
    Private Sub FormOperasional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtp_tanggal.Value.ToShortDateString()
        cmb_jenispengeluaran.Items.Clear()
        cmb_jenispengeluaran.Items.Add("BAYAR GAJI")
        cmb_jenispengeluaran.Items.Add("BAYAR PAJAK")
        cmb_jenispengeluaran.Items.Add("BAYAR LISTRIK")
        Call KondisiAwal()
        table.Columns.Add("ID USER", Type.GetType("System.String"))
        table.Columns.Add("TANGGAL", Type.GetType("System.String"))
        table.Columns.Add("JENIS PENGELUARAN", Type.GetType("System.String"))
        table.Columns.Add("PENGELUARAN", Type.GetType("System.Int32"))
        table.Columns.Add("PEMASUKAN", Type.GetType("System.Int32"))
        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtp_tanggal.Text = Today
        cmb_iduser.Enabled = False
        txt_nama.Enabled = False
    End Sub
    Sub KondisiAwal()

        DTA = New OleDbDataAdapter("Select * from KARYAWAN", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "KARYAWAN")
        DataGridView1.DataSource = (DTS.Tables("KARYAWAN"))

        CMD = New OleDbCommand("select * FROM KARYAWAN", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        Do While DTR.Read
            cmb_iduser.Items.Add(DTR.Item(0))
        Loop
        'cmb_iduser.Text = FormUtama.Label1.Text
        'txt_nama.Text = FormUtama.Label2.Text
    End Sub
    Sub Bersihkan()



        dtp_tanggal.Text = ""
        cmb_jenispengeluaran.Text = ""
        txt_nominal.Text = ""
        Me.DataGridView1.DataSource.clear()
        txt_nominal.Focus()

    End Sub

    Private Sub cmb_iduser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_iduser.SelectedIndexChanged
        CMD = New OleDbCommand("Select * from KARYAWAN where id_KARYAWAN='" & cmb_iduser.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txt_nama.Text = DTR.Item("nama")
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim index As Integer
        index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.Rows.RemoveAt(index)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If DataGridView1.CurrentCell Is Nothing Then
            MsgBox("Ada Data yang kosong")
            Exit Sub
        Else
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2

                Dim sqlsimpan As String = "Insert into OPERASIONAL (ID_KARYAWAN,TANGGAL,JENIS_PENGELUARAN,NOMINAL_PENGELUARAN,NOMINAL_PEMASUKAN) values " &
            "('" & DataGridView1.Rows(baris).Cells(0).Value &
            "','" & DataGridView1.Rows(baris).Cells(1).Value & "','" &
            DataGridView1.Rows(baris).Cells(2).Value & "','" & DataGridView1.Rows(baris).Cells(3).Value & "','" & DataGridView1.Rows(baris).Cells(4).Value & "')"
                CMD = New OleDbCommand(sqlsimpan, BUKAKONEKSI)
                CMD.ExecuteNonQuery()

            Next baris
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")

        End If
        Call Bersihkan()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click

        cmb_iduser.Text = FormUtama.lbl_id.Text
        txt_nama.Text = FormUtama.lbl_nama.Text

        If cmb_jenispengeluaran.Text = "" Or txt_nominal.Text = "" Then
            MsgBox("Ada Data yang kosong")
            Exit Sub
        Else

            table.Rows.Add(cmb_iduser.Text, dtp_tanggal.Text, cmb_jenispengeluaran.Text, txt_nominal.Text, lbl_pemasukan.Text)

            DataGridView1.DataSource = table



        End If


    End Sub
End Class
