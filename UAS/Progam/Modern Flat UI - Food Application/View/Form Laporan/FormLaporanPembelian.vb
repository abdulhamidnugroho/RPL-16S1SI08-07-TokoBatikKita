Imports CrystalDecisions.CrystalReports.Engine

Public Class FormLaporanPembelian
    Sub KetentuanTanggal()
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
    End Sub
    Private Sub FormLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KetentuanTanggal()
        'Me.MdiParent = FormUtama
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_cari.Enabled = True
            txt_cari.Focus()
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        Else
            txt_cari.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim stringFormula As String
        Dim ReportKu As New ReportDocument
        ReportKu.Load("D:\Perkuliahan\Tugas Kuliah Sem 5\Rekeyaya Perangkat Lunak\Afrig (2018-2019)\Final Project\Progam\Modern Flat UI - Food Application\Modern Flat UI - Food Application\Laporan\LaporanPembelian.rpt")
        CrystalReportViewer1.ReportSource = ReportKu

        If CheckBox1.Checked = True Then
            If Not String.IsNullOrEmpty(Me.txt_cari.Text) Then
                stringFormula = "{supplier.nama} Like '*" & txt_cari.Text.ToString() & "*' "
                stringFormula &= " Or {karyawan.nama} Like '*" & txt_cari.Text.ToString() & "*' "
            Else
                stringFormula = ""
            End If

        Else
            stringFormula = "{PEMBELIAN.Tanggal} >= #" & Me.DateTimePicker1.Value.ToShortDateString & "#"
            stringFormula &= "And {PEMBELIAN.Tanggal} <= #" & Me.DateTimePicker2.Value.ToShortDateString & "#"


        End If
        CrystalReportViewer1.SelectionFormula = stringFormula
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class