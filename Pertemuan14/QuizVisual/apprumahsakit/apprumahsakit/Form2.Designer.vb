<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJk = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNrp = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(361, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(361, 81)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(361, 52)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "NRP"
        '
        'txtJk
        '
        Me.txtJk.Location = New System.Drawing.Point(125, 100)
        Me.txtJk.Name = "txtJk"
        Me.txtJk.Size = New System.Drawing.Size(200, 20)
        Me.txtJk.TabIndex = 28
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(125, 74)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 27
        '
        'txtNrp
        '
        Me.txtNrp.Location = New System.Drawing.Point(125, 48)
        Me.txtNrp.Name = "txtNrp"
        Me.txtNrp.Size = New System.Drawing.Size(200, 20)
        Me.txtNrp.TabIndex = 26
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(46, 227)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(390, 150)
        Me.dgvData.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(125, 152)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 20)
        Me.txtAlamat.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Kota"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(125, 178)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(200, 20)
        Me.txtKota.TabIndex = 38
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(125, 126)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(200, 20)
        Me.txtTanggal.TabIndex = 40
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 415)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJk)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNrp)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJk As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNrp As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKota As TextBox
    Friend WithEvents txtTanggal As TextBox
End Class
