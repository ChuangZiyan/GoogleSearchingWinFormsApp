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
        CType(Me.Line_Number_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "讀取 :  第"
        '
        'Line_Number_NumericUpDown
        '
        Me.Line_Number_NumericUpDown.Location = New System.Drawing.Point(87, 76)
        Me.Line_Number_NumericUpDown.Name = "Line_Number_NumericUpDown"
        Me.Line_Number_NumericUpDown.Size = New System.Drawing.Size(107, 27)
        Me.Line_Number_NumericUpDown.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "行，內容 : @"
        '
        'SearchingContent_TextBox
        '
        Me.SearchingContent_TextBox.Location = New System.Drawing.Point(301, 76)
        Me.SearchingContent_TextBox.Name = "SearchingContent_TextBox"
        Me.SearchingContent_TextBox.Size = New System.Drawing.Size(273, 27)
        Me.SearchingContent_TextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL HK"
        '
        'Read_LineText_By_LineNumber_Btn
        '
        Me.Read_LineText_By_LineNumber_Btn.Location = New System.Drawing.Point(663, 76)
        Me.Read_LineText_By_LineNumber_Btn.Name = "Read_LineText_By_LineNumber_Btn"
        Me.Read_LineText_By_LineNumber_Btn.Size = New System.Drawing.Size(94, 29)
        Me.Read_LineText_By_LineNumber_Btn.TabIndex = 7
        Me.Read_LineText_By_LineNumber_Btn.Text = "確定"
        Me.Read_LineText_By_LineNumber_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
