Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(txnama.Text & vbCrLf & cmbJk.Text & vbCrLf & cmbFk.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
