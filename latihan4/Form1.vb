Public Class Form1

    Function HitungDiskon(hargaAwal As Double, diskonPersen As Double) As Double
        Dim hargaAkhir As Double
        hargaAkhir = hargaAwal - (hargaAwal * diskonPersen / 100)
        Return hargaAkhir
    End Function
    Sub TampilkanPesan(hargaAkhir As Double)
        MsgBox("Harga akhir setelah diskon adalah: Rp" & hargaAkhir)
    End Sub


    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Static itemCounter As Integer = 0 ' Digunakan untuk memberikan nama item otomatis
        Dim hargaAwal As Double
        Dim diskon As Double
        Dim hargaAkhir As Double

        ' Validasi input harga dan diskon
        If Not IsNumeric(txtHarga.Text) OrElse Not IsNumeric(txtDiskon.Text) Then
            MsgBox("Masukkan nilai numerik untuk harga dan diskon.")
            Exit Sub
        End If

        ' Ambil nilai dari TextBox
        hargaAwal = CDbl(txtHarga.Text)
        diskon = CDbl(txtDiskon.Text)

        ' Validasi persentase diskon
        If diskon < 0 Or diskon > 100 Then
            MsgBox("Masukkan diskon antara 0 dan 100.")
            Exit Sub
        End If

        ' Hitung harga akhir setelah diskon
        hargaAkhir = HitungDiskon(hargaAwal, diskon)

        ' Tampilkan pesan hasil perhitungan
        TampilkanPesan(hargaAkhir)

        ' Tambahkan item ke DataGridView dengan nama otomatis "Item A", "Item B", dll.
        Dim namaItem As String = "Item " & Chr(65 + itemCounter) ' Menggunakan ASCII untuk A, B, C...
        DataGridView1.Rows.Add(namaItem, "Rp" & hargaAwal, diskon & "%", "Rp" & hargaAkhir)

        ' Increment itemCounter untuk nama item berikutnya
        itemCounter += 1

        ' Bersihkan input setelah setiap perhitungan
        txtHarga.Clear()
        txtDiskon.Clear()

    End Sub
    Private Sub btnHitung_MouseHover(sender As Object, e As EventArgs) Handles btnHitung.MouseHover
        Me.Cursor = Cursors.Hand ' Ubah kursor menjadi tangan
    End Sub

    Private Sub btnHitung_MouseLeave(sender As Object, e As EventArgs) Handles btnHitung.MouseLeave
        Me.Cursor = Cursors.Default ' Kembalikan kursor ke default
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyiapkan kolom pada DataGridView
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Nama Item"
        DataGridView1.Columns(1).Name = "Harga Awal"
        DataGridView1.Columns(2).Name = "Diskon %"
        DataGridView1.Columns(3).Name = "Harga Akhir"
    End Sub


End Class
