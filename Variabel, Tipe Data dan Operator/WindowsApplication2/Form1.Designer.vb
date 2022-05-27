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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TmBox = New System.Windows.Forms.TextBox()
        Me.MtBox = New System.Windows.Forms.TextBox()
        Me.HitBtn = New System.Windows.Forms.Button()
        Me.FtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NaBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tatap Muka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mid Test"
        '
        'TmBox
        '
        Me.TmBox.Location = New System.Drawing.Point(117, 30)
        Me.TmBox.Name = "TmBox"
        Me.TmBox.Size = New System.Drawing.Size(100, 20)
        Me.TmBox.TabIndex = 2
        '
        'MtBox
        '
        Me.MtBox.Location = New System.Drawing.Point(117, 65)
        Me.MtBox.Name = "MtBox"
        Me.MtBox.Size = New System.Drawing.Size(100, 20)
        Me.MtBox.TabIndex = 3
        '
        'HitBtn
        '
        Me.HitBtn.Location = New System.Drawing.Point(117, 145)
        Me.HitBtn.Name = "HitBtn"
        Me.HitBtn.Size = New System.Drawing.Size(47, 22)
        Me.HitBtn.TabIndex = 4
        Me.HitBtn.Text = "Hitung"
        Me.HitBtn.UseVisualStyleBackColor = True
        '
        'FtBox
        '
        Me.FtBox.Location = New System.Drawing.Point(117, 99)
        Me.FtBox.Name = "FtBox"
        Me.FtBox.Size = New System.Drawing.Size(100, 20)
        Me.FtBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Final Test"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nilai Akhir"
        '
        'NaBox
        '
        Me.NaBox.Location = New System.Drawing.Point(117, 190)
        Me.NaBox.Name = "NaBox"
        Me.NaBox.Size = New System.Drawing.Size(100, 20)
        Me.NaBox.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NaBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FtBox)
        Me.Controls.Add(Me.HitBtn)
        Me.Controls.Add(Me.MtBox)
        Me.Controls.Add(Me.TmBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hitung Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TmBox As System.Windows.Forms.TextBox
    Friend WithEvents MtBox As System.Windows.Forms.TextBox
    Friend WithEvents HitBtn As System.Windows.Forms.Button
    Friend WithEvents FtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NaBox As System.Windows.Forms.TextBox

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
