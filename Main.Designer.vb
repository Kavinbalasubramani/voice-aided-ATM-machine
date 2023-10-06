<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnfund = New System.Windows.Forms.Button()
        Me.dis1 = New System.Windows.Forms.Label()
        Me.btnbalance = New System.Windows.Forms.Button()
        Me.Btnwithdraw = New System.Windows.Forms.Button()
        Me.btnpin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), System.Drawing.Image)
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexit.Location = New System.Drawing.Point(607, 466)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 40)
        Me.btnexit.TabIndex = 110
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(150, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 105)
        Me.Panel1.TabIndex = 109
        '
        'btnfund
        '
        Me.btnfund.BackgroundImage = CType(resources.GetObject("btnfund.BackgroundImage"), System.Drawing.Image)
        Me.btnfund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfund.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfund.Location = New System.Drawing.Point(177, 241)
        Me.btnfund.Name = "btnfund"
        Me.btnfund.Size = New System.Drawing.Size(208, 93)
        Me.btnfund.TabIndex = 105
        Me.btnfund.UseVisualStyleBackColor = True
        '
        'dis1
        '
        Me.dis1.AutoSize = True
        Me.dis1.Location = New System.Drawing.Point(173, 216)
        Me.dis1.Name = "dis1"
        Me.dis1.Size = New System.Drawing.Size(39, 13)
        Me.dis1.TabIndex = 111
        Me.dis1.Text = "Label1"
        Me.dis1.Visible = False
        '
        'btnbalance
        '
        Me.btnbalance.BackgroundImage = CType(resources.GetObject("btnbalance.BackgroundImage"), System.Drawing.Image)
        Me.btnbalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbalance.Location = New System.Drawing.Point(816, 417)
        Me.btnbalance.Name = "btnbalance"
        Me.btnbalance.Size = New System.Drawing.Size(204, 92)
        Me.btnbalance.TabIndex = 108
        Me.btnbalance.UseVisualStyleBackColor = True
        '
        'Btnwithdraw
        '
        Me.Btnwithdraw.BackgroundImage = CType(resources.GetObject("Btnwithdraw.BackgroundImage"), System.Drawing.Image)
        Me.Btnwithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnwithdraw.Location = New System.Drawing.Point(816, 241)
        Me.Btnwithdraw.Name = "Btnwithdraw"
        Me.Btnwithdraw.Size = New System.Drawing.Size(204, 93)
        Me.Btnwithdraw.TabIndex = 106
        Me.Btnwithdraw.UseVisualStyleBackColor = True
        '
        'btnpin
        '
        Me.btnpin.BackgroundImage = CType(resources.GetObject("btnpin.BackgroundImage"), System.Drawing.Image)
        Me.btnpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpin.Location = New System.Drawing.Point(177, 417)
        Me.btnpin.Name = "btnpin"
        Me.btnpin.Size = New System.Drawing.Size(208, 89)
        Me.btnpin.TabIndex = 107
        Me.btnpin.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 556)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnfund)
        Me.Controls.Add(Me.dis1)
        Me.Controls.Add(Me.btnbalance)
        Me.Controls.Add(Me.Btnwithdraw)
        Me.Controls.Add(Me.btnpin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnfund As System.Windows.Forms.Button
    Friend WithEvents dis1 As System.Windows.Forms.Label
    Friend WithEvents btnbalance As System.Windows.Forms.Button
    Friend WithEvents Btnwithdraw As System.Windows.Forms.Button
    Friend WithEvents btnpin As System.Windows.Forms.Button
End Class
