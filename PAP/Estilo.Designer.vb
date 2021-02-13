<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estilo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estilo))
        Me.ColorDialogBaixo = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogCima = New System.Windows.Forms.ColorDialog()
        Me.FormSkinEstilo = New PAP.FormSkin()
        Me.PictureBoxIcone = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFechar = New System.Windows.Forms.PictureBox()
        Me.FlatMinimizar = New PAP.FlatMini()
        Me.LabelCima = New System.Windows.Forms.Label()
        Me.LabelBaixo = New System.Windows.Forms.Label()
        Me.ButtonColorDialogCima = New System.Windows.Forms.Button()
        Me.ButtonResetCima = New System.Windows.Forms.Button()
        Me.ButtonResetLetra = New System.Windows.Forms.Button()
        Me.ComboBoxLetra = New System.Windows.Forms.ComboBox()
        Me.ButtonResetBaixo = New System.Windows.Forms.Button()
        Me.ButtonColorDialogBaixo = New System.Windows.Forms.Button()
        Me.LabelLetra = New System.Windows.Forms.Label()
        Me.LabelCorPaineis = New System.Windows.Forms.Label()
        Me.FormSkinEstilo.SuspendLayout()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkinEstilo
        '
        Me.FormSkinEstilo.BackColor = System.Drawing.Color.White
        Me.FormSkinEstilo.BaseColor = System.Drawing.SystemColors.Control
        Me.FormSkinEstilo.BorderColor = System.Drawing.Color.Black
        Me.FormSkinEstilo.Controls.Add(Me.PictureBoxIcone)
        Me.FormSkinEstilo.Controls.Add(Me.PictureBoxFechar)
        Me.FormSkinEstilo.Controls.Add(Me.FlatMinimizar)
        Me.FormSkinEstilo.Controls.Add(Me.LabelCima)
        Me.FormSkinEstilo.Controls.Add(Me.LabelBaixo)
        Me.FormSkinEstilo.Controls.Add(Me.ButtonColorDialogCima)
        Me.FormSkinEstilo.Controls.Add(Me.ButtonResetCima)
        Me.FormSkinEstilo.Controls.Add(Me.ButtonResetLetra)
        Me.FormSkinEstilo.Controls.Add(Me.ComboBoxLetra)
        Me.FormSkinEstilo.Controls.Add(Me.ButtonResetBaixo)
        Me.FormSkinEstilo.Controls.Add(Me.ButtonColorDialogBaixo)
        Me.FormSkinEstilo.Controls.Add(Me.LabelLetra)
        Me.FormSkinEstilo.Controls.Add(Me.LabelCorPaineis)
        Me.FormSkinEstilo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkinEstilo.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkinEstilo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkinEstilo.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkinEstilo.HeaderMaximize = False
        Me.FormSkinEstilo.Location = New System.Drawing.Point(0, 0)
        Me.FormSkinEstilo.Name = "FormSkinEstilo"
        Me.FormSkinEstilo.Size = New System.Drawing.Size(336, 264)
        Me.FormSkinEstilo.TabIndex = 0
        Me.FormSkinEstilo.Text = "              Mudar cor e tipo de letra"
        '
        'PictureBoxIcone
        '
        Me.PictureBoxIcone.Image = CType(resources.GetObject("PictureBoxIcone.Image"), System.Drawing.Image)
        Me.PictureBoxIcone.Location = New System.Drawing.Point(29, 3)
        Me.PictureBoxIcone.Name = "PictureBoxIcone"
        Me.PictureBoxIcone.Size = New System.Drawing.Size(54, 45)
        Me.PictureBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxIcone.TabIndex = 30
        Me.PictureBoxIcone.TabStop = False
        '
        'PictureBoxFechar
        '
        Me.PictureBoxFechar.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxFechar.Image = CType(resources.GetObject("PictureBoxFechar.Image"), System.Drawing.Image)
        Me.PictureBoxFechar.Location = New System.Drawing.Point(307, 17)
        Me.PictureBoxFechar.Name = "PictureBoxFechar"
        Me.PictureBoxFechar.Size = New System.Drawing.Size(17, 18)
        Me.PictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFechar.TabIndex = 29
        Me.PictureBoxFechar.TabStop = False
        '
        'FlatMinimizar
        '
        Me.FlatMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMinimizar.BackColor = System.Drawing.Color.White
        Me.FlatMinimizar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMinimizar.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMinimizar.Location = New System.Drawing.Point(283, 17)
        Me.FlatMinimizar.Name = "FlatMinimizar"
        Me.FlatMinimizar.Size = New System.Drawing.Size(18, 18)
        Me.FlatMinimizar.TabIndex = 28
        Me.FlatMinimizar.Text = "FlatMinimizar"
        Me.FlatMinimizar.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'LabelCima
        '
        Me.LabelCima.AutoSize = True
        Me.LabelCima.BackColor = System.Drawing.Color.Transparent
        Me.LabelCima.Location = New System.Drawing.Point(219, 78)
        Me.LabelCima.Name = "LabelCima"
        Me.LabelCima.Size = New System.Drawing.Size(46, 21)
        Me.LabelCima.TabIndex = 27
        Me.LabelCima.Text = "Cima"
        '
        'LabelBaixo
        '
        Me.LabelBaixo.AutoSize = True
        Me.LabelBaixo.BackColor = System.Drawing.Color.Transparent
        Me.LabelBaixo.Location = New System.Drawing.Point(73, 78)
        Me.LabelBaixo.Name = "LabelBaixo"
        Me.LabelBaixo.Size = New System.Drawing.Size(47, 21)
        Me.LabelBaixo.TabIndex = 26
        Me.LabelBaixo.Text = "Baixo"
        '
        'ButtonColorDialogCima
        '
        Me.ButtonColorDialogCima.Location = New System.Drawing.Point(173, 102)
        Me.ButtonColorDialogCima.Name = "ButtonColorDialogCima"
        Me.ButtonColorDialogCima.Size = New System.Drawing.Size(144, 30)
        Me.ButtonColorDialogCima.TabIndex = 25
        Me.ButtonColorDialogCima.Text = "Abrir ColorDialog"
        Me.ButtonColorDialogCima.UseVisualStyleBackColor = True
        '
        'ButtonResetCima
        '
        Me.ButtonResetCima.Location = New System.Drawing.Point(173, 136)
        Me.ButtonResetCima.Name = "ButtonResetCima"
        Me.ButtonResetCima.Size = New System.Drawing.Size(58, 30)
        Me.ButtonResetCima.TabIndex = 24
        Me.ButtonResetCima.Text = "Reset"
        Me.ButtonResetCima.UseVisualStyleBackColor = True
        '
        'ButtonResetLetra
        '
        Me.ButtonResetLetra.Location = New System.Drawing.Point(23, 228)
        Me.ButtonResetLetra.Name = "ButtonResetLetra"
        Me.ButtonResetLetra.Size = New System.Drawing.Size(58, 29)
        Me.ButtonResetLetra.TabIndex = 21
        Me.ButtonResetLetra.Text = "Reset"
        Me.ButtonResetLetra.UseVisualStyleBackColor = True
        '
        'ComboBoxLetra
        '
        Me.ComboBoxLetra.FormattingEnabled = True
        Me.ComboBoxLetra.Location = New System.Drawing.Point(23, 197)
        Me.ComboBoxLetra.Name = "ComboBoxLetra"
        Me.ComboBoxLetra.Size = New System.Drawing.Size(294, 29)
        Me.ComboBoxLetra.TabIndex = 20
        '
        'ButtonResetBaixo
        '
        Me.ButtonResetBaixo.Location = New System.Drawing.Point(23, 136)
        Me.ButtonResetBaixo.Name = "ButtonResetBaixo"
        Me.ButtonResetBaixo.Size = New System.Drawing.Size(58, 30)
        Me.ButtonResetBaixo.TabIndex = 17
        Me.ButtonResetBaixo.Text = "Reset"
        Me.ButtonResetBaixo.UseVisualStyleBackColor = True
        '
        'ButtonColorDialogBaixo
        '
        Me.ButtonColorDialogBaixo.Location = New System.Drawing.Point(23, 102)
        Me.ButtonColorDialogBaixo.Name = "ButtonColorDialogBaixo"
        Me.ButtonColorDialogBaixo.Size = New System.Drawing.Size(144, 30)
        Me.ButtonColorDialogBaixo.TabIndex = 16
        Me.ButtonColorDialogBaixo.Text = "Abrir ColorDialog"
        Me.ButtonColorDialogBaixo.UseVisualStyleBackColor = True
        '
        'LabelLetra
        '
        Me.LabelLetra.AutoSize = True
        Me.LabelLetra.BackColor = System.Drawing.Color.Transparent
        Me.LabelLetra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelLetra.Location = New System.Drawing.Point(19, 172)
        Me.LabelLetra.Name = "LabelLetra"
        Me.LabelLetra.Size = New System.Drawing.Size(161, 21)
        Me.LabelLetra.TabIndex = 15
        Me.LabelLetra.Text = "Mudar tipo de letra:"
        '
        'LabelCorPaineis
        '
        Me.LabelCorPaineis.AutoSize = True
        Me.LabelCorPaineis.BackColor = System.Drawing.Color.Transparent
        Me.LabelCorPaineis.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCorPaineis.Location = New System.Drawing.Point(19, 57)
        Me.LabelCorPaineis.Name = "LabelCorPaineis"
        Me.LabelCorPaineis.Size = New System.Drawing.Size(182, 21)
        Me.LabelCorPaineis.TabIndex = 14
        Me.LabelCorPaineis.Text = "Mudar cor dos paineis:"
        '
        'Estilo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 264)
        Me.Controls.Add(Me.FormSkinEstilo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estilo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estilo"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkinEstilo.ResumeLayout(False)
        Me.FormSkinEstilo.PerformLayout()
        CType(Me.PictureBoxIcone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialogBaixo As ColorDialog
    Friend WithEvents ColorDialogCima As ColorDialog
    Friend WithEvents LabelCorPaineis As Label
    Friend WithEvents LabelLetra As Label
    Friend WithEvents ButtonColorDialogBaixo As Button
    Friend WithEvents ButtonResetBaixo As Button
    Friend WithEvents ComboBoxLetra As ComboBox
    Friend WithEvents ButtonResetLetra As Button
    Friend WithEvents ButtonResetCima As Button
    Friend WithEvents ButtonColorDialogCima As Button
    Friend WithEvents LabelBaixo As Label
    Friend WithEvents LabelCima As Label
    Friend WithEvents FormSkinEstilo As FormSkin
    Friend WithEvents FlatMinimizar As FlatMini
    Friend WithEvents PictureBoxFechar As PictureBox
    Friend WithEvents PictureBoxIcone As PictureBox
End Class
