<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PilihBagian
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
        Me.Pengambilan = New System.Windows.Forms.Button()
        Me.Server = New System.Windows.Forms.Button()
        Me.CallAntrian = New System.Windows.Forms.Button()
        Me.ViewAntrian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(690, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Fungsi Untuk Bagian Ini"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pengambilan
        '
        Me.Pengambilan.Location = New System.Drawing.Point(20, 103)
        Me.Pengambilan.Name = "Pengambilan"
        Me.Pengambilan.Size = New System.Drawing.Size(133, 117)
        Me.Pengambilan.TabIndex = 1
        Me.Pengambilan.Text = "Pengambilan Tiket Antrian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Pengambilan.UseVisualStyleBackColor = True
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(193, 103)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(133, 117)
        Me.Server.TabIndex = 2
        Me.Server.Text = "Admin Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Server.UseVisualStyleBackColor = True
        '
        'CallAntrian
        '
        Me.CallAntrian.Location = New System.Drawing.Point(364, 103)
        Me.CallAntrian.Name = "CallAntrian"
        Me.CallAntrian.Size = New System.Drawing.Size(133, 117)
        Me.CallAntrian.TabIndex = 3
        Me.CallAntrian.Text = "Call Antrian"
        Me.CallAntrian.UseVisualStyleBackColor = True
        '
        'ViewAntrian
        '
        Me.ViewAntrian.Location = New System.Drawing.Point(531, 103)
        Me.ViewAntrian.Name = "ViewAntrian"
        Me.ViewAntrian.Size = New System.Drawing.Size(133, 117)
        Me.ViewAntrian.TabIndex = 4
        Me.ViewAntrian.Text = "View Antrian"
        Me.ViewAntrian.UseVisualStyleBackColor = True
        '
        'PilihBagian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 264)
        Me.Controls.Add(Me.ViewAntrian)
        Me.Controls.Add(Me.CallAntrian)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.Pengambilan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PilihBagian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Bagian"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Pengambilan As Button
    Friend WithEvents Server As Button
    Friend WithEvents CallAntrian As Button
    Friend WithEvents ViewAntrian As Button
End Class
