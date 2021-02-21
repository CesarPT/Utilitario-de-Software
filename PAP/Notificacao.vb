Public Class Notificacao
    Dim hora As String
    Dim tempomensagem As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hora = TimeString
        LabelHora.Text = hora
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tempomensagem = MaskedTextBox.Text
        LabelTempoM.Text = "Mensagem aparece em: " + tempomensagem

        If hora = tempomensagem Then
            Timer2.Stop()
            MsgBox(TextBoxM.Text)
            ButtonIniciar.Enabled = True
            ButtonParar.Enabled = False
            LabelTempoM.Text = "Mensagem aparece em:"
        End If
    End Sub
    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        'Se clicar no Iniciar o tempo 2 começa
        Timer2.Start()
        ButtonIniciar.Enabled = False
        ButtonParar.Enabled = True
    End Sub
    Private Sub ButtonParar_Click(sender As Object, e As EventArgs) Handles ButtonParar.Click
        'Se clicar no Parar o tempo 2 para
        Timer2.Stop()
        ButtonIniciar.Enabled = True
        ButtonParar.Enabled = False
        LabelTempoM.Text = ""
    End Sub
    Private Sub ButtonMinimizarN_Click(sender As Object, e As EventArgs) Handles ButtonMinimizarN.Click
        'O formulário se esconde e aparece a notificação por 5 seg
        NotifyIcon1.Visible = True
        Me.Hide()
        NotifyIcon1.BalloonTipText = "A notificação foi minimizada, não feche o formulário! Notificação aparece em: " + tempomensagem
        NotifyIcon1.ShowBalloonTip(4000)
    End Sub
End Class