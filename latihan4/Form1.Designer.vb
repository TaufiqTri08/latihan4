<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.harga = New System.Windows.Forms.Label()
        Me.diskon = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtNamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHargaAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDiskonItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHargaAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'harga
        '
        Me.harga.AutoSize = True
        Me.harga.Location = New System.Drawing.Point(113, 82)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(47, 17)
        Me.harga.TabIndex = 0
        Me.harga.Text = "Harga"
        '
        'diskon
        '
        Me.diskon.AutoSize = True
        Me.diskon.Location = New System.Drawing.Point(113, 125)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(51, 17)
        Me.diskon.TabIndex = 1
        Me.diskon.Text = "Diskon"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(210, 82)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(158, 22)
        Me.txtHarga.TabIndex = 2
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(210, 125)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(158, 22)
        Me.txtDiskon.TabIndex = 3
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(210, 170)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(93, 44)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtNamaItem, Me.txtHargaAwal, Me.txtDiskonItem, Me.txtHargaAkhir})
        Me.DataGridView1.Location = New System.Drawing.Point(210, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(735, 356)
        Me.DataGridView1.TabIndex = 5
        '
        'txtNamaItem
        '
        Me.txtNamaItem.HeaderText = "Nama Item"
        Me.txtNamaItem.MinimumWidth = 6
        Me.txtNamaItem.Name = "txtNamaItem"
        Me.txtNamaItem.Width = 125
        '
        'txtHargaAwal
        '
        Me.txtHargaAwal.HeaderText = "Harga Awal"
        Me.txtHargaAwal.MinimumWidth = 6
        Me.txtHargaAwal.Name = "txtHargaAwal"
        Me.txtHargaAwal.Width = 125
        '
        'txtDiskonItem
        '
        Me.txtDiskonItem.HeaderText = "Diskon%"
        Me.txtDiskonItem.MinimumWidth = 6
        Me.txtDiskonItem.Name = "txtDiskonItem"
        Me.txtDiskonItem.Width = 125
        '
        'txtHargaAkhir
        '
        Me.txtHargaAkhir.HeaderText = "Harga Akhir"
        Me.txtHargaAkhir.MinimumWidth = 6
        Me.txtHargaAkhir.Name = "txtHargaAkhir"
        Me.txtHargaAkhir.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 626)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.harga)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents harga As Label
    Friend WithEvents diskon As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNamaItem As DataGridViewTextBoxColumn
    Friend WithEvents txtHargaAwal As DataGridViewTextBoxColumn
    Friend WithEvents txtDiskonItem As DataGridViewTextBoxColumn
    Friend WithEvents txtHargaAkhir As DataGridViewTextBoxColumn
End Class
