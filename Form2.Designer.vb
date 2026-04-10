<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(335, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 0
        Label1.Text = "SIGN IN"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(129, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(530, 27)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Full Name :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(129, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(530, 27)
        TextBox2.TabIndex = 2
        TextBox2.Text = "Email :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(129, 192)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(530, 27)
        TextBox3.TabIndex = 3
        TextBox3.Text = "Password :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(129, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(24, 23)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(159, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 6
        Label2.Text = "Remember me"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(506, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 20)
        Label3.TabIndex = 7
        Label3.Text = "Forget Password ?"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Button3.Location = New Point(340, 298)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 9
        Button3.Text = "OK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button4.Location = New Point(340, 386)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 10
        Button4.Text = "LOG IN"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(372, 353)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 20)
        Label4.TabIndex = 11
        Label4.Text = "OR"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
