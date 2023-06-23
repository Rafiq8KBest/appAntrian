Public Class PilihBagian
    Private Sub Pengambilan_Click(sender As Object, e As EventArgs) Handles Pengambilan.Click
        Me.Hide()

        PengambilanTiketAntri.Show()


    End Sub

    Private Sub ViewAntrian_Click(sender As Object, e As EventArgs) Handles ViewAntrian.Click
        Me.Hide()
        LihatAntrian.Show()


    End Sub
End Class
