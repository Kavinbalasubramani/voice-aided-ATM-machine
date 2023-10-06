<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdrawal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdrawal))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.take_money = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.Label()
        Me.pixmoney = New System.Windows.Forms.PictureBox()
        Me.pixloading = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_500 = New System.Windows.Forms.Button()
        Me.dis = New System.Windows.Forms.Label()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.btn_20000 = New System.Windows.Forms.Button()
        Me.btn_10000 = New System.Windows.Forms.Button()
        Me.btn_5000 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_1000 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'take_money
        '
        Me.take_money.AutoSize = True
        Me.take_money.Location = New System.Drawing.Point(95, 436)
        Me.take_money.Name = "take_money"
        Me.take_money.Size = New System.Drawing.Size(89, 13)
        Me.take_money.TabIndex = 129
        Me.take_money.Text = "Take your money"
        '
        'wait
        '
        Me.wait.AutoSize = True
        Me.wait.Location = New System.Drawing.Point(69, 404)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(61, 13)
        Me.wait.TabIndex = 128
        Me.wait.Text = "Please wait"
        '
        'pixmoney
        '
        Me.pixmoney.BackgroundImage = CType(resources.GetObject("pixmoney.BackgroundImage"), System.Drawing.Image)
        Me.pixmoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pixmoney.Location = New System.Drawing.Point(190, 376)
        Me.pixmoney.Name = "pixmoney"
        Me.pixmoney.Size = New System.Drawing.Size(131, 96)
        Me.pixmoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixmoney.TabIndex = 127
        Me.pixmoney.TabStop = False
        '
        'pixloading
        '
        Me.pixloading.BackgroundImage = CType(resources.GetObject("pixloading.BackgroundImage"), System.Drawing.Image)
        Me.pixloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pixloading.Location = New System.Drawing.Point(132, 389)
        Me.pixloading.Name = "pixloading"
        Me.pixloading.Size = New System.Drawing.Size(52, 42)
        Me.pixloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pixloading.TabIndex = 126
        Me.pixloading.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(132, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 125
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Location = New System.Drawing.Point(238, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 35)
        Me.Button5.TabIndex = 118
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btn_500
        '
        Me.btn_500.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_500.ForeColor = System.Drawing.Color.Blue
        Me.btn_500.Location = New System.Drawing.Point(22, 185)
        Me.btn_500.Name = "btn_500"
        Me.btn_500.Size = New System.Drawing.Size(103, 49)
        Me.btn_500.TabIndex = 113
        Me.btn_500.Text = "500"
        Me.btn_500.UseVisualStyleBackColor = True
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(31, 150)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 122
        Me.dis.Text = "Label4"
        Me.dis.Visible = False
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(141, 134)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(180, 54)
        Me.btndisplay.TabIndex = 121
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'btn_20000
        '
        Me.btn_20000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_20000.ForeColor = System.Drawing.Color.Blue
        Me.btn_20000.Location = New System.Drawing.Point(344, 248)
        Me.btn_20000.Name = "btn_20000"
        Me.btn_20000.Size = New System.Drawing.Size(103, 49)
        Me.btn_20000.TabIndex = 120
        Me.btn_20000.Text = "20000"
        Me.btn_20000.UseVisualStyleBackColor = True
        '
        'btn_10000
        '
        Me.btn_10000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_10000.ForeColor = System.Drawing.Color.Blue
        Me.btn_10000.Location = New System.Drawing.Point(344, 185)
        Me.btn_10000.Name = "btn_10000"
        Me.btn_10000.Size = New System.Drawing.Size(103, 49)
        Me.btn_10000.TabIndex = 119
        Me.btn_10000.Text = "10000"
        Me.btn_10000.UseVisualStyleBackColor = True
        '
        'btn_5000
        '
        Me.btn_5000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5000.ForeColor = System.Drawing.Color.Blue
        Me.btn_5000.Location = New System.Drawing.Point(22, 317)
        Me.btn_5000.Name = "btn_5000"
        Me.btn_5000.Size = New System.Drawing.Size(103, 49)
        Me.btn_5000.TabIndex = 117
        Me.btn_5000.Text = "5000"
        Me.btn_5000.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 83)
        Me.Panel1.TabIndex = 116
        '
        'btn_1000
        '
        Me.btn_1000.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1000.ForeColor = System.Drawing.Color.Blue
        Me.btn_1000.Location = New System.Drawing.Point(22, 248)
        Me.btn_1000.Name = "btn_1000"
        Me.btn_1000.Size = New System.Drawing.Size(103, 49)
        Me.btn_1000.TabIndex = 115
        Me.btn_1000.Text = "1000"
        Me.btn_1000.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(344, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 49)
        Me.Button3.TabIndex = 114
        Me.Button3.Text = "Others"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(327, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Naira"
        '
        'Withdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.take_money)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.pixmoney)
        Me.Controls.Add(Me.pixloading)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_500)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btn_20000)
        Me.Controls.Add(Me.btn_10000)
        Me.Controls.Add(Me.btn_5000)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_1000)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Withdrawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "withdraw"
        CType(Me.pixmoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixloading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents take_money As System.Windows.Forms.Label
    Friend WithEvents wait As System.Windows.Forms.Label
    Friend WithEvents pixmoney As System.Windows.Forms.PictureBox
    Friend WithEvents pixloading As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_500 As System.Windows.Forms.Button
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents btndisplay As System.Windows.Forms.Button
    Friend WithEvents btn_20000 As System.Windows.Forms.Button
    Friend WithEvents btn_10000 As System.Windows.Forms.Button
    Friend WithEvents btn_5000 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_1000 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
