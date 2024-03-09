<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Login_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(98, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(380, 26)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "HELLO MADLANG PEOPLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "email or username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "USER LOGIN"
        '
        'Label6
        '
        Me.Label6.Image = Global.test_application.My.Resources.Resources.password_FILL0_wght400_GRAD0_opsz24
        Me.Label6.Location = New System.Drawing.Point(62, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 22)
        Me.Label6.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Image = Global.test_application.My.Resources.Resources.digital_wellbeing_FILL0_wght400_GRAD0_opsz24
        Me.Label5.Location = New System.Drawing.Point(72, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 27)
        Me.Label5.TabIndex = 8
        '
        'Login_btn
        '
        Me.Login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login_btn.Font = New System.Drawing.Font("Gadugi", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_btn.Image = Global.test_application.My.Resources.Resources.login_FILL0_wght400_GRAD0_opsz24
        Me.Login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Login_btn.Location = New System.Drawing.Point(249, 252)
        Me.Login_btn.Name = "Login_btn"
        Me.Login_btn.Size = New System.Drawing.Size(73, 28)
        Me.Login_btn.TabIndex = 2
        Me.Login_btn.Text = "Login"
        Me.Login_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Login_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(562, 375)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Login_btn)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Login_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
