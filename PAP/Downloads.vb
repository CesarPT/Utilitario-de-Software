Public Class Downloads
    'Variáveis
    Dim contador As Integer = 0
    Dim vetor(10) As String
    Dim numeros(10) As String
    Dim i As String
    'Vetores de Eletronica
    Private Sub Downloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxImagens.Image = ImageList.Images(0)
        TimerImagens.Enabled = True
        numeros(0) = "1/10"
        numeros(1) = "2/10"
        numeros(2) = "3/10"
        numeros(3) = "4/10"
        numeros(4) = "5/10"
        numeros(5) = "6/10"
        numeros(6) = "7/10"
        numeros(7) = "8/10"
        numeros(8) = "9/10"
        numeros(9) = "10/10"
        vetor(0) = "Autocad"
        vetor(1) = "Circuit Wizard"
        vetor(2) = "CxProgrammer"
        vetor(3) = "Eagle"
        vetor(4) = "Electronics Workbench"
        vetor(5) = "Fritzing"
        vetor(6) = "Multisim"
        vetor(7) = "PCBWizard"
        vetor(8) = "Progecad"
        vetor(9) = "Proteus"
    End Sub
    'TabControl: Sistemas Operativos
    Private Sub ButtonRequisitos1_Click(sender As Object, e As EventArgs)
        MsgBox("Requisitos mínimos:" & Chr(13) & "" & Chr(13) & "Processador: 1GHz ou superior" & Chr(13) & "RAM: 1GB (32bits) 2GB (64bits)" & Chr(13) & "Espaço em disco: 16GB (32bits) 20GB (64bits)" & Chr(13) & "Placa gráfica: DirectX 9 ou posterior com o controlador WDDM 1.0" & Chr(13) & "Ecrã: 800 x 600" & Chr(13) & "Se instalar em PEN, ISO, DVD: 8GB de armazenamento")
    End Sub
    Private Sub ButtonRequisitos2_Click(sender As Object, e As EventArgs)
        MsgBox("Requisitos mínimos:" & Chr(13) & "" & Chr(13) & "Processador: 1GHz ou superior" & Chr(13) & "RAM: 1GB (32/64bits)" & Chr(13) & "Espaço em disco: 30GB (32/64bits)" & Chr(13) & "Placa gráfica: Bons gráficos" & Chr(13) & "Ecrã: -" & Chr(13) & "Se instalar em PEN, ISO, DVD: 4GB de armazenamento")
    End Sub
    Private Sub ComboBoxWin10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWin10.SelectedIndexChanged
        If ComboBoxWin10.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Sistemas Operativos\Windows 10 Versao 20H2.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/?LinkId=691209")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.microsoft.com/pt-pt/software-download/windows10")
            End If
        End If
    End Sub
    Private Sub ComboBoxManjaro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxManjaro.SelectedIndexChanged
        If ComboBoxManjaro.SelectedItem = "Versão atualizada" Then
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    System.Diagnostics.Process.Start("https://osdn.net/frs/redir.php?m=plug&f=%2Fstorage%2Fg%2Fm%2Fma%2Fmanjaro%2Fxfce%2F20.2.1%2Fmanjaro-xfce-20.2.1-210103-linux59.iso")
                Else
                    System.Diagnostics.Process.Start("https://osdn.net/frs/redir.php?m=xtom_hk&f=%2Fstorage%2Fg%2Fm%2Fma%2Fmanjaro32%2Fxfce%2F18.0.4%2Fmanjaro-xfce-18.0.4-x32-stable-minimal-i686.iso")
                End If
            ElseIf vbNo Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    System.Diagnostics.Process.Start("https://manjaro.org/downloads/official/xfce/")
                Else
                    System.Diagnostics.Process.Start("https://manjaro.org/downloads/32bit/32bit-xfce/")
                End If
            End If
            End If
    End Sub
    Private Sub ComboBoxOutrosSO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOutrosSO.SelectedIndexChanged
        If ComboBoxOutrosSO.SelectedItem = "Ubuntu" Then
            System.Diagnostics.Process.Start("https://ubuntu.com/download/desktop")
        ElseIf ComboBoxOutrosSO.SelectedItem = "Lubuntu" Then
            System.Diagnostics.Process.Start("https://lubuntu.net/")
        ElseIf ComboBoxOutrosSO.SelectedItem = "Xubuntu" Then
            System.Diagnostics.Process.Start("https://xubuntu.org/")
        ElseIf ComboBoxOutrosSO.SelectedItem = "Kubuntu" Then
            System.Diagnostics.Process.Start("https://kubuntu.org/")
        Else
            System.Diagnostics.Process.Start("https://www.caixamagica.pt/linux-cm#downloads")
        End If
    End Sub
    'TabControl: Navegadores
    Private Sub ComboBoxMicrosoftEdge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMicrosoftEdge.SelectedIndexChanged
        If ComboBoxOutrosVC.SelectedItem = "Versão atualizada" Then
            System.Diagnostics.Process.Start("https://www.microsoft.com/pt-pt/edge")
        End If
    End Sub
    Private Sub ComboBoxChrome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxChrome.SelectedIndexChanged
        If ComboBoxChrome.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Navegadores\Google Chrome")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.google.com/intl/pt-PT/chrome/thank-you.html?statcb=1&installdataindex=empty&defaultbrowser=0#")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.google.com/intl/pt-PT/chrome/")
            End If
        End If
    End Sub
    Private Sub ComboBoxBrave_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBrave.SelectedIndexChanged
        If ComboBoxBrave.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Navegadores\Brave")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://laptop-updates.brave.com/latest/winx64")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://brave.com/")
            End If
        End If
    End Sub
    Private Sub ComboBoxMozillaFirefox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMozillaFirefox.SelectedIndexChanged
        If ComboBoxMozillaFirefox.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Navegadores\Mozilla Firefox")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.mozilla.org/pt-PT/firefox/download/thanks/")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.mozilla.org/pt-PT/firefox/new/")
            End If
        End If
    End Sub
    Private Sub ComboBoxOpera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOpera.SelectedIndexChanged
        If ComboBoxOpera.SelectedItem = "Executável" Then
            If System.Environment.Is64BitOperatingSystem = True Then
                Try
                    Process.Start("\Programas\Downloads\Navegadores\Opera GX x64")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            Else
                Try
                    Process.Start("\Programas\Downloads\Navegadores\Opera GX x32")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.opera.com/pt/computer/thanks?ni=eapgx&os=windows")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.opera.com/pt/gx")
            End If
        End If
    End Sub
    'TabControl: Office
    Private Sub PictureBoxOffice_Click_1(sender As Object, e As EventArgs) Handles PictureBoxOffice.Click
        If MsgBox("Antes de instalar o Office, certifique-se de qualquer Antivirus está desativado. Não há nenhum vírus no programa, mas o Windows assume como um programa desconhecido." & Chr(13) & "" & Chr(13) & "Escolhe Microsoft Office, a versão, o idioma e a arquitetura." & Chr(13) & "Será levado para um site externo seguro https://tb.rg-adguard.net/public.php. Pretende continuar?", vbYesNo, "Abrir link / Transferir / Instalar") = vbYes Then
            System.Diagnostics.Process.Start("https://tb.rg-adguard.net/public.php")
        End If
    End Sub
    'TabControl: Des-Compactadores
    Private Sub ComboBoxWinRar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWinRar.SelectedIndexChanged
        If ComboBoxWinRar.SelectedItem = "Executável" Then
            If System.Environment.Is64BitOperatingSystem = True Then
                Try
                    Process.Start("\Programas\Downloads\Des-Compactadores\WinRar x64.exe")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            Else
                Try
                    Process.Start("\Programas\Downloads\Des-Compactadores\WinRar x32.exe")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    System.Diagnostics.Process.Start("https://www.win-rar.com/postdownload.html?&L=9")
                Else
                    System.Diagnostics.Process.Start("https://www.win-rar.com/fileadmin/winrar-versions/winrar/wrar600.exe")
                End If
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.win-rar.com/start.html?&L=9")
            End If
        End If
    End Sub
    Private Sub ComboBoxIZArc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIZArc.SelectedIndexChanged
        If ComboBoxIZArc.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Des-Compactadores\IZArc.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.izarc.org/download/IZArc_4.4.exe")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.izarc.org/")
            End If
        End If
    End Sub
    Private Sub ComboBoxOutrosDesCompactadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOutrosDesCompactadores.SelectedIndexChanged
        If ComboBoxOutrosDesCompactadores.SelectedItem = "DAEMON Tools (32MB)" Then
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://dw.uptodown.com/dwn/If5kEJ9gaIyasB9OvhJX7c57SWPESZKar4-vYvUB_IashLxhoIn_gX4eoPZxrTP3FL2bN_6ZKF5_xmxf6ZkwwgkHirM8T3Bg_-aBO6hxi8WGLfp52w8_cCA9Vm8Vc6rG/1dTpZigMviwkuzdNwznZvO-PjxwfI-Ltn14nSHunwYZI0iwA15KCcHtHKwYOpEi9tIELisTNBVvYEWvfSb-SNJNQyhFEr1sP1DrmcOvLregwBBclBN6wa3TT5Ab-8Les/Xr55SIPd73DYq-tXWVH73qJZ4rckCQjUE7B_7wobFdR_y_DRdZ2o7Ta9kIYPoMt7MBqMM9KRTN4q8W_IJPfiXw==/")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://daemon-tools.br.uptodown.com/windows/download")
        End If
        End If
    End Sub
    'TabControl: VídeoChamadas
    Private Sub ComboBoxMT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMT.SelectedIndexChanged
        If ComboBoxMT.SelectedItem = "Executável" Then
            If System.Environment.Is64BitOperatingSystem = True Then
                Try
                    Process.Start("\Programas\Downloads\VideoChamadas\Microsoft Teams x64")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
                End Try
            Else
                Try
                    Process.Start("\Programas\Downloads\VideoChamadas\Microsoft Teams x32")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
                End Try
            End If
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/p/?LinkID=869426&clcid=0x816&culture=pt-pt&country=PT&lm=deeplink&lmsrc=groupChatMarketingPageWeb&cmpid=directDownloadWin64")
                Else
                    System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/p/?linkid=869427")
                End If
            ElseIf vbNo Then
                If System.Environment.Is64BitOperatingSystem = True Then
                    System.Diagnostics.Process.Start("https://www.microsoft.com/pt-pt/microsoft-365/microsoft-teams/download-app")
                Else
                    System.Diagnostics.Process.Start("https://www.filehorse.com/download-microsoft-teams-32/download/")
                End If
        End If
        End If
    End Sub
    Private Sub ComboBoxZoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxZoom.SelectedIndexChanged
        If ComboBoxZoom.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\VideoChamadas\Zoom")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://zoom.us/client/latest/ZoomInstaller.exe")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://zoom.us/download")
            End If
        End If
    End Sub
    Private Sub ComboBoxSkype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSkype.SelectedIndexChanged
        If ComboBoxSkype.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\VideoChamadas\Skype")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://go.skype.com/windows.desktop.download")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.skype.com/pt/")
            End If
        End If
    End Sub
    Private Sub ComboBoxOutrosVC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOutrosVC.SelectedIndexChanged
        If ComboBoxOutrosVC.SelectedItem = "Google Meet" Then
            System.Diagnostics.Process.Start("https://apps.google.com/meet/")
        Else
            System.Diagnostics.Process.Start("https://discordapp.com/")
        End If
    End Sub
    'TabControl: Eletronica
    Private Sub ComboBoxEletronica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEletronica.SelectedIndexChanged
        If (Not RadioButton1.Checked) AndAlso (Not RadioButton2.Checked) Then
            MsgBox("Acesso negado pelo utilizador. Não selecionou um Botão.")
        End If

        If RadioButton1.Checked Then
            If ComboBoxEletronica.SelectedItem = "MultiSim (1.47GB)" Then
                MsgBox("Depois de instalar, terá que ir no ativador, clicar com o botão esquerdo do rato na opção Education Edition.")
                System.Diagnostics.Process.Start("https://www.malavida.com/br/soft/ni-multisim/download")
            ElseIf ComboBoxEletronica.SelectedItem = "Circuit Wizard (100MB)" Then
                MsgBox("Será aberto um bloco de notas com as instruções para instalar o programa, traduzido em Português por mim.")
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1Wjoxbld8FvyAs-bCegyKJFBZrm6DqExf/view")
            ElseIf ComboBoxEletronica.SelectedItem = "Fritzing (227MB)" Then
                System.Diagnostics.Process.Start("https://www.electroschematics.com/fritzing-software-download/")
            ElseIf ComboBoxEletronica.SelectedItem = "ProgeCAD (2GB sem extensões)" Then
                System.Diagnostics.Process.Start("https://download.progecad.com/products/professional/2021/downloader_pcad2021proeng.exe")
            ElseIf ComboBoxEletronica.SelectedItem = "Cx Programmer (214MB)" Then
                System.Diagnostics.Process.Start("https://industrial.omron.pt/pt/products/cx-programmer#registration__downloads")
            ElseIf ComboBoxEletronica.SelectedItem = "Proteus (2GB)" Then
                System.Diagnostics.Process.Start("https://onlinejobmogul.com/download")
            ElseIf ComboBoxEletronica.SelectedItem = "Eagle (584MB)" Then
                System.Diagnostics.Process.Start("https://www.autodesk.com/products/eagle/free-download?plc=F360&term=1-YEAR&support=ADVANCED&quantity=1")
            ElseIf ComboBoxEletronica.SelectedItem = "Electronics Workbench (18MB)" Then
                System.Diagnostics.Process.Start("https://techsroat-network.com/electronicworkbench/")
            End If
        End If
        If RadioButton2.Checked Then
            Try
                If ComboBoxEletronica.SelectedItem = "MultiSim (1.47GB)" Then
                    MsgBox("Depois de instalar, terá que ir no ativador, clicar com o botão esquerdo do rato na opção Education Edition.")
                    Process.Start("\Programas\Downloads\Eletronica\MultiSim\autorun.exe")
                ElseIf ComboBoxEletronica.SelectedItem = "Circuit Wizard (100MB)" Then
                    MsgBox("Será aberto um bloco de notas com as instruções para instalar o programa, traduzido em Português por mim.")
                    Process.Start("\Programas\Downloads\Eletronica\Circuit Wizard\serial.txt")
                    Process.Start("\Programas\Downloads\Eletronica\Circuit Wizard\setup.exe")
                ElseIf ComboBoxEletronica.SelectedItem = "Fritzing (227MB)" Then
                    If MsgBox("Será aberta uma pasta com o Fritzing já instalado no local, copie para o local que deseja (Ambiente de Trabalho, por exemplo) e crie um atalho! Demora em torno de 15 minutos para copiar. Deseja continuar?", vbYesNo, "Abrir pasta e copiar") = vbYes Then
                        Shell("explorer /n,\Programas\Downloads\Eletronica", vbNormalFocus)
                    Else
                        MsgBox("Acesso negado pelo utilizador. Não foi possível copiar, verifique se o programa está em \Programas\Downloads\Eletronica\Fritzing")
                    End If

                ElseIf ComboBoxEletronica.SelectedItem = "ProgeCAD (2GB sem extensões)" Then
                    Process.Start("\Programas\Downloads\Eletronica\ProgeCAD\PCAD2021PROENGx64.exe")
                ElseIf ComboBoxEletronica.SelectedItem = "Cx Programmer (214MB)" Then
                    MsgBox("A instalação poderá demorar um pouco, consoante o computador.")
                    Process.Start("\Programas\Downloads\Eletronica\Cx Programmer\setup.exe")
                ElseIf ComboBoxEletronica.SelectedItem = "Proteus (2GB)" Then
                    If MsgBox("Será aberta uma pasta com o Proteus já instalado no local, copie para o local que deseja (Ambiente de Trabalho, por exemplo) e crie um atalho! Demora em torno de 5 minutos para copiar. Deseja continuar?", vbYesNo, "Abrir pasta e copiar") = vbYes Then
                        Shell("explorer /n,\Programas\Downloads\Eletronica", vbNormalFocus)
                    Else
                        MsgBox("Acesso negado pelo utilizador. Não foi possível copiar, verifique se o programa está em \Programas\Downloads\Eletronica\Proteus")
                    End If
                ElseIf ComboBoxEletronica.SelectedItem = "Eagle (584MB)" Then
                    Process.Start("\Programas\Downloads\Eletronica\Eagle\Eagle.exe")
                ElseIf ComboBoxEletronica.SelectedItem = "Electronics Workbench (18MB)" Then
                    Process.Start("\Programas\Downloads\Eletronica\Electronics Workbench\Electronics Workbench.exe")
                End If
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        End If
    End Sub
    Private Sub ComboBoxEletronicaAtivador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEletronicaAtivador.SelectedIndexChanged
        Try
            If ComboBoxEletronicaAtivador.SelectedItem = "MultiSim License Activator" Then
                Process.Start("\Programas\Downloads\Eletronica\MultiSim License Activator")
            End If
            If ComboBoxEletronicaAtivador.SelectedItem = "Circuit Wizard Activator" Then
                Process.Start("\Programas\Downloads\Eletronica\Circuit Wizard\cw150web.exe")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
        End Try
    End Sub
    'Contador das imagens em Eletronica
    Private Sub TimerImagens_Tick(sender As Object, e As EventArgs) Handles TimerImagens.Tick
        PictureBoxImagens.Image = ImageList.Images(contador)
        TextBoxImagens.Text = vetor(i)
        TextBoxNumeros.Text = numeros(i)
        i += 1
        contador += 1 'Próximo
        If ImageList.Images.Count = contador Then
            contador = 0 'Volta ao inicio das imagens
            i = 0
        End If
    End Sub
    'TabControl: Programacao
    Private Sub ComboBoxPascalzim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPascalzim.SelectedIndexChanged
        If ComboBoxPascalzim.SelectedItem = "Ficheiro .RAR" Then
            Try
                MsgBox("Será aberto uma pasta contendo o Pascalzim extraia-o para a pasta que deseja.")
                Shell("explorer /n,\Programas\Downloads\Programacao", vbNormalFocus)
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://drive.google.com/u/0/uc?id=0B3VoHkQew72qTUV0N3RyNlg3VEU&export=download")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("http://pascalzimbr.blogspot.com/p/blog-page.html")
            End If
        End If
    End Sub
    Private Sub ComboBoxCodeBlocks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCodeBlocks.SelectedIndexChanged
        If ComboBoxCodeBlocks.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Code Blocks.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.fosshub.com/Code-Blocks.html?dwl=codeblocks-20.03-setup.exe")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("http://www.codeblocks.org/downloads")
            End If
        End If
    End Sub
    Private Sub ComboBoxArduino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxArduino.SelectedIndexChanged
        If ComboBoxArduino.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Arduino IDE.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://www.arduino.cc/en/donate/")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://www.arduino.cc/en/software")
            End If
        End If
    End Sub
    Private Sub ComboBoxVB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVB.SelectedIndexChanged
        If ComboBoxVB.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Visual Basic Express 2010.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://microsoft-visual-basic-2010-express.software.informer.com/download/?ca8a44c")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://microsoft-visual-basic-2010-express.software.informer.com/download/")
            End If
        End If
    End Sub

    Private Sub ComboBoxVSCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVSCode.SelectedIndexChanged
        If ComboBoxVSCode.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Visual Studio Code.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://code.visualstudio.com/")
            End If
        End If
    End Sub

    Private Sub ComboBoxVSIDE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVSIDE.SelectedIndexChanged
        If ComboBoxVSIDE.SelectedItem = "Executável" And RadioButton2013.Checked Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Visual Studio IDE 2013.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        ElseIf ComboBoxVSIDE.SelectedItem = "Executável" And RadioButton2015.Checked Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Visual Studio IDE 2015.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        ElseIf ComboBoxVSIDE.SelectedItem = "Executável" And RadioButton2019.Checked Then
            Try
                Process.Start("\Programas\Downloads\Programacao\Visual Studio IDE 2019.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado.")
            End Try
        ElseIf ComboBoxVSIDE.SelectedItem = "Versão atualizada" Then
            System.Diagnostics.Process.Start("https://visualstudio.microsoft.com/vs/older-downloads/")
        Else
            MsgBox("Acesso negado pelo utilizador. Não selecionou um Botão (2013, 2015 ou 2019).")
        End If
    End Sub
    'TabControl: Personalização
    Private Sub ComboBoxRGBCursor_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxRGBCursor.SelectedIndexChanged
        If ComboBoxRGBCursor.SelectedItem = "Instalar" Then
            If MsgBox("Será aberta uma pasta clique com botão DIREITO do mouse em Install.inf e depois em Instalar, de seguida vá em Configurações do Mouse > Ponteiros e escolha o Chroma > Aplicar, deseja continuar?", vbYesNo, "Instalar / Configs Mouse") = vbYes Then
                Try
                    Shell("explorer /n,\Programas\Downloads\Personalizacao\CursorRGB", vbNormalFocus)
                    Process.Start("\Programas\Downloads\Personalizacao\CursorRGB\control mouse.bat")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Não foi possível abrir a pasta ou as configs do mouse, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        Else
            If MsgBox("Será aberto um link de um vídeo no Youtube com 10 tipos de cursores que pode instalar no PC (na descrição do vídeo estão os links), deseja continuar?", vbYesNo, "Mais cursores") = vbYes Then
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?app=desktop&v=oCdIh_oAfUk")
            End If
        End If
    End Sub
    Private Sub ComboBoxPastasCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFolderPainter.SelectedIndexChanged
        If ComboBoxFolderPainter.SelectedItem = "Executável" Then
            If MsgBox("Instale 1 ou mais packs de pastas do FolderPainter, depois é só clicar com o botão DIREITO do mouse numa pasta e escolher um pack de pastas, pretende continuar?", vbYesNo, "Instalar FolderPainter") = vbYes Then
                Try
                    Process.Start("\Programas\Downloads\Personalizacao\FolderPainter\FolderPainter.exe")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        End If
    End Sub
    Private Sub ComboBoxNexusDock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNexusDock.SelectedIndexChanged
        If ComboBoxNexusDock.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Personalizacao\Nexus Dock\Nexus Dock.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Não foi possível abrir a pasta ou as configs do mouse, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
            End Try
        End If
    End Sub
    Private Sub ComboBoxMaisPer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMaisPer.SelectedIndexChanged
        If ComboBoxMaisPer.SelectedItem = "Mais personalizações..." Then
            If MsgBox("Será aberto um link de um vídeo no Youtube com packs de personalização que pode instalar no PC (na descrição do vídeo estão os links), deseja continuar?", vbYesNo, "Instalar mais cursores") = vbYes Then
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=L3CHDCCcAIM")
            End If
        End If
    End Sub
    'TabControl: Simuladores
    Private Sub ComboBoxCiscoPT_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxCiscoPT.SelectedIndexChanged
        If ComboBoxCiscoPT.SelectedItem = "Executável" Then
            If System.Environment.Is64BitOperatingSystem = True Then
                Try
                    Process.Start("\Programas\Downloads\Simuladores\Cisco Packet Tracer x64.exe")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            Else
                Try
                    Process.Start("\Programas\Downloads\Simuladores\Cisco Packet Tracer x32.exe")
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        Else
            System.Diagnostics.Process.Start("https://www.computernetworkingnotes.com/ccna-study-guide/download-packet-tracer-for-windows-and-linux.html")
        End If
    End Sub

    Private Sub ComboBoxSimIntel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSimIntel.SelectedIndexChanged
        If ComboBoxSimIntel.SelectedItem = "Portable" Then
            If MsgBox("Será aberta uma pasta copie o Simulador de Defeitos da Intel para o local que deseja e crie um atalho para acedê-lo, deseha continuar?", vbYesNo, "Portable Simulador Defeitos da Intel") = vbYes Then
                Try
                    Shell("explorer /n,\Programas\Downloads\Simuladores", vbNormalFocus)
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Não foi possível abrir a pasta \Programas\Downloads\Simuladores, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        End If
    End Sub

    Private Sub ComboBoxSimPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSimPC.SelectedIndexChanged
        If ComboBoxSimPC.SelectedItem = "Portable" Then
            If MsgBox("Será aberta uma pasta copie o Simulador de Montagem de PC para o local que deseja e crie um atalho para acedê-lo, deseha continuar?", vbYesNo, "Portable Simulador de Montagem de PC") = vbYes Then
                Try
                    Shell("explorer /n,\Programas\Downloads\Simuladores", vbNormalFocus)
                Catch ex As Exception
                    MsgBox("Acesso negado pelo utilizador. Não foi possível abrir a pasta \Programas\Downloads\Simuladores, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
                End Try
            End If
        End If
    End Sub
    'TabControl: Outros
    Private Sub ComboBoxPhotoshop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPhotoshop.SelectedIndexChanged
        If ComboBoxPhotoshop.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Outros\PhotoshopCS3\PhotoshopCS3.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Não foi possível abrir o executável, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://dl7.softmany.com/dwnld/703/OQOISWHgT0iTDwaG3rplhWvGtreAx6WA/ADBEPOHSPCS3.zip")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://softmany.com/adobe-photoshop-cs3/download/")
            End If
        End If
    End Sub
    Private Sub ComboBoxFilmora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilmora.SelectedIndexChanged
        If ComboBoxFilmora.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Outros\Filmora X.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Não foi possível abrir o executável, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
            End Try
        Else
            If MsgBox("Se pretender download automático clique em SIM, se pretender ir ao site e fazer o download manual clique em NÃO.", MessageBoxButtons.YesNo) = vbYes Then
                System.Diagnostics.Process.Start("https://dl7.softmany.com/dwnld/703/OQOISWHgT0iTDwaG3rplhWvGtreAx6WA/ADBEPOHSPCS3.zip")
            ElseIf vbNo Then
                System.Diagnostics.Process.Start("https://dw.malavida.com/aHVya2dsb1dKaCtNOHlDRFZLR2htZk01VXdtU2JNK0FYVkZvclljOWtqVzRmZVRmbmxEQWUwRTJwd1lMZ2l2cXo0alhOT2ErRGFs/NDZhdmZITUMyVDlGVGVPUzZWUGlPVzJzbWd2WnV0L2kxaVdvUVVNNkRMVG1Gb0k1dnNETU8xVUNHU3NIUTBPalJaZXFnZWNGUmRt/VW1ROFpsRDhHV1JoQ3RkNHBKUWpJS2h3OFN6TmhIVG9WK1RzVy9nOFlPcHBJVWt2dy92TkcwSURsbFU2TUJjY3hUdmNCNStzSS9O/a1BXNHplc0NWZTQvaVBjSE1lT29KTXVBakcxanc5NHNGSnlldWI4TmhhVmd4S2dpMWlVd2lHc3pQUjJTdGRSczhtcUlhVzE1dDRX/RkZkSjJTY201TE1lR0xZYUx3NzlCMGdoSnlMODN3Q1lsUWJuNWlHNkxQL29zVHFuS01hWG04eE1zcVpZV0VlcUJXQllLU3BQTXVQ/ZS9jTi93Z2R0VmY1WlhoeDRSQU1CeVlLS3NHWHZrZzY5Sm0vTlRFb2k0YVgreFBnV0pyc1krMXVVWWhUS2RQTU1ndHZOcDZhZG52/RnB6enZaeTZPb2xhU1UzUmcyNytFU3Q0Q1BvN1duQWlWeTRqb0IzbWtkbUFsaUtnYzlRYkpZUHRmSXBpZ0RHSGtwTDhoaHZ6SXhM/SXhvS3BIcDhDSFhNcm9PelorTVE5WmR3T1pIdWtGSWxIRjJSbVpsWTJjZjVBMTBpam8yeU51MVVTR2FYS25GRnpBaWpOOVVaQT09/ea60f2a27afc0252")
            End If
        End If
    End Sub
    Private Sub ComboBoxUSBDS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUSBDS.SelectedIndexChanged
        If ComboBoxUSBDS.SelectedItem = "Executável" Then
            Try
                Process.Start("\Programas\Downloads\Outros\USB Disk Security.exe")
            Catch ex As Exception
                MsgBox("Acesso negado pelo utilizador. Não foi possível abrir o executável, consulte o ficheiro Ajuda.txt para ver a pasta onde está inserido o programa.")
            End Try
        End If
    End Sub
    Private Sub LinkLabelAjuda_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAjuda.LinkClicked
        Try
            Process.Start("\Programas\Ajuda.txt")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Ajuda.txt")
        End Try
    End Sub
    'Botão de minimizar
    Private Sub PictureBoxMini_Click(sender As Object, e As EventArgs) Handles PictureBoxMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Botão de fechar
    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub
End Class