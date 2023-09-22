<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Open_Note_Btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line_Number_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchingContent_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Read_LineText_By_LineNumber_Btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Start_Searching_Button = New System.Windows.Forms.Button()
        Me.EventLog_ListBox = New System.Windows.Forms.ListBox()
        Me.Read_LineCount_Button = New System.Windows.Forms.Button()
        Me.Line_Number_Counter_Label = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "輸入搜尋內容 : "
        '
        'Open_Note_Btn
        '
        Me.Open_Note_Btn.Location = New System.Drawing.Point(128, 24)
        Me.Open_Note_Btn.Name = "Open_Note_Btn"
        Me.Open_Note_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Open_Note_Btn.TabIndex = 1
        Me.Open_Note_Btn.Text = "記事本"
        Me.Open_Note_Btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(536, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "第"
        '
        'Line_Number_NumericUpDown
        '
        Me.Line_Number_NumericUpDown.Location = New System.Drawing.Point(566, 24)
        Me.Line_Number_NumericUpDown.Name = "Line_Number_NumericUpDown"
        Me.Line_Number_NumericUpDown.Size = New System.Drawing.Size(82, 27)
        Me.Line_Number_NumericUpDown.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "內容 : @"
        '
        'SearchingContent_TextBox
        '
        Me.SearchingContent_TextBox.Location = New System.Drawing.Point(83, 73)
        Me.SearchingContent_TextBox.Name = "SearchingContent_TextBox"
        Me.SearchingContent_TextBox.Size = New System.Drawing.Size(273, 27)
        Me.SearchingContent_TextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL HK"
        '
        'Read_LineText_By_LineNumber_Btn
        '
        Me.Read_LineText_By_LineNumber_Btn.Location = New System.Drawing.Point(436, 24)
        Me.Read_LineText_By_LineNumber_Btn.Name = "Read_LineText_By_LineNumber_Btn"
        Me.Read_LineText_By_LineNumber_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Read_LineText_By_LineNumber_Btn.TabIndex = 7
        Me.Read_LineText_By_LineNumber_Btn.Text = "讀取"
        Me.Read_LineText_By_LineNumber_Btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "行"
        '
        'Start_Searching_Button
        '
        Me.Start_Searching_Button.Location = New System.Drawing.Point(584, 71)
        Me.Start_Searching_Button.Name = "Start_Searching_Button"
        Me.Start_Searching_Button.Size = New System.Drawing.Size(94, 29)
        Me.Start_Searching_Button.TabIndex = 9
        Me.Start_Searching_Button.Text = "開始搜尋"
        Me.Start_Searching_Button.UseVisualStyleBackColor = True
        '
        'EventLog_ListBox
        '
        Me.EventLog_ListBox.FormattingEnabled = True
        Me.EventLog_ListBox.ItemHeight = 19
        Me.EventLog_ListBox.Location = New System.Drawing.Point(12, 141)
        Me.EventLog_ListBox.Name = "EventLog_ListBox"
        Me.EventLog_ListBox.Size = New System.Drawing.Size(527, 289)
        Me.EventLog_ListBox.TabIndex = 10
        '
        'Read_LineCount_Button
        '
        Me.Read_LineCount_Button.Location = New System.Drawing.Point(228, 24)
        Me.Read_LineCount_Button.Name = "Read_LineCount_Button"
        Me.Read_LineCount_Button.Size = New System.Drawing.Size(94, 29)
        Me.Read_LineCount_Button.TabIndex = 11
        Me.Read_LineCount_Button.Text = "讀取行數"
        Me.Read_LineCount_Button.UseVisualStyleBackColor = True
        '
        'Line_Number_Counter_Label
        '
        Me.Line_Number_Counter_Label.AutoSize = True
        Me.Line_Number_Counter_Label.Location = New System.Drawing.Point(328, 29)
        Me.Line_Number_Counter_Label.Name = "Line_Number_Counter_Label"
        Me.Line_Number_Counter_Label.Size = New System.Drawing.Size(67, 19)
        Me.Line_Number_Counter_Label.TabIndex = 12
        Me.Line_Number_Counter_Label.Text = "共N/A行"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(515, 73)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(59, 27)
        Me.NumericUpDown1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "延遲:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Line_Number_Counter_Label)
        Me.Controls.Add(Me.Read_LineCount_Button)
        Me.Controls.Add(Me.EventLog_ListBox)
        Me.Controls.Add(Me.Start_Searching_Button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Read_LineText_By_LineNumber_Btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SearchingContent_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Line_Number_NumericUpDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Open_Note_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Open_Note_Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Line_Number_NumericUpDown As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents SearchingContent_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Read_LineText_By_LineNumber_Btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Start_Searching_Button As Button
    Friend WithEvents EventLog_ListBox As ListBox
    Friend WithEvents Read_LineCount_Button As Button
    Friend WithEvents Line_Number_Counter_Label As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label7 As Label
End Class
