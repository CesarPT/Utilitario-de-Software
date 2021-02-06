Public Class Inicio
    'Variáveis
    Dim x As Integer = 800
    Dim y As Integer = 351 'Posição y no Inicio.vb

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Me.WindowState = FormWindowState.Normal
        LabelDate.Text = Today
        LabelUtilizador.Text = Environment.MachineName & " - " & System.Environment.UserName
        'Saber se um utilizador é Admin ou não ao executar a app
        If My.User.IsInRole(ApplicationServices.BuiltInRole.User) Then
            LabelAdminLevel.Text = "Não"
            LabelAdminLevel.ForeColor = Color.Red
        Else
            LabelAdminLevel.Text = "Sim"
            LabelAdminLevel.ForeColor = Color.Green
        End If
        LabelRodape.Text = "Bem vindo à aplicação Utilitário de Software, feito por César Guimarães Nº3 12ºEI"
        LabelRodape.Font = New Font("", 13)
        TimerRodape.Interval = 1
        TimerRodape.Start()
    End Sub
    Private Sub TimerRodape_Tick(sender As Object, e As EventArgs) Handles TimerRodape.Tick
        LabelRodape.SetBounds(x, y, 1, 1)
        x -= 2
        If (x <= 80) Then 'Limite no Form
            x = 80 'Fixa na posição 80
        End If
    End Sub
    Private Sub TimerDataHora_Tick(sender As Object, e As EventArgs) Handles TimerDataHora.Tick
        LabelHour.Text = TimeString
    End Sub
    'Botões
    Private Sub ButtonInformacoes_Click_1(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        ButtonInfo.BackColor = Color.FromArgb(53, 184, 180)
        ButtonFerramentas.BackColor = Color.WhiteSmoke
        ButtonDownloads.BackColor = Color.WhiteSmoke
        ButtonOutros.BackColor = Color.WhiteSmoke
        ButtonEscola.BackColor = Color.WhiteSmoke
        InformacoesDiagnostico.Show()
    End Sub

    Private Sub ButtonFerramentas_Click_1(sender As Object, e As EventArgs) Handles ButtonFerramentas.Click
        ButtonInfo.BackColor = Color.WhiteSmoke
        ButtonFerramentas.BackColor = Color.FromArgb(53, 184, 180)
        ButtonDownloads.BackColor = Color.WhiteSmoke
        ButtonOutros.BackColor = Color.WhiteSmoke
        ButtonEscola.BackColor = Color.WhiteSmoke
        Ferramentas.Show()
    End Sub
    Private Sub ButtonDownloads_Click(sender As Object, e As EventArgs) Handles ButtonDownloads.Click
        ButtonInfo.BackColor = Color.WhiteSmoke
        ButtonFerramentas.BackColor = Color.WhiteSmoke
        ButtonDownloads.BackColor = Color.FromArgb(53, 185, 180)
        ButtonOutros.BackColor = Color.WhiteSmoke
        ButtonEscola.BackColor = Color.WhiteSmoke
        Downloads.Show()
    End Sub
    Private Sub ButtonOutros_Click(sender As Object, e As EventArgs) Handles ButtonOutros.Click
        ButtonInfo.BackColor = Color.WhiteSmoke
        ButtonFerramentas.BackColor = Color.WhiteSmoke
        ButtonDownloads.BackColor = Color.WhiteSmoke
        ButtonOutros.BackColor = Color.FromArgb(53, 184, 180)
        ButtonEscola.BackColor = Color.WhiteSmoke
        Outros.Show()
    End Sub
    Private Sub ButtonEscola_Click(sender As Object, e As EventArgs) Handles ButtonEscola.Click
        ButtonInfo.BackColor = Color.WhiteSmoke
        ButtonFerramentas.BackColor = Color.WhiteSmoke
        ButtonDownloads.BackColor = Color.WhiteSmoke
        ButtonOutros.BackColor = Color.WhiteSmoke
        ButtonEscola.BackColor = Color.FromArgb(53, 184, 180)
        Escola.Show()
    End Sub
    Private Sub FlatButtonEstilo_Click(sender As Object, e As EventArgs) Handles FlatButtonEstilo.Click
        Estilo.Show()
    End Sub
    Private Sub FlatButtonCreditos_Click(sender As Object, e As EventArgs) Handles FlatButtonCreditos.Click
        MsgBox("Créditos - PAP: Aplicação Utilitário de Software" & Chr(13) & "" & Chr(13) & "Nome: César Guimarães" & Chr(13) & "Número: 3" & Chr(13) & "Turma: 12ºEI" & Chr(13) & "Curso Profissional: Técnico de Gestão de Equipamentos Informáticos (2020/2021)" & Chr(13) & "Escola: EB2/3 e Secundária de Ermesinde" & Chr(13) & "" & Chr(13) & "Contato" & Chr(13) & "Email: cesarguimaraes2003@gmail.com")
    End Sub
    Private Sub PictureBoxAjuda_Click(sender As Object, e As EventArgs) Handles PictureBoxAjuda.Click
        ToolTipControlBox.SetToolTip(PictureBoxAjuda, "Ajuda")
        Try
            Process.Start("\Programas\Ajuda.txt")
        Catch ex As Exception
            MsgBox("Acesso negado pelo utilizador. Consulte o ficheiro Ajuda.txt para ver se o nome da pasta/ficheiro foi alterado. Localização: \Programas\Ajuda.txt")
        End Try
    End Sub
    'Radio
    Private Sub PictureBoxSom_Click_1(sender As Object, e As EventArgs) Handles PictureBoxSom.Click
        System.Diagnostics.Process.Start("https://onlineradiobox.com/")
    End Sub
    Private Sub ButtonSanDisk_Click(sender As Object, e As EventArgs) Handles ButtonSanDisk.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=3VS8xbww9_M&list=PLmtQIL2VA7Fkj_SIYHPCXP6r99SCvYspj")
    End Sub
    Private Sub TimerContador_Tick(sender As Object, e As EventArgs) Handles TimerContador.Tick
        LabelSeg.Text += 1
        If LabelSeg.Text = 60 Then
            LabelMin.Text += 1
            LabelSeg.Text = 0
        ElseIf LabelMin.Text = 60 Then
            LabelHora.Text += 1
            LabelMin.Text = 0
        End If
    End Sub
End Class