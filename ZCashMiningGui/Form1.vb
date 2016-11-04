Public Class Form1
    Private strResults As String
    Private intStop As Integer
    Private swReader As System.IO.StreamReader
    Private thrdCMD As System.Threading.Thread
    Private Delegate Sub Update()
    Private uFin As New Update(AddressOf UpdateText)
    Private Server As String = ""
    Private Address As String = ""
    Private UseGPU As Boolean = False
    Private ThreadsAndBlocksCommand As String = ""
    Private GPUcommand As String = ""
    Private GPUDevices As Integer = 0
    Private CPUThreads As Integer = 0
    Public CUDAThreads As Integer = 0
    Public CUDABlocks As Integer = 0

    Private Sub UpdateText()
        MinerConsole.Text += strResults
        MinerConsole.SelectionStart = MinerConsole.TextLength - 1
        MinerConsole.Focus()
        intStop = MinerConsole.SelectionStart
        MinerConsole.ScrollToCaret()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ValidationError As Boolean = False
        Dim ErrorMessage As String = "The Following Errors were found:" & vbNewLine
        If String.IsNullOrEmpty(AddressField.Text) = False Then
            Address = AddressField.Text
        Else
            ValidationError = True
            ErrorMessage += "-Address field is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(ServerField.Text) = False Then
            Server = ServerField.Text
        Else
            ValidationError = True
            ErrorMessage += "-Server field is empty" & vbNewLine
        End If
        If UseNvidia.Checked Then
            UseGPU = True
            GPUcommand = "-cd"
        ElseIf UseAMD.Checked Then
            UseGPU = True
            GPUcommand = "-od"
        ElseIf UseNone.Checked Then
            UseGPU = False
            GPUcommand = "null"
        End If
        If UseGPU = True Then
            If String.IsNullOrEmpty(GPUDevicesField.Text) = False Then
                If IsNumeric(GPUDevicesField.Text) Then
                    GPUDevices = GPUDevicesField.Text
                Else
                    ValidationError = True
                    ErrorMessage += "-GPU Devices Number is not numeric" & vbNewLine
                End If
            Else
                ValidationError = True
                ErrorMessage += "-GPU Devices Number is empty" & vbNewLine
            End If
        End If
        If UseCPU.Checked Then
            If String.IsNullOrEmpty(Threads.Text) = False Then
                If IsNumeric(Threads.Text) Then
                    If Threads.Text = "0" = False Then
                        CPUThreads = Threads.Text
                    Else
                        ValidationError = True
                        ErrorMessage += "-CPU Threads cannot be zero" & vbNewLine
                    End If
                Else
                    ValidationError = True
                    ErrorMessage += "-CPU Threads is not numeric" & vbNewLine
                End If
            Else
                ValidationError = True
                ErrorMessage += "-CPU Threads is empty" & vbNewLine
            End If
        End If
        If UseGPU = False And UseCPU.Checked = False Then
            ValidationError = True
            ErrorMessage += "-You must use either the CPU or GPU to mine" & vbNewLine
        End If
        If ValidationError = True Then
            MessageBox.Show(ErrorMessage & "Please fix these errors in order to start mining ZCash")
        Else
            If UseNvidia.Checked Then
                If CUDAThreads = 0 = False Then
                    ThreadsAndBlocksCommand = "-ct " & CUDAThreads
                End If
                If CUDABlocks = 0 = False Then
                    ThreadsAndBlocksCommand += " -cb " & CUDABlocks
                End If
            Else
                ThreadsAndBlocksCommand = ""
            End If
            Dim writer As New System.IO.StreamWriter("config.conf", False)
            writer.WriteLine("Address=" & Address)
            writer.WriteLine("Server=" & Server)
            writer.WriteLine("GPUCommand=" & GPUcommand)
            writer.WriteLine("CompatibilityMode=" & CompatibilityModeCheckBox.Checked)
            writer.WriteLine("GPUDevices=" & GPUDevices)
            writer.WriteLine("CUDAThreads=" & CUDAThreads)
            writer.WriteLine("CUDABlocks=" & CUDABlocks)
            writer.WriteLine("UseCPU=" & UseCPU.Checked)
            writer.WriteLine("CPUThreads=" & CPUThreads)
            writer.WriteLine("ShowCMD=" & ShowCMD.Checked)
            writer.Close()
            thrdCMD = New System.Threading.Thread(AddressOf Miner)
            thrdCMD.IsBackground = True
            thrdCMD.Start()
            End If
    End Sub
    Private Sub Miner()
        Dim ArgumentsToUse As String = ""
        If UseGPU = True Then
            If CompatibilityModeCheckBox.Checked Then
                If UseCPU.Checked Then
                    ArgumentsToUse = "-l " & Server & " -u " & Address & " -t " & CPUThreads & " " & GPUcommand & " " & GPUDevices & " -cv 1 " & ThreadsAndBlocksCommand
                Else
                    ArgumentsToUse = "-l " & Server & " -u " & Address & " -t 0 " & GPUcommand & " " & GPUDevices & " -cv 1 " & ThreadsAndBlocksCommand
                End If
            Else
                If UseCPU.Checked Then
                    ArgumentsToUse = "-l " & Server & " -u " & Address & " -t " & CPUThreads & " " & GPUcommand & " " & GPUDevices & " " & ThreadsAndBlocksCommand
                Else
                    ArgumentsToUse = "-l " & Server & " -u " & Address & " -t 0 " & GPUcommand & " " & GPUDevices & " " & ThreadsAndBlocksCommand
                End If
            End If
        Else
            If UseCPU.Checked Then
                ArgumentsToUse = "-l " & Server & " -u " & Address & " -t " & CPUThreads
            Else
                ArgumentsToUse = "-l " & Server & " -u " & Address & " -t 0 "
            End If
        End If
        Dim procMiner As New Process
        If ShowCMD.Checked Then
            procMiner.StartInfo.RedirectStandardOutput = False
            procMiner.StartInfo.CreateNoWindow = False
            procMiner.StartInfo.UseShellExecute = True
            procMiner.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory & "\nheqminer\nheqminer.exe"
            procMiner.StartInfo.Arguments = ArgumentsToUse
            procMiner.StartInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory & "\nheqminer\"
            procMiner.Start()
            Do Until (procMiner.HasExited)
            Loop
            procMiner.Dispose()
        Else
            AddHandler procMiner.OutputDataReceived, AddressOf MinerOutput
            procMiner.StartInfo.RedirectStandardOutput = True
            procMiner.StartInfo.CreateNoWindow = True
            procMiner.StartInfo.UseShellExecute = False
            procMiner.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory & "\nheqminer\nheqminer.exe"
            procMiner.StartInfo.Arguments = ArgumentsToUse
            procMiner.StartInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory & "\nheqminer\"
            procMiner.Start()
            procMiner.BeginOutputReadLine()
            Do Until (procMiner.HasExited)
            Loop
            procMiner.Dispose()
        End If
    End Sub
    Private Sub MinerOutput(ByVal Sender As Object, ByVal OutputLine As DataReceivedEventArgs)
        strResults = OutputLine.Data & Environment.NewLine
        Try
            Invoke(uFin)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Dim line As String
        Dim getdata As String()
        Dim result As String
        If My.Computer.FileSystem.FileExists(System.IO.Directory.GetCurrentDirectory & "\nheqminer\nheqminer.exe") = False Then
            MessageBox.Show("nheqminer not found. Please download the miner and put it inside a folder called ""nheqminer""")
            Process.Start("https://github.com/nicehash/nheqminer/releases")
            Me.Close()
        End If
        Try
            Using reader As New System.IO.StreamReader("config.conf")
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    If line.Contains("Address") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        AddressField.Text = result
                    ElseIf line.Contains("Server") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = "usa" Or result = "eu" Then
                            ServerField.Text = "stratum.zcash.nicehash.com:3357"
                        Else
                            ServerField.Text = result
                        End If
                    ElseIf line.Contains("GPUCommand") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = "-od" Then
                            UseAMD.Checked = True
                            CompatibilityModeCheckBox.Checked = False
                            CompatibilityModeCheckBox.Enabled = False
                            TuningButton.Enabled = False
                        ElseIf result = "-cd" Then
                            UseNvidia.Checked = True
                            CompatibilityModeCheckBox.Enabled = True
                            TuningButton.Enabled = True
                        Else
                            UseNone.Checked = True
                            CompatibilityModeCheckBox.Checked = False
                            CompatibilityModeCheckBox.Enabled = False
                            TuningButton.Enabled = False
                        End If
                    ElseIf line.Contains("CompatibilityMode") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = "True" Then
                            CompatibilityModeCheckBox.Checked = True
                        Else
                            CompatibilityModeCheckBox.Checked = False
                        End If
                    ElseIf line.Contains("GPUDevices") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        GPUDevicesField.Text = result
                    ElseIf line.Contains("CUDAThreads") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        CUDAThreads = result
                    ElseIf line.Contains("CUDABlocks") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        CUDABlocks = result
                    ElseIf line.Contains("UseCPU") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = "True" Then
                            UseCPU.Checked = True
                        Else
                            UseCPU.Checked = False
                        End If
                    ElseIf line.Contains("CPUThreads") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        Threads.Text = result
                    ElseIf line.Contains("ShowCMD") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = "True" Then
                            ShowCMD.Checked = True
                        Else
                            ShowCMD.Checked = False
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            ServerField.Text = "stratum.zcash.nicehash.com:3357"
            CompatibilityModeCheckBox.Checked = False
            CompatibilityModeCheckBox.Enabled = False
            TuningButton.Enabled = False
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("nheqminer")
            P.Kill()
        Next
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            Me.Hide()
            NotifyIcon1.BalloonTipTitle = "ZCash Miner GUI"
            NotifyIcon1.BalloonTipText = "ZCash Miner GUI running on System Tray"
            NotifyIcon1.ShowBalloonTip(5000)
        End If
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://moisescardona.net")
    End Sub

    Private Sub UseNvidia_CheckedChanged(sender As Object, e As EventArgs) Handles UseNvidia.CheckedChanged
        If UseNvidia.Checked Then
            CompatibilityModeCheckBox.Enabled = True
            TuningButton.Enabled = True
        Else
            CompatibilityModeCheckBox.Checked = False
            CompatibilityModeCheckBox.Enabled = False
            TuningButton.Enabled = False
        End If
    End Sub

    Private Sub TuningButton_Click(sender As Object, e As EventArgs) Handles TuningButton.Click
        NvidiaTuning.ShowDialog()
    End Sub
End Class
