Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanStokBarang
    Private Sub FormLaporanStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub tampilkan()
        Dim stringFormula As String
        Dim ReportKu As New ReportDocument
        ReportKu.Load("D:\Perkuliahan\Tugas Kuliah Sem 5\Rekeyaya Perangkat Lunak\Afrig (2018-2019)\Final Project\Progam\Modern Flat UI - Food Application\Modern Flat UI - Food Application\Laporan\LaporanStokBarang.rpt")
        CrystalReportViewer1.ReportSource = ReportKu


        If Not String.IsNullOrEmpty(Me.txt_cari.Text) Then
            stringFormula = "{Barang.nama_barang} Like '*" & txt_cari.Text.ToString() & "*' "

        Else
            stringFormula = ""
        End If


        CrystalReportViewer1.SelectionFormula = stringFormula
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub btn_tampilkan_Click(sender As Object, e As EventArgs) Handles btn_tampilkan.Click
        tampilkan()
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        Me.Close()
    End Sub
End Class