﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.lNamaBarang = New System.Windows.Forms.Label()
        Me.cbKondisi = New System.Windows.Forms.ComboBox()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.lKataKunci = New System.Windows.Forms.Label()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.lMerek = New System.Windows.Forms.Label()
        Me.tbMerek = New System.Windows.Forms.TextBox()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.lJumlah = New System.Windows.Forms.Label()
        Me.tbKataKunci = New System.Windows.Forms.TextBox()
        Me.lKondisi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPemanfaatan = New System.Windows.Forms.ComboBox()
        Me.tbKeterangan = New System.Windows.Forms.TextBox()
        Me.lKeterangan = New System.Windows.Forms.Label()
        Me.lAsal = New System.Windows.Forms.Label()
        Me.cbAsal = New System.Windows.Forms.ComboBox()
        Me.lPemanfaatan = New System.Windows.Forms.Label()
        Me.lFungsi = New System.Windows.Forms.Label()
        Me.tbFungsi = New System.Windows.Forms.TextBox()
        Me.lIDBarang = New System.Windows.Forms.Label()
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.lTanggalMasuk = New System.Windows.Forms.Label()
        Me.tbIDBarang = New System.Windows.Forms.TextBox()
        Me.bBersih = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvTabelBarang = New System.Windows.Forms.DataGridView()
        Me.lJam = New System.Windows.Forms.Label()
        Me.tJam = New System.Windows.Forms.Timer(Me.components)
        Me.lNamaMhs = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTambahPengguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTabelBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lNamaBarang
        '
        Me.lNamaBarang.AutoSize = True
        Me.lNamaBarang.Location = New System.Drawing.Point(19, 67)
        Me.lNamaBarang.Name = "lNamaBarang"
        Me.lNamaBarang.Size = New System.Drawing.Size(73, 13)
        Me.lNamaBarang.TabIndex = 0
        Me.lNamaBarang.Text = "Nama Barang"
        '
        'cbKondisi
        '
        Me.cbKondisi.FormattingEnabled = True
        Me.cbKondisi.Location = New System.Drawing.Point(107, 160)
        Me.cbKondisi.Name = "cbKondisi"
        Me.cbKondisi.Size = New System.Drawing.Size(245, 21)
        Me.cbKondisi.TabIndex = 4
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(107, 357)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(56, 23)
        Me.bSimpan.TabIndex = 10
        Me.bSimpan.Text = "&Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'lKataKunci
        '
        Me.lKataKunci.AutoSize = True
        Me.lKataKunci.Location = New System.Drawing.Point(747, 155)
        Me.lKataKunci.Name = "lKataKunci"
        Me.lKataKunci.Size = New System.Drawing.Size(178, 13)
        Me.lKataKunci.TabIndex = 3
        Me.lKataKunci.Text = "Cari Barang (Merek, Nama, Kondisi)"
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Location = New System.Drawing.Point(107, 64)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(245, 22)
        Me.tbNamaBarang.TabIndex = 1
        '
        'lMerek
        '
        Me.lMerek.AutoSize = True
        Me.lMerek.Location = New System.Drawing.Point(54, 99)
        Me.lMerek.Name = "lMerek"
        Me.lMerek.Size = New System.Drawing.Size(38, 13)
        Me.lMerek.TabIndex = 5
        Me.lMerek.Text = "Merek"
        '
        'tbMerek
        '
        Me.tbMerek.Location = New System.Drawing.Point(107, 96)
        Me.tbMerek.Name = "tbMerek"
        Me.tbMerek.Size = New System.Drawing.Size(245, 22)
        Me.tbMerek.TabIndex = 2
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(107, 256)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(245, 22)
        Me.tbJumlah.TabIndex = 7
        '
        'lJumlah
        '
        Me.lJumlah.AutoSize = True
        Me.lJumlah.Location = New System.Drawing.Point(51, 259)
        Me.lJumlah.Name = "lJumlah"
        Me.lJumlah.Size = New System.Drawing.Size(41, 13)
        Me.lJumlah.TabIndex = 7
        Me.lJumlah.Text = "Jumlah"
        '
        'tbKataKunci
        '
        Me.tbKataKunci.Location = New System.Drawing.Point(930, 152)
        Me.tbKataKunci.Name = "tbKataKunci"
        Me.tbKataKunci.Size = New System.Drawing.Size(197, 22)
        Me.tbKataKunci.TabIndex = 10
        '
        'lKondisi
        '
        Me.lKondisi.AutoSize = True
        Me.lKondisi.Location = New System.Drawing.Point(50, 163)
        Me.lKondisi.Name = "lKondisi"
        Me.lKondisi.Size = New System.Drawing.Size(42, 13)
        Me.lKondisi.TabIndex = 9
        Me.lKondisi.Text = "Kondisi"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.cbPemanfaatan)
        Me.GroupBox1.Controls.Add(Me.tbKeterangan)
        Me.GroupBox1.Controls.Add(Me.lKeterangan)
        Me.GroupBox1.Controls.Add(Me.lAsal)
        Me.GroupBox1.Controls.Add(Me.cbAsal)
        Me.GroupBox1.Controls.Add(Me.lPemanfaatan)
        Me.GroupBox1.Controls.Add(Me.lFungsi)
        Me.GroupBox1.Controls.Add(Me.tbFungsi)
        Me.GroupBox1.Controls.Add(Me.lIDBarang)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalMasuk)
        Me.GroupBox1.Controls.Add(Me.lMerek)
        Me.GroupBox1.Controls.Add(Me.tbMerek)
        Me.GroupBox1.Controls.Add(Me.lTanggalMasuk)
        Me.GroupBox1.Controls.Add(Me.tbIDBarang)
        Me.GroupBox1.Controls.Add(Me.bBersih)
        Me.GroupBox1.Controls.Add(Me.bEdit)
        Me.GroupBox1.Controls.Add(Me.bHapus)
        Me.GroupBox1.Controls.Add(Me.tbJumlah)
        Me.GroupBox1.Controls.Add(Me.lNamaBarang)
        Me.GroupBox1.Controls.Add(Me.lKondisi)
        Me.GroupBox1.Controls.Add(Me.bSimpan)
        Me.GroupBox1.Controls.Add(Me.cbKondisi)
        Me.GroupBox1.Controls.Add(Me.tbNamaBarang)
        Me.GroupBox1.Controls.Add(Me.lJumlah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 398)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Barang"
        '
        'cbPemanfaatan
        '
        Me.cbPemanfaatan.FormattingEnabled = True
        Me.cbPemanfaatan.Location = New System.Drawing.Point(107, 224)
        Me.cbPemanfaatan.Name = "cbPemanfaatan"
        Me.cbPemanfaatan.Size = New System.Drawing.Size(245, 21)
        Me.cbPemanfaatan.TabIndex = 6
        '
        'tbKeterangan
        '
        Me.tbKeterangan.Location = New System.Drawing.Point(107, 320)
        Me.tbKeterangan.Name = "tbKeterangan"
        Me.tbKeterangan.Size = New System.Drawing.Size(245, 22)
        Me.tbKeterangan.TabIndex = 9
        '
        'lKeterangan
        '
        Me.lKeterangan.AutoSize = True
        Me.lKeterangan.Location = New System.Drawing.Point(29, 323)
        Me.lKeterangan.Name = "lKeterangan"
        Me.lKeterangan.Size = New System.Drawing.Size(63, 13)
        Me.lKeterangan.TabIndex = 24
        Me.lKeterangan.Text = "Keterangan"
        '
        'lAsal
        '
        Me.lAsal.AutoSize = True
        Me.lAsal.Location = New System.Drawing.Point(64, 291)
        Me.lAsal.Name = "lAsal"
        Me.lAsal.Size = New System.Drawing.Size(28, 13)
        Me.lAsal.TabIndex = 23
        Me.lAsal.Text = "Asal"
        '
        'cbAsal
        '
        Me.cbAsal.FormattingEnabled = True
        Me.cbAsal.Location = New System.Drawing.Point(107, 288)
        Me.cbAsal.Name = "cbAsal"
        Me.cbAsal.Size = New System.Drawing.Size(245, 21)
        Me.cbAsal.TabIndex = 8
        '
        'lPemanfaatan
        '
        Me.lPemanfaatan.AutoSize = True
        Me.lPemanfaatan.Location = New System.Drawing.Point(21, 227)
        Me.lPemanfaatan.Name = "lPemanfaatan"
        Me.lPemanfaatan.Size = New System.Drawing.Size(71, 13)
        Me.lPemanfaatan.TabIndex = 20
        Me.lPemanfaatan.Text = "Pemanfaatan"
        '
        'lFungsi
        '
        Me.lFungsi.AutoSize = True
        Me.lFungsi.Location = New System.Drawing.Point(11, 195)
        Me.lFungsi.Name = "lFungsi"
        Me.lFungsi.Size = New System.Drawing.Size(81, 13)
        Me.lFungsi.TabIndex = 18
        Me.lFungsi.Text = "Fungsi (ringkas)"
        '
        'tbFungsi
        '
        Me.tbFungsi.Location = New System.Drawing.Point(107, 192)
        Me.tbFungsi.Name = "tbFungsi"
        Me.tbFungsi.Size = New System.Drawing.Size(245, 22)
        Me.tbFungsi.TabIndex = 5
        '
        'lIDBarang
        '
        Me.lIDBarang.AutoSize = True
        Me.lIDBarang.Location = New System.Drawing.Point(37, 35)
        Me.lIDBarang.Name = "lIDBarang"
        Me.lIDBarang.Size = New System.Drawing.Size(55, 13)
        Me.lIDBarang.TabIndex = 16
        Me.lIDBarang.Text = "ID Barang"
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(107, 128)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(245, 22)
        Me.dtpTanggalMasuk.TabIndex = 3
        '
        'lTanggalMasuk
        '
        Me.lTanggalMasuk.AutoSize = True
        Me.lTanggalMasuk.Location = New System.Drawing.Point(12, 133)
        Me.lTanggalMasuk.Name = "lTanggalMasuk"
        Me.lTanggalMasuk.Size = New System.Drawing.Size(80, 13)
        Me.lTanggalMasuk.TabIndex = 13
        Me.lTanggalMasuk.Text = "Tanggal Masuk"
        '
        'tbIDBarang
        '
        Me.tbIDBarang.Location = New System.Drawing.Point(107, 32)
        Me.tbIDBarang.Name = "tbIDBarang"
        Me.tbIDBarang.Size = New System.Drawing.Size(245, 22)
        Me.tbIDBarang.TabIndex = 0
        '
        'bBersih
        '
        Me.bBersih.Location = New System.Drawing.Point(296, 357)
        Me.bBersih.Name = "bBersih"
        Me.bBersih.Size = New System.Drawing.Size(56, 23)
        Me.bBersih.TabIndex = 13
        Me.bBersih.Text = "&Bersih"
        Me.bBersih.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(170, 357)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(56, 23)
        Me.bEdit.TabIndex = 11
        Me.bEdit.Text = "&Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(233, 357)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(56, 23)
        Me.bHapus.TabIndex = 12
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(382, 60)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Inventarisasi Lab D-3 Teknik Informatika" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Universitas Sumatera Utara"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvTabelBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 351)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Barang"
        '
        'dgvTabelBarang
        '
        Me.dgvTabelBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTabelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabelBarang.Location = New System.Drawing.Point(6, 24)
        Me.dgvTabelBarang.Name = "dgvTabelBarang"
        Me.dgvTabelBarang.Size = New System.Drawing.Size(716, 321)
        Me.dgvTabelBarang.TabIndex = 14
        '
        'lJam
        '
        Me.lJam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lJam.Location = New System.Drawing.Point(919, 51)
        Me.lJam.Name = "lJam"
        Me.lJam.Size = New System.Drawing.Size(208, 15)
        Me.lJam.TabIndex = 14
        Me.lJam.Text = "jam_realtime"
        Me.lJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tJam
        '
        '
        'lNamaMhs
        '
        Me.lNamaMhs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lNamaMhs.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNamaMhs.Location = New System.Drawing.Point(874, 76)
        Me.lNamaMhs.Name = "lNamaMhs"
        Me.lNamaMhs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lNamaMhs.Size = New System.Drawing.Size(253, 23)
        Me.lNamaMhs.TabIndex = 15
        Me.lNamaMhs.Text = "nama_mhs"
        Me.lNamaMhs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmKeluar, Me.tsmTambahPengguna})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1145, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmKeluar
        '
        Me.tsmKeluar.Name = "tsmKeluar"
        Me.tsmKeluar.Size = New System.Drawing.Size(52, 20)
        Me.tsmKeluar.Text = "Keluar"
        '
        'tsmTambahPengguna
        '
        Me.tsmTambahPengguna.Name = "tsmTambahPengguna"
        Me.tsmTambahPengguna.Size = New System.Drawing.Size(118, 20)
        Me.tsmTambahPengguna.Text = "Tambah Pengguna"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1145, 538)
        Me.Controls.Add(Me.lNamaMhs)
        Me.Controls.Add(Me.lJam)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbKataKunci)
        Me.Controls.Add(Me.lKataKunci)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Barang Laboratorium"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvTabelBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lNamaBarang As System.Windows.Forms.Label
    Friend WithEvents cbKondisi As System.Windows.Forms.ComboBox
    Friend WithEvents bSimpan As System.Windows.Forms.Button
    Friend WithEvents lKataKunci As System.Windows.Forms.Label
    Friend WithEvents tbNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents lMerek As System.Windows.Forms.Label
    Friend WithEvents tbMerek As System.Windows.Forms.TextBox
    Friend WithEvents tbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents lJumlah As System.Windows.Forms.Label
    Friend WithEvents tbKataKunci As System.Windows.Forms.TextBox
    Friend WithEvents lKondisi As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lTanggalMasuk As System.Windows.Forms.Label
    Friend WithEvents bBersih As System.Windows.Forms.Button
    Friend WithEvents bEdit As System.Windows.Forms.Button
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTabelBarang As System.Windows.Forms.DataGridView
    Friend WithEvents dtpTanggalMasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents lIDBarang As System.Windows.Forms.Label
    Friend WithEvents tbIDBarang As System.Windows.Forms.TextBox
    Friend WithEvents lJam As System.Windows.Forms.Label
    Friend WithEvents tJam As System.Windows.Forms.Timer
    Friend WithEvents lNamaMhs As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmTambahPengguna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lAsal As System.Windows.Forms.Label
    Friend WithEvents cbAsal As System.Windows.Forms.ComboBox
    Friend WithEvents lPemanfaatan As System.Windows.Forms.Label
    Friend WithEvents lFungsi As System.Windows.Forms.Label
    Friend WithEvents tbFungsi As System.Windows.Forms.TextBox
    Friend WithEvents lKeterangan As System.Windows.Forms.Label
    Friend WithEvents cbPemanfaatan As System.Windows.Forms.ComboBox
    Friend WithEvents tbKeterangan As System.Windows.Forms.TextBox

End Class
