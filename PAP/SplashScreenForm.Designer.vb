<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenForm))
        Me.Logotipo = New System.Windows.Forms.PictureBox()
        Me.LabelSplash1 = New System.Windows.Forms.Label()
        Me.LabelSplash2 = New System.Windows.Forms.Label()
        Me.LabelSplash3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.LabelSaltar = New System.Windows.Forms.Label()
        Me.LabelSplashScreen = New System.Windows.Forms.Label()
        Me.Textura = New System.Windows.Forms.PictureBox()
        Me.LabelContagem = New System.Windows.Forms.Label()
        CType(Me.Logotipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Textura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logotipo
        '
        Me.Logotipo.Image = CType(resources.GetObject("Logotipo.Image"), System.Drawing.Image)
        Me.Logotipo.Location = New System.Drawing.Point(1, 1)
        Me.Logotipo.Name = "Logotipo"
        Me.Logotipo.Size = New System.Drawing.Size(264, 214)
        Me.Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logotipo.TabIndex = 1
        Me.Logotipo.TabStop = False
        '
        'LabelSplash1
        '
        Me.LabelSplash1.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSplash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSplash1.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplash1.Location = New System.Drawing.Point(1, 218)
        Me.LabelSplash1.Name = "LabelSplash1"
        Me.LabelSplash1.Size = New System.Drawing.Size(262, 67)
        Me.LabelSplash1.TabIndex = 3
        Me.LabelSplash1.Text = "Suporta sistemas operativos Windows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criado em Visual Basic e Batch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Terminado em" &
    " --/--/2021" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por César Guimarães Nº3 12ºEI"
        '
        'LabelSplash2
        '
        Me.LabelSplash2.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSplash2.Font = New System.Drawing.Font("OCR A Extended", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplash2.Image = CType(resources.GetObject("LabelSplash2.Image"), System.Drawing.Image)
        Me.LabelSplash2.Location = New System.Drawing.Point(265, 1)
        Me.LabelSplash2.Name = "LabelSplash2"
        Me.LabelSplash2.Size = New System.Drawing.Size(262, 51)
        Me.LabelSplash2.TabIndex = 4
        Me.LabelSplash2.Text = "Utilitário de Software"
        '
        'LabelSplash3
        '
        Me.LabelSplash3.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSplash3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSplash3.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplash3.Image = CType(resources.GetObject("LabelSplash3.Image"), System.Drawing.Image)
        Me.LabelSplash3.Location = New System.Drawing.Point(355, 241)
        Me.LabelSplash3.Name = "LabelSplash3"
        Me.LabelSplash3.Size = New System.Drawing.Size(170, 20)
        Me.LabelSplash3.TabIndex = 5
        Me.LabelSplash3.Text = "A abrir o programa..."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(265, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 143)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "- Informações/Diagnóstico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Ferramentas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Downloads" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Soluções" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Outros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Es" &
    "cola (Informações)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Aplicação SanDisk Memory Zone"
        '
        'TimerCountDown
        '
        Me.TimerCountDown.Enabled = True
        Me.TimerCountDown.Interval = 1000
        '
        'LabelSaltar
        '
        Me.LabelSaltar.BackColor = System.Drawing.Color.Transparent
        Me.LabelSaltar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSaltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelSaltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSaltar.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaltar.Image = CType(resources.GetObject("LabelSaltar.Image"), System.Drawing.Image)
        Me.LabelSaltar.Location = New System.Drawing.Point(355, 265)
        Me.LabelSaltar.Name = "LabelSaltar"
        Me.LabelSaltar.Size = New System.Drawing.Size(54, 20)
        Me.LabelSaltar.TabIndex = 8
        Me.LabelSaltar.Text = "Saltar"
        '
        'LabelSplashScreen
        '
        Me.LabelSplashScreen.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplashScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSplashScreen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelSplashScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSplashScreen.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplashScreen.Location = New System.Drawing.Point(415, 265)
        Me.LabelSplashScreen.Name = "LabelSplashScreen"
        Me.LabelSplashScreen.Size = New System.Drawing.Size(82, 20)
        Me.LabelSplashScreen.TabIndex = 12
        Me.LabelSplashScreen.Text = "A carregar"
        '
        'Textura
        '
        Me.Textura.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Textura.Image = CType(resources.GetObject("Textura.Image"), System.Drawing.Image)
        Me.Textura.Location = New System.Drawing.Point(1, 1)
        Me.Textura.Name = "Textura"
        Me.Textura.Size = New System.Drawing.Size(526, 291)
        Me.Textura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Textura.TabIndex = 0
        Me.Textura.TabStop = False
        '
        'LabelContagem
        '
        Me.LabelContagem.BackColor = System.Drawing.Color.Transparent
        Me.LabelContagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelContagem.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LabelContagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelContagem.Font = New System.Drawing.Font("OCR A Extended", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContagem.Location = New System.Drawing.Point(496, 265)
        Me.LabelContagem.Name = "LabelContagem"
        Me.LabelContagem.Size = New System.Drawing.Size(31, 20)
        Me.LabelContagem.TabIndex = 13
        Me.LabelContagem.Text = "12"
        '
        'SplashScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelContagem)
        Me.Controls.Add(Me.LabelSplashScreen)
        Me.Controls.Add(Me.LabelSaltar)
        Me.Controls.Add(Me.LabelSplash3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelSplash2)
        Me.Controls.Add(Me.LabelSplash1)
        Me.Controls.Add(Me.Logotipo)
        Me.Controls.Add(Me.Textura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreenForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bem vindo Utilitario de Software"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.Logotipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Textura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logotipo As PictureBox
    Friend WithEvents LabelSplash1 As Label
    Friend WithEvents LabelSplash2 As Label
    Friend WithEvents LabelSplash3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerCountDown As Timer
    Friend WithEvents LabelSaltar As Label
    Friend WithEvents LabelSplashScreen As Label
    Friend WithEvents Textura As PictureBox
    Friend WithEvents LabelContagem As Label
End Class
