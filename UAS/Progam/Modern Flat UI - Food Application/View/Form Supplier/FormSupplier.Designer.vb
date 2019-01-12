<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.gb_cari = New System.Windows.Forms.GroupBox()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.gb_ataskanan = New System.Windows.Forms.GroupBox()
        Me.txt_notelpn = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gb_ataskiri = New System.Windows.Forms.GroupBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_idsupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.gb_cari.SuspendLayout()
        Me.gb_ataskanan.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ataskiri.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBaris.Location = New System.Drawing.Point(12, 6)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(114, 13)
        Me.LblBaris.TabIndex = 44
        Me.LblBaris.Text = "Data ke-0 dari 0 data"
        '
        'gb_cari
        '
        Me.gb_cari.Controls.Add(Me.txt_cari)
        Me.gb_cari.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_cari.Location = New System.Drawing.Point(15, 393)
        Me.gb_cari.Name = "gb_cari"
        Me.gb_cari.Size = New System.Drawing.Size(525, 52)
        Me.gb_cari.TabIndex = 42
        Me.gb_cari.TabStop = False
        Me.gb_cari.Text = "Cari Data Berdasarkan Nama"
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(9, 20)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(301, 22)
        Me.txt_cari.TabIndex = 1
        '
        'gb_ataskanan
        '
        Me.gb_ataskanan.Controls.Add(Me.txt_notelpn)
        Me.gb_ataskanan.Controls.Add(Me.txt_alamat)
        Me.gb_ataskanan.Controls.Add(Me.Label6)
        Me.gb_ataskanan.Controls.Add(Me.Label7)
        Me.gb_ataskanan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ataskanan.Location = New System.Drawing.Point(291, 19)
        Me.gb_ataskanan.Name = "gb_ataskanan"
        Me.gb_ataskanan.Size = New System.Drawing.Size(250, 93)
        Me.gb_ataskanan.TabIndex = 41
        Me.gb_ataskanan.TabStop = False
        '
        'txt_notelpn
        '
        Me.txt_notelpn.Location = New System.Drawing.Point(121, 55)
        Me.txt_notelpn.Name = "txt_notelpn"
        Me.txt_notelpn.Size = New System.Drawing.Size(112, 22)
        Me.txt_notelpn.TabIndex = 9
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(121, 20)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(112, 22)
        Me.txt_alamat.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "No Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Alamat"
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
        Me.DataGridView1.Location = New System.Drawing.Point(14, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 212)
        Me.DataGridView1.TabIndex = 40
        '
        'gb_ataskiri
        '
        Me.gb_ataskiri.Controls.Add(Me.txt_nama)
        Me.gb_ataskiri.Controls.Add(Me.txt_idsupplier)
        Me.gb_ataskiri.Controls.Add(Me.Label2)
        Me.gb_ataskiri.Controls.Add(Me.Label1)
        Me.gb_ataskiri.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_ataskiri.Location = New System.Drawing.Point(15, 19)
        Me.gb_ataskiri.Name = "gb_ataskiri"
        Me.gb_ataskiri.Size = New System.Drawing.Size(250, 93)
        Me.gb_ataskiri.TabIndex = 39
        Me.gb_ataskiri.TabStop = False
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(121, 51)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(112, 22)
        Me.txt_nama.TabIndex = 6
        '
        'txt_idsupplier
        '
        Me.txt_idsupplier.Location = New System.Drawing.Point(121, 19)
        Me.txt_idsupplier.Name = "txt_idsupplier"
        Me.txt_idsupplier.Size = New System.Drawing.Size(112, 22)
        Me.txt_idsupplier.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Supplier"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.btn_simpan)
        Me.GroupBox5.Controls.Add(Me.btn_tambah)
        Me.GroupBox5.Controls.Add(Me.btn_hapus)
        Me.GroupBox5.Controls.Add(Me.btn_update)
        Me.GroupBox5.Controls.Add(Me.btn_batal)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(14, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(527, 50)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.Firebrick
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.White
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(429, 14)
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
        Me.btn_hapus.Location = New System.Drawing.Point(230, 14)
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
        Me.btn_update.Location = New System.Drawing.Point(125, 14)
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
        Me.btn_batal.Location = New System.Drawing.Point(332, 14)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 27)
        Me.btn_batal.TabIndex = 3
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = False
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.gb_cari)
        Me.Controls.Add(Me.gb_ataskanan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gb_ataskiri)
        Me.Name = "FormSupplier"
        Me.Size = New System.Drawing.Size(682, 453)
        Me.gb_cari.ResumeLayout(False)
        Me.gb_cari.PerformLayout()
        Me.gb_ataskanan.ResumeLayout(False)
        Me.gb_ataskanan.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ataskiri.ResumeLayout(False)
        Me.gb_ataskiri.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBaris As Label
    Friend WithEvents gb_cari As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents gb_ataskanan As GroupBox
    Friend WithEvents txt_notelpn As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gb_ataskiri As GroupBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_idsupplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_batal As Button
End Class
