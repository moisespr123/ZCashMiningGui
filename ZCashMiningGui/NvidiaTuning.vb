Public Class NvidiaTuning
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ValidationError As Boolean = False
        Dim ErrorMessage As String = "Cannot apply settings. Check the errors below:" & vbNewLine
        If String.IsNullOrEmpty(ThreadsField.Text) Then
            Form1.CUDAThreads = 0
        Else
            If IsNumeric(ThreadsField.Text) Then
                Form1.CUDAThreads = ThreadsField.Text
            Else
                ValidationError = True
                ErrorMessage = "-Threads field is not numeric" & vbNewLine
            End If
        End If
        If String.IsNullOrEmpty(BlocksField.Text) Then
            Form1.CUDAThreads = 0
        Else
            If IsNumeric(BlocksField.Text) Then
                Form1.CUDABlocks = BlocksField.Text
            Else
                ValidationError = True
                ErrorMessage = "-Blocks field is not numeric" & vbNewLine
            End If
        End If
        If ValidationError = True Then
            MessageBox.Show(ErrorMessage)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub NvidiaTuning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThreadsField.Text = Form1.CUDAThreads
        BlocksField.Text = Form1.CUDABlocks
    End Sub
End Class