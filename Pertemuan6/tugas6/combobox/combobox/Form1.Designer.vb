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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSisa = New System.Windows.Forms.TextBox()
        Me.txtHitung = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtUKT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKodeProdi = New System.Windows.Forms.ComboBox()
        Me.labelProdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "design by Yedi Risdianto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Sisa"
        '
        'txtSisa
        '
        Me.txtSisa.Location = New System.Drawing.Point(125, 254)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Size = New System.Drawing.Size(144, 20)
        Me.txtSisa.TabIndex = 21
        '
        'txtHitung
        '
        Me.txtHitung.Location = New System.Drawing.Point(125, 211)
        Me.txtHitung.Name = "txtHitung"
        Me.txtHitung.Size = New System.Drawing.Size(121, 23)
        Me.txtHitung.TabIndex = 20
        Me.txtHitung.Text = "Hitung"
        Me.txtHitung.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Bayar"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(125, 170)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(144, 20)
        Me.txtBayar.TabIndex = 18
        '
        'txtUKT
        '
        Me.txtUKT.Location = New System.Drawing.Point(125, 128)
        Me.txtUKT.Name = "txtUKT"
        Me.txtUKT.Size = New System.Drawing.Size(144, 20)
        Me.txtUKT.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "UKT"
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(125, 89)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(144, 20)
        Me.txtProdi.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nama Prodi"
        '
        'cmbKodeProdi
        '
        Me.cmbKodeProdi.FormattingEnabled = True
        Me.cmbKodeProdi.Location = New System.Drawing.Point(125, 50)
        Me.cmbKodeProdi.Name = "cmbKodeProdi"
        Me.cmbKodeProdi.Size = New System.Drawing.Size(121, 21)
        Me.cmbKodeProdi.TabIndex = 13
        '
        'labelProdi
        '
        Me.labelProdi.AutoSize = True
        Me.labelProdi.Location = New System.Drawing.Point(44, 53)
        Me.labelProdi.Name = "labelProdi"
        Me.labelProdi.Size = New System.Drawing.Size(59, 13)
        Me.labelProdi.TabIndex = 12
        Me.labelProdi.Text = "Kode Prodi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSisa)
        Me.Controls.Add(Me.txtHitung)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtUKT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbKodeProdi)
        Me.Controls.Add(Me.labelProdi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSisa As TextBox
    Friend WithEvents txtHitung As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents txtUKT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbKodeProdi As System.Windows.Forms.ComboBox
    Friend WithEvents labelProdi As Label
End Class
