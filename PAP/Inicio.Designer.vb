<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.ToolTipControlBox = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerDataHora = New System.Windows.Forms.Timer(Me.components)
        Me.TimerContador = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRodape = New System.Windows.Forms.Timer(Me.components)
        Me.FlatSkinInicio = New PAP.FormSkin()
        Me.PictureBoxAjuda = New System.Windows.Forms.PictureBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.LabelHoraQuestion = New System.Windows.Forms.Label()
        Me.LabelDataQuestion = New System.Windows.Forms.Label()
        Me.LabelAdminLevel = New System.Windows.Forms.Label()
        Me.LabelAdminQuestion = New System.Windows.Forms.Label()
        Me.FlatButtonCreditos = New PAP.FlatButton()
        Me.FlatButtonEstilo = New PAP.FlatButton()
        Me.PictureBoxAEE = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSom = New System.Windows.Forms.PictureBox()
        Me.Labeldoispontos = New System.Windows.Forms.Label()
        Me.Labeldoispontos2 = New System.Windows.Forms.Label()
        Me.Labelhms = New System.Windows.Forms.Label()
        Me.LabelSeg = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelRodape = New System.Windows.Forms.Label()
        Me.LabelBemVindo = New System.Windows.Forms.Label()
        Me.LabelUtilizador = New System.Windows.Forms.Label()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.PictureBoxPOCH = New System.Windows.Forms.PictureBox()
        Me.LabelAEE2 = New System.Windows.Forms.Label()
        Me.LabelAEE1 = New System.Windows.Forms.Label()
        Me.PictureBoxIcone = New System.Windows.Forms.PictureBox()
        Me.FlatFecharTudo = New PAP.FlatClose()
        Me.PanelCima = New System.Windows.Forms.Panel()
        Me.LabelFlatSkinInicio = New System.Windows.Forms.Label()
        Me.PanelBaixo = New System.Windows.Forms.Panel()
        Me.PictureBoxSanDisk = New System.Windows.Forms.PictureBox()
        Me.ButtonSanDisk = New System.Windows.Forms.Button()
        Me.PictureBoxInfo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxRedesSociais = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFerramentas = New System.Windows.Forms.PictureBox()
        Me.PictureBoxOutros = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDownloads = New System.Windows.Forms.PictureBox()
        Me.ButtonFerramentas = New System.Windows.Forms.Button()
        Me.ButtonOutros = New System.Windows.Forms.Button()
        Me.ButtonDownloads = New System.Windows.Forms.Button()
        Me.ButtonEscola = New System.Windows.Forms.Button()
        Me.FlatSkinInicio.SuspendLayout()
        CType(Me.PictureBoxAjuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAEE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPOCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCima.SuspendLayout()
        Me.PanelBaixo.SuspendLayout()
        CType(Me.PictureBoxSanDisk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRedesSociais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFerramentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDownloads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerDataHora
        '
        Me.TimerDataHora.Enabled = True
        Me.TimerDataHora.Interval = 1000
        '
        'TimerContador
        '
        Me.TimerContador.Enabled = True
        Me.TimerContador.Interval = 1000
        '
        'TimerRodape
        '
        Me.TimerRodape.Enabled = True
        Me.TimerRodape.Interval = 1000
        '
        'FlatSkinInicio
        '
        Me.FlatSkinInicio.BackColor = System.Drawing.Color.White
        Me.FlatSkinInicio.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatSkinInicio.BorderColor = System.Drawing.Color.Black
        Me.FlatSkinInicio.Controls.Add(Me.PictureBoxAjuda)
        Me.FlatSkinInicio.Controls.Add(Me.LabelDate)
        Me.FlatSkinInicio.Controls.Add(Me.LabelHour)
        Me.FlatSkinInicio.Controls.Add(Me.LabelHoraQuestion)
        Me.FlatSkinInicio.Controls.Add(Me.LabelDataQuestion)
        Me.FlatSkinInicio.Controls.Add(Me.LabelAdminLevel)
        Me.FlatSkinInicio.Controls.Add(Me.LabelAdminQuestion)
        Me.FlatSkinInicio.Controls.Add(Me.FlatButtonCreditos)
        Me.FlatSkinInicio.Controls.Add(Me.FlatButtonEstilo)
        Me.FlatSkinInicio.Controls.Add(Me.PictureBoxAEE)
        Me.FlatSkinInicio.Controls.Add(Me.PictureBoxSom)
        Me.FlatSkinInicio.Controls.Add(Me.Labeldoispontos)
        Me.FlatSkinInicio.Controls.Add(Me.Labeldoispontos2)
        Me.FlatSkinInicio.Controls.Add(Me.Labelhms)
        Me.FlatSkinInicio.Controls.Add(Me.LabelSeg)
        Me.FlatSkinInicio.Controls.Add(Me.LabelHora)
        Me.FlatSkinInicio.Controls.Add(Me.LabelMin)
        Me.FlatSkinInicio.Controls.Add(Me.LabelRodape)
        Me.FlatSkinInicio.Controls.Add(Me.LabelBemVindo)
        Me.FlatSkinInicio.Controls.Add(Me.LabelUtilizador)
        Me.FlatSkinInicio.Controls.Add(Me.ButtonInfo)
        Me.FlatSkinInicio.Controls.Add(Me.PictureBoxPOCH)
        Me.FlatSkinInicio.Controls.Add(Me.LabelAEE2)
        Me.FlatSkinInicio.Controls.Add(Me.LabelAEE1)
        Me.FlatSkinInicio.Controls.Add(Me.PictureBoxIcone)
        Me.FlatSkinInicio.Controls.Add(Me.FlatFecharTudo)
        Me.FlatSkinInicio.Controls.Add(Me.PanelCima)
        Me.FlatSkinInicio.Controls.Add(Me.PanelBaixo)
        Me.FlatSkinInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatSkinInicio.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatSkinInicio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatSkinInicio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FlatSkinInicio.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatSkinInicio.HeaderMaximize = False
        Me.FlatSkinInicio.Location = New System.Drawing.Point(0, 0)
        Me.FlatSkinInicio.Name = "FlatSkinInicio"
        Me.FlatSkinInicio.Size = New System.Drawing.Size(799, 409)
        Me.FlatSkinInicio.TabIndex = 0
        Me.FlatSkinInicio.Text = "              Aplicação: Utilitário de Software"
        '
        'PictureBoxAjuda
        '
        Me.PictureBoxAjuda.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAjuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.PictureBoxAjuda.Image = CType(resources.GetObject("PictureBoxAjuda.Image"), System.Drawing.Image)
        Me.PictureBoxAjuda.Location = New System.Drawing.Point(733, 11)
        Me.PictureBoxAjuda.Name = "PictureBoxAjuda"
        Me.PictureBoxAjuda.Size = New System.Drawing.Size(27, 26)
        Me.PictureBoxAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAjuda.TabIndex = 111
        Me.PictureBoxAjuda.TabStop = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LabelDate.Location = New System.Drawing.Point(479, 57)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(66, 21)
        Me.LabelDate.TabIndex = 110
        Me.LabelDate.Text = "%data%"
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.BackColor = System.Drawing.Color.Transparent
        Me.LabelHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LabelHour.Location = New System.Drawing.Point(481, 78)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(68, 21)
        Me.LabelHour.TabIndex = 109
        Me.LabelHour.Text = "%hora%"
        '
        'LabelHoraQuestion
        '
        Me.LabelHoraQuestion.AutoSize = True
        Me.LabelHoraQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelHoraQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LabelHoraQuestion.Location = New System.Drawing.Point(440, 78)
        Me.LabelHoraQuestion.Name = "LabelHoraQuestion"
        Me.LabelHoraQuestion.Size = New System.Drawing.Size(47, 21)
        Me.LabelHoraQuestion.TabIndex = 108
        Me.LabelHoraQuestion.Text = "Hora:"
        '
        'LabelDataQuestion
        '
        Me.LabelDataQuestion.AutoSize = True
        Me.LabelDataQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LabelDataQuestion.Location = New System.Drawing.Point(440, 57)
        Me.LabelDataQuestion.Name = "LabelDataQuestion"
        Me.LabelDataQuestion.Size = New System.Drawing.Size(45, 21)
        Me.LabelDataQuestion.TabIndex = 106
        Me.LabelDataQuestion.Text = "Data:"
        '
        'LabelAdminLevel
        '
        Me.LabelAdminLevel.AutoSize = True
        Me.LabelAdminLevel.BackColor = System.Drawing.Color.Transparent
        Me.LabelAdminLevel.Location = New System.Drawing.Point(379, 15)
        Me.LabelAdminLevel.Name = "LabelAdminLevel"
        Me.LabelAdminLevel.Size = New System.Drawing.Size(57, 21)
        Me.LabelAdminLevel.TabIndex = 105
        Me.LabelAdminLevel.Text = "%res%"
        '
        'LabelAdminQuestion
        '
        Me.LabelAdminQuestion.AutoSize = True
        Me.LabelAdminQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelAdminQuestion.Location = New System.Drawing.Point(324, 15)
        Me.LabelAdminQuestion.Name = "LabelAdminQuestion"
        Me.LabelAdminQuestion.Size = New System.Drawing.Size(59, 21)
        Me.LabelAdminQuestion.TabIndex = 104
        Me.LabelAdminQuestion.Text = "Admin:"
        '
        'FlatButtonCreditos
        '
        Me.FlatButtonCreditos.BackColor = System.Drawing.Color.Transparent
        Me.FlatButtonCreditos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButtonCreditos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButtonCreditos.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButtonCreditos.Location = New System.Drawing.Point(629, 10)
        Me.FlatButtonCreditos.Name = "FlatButtonCreditos"
        Me.FlatButtonCreditos.Rounded = False
        Me.FlatButtonCreditos.Size = New System.Drawing.Size(84, 32)
        Me.FlatButtonCreditos.TabIndex = 103
        Me.FlatButtonCreditos.Text = "Créditos"
        Me.FlatButtonCreditos.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButtonEstilo
        '
        Me.FlatButtonEstilo.BackColor = System.Drawing.Color.Transparent
        Me.FlatButtonEstilo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButtonEstilo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButtonEstilo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButtonEstilo.Location = New System.Drawing.Point(450, 10)
        Me.FlatButtonEstilo.Name = "FlatButtonEstilo"
        Me.FlatButtonEstilo.Rounded = False
        Me.FlatButtonEstilo.Size = New System.Drawing.Size(170, 32)
        Me.FlatButtonEstilo.TabIndex = 102
        Me.FlatButtonEstilo.Text = "Estilo de letras e cores"
        Me.FlatButtonEstilo.TextColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        '
        'PictureBoxAEE
        '
        Me.PictureBoxAEE.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAEE.Image = CType(resources.GetObject("PictureBoxAEE.Image"), System.Drawing.Image)
        Me.PictureBoxAEE.Location = New System.Drawing.Point(0, 53)
        Me.PictureBoxAEE.Name = "PictureBoxAEE"
        Me.PictureBoxAEE.Size = New System.Drawing.Size(81, 50)
        Me.PictureBoxAEE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAEE.TabIndex = 101
        Me.PictureBoxAEE.TabStop = False
        '
        'PictureBoxSom
        '
        Me.PictureBoxSom.BackColor = System.Drawing.Color.Gray
        Me.PictureBoxSom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSom.Image = CType(resources.GetObject("PictureBoxSom.Image"), System.Drawing.Image)
        Me.PictureBoxSom.Location = New System.Drawing.Point(3, 351)
        Me.PictureBoxSom.Name = "PictureBoxSom"
        Me.PictureBoxSom.Size = New System.Drawing.Size(52, 55)
        Me.PictureBoxSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSom.TabIndex = 100
        Me.PictureBoxSom.TabStop = False
        '
        'Labeldoispontos
        '
        Me.Labeldoispontos.AutoSize = True
        Me.Labeldoispontos.BackColor = System.Drawing.Color.Transparent
        Me.Labeldoispontos.Location = New System.Drawing.Point(382, 371)
        Me.Labeldoispontos.Name = "Labeldoispontos"
        Me.Labeldoispontos.Size = New System.Drawing.Size(13, 21)
        Me.Labeldoispontos.TabIndex = 99
        Me.Labeldoispontos.Text = ":"
        '
        'Labeldoispontos2
        '
        Me.Labeldoispontos2.AutoSize = True
        Me.Labeldoispontos2.BackColor = System.Drawing.Color.Transparent
        Me.Labeldoispontos2.Location = New System.Drawing.Point(417, 371)
        Me.Labeldoispontos2.Name = "Labeldoispontos2"
        Me.Labeldoispontos2.Size = New System.Drawing.Size(13, 21)
        Me.Labeldoispontos2.TabIndex = 98
        Me.Labeldoispontos2.Text = ":"
        '
        'Labelhms
        '
        Me.Labelhms.AutoSize = True
        Me.Labelhms.BackColor = System.Drawing.Color.Transparent
        Me.Labelhms.Location = New System.Drawing.Point(383, 390)
        Me.Labelhms.Name = "Labelhms"
        Me.Labelhms.Size = New System.Drawing.Size(46, 21)
        Me.Labelhms.TabIndex = 97
        Me.Labelhms.Text = "h:m:s"
        '
        'LabelSeg
        '
        Me.LabelSeg.AutoSize = True
        Me.LabelSeg.BackColor = System.Drawing.Color.Transparent
        Me.LabelSeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeg.Location = New System.Drawing.Point(429, 374)
        Me.LabelSeg.Name = "LabelSeg"
        Me.LabelSeg.Size = New System.Drawing.Size(24, 18)
        Me.LabelSeg.TabIndex = 96
        Me.LabelSeg.Text = "00"
        Me.LabelSeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.BackColor = System.Drawing.Color.Transparent
        Me.LabelHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(358, 374)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(24, 18)
        Me.LabelHora.TabIndex = 95
        Me.LabelHora.Text = "00"
        Me.LabelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.BackColor = System.Drawing.Color.Transparent
        Me.LabelMin.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMin.Location = New System.Drawing.Point(394, 374)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(24, 18)
        Me.LabelMin.TabIndex = 94
        Me.LabelMin.Text = "00"
        Me.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRodape
        '
        Me.LabelRodape.AutoSize = True
        Me.LabelRodape.BackColor = System.Drawing.Color.Transparent
        Me.LabelRodape.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRodape.Location = New System.Drawing.Point(670, 351)
        Me.LabelRodape.Name = "LabelRodape"
        Me.LabelRodape.Size = New System.Drawing.Size(117, 22)
        Me.LabelRodape.TabIndex = 93
        Me.LabelRodape.Text = "LabelRodape"
        '
        'LabelBemVindo
        '
        Me.LabelBemVindo.BackColor = System.Drawing.Color.Transparent
        Me.LabelBemVindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBemVindo.Image = CType(resources.GetObject("LabelBemVindo.Image"), System.Drawing.Image)
        Me.LabelBemVindo.Location = New System.Drawing.Point(174, 126)
        Me.LabelBemVindo.Name = "LabelBemVindo"
        Me.LabelBemVindo.Size = New System.Drawing.Size(149, 31)
        Me.LabelBemVindo.TabIndex = 85
        Me.LabelBemVindo.Text = "Bem vindo:"
        '
        'LabelUtilizador
        '
        Me.LabelUtilizador.AutoSize = True
        Me.LabelUtilizador.BackColor = System.Drawing.Color.Transparent
        Me.LabelUtilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUtilizador.Image = CType(resources.GetObject("LabelUtilizador.Image"), System.Drawing.Image)
        Me.LabelUtilizador.Location = New System.Drawing.Point(326, 126)
        Me.LabelUtilizador.Name = "LabelUtilizador"
        Me.LabelUtilizador.Size = New System.Drawing.Size(171, 31)
        Me.LabelUtilizador.TabIndex = 84
        Me.LabelUtilizador.Text = "%utilizador%"
        '
        'ButtonInfo
        '
        Me.ButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInfo.Location = New System.Drawing.Point(125, 188)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(144, 71)
        Me.ButtonInfo.TabIndex = 80
        Me.ButtonInfo.Text = "Informações e Diagnóstico"
        Me.ButtonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInfo.UseVisualStyleBackColor = False
        '
        'PictureBoxPOCH
        '
        Me.PictureBoxPOCH.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPOCH.Image = CType(resources.GetObject("PictureBoxPOCH.Image"), System.Drawing.Image)
        Me.PictureBoxPOCH.Location = New System.Drawing.Point(582, 53)
        Me.PictureBoxPOCH.Name = "PictureBoxPOCH"
        Me.PictureBoxPOCH.Size = New System.Drawing.Size(214, 50)
        Me.PictureBoxPOCH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPOCH.TabIndex = 60
        Me.PictureBoxPOCH.TabStop = False
        '
        'LabelAEE2
        '
        Me.LabelAEE2.AutoSize = True
        Me.LabelAEE2.BackColor = System.Drawing.Color.Transparent
        Me.LabelAEE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAEE2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAEE2.Location = New System.Drawing.Point(89, 81)
        Me.LabelAEE2.Name = "LabelAEE2"
        Me.LabelAEE2.Size = New System.Drawing.Size(283, 18)
        Me.LabelAEE2.TabIndex = 58
        Me.LabelAEE2.Text = "Escola EB2/3 e Secundária de Ermesinde"
        '
        'LabelAEE1
        '
        Me.LabelAEE1.AutoSize = True
        Me.LabelAEE1.BackColor = System.Drawing.Color.Transparent
        Me.LabelAEE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAEE1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAEE1.Location = New System.Drawing.Point(88, 57)
        Me.LabelAEE1.Name = "LabelAEE1"
        Me.LabelAEE1.Size = New System.Drawing.Size(325, 22)
        Me.LabelAEE1.TabIndex = 57
        Me.LabelAEE1.Text = "Agrupamento de Escolas de Ermesinde"
        '
        'PictureBoxIcone
        '
        Me.PictureBoxIcone.Image = CType(resources.GetObject("PictureBoxIcone.Image"), System.Drawing.Image)
        Me.PictureBoxIcone.Location = New System.Drawing.Point(27, 3)
        Me.PictureBoxIcone.Name = "PictureBoxIcone"
        Me.PictureBoxIcone.Size = New System.Drawing.Size(54, 45)
        Me.PictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIcone.TabIndex = 2
        Me.PictureBoxIcone.TabStop = False
        '
        'FlatFecharTudo
        '
        Me.FlatFecharTudo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatFecharTudo.BackColor = System.Drawing.Color.White
        Me.FlatFecharTudo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatFecharTudo.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatFecharTudo.Location = New System.Drawing.Point(769, 17)
        Me.FlatFecharTudo.Name = "FlatFecharTudo"
        Me.FlatFecharTudo.Size = New System.Drawing.Size(18, 18)
        Me.FlatFecharTudo.TabIndex = 1
        Me.FlatFecharTudo.Text = "FlatFecharTudo"
        Me.FlatFecharTudo.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PanelCima
        '
        Me.PanelCima.BackColor = System.Drawing.Color.Transparent
        Me.PanelCima.Controls.Add(Me.LabelFlatSkinInicio)
        Me.PanelCima.Location = New System.Drawing.Point(-1, -1)
        Me.PanelCima.Name = "PanelCima"
        Me.PanelCima.Size = New System.Drawing.Size(799, 51)
        Me.PanelCima.TabIndex = 113
        '
        'LabelFlatSkinInicio
        '
        Me.LabelFlatSkinInicio.AutoSize = True
        Me.LabelFlatSkinInicio.ForeColor = System.Drawing.Color.White
        Me.LabelFlatSkinInicio.Location = New System.Drawing.Point(89, 16)
        Me.LabelFlatSkinInicio.Name = "LabelFlatSkinInicio"
        Me.LabelFlatSkinInicio.Size = New System.Drawing.Size(230, 21)
        Me.LabelFlatSkinInicio.TabIndex = 0
        Me.LabelFlatSkinInicio.Text = "Aplicação: Utilitário de Software"
        Me.LabelFlatSkinInicio.Visible = False
        '
        'PanelBaixo
        '
        Me.PanelBaixo.BackColor = System.Drawing.Color.Transparent
        Me.PanelBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelBaixo.Controls.Add(Me.PictureBoxSanDisk)
        Me.PanelBaixo.Controls.Add(Me.ButtonSanDisk)
        Me.PanelBaixo.Controls.Add(Me.PictureBoxInfo)
        Me.PanelBaixo.Controls.Add(Me.PictureBoxRedesSociais)
        Me.PanelBaixo.Controls.Add(Me.PictureBoxFerramentas)
        Me.PanelBaixo.Controls.Add(Me.PictureBoxOutros)
        Me.PanelBaixo.Controls.Add(Me.PictureBoxDownloads)
        Me.PanelBaixo.Controls.Add(Me.ButtonFerramentas)
        Me.PanelBaixo.Controls.Add(Me.ButtonOutros)
        Me.PanelBaixo.Controls.Add(Me.ButtonDownloads)
        Me.PanelBaixo.Controls.Add(Me.ButtonEscola)
        Me.PanelBaixo.Location = New System.Drawing.Point(0, 48)
        Me.PanelBaixo.Name = "PanelBaixo"
        Me.PanelBaixo.Size = New System.Drawing.Size(799, 361)
        Me.PanelBaixo.TabIndex = 112
        '
        'PictureBoxSanDisk
        '
        Me.PictureBoxSanDisk.BackgroundImage = CType(resources.GetObject("PictureBoxSanDisk.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSanDisk.Image = CType(resources.GetObject("PictureBoxSanDisk.Image"), System.Drawing.Image)
        Me.PictureBoxSanDisk.Location = New System.Drawing.Point(530, 217)
        Me.PictureBoxSanDisk.Name = "PictureBoxSanDisk"
        Me.PictureBoxSanDisk.Size = New System.Drawing.Size(82, 71)
        Me.PictureBoxSanDisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSanDisk.TabIndex = 94
        Me.PictureBoxSanDisk.TabStop = False
        '
        'ButtonSanDisk
        '
        Me.ButtonSanDisk.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonSanDisk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSanDisk.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.ButtonSanDisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonSanDisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.ButtonSanDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSanDisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSanDisk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSanDisk.Location = New System.Drawing.Point(612, 217)
        Me.ButtonSanDisk.Name = "ButtonSanDisk"
        Me.ButtonSanDisk.Size = New System.Drawing.Size(143, 71)
        Me.ButtonSanDisk.TabIndex = 93
        Me.ButtonSanDisk.Text = "SanDisk Memory Zone"
        Me.ButtonSanDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSanDisk.UseVisualStyleBackColor = False
        '
        'PictureBoxInfo
        '
        Me.PictureBoxInfo.BackgroundImage = CType(resources.GetObject("PictureBoxInfo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxInfo.Image = CType(resources.GetObject("PictureBoxInfo.Image"), System.Drawing.Image)
        Me.PictureBoxInfo.Location = New System.Drawing.Point(43, 140)
        Me.PictureBoxInfo.Name = "PictureBoxInfo"
        Me.PictureBoxInfo.Size = New System.Drawing.Size(82, 71)
        Me.PictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxInfo.TabIndex = 91
        Me.PictureBoxInfo.TabStop = False
        '
        'PictureBoxRedesSociais
        '
        Me.PictureBoxRedesSociais.BackgroundImage = CType(resources.GetObject("PictureBoxRedesSociais.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxRedesSociais.Image = CType(resources.GetObject("PictureBoxRedesSociais.Image"), System.Drawing.Image)
        Me.PictureBoxRedesSociais.Location = New System.Drawing.Point(285, 216)
        Me.PictureBoxRedesSociais.Name = "PictureBoxRedesSociais"
        Me.PictureBoxRedesSociais.Size = New System.Drawing.Size(84, 71)
        Me.PictureBoxRedesSociais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRedesSociais.TabIndex = 87
        Me.PictureBoxRedesSociais.TabStop = False
        '
        'PictureBoxFerramentas
        '
        Me.PictureBoxFerramentas.BackgroundImage = CType(resources.GetObject("PictureBoxFerramentas.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxFerramentas.Image = CType(resources.GetObject("PictureBoxFerramentas.Image"), System.Drawing.Image)
        Me.PictureBoxFerramentas.Location = New System.Drawing.Point(287, 139)
        Me.PictureBoxFerramentas.Name = "PictureBoxFerramentas"
        Me.PictureBoxFerramentas.Size = New System.Drawing.Size(82, 71)
        Me.PictureBoxFerramentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFerramentas.TabIndex = 88
        Me.PictureBoxFerramentas.TabStop = False
        '
        'PictureBoxOutros
        '
        Me.PictureBoxOutros.Image = CType(resources.GetObject("PictureBoxOutros.Image"), System.Drawing.Image)
        Me.PictureBoxOutros.Location = New System.Drawing.Point(43, 217)
        Me.PictureBoxOutros.Name = "PictureBoxOutros"
        Me.PictureBoxOutros.Size = New System.Drawing.Size(82, 71)
        Me.PictureBoxOutros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxOutros.TabIndex = 89
        Me.PictureBoxOutros.TabStop = False
        '
        'PictureBoxDownloads
        '
        Me.PictureBoxDownloads.BackgroundImage = CType(resources.GetObject("PictureBoxDownloads.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDownloads.Image = CType(resources.GetObject("PictureBoxDownloads.Image"), System.Drawing.Image)
        Me.PictureBoxDownloads.Location = New System.Drawing.Point(530, 140)
        Me.PictureBoxDownloads.Name = "PictureBoxDownloads"
        Me.PictureBoxDownloads.Size = New System.Drawing.Size(82, 71)
        Me.PictureBoxDownloads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxDownloads.TabIndex = 90
        Me.PictureBoxDownloads.TabStop = False
        '
        'ButtonFerramentas
        '
        Me.ButtonFerramentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonFerramentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFerramentas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonFerramentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFerramentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFerramentas.Location = New System.Drawing.Point(369, 139)
        Me.ButtonFerramentas.Name = "ButtonFerramentas"
        Me.ButtonFerramentas.Size = New System.Drawing.Size(144, 70)
        Me.ButtonFerramentas.TabIndex = 81
        Me.ButtonFerramentas.Text = "Ferramentas"
        Me.ButtonFerramentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFerramentas.UseVisualStyleBackColor = False
        '
        'ButtonOutros
        '
        Me.ButtonOutros.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonOutros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOutros.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonOutros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonOutros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOutros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOutros.Location = New System.Drawing.Point(125, 217)
        Me.ButtonOutros.Name = "ButtonOutros"
        Me.ButtonOutros.Size = New System.Drawing.Size(144, 71)
        Me.ButtonOutros.TabIndex = 79
        Me.ButtonOutros.Text = "Outros"
        Me.ButtonOutros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOutros.UseVisualStyleBackColor = False
        '
        'ButtonDownloads
        '
        Me.ButtonDownloads.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonDownloads.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDownloads.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonDownloads.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDownloads.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDownloads.Location = New System.Drawing.Point(612, 140)
        Me.ButtonDownloads.Name = "ButtonDownloads"
        Me.ButtonDownloads.Size = New System.Drawing.Size(143, 70)
        Me.ButtonDownloads.TabIndex = 82
        Me.ButtonDownloads.Text = "Downloads"
        Me.ButtonDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDownloads.UseVisualStyleBackColor = False
        '
        'ButtonEscola
        '
        Me.ButtonEscola.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonEscola.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEscola.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonEscola.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan
        Me.ButtonEscola.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEscola.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEscola.Location = New System.Drawing.Point(369, 216)
        Me.ButtonEscola.Name = "ButtonEscola"
        Me.ButtonEscola.Size = New System.Drawing.Size(143, 71)
        Me.ButtonEscola.TabIndex = 86
        Me.ButtonEscola.Text = "Escola"
        Me.ButtonEscola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEscola.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 409)
        Me.Controls.Add(Me.FlatSkinInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação: Utilitário de Software"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FlatSkinInicio.ResumeLayout(False)
        Me.FlatSkinInicio.PerformLayout()
        CType(Me.PictureBoxAjuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAEE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPOCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCima.ResumeLayout(False)
        Me.PanelCima.PerformLayout()
        Me.PanelBaixo.ResumeLayout(False)
        CType(Me.PictureBoxSanDisk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRedesSociais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFerramentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOutros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDownloads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatFecharTudo As FlatClose
    Friend WithEvents PictureBoxIcone As PictureBox
    Friend WithEvents FlatSkinInicio As FormSkin
    Friend WithEvents PictureBoxPOCH As PictureBox
    Friend WithEvents LabelAEE2 As Label
    Friend WithEvents LabelAEE1 As Label
    Friend WithEvents PictureBoxInfo As PictureBox
    Friend WithEvents PictureBoxDownloads As PictureBox
    Friend WithEvents PictureBoxOutros As PictureBox
    Friend WithEvents PictureBoxFerramentas As PictureBox
    Friend WithEvents PictureBoxRedesSociais As PictureBox
    Friend WithEvents LabelBemVindo As Label
    Friend WithEvents LabelUtilizador As Label
    Friend WithEvents PictureBoxSom As PictureBox
    Friend WithEvents Labeldoispontos As Label
    Friend WithEvents Labeldoispontos2 As Label
    Friend WithEvents Labelhms As Label
    Friend WithEvents LabelSeg As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelMin As Label
    Friend WithEvents LabelRodape As Label
    Friend WithEvents PictureBoxAEE As PictureBox
    Friend WithEvents ToolTipControlBox As ToolTip
    Friend WithEvents TimerDataHora As Timer
    Friend WithEvents TimerContador As Timer
    Friend WithEvents TimerRodape As Timer
    Friend WithEvents FlatButtonEstilo As FlatButton
    Friend WithEvents FlatButtonCreditos As FlatButton
    Friend WithEvents LabelAdminLevel As Label
    Friend WithEvents LabelAdminQuestion As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelHour As Label
    Friend WithEvents LabelHoraQuestion As Label
    Friend WithEvents LabelDataQuestion As Label
    Friend WithEvents PictureBoxAjuda As PictureBox
    Friend WithEvents PanelBaixo As Panel
    Friend WithEvents PanelCima As Panel
    Friend WithEvents LabelFlatSkinInicio As Label
    Friend WithEvents ButtonInfo As Button
    Friend WithEvents ButtonSanDisk As Button
    Friend WithEvents ButtonFerramentas As Button
    Friend WithEvents ButtonOutros As Button
    Friend WithEvents ButtonDownloads As Button
    Friend WithEvents ButtonEscola As Button
    Friend WithEvents PictureBoxSanDisk As PictureBox
End Class
