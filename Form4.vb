Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each r As rdv In Classer
            dgv_2.Rows.Add(r.code, r.dat)
        Next
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
        Form1.Show()
        Form1.WindowState = WindowState.Maximized
    End Sub

    Private Sub btn_ch_Click(sender As Object, e As EventArgs) Handles btn_ch.Click
        Dim a As Integer

        If Integer.TryParse(txt_code.Text, a) Then
            For Each row As DataGridViewRow In dgv_2.Rows

                If row.Cells("Code").Value IsNot Nothing AndAlso row.Cells("Code").Value.ToString() = a.ToString() Then
                    Dim code As Integer = Convert.ToInt32(row.Cells("Code").Value)

                    Dim dat As Date = Convert.ToDateTime(row.Cells("date_rdv").Value)
                    MsgBox("Date du rendez-vous : " & dat.ToString("yyyy-MM-dd") & Environment.NewLine & "Code :" & code.ToString())
                End If
            Next
        Else
            MsgBox("Veuillez entrer une valeur entière dans le champ.")
        End If
    End Sub

    Private Sub btn_ann_Click(sender As Object, e As EventArgs) Handles btn_ann.Click
        Dim a As Integer

        If Integer.TryParse(txt_code.Text, a) Then
            For Each row As DataGridViewRow In dgv_2.Rows

                If row.Cells("code").Value IsNot Nothing AndAlso row.Cells("code").Value.ToString() = a.ToString() Then
                    dgv_2.Rows.Remove(row)
                End If
            Next
        End If
        txt_code.Clear()
    End Sub
End Class