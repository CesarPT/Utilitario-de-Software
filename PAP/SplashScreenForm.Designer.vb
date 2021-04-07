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
        Me.LabelTextoSS = New System.Windows.Forms.Label()
        Me.TimerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.LabelSaltar = New System.Windows.Forms.Label()
        Me.Textura = New System.Windows.Forms.PictureBox()
        Me.LabelContagem = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.Logotipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Textura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logotipo
        '
        Me.Logotipo.Image = CType(resources.GetObject("Logotipo.Image"), System.Drawing.Image)
        Me.Logotipo.Location = New System.Drawing.Point(3, 1)
        Me.Logotipo.Name = "Logotipo"
        Me.Logotipo.Size = New System.Drawing.Size(262, 203)
        Me.Logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logotipo.TabIndex = 1
        Me.Logotipo.TabStop = False
        '
        'LabelSplash1
        '
        Me.LabelSplash1.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSplash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSplash1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.LabelSplash1.Location = New System.Drawing.Point(2, 207)
        Me.LabelSplash1.Name = "LabelSplash1"
        Me.LabelSplash1.Size = New System.Drawing.Size(263, 83)
        Me.LabelSplash1.TabIndex = 3
        Me.LabelSplash1.Text = "Suporta sistemas operativos Windows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Criado em Visual Basic e Batch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Terminado em" & _
    " 07/04/2021" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Por César Guimarães Nº3 12ºEI"
        '
        'LabelSplash2
        '
        Me.LabelSplash2.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelSplash2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplash2.Image = CType(resources.GetObject("LabelSplash2.Image"), System.Drawing.Image)
        Me.LabelSplash2.Location = New System.Drawing.Point(265, 1)
        Me.LabelSplash2.Name = "LabelSplash2"
        Me.LabelSplash2.Size = New System.Drawing.Size(262, 30)
        Me.LabelSplash2.TabIndex = 4
        Me.LabelSplash2.Text = "Utilitário de Software"
        Me.LabelSplash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSplash3
        '
        Me.LabelSplash3.BackColor = System.Drawing.Color.Transparent
        Me.LabelSplash3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSplash3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSplash3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSplash3.Image = CType(resources.GetObject("LabelSplash3.Image"), System.Drawing.Image)
        Me.LabelSplash3.Location = New System.Drawing.Point(311, 267)
        Me.LabelSplash3.Name = "LabelSplash3"
        Me.LabelSplash3.Size = New System.Drawing.Size(127, 22)
        Me.LabelSplash3.TabIndex = 5
        Me.LabelSplash3.Text = "A abrir o programa..."
        '
        'LabelTextoSS
        '
        Me.LabelTextoSS.BackColor = System.Drawing.Color.Transparent
        Me.LabelTextoSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTextoSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTextoSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LabelTextoSS.Image = CType(resources.GetObject("LabelTextoSS.Image"), System.Drawing.Image)
        Me.LabelTextoSS.Location = New System.Drawing.Point(265, 92)
        Me.LabelTextoSS.Name = "LabelTextoSS"
        Me.LabelTextoSS.Size = New System.Drawing.Size(262, 112)
        Me.LabelTextoSS.TabIndex = 6
        Me.LabelTextoSS.Text = "- Informações/Diagnóstico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Ferramentas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Downloads" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Outros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Escola (Inform" & _
    "ações)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Aplicação SanDisk Memory Zone"
        Me.LabelTextoSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.LabelSaltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaltar.Image = CType(resources.GetObject("LabelSaltar.Image"), System.Drawing.Image)
        Me.LabelSaltar.Location = New System.Drawing.Point(444, 267)
        Me.LabelSaltar.Name = "LabelSaltar"
        Me.LabelSaltar.Size = New System.Drawing.Size(48, 22)
        Me.LabelSaltar.TabIndex = 8
        Me.LabelSaltar.Text = "Saltar"
        Me.LabelSaltar.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.LabelContagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContagem.Location = New System.Drawing.Point(497, 267)
        Me.LabelContagem.Name = "LabelContagem"
        Me.LabelContagem.Size = New System.Drawing.Size(26, 22)
        Me.LabelContagem.TabIndex = 13
        Me.LabelContagem.Text = "12"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(269, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(439, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(354, 207)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(269, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(439, 37)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(354, 37)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(84, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'SplashScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 293)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelContagem)
        Me.Controls.Add(Me.LabelSaltar)
        Me.Controls.Add(Me.LabelSplash3)
        Me.Controls.Add(Me.LabelTextoSS)
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logotipo As PictureBox
    Friend WithEvents LabelSplash1 As Label
    Friend WithEvents LabelSplash2 As Label
    Friend WithEvents LabelSplash3 As Label
    Friend WithEvents LabelTextoSS As Label
    Friend WithEvents TimerCountDown As Timer
    Friend WithEvents LabelSaltar As Label
    Friend WithEvents Textura As PictureBox
    Friend WithEvents LabelContagem As Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
