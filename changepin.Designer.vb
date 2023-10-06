<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changepin))
        Me.txtaccountnum = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtspeed = New System.Windows.Forms.NumericUpDown()
        Me.txtconfirmpin = New System.Windows.Forms.TextBox()
        Me.txtnewpin = New System.Windows.Forms.TextBox()
        Me.txtoldpin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvol = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dis = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtaccountnum
        '
        Me.txtaccountnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaccountnum.Location = New System.Drawing.Point(213, 220)
        Me.txtaccountnum.Multiline = True
        Me.txtaccountnum.Name = "txtaccountnum"
        Me.txtaccountnum.ReadOnly = True
        Me.txtaccountnum.Size = New System.Drawing.Size(193, 30)
        Me.txtaccountnum.TabIndex = 118
        '
        'txtcustname
        '
        Me.txtcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(213, 186)
        Me.txtcustname.Multiline = True
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(193, 27)
        Me.txtcustname.TabIndex = 117
        '
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(55, 19)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(61, 20)
        Me.txtspeed.TabIndex = 62
        Me.txtspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtconfirmpin
        '
        Me.txtconfirmpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpin.Location = New System.Drawing.Point(213, 149)
        Me.txtconfirmpin.MaxLength = 4
        Me.txtconfirmpin.Multiline = True
        Me.txtconfirmpin.Name = "txtconfirmpin"
        Me.txtconfirmpin.Size = New System.Drawing.Size(193, 32)
        Me.txtconfirmpin.TabIndex = 116
        '
        'txtnewpin
        '
        Me.txtnewpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpin.Location = New System.Drawing.Point(213, 120)
        Me.txtnewpin.MaxLength = 4
        Me.txtnewpin.Multiline = True
        Me.txtnewpin.Name = "txtnewpin"
        Me.txtnewpin.Size = New System.Drawing.Size(193, 26)
        Me.txtnewpin.TabIndex = 115
        '
        'txtoldpin
        '
        Me.txtoldpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpin.Location = New System.Drawing.Point(213, 83)
        Me.txtoldpin.Multiline = True
        Me.txtoldpin.Name = "txtoldpin"
        Me.txtoldpin.ReadOnly = True
        Me.txtoldpin.Size = New System.Drawing.Size(193, 30)
        Me.txtoldpin.TabIndex = 114
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
        'txtvol
        '
        Me.txtvol.Location = New System.Drawing.Point(55, 51)
        Me.txtvol.Name = "txtvol"
        Me.txtvol.Size = New System.Drawing.Size(61, 20)
        Me.txtvol.TabIndex = 61
        Me.txtvol.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 16)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "CONFIRM PIN- NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "REPORT"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(26, 228)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(150, 16)
        Me.label2.TabIndex = 111
        Me.label2.Text = "ACCOUNT NUMBER"
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(26, 193)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(176, 16)
        Me.label1.TabIndex = 110
        Me.label1.Text = "CUSTOMER FULLNAME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 68)
        Me.Panel1.TabIndex = 109
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(328, 297)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(69, 31)
        Me.button2.TabIndex = 108
        Me.button2.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(26, 124)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(146, 16)
        Me.label5.TabIndex = 107
        Me.label5.Text = "NEW PIN- NUMBER"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(26, 93)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(127, 16)
        Me.label6.TabIndex = 106
        Me.label6.Text = "ENTER OLD  PIN"
        '
        'btnchange
        '
        Me.btnchange.BackgroundImage = CType(resources.GetObject("btnchange.BackgroundImage"), System.Drawing.Image)
        Me.btnchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchange.Location = New System.Drawing.Point(230, 297)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(72, 31)
        Me.btnchange.TabIndex = 105
        Me.btnchange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.txtspeed)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 54)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Atm Voice Setting"
        '
        'dis
        '
        Me.dis.AutoSize = True
        Me.dis.Location = New System.Drawing.Point(27, 306)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(39, 13)
        Me.dis.TabIndex = 123
        Me.dis.Text = "Label4"
        Me.dis.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'changepin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 340)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.txtaccountnum)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.txtconfirmpin)
        Me.Controls.Add(Me.txtnewpin)
        Me.Controls.Add(Me.txtoldpin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "changepin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Pin"
        CType(Me.txtspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtaccountnum As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Private WithEvents txtspeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtconfirmpin As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpin As System.Windows.Forms.TextBox
    Friend WithEvents txtoldpin As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtvol As System.Windows.Forms.NumericUpDown
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents btnchange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dis As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
