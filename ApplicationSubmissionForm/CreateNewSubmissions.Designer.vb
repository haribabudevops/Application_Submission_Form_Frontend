<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSubmissions
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
        components = New ComponentModel.Container()
        Label2 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Timer1 = New Timer(components)
        TextBox4 = New TextBox()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(92, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(621, 37)
        Label2.TabIndex = 1
        Label2.Text = "P S Hari Babu, Slidely Task 2 - Create Submissions"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(92, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 30)
        Label5.TabIndex = 9
        Label5.Text = "Github Link For Task 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F)
        Label4.Location = New Point(92, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 30)
        Label4.TabIndex = 8
        Label4.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
        Label3.Location = New Point(92, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 30)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(92, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 30)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(490, 99)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(223, 23)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(490, 143)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(223, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(490, 186)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(223, 23)
        TextBox3.TabIndex = 13
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(490, 231)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(223, 23)
        TextBox4.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(92, 301)
        Button1.Name = "Button1"
        Button1.Size = New Size(319, 47)
        Button1.TabIndex = 20
        Button1.Text = "TOGGLE STOPWATCH"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.HideSelection = False
        TextBox5.Location = New Point(524, 314)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(169, 23)
        TextBox5.TabIndex = 22
        TextBox5.TabStop = False
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(282, 374)
        Button2.Name = "Button2"
        Button2.Size = New Size(264, 48)
        Button2.TabIndex = 23
        Button2.Text = "SUBMIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CreateNewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "CreateNewSubmissions"
        Text = "Create New Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
End Class
