<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_grandtotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.txt_kembali = New System.Windows.Forms.TextBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_dibayar = New System.Windows.Forms.TextBox()
        Me.txt_jumlahbarang = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_0 = New System.Windows.Forms.Label()
        Me.lbl_pembelian = New System.Windows.Forms.Label()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_hargabarang = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_idbarang = New System.Windows.Forms.ComboBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_idnota = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.cmb_iduser = New System.Windows.Forms.ComboBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_idsupplier = New System.Windows.Forms.ComboBox()
        Me.txt_namasupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_grandtotal
        '
        Me.txt_grandtotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grandtotal.Location = New System.Drawing.Point(158, 438)
        Me.txt_grandtotal.Name = "txt_grandtotal"
        Me.txt_grandtotal.Size = New System.Drawing.Size(112, 22)
        Me.txt_grandtotal.TabIndex = 106
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(44, 442)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Grand Total"
        '
        'txt_diskon
        '
        Me.txt_diskon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diskon.Location = New System.Drawing.Point(418, 385)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(112, 22)
        Me.txt_diskon.TabIndex = 104
        Me.txt_diskon.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(305, 390)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Diskon"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(304, 443)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Kembali"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(304, 415)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Dibayar"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(731, 187)
        Me.DataGridView1.TabIndex = 100
        '
        'btn_hitung
        '
        Me.btn_hitung.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hitung.Location = New System.Drawing.Point(657, 427)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(75, 29)
        Me.btn_hitung.TabIndex = 99
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hapus.Location = New System.Drawing.Point(576, 427)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 29)
        Me.btn_hapus.TabIndex = 94
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'txt_kembali
        '
        Me.txt_kembali.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kembali.Location = New System.Drawing.Point(418, 437)
        Me.txt_kembali.Name = "txt_kembali"
        Me.txt_kembali.Size = New System.Drawing.Size(112, 22)
        Me.txt_kembali.TabIndex = 98
        '
        'btn_batal
        '
        Me.btn_batal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_batal.Location = New System.Drawing.Point(657, 392)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 29)
        Me.btn_batal.TabIndex = 92
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(576, 393)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 29)
        Me.btn_simpan.TabIndex = 90
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_dibayar
        '
        Me.txt_dibayar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dibayar.Location = New System.Drawing.Point(418, 411)
        Me.txt_dibayar.Name = "txt_dibayar"
        Me.txt_dibayar.Size = New System.Drawing.Size(112, 22)
        Me.txt_dibayar.TabIndex = 97
        '
        'txt_jumlahbarang
        '
        Me.txt_jumlahbarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlahbarang.Location = New System.Drawing.Point(158, 386)
        Me.txt_jumlahbarang.Name = "txt_jumlahbarang"
        Me.txt_jumlahbarang.Size = New System.Drawing.Size(112, 22)
        Me.txt_jumlahbarang.TabIndex = 96
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(158, 412)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(112, 22)
        Me.txt_total.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_refresh)
        Me.GroupBox2.Controls.Add(Me.lbl_0)
        Me.GroupBox2.Controls.Add(Me.lbl_pembelian)
        Me.GroupBox2.Controls.Add(Me.btn_tambah)
        Me.GroupBox2.Controls.Add(Me.txt_hargabarang)
        Me.GroupBox2.Controls.Add(Me.txt_jumlah)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmb_idbarang)
        Me.GroupBox2.Controls.Add(Me.txt_namabarang)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 84)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        '
        'lbl_0
        '
        Me.lbl_0.AutoSize = True
        Me.lbl_0.Location = New System.Drawing.Point(676, 28)
        Me.lbl_0.Name = "lbl_0"
        Me.lbl_0.Size = New System.Drawing.Size(13, 13)
        Me.lbl_0.TabIndex = 83
        Me.lbl_0.Text = "0"
        Me.lbl_0.Visible = False
        '
        'lbl_pembelian
        '
        Me.lbl_pembelian.AutoSize = True
        Me.lbl_pembelian.Location = New System.Drawing.Point(601, 29)
        Me.lbl_pembelian.Name = "lbl_pembelian"
        Me.lbl_pembelian.Size = New System.Drawing.Size(65, 13)
        Me.lbl_pembelian.TabIndex = 82
        Me.lbl_pembelian.Text = "PEMBELIAN"
        Me.lbl_pembelian.Visible = False
        '
        'btn_tambah
        '
        Me.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tambah.Location = New System.Drawing.Point(510, 43)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 29)
        Me.btn_tambah.TabIndex = 25
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txt_hargabarang
        '
        Me.txt_hargabarang.Location = New System.Drawing.Point(361, 22)
        Me.txt_hargabarang.Name = "txt_hargabarang"
        Me.txt_hargabarang.Size = New System.Drawing.Size(112, 22)
        Me.txt_hargabarang.TabIndex = 11
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(362, 52)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(112, 22)
        Me.txt_jumlah.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(247, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Jumlah"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(247, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Harga Barang"
        '
        'cmb_idbarang
        '
        Me.cmb_idbarang.FormattingEnabled = True
        Me.cmb_idbarang.Location = New System.Drawing.Point(105, 21)
        Me.cmb_idbarang.Name = "cmb_idbarang"
        Me.cmb_idbarang.Size = New System.Drawing.Size(112, 21)
        Me.cmb_idbarang.TabIndex = 7
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(105, 52)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(112, 22)
        Me.txt_namabarang.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Nama Barang"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ID Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Jumlah Barang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_idnota)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lbl_tanggal)
        Me.GroupBox1.Controls.Add(Me.cmb_iduser)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmb_idsupplier)
        Me.GroupBox1.Controls.Add(Me.txt_namasupplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 84)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        '
        'txt_idnota
        '
        Me.txt_idnota.Location = New System.Drawing.Point(106, 22)
        Me.txt_idnota.Name = "txt_idnota"
        Me.txt_idnota.Size = New System.Drawing.Size(112, 22)
        Me.txt_idnota.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(103, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = ":"
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.AutoSize = True
        Me.lbl_tanggal.Location = New System.Drawing.Point(113, 59)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(47, 13)
        Me.lbl_tanggal.TabIndex = 18
        Me.lbl_tanggal.Text = "Tanggal"
        '
        'cmb_iduser
        '
        Me.cmb_iduser.FormattingEnabled = True
        Me.cmb_iduser.Location = New System.Drawing.Point(581, 21)
        Me.cmb_iduser.Name = "cmb_iduser"
        Me.cmb_iduser.Size = New System.Drawing.Size(112, 21)
        Me.cmb_iduser.TabIndex = 15
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(581, 52)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(112, 22)
        Me.txt_username.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(508, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(508, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ID User"
        '
        'cmb_idsupplier
        '
        Me.cmb_idsupplier.FormattingEnabled = True
        Me.cmb_idsupplier.Location = New System.Drawing.Point(362, 21)
        Me.cmb_idsupplier.Name = "cmb_idsupplier"
        Me.cmb_idsupplier.Size = New System.Drawing.Size(112, 21)
        Me.cmb_idsupplier.TabIndex = 11
        '
        'txt_namasupplier
        '
        Me.txt_namasupplier.Location = New System.Drawing.Point(362, 52)
        Me.txt_namasupplier.Name = "txt_namasupplier"
        Me.txt_namasupplier.Size = New System.Drawing.Size(112, 22)
        Me.txt_namasupplier.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Nota Beli"
        '
        'btn_refresh
        '
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.Location = New System.Drawing.Point(591, 43)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 29)
        Me.btn_refresh.TabIndex = 84
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt_grandtotal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.txt_kembali)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_dibayar)
        Me.Controls.Add(Me.txt_jumlahbarang)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPembelian"
        Me.Size = New System.Drawing.Size(752, 466)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_grandtotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_hitung As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents txt_kembali As TextBox
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents txt_dibayar As TextBox
    Friend WithEvents txt_jumlahbarang As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_0 As Label
    Friend WithEvents lbl_pembelian As Label
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_hargabarang As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_idbarang As ComboBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_idnota As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_tanggal As Label
    Friend WithEvents cmb_iduser As ComboBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_idsupplier As ComboBox
    Friend WithEvents txt_namasupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_refresh As Button
End Class
