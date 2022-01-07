<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.tabPag = New System.Windows.Forms.TabPage
        Me.label4 = New System.Windows.Forms.Label
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.label2 = New System.Windows.Forms.Label
        Me.tabPage1.SuspendLayout()
        Me.tabPag.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Papyrus", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(155, -31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(153, 71)
        Me.label1.TabIndex = 4
        Me.label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OPV3.1"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(0, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(272, 52)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Версия программы: 3.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Язык программы: многоязычный" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Версия .NET Framework: 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ве" & _
            "рсия Windows: Windows NT"
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.label3)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(272, 69)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Системная информация"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'tabPag
        '
        Me.tabPag.Controls.Add(Me.label4)
        Me.tabPag.Location = New System.Drawing.Point(4, 22)
        Me.tabPag.Name = "tabPag"
        Me.tabPag.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPag.Size = New System.Drawing.Size(272, 69)
        Me.tabPag.TabIndex = 1
        Me.tabPag.Text = "Компоненты"
        Me.tabPag.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(0, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(272, 67)
        Me.label4.TabIndex = 0
        Me.label4.Text = "dm.exe - Дебитомер" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stg.exe - настройки" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lang.ini - язык" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unit.ini - единицы изме" & _
            "рения" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "theme.ini - смена темы"
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPag)
        Me.tabControl1.Location = New System.Drawing.Point(-1, 137)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(280, 95)
        Me.tabControl1.TabIndex = 6
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(3, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(292, 94)
        Me.label2.TabIndex = 5
        Me.label2.Text = resources.GetString("label2.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 234)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Информация о программе"
        Me.tabPage1.ResumeLayout(False)
        Me.tabPag.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents tabPag As System.Windows.Forms.TabPage
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents label2 As System.Windows.Forms.Label

End Class
