Public Class Form2
    Private Sub btn_annul_Click(sender As Object, e As EventArgs) Handles btn_annul.Click
        txt_1.Clear()
        txt_2.Clear()
        txt_3.Clear()
    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        If txt_1.Text < 1 Or txt_1.Text > 150 Then
            txt_1.Clear()
            MsgBox(" donner un code valide entre 1 et 150")
        Else
            Dim p As pat
            With p
                .code = txt_1.Text
                .nom = txt_2.Text
                .prenom = txt_3.Text
            End With
            ajouter(p)
            txt_1.Clear()
            txt_2.Clear()
            txt_3.Clear()
            MessageBox.Show(" patient ajouté ")
        End If


    End Sub

    Private Sub btn_ret_Click(sender As Object, e As EventArgs) Handles btn_ret.Click
        Form1.Show()
        Form1.WindowState = WindowState.Maximized
        Me.Hide()
    End Sub
End Class