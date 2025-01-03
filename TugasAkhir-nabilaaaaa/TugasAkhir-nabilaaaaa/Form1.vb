Public Class Form1
    ' Array untuk daftar judul film
    Dim judulFilm() As String = {"BAYMAX", "TOY STORY 3", "KUNGFU PANDA", "ZOOTOPIA", "MONSTER.INC", "RATATOUILLE"}
    ' Array untuk daftar jam mulai
    Dim jamMulai() As String = {"13:00 WIB", "15:00 WIB", "19:00 WIB"}
    ' Harga tiket tetap
    Const hargaTiket As Decimal = 35000

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi ComboBox dengan judul film menggunakan perulangan
        For Each judul As String In judulFilm
            judulFilmComboBox.Items.Add(judul)
        Next

        ' Mengisi ComboBox dengan jam mulai menggunakan perulangan
        For Each jam As String In jamMulai
            JamMulaiComboBox.Items.Add(jam)
        Next

        ' Mengisi ComboBox dengan jumlah tiket (1 sampai 5)
        For i As Integer = 1 To 5
            JumlahTiketComboBox.Items.Add(i)
        Next

        ' Kosongkan pilihan awal ComboBox
        judulFilmComboBox.SelectedIndex = -1
        JamMulaiComboBox.SelectedIndex = -1
        JumlahTiketComboBox.SelectedIndex = -1

        ' Tidak menampilkan harga tiket di awal (kosongkan label)
        hargaTiketLabel.Text = ""
    End Sub

    Private Sub BeliTiketButton_Click(sender As Object, e As EventArgs) Handles BeliTiketButton.Click
        ' Validasi jika pengguna belum memilih opsi pada ComboBox
        If judulFilmComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih judul film terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If JamMulaiComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih jam mulai terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If JumlahTiketComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih jumlah tiket terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil jumlah tiket dari ComboBox
        Dim jumlahTiket As Integer = CInt(JumlahTiketComboBox.SelectedItem)

        ' Hitung total harga
        Dim totalHarga As Decimal = hargaTiket * jumlahTiket

        ' Tampilkan harga tiket dan total harga di label
        hargaTiketLabel.Text = $"Harga Tiket: Rp {hargaTiket:N0}"

        ' Tampilkan pesan konfirmasi pembelian
        MessageBox.Show($"Pembelian berhasil!{Environment.NewLine}" &
                        $"Tanggal: {tanggalDateTimePicker.Value.ToShortDateString()}{Environment.NewLine}" &
                        $"Judul Film: {judulFilmComboBox.SelectedItem}{Environment.NewLine}" &
                        $"Jam Mulai: {JamMulaiComboBox.SelectedItem}{Environment.NewLine}" &
                        $"Jumlah Tiket: {jumlahTiket}{Environment.NewLine}" &
                        $"Total Harga: Rp {totalHarga:N0}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub JudulFilmComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles judulFilmComboBox.SelectedIndexChanged
        ' Event handler ini dapat digunakan untuk aksi tambahan jika diperlukan
    End Sub

    Private Sub JamMulaiComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JamMulaiComboBox.SelectedIndexChanged
        ' Event handler ini dapat digunakan untuk aksi tambahan jika diperlukan
    End Sub
End Class
