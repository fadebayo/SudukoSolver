<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SudukoSolver
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
        Me.components = New System.ComponentModel.Container
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox73 = New System.Windows.Forms.TextBox
        Me.TextBox74 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox75 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox76 = New System.Windows.Forms.TextBox
        Me.TextBox77 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox78 = New System.Windows.Forms.TextBox
        Me.TextBox79 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox80 = New System.Windows.Forms.TextBox
        Me.TextBox81 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox64 = New System.Windows.Forms.TextBox
        Me.TextBox65 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox66 = New System.Windows.Forms.TextBox
        Me.TextBox67 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox68 = New System.Windows.Forms.TextBox
        Me.TextBox69 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox70 = New System.Windows.Forms.TextBox
        Me.TextBox71 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox72 = New System.Windows.Forms.TextBox
        Me.TextBox55 = New System.Windows.Forms.TextBox
        Me.TextBox56 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox57 = New System.Windows.Forms.TextBox
        Me.TextBox27 = New System.Windows.Forms.TextBox
        Me.TextBox58 = New System.Windows.Forms.TextBox
        Me.TextBox26 = New System.Windows.Forms.TextBox
        Me.TextBox59 = New System.Windows.Forms.TextBox
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.TextBox60 = New System.Windows.Forms.TextBox
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.TextBox61 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox62 = New System.Windows.Forms.TextBox
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.TextBox63 = New System.Windows.Forms.TextBox
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.TextBox46 = New System.Windows.Forms.TextBox
        Me.TextBox47 = New System.Windows.Forms.TextBox
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.TextBox48 = New System.Windows.Forms.TextBox
        Me.TextBox36 = New System.Windows.Forms.TextBox
        Me.TextBox49 = New System.Windows.Forms.TextBox
        Me.TextBox35 = New System.Windows.Forms.TextBox
        Me.TextBox50 = New System.Windows.Forms.TextBox
        Me.TextBox34 = New System.Windows.Forms.TextBox
        Me.TextBox51 = New System.Windows.Forms.TextBox
        Me.TextBox33 = New System.Windows.Forms.TextBox
        Me.TextBox52 = New System.Windows.Forms.TextBox
        Me.TextBox32 = New System.Windows.Forms.TextBox
        Me.TextBox53 = New System.Windows.Forms.TextBox
        Me.TextBox31 = New System.Windows.Forms.TextBox
        Me.TextBox54 = New System.Windows.Forms.TextBox
        Me.TextBox30 = New System.Windows.Forms.TextBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.TextBox37 = New System.Windows.Forms.TextBox
        Me.TextBox38 = New System.Windows.Forms.TextBox
        Me.TextBox45 = New System.Windows.Forms.TextBox
        Me.TextBox39 = New System.Windows.Forms.TextBox
        Me.TextBox44 = New System.Windows.Forms.TextBox
        Me.TextBox40 = New System.Windows.Forms.TextBox
        Me.TextBox43 = New System.Windows.Forms.TextBox
        Me.TextBox41 = New System.Windows.Forms.TextBox
        Me.TextBox42 = New System.Windows.Forms.TextBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSolve = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(370, 18)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate "
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 33)
        Me.Label1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 26)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(23, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(20, 26)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(43, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(20, 26)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "0"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(66, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(20, 26)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "0"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(86, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(20, 26)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(106, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(20, 26)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = "0"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(129, 3)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(20, 26)
        Me.TextBox7.TabIndex = 11
        Me.TextBox7.Text = "0"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(149, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(20, 26)
        Me.TextBox8.TabIndex = 10
        Me.TextBox8.Text = "0"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(169, 3)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(20, 26)
        Me.TextBox9.TabIndex = 9
        Me.TextBox9.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.TextBox73)
        Me.Panel1.Controls.Add(Me.TextBox74)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.TextBox75)
        Me.Panel1.Controls.Add(Me.TextBox11)
        Me.Panel1.Controls.Add(Me.TextBox76)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox77)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.TextBox78)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox79)
        Me.Panel1.Controls.Add(Me.TextBox13)
        Me.Panel1.Controls.Add(Me.TextBox80)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox81)
        Me.Panel1.Controls.Add(Me.TextBox14)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.TextBox64)
        Me.Panel1.Controls.Add(Me.TextBox65)
        Me.Panel1.Controls.Add(Me.TextBox15)
        Me.Panel1.Controls.Add(Me.TextBox66)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox67)
        Me.Panel1.Controls.Add(Me.TextBox16)
        Me.Panel1.Controls.Add(Me.TextBox68)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.TextBox69)
        Me.Panel1.Controls.Add(Me.TextBox17)
        Me.Panel1.Controls.Add(Me.TextBox70)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox71)
        Me.Panel1.Controls.Add(Me.TextBox18)
        Me.Panel1.Controls.Add(Me.TextBox72)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox55)
        Me.Panel1.Controls.Add(Me.TextBox56)
        Me.Panel1.Controls.Add(Me.TextBox19)
        Me.Panel1.Controls.Add(Me.TextBox57)
        Me.Panel1.Controls.Add(Me.TextBox27)
        Me.Panel1.Controls.Add(Me.TextBox58)
        Me.Panel1.Controls.Add(Me.TextBox26)
        Me.Panel1.Controls.Add(Me.TextBox59)
        Me.Panel1.Controls.Add(Me.TextBox25)
        Me.Panel1.Controls.Add(Me.TextBox60)
        Me.Panel1.Controls.Add(Me.TextBox24)
        Me.Panel1.Controls.Add(Me.TextBox61)
        Me.Panel1.Controls.Add(Me.TextBox23)
        Me.Panel1.Controls.Add(Me.TextBox62)
        Me.Panel1.Controls.Add(Me.TextBox22)
        Me.Panel1.Controls.Add(Me.TextBox63)
        Me.Panel1.Controls.Add(Me.TextBox21)
        Me.Panel1.Controls.Add(Me.TextBox20)
        Me.Panel1.Controls.Add(Me.TextBox46)
        Me.Panel1.Controls.Add(Me.TextBox47)
        Me.Panel1.Controls.Add(Me.TextBox28)
        Me.Panel1.Controls.Add(Me.TextBox48)
        Me.Panel1.Controls.Add(Me.TextBox36)
        Me.Panel1.Controls.Add(Me.TextBox49)
        Me.Panel1.Controls.Add(Me.TextBox35)
        Me.Panel1.Controls.Add(Me.TextBox50)
        Me.Panel1.Controls.Add(Me.TextBox34)
        Me.Panel1.Controls.Add(Me.TextBox51)
        Me.Panel1.Controls.Add(Me.TextBox33)
        Me.Panel1.Controls.Add(Me.TextBox52)
        Me.Panel1.Controls.Add(Me.TextBox32)
        Me.Panel1.Controls.Add(Me.TextBox53)
        Me.Panel1.Controls.Add(Me.TextBox31)
        Me.Panel1.Controls.Add(Me.TextBox54)
        Me.Panel1.Controls.Add(Me.TextBox30)
        Me.Panel1.Controls.Add(Me.TextBox29)
        Me.Panel1.Controls.Add(Me.TextBox37)
        Me.Panel1.Controls.Add(Me.TextBox38)
        Me.Panel1.Controls.Add(Me.TextBox45)
        Me.Panel1.Controls.Add(Me.TextBox39)
        Me.Panel1.Controls.Add(Me.TextBox44)
        Me.Panel1.Controls.Add(Me.TextBox40)
        Me.Panel1.Controls.Add(Me.TextBox43)
        Me.Panel1.Controls.Add(Me.TextBox41)
        Me.Panel1.Controls.Add(Me.TextBox42)
        Me.Panel1.Location = New System.Drawing.Point(151, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 245)
        Me.Panel1.TabIndex = 12
        '
        'TextBox73
        '
        Me.TextBox73.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox73.Location = New System.Drawing.Point(3, 217)
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(20, 26)
        Me.TextBox73.TabIndex = 67
        Me.TextBox73.Text = "0"
        '
        'TextBox74
        '
        Me.TextBox74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox74.Location = New System.Drawing.Point(23, 217)
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(20, 26)
        Me.TextBox74.TabIndex = 75
        Me.TextBox74.Text = "0"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(3, 29)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(20, 26)
        Me.TextBox10.TabIndex = 13
        Me.TextBox10.Text = "0"
        '
        'TextBox75
        '
        Me.TextBox75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox75.Location = New System.Drawing.Point(43, 217)
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(20, 26)
        Me.TextBox75.TabIndex = 68
        Me.TextBox75.Text = "0"
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(23, 29)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(20, 26)
        Me.TextBox11.TabIndex = 21
        Me.TextBox11.Text = "0"
        '
        'TextBox76
        '
        Me.TextBox76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox76.Location = New System.Drawing.Point(66, 217)
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(20, 26)
        Me.TextBox76.TabIndex = 74
        Me.TextBox76.Text = "0"
        '
        'TextBox77
        '
        Me.TextBox77.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox77.Location = New System.Drawing.Point(86, 217)
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(20, 26)
        Me.TextBox77.TabIndex = 69
        Me.TextBox77.Text = "0"
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(43, 29)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(20, 26)
        Me.TextBox12.TabIndex = 14
        Me.TextBox12.Text = "0"
        '
        'TextBox78
        '
        Me.TextBox78.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox78.Location = New System.Drawing.Point(106, 217)
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(20, 26)
        Me.TextBox78.TabIndex = 73
        Me.TextBox78.Text = "0"
        '
        'TextBox79
        '
        Me.TextBox79.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox79.Location = New System.Drawing.Point(129, 217)
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(20, 26)
        Me.TextBox79.TabIndex = 70
        Me.TextBox79.Text = "0"
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(66, 29)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(20, 26)
        Me.TextBox13.TabIndex = 20
        Me.TextBox13.Text = "0"
        '
        'TextBox80
        '
        Me.TextBox80.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox80.Location = New System.Drawing.Point(149, 217)
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(20, 26)
        Me.TextBox80.TabIndex = 72
        Me.TextBox80.Text = "0"
        '
        'TextBox81
        '
        Me.TextBox81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox81.Location = New System.Drawing.Point(169, 217)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(20, 26)
        Me.TextBox81.TabIndex = 71
        Me.TextBox81.Text = "0"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(86, 29)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(20, 26)
        Me.TextBox14.TabIndex = 15
        Me.TextBox14.Text = "0"
        '
        'TextBox64
        '
        Me.TextBox64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox64.Location = New System.Drawing.Point(3, 191)
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(20, 26)
        Me.TextBox64.TabIndex = 58
        Me.TextBox64.Text = "0"
        '
        'TextBox65
        '
        Me.TextBox65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox65.Location = New System.Drawing.Point(23, 191)
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(20, 26)
        Me.TextBox65.TabIndex = 66
        Me.TextBox65.Text = "0"
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(106, 29)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(20, 26)
        Me.TextBox15.TabIndex = 19
        Me.TextBox15.Text = "0"
        '
        'TextBox66
        '
        Me.TextBox66.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox66.Location = New System.Drawing.Point(43, 191)
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(20, 26)
        Me.TextBox66.TabIndex = 59
        Me.TextBox66.Text = "0"
        '
        'TextBox67
        '
        Me.TextBox67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox67.Location = New System.Drawing.Point(66, 191)
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(20, 26)
        Me.TextBox67.TabIndex = 65
        Me.TextBox67.Text = "0"
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(129, 29)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(20, 26)
        Me.TextBox16.TabIndex = 16
        Me.TextBox16.Text = "0"
        '
        'TextBox68
        '
        Me.TextBox68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox68.Location = New System.Drawing.Point(86, 191)
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(20, 26)
        Me.TextBox68.TabIndex = 60
        Me.TextBox68.Text = "0"
        '
        'TextBox69
        '
        Me.TextBox69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox69.Location = New System.Drawing.Point(106, 191)
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(20, 26)
        Me.TextBox69.TabIndex = 64
        Me.TextBox69.Text = "0"
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(149, 29)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(20, 26)
        Me.TextBox17.TabIndex = 18
        Me.TextBox17.Text = "0"
        '
        'TextBox70
        '
        Me.TextBox70.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox70.Location = New System.Drawing.Point(129, 191)
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(20, 26)
        Me.TextBox70.TabIndex = 61
        Me.TextBox70.Text = "0"
        '
        'TextBox71
        '
        Me.TextBox71.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox71.Location = New System.Drawing.Point(149, 191)
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(20, 26)
        Me.TextBox71.TabIndex = 63
        Me.TextBox71.Text = "0"
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(169, 29)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(20, 26)
        Me.TextBox18.TabIndex = 17
        Me.TextBox18.Text = "0"
        '
        'TextBox72
        '
        Me.TextBox72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox72.Location = New System.Drawing.Point(169, 191)
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(20, 26)
        Me.TextBox72.TabIndex = 62
        Me.TextBox72.Text = "0"
        '
        'TextBox55
        '
        Me.TextBox55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox55.Location = New System.Drawing.Point(3, 165)
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(20, 26)
        Me.TextBox55.TabIndex = 49
        Me.TextBox55.Text = "0"
        '
        'TextBox56
        '
        Me.TextBox56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox56.Location = New System.Drawing.Point(23, 165)
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(20, 26)
        Me.TextBox56.TabIndex = 57
        Me.TextBox56.Text = "0"
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(3, 55)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(20, 26)
        Me.TextBox19.TabIndex = 13
        Me.TextBox19.Text = "0"
        '
        'TextBox57
        '
        Me.TextBox57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox57.Location = New System.Drawing.Point(43, 165)
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(20, 26)
        Me.TextBox57.TabIndex = 50
        Me.TextBox57.Text = "0"
        '
        'TextBox27
        '
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.Location = New System.Drawing.Point(169, 55)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(20, 26)
        Me.TextBox27.TabIndex = 17
        Me.TextBox27.Text = "0"
        '
        'TextBox58
        '
        Me.TextBox58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox58.Location = New System.Drawing.Point(66, 165)
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(20, 26)
        Me.TextBox58.TabIndex = 56
        Me.TextBox58.Text = "0"
        '
        'TextBox26
        '
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(149, 55)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(20, 26)
        Me.TextBox26.TabIndex = 18
        Me.TextBox26.Text = "0"
        '
        'TextBox59
        '
        Me.TextBox59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox59.Location = New System.Drawing.Point(86, 165)
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(20, 26)
        Me.TextBox59.TabIndex = 51
        Me.TextBox59.Text = "0"
        '
        'TextBox25
        '
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(129, 55)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(20, 26)
        Me.TextBox25.TabIndex = 16
        Me.TextBox25.Text = "0"
        '
        'TextBox60
        '
        Me.TextBox60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox60.Location = New System.Drawing.Point(106, 165)
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(20, 26)
        Me.TextBox60.TabIndex = 55
        Me.TextBox60.Text = "0"
        '
        'TextBox24
        '
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(106, 55)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(20, 26)
        Me.TextBox24.TabIndex = 19
        Me.TextBox24.Text = "0"
        '
        'TextBox61
        '
        Me.TextBox61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox61.Location = New System.Drawing.Point(129, 165)
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(20, 26)
        Me.TextBox61.TabIndex = 52
        Me.TextBox61.Text = "0"
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(86, 55)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(20, 26)
        Me.TextBox23.TabIndex = 15
        Me.TextBox23.Text = "0"
        '
        'TextBox62
        '
        Me.TextBox62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox62.Location = New System.Drawing.Point(149, 165)
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(20, 26)
        Me.TextBox62.TabIndex = 54
        Me.TextBox62.Text = "0"
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(66, 55)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(20, 26)
        Me.TextBox22.TabIndex = 20
        Me.TextBox22.Text = "0"
        '
        'TextBox63
        '
        Me.TextBox63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox63.Location = New System.Drawing.Point(169, 165)
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(20, 26)
        Me.TextBox63.TabIndex = 53
        Me.TextBox63.Text = "0"
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(43, 55)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(20, 26)
        Me.TextBox21.TabIndex = 14
        Me.TextBox21.Text = "0"
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(23, 55)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(20, 26)
        Me.TextBox20.TabIndex = 21
        Me.TextBox20.Text = "0"
        '
        'TextBox46
        '
        Me.TextBox46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox46.Location = New System.Drawing.Point(3, 136)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(20, 26)
        Me.TextBox46.TabIndex = 40
        Me.TextBox46.Text = "0"
        '
        'TextBox47
        '
        Me.TextBox47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox47.Location = New System.Drawing.Point(23, 136)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(20, 26)
        Me.TextBox47.TabIndex = 48
        Me.TextBox47.Text = "0"
        '
        'TextBox28
        '
        Me.TextBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(3, 84)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(20, 26)
        Me.TextBox28.TabIndex = 22
        Me.TextBox28.Text = "0"
        '
        'TextBox48
        '
        Me.TextBox48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox48.Location = New System.Drawing.Point(43, 136)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(20, 26)
        Me.TextBox48.TabIndex = 41
        Me.TextBox48.Text = "0"
        '
        'TextBox36
        '
        Me.TextBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.Location = New System.Drawing.Point(169, 84)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(20, 26)
        Me.TextBox36.TabIndex = 26
        Me.TextBox36.Text = "0"
        '
        'TextBox49
        '
        Me.TextBox49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox49.Location = New System.Drawing.Point(66, 136)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(20, 26)
        Me.TextBox49.TabIndex = 47
        Me.TextBox49.Text = "0"
        '
        'TextBox35
        '
        Me.TextBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.Location = New System.Drawing.Point(149, 84)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(20, 26)
        Me.TextBox35.TabIndex = 27
        Me.TextBox35.Text = "0"
        '
        'TextBox50
        '
        Me.TextBox50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox50.Location = New System.Drawing.Point(86, 136)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(20, 26)
        Me.TextBox50.TabIndex = 42
        Me.TextBox50.Text = "0"
        '
        'TextBox34
        '
        Me.TextBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox34.Location = New System.Drawing.Point(129, 84)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(20, 26)
        Me.TextBox34.TabIndex = 25
        Me.TextBox34.Text = "0"
        '
        'TextBox51
        '
        Me.TextBox51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox51.Location = New System.Drawing.Point(106, 136)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(20, 26)
        Me.TextBox51.TabIndex = 46
        Me.TextBox51.Text = "0"
        '
        'TextBox33
        '
        Me.TextBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox33.Location = New System.Drawing.Point(106, 84)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(20, 26)
        Me.TextBox33.TabIndex = 28
        Me.TextBox33.Text = "0"
        '
        'TextBox52
        '
        Me.TextBox52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox52.Location = New System.Drawing.Point(129, 136)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(20, 26)
        Me.TextBox52.TabIndex = 43
        Me.TextBox52.Text = "0"
        '
        'TextBox32
        '
        Me.TextBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox32.Location = New System.Drawing.Point(86, 84)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(20, 26)
        Me.TextBox32.TabIndex = 24
        Me.TextBox32.Text = "0"
        '
        'TextBox53
        '
        Me.TextBox53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox53.Location = New System.Drawing.Point(149, 136)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(20, 26)
        Me.TextBox53.TabIndex = 45
        Me.TextBox53.Text = "0"
        '
        'TextBox31
        '
        Me.TextBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.Location = New System.Drawing.Point(66, 84)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(20, 26)
        Me.TextBox31.TabIndex = 29
        Me.TextBox31.Text = "0"
        '
        'TextBox54
        '
        Me.TextBox54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox54.Location = New System.Drawing.Point(169, 136)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(20, 26)
        Me.TextBox54.TabIndex = 44
        Me.TextBox54.Text = "0"
        '
        'TextBox30
        '
        Me.TextBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.Location = New System.Drawing.Point(43, 84)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(20, 26)
        Me.TextBox30.TabIndex = 23
        Me.TextBox30.Text = "0"
        '
        'TextBox29
        '
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(23, 84)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(20, 26)
        Me.TextBox29.TabIndex = 30
        Me.TextBox29.Text = "0"
        '
        'TextBox37
        '
        Me.TextBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox37.Location = New System.Drawing.Point(3, 110)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(20, 26)
        Me.TextBox37.TabIndex = 31
        Me.TextBox37.Text = "0"
        '
        'TextBox38
        '
        Me.TextBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox38.Location = New System.Drawing.Point(23, 110)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(20, 26)
        Me.TextBox38.TabIndex = 39
        Me.TextBox38.Text = "0"
        '
        'TextBox45
        '
        Me.TextBox45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox45.Location = New System.Drawing.Point(169, 110)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(20, 26)
        Me.TextBox45.TabIndex = 35
        Me.TextBox45.Text = "0"
        '
        'TextBox39
        '
        Me.TextBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox39.Location = New System.Drawing.Point(43, 110)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(20, 26)
        Me.TextBox39.TabIndex = 32
        Me.TextBox39.Text = "0"
        '
        'TextBox44
        '
        Me.TextBox44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox44.Location = New System.Drawing.Point(149, 110)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(20, 26)
        Me.TextBox44.TabIndex = 36
        Me.TextBox44.Text = "0"
        '
        'TextBox40
        '
        Me.TextBox40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox40.Location = New System.Drawing.Point(66, 110)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(20, 26)
        Me.TextBox40.TabIndex = 38
        Me.TextBox40.Text = "0"
        '
        'TextBox43
        '
        Me.TextBox43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox43.Location = New System.Drawing.Point(129, 110)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(20, 26)
        Me.TextBox43.TabIndex = 34
        Me.TextBox43.Text = "0"
        '
        'TextBox41
        '
        Me.TextBox41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox41.Location = New System.Drawing.Point(86, 110)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(20, 26)
        Me.TextBox41.TabIndex = 33
        Me.TextBox41.Text = "0"
        '
        'TextBox42
        '
        Me.TextBox42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox42.Location = New System.Drawing.Point(106, 110)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(20, 26)
        Me.TextBox42.TabIndex = 37
        Me.TextBox42.Text = "0"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(370, 43)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(370, 67)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 14
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(464, 18)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 15
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'SudukoSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 401)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "SudukoSolver"
        Me.Text = "SUDOKU SOLVER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox34 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox42 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox46 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox47 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox48 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox49 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox50 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox51 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox52 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox53 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox54 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox55 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox56 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox57 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox58 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox59 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox60 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox61 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox62 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox63 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox64 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox65 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox66 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox67 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox68 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox69 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox70 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox71 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox72 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox73 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox74 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox75 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox76 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox77 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox78 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox79 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox80 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button

End Class
