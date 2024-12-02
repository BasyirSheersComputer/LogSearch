<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogSearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TitleLabel = New Label()
        SearchBtn = New Button()
        FilePath = New TextBox()
        FilePathLabel = New Label()
        SearchBoxLabel = New Label()
        SearchBox = New TextBox()
        txtOutput = New TextBox()
        logOutput = New TextBox()
        txtOutputLabel = New Label()
        logOutputLabel = New Label()
        ExportBtn = New Button()
        SuspendLayout()
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Location = New Point(334, 20)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(101, 21)
        TitleLabel.TabIndex = 0
        TitleLabel.Text = "Log Searcher"
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Location = New Point(633, 81)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(116, 74)
        SearchBtn.TabIndex = 1
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' FilePath
        ' 
        FilePath.Location = New Point(153, 83)
        FilePath.Name = "FilePath"
        FilePath.Size = New Size(440, 29)
        FilePath.TabIndex = 2
        ' 
        ' FilePathLabel
        ' 
        FilePathLabel.AutoSize = True
        FilePathLabel.Location = New Point(26, 86)
        FilePathLabel.Name = "FilePathLabel"
        FilePathLabel.Size = New Size(70, 21)
        FilePathLabel.TabIndex = 3
        FilePathLabel.Text = "Log Path"
        ' 
        ' SearchBoxLabel
        ' 
        SearchBoxLabel.AutoSize = True
        SearchBoxLabel.Location = New Point(26, 134)
        SearchBoxLabel.Name = "SearchBoxLabel"
        SearchBoxLabel.Size = New Size(71, 21)
        SearchBoxLabel.TabIndex = 4
        SearchBoxLabel.Text = "Keyword"
        ' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(153, 131)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(216, 29)
        SearchBox.TabIndex = 5
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(26, 246)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.Size = New Size(343, 160)
        txtOutput.TabIndex = 6
        ' 
        ' logOutput
        ' 
        logOutput.Location = New Point(406, 246)
        logOutput.Multiline = True
        logOutput.Name = "logOutput"
        logOutput.Size = New Size(343, 160)
        logOutput.TabIndex = 7
        ' 
        ' txtOutputLabel
        ' 
        txtOutputLabel.AutoSize = True
        txtOutputLabel.Location = New Point(26, 213)
        txtOutputLabel.Name = "txtOutputLabel"
        txtOutputLabel.Size = New Size(83, 21)
        txtOutputLabel.TabIndex = 8
        txtOutputLabel.Text = ".txt Output"
        ' 
        ' logOutputLabel
        ' 
        logOutputLabel.AutoSize = True
        logOutputLabel.Location = New Point(406, 213)
        logOutputLabel.Name = "logOutputLabel"
        logOutputLabel.Size = New Size(88, 21)
        logOutputLabel.TabIndex = 9
        logOutputLabel.Text = ".log Output"
        ' 
        ' ExportBtn
        ' 
        ExportBtn.Location = New Point(633, 412)
        ExportBtn.Name = "ExportBtn"
        ExportBtn.Size = New Size(116, 36)
        ExportBtn.TabIndex = 10
        ExportBtn.Text = "Export"
        ExportBtn.UseVisualStyleBackColor = True
        ' 
        ' LogSearchForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(783, 470)
        Controls.Add(ExportBtn)
        Controls.Add(logOutputLabel)
        Controls.Add(txtOutputLabel)
        Controls.Add(logOutput)
        Controls.Add(txtOutput)
        Controls.Add(SearchBox)
        Controls.Add(SearchBoxLabel)
        Controls.Add(FilePathLabel)
        Controls.Add(FilePath)
        Controls.Add(SearchBtn)
        Controls.Add(TitleLabel)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.Black
        Margin = New Padding(4)
        Name = "LogSearchForm"
        Text = "Log Searcher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents FilePath As TextBox
    Friend WithEvents FilePathLabel As Label
    Friend WithEvents SearchBoxLabel As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents logOutput As TextBox
    Friend WithEvents txtOutputLabel As Label
    Friend WithEvents logOutputLabel As Label
    Friend WithEvents ExportBtn As Button
End Class
