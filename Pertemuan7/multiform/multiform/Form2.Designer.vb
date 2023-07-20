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
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnForm3
        '
        Me.btnForm3.Location = New System.Drawing.Point(144, 155)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(75, 23)
        Me.btnForm3.TabIndex = 8
        Me.btnForm3.Text = "form-3"
        Me.btnForm3.UseVisualStyleBackColor = True
        '
        'btnForm1
        '
        Me.btnForm1.Location = New System.Drawing.Point(63, 155)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(75, 23)
        Me.btnForm1.TabIndex = 7
        Me.btnForm1.Text = "form-1"
        Me.btnForm1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Form-2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 39)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Yedi Risdianto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20051033" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R4"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.btnForm1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForm3 As Button
    Friend WithEvents btnForm1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
