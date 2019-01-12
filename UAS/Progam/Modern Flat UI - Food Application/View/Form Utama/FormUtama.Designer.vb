<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.lbl_hakAkses = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.pnlDepan = New System.Windows.Forms.Panel()
        Me.FormLaporan1 = New Modern_Flat_UI___Food_Application.FormLaporan()
        Me.FormPembelian1 = New Modern_Flat_UI___Food_Application.FormPembelian()
        Me.FormOperasional1 = New Modern_Flat_UI___Food_Application.FormOperasional()
        Me.FormPenjualan1 = New Modern_Flat_UI___Food_Application.FormPenjualan1()
        Me.FormKaryawan1 = New Modern_Flat_UI___Food_Application.FormKaryawan()
        Me.FormSupplier1 = New Modern_Flat_UI___Food_Application.FormSupplier()
        Me.FormPelanggan1 = New Modern_Flat_UI___Food_Application.FormPelanggan()
        Me.PnlHalamanAwal = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.FormBarang11 = New Modern_Flat_UI___Food_Application.FormBarang()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picMax = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.BtnOperasional = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.btnPelanggan = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.pnlTopSide.SuspendLayout()
        Me.pnlDepan.SuspendLayout()
        Me.PnlHalamanAwal.SuspendLayout()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.lbl_hakAkses)
        Me.pnlTopSide.Controls.Add(Me.lbl_nama)
        Me.pnlTopSide.Controls.Add(Me.lbl_id)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(200, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(752, 29)
        Me.pnlTopSide.TabIndex = 1
        '
        'lbl_hakAkses
        '
        Me.lbl_hakAkses.AutoSize = True
        Me.lbl_hakAkses.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hakAkses.Location = New System.Drawing.Point(131, 9)
        Me.lbl_hakAkses.Name = "lbl_hakAkses"
        Me.lbl_hakAkses.Size = New System.Drawing.Size(40, 13)
        Me.lbl_hakAkses.TabIndex = 2
        Me.lbl_hakAkses.Text = "Label3"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(75, 9)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(40, 13)
        Me.lbl_nama.TabIndex = 1
        Me.lbl_nama.Text = "Label2"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(20, 9)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(40, 13)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Label1"
        '
        'pnlDepan
        '
        Me.pnlDepan.BackColor = System.Drawing.Color.White
        Me.pnlDepan.Controls.Add(Me.FormLaporan1)
        Me.pnlDepan.Controls.Add(Me.FormPembelian1)
        Me.pnlDepan.Controls.Add(Me.FormOperasional1)
        Me.pnlDepan.Controls.Add(Me.FormPenjualan1)
        Me.pnlDepan.Controls.Add(Me.FormKaryawan1)
        Me.pnlDepan.Controls.Add(Me.FormSupplier1)
        Me.pnlDepan.Controls.Add(Me.FormPelanggan1)
        Me.pnlDepan.Controls.Add(Me.PnlHalamanAwal)
        Me.pnlDepan.Controls.Add(Me.FormBarang11)
        Me.pnlDepan.Location = New System.Drawing.Point(200, 35)
        Me.pnlDepan.Name = "pnlDepan"
        Me.pnlDepan.Size = New System.Drawing.Size(748, 463)
        Me.pnlDepan.TabIndex = 6
        '
        'FormLaporan1
        '
        Me.FormLaporan1.BackColor = System.Drawing.Color.White
        Me.FormLaporan1.Location = New System.Drawing.Point(0, -4)
        Me.FormLaporan1.Name = "FormLaporan1"
        Me.FormLaporan1.Size = New System.Drawing.Size(752, 466)
        Me.FormLaporan1.TabIndex = 24
        '
        'FormPembelian1
        '
        Me.FormPembelian1.BackColor = System.Drawing.Color.White
        Me.FormPembelian1.Location = New System.Drawing.Point(0, -4)
        Me.FormPembelian1.Name = "FormPembelian1"
        Me.FormPembelian1.Size = New System.Drawing.Size(752, 466)
        Me.FormPembelian1.TabIndex = 24
        '
        'FormOperasional1
        '
        Me.FormOperasional1.BackColor = System.Drawing.Color.White
        Me.FormOperasional1.Location = New System.Drawing.Point(0, 0)
        Me.FormOperasional1.Name = "FormOperasional1"
        Me.FormOperasional1.Size = New System.Drawing.Size(682, 453)
        Me.FormOperasional1.TabIndex = 24
        '
        'FormPenjualan1
        '
        Me.FormPenjualan1.BackColor = System.Drawing.Color.White
        Me.FormPenjualan1.Location = New System.Drawing.Point(0, -2)
        Me.FormPenjualan1.Name = "FormPenjualan1"
        Me.FormPenjualan1.Size = New System.Drawing.Size(752, 466)
        Me.FormPenjualan1.TabIndex = 24
        '
        'FormKaryawan1
        '
        Me.FormKaryawan1.BackColor = System.Drawing.Color.White
        Me.FormKaryawan1.Location = New System.Drawing.Point(0, -5)
        Me.FormKaryawan1.Name = "FormKaryawan1"
        Me.FormKaryawan1.Size = New System.Drawing.Size(682, 453)
        Me.FormKaryawan1.TabIndex = 0
        '
        'FormSupplier1
        '
        Me.FormSupplier1.BackColor = System.Drawing.Color.White
        Me.FormSupplier1.Location = New System.Drawing.Point(0, -5)
        Me.FormSupplier1.Name = "FormSupplier1"
        Me.FormSupplier1.Size = New System.Drawing.Size(682, 453)
        Me.FormSupplier1.TabIndex = 24
        '
        'FormPelanggan1
        '
        Me.FormPelanggan1.BackColor = System.Drawing.Color.White
        Me.FormPelanggan1.Location = New System.Drawing.Point(0, -7)
        Me.FormPelanggan1.Name = "FormPelanggan1"
        Me.FormPelanggan1.Size = New System.Drawing.Size(682, 484)
        Me.FormPelanggan1.TabIndex = 24
        '
        'PnlHalamanAwal
        '
        Me.PnlHalamanAwal.BackColor = System.Drawing.Color.White
        Me.PnlHalamanAwal.BackgroundImage = CType(resources.GetObject("PnlHalamanAwal.BackgroundImage"), System.Drawing.Image)
        Me.PnlHalamanAwal.Controls.Add(Me.BtnExit)
        Me.PnlHalamanAwal.Controls.Add(Me.BtnLogin)
        Me.PnlHalamanAwal.Location = New System.Drawing.Point(0, 0)
        Me.PnlHalamanAwal.Name = "PnlHalamanAwal"
        Me.PnlHalamanAwal.Size = New System.Drawing.Size(682, 498)
        Me.PnlHalamanAwal.TabIndex = 7
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Firebrick
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit.Location = New System.Drawing.Point(344, 411)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(109, 38)
        Me.BtnExit.TabIndex = 23
        Me.BtnExit.Text = "   Exit"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Firebrick
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogin.Location = New System.Drawing.Point(220, 411)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(109, 38)
        Me.BtnLogin.TabIndex = 22
        Me.BtnLogin.Text = "   Login"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'FormBarang11
        '
        Me.FormBarang11.BackColor = System.Drawing.Color.White
        Me.FormBarang11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBarang11.Location = New System.Drawing.Point(0, 0)
        Me.FormBarang11.Name = "FormBarang11"
        Me.FormBarang11.Size = New System.Drawing.Size(682, 498)
        Me.FormBarang11.TabIndex = 24
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTopSide
        Me.BunifuDragControl1.Vertical = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(29, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 29)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Batik"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(92, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 29)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Kita"
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 80)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 37)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.Firebrick
        Me.pnlLeftSide.Controls.Add(Me.picClose)
        Me.pnlLeftSide.Controls.Add(Me.picMinimize)
        Me.pnlLeftSide.Controls.Add(Me.picMax)
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.BtnLogout)
        Me.pnlLeftSide.Controls.Add(Me.BtnLaporan)
        Me.pnlLeftSide.Controls.Add(Me.BtnOperasional)
        Me.pnlLeftSide.Controls.Add(Me.BtnPembelian)
        Me.pnlLeftSide.Controls.Add(Me.btnPenjualan)
        Me.pnlLeftSide.Controls.Add(Me.btnKaryawan)
        Me.pnlLeftSide.Controls.Add(Me.btnPelanggan)
        Me.pnlLeftSide.Controls.Add(Me.btnSupplier)
        Me.pnlLeftSide.Controls.Add(Me.btnBarang)
        Me.pnlLeftSide.Controls.Add(Me.Label19)
        Me.pnlLeftSide.Controls.Add(Me.Label16)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(200, 548)
        Me.pnlLeftSide.TabIndex = 0
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(4, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 30
        Me.picClose.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(45, 3)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(18, 18)
        Me.picMinimize.TabIndex = 29
        Me.picMinimize.TabStop = False
        '
        'picMax
        '
        Me.picMax.BackgroundImage = CType(resources.GetObject("picMax.BackgroundImage"), System.Drawing.Image)
        Me.picMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMax.Location = New System.Drawing.Point(25, 3)
        Me.picMax.Name = "picMax"
        Me.picMax.Size = New System.Drawing.Size(18, 18)
        Me.picMax.TabIndex = 28
        Me.picMax.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogout.Location = New System.Drawing.Point(-11, 429)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(200, 37)
        Me.BtnLogout.TabIndex = 27
        Me.BtnLogout.Text = "   Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnLaporan
        '
        Me.BtnLaporan.FlatAppearance.BorderSize = 0
        Me.BtnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaporan.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporan.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnLaporan.Image = CType(resources.GetObject("BtnLaporan.Image"), System.Drawing.Image)
        Me.BtnLaporan.Location = New System.Drawing.Point(-9, 386)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Size = New System.Drawing.Size(200, 37)
        Me.BtnLaporan.TabIndex = 26
        Me.BtnLaporan.Text = "   Laporan"
        Me.BtnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLaporan.UseVisualStyleBackColor = True
        '
        'BtnOperasional
        '
        Me.BtnOperasional.FlatAppearance.BorderSize = 0
        Me.BtnOperasional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperasional.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOperasional.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnOperasional.Image = CType(resources.GetObject("BtnOperasional.Image"), System.Drawing.Image)
        Me.BtnOperasional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOperasional.Location = New System.Drawing.Point(-8, 343)
        Me.BtnOperasional.Name = "BtnOperasional"
        Me.BtnOperasional.Size = New System.Drawing.Size(200, 37)
        Me.BtnOperasional.TabIndex = 25
        Me.BtnOperasional.Text = "   Operasional"
        Me.BtnOperasional.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOperasional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOperasional.UseVisualStyleBackColor = True
        '
        'BtnPembelian
        '
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPembelian.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPembelian.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnPembelian.Image = CType(resources.GetObject("BtnPembelian.Image"), System.Drawing.Image)
        Me.BtnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPembelian.Location = New System.Drawing.Point(-1, 300)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(200, 37)
        Me.BtnPembelian.TabIndex = 24
        Me.BtnPembelian.Text = "   Pembelian"
        Me.BtnPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPembelian.UseVisualStyleBackColor = True
        '
        'btnPenjualan
        '
        Me.btnPenjualan.FlatAppearance.BorderSize = 0
        Me.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenjualan.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPenjualan.Image = CType(resources.GetObject("btnPenjualan.Image"), System.Drawing.Image)
        Me.btnPenjualan.Location = New System.Drawing.Point(-2, 257)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(200, 37)
        Me.btnPenjualan.TabIndex = 23
        Me.btnPenjualan.Text = "   Penjualan"
        Me.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'btnKaryawan
        '
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnKaryawan.Image = CType(resources.GetObject("btnKaryawan.Image"), System.Drawing.Image)
        Me.btnKaryawan.Location = New System.Drawing.Point(-7, 210)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(200, 37)
        Me.btnKaryawan.TabIndex = 22
        Me.btnKaryawan.Text = "   Karyawan"
        Me.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKaryawan.UseVisualStyleBackColor = True
        '
        'btnPelanggan
        '
        Me.btnPelanggan.FlatAppearance.BorderSize = 0
        Me.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelanggan.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPelanggan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPelanggan.Image = CType(resources.GetObject("btnPelanggan.Image"), System.Drawing.Image)
        Me.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPelanggan.Location = New System.Drawing.Point(-1, 122)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Size = New System.Drawing.Size(200, 37)
        Me.btnPelanggan.TabIndex = 21
        Me.btnPelanggan.Text = "   Pelanggan"
        Me.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPelanggan.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSupplier.Image = CType(resources.GetObject("btnSupplier.Image"), System.Drawing.Image)
        Me.btnSupplier.Location = New System.Drawing.Point(4, 167)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(195, 37)
        Me.btnSupplier.TabIndex = 20
        Me.btnSupplier.Text = "   Supplier"
        Me.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("EngraversGothic BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBarang.Image = CType(resources.GetObject("btnBarang.Image"), System.Drawing.Image)
        Me.btnBarang.Location = New System.Drawing.Point(-1, 79)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(200, 37)
        Me.btnBarang.TabIndex = 19
        Me.btnBarang.Text = "   Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 548)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlDepan)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlTopSide.PerformLayout()
        Me.pnlDepan.ResumeLayout(False)
        Me.PnlHalamanAwal.ResumeLayout(False)
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents pnlDepan As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnLaporan As Button
    Friend WithEvents BtnOperasional As Button
    Friend WithEvents BtnPembelian As Button
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents btnKaryawan As Button
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnBarang As Button
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMax As PictureBox
    Friend WithEvents PnlHalamanAwal As Panel
    Friend WithEvents FormBarang11 As FormBarang
    Friend WithEvents lbl_hakAkses As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents FormPelanggan1 As FormPelanggan
    Friend WithEvents FormSupplier1 As FormSupplier
    Friend WithEvents FormKaryawan1 As FormKaryawan
    Friend WithEvents FormPenjualan1 As FormPenjualan1
    Friend WithEvents FormPembelian1 As FormPembelian
    Friend WithEvents FormOperasional1 As FormOperasional
    Friend WithEvents FormLaporan1 As FormLaporan
End Class
