Public Class Form5
    Private Sub btn_annul_Click(sender As Object, e As EventArgs) Handles btn_annul.Click
        txt_coder.Clear()
    End Sub

    Private Sub btn_ret_Click(sender As Object, e As EventArgs) Handles btn_ret.Click
        Me.Hide()
        Form1.Show()
        Form1.WindowState = WindowState.Maximized
    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim r As rdv
        With r
            .code = txt_coder.Text
            .dat = dtp_r.Value

        End With
        ajout(r)
        txt_coder.Clear()


        MessageBox.Show(" Rendez-vous ajouté ")
    End Sub
End Class