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
        Me.Evaluate_btn = New System.Windows.Forms.Button()
        Me.Age_txtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Evaluate_btn
        '
        Me.Evaluate_btn.Location = New System.Drawing.Point(158, 110)
        Me.Evaluate_btn.Name = "Evaluate_btn"
        Me.Evaluate_btn.Size = New System.Drawing.Size(74, 27)
        Me.Evaluate_btn.TabIndex = 0
        Me.Evaluate_btn.Text = "Evaluate"
        Me.Evaluate_btn.UseVisualStyleBackColor = True
        '
        'Age_txtbox
        '
        Me.Age_txtbox.Location = New System.Drawing.Point(29, 65)
        Me.Age_txtbox.Name = "Age_txtbox"
        Me.Age_txtbox.Size = New System.Drawing.Size(330, 20)
        Me.Age_txtbox.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 359)
        Me.Controls.Add(Me.Age_txtbox)
        Me.Controls.Add(Me.Evaluate_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Evaluate_btn As Button
    Friend WithEvents Age_txtbox As TextBox
End Class
