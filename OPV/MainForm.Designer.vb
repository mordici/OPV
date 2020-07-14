'
' Created by SharpDevelop.
' User: USER
' Date: 10.07.2020
' Time: 17:28
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.textBox7 = New System.Windows.Forms.TextBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.textBox8 = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.textBox16 = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.textBox15 = New System.Windows.Forms.TextBox()
		Me.textBox14 = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.button4 = New System.Windows.Forms.Button()
		Me.textBox13 = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.textBox12 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.textBox17 = New System.Windows.Forms.TextBox()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.button3 = New System.Windows.Forms.Button()
		Me.textBox10 = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.toolStrip1.SuspendLayout
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'toolStrip1
		'
		Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton3, Me.toolStripButton1, Me.toolStripButton2, Me.toolStripButton4})
		Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.Size = New System.Drawing.Size(413, 25)
		Me.toolStrip1.TabIndex = 0
		Me.toolStrip1.Text = "toolStrip1"
		'
		'toolStripButton3
		'
		Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"),System.Drawing.Image)
		Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton3.Name = "toolStripButton3"
		Me.toolStripButton3.Size = New System.Drawing.Size(102, 22)
		Me.toolStripButton3.Text = "О программе"
		AddHandler Me.toolStripButton3.Click, AddressOf Me.ToolStripButton3Click
		'
		'toolStripButton1
		'
		Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"),System.Drawing.Image)
		Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton1.Name = "toolStripButton1"
		Me.toolStripButton1.Size = New System.Drawing.Size(79, 22)
		Me.toolStripButton1.Text = "Очистить"
		AddHandler Me.toolStripButton1.Click, AddressOf Me.ToolStripButton1Click
		'
		'toolStripButton2
		'
		Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"),System.Drawing.Image)
		Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton2.Name = "toolStripButton2"
		Me.toolStripButton2.Size = New System.Drawing.Size(73, 22)
		Me.toolStripButton2.Text = "Закрыть"
		AddHandler Me.toolStripButton2.Click, AddressOf Me.ToolStripButton2Click
		'
		'toolStripButton4
		'
		Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"),System.Drawing.Image)
		Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton4.Name = "toolStripButton4"
		Me.toolStripButton4.Size = New System.Drawing.Size(99, 22)
		Me.toolStripButton4.Text = "Дата и время"
		AddHandler Me.toolStripButton4.Click, AddressOf Me.ToolStripButton4Click
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.textBox5)
		Me.groupBox1.Controls.Add(Me.textBox7)
		Me.groupBox1.Controls.Add(Me.label14)
		Me.groupBox1.Controls.Add(Me.textBox9)
		Me.groupBox1.Controls.Add(Me.textBox8)
		Me.groupBox1.Controls.Add(Me.label7)
		Me.groupBox1.Controls.Add(Me.textBox4)
		Me.groupBox1.Controls.Add(Me.label4)
		Me.groupBox1.Controls.Add(Me.textBox3)
		Me.groupBox1.Controls.Add(Me.label3)
		Me.groupBox1.Controls.Add(Me.textBox2)
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.button1)
		Me.groupBox1.Controls.Add(Me.textBox1)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Location = New System.Drawing.Point(0, 28)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(411, 187)
		Me.groupBox1.TabIndex = 1
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Кальций, магний"
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(212, 78)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(108, 20)
		Me.textBox5.TabIndex = 11
		'
		'textBox7
		'
		Me.textBox7.Location = New System.Drawing.Point(212, 38)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.Size = New System.Drawing.Size(108, 20)
		Me.textBox7.TabIndex = 7
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(211, 61)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(123, 23)
		Me.label14.TabIndex = 8
		Me.label14.Text = "Жесткость (мг/л)"
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(123, 156)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(76, 20)
		Me.textBox9.TabIndex = 10
		'
		'textBox8
		'
		Me.textBox8.Location = New System.Drawing.Point(123, 117)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(76, 20)
		Me.textBox8.TabIndex = 9
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(211, 16)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(123, 23)
		Me.label7.TabIndex = 6
		Me.label7.Text = "Жесткость (ммоль/л)"
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(7, 157)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(109, 20)
		Me.textBox4.TabIndex = 8
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(7, 141)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Магний"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(7, 118)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(109, 20)
		Me.textBox3.TabIndex = 6
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(7, 101)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Кальций"
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(7, 78)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(109, 20)
		Me.textBox2.TabIndex = 4
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(6, 61)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(123, 23)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Жесткость (мг-экв/л)"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(122, 35)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Подсчет"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(7, 38)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(109, 20)
		Me.textBox1.TabIndex = 1
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(7, 20)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(109, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Количество каплей"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.textBox16)
		Me.groupBox2.Controls.Add(Me.label13)
		Me.groupBox2.Controls.Add(Me.textBox15)
		Me.groupBox2.Controls.Add(Me.textBox14)
		Me.groupBox2.Controls.Add(Me.label12)
		Me.groupBox2.Controls.Add(Me.button4)
		Me.groupBox2.Controls.Add(Me.textBox13)
		Me.groupBox2.Controls.Add(Me.label11)
		Me.groupBox2.Controls.Add(Me.textBox12)
		Me.groupBox2.Controls.Add(Me.label10)
		Me.groupBox2.Location = New System.Drawing.Point(211, 221)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(200, 181)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Аммиак"
		'
		'textBox16
		'
		Me.textBox16.Location = New System.Drawing.Point(7, 152)
		Me.textBox16.Name = "textBox16"
		Me.textBox16.Size = New System.Drawing.Size(100, 20)
		Me.textBox16.TabIndex = 9
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(7, 134)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(100, 23)
		Me.label13.TabIndex = 8
		Me.label13.Text = "рОН"
		'
		'textBox15
		'
		Me.textBox15.Location = New System.Drawing.Point(113, 111)
		Me.textBox15.Name = "textBox15"
		Me.textBox15.Size = New System.Drawing.Size(81, 20)
		Me.textBox15.TabIndex = 7
		'
		'textBox14
		'
		Me.textBox14.Location = New System.Drawing.Point(7, 111)
		Me.textBox14.Name = "textBox14"
		Me.textBox14.Size = New System.Drawing.Size(100, 20)
		Me.textBox14.TabIndex = 6
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(7, 95)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 5
		Me.label12.Text = "Аммиак"
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(113, 72)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(75, 23)
		Me.button4.TabIndex = 4
		Me.button4.Text = "Подсчет"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'textBox13
		'
		Me.textBox13.Location = New System.Drawing.Point(7, 72)
		Me.textBox13.Name = "textBox13"
		Me.textBox13.Size = New System.Drawing.Size(100, 20)
		Me.textBox13.TabIndex = 3
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(6, 59)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 2
		Me.label11.Text = "Введите аммиак"
		'
		'textBox12
		'
		Me.textBox12.Location = New System.Drawing.Point(7, 36)
		Me.textBox12.Name = "textBox12"
		Me.textBox12.Size = New System.Drawing.Size(100, 20)
		Me.textBox12.TabIndex = 1
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(7, 20)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(185, 23)
		Me.label10.TabIndex = 0
		Me.label10.Text = "Введите рН (для дробей - запятая)"
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.textBox17)
		Me.groupBox3.Controls.Add(Me.textBox11)
		Me.groupBox3.Controls.Add(Me.label9)
		Me.groupBox3.Controls.Add(Me.button3)
		Me.groupBox3.Controls.Add(Me.textBox10)
		Me.groupBox3.Controls.Add(Me.label8)
		Me.groupBox3.Location = New System.Drawing.Point(0, 221)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(205, 181)
		Me.groupBox3.TabIndex = 3
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Мутность"
		'
		'textBox17
		'
		Me.textBox17.Location = New System.Drawing.Point(112, 87)
		Me.textBox17.Name = "textBox17"
		Me.textBox17.Size = New System.Drawing.Size(87, 20)
		Me.textBox17.TabIndex = 5
		'
		'textBox11
		'
		Me.textBox11.Location = New System.Drawing.Point(7, 87)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(100, 20)
		Me.textBox11.TabIndex = 4
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(7, 69)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 3
		Me.label9.Text = "Мутность (мг/л)"
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(114, 46)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(75, 23)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Подсчет"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'textBox10
		'
		Me.textBox10.Location = New System.Drawing.Point(7, 46)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(100, 20)
		Me.textBox10.TabIndex = 1
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(7, 20)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(143, 23)
		Me.label8.TabIndex = 0
		Me.label8.Text = "Введите мутность в NTU"
		'
		'notifyIcon1
		'
		Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"),System.Drawing.Icon)
		Me.notifyIcon1.Text = "OPV 0.1"
		'
		'timer1
		'
		Me.timer1.Interval = 5500
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(413, 405)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.toolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.Text = "OPV"
		Me.toolStrip1.ResumeLayout(false)
		Me.toolStrip1.PerformLayout
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private timer1 As System.Windows.Forms.Timer
	Private notifyIcon1 As System.Windows.Forms.NotifyIcon
	Private label14 As System.Windows.Forms.Label
	Private toolStripButton4 As System.Windows.Forms.ToolStripButton
	Private toolStripButton3 As System.Windows.Forms.ToolStripButton
	Private textBox17 As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private textBox16 As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private textBox11 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private textBox12 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private textBox13 As System.Windows.Forms.TextBox
	Private button4 As System.Windows.Forms.Button
	Private label12 As System.Windows.Forms.Label
	Private textBox14 As System.Windows.Forms.TextBox
	Private textBox15 As System.Windows.Forms.TextBox
	Private textBox10 As System.Windows.Forms.TextBox
	Private button3 As System.Windows.Forms.Button
	Private label8 As System.Windows.Forms.Label
	Private textBox8 As System.Windows.Forms.TextBox
	Private textBox9 As System.Windows.Forms.TextBox
	Private textBox5 As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private textBox7 As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private toolStripButton2 As System.Windows.Forms.ToolStripButton
	Private toolStripButton1 As System.Windows.Forms.ToolStripButton
	Private label1 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private textBox3 As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		notifyIcon1.Visible = False		
	End Sub
End Class
