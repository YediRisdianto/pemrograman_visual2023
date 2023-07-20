<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(145, 157)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(75, 23)
        Me.btnForm2.TabIndex = 6
        Me.btnForm2.Text = "form-2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnForm1
        '
        Me.btnForm1.Location = New System.Drawing.Point(64, 157)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(75, 23)
        Me.btnForm1.TabIndex = 5
        Me.btnForm1.Text = "form-1"
        Me.btnForm1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Form-3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 39)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Yedi Risdianto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20051033" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R4"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnForm1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnForm2 As Button
    Friend WithEvents btnForm1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
