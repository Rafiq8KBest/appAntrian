<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatAntrian
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
        Me.Front = New System.Windows.Forms.Panel()
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Menuju2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Antrian2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Menuju1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Antrian1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Front.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Front
        '
        Me.Front.Controls.Add(Me.FormPanel)
        Me.Front.Controls.Add(Me.Label3)
        Me.Front.Controls.Add(Me.Menuju2)
        Me.Front.Controls.Add(Me.Label4)
        Me.Front.Controls.Add(Me.Antrian2)
        Me.Front.Controls.Add(Me.Label2)
        Me.Front.Controls.Add(Me.Menuju1)
        Me.Front.Controls.Add(Me.Label1)
        Me.Front.Controls.Add(Me.Antrian1)
        Me.Front.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Front.ForeColor = System.Drawing.Color.White
        Me.Front.Location = New System.Drawing.Point(0, 0)
        Me.Front.Name = "Front"
        Me.Front.Size = New System.Drawing.Size(1280, 720)
        Me.Front.TabIndex = 0
        '
        'FormPanel
        '
        Me.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormPanel.Controls.Add(Me.PictureBox1)
        Me.FormPanel.Location = New System.Drawing.Point(595, 36)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(638, 353)
        Me.FormPanel.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Menuju Ke" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menuju2
        '
        Me.Menuju2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Menuju2.Location = New System.Drawing.Point(238, 229)
        Me.Menuju2.Name = "Menuju2"
        Me.Menuju2.Size = New System.Drawing.Size(200, 160)
        Me.Menuju2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nomor Antrian"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Antrian2
        '
        Me.Antrian2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Antrian2.Location = New System.Drawing.Point(32, 229)
        Me.Antrian2.Name = "Antrian2"
        Me.Antrian2.Size = New System.Drawing.Size(200, 160)
        Me.Antrian2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menuju Ke" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menuju1
        '
        Me.Menuju1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Menuju1.Location = New System.Drawing.Point(238, 50)
        Me.Menuju1.Name = "Menuju1"
        Me.Menuju1.Size = New System.Drawing.Size(200, 160)
        Me.Menuju1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Antrian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Antrian1
        '
        Me.Antrian1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Antrian1.Location = New System.Drawing.Point(32, 50)
        Me.Antrian1.Name = "Antrian1"
        Me.Antrian1.Size = New System.Drawing.Size(200, 160)
        Me.Antrian1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(636, 351)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LihatAntrian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Front)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LihatAntrian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LihatAntrian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Front.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Front As Panel
    Friend WithEvents Antrian1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Menuju1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Menuju2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Antrian2 As Panel
    Friend WithEvents FormPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
