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
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.cbBidang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPermintaan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbTunai = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbCek = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbGiro = New System.Windows.Forms.RadioButton()
        Me.tbKeperluan = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.Tbbentuk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(11, 118)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(32, 20)
        Me.TBID.TabIndex = 29
        '
        'btUpdate
        '
        Me.btUpdate.Location = New System.Drawing.Point(198, 242)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btUpdate.TabIndex = 28
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(102, 243)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 27
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'cbBidang
        '
        Me.cbBidang.FormattingEnabled = True
        Me.cbBidang.Items.AddRange(New Object() {"Akademik", "Keuangan", "ICT"})
        Me.cbBidang.Location = New System.Drawing.Point(102, 39)
        Me.cbBidang.Name = "cbBidang"
        Me.cbBidang.Size = New System.Drawing.Size(121, 21)
        Me.cbBidang.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Keperluan"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(102, 12)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(171, 20)
        Me.tbNama.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Bentuk dana"
        '
        'tbPermintaan
        '
        Me.tbPermintaan.Location = New System.Drawing.Point(102, 66)
        Me.tbPermintaan.Name = "tbPermintaan"
        Me.tbPermintaan.Size = New System.Drawing.Size(171, 20)
        Me.tbPermintaan.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Jml Permintaan"
        '
        'rbTunai
        '
        Me.rbTunai.AutoSize = True
        Me.rbTunai.Location = New System.Drawing.Point(102, 94)
        Me.rbTunai.Name = "rbTunai"
        Me.rbTunai.Size = New System.Drawing.Size(52, 17)
        Me.rbTunai.TabIndex = 18
        Me.rbTunai.TabStop = True
        Me.rbTunai.Text = "Tunai"
        Me.rbTunai.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Bidang"
        '
        'rbCek
        '
        Me.rbCek.AutoSize = True
        Me.rbCek.Location = New System.Drawing.Point(102, 118)
        Me.rbCek.Name = "rbCek"
        Me.rbCek.Size = New System.Drawing.Size(72, 17)
        Me.rbCek.TabIndex = 19
        Me.rbCek.TabStop = True
        Me.rbCek.Text = "Cek Bank"
        Me.rbCek.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nama Pelaksana"
        '
        'rbGiro
        '
        Me.rbGiro.AutoSize = True
        Me.rbGiro.Location = New System.Drawing.Point(102, 142)
        Me.rbGiro.Name = "rbGiro"
        Me.rbGiro.Size = New System.Drawing.Size(44, 17)
        Me.rbGiro.TabIndex = 20
        Me.rbGiro.TabStop = True
        Me.rbGiro.Text = "Giro"
        Me.rbGiro.UseVisualStyleBackColor = True
        '
        'tbKeperluan
        '
        Me.tbKeperluan.Location = New System.Drawing.Point(102, 166)
        Me.tbKeperluan.Multiline = True
        Me.tbKeperluan.Name = "tbKeperluan"
        Me.tbKeperluan.Size = New System.Drawing.Size(171, 70)
        Me.tbKeperluan.TabIndex = 21
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(11, 309)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(417, 97)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 283)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker1.TabIndex = 31
        Me.DateTimePicker1.Value = New Date(2018, 10, 10, 0, 0, 0, 0)
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(102, 419)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 32
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(198, 419)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 33
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'Tbbentuk
        '
        Me.Tbbentuk.Location = New System.Drawing.Point(9, 205)
        Me.Tbbentuk.Name = "Tbbentuk"
        Me.Tbbentuk.Size = New System.Drawing.Size(54, 20)
        Me.Tbbentuk.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 454)
        Me.Controls.Add(Me.Tbbentuk)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.btUpdate)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.cbBidang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbPermintaan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbTunai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbCek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbGiro)
        Me.Controls.Add(Me.tbKeperluan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBID As System.Windows.Forms.TextBox
    Friend WithEvents btUpdate As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents cbBidang As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPermintaan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbTunai As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbCek As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbGiro As System.Windows.Forms.RadioButton
    Friend WithEvents tbKeperluan As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents btDelete As System.Windows.Forms.Button
    Friend WithEvents Tbbentuk As System.Windows.Forms.TextBox

End Class
