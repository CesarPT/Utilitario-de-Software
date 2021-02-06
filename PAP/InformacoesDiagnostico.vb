Public Class InformacoesDiagnostico
    Private Sub InformacoesDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Environment.Is64BitOperatingSystem = True Then
            LabelAr.Text = "x64"
        Else
            LabelAr.Text = "x32"
        End If
    End Sub
    Private Sub ButtonSystemInfo_Click(sender As Object, e As EventArgs) Handles ButtonSystemInfo.Click
        Try
            Process.Start("\Programas\Diagnostico\systeminfo.bat")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Diagnostico\systeminfo.bat")
        End Try
    End Sub
    Private Sub ButtonIPConfig_Click(sender As Object, e As EventArgs) Handles ButtonIPConfig.Click
        Try
            Process.Start("\Programas\Diagnostico\ipconfig.bat")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Diagnostico\ipconfig.bat")
        End Try
    End Sub
    Private Sub ButtonIPConfigAll_Click(sender As Object, e As EventArgs) Handles ButtonIPConfigAll.Click
        Try
            Process.Start("\Programas\Diagnostico\ipconfigall.bat")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Diagnostico\ipconfigall.bat")
        End Try
    End Sub
    Private Sub PictureBoxHWINFO_Click_1(sender As Object, e As EventArgs) Handles PictureBoxHWINFO.Click
        Try
            If System.Environment.Is64BitOperatingSystem = True Then
                Process.Start("\Programas\Diagnostico\HWINFO64.exe")
            Else
                Process.Start("\Programas\Diagnostico\HWINFO32.exe")
            End If
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Diagnostico\HWINFO32.exe ou HWINFO64.exe")
        End Try
    End Sub
    Private Sub PictureBoxCPUZ_Click(sender As Object, e As EventArgs) Handles PictureBoxCPUZ.Click
        Try
            Process.Start("\Programas\Diagnostico\CPU-Z\cpuz.exe")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Diagnostico\CPU-Z\cpuz.exe")
        End Try
    End Sub
    'Botão de fechar
    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub
End Class