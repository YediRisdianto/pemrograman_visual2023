<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FahrenheitToReamur
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 46)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Konversi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fahrenheit To Reamur"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(118, 147)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(126, 26)
        Me.btnConvert.TabIndex = 11
        Me.btnConvert.Text = "convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fahrenheit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Reamur"
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(118, 191)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(126, 27)
        Me.txtReamur.TabIndex = 8
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(118, 104)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(126, 27)
        Me.txtFahrenheit.TabIndex = 7
        '
        'FahrenheitToReamur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Name = "FahrenheitToReamur"
        Me.Text = "Fahrenheit To Reamur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtFahrenheit As TextBox
End Class
