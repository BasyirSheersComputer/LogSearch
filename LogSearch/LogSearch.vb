Imports System.Buffers
Imports System.IO

Public Class LogSearchForm
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ' Get the log folder path and keyword input from the user
        Dim logDirectory As String = FilePath.Text
        Dim keyword As String = SearchBox.Text

        ' Check if the log folder exists
        If Not System.IO.Directory.Exists(logDirectory) Then
            MessageBox.Show("Log folder does not exist.")
            Return
        End If

        ' Search for files containing the keyword
        Dim txtFiles As New List(Of String)
        Dim logFiles As New List(Of String)

        ' Get all text files in the folder
        Dim files() As String = System.IO.Directory.GetFiles(logDirectory)

        ' Iterate through each file and search for the keyword
        For Each file As String In files
            Dim extension As String = System.IO.Path.GetExtension(file).ToLower()
            If extension = ".txt" OrElse extension = ".log" Then
                Dim lines() As String = System.IO.File.ReadAllLines(file)
                For Each line As String In lines
                    If line.Contains(keyword) Then
                        If extension = ".txt" Then
                            txtFiles.Add(file)
                        ElseIf extension = ".log" Then
                            logFiles.Add(file)
                        End If
                        Exit For ' Once found in this file, no need to continue searching
                    End If
                Next
            End If
        Next

        ' Display the matching files in the text boxes
        DisplayFiles(txtFiles, txtOutput)
        DisplayFiles(logFiles, logOutput)

    End Sub

    Private Sub DisplayFiles(files As List(Of String), textBox As TextBox)
        ' Display the matching files in the text box
        Dim output As String = ""
        For Each file As String In files
            output += file & Environment.NewLine
        Next
        textBox.Text = output
    End Sub

    Private Sub ExportToFile(files As List(Of String), filePath As String)
        Try
            ' Write the file paths to the text file
            Using writer As New StreamWriter(filePath)
                For Each file As String In files
                    writer.WriteLine(file)
                Next
            End Using
            MessageBox.Show("File paths exported successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error exporting file paths: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        ' Create a SaveFileDialog instance
        Dim saveFileDialog As New SaveFileDialog()

        ' Set properties for SaveFileDialog
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveFileDialog.Title = "Export File Paths"
        saveFileDialog.FileName = "ExportedFilePaths.txt"
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Show the SaveFileDialog
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the file paths from the text boxes
            Dim txtFilePaths As New List(Of String)(txtOutput.Lines)
            Dim logFilePaths As New List(Of String)(logOutput.Lines)

            ' Export the file paths to the selected file
            ExportToFile(txtFilePaths, saveFileDialog.FileName)
            ExportToFile(logFilePaths, saveFileDialog.FileName)
        End If
    End Sub
End Class
