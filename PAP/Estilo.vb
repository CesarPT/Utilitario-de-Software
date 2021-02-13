Public Class Estilo
    Dim FontCollection As New System.Drawing.Text.InstalledFontCollection 'Fontes instaladas na máquina
    Private Sub ComboBoxLetra_DrawItem(send As Object, e As DrawItemEventArgs)
        'Colocar negrito, itálico... nos tipos de letras no combobox
        Dim fn As New Font(FontCollection.Families(e.Index), 10)
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
        Inicio.ButtonInfo.Font = New Font(ComboBoxLetra.Text, 12)
        Inicio.ButtonFerramentas.Font = New Font(ComboBoxLetra.Text, 12)
        Inicio.ButtonDownloads.Font = New Font(ComboBoxLetra.Text, 12)
        Inicio.ButtonOutros.Font = New Font(ComboBoxLetra.Text, 12)
        Inicio.ButtonEscola.Font = New Font(ComboBoxLetra.Text, 12)
    End Sub

    Private Sub ButtonResetLetra_Click(sender As Object, e As EventArgs) Handles ButtonResetLetra.Click
        Inicio.ButtonInfo.Font = New Font("Microsoft Sans Serif", 12)
        Inicio.ButtonFerramentas.Font = New Font("Microsoft Sans Serif", 12)
        Inicio.ButtonDownloads.Font = New Font("Microsoft Sans Serif", 12)
        Inicio.ButtonOutros.Font = New Font("Microsoft Sans Serif", 12)
        Inicio.ButtonEscola.Font = New Font("Microsoft Sans Serif", 12)
    End Sub

    Private Sub ButtonColorDialogBaixo_Click(sender As Object, e As EventArgs) Handles ButtonColorDialogBaixo.Click
        'As variáveis coresbaixo e corescima fecham o ColorDialog ao clicar em OK.
        Dim coresbaixo As DialogResult
        coresbaixo = ColorDialogBaixo.ShowDialog()
        If coresbaixo = Windows.Forms.DialogResult.OK Then
            Inicio.PanelBaixo.BackColor = ColorDialogBaixo.Color
            Inicio.LabelBemVindo.BackColor = ColorDialogBaixo.Color
            Inicio.LabelUtilizador.BackColor = ColorDialogBaixo.Color
            Inicio.PictureBoxAEE.BackColor = ColorDialogBaixo.Color
            Inicio.PictureBoxPOCH.BackColor = ColorDialogBaixo.Color
            Inicio.LabelRodape.BackColor = ColorDialogBaixo.Color
            Inicio.LabelHora.BackColor = ColorDialogBaixo.Color
            Inicio.Labeldoispontos.BackColor = ColorDialogBaixo.Color
            Inicio.LabelMin.BackColor = ColorDialogBaixo.Color
            Inicio.Labeldoispontos2.BackColor = ColorDialogBaixo.Color
            Inicio.LabelSeg.BackColor = ColorDialogBaixo.Color
            Inicio.Labelhms.BackColor = ColorDialogBaixo.Color
            Inicio.LabelAEE1.BackColor = ColorDialogBaixo.Color
            Inicio.LabelAEE2.BackColor = ColorDialogBaixo.Color
            Inicio.LabelDate.BackColor = ColorDialogBaixo.Color
            Inicio.LabelHour.BackColor = ColorDialogBaixo.Color
            Inicio.LabelDataQuestion.BackColor = ColorDialogBaixo.Color
            Inicio.LabelHoraQuestion.BackColor = ColorDialogBaixo.Color
        End If
    End Sub

    Private Sub ButtonColorDialogCima_Click(sender As Object, e As EventArgs) Handles ButtonColorDialogCima.Click
        Dim corescima As DialogResult
        corescima = ColorDialogCima.ShowDialog()
        If corescima = Windows.Forms.DialogResult.OK Then
            Inicio.PanelCima.BackColor = ColorDialogCima.Color
            Inicio.LabelAdminQuestion.BackColor = ColorDialogCima.Color
            Inicio.LabelAdminLevel.BackColor = ColorDialogCima.Color
            Inicio.PictureBoxAjuda.BackColor = ColorDialogBaixo.Color
            Inicio.FlatSkinInicio.BackColor = ColorDialogBaixo.Color
            Inicio.LabelFlatSkinInicio.Visible = True
        End If
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
    End Sub

    Private Sub ButtonResetCima_Click(sender As Object, e As EventArgs) Handles ButtonResetCima.Click
        Inicio.PanelCima.BackColor = Color.Transparent
        Inicio.LabelAdminQuestion.BackColor = Color.Transparent
        Inicio.LabelAdminLevel.BackColor = Color.Transparent
        Inicio.PictureBoxAjuda.BackColor = Color.Transparent
        Inicio.FlatSkinInicio.BackColor = Color.White
        Inicio.LabelFlatSkinInicio.Visible = False
    End Sub

    Private Sub PictureBoxFechar_Click(sender As Object, e As EventArgs) Handles PictureBoxFechar.Click
        Me.Close()
    End Sub
End Class