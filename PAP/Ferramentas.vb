Public Class Ferramentas
    '-------------------
    'Botões de Descrição
    '-------------------
    Private Sub ButtonDescricao1_Click(sender As Object, e As EventArgs) Handles ButtonDescricao1.Click
        If ComboBoxAntivirus.SelectedItem = "Avast Free Antivírus" Then
            MsgBox("Funções de Avast Free Antivirus:" & Chr(13) & "" & Chr(13) & "Avast Antivírus é uma família de softwares antivírus desenvolvidos pela Avast Software, sediada na cidade de Praga, na República Tcheca. Sua primeira versão foi lançada em 1988. O Avast conta com mais de 170 milhões de usuários registrados espalhados pelo mundo. - Wikipedia")
        ElseIf ComboBoxAntivirus.SelectedItem = "SUPERAntiSpyware" Then
            MsgBox("Funções de SUPERAntiSpyware:" & Chr(13) & "" & Chr(13) & "SUPERAntiSpyware é um aplicativo de software que pode detectar e remover spyware, adware, cavalos de Troia, software de segurança não autorizado, worms de computador, rootkits, parasitas e outros aplicativos de software potencialmente prejudiciais. - Wikipedia")
        ElseIf ComboBoxAntivirus.SelectedItem = "MalwareBytes" Then
            MsgBox("Funções de MalwareBytes:" & Chr(13) & "" & Chr(13) & "Malwarebytes é uma aplicação para computadores que funciona nos sistemas operativos Microsoft Windows e na Apple OS X que detecta e elimina malware. É desenvolvido pela Malwarebytes Corporation e foi lançado em janeiro de 2008. - Wikipedia")
        ElseIf ComboBoxAntivirus.SelectedItem = "  MalwareBytes AdwCleaner" Then
            MsgBox("Funções de MalwareBytes AdwCleaner:" & Chr(13) & "" & Chr(13) & "Mensagens estranhas surgindo na internet? A página inicial do navegador mudou sem sua permissão? Isso pode ser um adware (e seus amigos), uma variante sorrateira de malware que é difícil de encontrar e mais difícil de remover. AdwCleaner remove.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao2_Click(sender As Object, e As EventArgs) Handles ButtonDescricao2.Click
        If ComboBoxOtimizacao.SelectedItem = "CCleaner" Then
            MsgBox("Funções de CCleaner:" & Chr(13) & "" & Chr(13) & "Limpa histórico, cookies, ficheiros temporários, reciclagem..." & Chr(13) & "Corrige erros nos ficheiros.")
        ElseIf ComboBoxOtimizacao.SelectedItem = "IOBIT Advanced System Care" Then
            MsgBox("Funções de IOBIT Advanced System Care:" & Chr(13) & "" & Chr(13) & "Analisa e corrige problemas e limpa ficheiros inúteis." & Chr(13) & "Impulsionar e atualizar aplicações." & Chr(13) & "Contém proteções de firewall, email, senhas, sites, etc.")
        ElseIf ComboBoxOtimizacao.SelectedItem = "Smart Defrag" Then
            MsgBox("Funções de Smart Defrag:" & Chr(13) & "" & Chr(13) & "Desfragmentação (rápida, lenta ou no arranque) e otimização de memória secundária e flash.")
        ElseIf ComboBoxOtimizacao.SelectedItem = "Mem Reduct" Then
            MsgBox("Funções de Mem Reduct:" & Chr(13) & "" & Chr(13) & "Limpa a memória RAM e Cache.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao3_Click(sender As Object, e As EventArgs) Handles ButtonDescricao3.Click
        If ComboBoxAtualizacoes.SelectedItem = "Windows Update" Then
            MsgBox("Funções de Windows Update:" & Chr(13) & "" & Chr(13) & "Procura por atualizações disponíveis no computador (necessário uma ligação à internet).")
        ElseIf ComboBoxAtualizacoes.SelectedItem = "IOBIT Driver Booster" Then
            MsgBox("Funções de IOBIT Driver Booster:" & Chr(13) & "" & Chr(13) & "Atualiza drivers de dispositivos (mesmo offline)." & Chr(13) & "Impulsionar aplicações." & Chr(13) & "Corrigir problemas comuns de som, rede e outros.")
        ElseIf ComboBoxAtualizacoes.SelectedItem = "SuperANTISpyware" Then
            MsgBox("Descrição de SUPERAntiSpyware" & Chr(13) & "" & Chr(13) & "")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao4_Click(sender As Object, e As EventArgs) Handles ButtonDescricao4.Click
        If ComboBoxArmazenamento.SelectedItem = "Clonezilla Live" Then
            MsgBox("Funções de Clonezilla Live:" & Chr(13) & "" & Chr(13) & "Clonezilla Live é adequado para backup e restauração em uma única máquina. Salva e restaura apenas blocos usados ​​na memória secundára, isso aumenta a eficiência da clonagem." & Chr(13) & "" & Chr(13) & "Atenção:" & Chr(13) & "Deve ser instalado em unidades amovíveis como PEN Drives ou discos externos." & Chr(13) & "A partição de destino deve ser igual ou maior que a de origem.")
        ElseIf ComboBoxArmazenamento.SelectedItem = "Macrorit Partition Expert" Then
            MsgBox("Funções de Macrorit Partition Expert:" & Chr(13) & "" & Chr(13) & "Criar boots, clonar..." & Chr(13) & "Mudar propriedades do disco (nome, label...), mover/editar/remover partições, formatar, etc.")
        ElseIf ComboBoxArmazenamento.SelectedItem = "Limpeza do disco" Then
            MsgBox("Funções de limpeza do disco:" & Chr(13) & "" & Chr(13) & "Irá verificar ficheiros temporários, atualizações antigas no computador com a aplicação nativa do Windows cleanmgr.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao5_Click(sender As Object, e As EventArgs) Handles ButtonDescricao5.Click
        If ComboBoxRecuperacao.SelectedItem = "EaseUS Data Recovery Technician" Then
            MsgBox("Funções de EaseUS Data Recovery Technician:" & Chr(13) & "" & Chr(13) & "Faz uma verificação profunda e recupera ficheiros, imagens, vídeos que já não estão no disco rígido, SSD, PEN drives, etc. Versão crackeada (seguro).")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao6_Click(sender As Object, e As EventArgs) Handles ButtonDescricao6.Click
        If ComboBoxAcessoRemoto.SelectedItem = "AnyDesk" Then
            MsgBox("Funções de AnyDesk:" & Chr(13) & "" & Chr(13) & "Permite criar uma conexão com um ou mais dispositivos externos com a possibilidade de fazer multifunções no computador (desligar, escrever...) sem a necessidade de ter à mão um teclado ou mouse." & Chr(13) & "É necessário ter a aplicação no outro dispositivo.")
        ElseIf ComboBoxArmazenamento.SelectedItem = "CombatV3 3.3" Then
            MsgBox("Funções de CombatV 3.3:" & Chr(13) & "" & Chr(13) & "O sistema CombatV3 tem como objetivo o auxilio na busca de hacks/jogos, em computadores de possíveis infratores. Atenção: em baixo no centro tem 2 paineis que pode clicar.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao7_Click(sender As Object, e As EventArgs) Handles ButtonDescricao7.Click
        If ComboBoxPersonalizacao.SelectedItem = "Painel de Controle - Personalizar" Then
            MsgBox("Funções de Painel de Controle - Personalizar:" & Chr(13) & "" & Chr(13) & "Irá abrir o painel de controlo > Personalização (necessário ter o Windows ativado). Mais programas em Downloads.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao8_Click(sender As Object, e As EventArgs) Handles ButtonDescricao8.Click
        If ComboBoxOutros.SelectedItem = "GodMode" Then
            MsgBox("Funções de GodMode:" & Chr(13) & "" & Chr(13) & "GodMode é uma pasta que contém ligações para várias ferramentas importantes do Windows como: Administração, Backup e Restaurar, Data e Hora, Mouse, Teclado, Problemas...")
        ElseIf ComboBoxOutros.SelectedItem = "iTop VPN" Then
            MsgBox("Funções de iTop VPN:" & Chr(13) & "" & Chr(13) & "Na versão gratuita dá acesso a 3 servidores VPN (cada um com limite máximo de 700MB diários) que protege o IP do utilizador e criptografia os dados de rede para garantir que a localização, identidade e atividade não sejam monitoradas e controladas por hackers.")
        ElseIf ComboBoxOutros.SelectedItem = "Petst" Then
            MsgBox("Funções de Petst:" & Chr(13) & "" & Chr(13) & "Passmark Performance Test é um utilitário de benchmark de hardware de PC premiado que permite avaliar rapidamente o desempenho de seu computador e compará-lo a outros computadores. Descubra se o seu PC está tendo o melhor desempenho, compare o desempenho da sua máquina com máquinas semelhantes e faça medições independentes objetivas nas quais basear sua decisão de compra.")
        ElseIf ComboBoxOutros.SelectedItem = "USBDeview" Then
            MsgBox("Funções de USBDeview:" & Chr(13) & "" & Chr(13) & "USBDeview permite desativar/ativar dispositivos USB e a última data em que eles foram inseridos. Muito útil para encontrar infratores num determinado horário.")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    Private Sub ButtonDescricao9_Click(sender As Object, e As EventArgs) Handles ButtonDescricao9.Click
        If ComboBoxTestes.SelectedItem = "Petst" Then
            MsgBox("Funções de Petst:" & Chr(13) & "" & Chr(13) & "Passmark Performance Test é um utilitário de benchmark de hardware de PC premiado que permite avaliar rapidamente o desempenho de seu computador e compará-lo a outros computadores. Descubra se o seu PC está tendo o melhor desempenho, compare o desempenho da sua máquina com máquinas semelhantes e faça medições independentes objetivas nas quais basear sua decisão de compra.")
        ElseIf ComboBoxTestes.SelectedItem = "UserBenchMark" Then
            MsgBox("Funções de UserBenchMark:" & Chr(13) & "" & Chr(13) & "Informa o desempenho do computador do usuário em comparação com outras máquinas do mesmo modelo. Também apresenta diagnósticos de qual hardware pode ser responsável pela performance abaixo da média da máquina.")
        ElseIf ComboBoxTestes.SelectedItem = "MSI AfterBurner" Then
            MsgBox("Funções de MSI AfterBurner:" & Chr(13) & "" & Chr(13) & "MSI AfterBurner é um software de placa de vídeo mais usado, funciona em qualquer placa (mesmo não sendo MSI). Dá a possibilidade de overclock, permite monitorar o hardware em tempo real.")
        ElseIf ComboBoxTestes.SelectedItem = "FurMark" Then
            MsgBox("Funções de FurMark:" & Chr(13) & "" & Chr(13) & "FurMark é um teste de estresse de placa de vídeo / GPU leve, mas muito intensivo na plataforma Windows. É também um benchmark OpenGL rápido (com pontuações online).")
        Else
            MsgBox("Não selecionou um programa.")
        End If
    End Sub
    '-------------------
    'Botões de Abrir
    '-------------------
    Private Sub ButtonAbrir1_Click(sender As Object, e As EventArgs) Handles ButtonAbrir1.Click
        Try
            If ComboBoxAntivirus.SelectedItem = "Avast Free Antivírus" Then
                Process.Start("\Programas\Ferramentas\Antivirus\Avast Free Antivirus\AvastUI.exe")
            ElseIf ComboBoxAntivirus.SelectedItem = "SUPERAntiSpyware" Then
                Process.Start("\Programas\Ferramentas\Antivirus\SUPERAntiSpyware\SUPERAntiSpyware.exe")
            ElseIf ComboBoxAntivirus.SelectedItem = "MalwareBytes" Then
                Process.Start("\Programas\Ferramentas\Antivirus\MalwareBytes\mbam.exe")
            ElseIf ComboBoxAntivirus.SelectedItem = "  MalwareBytes AdwCleaner" Then
                Process.Start("\Programas\Ferramentas\Antivirus\AdwCleaner.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir2_Click(sender As Object, e As EventArgs) Handles ButtonAbrir2.Click
        Try
            If ComboBoxOtimizacao.SelectedItem = "CCleaner" Then
                Process.Start("\Programas\Ferramentas\Otimizacao\CCleaner\CCleaner.exe")
            ElseIf ComboBoxOtimizacao.SelectedItem = "IOBIT Advanced System Care" Then
                Process.Start("\Programas\Ferramentas\Otimizacao\IOBIT Advanced System Care\ASC.exe")
            ElseIf ComboBoxOtimizacao.SelectedItem = "Smart Defrag" Then
                Process.Start("\Programas\Ferramentas\Otimizacao\Smart Defrag\SmartDefrag.exe")
            ElseIf ComboBoxOtimizacao.SelectedItem = "Mem Reduct" Then
                Process.Start("\Programas\Ferramentas\Otimizacao\Mem Reduct\memreduct.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir3_Click(sender As Object, e As EventArgs) Handles ButtonAbrir3.Click
        Try
            If ComboBoxAtualizacoes.SelectedItem = "Windows Update" Then
                Process.Start("\Programas\Ferramentas\Atualizacoes\Windows Update")
            ElseIf ComboBoxAtualizacoes.SelectedItem = "IOBIT Driver Booster" Then
                Process.Start("\Programas\Ferramentas\Atualizacoes\IOBIT Driver Booster\DriverBooster.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir4_Click(sender As Object, e As EventArgs) Handles ButtonAbrir4.Click
        Try
            If ComboBoxArmazenamento.SelectedItem = "Clonezilla Live" Then
                MsgBox("Será aberto um link externo se tiver dúvidas de como usar o Clonezilla." & Chr(13) & "Depois será aberta uma pasta, copie todos os ficheiros que estão na pasta para uma unidade amovível como uma PEN Drive ou um Disco Externo (formatado).")
                System.Diagnostics.Process.Start("https://clonezilla.org/clonezilla-live-doc.php")
                Shell("explorer /n,\Programas\Ferramentas\Armazenamento\Clonezilla Live", vbNormalFocus)
            ElseIf ComboBoxArmazenamento.SelectedItem = "Macrorit Partition Expert" Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    Process.Start("\Programas\Ferramentas\Armazenamento\Macrorit Partition Expert\x64\dm.exe")
                Else
                    Process.Start("\Programas\Ferramentas\Armazenamento\Macrorit Partition Expert\x86\dm.exe")
                End If
            ElseIf ComboBoxArmazenamento.SelectedItem = "Limpeza do disco" Then
                Process.Start("\Programas\Ferramentas\Armazenamento\cleanmgr.bat")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir5_Click(sender As Object, e As EventArgs) Handles ButtonAbrir5.Click
        Try
            If ComboBoxRecuperacao.SelectedItem = "EaseUS Data Recovery Technician" Then
                Process.Start("\Programas\Ferramentas\Armazenamento\EaseUS Data Recovery Wizard\DRW.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir6_Click(sender As Object, e As EventArgs) Handles ButtonAbrir6.Click
        Try
            If ComboBoxAcessoRemoto.SelectedItem = "AnyDesk" Then
                Process.Start("\Programas\Ferramentas\Acesso Remoto\AnyDesk.exe")
            ElseIf ComboBoxArmazenamento.SelectedItem = "CombatV3 3.3" Then
                Process.Start("\Programas\Ferramentas\Armazenamento\CombatV3 3.3.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir7_Click(sender As Object, e As EventArgs) Handles ButtonAbrir7.Click
        Try
            If ComboBoxPersonalizacao.SelectedItem = "Painel de Controle - Personalizar" Then
                Process.Start("\Programas\Ferramentas\personalizacao.bat")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir8_Click(sender As Object, e As EventArgs) Handles ButtonAbrir8.Click
        Try
            If ComboBoxOutros.SelectedItem = "GodMode" Then
                Process.Start("\Programas\Ferramentas\Outros\GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}")
            ElseIf ComboBoxOutros.SelectedItem = "iTop VPN" Then
                Process.Start("\Programas\Ferramentas\Outros\iTop VPN\iTopVPN.exe")
            ElseIf ComboBoxOutros.SelectedItem = "USBDeview" Then
                Process.Start("\Programas\Ferramentas\Outros\USBDeview.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    Private Sub ButtonAbrir9_Click(sender As Object, e As EventArgs) Handles ButtonAbrir9.Click
        Try
            If ComboBoxTestes.SelectedItem = "Petst" Then
                MsgBox("Será aberto o executável petst.exe, por favor instale na partição C: ou uma partição do disco principal do PC ou o programa não irá detetar os componentes do computador.")
                Process.Start("\Programas\Ferramentas\Testes\petst.exe")
            ElseIf ComboBoxTestes.SelectedItem = "UserBenchMark" Then
                Process.Start("\Programas\Ferramentas\Testes\UserBenchMark.exe")
            ElseIf ComboBoxTestes.SelectedItem = "MSI AfterBurner" Then
                Process.Start("\Programas\Ferramentas\Testes\MSI AfterBurner\MSIAfterburner.exe")
            ElseIf ComboBoxTestes.SelectedItem = "FurMark" Then
                Process.Start("\Programas\Ferramentas\Testes\FurMark\FurMark.exe")
            Else
                MsgBox("Não selecionou um programa.")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. A ferramenta que pretende abrir foi modificada/alterada a sua localização. Verifique em 'Ajuda' o local em que está inserida.")
        End Try
    End Sub
    'Botão de fechar
    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub
    'Botão de minimizar
    Private Sub PictureBoxMini_Click(sender As Object, e As EventArgs) Handles PictureBoxMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class