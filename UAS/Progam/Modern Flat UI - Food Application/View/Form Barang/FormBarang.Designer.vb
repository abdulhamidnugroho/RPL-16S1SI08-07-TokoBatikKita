<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.gb_cari = New System.Windows.Forms.GroupBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.gb_ataskanan = New System.Windows.Forms.GroupBox()
        Me.txt_hargabeli = New System.Windows.Forms.TextBox()
        Me.txt_jumlahstok = New System.Windows.Forms.TextBox()
        Me.txt_hargajual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gb_ataskiri = New System.Windows.Forms.GroupBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.txt_idbarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_cari.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.gb_ataskanan.SuspendLayout()
        Me.gb_ataskiri.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBaris.Location = New System.Drawing.Point(10, 0)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(115, 15)
        Me.LblBaris.TabIndex = 52
        Me.LblBaris.Text = "Data ke-0 dari 0 data"
        '
        'gb_cari
        '
        Me.gb_cari.BackColor = System.Drawing.Color.Transparent
        Me.gb_cari.Controls.Add(Me.txt_cari)
        Me.gb_cari.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cari.Location = New System.Drawing.Point(13, 401)
        Me.gb_cari.Name = "gb_cari"
        Me.gb_cari.Size = New System.Drawing.Size(542, 48)
        Me.gb_cari.TabIndex = 51
        Me.gb_cari.TabStop = False
        Me.gb_cari.Text = "Cari Data Berdasarkan Nama"
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(9, 18)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(301, 22)
        Me.txt_cari.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 209)
        Me.DataGridView1.TabIndex = 50
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.btn_simpan)
        Me.GroupBox5.Controls.Add(Me.btn_tambah)
        Me.GroupBox5.Controls.Add(Me.btn_hapus)
        Me.GroupBox5.Controls.Add(Me.btn_update)
        Me.GroupBox5.Controls.Add(Me.btn_batal)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(542, 50)
        Me.GroupBox5.TabIndex = 49
        Me.GroupBox5.TabStop = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.Firebrick
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(405, 14)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 27)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.Color.Firebrick
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.ForeColor = System.Drawing.Color.White
        Me.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tambah.Location = New System.Drawing.Point(24, 14)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 27)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.Color.Firebrick
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.ForeColor = System.Drawing.Color.White
        Me.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hapus.Location = New System.Drawing.Point(218, 14)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 27)
        Me.btn_hapus.TabIndex = 4
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Firebrick
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(122, 14)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 27)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.Firebrick
        Me.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_batal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.ForeColor = System.Drawing.Color.White
        Me.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_batal.Location = New System.Drawing.Point(310, 14)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 27)
        Me.btn_batal.TabIndex = 3
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'gb_ataskanan
        '
        Me.gb_ataskanan.BackColor = System.Drawing.Color.Transparent
        Me.gb_ataskanan.Controls.Add(Me.txt_hargabeli)
        Me.gb_ataskanan.Controls.Add(Me.txt_jumlahstok)
        Me.gb_ataskanan.Controls.Add(Me.txt_hargajual)
        Me.gb_ataskanan.Controls.Add(Me.Label3)
        Me.gb_ataskanan.Controls.Add(Me.Label6)
        Me.gb_ataskanan.Controls.Add(Me.Label7)
        Me.gb_ataskanan.Location = New System.Drawing.Point(294, 16)
        Me.gb_ataskanan.Name = "gb_ataskanan"
        Me.gb_ataskanan.Size = New System.Drawing.Size(261, 111)
        Me.gb_ataskanan.TabIndex = 48
        Me.gb_ataskanan.TabStop = False
        '
        'txt_hargabeli
        '
        Me.txt_hargabeli.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hargabeli.Location = New System.Drawing.Point(122, 21)
        Me.txt_hargabeli.Name = "txt_hargabeli"
        Me.txt_hargabeli.Size = New System.Drawing.Size(112, 22)
        Me.txt_hargabeli.TabIndex = 7
        '
        'txt_jumlahstok
        '
        Me.txt_jumlahstok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlahstok.Location = New System.Drawing.Point(122, 78)
        Me.txt_jumlahstok.Name = "txt_jumlahstok"
        Me.txt_jumlahstok.Size = New System.Drawing.Size(112, 22)
        Me.txt_jumlahstok.TabIndex = 9
        '
        'txt_hargajual
        '
        Me.txt_hargajual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hargajual.Location = New System.Drawing.Point(122, 50)
        Me.txt_hargajual.Name = "txt_hargajual"
        Me.txt_hargajual.Size = New System.Drawing.Size(112, 22)
        Me.txt_hargajual.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jumlah Stok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Harga Jual"
        '
        'gb_ataskiri
        '
        Me.gb_ataskiri.BackColor = System.Drawing.Color.Transparent
        Me.gb_ataskiri.Controls.Add(Me.txt_namabarang)
        Me.gb_ataskiri.Controls.Add(Me.txt_idbarang)
        Me.gb_ataskiri.Controls.Add(Me.Label2)
        Me.gb_ataskiri.Controls.Add(Me.Label1)
        Me.gb_ataskiri.Location = New System.Drawing.Point(13, 16)
        Me.gb_ataskiri.Name = "gb_ataskiri"
        Me.gb_ataskiri.Size = New System.Drawing.Size(265, 111)
        Me.gb_ataskiri.TabIndex = 47
        Me.gb_ataskiri.TabStop = False
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namabarang.Location = New System.Drawing.Point(122, 54)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(112, 22)
        Me.txt_namabarang.TabIndex = 6
        '
        'txt_idbarang
        '
        Me.txt_idbarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idbarang.Location = New System.Drawing.Point(122, 24)
        Me.txt_idbarang.Name = "txt_idbarang"
        Me.txt_idbarang.Size = New System.Drawing.Size(112, 22)
        Me.txt_idbarang.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barang"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.gb_cari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gb_ataskanan)
        Me.Controls.Add(Me.gb_ataskiri)
        Me.Name = "FormBarang"
        Me.Size = New System.Drawing.Size(682, 453)
        Me.gb_cari.ResumeLayout(False)
        Me.gb_cari.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.gb_ataskanan.ResumeLayout(False)
        Me.gb_ataskanan.PerformLayout()
        Me.gb_ataskiri.ResumeLayout(False)
        Me.gb_ataskiri.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBaris As Label
    Friend WithEvents gb_cari As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents gb_ataskanan As GroupBox
    Friend WithEvents txt_hargabeli As TextBox
    Friend WithEvents txt_jumlahstok As TextBox
    Friend WithEvents txt_hargajual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gb_ataskiri As GroupBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents txt_idbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
