Imports GameShardsCore.Encryptor

Public Class Form1
    Public filetext() As String
    Dim filetxt As String
    Dim w As Byte
    Dim btns(3) As Button
    Dim x As Integer
    Dim help As String
    Dim correctans, kj As SByte
    Public k As Integer = 2
    Dim listindex As UShort = 0
    Dim lives As Byte = 4
    Dim helpnumber As Byte = 3
    Dim a As Boolean = True
    Dim stoplabel As Boolean = False
    Dim enc As New GameShardsCore.Encryptor
    Public GameMode As String = "Normal"
    Dim Answers() As Byte
    Public index As Integer
    Dim QuestionIndex As Integer
    Dim results As Integer
    Dim percent As Single

    Private Sub EditorDomandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectEditor.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click
        Me.Close()
    End Sub
    Private Sub ApriProgettoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProjectTSMI.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            startproject(OpenFileDialog1.FileName)
        End If
    End Sub
    Public Sub startproject(ByVal projectpath As String)
        '  StatoAttualeToolStripMenuItem.Enabled = True
        Percent50TSMI.Enabled = True
        JumpQuestion.Enabled = True
        HelpTSMI.Enabled = True
        Try
            Dim reader As New IO.StreamReader(projectpath)
            filetxt = enc.TranslationEncrypt(reader.ReadToEnd, -7)
            filetext = Split(filetxt, "§")
            reader.Close()
            restart()
            Timer1.Start()
            Timer3.Start()
            For f = 0 To 3
                btns(f).Enabled = True
            Next
            Button5.Enabled = True
        Catch
            MsgBox("An error prevented the project's loading. If you have finished a project and you want to play it again choose File-->Open Project...", MsgBoxStyle.Critical)
            CancelProject()
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        ListBox1.SelectedItem = ListBox1.Items.Item(listindex)
        ListBox2.SelectedItem = ListBox2.Items.Item(listindex)
        Label5.Text = (((k - 2) / 9) + 1).ToString & "/" & ((filetext.Count - 4) / 9).ToString
        index = ((k - 2) / 9)

        'Normal GameMode
        If GameMode = "Normal" Then
            'If game mode is normal, then hide the listboxes
            ListBox1.Visible = False
            ListBox2.Visible = False

            ReDim Preserve Answers((filetext.Count - 4) / 9)


            If listindex Mod 5 = 0 Then
                If listindex = 0 Then
                    Label7.Text = ListBox1.SelectedItem
                Else
                    Label7.Text = ListBox1.Items.Item(listindex - 1)
                End If
            End If

            x = filetext(0)
            TextBox2.Text = filetext(1)
            TextBox1.Text = filetext(k)

            If a = True Then
                Label2.Text = filetext(k + 1)
                a = False
            End If

            Button1.Text = filetext(k + 2)
            Button2.Text = filetext(k + 3)
            Button3.Text = filetext(k + 4)
            Button4.Text = filetext(k + 5)
            help = filetext(k + 6)
            correctans = filetext(k + 7)
            Label18.Text = filetext(k + 8)

            Button1.BackColor = Color.BlueViolet
            Button2.BackColor = Color.BlueViolet
            Button3.BackColor = Color.BlueViolet
            Button4.BackColor = Color.BlueViolet
            Select Case Answers(((k - 2) / 9))
                Case 1
                    Button1.BackColor = Color.YellowGreen
                Case 2
                    Button2.BackColor = Color.YellowGreen
                Case 3
                    Button3.BackColor = Color.YellowGreen
                Case 4
                    Button4.BackColor = Color.YellowGreen
            End Select

            'The user answered
        If w <> 0 Then
                Answers(index) = w
                w = 0
            If filetext(k + 9) = "End" Then
                Label5.Text = ((filetext.Count - 4) / 9).ToString & "/" & ((filetext.Count - 4) / 9).ToString
                'a = False
                'Timer3.Stop()
                'CancelProject()
                'Timer1.Stop()
            Else
                a = True
                k += 9
            End If
        End If

        ElseIf GameMode = "Game" Then
        ListBox1.Visible = True
        ListBox2.Visible = True
        x = filetext(0)
        TextBox2.Text = filetext(1)
        TextBox1.Text = filetext(k)

        If a = True Then
            Label2.Text = filetext(k + 1)
            a = False
        End If

        Button1.Text = filetext(k + 2)
        Button2.Text = filetext(k + 3)
        Button3.Text = filetext(k + 4)
        Button4.Text = filetext(k + 5)
        help = filetext(k + 6)
        correctans = filetext(k + 7)
        Label18.Text = filetext(k + 8)

        'If the answer is not correct
        If w <> 0 And w <> correctans Then
            lives -= 1
            w = 0
            If lives = 0 Then
                    If MsgBox("Hai perso tute le vite." & vbNewLine & "      ----Game Over----      " & vbNewLine & "Ricominciare?", MsgBoxStyle.YesNo, "Game Over") = DialogResult.Yes Then
                        restart()
                    End If
            End If
            If filetext(k + 9) = "End" Then
                    MsgBox("Congratulazioni! Hai completato il progetto", MsgBoxStyle.OkOnly)
                a = False
                Timer3.Stop()
                CancelProject()
                Timer1.Stop()
            Else
                a = True
                k += 9
            End If
        End If

        'If the answer is correct
        If w = correctans Then
            w = 0
            MsgBox("La tua risposta è corretta!", MsgBoxStyle.OkOnly)
            listindex += 1
            For f = 0 To 3
                btns(f).Enabled = True
            Next
            If filetext(k + 9) = "End" Then
                Label5.Text = ((filetext.Count - 4) / 9).ToString & "/" & ((filetext.Count - 4) / 9).ToString
                MsgBox("Congratulazioni! Hai completato il progetto", MsgBoxStyle.OkOnly)
                a = False
                Timer3.Stop()
                CancelProject()
                Timer1.Stop()
            Else
                a = True
                k += 9
            End If

        End If
        End If



    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btns(0) = Button1
        btns(1) = Button2
        btns(2) = Button3
        btns(3) = Button4
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        w = 1
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        w = 2
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        w = 3
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        w = 4
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Button6.Enabled = Timer1.Enabled
        Button7.Enabled = Timer1.Enabled
        If stoplabel = True Then
        ElseIf stoplabel = False Then
            Label9.Left -= 1
            If (Label9.Left + Label9.Width) < 0 Then
                Label9.Left = Me.Width
            End If
        End If
        Select Case lives
            Case 5
                Label19.Text = "YYYYY"
            Case 4
                Label19.Text = "YYYY"
            Case 3
                Label19.Text = "YYY"
            Case 2
                Label19.Text = "YY"
            Case 1
                Label19.Text = "Y"
            Case 0
                Label19.Text = ""
        End Select
    End Sub
    Sub restart()
        listindex = 0
        Label19.Text = "YYYY"
        k = 2
        Timer1.Stop()
        w = 0
        TextBox1.Clear()
        a = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        lives = 4
        ' StatoAttualeToolStripMenuItem.Enabled = True
        Percent50TSMI.Enabled = True
        JumpQuestion.Enabled = True
        HelpTSMI.Enabled = True
        HelpTSMI.Text = "Aiuti (x3)"
        helpnumber = 3
        Timer1.Start()
        Timer3.Start()
        For f = 0 To 3
            btns(f).Enabled = True
        Next
        Button5.Enabled = True
    End Sub
    Private Sub AiutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTSMI.Click
        MsgBox(help, MsgBoxStyle.OkOnly, "aiuto alla domanda")
        helpnumber -= 1
        If helpnumber = 0 Then
            MsgBox("Hai finito gli aiuti!")
            HelpTSMI.Enabled = False
        End If
        HelpTSMI.Text = "Aiuto (x" & helpnumber & ")"
    End Sub
    Private Sub CambioDomandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        JumpQuestion.Enabled = False
        w = correctans
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Sei sicuro?", MsgBoxStyle.YesNo) = DialogResult.Yes Then
            If GameMode = "Normal" Then
                results = 0
                MsgBox(Answers.Count - 1)
                For j = 0 To Answers.Count - 1
                    If Answers(j) = filetext(9 * j) Then
                        results += 1
                    End If
                Next
                percent = results / (Answers.Count - 1)
                Label12.Text = "Hai risposto correttamente ad un numero di domande pari a " & results & ", per una percentuale pari a " & percent & "%"
            Else
                MsgBox("Hai appena vinto " & Label7.Text & " Euro!")
                Timer1.Stop()
                Timer3.Stop()
                CancelProject()
            End If


        End If
    End Sub
    Private Sub CancelProject()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        TextBox1.Text = ""
        help = ""
        Label19.Text = "YYYY"
        'Label5.Text = ""
        Label7.Text = ""
        Label2.Text = 5000.0
        a = True
        Timer1.Stop()
        Timer3.Stop()
        listindex = 0
        For f = 0 To 3
            btns(f).Enabled = True
        Next
        Button5.Enabled = False
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TimeTrialTSMI.Checked = True Then
            Label2.Text -= 0.1
            If Label2.Text = 0 Then
                If MsgBox("Il tempo è terminato. Ricominciare?", MsgBoxStyle.YesNo, "Tempo scaduto") = DialogResult.Yes Then
                    restart()
                Else
                    CancelProject()
                End If
            End If
        End If
    End Sub
    Private Sub Label9_enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        stoplabel = True
        Label9.ForeColor = Color.Gold
    End Sub
    Private Sub Label9_exit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        stoplabel = False
        Label9.ForeColor = Color.DarkBlue
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        MsgBox("Creato da GameShards Software (c) 2016")
        'gsc = New GameShardsCore.GameShardsCoreBETA
        'gsc.OpenBrowser()
    End Sub
    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        kj = 2
        Dim albutton As SByte = -1
        Do While kj <> 0
            Dim rdn As Random
            rdn = New Random
            Dim bl As Byte = rdn.Next(0, 3)
            If bl <> (correctans - 1) And albutton <> bl Then
                albutton = bl
                btns(bl).Enabled = False
                kj -= 1
            End If
        Loop
    End Sub
    Private Sub RicominciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartTSMI.Click
        CancelProject()
        startproject(Form2.SaveFileDialog1.FileName)
    End Sub
    Private Sub LanguageTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageTSMI.Click
        Dialog2.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If k > 10 Then
            k -= 9
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If Not filetext(k + 9) = "End" Then
            k += 9
        End If
    End Sub
End Class
