Imports GameShardsCore
Imports GameShardsCore.Encryptor
Imports System.IO

Public Class AreaCompito

    'Base variables
    Public CurrentProject As Project
    Public CurrentQuestion As Question
    Public Helps As Integer = 3
    Public Answers As New List(Of Byte)
    Public Questions As New List(Of Question)

    'Core variables
    Dim FileReader As StreamReader
    Dim Enc As Encryptor
    Dim w As StreamWriter

    'Reader Variables
    Dim FileText As String
    Dim FileParts As List(Of String)

    'Temp Variables
    Dim SIndex As Integer

#Region "MenuItems"
    Private Sub EditorDomandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectEditor.Click
        AreaAmministratore.Show()
        Me.Hide()
    End Sub
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click
        Me.Close()
    End Sub


#End Region

#Region "Subs"
    Public Sub StartProject(ByVal ProjectPath As String)
        'HelpTSMI.Enabled = True
        Try
            FileReader = New StreamReader(ProjectPath)
            FileText = Enc.TranslationEncrypt(FileReader.ReadToEnd, -7)
            FileParts = Split(FileText, "§").ToList
            FileReader.Close()
            RestartProject()
        Catch
            MsgBox("An error prevented the project's loading. If you have finished a project and you want to play it again choose File-->Open Project...", MsgBoxStyle.Critical)
            CancelProject()
        End Try
    End Sub

    Public Sub InitializeProject()
        Answers.Clear()
    End Sub

    Public Sub RestartProject()
        Answers.Clear()
    End Sub

    Public Sub CancelProject()
        Answers.Clear()
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Label9.Left + Label9.Width <= 0 Then
            Label9.Left = Me.Width
        Else
            Label9.Left -= 1
        End If
    End Sub

    Private Sub OpenProjectTSMI_Click(sender As System.Object, e As System.EventArgs) Handles OpenProjectTSMI.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenProject(OpenFileDialog1.FileName)
        End If
    End Sub

    Public Sub OpenProject(ByVal location As String)
        'Try
        Dim p As New Project
        FileReader = New StreamReader(location)
        Dim content As String
        Dim splits As New List(Of String)
        Enc = New Encryptor
        content = Enc.TranslationEncrypt(FileReader.ReadToEnd, -17)
        splits = Split(content, "§").ToList

        Questions.Clear()
        UpdateListboxes()

        p.Name = splits(0)
        p.ErrorPunishment = Convert.ToBoolean(splits(2))
        p.PointsRemovedOnError = Convert.ToSingle(splits(3))
        p.Author = splits(4)
        p.Contributors = Split(splits(5), ";")
        p.Helps = splits(6)
        p.Simulation = splits(7)
        p.Password = splits(8)

        'gets the name and removes it from the strings list
        splits.RemoveAt(0) 'removes project name as it is no longer required
        Dim count As Integer = splits(0)
        splits.RemoveAt(0) 'project count, only used in project play, so ingoring that info, too
        splits.RemoveAt(0) 'removes the error punishment flag, as it is no longer required
        splits.RemoveAt(0) 'removes the number of points removed on error, as it is no longer requires
        splits.RemoveAt(0) 'removes the author
        splits.RemoveAt(0) 'removes the contributors
        splits.RemoveAt(0) 'removes the number of helps
        splits.RemoveAt(0) 'removes the simulation flag
        splits.RemoveAt(0) 'removes the password

        For x = 0 To (count - 1) * 10 Step +10 '((splits.Count / 10) - 1) Step 10
            'FORMAT: 
            Dim q As New Question
            q.Text = splits(x)
            q.A = splits(x + 1)
            q.B = splits(x + 2)
            q.C = splits(x + 3)
            q.D = splits(x + 4)
            q.Correct = Convert.ToInt32(splits(x + 5))
            q.Help = splits(x + 6)
            q.Time = splits(x + 7)
            q.Category = Convert.ToByte(splits(x + 8))
            q.ID = splits(x + 9)
            Questions.Add(q)
        Next
        p.Questions = Questions
        CurrentProject = p
        UpdateListboxes()
        FileReader.Close()

        mainlbl.Text = String.Format("Nome progetto: {0}. Autore: {1}. Collaboratori: {2}. Numero domande: {3}. Viene assegnato 1 punto per ogni risposta corretta. Si hanno a disposizione {4} aiuti. ", p.Name, p.Author, String.Join(", ", p.Contributors), CheckedListBox1.Items.Count, p.Helps)
        If p.ErrorPunishment Then
            mainlbl.Text &= String.Format("Inoltre verranno sottratti {0} punti per ogni risposta errata", p.PointsRemovedOnError)
        End If
        Helps = p.Helps
        Label3.Text = p.Helps

        If Not CheckedListBox1.Items.Count < 1 Then
            CheckedListBox1.SelectedIndex = 0
        End If
        'Catch ex As Exception
        'MsgBox("Errore nell'apertura del file. Non è stato possibile aprire il progetto. Il file potrebbe essere obsoleto e/o danneggiato.", MsgBoxStyle.Critical)
        'End Try
    End Sub

    Public Sub UpdateListboxes()
        SIndex = CheckedListBox1.SelectedIndex
        CheckedListBox1.Items.Clear()
        For Each q As Question In Questions
            CheckedListBox1.Items.Add(q.Text)
        Next
        'ListBox1.Items.Clear()
        'For x = 0 To CheckedListBox1.Items.Count - 1
        '    'metodo elegante ma rischioso, con directCast. può essere aggirato con questions(x).text invece di DirectCast(Listbox1.Items(x), Question).Text
        '    ListBox1.Items.Add(DirectCast(CheckedListBox1.Items(x), Question).Text)
        'Next
        Try
            CheckedListBox1.SelectedIndex = SIndex
        Catch ex As ArgumentOutOfRangeException
            CheckedListBox1.SelectedIndex = -1
        Catch ex As Exception
            If Not TypeOf ex Is ArgumentOutOfRangeException Then
                MsgBox("Errore nell'aggiornamento delle liste. Riporta all'autore. " & ex.ToString)
            End If
        End Try


    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If Not CheckedListBox1.SelectedIndex = -1 Then
            TextBox1.Text = Questions(CheckedListBox1.SelectedIndex).Text
            Button1.Text = Questions(CheckedListBox1.SelectedIndex).A
            Button2.Text = Questions(CheckedListBox1.SelectedIndex).B
            Button3.Text = Questions(CheckedListBox1.SelectedIndex).C
            Button4.Text = Questions(CheckedListBox1.SelectedIndex).D
            If Questions(CheckedListBox1.SelectedIndex).HelpShown Then
                TextBox2.Text = Questions(CheckedListBox1.SelectedIndex).Help
            Else
                TextBox2.Clear()
            End If
            Catlbl.Text = GetCategoryStringFromID(Questions(CheckedListBox1.SelectedIndex).Category)
            Label1.Text = CheckedListBox1.SelectedIndex + 1
            Select Case True
                Case Questions(CheckedListBox1.SelectedIndex).UserAnswer = 0
                    Button1.BackColor = Color.Yellow
                    Button2.BackColor = Color.RoyalBlue
                    Button3.BackColor = Color.RoyalBlue
                    Button4.BackColor = Color.RoyalBlue
                Case Questions(CheckedListBox1.SelectedIndex).UserAnswer = 1
                    Button1.BackColor = Color.RoyalBlue
                    Button2.BackColor = Color.Yellow
                    Button3.BackColor = Color.RoyalBlue
                    Button4.BackColor = Color.RoyalBlue
                Case Questions(CheckedListBox1.SelectedIndex).UserAnswer = 2
                    Button1.BackColor = Color.RoyalBlue
                    Button2.BackColor = Color.RoyalBlue
                    Button3.BackColor = Color.Yellow
                    Button4.BackColor = Color.RoyalBlue
                Case Questions(CheckedListBox1.SelectedIndex).UserAnswer = 3
                    Button1.BackColor = Color.RoyalBlue
                    Button2.BackColor = Color.RoyalBlue
                    Button3.BackColor = Color.RoyalBlue
                    Button4.BackColor = Color.Yellow
                Case Else
                    Button1.BackColor = Color.RoyalBlue
                    Button2.BackColor = Color.RoyalBlue
                    Button3.BackColor = Color.RoyalBlue
                    Button4.BackColor = Color.RoyalBlue
            End Select
        Else
            Label1.Text = "--"
        End If
    End Sub

    Public Function GetCategoryStringFromID(ByVal val As Byte) As String
        Select Case True
            Case val = 0
                Return "Algebra"
            Case val = 1
                Return "Altro"
            Case val = 2
                Return "Aritmetica"
            Case val = 3
                Return "Arte"
            Case val = 4
                Return "Attualità"
            Case val = 5
                Return "Chimica"
            Case val = 6
                Return "Cultura"
            Case val = 7
                Return "Curiosità"
            Case val = 8
                Return "Elettronica"
            Case val = 9
                Return "Filosofia"
            Case val = 10
                Return "Fisica"
            Case val = 11
                Return "  Geografia"
            Case val = 12
                Return "Grammatica"
            Case val = 13
                Return "Informatica"
            Case val = 14
                Return "Letteratura"
            Case val = 15
                Return "Meccanica"
            Case val = 16
                Return "Passatempo"
            Case val = 17
                Return "Religione"
            Case val = 18
                Return "Sanità"
            Case val = 19
                Return "Scienza"
            Case val = 20
                Return "Sport"
            Case val = 21
                Return "Storia"
            Case val = 22
                Return "Svago"
            Case Else
                Return "Altro"
        End Select
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Try
            Select Case True
                Case sender Is Button1
                    Questions(CheckedListBox1.SelectedIndex).UserAnswer = 0
                Case sender Is Button2
                    Questions(CheckedListBox1.SelectedIndex).UserAnswer = 1
                Case sender Is Button3
                    Questions(CheckedListBox1.SelectedIndex).UserAnswer = 2
                Case sender Is Button4
                    Questions(CheckedListBox1.SelectedIndex).UserAnswer = 3
            End Select
            UpdateChecks()
            If Not CheckedListBox1.SelectedIndex = CheckedListBox1.Items.Count - 1 Then
                CheckedListBox1.SelectedIndex += 1
            End If
        Catch
        End Try
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If CheckedListBox1.Items.Count > 0 AndAlso CheckedListBox1.SelectedIndex <> -1 Then
            Questions(CheckedListBox1.SelectedIndex).UserAnswer = -1
            UpdateChecks()
            If Not CheckedListBox1.SelectedIndex = CheckedListBox1.Items.Count - 1 Then
                CheckedListBox1.SelectedIndex += 1
            End If
        End If
    End Sub

    Public Sub UpdateChecks()
            For x = 0 To Questions.Count - 1
                If Questions(x).UserAnswer <> -1 Then
                    CheckedListBox1.SetItemChecked(x, True)
                Else
                    CheckedListBox1.SetItemChecked(x, False)
                End If
            Next
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        NextQ()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PrevQ()
    End Sub

    Public Sub NextQ()
        If CheckedListBox1.Items.Count > 0 Then
            If Not CheckedListBox1.SelectedIndex = CheckedListBox1.Items.Count - 1 Then
                CheckedListBox1.SelectedIndex += 1
            Else
                CheckedListBox1.SelectedIndex = 0
            End If
        End If
    End Sub

    Public Sub PrevQ()
        If CheckedListBox1.Items.Count > 0 Then
            If Not CheckedListBox1.SelectedIndex = 0 Then
                CheckedListBox1.SelectedIndex -= 1
            Else
                CheckedListBox1.SelectedIndex = CheckedListBox1.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If CheckedListBox1.Items.Count > 0 Then
            If Not CheckIfAllCheckedInRange(0, CheckedListBox1.Items.Count - 1) Then

                'MsgBox("Missing answers")
                If Not CheckIfAllCheckedInRange(CheckedListBox1.SelectedIndex - 1, 0, True) Then
                    'MsgBox("selection to end")
                    For x = CheckedListBox1.SelectedIndex - 1 To 0 Step -1
                        If Not CheckedListBox1.GetItemChecked(x) Then
                            CheckedListBox1.SelectedIndex = x
                            Exit For
                        End If
                    Next

                Else
                    'MsgBox("start to selection")
                    For x = CheckedListBox1.Items.Count - 1 To 0 Step -1
                        If Not CheckedListBox1.GetItemChecked(x) Then
                            CheckedListBox1.SelectedIndex = x
                            Exit For
                        End If
                    Next
                End If
            Else
                MsgBox("Hai dato una risposta a tutte le domande del progetto. Se si è sicuri delle proprie risposte cliccare su ""Stop"".", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click

        If CheckedListBox1.Items.Count > 0 Then
            If Not CheckIfAllCheckedInRange(0, CheckedListBox1.Items.Count - 1) Then
                'MsgBox("Missing answers")
                If Not CheckIfAllCheckedInRange(CheckedListBox1.SelectedIndex + 1, CheckedListBox1.Items.Count - 1) Then
                    'MsgBox("selection to end")
                    For x = CheckedListBox1.SelectedIndex + 1 To CheckedListBox1.Items.Count - 1
                        If Not CheckedListBox1.GetItemChecked(x) Then
                            CheckedListBox1.SelectedIndex = x
                            Exit For
                        End If
                    Next

                Else
                    'MsgBox("start to selection")
                    For x = 0 To CheckedListBox1.Items.Count - 1
                        If Not CheckedListBox1.GetItemChecked(x) Then
                            CheckedListBox1.SelectedIndex = x
                            Exit For
                        End If
                    Next
                End If
            Else
                MsgBox("Hai dato una risposta a tutte le domande del progetto. Se si è sicuri delle proprie risposte cliccare su ""Stop"".", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Public Function CheckIfAllCheckedInRange(ByVal StartIndex As Integer, ByVal EndIndex As Integer, Optional ByVal Backwards As Boolean = False) As Boolean
        If Not Backwards Then
            For x = StartIndex To EndIndex
                If Not CheckedListBox1.GetItemChecked(x) Then
                    Return False
                    Exit Function
                End If
            Next
            Return True
        Else
            For x = StartIndex To EndIndex Step -1
                If Not CheckedListBox1.GetItemChecked(x) Then
                    Return False
                    Exit Function
                End If
            Next
            Return True
        End If
    End Function

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If CheckedListBox1.Items.Count > 0 Then
            If MsgBox("Sei sicuro di voler terminare il test? Cliccando su ""Sì"" riceverai il risultato del test", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Dialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then




                    If CurrentProject.Simulation Then
                        Finished.ShowDialog()
                    Else
                        Finished.Show()
                        Finished.Hide()
                    End If



                    SaveFileDialog1.FileName = "Risultati test " & CurrentProject.Name & " - " & Dialog2.TextBox1.Text & " " & Dialog2.TextBox2.Text & "(" & Dialog2.TextBox3.Text & ")"
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        w = New StreamWriter(SaveFileDialog1.FileName)
                        Dim content As String = CurrentProject.Password & "§" & CurrentProject.Author & "§"
                        content &= Dialog2.TextBox1.Text & " " & Dialog2.TextBox2.Text & " " & Dialog2.TextBox3.Text & " (" & Now.Date & ") " & vbNewLine
                        content &= vbNewLine
                        For x = 0 To Questions.Count - 1
                            content &= "Domanda " & x & ": " & Questions(x).Text & vbNewLine
                            Select Case True
                                Case Questions(x).Correct = 0
                                    content &= "Risposta corretta: " & Questions(x).A
                                Case Questions(x).Correct = 1
                                    content &= "Risposta corretta: " & Questions(x).B
                                Case Questions(x).Correct = 2
                                    content &= "Risposta corretta: " & Questions(x).C
                                Case Questions(x).Correct = 3
                                    content &= "Risposta corretta: " & Questions(x).D
                            End Select
                            content &= vbNewLine

                            Select Case True
                                Case Questions(x).UserAnswer = 0
                                    content &= "Risposta dell' alunno: A (" & Questions(x).A & ")"
                                Case Questions(x).UserAnswer = 1
                                    content &= "Risposta dell' alunno: B(" & Questions(x).B & ")"
                                Case Questions(x).UserAnswer = 2
                                    content &= "Risposta dell' alunno: C(" & Questions(x).C & ")"
                                Case Questions(x).UserAnswer = 3
                                    content &= "Risposta dell' alunno: D(" & Questions(x).D & ")"
                                Case Questions(x).UserAnswer = -1
                                    content &= "Risposta dell' alunno: NON RISPOSTA (Astensione)"
                            End Select
                            content &= vbNewLine
                            content &= vbNewLine
                        Next
                        With Finished
                            content &= String.Format("Risultati del progetto {6} di {7}: L'alunno ha risposto a {0} domande su {1}, di cui {2} corrette e {3} sbagliate. Ha raggiunto il voto {4}, rispondendo al {5}% dei quesiti proposti", .count - .notans, .count, .corrects, .wrong, .votelaw, .percent, CurrentProject.Name, CurrentProject.Author)
                        End With
                        w.Write(Enc.SymmetryEncrypt(content))
                        w.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If CheckedListBox1.Items.Count > 0 AndAlso CheckedListBox1.SelectedIndex <> -1 Then
            If Helps > 0 Then
                TextBox2.Text = Questions(CheckedListBox1.SelectedIndex).Help
                If Not (Questions(CheckedListBox1.SelectedIndex).Help = String.Empty OrElse Questions(CheckedListBox1.SelectedIndex).Help = "" OrElse Questions(CheckedListBox1.SelectedIndex).HelpShown) Then
                    Questions(CheckedListBox1.SelectedIndex).HelpShown = True
                    Helps -= 1
                    Label3.Text = Helps
                End If
            Else
                MsgBox("Hai terminato gli aiuti!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub AreaCompito_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuPrincipale.Show()
    End Sub

    Private Sub AreaCompito_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case True
            Case e.KeyCode = Keys.Down
                NextQ()
            Case e.KeyCode = Keys.Up
                PrevQ()
        End Select
    End Sub

    Private Sub RestartTSMI_Click(sender As System.Object, e As System.EventArgs) Handles RestartTSMI.Click
        If MsgBox("Sei sicuro di voler ricominciare il progetto? Tutte le risposte saranno azzerate.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                OpenProject(OpenFileDialog1.FileName)
            Catch ex As FileNotFoundException
                MsgBox("ERRORE: impossibile ricominciare il progetto: File non trovato. Cliccare su File-->Apri Progetto e aprire nuovamente il progetto per ricominciare", MsgBoxStyle.Critical)
            Catch ex As Exception
                MsgBox("ERRORE: impossibile ricominciare il progetto. Cliccare su File-->Apri Progetto e aprire nuovamente il progetto per ricominciare", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub AreaCompito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckedListBox1.Height = Me.Height - 80
    End Sub
End Class
