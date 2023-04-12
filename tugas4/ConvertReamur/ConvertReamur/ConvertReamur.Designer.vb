<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertReamur
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.LabelKelvin = New System.Windows.Forms.Label()
        Me.LabelFahrenheit = New System.Windows.Forms.Label()
        Me.LabelCelcius = New System.Windows.Forms.Label()
        Me.LabelReamur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(144, 80)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 32)
        Me.btnConvert.TabIndex = 26
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtKelvin
        '
        Me.txtKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(144, 208)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(100, 27)
        Me.txtKelvin.TabIndex = 25
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(144, 165)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 27)
        Me.txtFahrenheit.TabIndex = 24
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(144, 124)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(100, 27)
        Me.txtCelcius.TabIndex = 23
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(144, 37)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(100, 27)
        Me.txtReamur.TabIndex = 22
        '
        'LabelKelvin
        '
        Me.LabelKelvin.AutoSize = True
        Me.LabelKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKelvin.Location = New System.Drawing.Point(40, 210)
        Me.LabelKelvin.Name = "LabelKelvin"
        Me.LabelKelvin.Size = New System.Drawing.Size(47, 23)
        Me.LabelKelvin.TabIndex = 21
        Me.LabelKelvin.Text = "Kelvin"
        '
        'LabelFahrenheit
        '
        Me.LabelFahrenheit.AutoSize = True
        Me.LabelFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFahrenheit.Location = New System.Drawing.Point(40, 167)
        Me.LabelFahrenheit.Name = "LabelFahrenheit"
        Me.LabelFahrenheit.Size = New System.Drawing.Size(79, 23)
        Me.LabelFahrenheit.TabIndex = 20
        Me.LabelFahrenheit.Text = "Fahrenheit"
        '
        'LabelCelcius
        '
        Me.LabelCelcius.AutoSize = True
        Me.LabelCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCelcius.Location = New System.Drawing.Point(40, 126)
        Me.LabelCelcius.Name = "LabelCelcius"
        Me.LabelCelcius.Size = New System.Drawing.Size(57, 23)
        Me.LabelCelcius.TabIndex = 19
        Me.LabelCelcius.Text = "Celcius"
        '
        'LabelReamur
        '
        Me.LabelReamur.AutoSize = True
        Me.LabelReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReamur.Location = New System.Drawing.Point(40, 40)
        Me.LabelReamur.Name = "LabelReamur"
        Me.LabelReamur.Size = New System.Drawing.Size(61, 23)
        Me.LabelReamur.TabIndex = 18
        Me.LabelReamur.Text = "Reamur"
        '
        'ConvertReamur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 272)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.LabelKelvin)
        Me.Controls.Add(Me.LabelFahrenheit)
        Me.Controls.Add(Me.LabelCelcius)
        Me.Controls.Add(Me.LabelReamur)
        Me.Name = "ConvertReamur"
        Me.Text = "Convert Reamur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents LabelKelvin As Label
    Friend WithEvents LabelFahrenheit As Label
    Friend WithEvents LabelCelcius As Label
    Friend WithEvents LabelReamur As Label
End Class
