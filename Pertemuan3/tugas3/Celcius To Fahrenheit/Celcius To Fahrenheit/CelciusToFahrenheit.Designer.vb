<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelciusToFahrenheit
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
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(118, 98)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(126, 27)
        Me.txtCelcius.TabIndex = 0
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(118, 185)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(126, 27)
        Me.txtFahrenheit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Celcius"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(118, 141)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(126, 26)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 46)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Konversi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Celcius To Fahrenheit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CelciusToFahrenheit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelcius)
        Me.Name = "CelciusToFahrenheit"
        Me.Text = "Celcius Ke Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label3 As Label
End Class
