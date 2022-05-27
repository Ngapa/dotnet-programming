Public Class Form1

    Private Sub BtnUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUlang.Click
        'Membersihkan isi textbox
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtHrga.Text = ""
        txtDskn.Text = ""
        txtBayar.Text = ""
        txtBns.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim Harga, Jumlah As Integer
        Dim Total, Diskon, Bayar As Double
        Dim Bonus As String

        Harga = txtHarga.Text
        Jumlah = txtJumlah.Text

        Total = Harga * Jumlah

        If Total >= 500000 Then
            Diskon = 0.2 * Total
            Bonus = "Tas Pinggang"
        ElseIf Total >= 200000 Then
            Diskon = 0.15 * Total
            Bonus = "Payung"
        ElseIf Total >= 100000 Then
            Diskon = 0.1 * Total
            Bonus = "Kaos"
        ElseIf Total >= 50000 Then
            Diskon = 0.05 * Total
            Bonus = "Cangkir"
        ElseIf Total < 50000 Then
            Diskon = 0 * Total
            Bonus = "Tidak Ada"
        End If
        Bayar = Total - Diskon
        txtHrga.Text = Total
        txtDskn.Text = Diskon
        txtBayar.Text = Bayar
        txtBns.Text = Bonus
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        End
    End Sub
End Class
