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
        Me.txnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbJk = New System.Windows.Forms.ComboBox()
        Me.cmbFk = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txnama
        '
        Me.txnama.Location = New System.Drawing.Point(113, 38)
        Me.txnama.Name = "txnama"
        Me.txnama.Size = New System.Drawing.Size(121, 20)
        Me.txnama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fakultas"
        '
        'cmbJk
        '
        Me.cmbJk.FormattingEnabled = True
        Me.cmbJk.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJk.Location = New System.Drawing.Point(113, 67)
        Me.cmbJk.Name = "cmbJk"
        Me.cmbJk.Size = New System.Drawing.Size(121, 21)
        Me.cmbJk.TabIndex = 4
        '
        'cmbFk
        '
        Me.cmbFk.FormattingEnabled = True
        Me.cmbFk.Items.AddRange(New Object() {"FAI", "FBS", "FIA", "FIK", "FT"})
        Me.cmbFk.Location = New System.Drawing.Point(113, 95)
        Me.cmbFk.Name = "cmbFk"
        Me.cmbFk.Size = New System.Drawing.Size(121, 21)
        Me.cmbFk.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tampilkan Pesan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbFk)
        Me.Controls.Add(Me.cmbJk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txnama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbJk As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFk As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
