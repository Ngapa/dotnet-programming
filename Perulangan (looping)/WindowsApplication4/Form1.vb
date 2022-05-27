Public Class Form1

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim teks As String
        Dim jumlah As Integer
        teks = txtTeks.Text
        jumlah = txtJumlah.Text
        For i = 1 To jumlah
            ListView1.Items.Add(teks)
        Next i
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtTeks.Text = ""
        txtJumlah.Text = ""
        ListView1.Items.Clear()
    End Sub
End Class
