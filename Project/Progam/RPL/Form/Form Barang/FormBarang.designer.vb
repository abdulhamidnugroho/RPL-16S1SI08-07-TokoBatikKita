<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.txt_idbarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_hargabeli = New System.Windows.Forms.TextBox()
        Me.txt_jumlahstok = New System.Windows.Forms.TextBox()
        Me.txt_hargajual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_namabarang)
        Me.GroupBox1.Controls.Add(Me.txt_idbarang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(122, 58)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(112, 20)
        Me.txt_namabarang.TabIndex = 6
        '
        'txt_idbarang
        '
        Me.txt_idbarang.Location = New System.Drawing.Point(122, 26)
        Me.txt_idbarang.Name = "txt_idbarang"
        Me.txt_idbarang.Size = New System.Drawing.Size(112, 20)
        Me.txt_idbarang.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Barang"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_hargabeli)
        Me.GroupBox4.Controls.Add(Me.txt_jumlahstok)
        Me.GroupBox4.Controls.Add(Me.txt_hargajual)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(276, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 120)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'txt_hargabeli
        '
        Me.txt_hargabeli.Location = New System.Drawing.Point(122, 23)
        Me.txt_hargabeli.Name = "txt_hargabeli"
        Me.txt_hargabeli.Size = New System.Drawing.Size(112, 20)
        Me.txt_hargabeli.TabIndex = 7
        '
        'txt_jumlahstok
        '
        Me.txt_jumlahstok.Location = New System.Drawing.Point(122, 85)
        Me.txt_jumlahstok.Name = "txt_jumlahstok"
        Me.txt_jumlahstok.Size = New System.Drawing.Size(112, 20)
        Me.txt_jumlahstok.TabIndex = 9
        '
        'txt_hargajual
        '
        Me.txt_hargajual.Location = New System.Drawing.Point(122, 54)
        Me.txt_hargajual.Name = "txt_hargajual"
        Me.txt_hargajual.Size = New System.Drawing.Size(112, 20)
        Me.txt_hargajual.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jumlah Stok"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Harga Jual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Data-data lengkap tentang Barang di Toko Batik Kita"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Data Barang di Toko Batik Kita"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 70)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_simpan)
        Me.GroupBox5.Controls.Add(Me.btn_tambah)
        Me.GroupBox5.Controls.Add(Me.btn_hapus)
        Me.GroupBox5.Controls.Add(Me.btn_update)
        Me.GroupBox5.Controls.Add(Me.btn_batal)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(514, 54)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'btn_simpan
        '
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(429, 15)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 29)
        Me.btn_simpan.TabIndex = 5
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tambah.Location = New System.Drawing.Point(23, 15)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 29)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hapus.Location = New System.Drawing.Point(223, 15)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 29)
        Me.btn_hapus.TabIndex = 4
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.Location = New System.Drawing.Point(123, 15)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 29)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_batal.Location = New System.Drawing.Point(327, 15)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 29)
        Me.btn_batal.TabIndex = 3
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 299)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(514, 203)
        Me.DataGridView1.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_cari)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 517)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 52)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari Data Berdasarkan Nama"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(352, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(9, 19)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(301, 20)
        Me.txt_cari.TabIndex = 1
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Location = New System.Drawing.Point(110, 97)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(107, 13)
        Me.LblBaris.TabIndex = 31
        Me.LblBaris.Text = "Data ke-0 dari 0 data"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 581)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents txt_idbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_hargabeli As TextBox
    Friend WithEvents txt_jumlahstok As TextBox
    Friend WithEvents txt_hargajual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_batal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents LblBaris As Label
    Friend WithEvents Button1 As Button
End Class
