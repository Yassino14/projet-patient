Public Class Form1
    Private Sub AjoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem.Click
        Form2.Show()
        Form2.WindowState = WindowState.Maximized
        Me.Hide()

    End Sub

    Private Sub AffichageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichageToolStripMenuItem.Click
        Form3.Show()
        Form3.WindowState = WindowState.Maximized
        Me.Hide()
    End Sub

    Private Sub PRENDRERDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRENDRERDVToolStripMenuItem.Click
        Form5.Show()
        Form5.WindowState = WindowState.Maximized
        Me.Hide()
    End Sub

    Private Sub AFFICHAGEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AFFICHAGEToolStripMenuItem1.Click
        Form4.Show()
        Form4.WindowState = WindowState.Maximized
        Me.Hide()
    End Sub

End Class
