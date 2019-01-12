<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanStokBarang
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
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_tampilkan = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cari)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 43)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Berdasarkan Nama Barang"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(6, 17)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(180, 20)
        Me.txt_cari.TabIndex = 33
        '
        'btn_batal
        '
        Me.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_batal.Location = New System.Drawing.Point(108, 54)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 27)
        Me.btn_batal.TabIndex = 39
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_tampilkan
        '
        Me.btn_tampilkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tampilkan.Location = New System.Drawing.Point(11, 54)
        Me.btn_tampilkan.Name = "btn_tampilkan"
        Me.btn_tampilkan.Size = New System.Drawing.Size(75, 27)
        Me.btn_tampilkan.TabIndex = 38
        Me.btn_tampilkan.Text = "Tampil"
        Me.btn_tampilkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tampilkan.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 99)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(867, 516)
        Me.CrystalReportViewer1.TabIndex = 37
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormLaporanStokBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 615)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_tampilkan)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FormLaporanStokBarang"
        Me.Text = "FormLaporanStokBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_tampilkan As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
