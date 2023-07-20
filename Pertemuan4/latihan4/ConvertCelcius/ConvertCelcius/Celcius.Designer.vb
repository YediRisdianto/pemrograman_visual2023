<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCelcius
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
        Me.LabelCelcius = New System.Windows.Forms.Label()
        Me.LabelFahrenheit = New System.Windows.Forms.Label()
        Me.LabelReamur = New System.Windows.Forms.Label()
        Me.LabelKelvin = New System.Windows.Forms.Label()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelCelcius
        '
        Me.LabelCelcius.AutoSize = True
        Me.LabelCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCelcius.Location = New System.Drawing.Point(38, 47)
        Me.LabelCelcius.Name = "LabelCelcius"
        Me.LabelCelcius.Size = New System.Drawing.Size(57, 23)
        Me.LabelCelcius.TabIndex = 0
        Me.LabelCelcius.Text = "Celcius"
        '
        'LabelFahrenheit
        '
        Me.LabelFahrenheit.AutoSize = True
        Me.LabelFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFahrenheit.Location = New System.Drawing.Point(38, 129)
        Me.LabelFahrenheit.Name = "LabelFahrenheit"
        Me.LabelFahrenheit.Size = New System.Drawing.Size(79, 23)
        Me.LabelFahrenheit.TabIndex = 1
        Me.LabelFahrenheit.Text = "Fahrenheit"
        '
        'LabelReamur
        '
        Me.LabelReamur.AutoSize = True
        Me.LabelReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReamur.Location = New System.Drawing.Point(38, 170)
        Me.LabelReamur.Name = "LabelReamur"
        Me.LabelReamur.Size = New System.Drawing.Size(61, 23)
        Me.LabelReamur.TabIndex = 2
        Me.LabelReamur.Text = "Reamur"
        '
        'LabelKelvin
        '
        Me.LabelKelvin.AutoSize = True
        Me.LabelKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKelvin.Location = New System.Drawing.Point(38, 213)
        Me.LabelKelvin.Name = "LabelKelvin"
        Me.LabelKelvin.Size = New System.Drawing.Size(47, 23)
        Me.LabelKelvin.TabIndex = 3
        Me.LabelKelvin.Text = "Kelvin"
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(142, 40)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(100, 27)
        Me.txtCelcius.TabIndex = 4
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(142, 127)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 27)
        Me.txtFahrenheit.TabIndex = 5
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(142, 168)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(100, 27)
        Me.txtReamur.TabIndex = 6
        '
        'txtKelvin
        '
        Me.txtKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(142, 211)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(100, 27)
        Me.txtKelvin.TabIndex = 7
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(142, 83)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 32)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'FormCelcius
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 269)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.LabelKelvin)
        Me.Controls.Add(Me.LabelReamur)
        Me.Controls.Add(Me.LabelFahrenheit)
        Me.Controls.Add(Me.LabelCelcius)
        Me.Name = "FormCelcius"
        Me.Text = "Convert Celcius"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelCelcius As Label
    Friend WithEvents LabelFahrenheit As Label
    Friend WithEvents LabelReamur As Label
    Friend WithEvents LabelKelvin As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents btnConvert As Button
End Class
