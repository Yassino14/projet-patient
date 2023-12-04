Public Class Form6

    Private Sub enit()
        txt_mdp.Clear()
        txt_nom.Clear()


    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login, pw As String

        login = txt_nom.Text
        pw = txt_mdp.Text

        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            Form1.Show()
            Form1.WindowState = WindowState.Maximized
            enit()
        Else
            enit()
            MsgBox("Nom d'utilisateur ou Mot de passe incorrects")

        End If

    End Sub

    Private Sub btn_annul_Click(sender As Object, e As EventArgs) Handles btn_annul.Click
        enit()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = WindowState.Maximized
    End Sub
End Class