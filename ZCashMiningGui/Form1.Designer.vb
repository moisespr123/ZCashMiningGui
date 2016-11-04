<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddressField = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TuningButton = New System.Windows.Forms.Button()
        Me.CompatibilityModeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GPUDevicesField = New System.Windows.Forms.TextBox()
        Me.UseNone = New System.Windows.Forms.RadioButton()
        Me.UseAMD = New System.Windows.Forms.RadioButton()
        Me.UseNvidia = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Threads = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UseCPU = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MinerConsole = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ServerField = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ShowCMD = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your ZCash Address:"
        '
        'AddressField
        '
        Me.AddressField.Location = New System.Drawing.Point(15, 25)
        Me.AddressField.Name = "AddressField"
        Me.AddressField.Size = New System.Drawing.Size(200, 20)
        Me.AddressField.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TuningButton)
        Me.GroupBox2.Controls.Add(Me.CompatibilityModeCheckBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GPUDevicesField)
        Me.GroupBox2.Controls.Add(Me.UseNone)
        Me.GroupBox2.Controls.Add(Me.UseAMD)
        Me.GroupBox2.Controls.Add(Me.UseNvidia)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 115)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Use Nvidia or AMD?"
        '
        'TuningButton
        '
        Me.TuningButton.Location = New System.Drawing.Point(119, 86)
        Me.TuningButton.Name = "TuningButton"
        Me.TuningButton.Size = New System.Drawing.Size(75, 23)
        Me.TuningButton.TabIndex = 16
        Me.TuningButton.Text = "Tuning"
        Me.TuningButton.UseVisualStyleBackColor = True
        '
        'CompatibilityModeCheckBox
        '
        Me.CompatibilityModeCheckBox.AutoSize = True
        Me.CompatibilityModeCheckBox.Location = New System.Drawing.Point(6, 93)
        Me.CompatibilityModeCheckBox.Name = "CompatibilityModeCheckBox"
        Me.CompatibilityModeCheckBox.Size = New System.Drawing.Size(114, 17)
        Me.CompatibilityModeCheckBox.TabIndex = 15
        Me.CompatibilityModeCheckBox.Text = "Compatibility Mode"
        Me.CompatibilityModeCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Device Number:"
        '
        'GPUDevicesField
        '
        Me.GPUDevicesField.Location = New System.Drawing.Point(6, 60)
        Me.GPUDevicesField.Name = "GPUDevicesField"
        Me.GPUDevicesField.Size = New System.Drawing.Size(100, 20)
        Me.GPUDevicesField.TabIndex = 3
        Me.GPUDevicesField.Text = "0"
        '
        'UseNone
        '
        Me.UseNone.AutoSize = True
        Me.UseNone.Checked = True
        Me.UseNone.Location = New System.Drawing.Point(122, 19)
        Me.UseNone.Name = "UseNone"
        Me.UseNone.Size = New System.Drawing.Size(51, 17)
        Me.UseNone.TabIndex = 2
        Me.UseNone.TabStop = True
        Me.UseNone.Text = "None"
        Me.UseNone.UseVisualStyleBackColor = True
        '
        'UseAMD
        '
        Me.UseAMD.AutoSize = True
        Me.UseAMD.Location = New System.Drawing.Point(67, 19)
        Me.UseAMD.Name = "UseAMD"
        Me.UseAMD.Size = New System.Drawing.Size(49, 17)
        Me.UseAMD.TabIndex = 1
        Me.UseAMD.TabStop = True
        Me.UseAMD.Text = "AMD"
        Me.UseAMD.UseVisualStyleBackColor = True
        '
        'UseNvidia
        '
        Me.UseNvidia.AutoSize = True
        Me.UseNvidia.Location = New System.Drawing.Point(6, 19)
        Me.UseNvidia.Name = "UseNvidia"
        Me.UseNvidia.Size = New System.Drawing.Size(55, 17)
        Me.UseNvidia.TabIndex = 0
        Me.UseNvidia.TabStop = True
        Me.UseNvidia.Text = "Nvidia"
        Me.UseNvidia.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Threads)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.UseCPU)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Use CPU?"
        '
        'Threads
        '
        Me.Threads.Location = New System.Drawing.Point(9, 64)
        Me.Threads.Name = "Threads"
        Me.Threads.Size = New System.Drawing.Size(100, 20)
        Me.Threads.TabIndex = 2
        Me.Threads.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Threads:"
        '
        'UseCPU
        '
        Me.UseCPU.AutoSize = True
        Me.UseCPU.Location = New System.Drawing.Point(9, 19)
        Me.UseCPU.Name = "UseCPU"
        Me.UseCPU.Size = New System.Drawing.Size(44, 17)
        Me.UseCPU.TabIndex = 0
        Me.UseCPU.Text = "Yes"
        Me.UseCPU.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Start Mining!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Miner Output (May not be realtime):"
        '
        'MinerConsole
        '
        Me.MinerConsole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinerConsole.Location = New System.Drawing.Point(247, 25)
        Me.MinerConsole.Multiline = True
        Me.MinerConsole.Name = "MinerConsole"
        Me.MinerConsole.Size = New System.Drawing.Size(716, 389)
        Me.MinerConsole.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "GUI developed by Moises Cardona"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(836, 417)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(127, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://moisescardona.net"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ZCash Miner GUI"
        Me.NotifyIcon1.Visible = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(802, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "v0.3"
        '
        'ServerField
        '
        Me.ServerField.Location = New System.Drawing.Point(15, 74)
        Me.ServerField.Name = "ServerField"
        Me.ServerField.Size = New System.Drawing.Size(200, 20)
        Me.ServerField.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Server:Port"
        '
        'ShowCMD
        '
        Me.ShowCMD.AutoSize = True
        Me.ShowCMD.Location = New System.Drawing.Point(15, 341)
        Me.ShowCMD.Name = "ShowCMD"
        Me.ShowCMD.Size = New System.Drawing.Size(172, 30)
        Me.ShowCMD.TabIndex = 15
        Me.ShowCMD.Text = "Show CMD window" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Output will not be shown here)"
        Me.ShowCMD.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(108, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 53)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "StopMining"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 439)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowCMD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ServerField)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MinerConsole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AddressField)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "nheqminer ZCash Miner GUI"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddressField As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GPUDevicesField As TextBox
    Friend WithEvents UseNone As RadioButton
    Friend WithEvents UseAMD As RadioButton
    Friend WithEvents UseNvidia As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Threads As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UseCPU As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents MinerConsole As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label6 As Label
    Friend WithEvents CompatibilityModeCheckBox As CheckBox
    Friend WithEvents ServerField As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ShowCMD As CheckBox
    Friend WithEvents TuningButton As Button
    Friend WithEvents Button2 As Button
End Class
