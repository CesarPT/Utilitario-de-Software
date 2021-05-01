Public Class Escola
    Private Sub PictureBoxSite_Click(sender As Object, e As EventArgs) Handles PictureBoxSite.Click
        System.Diagnostics.Process.Start("https://aeermesinde.net/aee/")
    End Sub

    Private Sub PictureBoxFB_Click(sender As Object, e As EventArgs) Handles PictureBoxFB.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/agrupamentodeescolasdeermesinde")
        System.Diagnostics.Process.Start("https://www.facebook.com/ebdafg")
    End Sub

    Private Sub PictureBoxInsta_Click(sender As Object, e As EventArgs) Handles PictureBoxInsta.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/agrupamento_escolas_ermesinde/?hl=pt")
    End Sub

    Private Sub PictureBoxContatos_Click(sender As Object, e As EventArgs) Handles PictureBoxContatos.Click
        System.Diagnostics.Process.Start("https://aeermesinde.net/aee/index.php/agrupamento/constituicao")
    End Sub

    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxMini_Click(sender As Object, e As EventArgs) Handles PictureBoxMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class