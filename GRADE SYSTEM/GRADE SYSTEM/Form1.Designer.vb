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
        Me.gradeform_tbn = New System.Windows.Forms.Label()
        Me.math_label = New System.Windows.Forms.Label()
        Me.Evaluate_tbn = New System.Windows.Forms.Button()
        Me.Mathtxtbox_tbn = New System.Windows.Forms.TextBox()
        Me.Sciencetxtbox_tbn = New System.Windows.Forms.TextBox()
        Me.Englishtxtbox_tbn = New System.Windows.Forms.TextBox()
        Me.Science_Label = New System.Windows.Forms.Label()
        Me.English_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gradeform_tbn
        '
        Me.gradeform_tbn.AutoSize = True
        Me.gradeform_tbn.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeform_tbn.Location = New System.Drawing.Point(31, 24)
        Me.gradeform_tbn.Name = "gradeform_tbn"
        Me.gradeform_tbn.Size = New System.Drawing.Size(115, 17)
        Me.gradeform_tbn.TabIndex = 0
        Me.gradeform_tbn.Text = "GRADE FORM"
        '
        'math_label
        '
        Me.math_label.AutoSize = True
        Me.math_label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.math_label.Location = New System.Drawing.Point(42, 56)
        Me.math_label.Name = "math_label"
        Me.math_label.Size = New System.Drawing.Size(44, 16)
        Me.math_label.TabIndex = 1
        Me.math_label.Text = "Math"
        '
        'Evaluate_tbn
        '
        Me.Evaluate_tbn.BackColor = System.Drawing.Color.SeaShell
        Me.Evaluate_tbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evaluate_tbn.Location = New System.Drawing.Point(117, 272)
        Me.Evaluate_tbn.Name = "Evaluate_tbn"
        Me.Evaluate_tbn.Size = New System.Drawing.Size(101, 25)
        Me.Evaluate_tbn.TabIndex = 2
        Me.Evaluate_tbn.Text = "EVALUATE"
        Me.Evaluate_tbn.UseVisualStyleBackColor = False
        '
        'Mathtxtbox_tbn
        '
        Me.Mathtxtbox_tbn.Location = New System.Drawing.Point(52, 72)
        Me.Mathtxtbox_tbn.Name = "Mathtxtbox_tbn"
        Me.Mathtxtbox_tbn.Size = New System.Drawing.Size(238, 20)
        Me.Mathtxtbox_tbn.TabIndex = 3
        '
        'Sciencetxtbox_tbn
        '
        Me.Sciencetxtbox_tbn.Location = New System.Drawing.Point(52, 146)
        Me.Sciencetxtbox_tbn.Name = "Sciencetxtbox_tbn"
        Me.Sciencetxtbox_tbn.Size = New System.Drawing.Size(238, 20)
        Me.Sciencetxtbox_tbn.TabIndex = 4
        '
        'Englishtxtbox_tbn
        '
        Me.Englishtxtbox_tbn.Location = New System.Drawing.Point(52, 218)
        Me.Englishtxtbox_tbn.Name = "Englishtxtbox_tbn"
        Me.Englishtxtbox_tbn.Size = New System.Drawing.Size(238, 20)
        Me.Englishtxtbox_tbn.TabIndex = 5
        '
        'Science_Label
        '
        Me.Science_Label.AutoSize = True
        Me.Science_Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Science_Label.Location = New System.Drawing.Point(42, 130)
        Me.Science_Label.Name = "Science_Label"
        Me.Science_Label.Size = New System.Drawing.Size(64, 16)
        Me.Science_Label.TabIndex = 6
        Me.Science_Label.Text = "Science"
        '
        'English_Label
        '
        Me.English_Label.AutoSize = True
        Me.English_Label.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.English_Label.Location = New System.Drawing.Point(42, 202)
        Me.English_Label.Name = "English_Label"
        Me.English_Label.Size = New System.Drawing.Size(60, 16)
        Me.English_Label.TabIndex = 7
        Me.English_Label.Text = "English"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(363, 353)
        Me.Controls.Add(Me.English_Label)
        Me.Controls.Add(Me.Science_Label)
        Me.Controls.Add(Me.Englishtxtbox_tbn)
        Me.Controls.Add(Me.Sciencetxtbox_tbn)
        Me.Controls.Add(Me.Mathtxtbox_tbn)
        Me.Controls.Add(Me.Evaluate_tbn)
        Me.Controls.Add(Me.math_label)
        Me.Controls.Add(Me.gradeform_tbn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gradeform_tbn As Label
    Friend WithEvents math_label As Label
    Friend WithEvents Evaluate_tbn As Button
    Friend WithEvents Mathtxtbox_tbn As TextBox
    Friend WithEvents Sciencetxtbox_tbn As TextBox
    Friend WithEvents Englishtxtbox_tbn As TextBox
    Friend WithEvents Science_Label As Label
    Friend WithEvents English_Label As Label
End Class
