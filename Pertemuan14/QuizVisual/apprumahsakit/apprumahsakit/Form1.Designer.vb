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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJk = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.txtSpesialis = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(299, 117)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(299, 88)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(299, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Spesialis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NIP"
        '
        'txtJk
        '
        Me.txtJk.Location = New System.Drawing.Point(130, 100)
        Me.txtJk.Name = "txtJk"
        Me.txtJk.Size = New System.Drawing.Size(129, 20)
        Me.txtJk.TabIndex = 16
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(130, 74)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(129, 20)
        Me.txtNama.TabIndex = 15
        '
        'txtNip
        '
        Me.txtNip.Location = New System.Drawing.Point(130, 48)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(129, 20)
        Me.txtNip.TabIndex = 14
        '
        'txtSpesialis
        '
        Me.txtSpesialis.Location = New System.Drawing.Point(130, 126)
        Me.txtSpesialis.Name = "txtSpesialis"
        Me.txtSpesialis.Size = New System.Drawing.Size(129, 20)
        Me.txtSpesialis.TabIndex = 13
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(51, 165)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(323, 150)
        Me.dgvData.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 372)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJk)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.txtSpesialis)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents txtNip As TextBox
    Friend WithEvents txtSpesialis As TextBox
    Friend WithEvents dgvData As DataGridView
End Class
