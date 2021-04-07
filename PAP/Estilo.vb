Public Class Estilo
    Dim FontCollection As New System.Drawing.Text.InstalledFontCollection 'Fontes instaladas na máquina
    Private Sub ComboBoxLetra_DrawItem(send As Object, e As DrawItemEventArgs)
        'Colocar negrito, itálico... nos tipos de letras no combobox
        Dim fn As New Font(FontCollection.Families(e.Index), 12)
        e.DrawBackground()
        e.Graphics.DrawString(FontCollection.Families(e.Index).Name, fn, New SolidBrush(ComboBoxLetra.ForeColor), e.Bounds)
    End Sub

    Private Sub Estilos_Letra_Cor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxLetra.ItemHeight = 20
        For Each FontFamily In FontCollection.Families
            ComboBoxLetra.Items.Add(FontFamily.Name)
        Next
    End Sub

    Private Sub ComboBoxLetra_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxLetra.SelectedIndexChanged
        Inicio.ButtonInfo.Font = New Font(ComboBoxLetra.Text, 14)
        Inicio.ButtonFerramentas.Font = New Font(ComboBoxLetra.Text, 14)
        Inicio.ButtonDownloads.Font = New Font(ComboBoxLetra.Text, 14)
        Inicio.ButtonOutros.Font = New Font(ComboBoxLetra.Text, 14)
        Inicio.ButtonEscola.Font = New Font(ComboBoxLetra.Text, 14)
        My.Settings.LetraSalva = New Font(ComboBoxLetra.Text, 14)
        My.Settings.Save()
    End Sub

    Private Sub ButtonResetLetra_Click(sender As Object, e As EventArgs) Handles ButtonResetLetra.Click
        Inicio.ButtonInfo.Font = New Font("Microsoft Sans Serif", 14)
        Inicio.ButtonFerramentas.Font = New Font("Microsoft Sans Serif", 14)
        Inicio.ButtonDownloads.Font = New Font("Microsoft Sans Serif", 14)
        Inicio.ButtonOutros.Font = New Font("Microsoft Sans Serif", 14)
        Inicio.ButtonEscola.Font = New Font("Microsoft Sans Serif", 14)
        My.Settings.LetraSalva = New Font("Microsoft Sans Serif", 14)
        My.Settings.Save()
    End Sub

    Private Sub ButtonColorDialogBaixo_Click(sender As Object, e As EventArgs) Handles ButtonColorDialogBaixo.Click
        'As variáveis coresbaixo e corescima fecham o ColorDialog ao clicar em OK.
        Dim CorPanelBaixo As New ColorDialog
        CorPanelBaixo.ShowDialog()
        Inicio.PanelBaixo.BackColor = CorPanelBaixo.Color
        Inicio.LabelBemVindo.BackColor = CorPanelBaixo.Color
        Inicio.LabelUtilizador.BackColor = CorPanelBaixo.Color
        Inicio.PictureBoxAEE.BackColor = CorPanelBaixo.Color
        Inicio.PictureBoxPOCH.BackColor = CorPanelBaixo.Color
        Inicio.LabelRodape.BackColor = CorPanelBaixo.Color
        Inicio.LabelHora.BackColor = CorPanelBaixo.Color
        Inicio.Labeldoispontos.BackColor = CorPanelBaixo.Color
        Inicio.LabelMin.BackColor = CorPanelBaixo.Color
        Inicio.Labeldoispontos2.BackColor = CorPanelBaixo.Color
        Inicio.LabelSeg.BackColor = CorPanelBaixo.Color
        Inicio.Labelhms.BackColor = CorPanelBaixo.Color
        Inicio.LabelAEE1.BackColor = CorPanelBaixo.Color
        Inicio.LabelAEE2.BackColor = CorPanelBaixo.Color
        Inicio.LabelDate.BackColor = CorPanelBaixo.Color
        Inicio.LabelHour.BackColor = CorPanelBaixo.Color
        Inicio.LabelDataQuestion.BackColor = CorPanelBaixo.Color
        Inicio.LabelHoraQuestion.BackColor = CorPanelBaixo.Color
        My.Settings.CorBaixoSalva = CorPanelBaixo.Color
        My.Settings.Save()
    End Sub

    Private Sub ButtonColorDialogCima_Click(sender As Object, e As EventArgs) Handles ButtonColorDialogCima.Click
        Dim CorPanelCima As New ColorDialog
        CorPanelCima.ShowDialog()
        Inicio.PanelCima.BackColor = CorPanelCima.Color
        Inicio.LabelAdminQuestion.BackColor = CorPanelCima.Color
        Inicio.LabelAdminLevel.BackColor = CorPanelCima.Color
        Inicio.PictureBoxAjuda.BackColor = CorPanelCima.Color
        Inicio.FlatSkinInicio.BackColor = CorPanelCima.Color
        Inicio.LabelFlatSkinInicio.Visible = True
        My.Settings.CorCimaSalva = CorPanelCima.Color
        My.Settings.Save()
    End Sub

    Private Sub ButtonResetBaixo_Click(sender As Object, e As EventArgs) Handles ButtonResetBaixo.Click
        Inicio.PanelBaixo.BackColor = Color.Transparent
        Inicio.LabelBemVindo.BackColor = Color.Transparent
        Inicio.LabelUtilizador.BackColor = Color.Transparent
        Inicio.PictureBoxAEE.BackColor = Color.Transparent
        Inicio.PictureBoxPOCH.BackColor = Color.Transparent
        Inicio.LabelRodape.BackColor = Color.Transparent
        Inicio.LabelHora.BackColor = Color.Transparent
        Inicio.Labeldoispontos.BackColor = Color.Transparent
        Inicio.LabelMin.BackColor = Color.Transparent
        Inicio.Labeldoispontos2.BackColor = Color.Transparent
        Inicio.LabelSeg.BackColor = Color.Transparent
        Inicio.Labelhms.BackColor = Color.Transparent
        Inicio.LabelAEE1.BackColor = Color.Transparent
        Inicio.LabelAEE2.BackColor = Color.Transparent
        Inicio.LabelDate.BackColor = Color.Transparent
        Inicio.LabelHour.BackColor = Color.Transparent
        Inicio.LabelDataQuestion.BackColor = Color.Transparent
        Inicio.LabelHoraQuestion.BackColor = Color.Transparent
        My.Settings.CorBaixoSalva = Color.Transparent
        My.Settings.Save()
    End Sub

    Private Sub ButtonResetCima_Click(sender As Object, e As EventArgs) Handles ButtonResetCima.Click
        Inicio.PanelCima.BackColor = Color.Transparent
        Inicio.LabelAdminQuestion.BackColor = Color.Transparent
        Inicio.LabelAdminLevel.BackColor = Color.Transparent
        Inicio.PictureBoxAjuda.BackColor = Color.Transparent
        Inicio.FlatSkinInicio.BackColor = Color.White
        Inicio.LabelFlatSkinInicio.Visible = False
        My.Settings.CorCimaSalva = Color.Transparent
        My.Settings.Save()
    End Sub

    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub
End Class