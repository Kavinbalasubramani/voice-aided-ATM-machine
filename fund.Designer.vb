<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fund))
        Me.nnn = New System.Windows.Forms.Label()
        Me.dis = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtaccount_num = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btntransfer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nnn
        '
        Me.nnn.AutoSize = True
        Me.nnn.Location = New System.Drawing.Point(389, 287)
        Me.nnn.Name = "nnn"
        Me.nnn.Size = New System.Drawing.Size(39, 13)
        Me.nnn.TabIndex = 138
        Me.nnn.Text = "Label2"
        Me.nnn.Visible = False
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(22, 111)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 136
        Me.dis.Text = "Label2"
        Me.dis.Visible = False
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(238, 181)
        Me.txtamount.MaxLength = 35535
        Me.txtamount.Multiline = True
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(237, 31)
        Me.txtamount.TabIndex = 133
        '
        'txtaccount_num
        '
        Me.txtaccount_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccount_num.Location = New System.Drawing.Point(238, 136)
        Me.txtaccount_num.Multiline = True
        Me.txtaccount_num.Name = "txtaccount_num"
        Me.txtaccount_num.Size = New System.Drawing.Size(237, 34)
        Me.txtaccount_num.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 68)
        Me.Panel1.TabIndex = 130
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(268, 270)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(71, 46)
        Me.button2.TabIndex = 129
        Me.button2.UseVisualStyleBackColor = True
        '
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(55, 19)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(61, 20)
        Me.txtspeed.TabIndex = 62
        Me.txtspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(4, 182)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(226, 16)
        Me.label5.TabIndex = 128
        Me.label5.Text = "AMOUNT TO BE TRANSFER"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(4, 141)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(259, 16)
        Me.label6.TabIndex = 127
        Me.label6.Text = "RECIPIENT ACCOUNT NUMBER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "SPEED"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 54)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atm Voice Setting"
        '
        'txtvol
        '
        Me.txtvol.Location = New System.Drawing.Point(55, 51)
        Me.txtvol.Name = "txtvol"
        Me.txtvol.Size = New System.Drawing.Size(61, 20)
        Me.txtvol.TabIndex = 61
        Me.txtvol.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "VOL."
        '
        'btntransfer
        '
        Me.btntransfer.BackgroundImage = CType(resources.GetObject("btntransfer.BackgroundImage"), System.Drawing.Image)
        Me.btntransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransfer.Location = New System.Drawing.Point(132, 270)
        Me.btntransfer.Name = "btntransfer"
        Me.btntransfer.Size = New System.Drawing.Size(80, 46)
        Me.btntransfer.TabIndex = 126
        Me.btntransfer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Your Balance :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Your Balance :"
        '
        'fund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 345)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nnn)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtaccount_num)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btntransfer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Fund"
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nnn As System.Windows.Forms.Label
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtaccount_num As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents btntransfer As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
End Class
