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
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form-1"
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(61, 157)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(75, 23)
        Me.btnForm2.TabIndex = 2
        Me.btnForm2.Text = "form-2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnForm3
        '
        Me.btnForm3.Location = New System.Drawing.Point(142, 157)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(75, 23)
        Me.btnForm3.TabIndex = 3
        Me.btnForm3.Text = "form-3"
        Me.btnForm3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Yedi Risdianto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "20051033" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R4"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnForm2 As Button
    Friend WithEvents btnForm3 As Button
    Friend WithEvents Label2 As Label
End Class
