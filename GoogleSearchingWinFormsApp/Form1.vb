Imports System.IO
Public Class Form1

    Dim filePath As String = "keyword.txt"


    Private Sub Open_Note_Btn_Click(sender As Object, e As EventArgs) Handles Open_Note_Btn.Click

        If File.Exists(filePath) Then
            Dim fileContent As String = File.ReadAllText(filePath)
        Else
            Dim fs As FileStream = File.Create(filePath)
            fs.Close()
        End If

        Process.Start("explorer.exe", filePath)

    End Sub

    Private Sub Read_LineText_By_LineNumber_Btn_Click(sender As Object, e As EventArgs) Handles Read_LineText_By_LineNumber_Btn.Click
        Dim selected_line_number = Line_Number_NumericUpDown.Value

        Using reader As New StreamReader(filePath)
            Dim line_counter = 1
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line_counter = selected_line_number Then
                    SearchingContent_TextBox.Text = line
                End If
                line_counter += 1
            End While
        End Using
    End Sub

    Private Sub Read_LineCount_Button_Click(sender As Object, e As EventArgs) Handles Read_LineCount_Button.Click
        Dim line_counter = 0
        Using reader As New StreamReader(filePath)

            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                line_counter += 1
            End While
        End Using

        Line_Number_Counter_Label.Text = "共" & line_counter & "行"
    End Sub

    Private Sub Start_Searching_Button_Click(sender As Object, e As EventArgs) Handles Start_Searching_Button.Click
        EventLog_ListBox.Items.Add(Now.ToString("yyyy-MM-dd HH:mm:ss") + " - 開始搜尋")
    End Sub
End Class
