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
        Me.Delay_Sec_Between_Searching_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Delay_Sec_Between_Keyword_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Keyword_Delay_Sec_Label = New System.Windows.Forms.Label()
        Me.Max_Searching_Page_Limit_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Reveal_Searching_Result_Dir_Btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Searching_15Time_Delay_Sec_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Searching_15Time_Delay_Sec_Label = New System.Windows.Forms.Label()
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delay_Sec_Between_Searching_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delay_Sec_Between_Keyword_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Max_Searching_Page_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Searching_15Time_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(515, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "第"
        '
        'Line_Number_NumericUpDown
        '
        Me.Line_Number_NumericUpDown.Location = New System.Drawing.Point(545, 21)
        Me.Line_Number_NumericUpDown.Name = "Line_Number_NumericUpDown"
        Me.Line_Number_NumericUpDown.Size = New System.Drawing.Size(56, 27)
        Me.Line_Number_NumericUpDown.TabIndex = 3
        Me.Line_Number_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.Label4.Location = New System.Drawing.Point(362, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL HK"
        '
        'Read_LineText_By_LineNumber_Btn
        '
        Me.Read_LineText_By_LineNumber_Btn.Location = New System.Drawing.Point(419, 24)
        Me.Read_LineText_By_LineNumber_Btn.Name = "Read_LineText_By_LineNumber_Btn"
        Me.Read_LineText_By_LineNumber_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Read_LineText_By_LineNumber_Btn.TabIndex = 7
        Me.Read_LineText_By_LineNumber_Btn.Text = "讀取"
        Me.Read_LineText_By_LineNumber_Btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "行"
        '
        'Start_Searching_Button
        '
        Me.Start_Searching_Button.Location = New System.Drawing.Point(444, 192)
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
        Me.EventLog_ListBox.Location = New System.Drawing.Point(12, 236)
        Me.EventLog_ListBox.Name = "EventLog_ListBox"
        Me.EventLog_ListBox.Size = New System.Drawing.Size(619, 194)
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
        'Delay_Sec_Between_Searching_NumericUpDown
        '
        Me.Delay_Sec_Between_Searching_NumericUpDown.Location = New System.Drawing.Point(128, 191)
        Me.Delay_Sec_Between_Searching_NumericUpDown.Name = "Delay_Sec_Between_Searching_NumericUpDown"
        Me.Delay_Sec_Between_Searching_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Delay_Sec_Between_Searching_NumericUpDown.TabIndex = 13
        Me.Delay_Sec_Between_Searching_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "頁數間延遲 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "關鍵字間延遲 : "
        '
        'Delay_Sec_Between_Keyword_NumericUpDown
        '
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Location = New System.Drawing.Point(128, 158)
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Name = "Delay_Sec_Between_Keyword_NumericUpDown"
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Delay_Sec_Between_Keyword_NumericUpDown.TabIndex = 16
        Me.Delay_Sec_Between_Keyword_NumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Keyword_Delay_Sec_Label
        '
        Me.Keyword_Delay_Sec_Label.AutoSize = True
        Me.Keyword_Delay_Sec_Label.Location = New System.Drawing.Point(203, 166)
        Me.Keyword_Delay_Sec_Label.Name = "Keyword_Delay_Sec_Label"
        Me.Keyword_Delay_Sec_Label.Size = New System.Drawing.Size(78, 19)
        Me.Keyword_Delay_Sec_Label.TabIndex = 17
        Me.Keyword_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        '
        'Max_Searching_Page_Limit_NumericUpDown
        '
        Me.Max_Searching_Page_Limit_NumericUpDown.Location = New System.Drawing.Point(290, 191)
        Me.Max_Searching_Page_Limit_NumericUpDown.Name = "Max_Searching_Page_Limit_NumericUpDown"
        Me.Max_Searching_Page_Limit_NumericUpDown.Size = New System.Drawing.Size(56, 27)
        Me.Max_Searching_Page_Limit_NumericUpDown.TabIndex = 18
        Me.Max_Searching_Page_Limit_NumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "搜尋頁數 : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "頁"
        '
        'Reveal_Searching_Result_Dir_Btn
        '
        Me.Reveal_Searching_Result_Dir_Btn.Location = New System.Drawing.Point(544, 194)
        Me.Reveal_Searching_Result_Dir_Btn.Name = "Reveal_Searching_Result_Dir_Btn"
        Me.Reveal_Searching_Result_Dir_Btn.Size = New System.Drawing.Size(86, 29)
        Me.Reveal_Searching_Result_Dir_Btn.TabIndex = 21
        Me.Reveal_Searching_Result_Dir_Btn.Text = "搜尋結果"
        Me.Reveal_Searching_Result_Dir_Btn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "每15筆延遲 : "
        '
        'Searching_15Time_Delay_Sec_NumericUpDown
        '
        Me.Searching_15Time_Delay_Sec_NumericUpDown.Location = New System.Drawing.Point(127, 125)
        Me.Searching_15Time_Delay_Sec_NumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.Searching_15Time_Delay_Sec_NumericUpDown.Name = "Searching_15Time_Delay_Sec_NumericUpDown"
        Me.Searching_15Time_Delay_Sec_NumericUpDown.Size = New System.Drawing.Size(70, 27)
        Me.Searching_15Time_Delay_Sec_NumericUpDown.TabIndex = 23
        Me.Searching_15Time_Delay_Sec_NumericUpDown.Value = New Decimal(New Integer() {1800, 0, 0, 0})
        '
        'Searching_15Time_Delay_Sec_Label
        '
        Me.Searching_15Time_Delay_Sec_Label.AutoSize = True
        Me.Searching_15Time_Delay_Sec_Label.Location = New System.Drawing.Point(203, 133)
        Me.Searching_15Time_Delay_Sec_Label.Name = "Searching_15Time_Delay_Sec_Label"
        Me.Searching_15Time_Delay_Sec_Label.Size = New System.Drawing.Size(78, 19)
        Me.Searching_15Time_Delay_Sec_Label.TabIndex = 24
        Me.Searching_15Time_Delay_Sec_Label.Text = "剩餘 : 0 秒"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 444)
        Me.Controls.Add(Me.Searching_15Time_Delay_Sec_Label)
        Me.Controls.Add(Me.Searching_15Time_Delay_Sec_NumericUpDown)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Reveal_Searching_Result_Dir_Btn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Max_Searching_Page_Limit_NumericUpDown)
        Me.Controls.Add(Me.Keyword_Delay_Sec_Label)
        Me.Controls.Add(Me.Delay_Sec_Between_Keyword_NumericUpDown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Delay_Sec_Between_Searching_NumericUpDown)
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
        CType(Me.Delay_Sec_Between_Searching_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delay_Sec_Between_Keyword_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Max_Searching_Page_Limit_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Searching_15Time_Delay_Sec_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Delay_Sec_Between_Searching_NumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Delay_Sec_Between_Keyword_NumericUpDown As NumericUpDown
    Friend WithEvents Keyword_Delay_Sec_Label As Label
    Friend WithEvents Max_Searching_Page_Limit_NumericUpDown As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Reveal_Searching_Result_Dir_Btn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Searching_15Time_Delay_Sec_NumericUpDown As NumericUpDown
    Friend WithEvents Searching_15Time_Delay_Sec_Label As Label
End Class
