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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkMember = New System.Windows.Forms.CheckBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(160, 244)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtTotal.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 247)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total Barang"
        '
        'checkMember
        '
        Me.checkMember.AutoSize = True
        Me.checkMember.Location = New System.Drawing.Point(162, 167)
        Me.checkMember.Margin = New System.Windows.Forms.Padding(2)
        Me.checkMember.Name = "checkMember"
        Me.checkMember.Size = New System.Drawing.Size(63, 17)
        Me.checkMember.TabIndex = 17
        Me.checkMember.Text = "member"
        Me.checkMember.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.White
        Me.btnHitung.Location = New System.Drawing.Point(162, 204)
        Me.btnHitung.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(105, 24)
        Me.btnHitung.TabIndex = 16
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(160, 135)
        Me.txtJumlah.Margin = New System.Windows.Forms.Padding(2)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(107, 20)
        Me.txtJumlah.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Jumlah Barang"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(160, 101)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(107, 20)
        Me.txtHarga.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Harga Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Toko Buku Gudang Ilmu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "design by Yedi Risdianto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 338)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.checkMember)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents checkMember As System.Windows.Forms.CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
