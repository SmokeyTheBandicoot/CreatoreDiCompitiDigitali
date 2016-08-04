<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaCompito
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Catlbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AA = New System.Windows.Forms.Label()
        Me.Categorylbl = New System.Windows.Forms.Label()
        Me.Question = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mainlbl = New System.Windows.Forms.Label()
        Me.ExitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(562, 582)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(195, 43)
        Me.Button7.TabIndex = 68
        Me.Button7.Text = "Domanda successiva >"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(121, 582)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(195, 43)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = "< Domanda precedente"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(322, 582)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(234, 43)
        Me.Button5.TabIndex = 65
        Me.Button5.Text = "[] Stop"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Catlbl
        '
        Me.Catlbl.AutoSize = True
        Me.Catlbl.BackColor = System.Drawing.Color.Transparent
        Me.Catlbl.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Catlbl.Location = New System.Drawing.Point(433, 135)
        Me.Catlbl.Name = "Catlbl"
        Me.Catlbl.Size = New System.Drawing.Size(16, 16)
        Me.Catlbl.TabIndex = 64
        Me.Catlbl.Text = "--"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(595, 359)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Risposta D"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(156, 359)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Risposta C"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(595, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 16)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Risposta B"
        '
        'AA
        '
        Me.AA.AutoSize = True
        Me.AA.BackColor = System.Drawing.Color.Transparent
        Me.AA.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AA.Location = New System.Drawing.Point(156, 273)
        Me.AA.Name = "AA"
        Me.AA.Size = New System.Drawing.Size(82, 16)
        Me.AA.TabIndex = 58
        Me.AA.Text = "Risposta A"
        '
        'Categorylbl
        '
        Me.Categorylbl.AutoSize = True
        Me.Categorylbl.BackColor = System.Drawing.Color.Transparent
        Me.Categorylbl.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categorylbl.Location = New System.Drawing.Point(367, 135)
        Me.Categorylbl.Name = "Categorylbl"
        Me.Categorylbl.Size = New System.Drawing.Size(77, 16)
        Me.Categorylbl.TabIndex = 57
        Me.Categorylbl.Text = "Categoria:"
        '
        'Question
        '
        Me.Question.AutoSize = True
        Me.Question.BackColor = System.Drawing.Color.Transparent
        Me.Question.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question.Location = New System.Drawing.Point(23, 135)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(78, 16)
        Me.Question.TabIndex = 56
        Me.Question.Text = "Domanda:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "File compiti digitali (digital test file) (.dtf)|*.dtf"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(305, 961)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(337, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "GameShards Software (c) 2016 - LearningShards Group"
        '
        'mainlbl
        '
        Me.mainlbl.BackColor = System.Drawing.Color.Transparent
        Me.mainlbl.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlbl.Location = New System.Drawing.Point(12, 43)
        Me.mainlbl.Name = "mainlbl"
        Me.mainlbl.Size = New System.Drawing.Size(919, 70)
        Me.mainlbl.TabIndex = 48
        Me.mainlbl.Text = "Benvenuto!"
        '
        'ExitTSMI
        '
        Me.ExitTSMI.BackColor = System.Drawing.Color.Black
        Me.ExitTSMI.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitTSMI.ForeColor = System.Drawing.Color.White
        Me.ExitTSMI.Name = "ExitTSMI"
        Me.ExitTSMI.Size = New System.Drawing.Size(179, 22)
        Me.ExitTSMI.Text = "Esci"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectEditor})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripMenuItem2.Text = "Modalità"
        '
        'ProjectEditor
        '
        Me.ProjectEditor.BackColor = System.Drawing.Color.Black
        Me.ProjectEditor.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectEditor.ForeColor = System.Drawing.Color.White
        Me.ProjectEditor.Name = "ProjectEditor"
        Me.ProjectEditor.Size = New System.Drawing.Size(194, 22)
        Me.ProjectEditor.Text = "Editor di progetti"
        '
        'RestartTSMI
        '
        Me.RestartTSMI.BackColor = System.Drawing.Color.Black
        Me.RestartTSMI.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartTSMI.ForeColor = System.Drawing.Color.White
        Me.RestartTSMI.Name = "RestartTSMI"
        Me.RestartTSMI.Size = New System.Drawing.Size(179, 22)
        Me.RestartTSMI.Text = "Ricomincia"
        '
        'OpenProjectTSMI
        '
        Me.OpenProjectTSMI.BackColor = System.Drawing.Color.Black
        Me.OpenProjectTSMI.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenProjectTSMI.ForeColor = System.Drawing.Color.White
        Me.OpenProjectTSMI.Name = "OpenProjectTSMI"
        Me.OpenProjectTSMI.Size = New System.Drawing.Size(179, 22)
        Me.OpenProjectTSMI.Text = "Apri progetto..."
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(408, 57)
        Me.Button3.TabIndex = 40
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenProjectTSMI, Me.RestartTSMI, Me.ExitTSMI})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(453, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(409, 57)
        Me.Button4.TabIndex = 39
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(453, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(409, 57)
        Me.Button2.TabIndex = 38
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem2, Me.AboutTSMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1428, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutTSMI
        '
        Me.AboutTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniToolStripMenuItem1})
        Me.AboutTSMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutTSMI.Name = "AboutTSMI"
        Me.AboutTSMI.Size = New System.Drawing.Size(27, 20)
        Me.AboutTSMI.Text = "?"
        '
        'InformazioniToolStripMenuItem1
        '
        Me.InformazioniToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.InformazioniToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformazioniToolStripMenuItem1.Name = "InformazioniToolStripMenuItem1"
        Me.InformazioniToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.InformazioniToolStripMenuItem1.Text = "Info e crediti"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 161)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(847, 109)
        Me.TextBox1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(408, 57)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(868, 360)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(63, 55)
        Me.Button8.TabIndex = 69
        Me.Button8.Text = "50 e 50"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(868, 299)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(63, 55)
        Me.Button9.TabIndex = 70
        Me.Button9.Text = "Salta quesito"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(868, 161)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(63, 55)
        Me.Button10.TabIndex = 71
        Me.Button10.Text = "Aiuto"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(937, 27)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(487, 760)
        Me.CheckedListBox1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(92, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "--"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(255, 530)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(369, 40)
        Me.Button11.TabIndex = 74
        Me.Button11.Text = "X Annulla la tua risposta per questa domanda"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(121, 631)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(291, 43)
        Me.Button12.TabIndex = 75
        Me.Button12.Text = "<< Domanda precedente non risposta"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(466, 631)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(291, 43)
        Me.Button13.TabIndex = 76
        Me.Button13.Text = "Domanda successiva non risposta >>"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightGray
        Me.TextBox2.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(15, 471)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(847, 43)
        Me.TextBox2.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 452)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Aiuto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(847, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("News701 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(805, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Aiuti:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Risultati di BiT-Test (.dtcr)|*.dtcr"
        '
        'AreaCompito
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BiTTest.My.Resources.Resources.Square
        Me.ClientSize = New System.Drawing.Size(1428, 865)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Catlbl)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.AA)
        Me.Controls.Add(Me.Categorylbl)
        Me.Controls.Add(Me.Question)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mainlbl)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("News701 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "AreaCompito"
        Me.Text = "AreaCompito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Catlbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents AA As System.Windows.Forms.Label
    Friend WithEvents Categorylbl As System.Windows.Forms.Label
    Friend WithEvents Question As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mainlbl As System.Windows.Forms.Label
    Friend WithEvents ExitTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectEditor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenProjectTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
