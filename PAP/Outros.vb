Public Class Outros
    'Métodos de encerramento
    Private Sub FlatToggle_CheckedChanged(sender As Object) Handles FlatToggle.CheckedChanged
        Try
            If ComboBoxOff.SelectedItem = "Desligar" Then
                Process.Start("\Programas\Outros\Funcoes do PC\Desligar.exe")
            ElseIf ComboBoxOff.SelectedItem = "Reiniciar" Then
                Process.Start("\Programas\Outros\Funcoes do PC\Reiniciar.exe")
            ElseIf ComboBoxOff.SelectedItem = "Suspender" Then
                Process.Start("\Programas\Outros\Funcoes do PC\Suspender.exe")
            ElseIf ComboBoxOff.SelectedItem = "Terminar Sessão" Then
                Process.Start("\Programas\Outros\Funcoes do PC\Terminar Sessao.exe")
            ElseIf ComboBoxOff.SelectedItem = "BIOS" Then
                Process.Start("\Programas\Outros\Funcoes do PC\BIOS.exe")
            ElseIf ComboBoxOff.SelectedItem = "Opções Avançadas" Then
                Process.Start("\Programas\Outros\Funcoes do PC\Opcoes Avancadas.exe")
            Else
                MsgBox("Não selecionou um método de encerramento no TabControl.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    'Controlar
    Private Sub PictureBoxFlux_Click(sender As Object, e As EventArgs) Handles PictureBoxFlux.Click
        Try
            Process.Start("\Programas\Outros\Funcoes do PC\f.lux\flux.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub PictureBoxAudio_Click(sender As Object, e As EventArgs) Handles PictureBoxAudio.Click
        Try
            Process.Start("\Programas\Outros\Funcoes do PC\sndvol.bat")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub ButtonLumi_Click(sender As Object, e As EventArgs) Handles ButtonLumi.Click
        Try
            Process.Start("C:\Windows\System32\DpiScaling.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub ButtonCharmap_Click(sender As Object, e As EventArgs) Handles ButtonCharmap.Click
        Try
            Process.Start("C:\Windows\System32\charmap.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub ButtonVersao_Click(sender As Object, e As EventArgs) Handles ButtonVersao.Click
        Try
            Process.Start("C:\Windows\System32\winver.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub ButtonRestauro_Click(sender As Object, e As EventArgs) Handles ButtonRestauro.Click
        Try
            Process.Start("C:\Windows\System32\rstrui")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    Private Sub ButtonGT_Click(sender As Object, e As EventArgs) Handles ButtonGT.Click
        Try
            Process.Start("C:\Windows\System32\taskmgr.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    'Converter
    Private Sub PictureBoxConverter_Click(sender As Object, e As EventArgs) Handles PictureBoxConverter.Click
        System.Diagnostics.Process.Start("https://convertio.co/pt/")
    End Sub
    'Manuais
    Private Sub PictureBoxArduino_Click(sender As Object, e As EventArgs) Handles PictureBoxArduino.Click
        If MsgBox("Manuais do Arduino - Irá abrir um link com informações gerais e um outro link com todas as funções, variáveis e estruturas, deseja continuar?", MsgBoxStyle.YesNo, "Manuais - Arduino") = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://edisciplinas.usp.br/pluginfile.php/3252633/mod_resource/content/1/Guia_Arduino_Iniciante_Multilogica_Shop.pdf")
            System.Diagnostics.Process.Start("https://www.arduino.cc/reference/pt/")
        End If
    End Sub
    Private Sub PictureBoxEletro_Click(sender As Object, e As EventArgs) Handles PictureBoxEletro.Click
        If MsgBox("Aplicação de Eletrónica - Irá abrir um link no Google Play, instale no seu dispositivo Mobile/iOS, deseja continuar?", MsgBoxStyle.YesNo, "Aplicação - Eletrónica") = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=it.android.demi.elettronica&hl=pt_PT&gl=US")
        End If
    End Sub
    Private Sub PictureBoxEletri_Click(sender As Object, e As EventArgs) Handles PictureBoxEletri.Click
        If MsgBox("Aplicação de Eletricidade - Irá abrir um link no Google Play, instale no seu dispositivo Mobile/iOS, deseja continuar?", MsgBoxStyle.YesNo, "Aplicação - Eletricidade") = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=mmy.first.myapplication433&hl=pt_BR&gl=US")
        End If
    End Sub
    'Baixar
    Private Sub PictureBoxFilmes_Click(sender As Object, e As EventArgs) Handles PictureBoxFilmes.Click
        System.Diagnostics.Process.Start("https://mrpiracy.site/")
    End Sub
    Private Sub PictureBoxVideos_Click(sender As Object, e As EventArgs) Handles PictureBoxVideos.Click
        System.Diagnostics.Process.Start("https://www.notube.net/pt/convert")
    End Sub
    Private Sub PictureBoxProgramas_Click(sender As Object, e As EventArgs) Handles PictureBoxProgramas.Click
        System.Diagnostics.Process.Start("https://www.filehorse.com/")
        System.Diagnostics.Process.Start("https://www.downloadcrew.com/")
    End Sub
    'Botão de fechar
    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxPCescola1_Click(sender As Object, e As EventArgs) Handles PictureBoxPCescola1.Click
        System.Diagnostics.Process.Start("http://h10032.www1.hp.com/ctg/Manual/c01162629")
    End Sub

    Private Sub PictureBoxYoutube_Click(sender As Object, e As EventArgs) Handles PictureBoxYoutube.Click
        If MsgBox("Irá ser aberto um link com informações acerca do Youtube Premium, um 2 link com um vídeo no Youtube a explicar como instalar o Youtube Premium (Youtube Vanced) e um 3 link com a instalação, deseja continuar?", MsgBoxStyle.YesNo, "Download Youtube Premium - Android .apk") = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://www.youtube.com/premium")
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=cga4ve0_iF0")
            System.Diagnostics.Process.Start("https://vancedapp.com/")
        End If
    End Sub

    Private Sub PictureBoxSpotify_Click(sender As Object, e As EventArgs) Handles PictureBoxSpotify.Click
        If MsgBox("Irá ser aberto um link com informações acerca do Spotify Premium, um 2 link com um vídeo no Youtube a explicar como instalar o Spotify Premium, siga os passos no vídeo de como instalar, deseja continuar?", MsgBoxStyle.YesNo, "Download Spotify Premium - Android .apk") = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://www.spotify.com/pt/premium/?utm_source=pt_brand_contextual_text&utm_medium=paidsearch&utm_campaign=alwayson_europe_pt_performancemarketing_coreplus_brand+contextual+text+exact+pt+google&gclid=CjwKCAiA9vOABhBfEiwATCi7GIdYhm_1yE95fT_CT5US-Hwmp3a9y5ieRP8_sUnlh242GYJ4gVS2TRoCX8oQAvD_BwE&gclsrc=aw.ds")
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=bXb6O4zvE70&t")
        End If
    End Sub
End Class