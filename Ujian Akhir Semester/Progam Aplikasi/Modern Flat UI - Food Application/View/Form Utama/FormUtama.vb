Public Class FormUtama
    Sub terkunci()
        btnBarang.Visible = False
        btnPelanggan.Visible = False
        btnSupplier.Visible = False
        btnKaryawan.Visible = False
        btnPenjualan.Visible = False
        BtnPembelian.Visible = False
        BtnOperasional.Visible = False
        BtnLaporan.Visible = False
        BtnLogout.Visible = False

        PnlHalamanAwal.Visible = True
        BtnLogin.Visible = True
        BtnExit.Visible = True

        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False


        lbl_id.Text = ""
        lbl_nama.Text = ""
        lbl_hakAkses.Text = ""
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) Handles picMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub pnlLeftSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeftSide.Paint

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkunci()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        pnlOnButtonPosition.Height = btnBarang.Height
        pnlOnButtonPosition.Top = btnBarang.Top


        FormBarang11.Show()
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False


    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        pnlOnButtonPosition.Height = btnPelanggan.Height
        pnlOnButtonPosition.Top = btnPelanggan.Top


        FormPelanggan1.Show()
        FormBarang11.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        pnlOnButtonPosition.Height = btnSupplier.Height
        pnlOnButtonPosition.Top = btnSupplier.Top

        FormSupplier1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False
    End Sub

    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        pnlOnButtonPosition.Height = btnKaryawan.Height
        pnlOnButtonPosition.Top = btnKaryawan.Top

        FormKaryawan1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        pnlOnButtonPosition.Height = btnPenjualan.Height
        pnlOnButtonPosition.Top = btnPenjualan.Top

        FormPenjualan1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False

    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        pnlOnButtonPosition.Height = BtnPembelian.Height
        pnlOnButtonPosition.Top = BtnPembelian.Top

        FormPembelian1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormOperasional1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False



    End Sub

    Private Sub BtnOperasional_Click(sender As Object, e As EventArgs) Handles BtnOperasional.Click
        pnlOnButtonPosition.Height = BtnOperasional.Height
        pnlOnButtonPosition.Top = BtnOperasional.Top

        FormOperasional1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormLaporan1.Visible = False

        PnlHalamanAwal.Visible = False
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        pnlOnButtonPosition.Height = BtnLaporan.Height
        pnlOnButtonPosition.Top = BtnLaporan.Top

        FormLaporan1.Show()
        FormBarang11.Visible = False
        FormPelanggan1.Visible = False
        FormSupplier1.Visible = False
        FormKaryawan1.Visible = False
        FormPenjualan1.Visible = False
        FormPembelian1.Visible = False
        FormOperasional1.Visible = False

        PnlHalamanAwal.Visible = False
    End Sub

    Private Sub FormBarang11_Load(sender As Object, e As EventArgs) Handles FormBarang11.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        FormLogin.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Call terkunci()
    End Sub

    Private Sub FormPembelian1_Load(sender As Object, e As EventArgs) Handles FormPembelian1.Load

    End Sub
End Class
