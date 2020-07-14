Public Partial Class MainForm
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	Sub Button1Click(sender As Object, e As EventArgs)
		Dim a As String, b As String, c As String, d As String, f As String, mml As String
		a = textBox1.Text
		b = a * 0.3566
		c = a * 6.7134
		d = a * 4.0736
		mml = b * 0.50
		f = b * 50.05
		textBox2.Text = b
		textBox3.Text = c
		textBox7.Text = mml
		textbox5.Text = f
		If c > 100 Then
			textBox8.Text = "Превышение"
			textBox8.BackColor = System.Drawing.Color.Red
		Else
			textBox8.Text = "Норма"
			textBox8.BackColor = System.Drawing.Color.LimeGreen
		End If
		textBox4.Text = d
		If d > 85 Then
			textBox9.Text = "Превышение"
			textBox9.BackColor = System.Drawing.Color.Red
		Else
			textBox9.Text = "Норма"
			textBox9.BackColor = System.Drawing.Color.LimeGreen
		End If
		timer1.Start()
		notifyIcon1.BalloonTipTitle = "WinOPV 0.1"
		notifyIcon1.BalloonTipText = "Подсчет выполнен"
		notifyIcon1.Visible = True
		notifyIcon1.ShowBalloonTip(0)
	End Sub
	
	Sub ToolStripButton1Click(sender As Object, e As EventArgs)
		textBox1.Text = ""
		textBox2.Text = ""
		textBox3.Text = ""
		textBox4.Text = ""
		textBox5.Text = ""
		textBox7.Text = ""
		textBox8.Text = ""
		textBox9.Text = ""
		textBox10.Text = ""
		textBox11.Text = ""
		textBox13.Text = ""
		textBox14.Text = ""
		textBox12.Text = ""
		textBox15.Text = ""
		textBox16.Text = ""
		textBox17.Text = ""
		textBox8.BackColor = System.Drawing.Color.White
		textBox9.BackColor = System.Drawing.Color.White
		textBox15.BackColor = System.Drawing.Color.White
		textBox17.BackColor = System.Drawing.Color.White
	End Sub
	
	Sub ToolStripButton2Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
	Sub Button3Click(sender As Object, e As EventArgs)
		Dim a As String, b As String
		a = textBox10.Text
		b = a * 0.58
		textBox11.Text = b
		If b > 1.5 Then
			textBox17.Text = "Превышение"
			textBox17.BackColor = System.Drawing.Color.Red
		Else
			textBox17.Text = "Норма"
			textBox17.BackColor = System.Drawing.Color.LimeGreen
		End If
		timer1.Start()
		notifyIcon1.BalloonTipTitle = "WinOPV 0.1"
		notifyIcon1.BalloonTipText = "Подсчет выполнен"
		notifyIcon1.Visible = True
		notifyIcon1.ShowBalloonTip(0)
	End Sub
	
	Sub Button4Click(sender As Object, e As EventArgs)
		Dim a As String, b As String, c As String, d As String
		a = textBox12.Text
		b = textBox13.Text
		If a = 7 And b = 1 Then
    		textBox14.text = "0.006"
    		textBox15.Text = "Норма"
		End If
		If a = 7 And b = 2 Then
    		textBox14.text = "0.014"
    		textBox15.Text = "Норма"
		End If
		If a = 7 And b = 5 Then
    		textBox14.text = "0.029"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = 7 And b = 10 Then
    		textBox14.text = "0.057"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = "7,5" And b = 1 Then
    		textBox14.text = "0.018"
    		textBox15.Text = "Норма"
		End If
		If a = "7,5" And b = 2 Then
    		textBox14.text = "0.036"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = "7,5" And b = 5 Then
    		textBox14.text = "0.090"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = "7,5" And b = 10 Then
    		textBox14.text = "0.179"
    		textBox15.Text = "Нельзя пить"
		End If
		If a = 8 And b = 1 Then
    		textBox14.text = "0.006"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = 8 And b = 2 Then
    		textBox14.text = "0.109"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = 8 And b = 5 Then
    		textBox14.text = "0.272"
    		textBox15.Text = "Нельзя пить"
		End If
		If a = 8 And b = 10 Then
    		textBox14.text = "0.544"
    		textBox15.Text = "Нельзя пить"
		End If
		If a = "8,5" And b = 1 Then
    		textBox14.text = "0.154"
    		textBox15.Text = "Не рекомендуется"
		End If
		If a = "8,5" And b = 2 Then
    		textBox14.text = "0.308"
    		textBox15.Text = "Нельзя пить"
		End If
		If a = "8,5" And b = 5 Then
    		textBox14.text = "0.770"
    		textBox15.Text = "Нельзя пить"
		End If
		If a = "8,5" And b = 10 Then
    		textBox14.text = "1.540"
    		textBox15.Text = "Нельзя пить"
		End If
		c = textBox15.Text
		Select Case (c)
			Case "Норма"
				textBox15.BackColor = System.Drawing.Color.LimeGreen
			Case "Не рекомендуется"
				textBox15.BackColor = System.Drawing.Color.Yellow
			Case "Нельзя пить"
				textBox15.BackColor = System.Drawing.Color.Red
		End Select
		d = 14 - a
		textBox16.Text = d
		timer1.Start()
		notifyIcon1.BalloonTipTitle = "WinOPV 0.1"
		notifyIcon1.BalloonTipText = "Подсчет выполнен"
		notifyIcon1.Visible = True
		notifyIcon1.ShowBalloonTip(0)
	End Sub
	
	Sub ToolStripButton3Click(sender As Object, e As EventArgs)
		MsgBox("Программа для определения качества воды. Написана на Visual Basic .NET Framework 4. Автор - Гиль Александр")		
	End Sub
	
	Sub ToolStripButton4Click(sender As Object, e As EventArgs)
		MsgBox(Now.ToLongDateString())
		MsgBox(TimeOfDay)
	End Sub
End Class
