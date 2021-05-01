<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notificacao))
        Me.LabelHora1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTempoM = New System.Windows.Forms.Label()
        Me.MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxM = New System.Windows.Forms.TextBox()
        Me.ButtonIniciar = New System.Windows.Forms.Button()
        Me.ButtonParar = New System.Windows.Forms.Button()
        Me.ButtonMinimizarN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LabelHoraDesejada = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelHora1
        '
        Me.LabelHora1.AutoSize = True
        Me.LabelHora1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora1.Location = New System.Drawing.Point(9, 9)
        Me.LabelHora1.Name = "LabelHora1"
        Me.LabelHora1.Size = New System.Drawing.Size(48, 20)
        Me.LabelHora1.TabIndex = 0
        Me.LabelHora1.Text = "Hora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mensagem:"
        '
        'LabelTempoM
        '
        Me.LabelTempoM.AutoSize = True
        Me.LabelTempoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTempoM.Location = New System.Drawing.Point(9, 204)
        Me.LabelTempoM.Name = "LabelTempoM"
        Me.LabelTempoM.Size = New System.Drawing.Size(160, 17)
        Me.LabelTempoM.TabIndex = 2
        Me.LabelTempoM.Text = "Mensagem aparece em:"
        '
        'MaskedTextBox
        '
        Me.MaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox.Location = New System.Drawing.Point(12, 56)
        Me.MaskedTextBox.Mask = "00:00:00"
        Me.MaskedTextBox.Name = "MaskedTextBox"
        Me.MaskedTextBox.Size = New System.Drawing.Size(102, 35)
        Me.MaskedTextBox.TabIndex = 3
        '
        'TextBoxM
        '
        Me.TextBoxM.Location = New System.Drawing.Point(12, 116)
        Me.TextBoxM.Multiline = True
        Me.TextBoxM.Name = "TextBoxM"
        Me.TextBoxM.Size = New System.Drawing.Size(222, 84)
        Me.TextBoxM.TabIndex = 4
        '
        'ButtonIniciar
        '
        Me.ButtonIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIniciar.Location = New System.Drawing.Point(13, 229)
        Me.ButtonIniciar.Name = "ButtonIniciar"
        Me.ButtonIniciar.Size = New System.Drawing.Size(105, 33)
        Me.ButtonIniciar.TabIndex = 5
        Me.ButtonIniciar.Text = "Iniciar"
        Me.ButtonIniciar.UseVisualStyleBackColor = True
        '
        'ButtonParar
        '
        Me.ButtonParar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParar.Location = New System.Drawing.Point(12, 266)
        Me.ButtonParar.Name = "ButtonParar"
        Me.ButtonParar.Size = New System.Drawing.Size(105, 33)
        Me.ButtonParar.TabIndex = 6
        Me.ButtonParar.Text = "Parar"
        Me.ButtonParar.UseVisualStyleBackColor = True
        '
        'ButtonMinimizarN
        '
        Me.ButtonMinimizarN.Image = CType(resources.GetObject("ButtonMinimizarN.Image"), System.Drawing.Image)
        Me.ButtonMinimizarN.Location = New System.Drawing.Point(211, 274)
        Me.ButtonMinimizarN.Name = "ButtonMinimizarN"
        Me.ButtonMinimizarN.Size = New System.Drawing.Size(23, 25)
        Me.ButtonMinimizarN.TabIndex = 7
        Me.ButtonMinimizarN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "-"
        Me.NotifyIcon1.BalloonTipTitle = "Notificação"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Notificação"
        '
        'LabelHoraDesejada
        '
        Me.LabelHoraDesejada.AutoSize = True
        Me.LabelHoraDesejada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHoraDesejada.Location = New System.Drawing.Point(9, 36)
        Me.LabelHoraDesejada.Name = "LabelHoraDesejada"
        Me.LabelHoraDesejada.Size = New System.Drawing.Size(105, 17)
        Me.LabelHoraDesejada.TabIndex = 8
        Me.LabelHoraDesejada.Text = "Hora desejada:"
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.Location = New System.Drawing.Point(58, 9)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(47, 20)
        Me.LabelHora.TabIndex = 9
        Me.LabelHora.Text = "--/--/--"
        '
        'Notificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(244, 309)
        Me.Controls.Add(Me.LabelHora)
        Me.Controls.Add(Me.LabelHoraDesejada)
        Me.Controls.Add(Me.ButtonMinimizarN)
        Me.Controls.Add(Me.ButtonParar)
        Me.Controls.Add(Me.ButtonIniciar)
        Me.Controls.Add(Me.TextBoxM)
        Me.Controls.Add(Me.MaskedTextBox)
        Me.Controls.Add(Me.LabelTempoM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelHora1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Notificacao"
        Me.Text = "Notificação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHora1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTempoM As Label
    Friend WithEvents MaskedTextBox As MaskedTextBox
    Friend WithEvents TextBoxM As TextBox
    Friend WithEvents ButtonIniciar As Button
    Friend WithEvents ButtonParar As Button
    Friend WithEvents ButtonMinimizarN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LabelHoraDesejada As Label
    Friend WithEvents LabelHora As Label
End Class
