Public Class Form1
    Private Sub HitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HitBtn.Click
        Dim Angka1, Angka2, Angka3, Hasil As Integer
        Angka1 = Val(TmBox.Text)
        Angka2 = Val(MtBox.Text)
        Angka3 = Val(FtBox.Text)
        Hasil = (Angka1 + Angka2 + Angka3) / 3
        NaBox.Text = Hasil
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class