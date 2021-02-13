<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Data = New System.Windows.Forms.Label()
        Me.TimerDataHora = New System.Windows.Forms.Timer(Me.components)
        Me.DataTimer = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.HoraTimer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.aee = New System.Windows.Forms.PictureBox()
        Me.Ajuda = New System.Windows.Forms.HelpProvider()
        CType(Me.aee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data
        '
        resources.ApplyResources(Me.Data, "Data")
        Me.Data.Name = "Data"
        Me.Ajuda.SetShowHelp(Me.Data, CType(resources.GetObject("Data.ShowHelp"), Boolean))
        '
        'TimerDataHora
        '
        Me.TimerDataHora.Enabled = True
        Me.TimerDataHora.Interval = 1000
        '
        'DataTimer
        '
        resources.ApplyResources(Me.DataTimer, "DataTimer")
        Me.DataTimer.Name = "DataTimer"
        Me.Ajuda.SetShowHelp(Me.DataTimer, CType(resources.GetObject("DataTimer.ShowHelp"), Boolean))
        '
        'Hora
        '
        resources.ApplyResources(Me.Hora, "Hora")
        Me.Hora.Name = "Hora"
        Me.Ajuda.SetShowHelp(Me.Hora, CType(resources.GetObject("Hora.ShowHelp"), Boolean))
        '
        'HoraTimer
        '
        resources.ApplyResources(Me.HoraTimer, "HoraTimer")
        Me.HoraTimer.Name = "HoraTimer"
        Me.Ajuda.SetShowHelp(Me.HoraTimer, CType(resources.GetObject("HoraTimer.ShowHelp"), Boolean))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Ajuda.SetShowHelp(Me.Button1, CType(resources.GetObject("Button1.ShowHelp"), Boolean))
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Ajuda.SetShowHelp(Me.Button2, CType(resources.GetObject("Button2.ShowHelp"), Boolean))
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.Ajuda.SetShowHelp(Me.Label2, CType(resources.GetObject("Label2.ShowHelp"), Boolean))
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Ajuda.SetShowHelp(Me.Button3, CType(resources.GetObject("Button3.ShowHelp"), Boolean))
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Ajuda.SetShowHelp(Me.Button4, CType(resources.GetObject("Button4.ShowHelp"), Boolean))
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.Ajuda.SetShowHelp(Me.LinkLabel1, CType(resources.GetObject("LinkLabel1.ShowHelp"), Boolean))
        Me.LinkLabel1.TabStop = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Ajuda.SetShowHelp(Me.Button5, CType(resources.GetObject("Button5.ShowHelp"), Boolean))
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Ajuda.SetShowHelp(Me.Button6, CType(resources.GetObject("Button6.ShowHelp"), Boolean))
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Ajuda.SetShowHelp(Me.Button7, CType(resources.GetObject("Button7.ShowHelp"), Boolean))
        Me.Button7.UseVisualStyleBackColor = True
        '
        'aee
        '
        Me.aee.Image = Global.PAP.My.Resources.Resources.aee
        resources.ApplyResources(Me.aee, "aee")
        Me.aee.Name = "aee"
        Me.Ajuda.SetShowHelp(Me.aee, CType(resources.GetObject("aee.ShowHelp"), Boolean))
        Me.aee.TabStop = False
        '
        'Ajuda
        '
        resources.ApplyResources(Me.Ajuda, "Ajuda")
        '
        'Home
        '
        Me.AcceptButton = Me.LinkLabel1
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.aee)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HoraTimer)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.DataTimer)
        Me.Controls.Add(Me.Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Ajuda.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.aee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data As Label
    Friend WithEvents TimerDataHora As Timer
    Friend WithEvents DataTimer As Label
    Friend WithEvents Hora As Label
    Friend WithEvents HoraTimer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents aee As PictureBox
    Friend WithEvents Ajuda As HelpProvider
End Class
