<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBls = New System.Windows.Forms.Label()
        Me.lblBlsstat = New System.Windows.Forms.Label()
        Me.lblBws = New System.Windows.Forms.Label()
        Me.lblBwsstat = New System.Windows.Forms.Label()
        Me.lblWl = New System.Windows.Forms.Label()
        Me.lblWlstat = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblBls)
        Me.GroupBox1.Controls.Add(Me.lblBlsstat)
        Me.GroupBox1.Controls.Add(Me.lblBws)
        Me.GroupBox1.Controls.Add(Me.lblBwsstat)
        Me.GroupBox1.Controls.Add(Me.lblWl)
        Me.GroupBox1.Controls.Add(Me.lblWlstat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 423)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CURRENT SESSION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBls
        '
        Me.lblBls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBls.Location = New System.Drawing.Point(11, 307)
        Me.lblBls.Name = "lblBls"
        Me.lblBls.Size = New System.Drawing.Size(219, 58)
        Me.lblBls.TabIndex = 0
        Me.lblBls.Text = "BIGGEST LOSING STREAK"
        Me.lblBls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlsstat
        '
        Me.lblBlsstat.AutoSize = True
        Me.lblBlsstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlsstat.Location = New System.Drawing.Point(84, 365)
        Me.lblBlsstat.Name = "lblBlsstat"
        Me.lblBlsstat.Size = New System.Drawing.Size(0, 24)
        Me.lblBlsstat.TabIndex = 0
        Me.lblBlsstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBws
        '
        Me.lblBws.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBws.Location = New System.Drawing.Point(6, 179)
        Me.lblBws.Name = "lblBws"
        Me.lblBws.Size = New System.Drawing.Size(224, 59)
        Me.lblBws.TabIndex = 0
        Me.lblBws.Text = "BIGGEST WIN STREAK"
        Me.lblBws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBwsstat
        '
        Me.lblBwsstat.AutoSize = True
        Me.lblBwsstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBwsstat.Location = New System.Drawing.Point(84, 238)
        Me.lblBwsstat.Name = "lblBwsstat"
        Me.lblBwsstat.Size = New System.Drawing.Size(0, 24)
        Me.lblBwsstat.TabIndex = 0
        Me.lblBwsstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWl
        '
        Me.lblWl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWl.Location = New System.Drawing.Point(6, 90)
        Me.lblWl.Name = "lblWl"
        Me.lblWl.Size = New System.Drawing.Size(224, 30)
        Me.lblWl.TabIndex = 0
        Me.lblWl.Text = "WIN/LOSE RATE"
        Me.lblWl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWlstat
        '
        Me.lblWlstat.AutoSize = True
        Me.lblWlstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWlstat.Location = New System.Drawing.Point(84, 136)
        Me.lblWlstat.Name = "lblWlstat"
        Me.lblWlstat.Size = New System.Drawing.Size(0, 24)
        Me.lblWlstat.TabIndex = 0
        Me.lblWlstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(260, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBls As Label
    Friend WithEvents lblBlsstat As Label
    Friend WithEvents lblBwsstat As Label
    Friend WithEvents lblWl As Label
    Friend WithEvents lblWlstat As Label
    Friend WithEvents lblBws As Label
    Friend WithEvents Label1 As Label
End Class
