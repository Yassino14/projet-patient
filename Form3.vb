Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each p As pat In Classe
            Dgv_1.Rows.Add(p.code, p.nom, p.prenom)
        Next
    End Sub

    Private Sub btn_ret_Click(sender As Object, e As EventArgs) Handles btn_ret.Click
        Me.Hide()
        Form1.Show()
        Form1.WindowState = WindowState.Maximized
    End Sub
    Private Sub btn_chercher_Click(sender As Object, e As EventArgs) Handles btn_chercher.Click
        Dim a As Integer

        If Integer.TryParse(txt_ch1.Text, a) Then
            For Each row As DataGridViewRow In Dgv_1.Rows

                If row.Cells("code").Value IsNot Nothing AndAlso row.Cells("code").Value.ToString() = a.ToString() Then
                    Dim code As Integer = Convert.ToInt32(row.Cells("code").Value)
                    Dim nom As String = If(row.Cells("nom").Value IsNot Nothing, row.Cells("nom").Value.ToString(), String.Empty)
                    Dim prenom As String = If(row.Cells("prenom").Value IsNot Nothing, row.Cells("prenom").Value.ToString(), String.Empty)
                    MsgBox("Nom : " & nom & ", Prénom : " & prenom & ", Code : " & code.ToString())
                End If
            Next
        Else
            MsgBox("Veuillez entrer une valeur entière dans le champ.")
        End If
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim a As Integer

        If Integer.TryParse(txt_ch1.Text, a) Then
            For Each row As DataGridViewRow In Dgv_1.Rows

                If row.Cells("code").Value IsNot Nothing AndAlso row.Cells("code").Value.ToString() = a.ToString() Then
                    Dgv_1.Rows.Remove(row)
                End If
            Next
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = txt_n.Text
        For Each row As DataGridViewRow In Dgv_1.Rows

            If row.Cells("nom").Value IsNot Nothing AndAlso row.Cells("nom").Value.ToString() = a.ToString() Then
                Dim code As Integer = Convert.ToInt32(row.Cells("code").Value)
                Dim nom As String = If(row.Cells("nom").Value IsNot Nothing, row.Cells("nom").Value.ToString(), String.Empty)
                Dim prenom As String = If(row.Cells("prenom").Value IsNot Nothing, row.Cells("prenom").Value.ToString(), String.Empty)
                MsgBox("Nom : " & nom & ", Prénom : " & prenom & ", Code : " & code.ToString())



            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String
        a = txt_n.Text
        For Each row As DataGridViewRow In Dgv_1.Rows

            If row.Cells("nom").Value IsNot Nothing AndAlso row.Cells("nom").Value.ToString() = a.ToString() Then
                Dgv_1.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String
        a = txt_p.Text
        For Each row As DataGridViewRow In Dgv_1.Rows

            If row.Cells("prenom").Value IsNot Nothing AndAlso row.Cells("prenom").Value.ToString() = a.ToString() Then
                Dim code As Integer = Convert.ToInt32(row.Cells("code").Value)
                Dim nom As String = If(row.Cells("nom").Value IsNot Nothing, row.Cells("nom").Value.ToString(), String.Empty)
                Dim prenom As String = If(row.Cells("prenom").Value IsNot Nothing, row.Cells("prenom").Value.ToString(), String.Empty)
                MsgBox("Nom : " & nom & ", Prénom : " & prenom & ", Code : " & code.ToString())


            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        a = txt_p.Text
        For Each row As DataGridViewRow In Dgv_1.Rows

            If row.Cells("prenom").Value IsNot Nothing AndAlso row.Cells("prenom").Value.ToString() = a.ToString() Then
                Dgv_1.Rows.Remove(row)
            End If
        Next
    End Sub
End Class