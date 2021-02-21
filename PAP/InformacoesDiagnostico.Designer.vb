<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacoesDiagnostico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacoesDiagnostico))
        Me.FormSkinInfo = New PAP.FormSkin()
        Me.LabelAr = New System.Windows.Forms.Label()
        Me.LabelArqui = New System.Windows.Forms.Label()
        Me.PictureBoxIcone = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFechar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSystemInfo = New System.Windows.Forms.Button()
        Me.ButtonIPConfigAll = New System.Windows.Forms.Button()
        Me.PictureBoxPrompt = New System.Windows.Forms.PictureBox()
        Me.ButtonIPConfig = New System.Windows.Forms.Button()
        Me.LabelInfo1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxCPUZ = New System.Windows.Forms.PictureBox()
        Me.PictureBoxHWINFO = New System.Windows.Forms.PictureBox()
        Me.LabelInfo2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelManual = New System.Windows.Forms.Label()
        Me.LabelFab = New System.Windows.Forms.Label()
        Me.LabelSens = New System.Windows.Forms.Label()
        Me.PictureBoxMini = New System.Windows.Forms.PictureBox()
        Me.FormSkinInfo.SuspendLayout()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxPrompt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxCPUZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHWINFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkinInfo
        '
        Me.FormSkinInfo.BackColor = System.Drawing.Color.White
        Me.FormSkinInfo.BaseColor = System.Drawing.SystemColors.Control
        Me.FormSkinInfo.BorderColor = System.Drawing.Color.Black
        Me.FormSkinInfo.Controls.Add(Me.PictureBoxMini)
        Me.FormSkinInfo.Controls.Add(Me.LabelAr)
        Me.FormSkinInfo.Controls.Add(Me.LabelArqui)
        Me.FormSkinInfo.Controls.Add(Me.PictureBoxIcone)
        Me.FormSkinInfo.Controls.Add(Me.PictureBoxFechar)
        Me.FormSkinInfo.Controls.Add(Me.Panel1)
        Me.FormSkinInfo.Controls.Add(Me.Panel2)
        Me.FormSkinInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkinInfo.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkinInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkinInfo.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkinInfo.HeaderMaximize = False
        Me.FormSkinInfo.Location = New System.Drawing.Point(0, 0)
        Me.FormSkinInfo.Name = "FormSkinInfo"
        Me.FormSkinInfo.Size = New System.Drawing.Size(602, 348)
        Me.FormSkinInfo.TabIndex = 0
        Me.FormSkinInfo.Text = "              Informações e Diagnóstico do Sistema"
        '
        'LabelAr
        '
        Me.LabelAr.AutoSize = True
        Me.LabelAr.Location = New System.Drawing.Point(164, 59)
        Me.LabelAr.Name = "LabelAr"
        Me.LabelAr.Size = New System.Drawing.Size(29, 21)
        Me.LabelAr.TabIndex = 103
        Me.LabelAr.Text = "x--"
        '
        'LabelArqui
        '
        Me.LabelArqui.AutoSize = True
        Me.LabelArqui.Location = New System.Drawing.Point(70, 59)
        Me.LabelArqui.Name = "LabelArqui"
        Me.LabelArqui.Size = New System.Drawing.Size(92, 21)
        Me.LabelArqui.TabIndex = 102
        Me.LabelArqui.Text = "Arquitetura:"
        '
        'PictureBoxIcone
        '
        Me.PictureBoxIcone.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxIcone.Image = CType(resources.GetObject("PictureBoxIcone.Image"), System.Drawing.Image)
        Me.PictureBoxIcone.Location = New System.Drawing.Point(28, 3)
        Me.PictureBoxIcone.Name = "PictureBoxIcone"
        Me.PictureBoxIcone.Size = New System.Drawing.Size(54, 45)
        Me.PictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIcone.TabIndex = 101
        Me.PictureBoxIcone.TabStop = False
        '
        'PictureBoxFechar
        '
        Me.PictureBoxFechar.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxFechar.Image = CType(resources.GetObject("PictureBoxFechar.Image"), System.Drawing.Image)
        Me.PictureBoxFechar.Location = New System.Drawing.Point(573, 16)
        Me.PictureBoxFechar.Name = "PictureBoxFechar"
        Me.PictureBoxFechar.Size = New System.Drawing.Size(17, 18)
        Me.PictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFechar.TabIndex = 100
        Me.PictureBoxFechar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.ButtonSystemInfo)
        Me.Panel1.Controls.Add(Me.ButtonIPConfigAll)
        Me.Panel1.Controls.Add(Me.PictureBoxPrompt)
        Me.Panel1.Controls.Add(Me.ButtonIPConfig)
        Me.Panel1.Controls.Add(Me.LabelInfo1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 251)
        Me.Panel1.TabIndex = 97
        '
        'ButtonSystemInfo
        '
        Me.ButtonSystemInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSystemInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSystemInfo.Location = New System.Drawing.Point(26, 141)
        Me.ButtonSystemInfo.Name = "ButtonSystemInfo"
        Me.ButtonSystemInfo.Size = New System.Drawing.Size(90, 50)
        Me.ButtonSystemInfo.TabIndex = 85
        Me.ButtonSystemInfo.Text = "systeminfo"
        Me.ButtonSystemInfo.UseVisualStyleBackColor = True
        '
        'ButtonIPConfigAll
        '
        Me.ButtonIPConfigAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIPConfigAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIPConfigAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIPConfigAll.Location = New System.Drawing.Point(123, 197)
        Me.ButtonIPConfigAll.Name = "ButtonIPConfigAll"
        Me.ButtonIPConfigAll.Size = New System.Drawing.Size(93, 50)
        Me.ButtonIPConfigAll.TabIndex = 97
        Me.ButtonIPConfigAll.Text = "ipconfig /all"
        Me.ButtonIPConfigAll.UseVisualStyleBackColor = True
        '
        'PictureBoxPrompt
        '
        Me.PictureBoxPrompt.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPrompt.BackgroundImage = CType(resources.GetObject("PictureBoxPrompt.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxPrompt.Image = CType(resources.GetObject("PictureBoxPrompt.Image"), System.Drawing.Image)
        Me.PictureBoxPrompt.Location = New System.Drawing.Point(66, 63)
        Me.PictureBoxPrompt.Name = "PictureBoxPrompt"
        Me.PictureBoxPrompt.Size = New System.Drawing.Size(107, 69)
        Me.PictureBoxPrompt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrompt.TabIndex = 96
        Me.PictureBoxPrompt.TabStop = False
        '
        'ButtonIPConfig
        '
        Me.ButtonIPConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIPConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIPConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIPConfig.Location = New System.Drawing.Point(123, 141)
        Me.ButtonIPConfig.Name = "ButtonIPConfig"
        Me.ButtonIPConfig.Size = New System.Drawing.Size(93, 50)
        Me.ButtonIPConfig.TabIndex = 88
        Me.ButtonIPConfig.Text = "ipconfig"
        Me.ButtonIPConfig.UseVisualStyleBackColor = True
        '
        'LabelInfo1
        '
        Me.LabelInfo1.AutoSize = True
        Me.LabelInfo1.BackColor = System.Drawing.Color.Transparent
        Me.LabelInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelInfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo1.ForeColor = System.Drawing.Color.White
        Me.LabelInfo1.Location = New System.Drawing.Point(15, 5)
        Me.LabelInfo1.Name = "LabelInfo1"
        Me.LabelInfo1.Size = New System.Drawing.Size(213, 26)
        Me.LabelInfo1.TabIndex = 86
        Me.LabelInfo1.Text = "Informações do Sistema"
        Me.LabelInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Prompt de Comando"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Peru
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBoxCPUZ)
        Me.Panel2.Controls.Add(Me.PictureBoxHWINFO)
        Me.Panel2.Controls.Add(Me.LabelInfo2)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.LabelManual)
        Me.Panel2.Controls.Add(Me.LabelFab)
        Me.Panel2.Controls.Add(Me.LabelSens)
        Me.Panel2.Location = New System.Drawing.Point(260, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 277)
        Me.Panel2.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 17)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Memória RAM, ROM e Cache"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "CPU Testes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Processador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Clocks/Timers"
        '
        'PictureBoxCPUZ
        '
        Me.PictureBoxCPUZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCPUZ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxCPUZ.Image = CType(resources.GetObject("PictureBoxCPUZ.Image"), System.Drawing.Image)
        Me.PictureBoxCPUZ.Location = New System.Drawing.Point(15, 181)
        Me.PictureBoxCPUZ.Name = "PictureBoxCPUZ"
        Me.PictureBoxCPUZ.Size = New System.Drawing.Size(110, 88)
        Me.PictureBoxCPUZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCPUZ.TabIndex = 96
        Me.PictureBoxCPUZ.TabStop = False
        '
        'PictureBoxHWINFO
        '
        Me.PictureBoxHWINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxHWINFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxHWINFO.Image = CType(resources.GetObject("PictureBoxHWINFO.Image"), System.Drawing.Image)
        Me.PictureBoxHWINFO.Location = New System.Drawing.Point(15, 85)
        Me.PictureBoxHWINFO.Name = "PictureBoxHWINFO"
        Me.PictureBoxHWINFO.Size = New System.Drawing.Size(110, 87)
        Me.PictureBoxHWINFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHWINFO.TabIndex = 95
        Me.PictureBoxHWINFO.TabStop = False
        '
        'LabelInfo2
        '
        Me.LabelInfo2.BackColor = System.Drawing.Color.Transparent
        Me.LabelInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo2.ForeColor = System.Drawing.Color.White
        Me.LabelInfo2.Location = New System.Drawing.Point(42, 6)
        Me.LabelInfo2.Name = "LabelInfo2"
        Me.LabelInfo2.Size = New System.Drawing.Size(247, 50)
        Me.LabelInfo2.TabIndex = 90
        Me.LabelInfo2.Text = "Programas de Informações" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e/ou Diagnóstico"
        Me.LabelInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(80, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 20)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Tudo sobre o Sistema"
        '
        'LabelManual
        '
        Me.LabelManual.AutoSize = True
        Me.LabelManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelManual.Location = New System.Drawing.Point(133, 152)
        Me.LabelManual.Name = "LabelManual"
        Me.LabelManual.Size = New System.Drawing.Size(54, 17)
        Me.LabelManual.TabIndex = 93
        Me.LabelManual.Text = "Manual"
        '
        'LabelFab
        '
        Me.LabelFab.AutoSize = True
        Me.LabelFab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFab.Location = New System.Drawing.Point(133, 121)
        Me.LabelFab.Name = "LabelFab"
        Me.LabelFab.Size = New System.Drawing.Size(82, 17)
        Me.LabelFab.TabIndex = 92
        Me.LabelFab.Text = "Fabricantes"
        '
        'LabelSens
        '
        Me.LabelSens.AutoSize = True
        Me.LabelSens.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSens.Location = New System.Drawing.Point(133, 89)
        Me.LabelSens.Name = "LabelSens"
        Me.LabelSens.Size = New System.Drawing.Size(68, 17)
        Me.LabelSens.TabIndex = 91
        Me.LabelSens.Text = "Sensores"
        '
        'PictureBoxMini
        '
        Me.PictureBoxMini.Image = CType(resources.GetObject("PictureBoxMini.Image"), System.Drawing.Image)
        Me.PictureBoxMini.Location = New System.Drawing.Point(549, 15)
        Me.PictureBoxMini.Name = "PictureBoxMini"
        Me.PictureBoxMini.Size = New System.Drawing.Size(18, 19)
        Me.PictureBoxMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMini.TabIndex = 104
        Me.PictureBoxMini.TabStop = False
        '
        'InformacoesDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 348)
        Me.Controls.Add(Me.FormSkinInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformacoesDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "o"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkinInfo.ResumeLayout(False)
        Me.FormSkinInfo.PerformLayout()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxPrompt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxCPUZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHWINFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkinInfo As FormSkin
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxPrompt As PictureBox
    Friend WithEvents ButtonIPConfig As Button
    Friend WithEvents LabelInfo1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSystemInfo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxHWINFO As PictureBox
    Friend WithEvents LabelInfo2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelManual As Label
    Friend WithEvents LabelFab As Label
    Friend WithEvents LabelSens As Label
    Friend WithEvents PictureBoxFechar As PictureBox
    Friend WithEvents PictureBoxIcone As PictureBox
    Friend WithEvents ButtonIPConfigAll As Button
    Friend WithEvents PictureBoxCPUZ As PictureBox
    Friend WithEvents LabelAr As Label
    Friend WithEvents LabelArqui As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxMini As PictureBox
End Class
