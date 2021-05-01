Public Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub
    'Contagem
    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        'Diminuir 1 a cada 1seg
        TimerCountDown.Start()
        If LabelContagem.Text > 0 Then
            LabelContagem.Text -= 1
        Else
            'Auxiliar para dar um tempo para um programa não fechar e abrir o outro ao mesmo tempo.
            Auxiliar.Show()
            Me.Close()
            System.Threading.Thread.Sleep(400) 'Aguarda 0,4 segundos para o programa ser aberto
            Inicio.Show()
            Auxiliar.Close()
        End If
    End Sub
    'Saltar
    Private Sub LabelSaltar_Click(sender As Object, e As EventArgs) Handles LabelSaltar.Click
        Auxiliar.Show()
        Me.Close()
        System.Threading.Thread.Sleep(400)
        Inicio.Show()
        Auxiliar.Close()
    End Sub
End Class