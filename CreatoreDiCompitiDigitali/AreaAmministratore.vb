Imports GameShardsCore
Imports GameShardsCore.Encryptor
Imports System.IO

Public Class AreaAmministratore

    'Core Variables
    Dim Enc As Encryptor
    Dim FileWriter As StreamWriter
    Dim FileReader As StreamReader

    'Base variables
    Dim Questions As New List(Of Question)
    Dim Project As Project

    'Temp variables
    Dim SelectedIndex As Integer

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        NumericUpDown1.Enabled = CheckBox1.Checked
    End Sub

    Private Sub NuovoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuovoToolStripMenuItem.Click
        If Questions.Count > 0 AndAlso Dialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox13.Clear()
            NumericUpDown2.Value = 3
            ClearTextboxes()
            Questions.Clear()
            UpdateListboxes()
            Project = Nothing
            Project = New Project
            MsgBox("Nuovo progetto creato", MsgBoxStyle.Information)
        Else
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox13.Clear()
            NumericUpDown2.Value = 3
            ClearTextboxes()
            Questions.Clear()
            UpdateListboxes()
            Project = Nothing
            Project = New Project
            MsgBox("Nuovo progetto creato", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ApriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApriToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenProject(OpenFileDialog1.FileName)
        End If
    End Sub

    Public Sub OpenProject(ByVal location As String)
        Try

            Dim p As New Project
            FileReader = New StreamReader(location)
            Dim content As String
            Dim splits As New List(Of String)
            content = FileReader.ReadToEnd
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

            TextBox13.Text = p.Name
            Label12.Text = p.Count
            CheckBox1.Checked = p.ErrorPunishment
            NumericUpDown1.Value = p.PointsRemovedOnError
            TextBox7.Text = p.Author
            NumericUpDown2.Value = p.Helps
            TextBox8.Text = String.Join(";", p.Contributors)
            CheckBox3.Checked = p.Simulation
            TextBox9.Text = p.Password


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
            'MsgBox(String.Join(",", splits))
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
            FileReader.Close()
            p.Questions = Questions
            UpdateListboxes()


            Label12.Text = p.Count
        Catch ex As Exception
            MsgBox("Errore nell'apertura del file. Non è stato possibile aprire il progetto. Il file potrebbe essere obsoleto e/o danneggiato.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Or TextBox1.Text = "" Then
            MsgBox("Impossibile aggiungere la domanda: la traccia è vuota")
            Exit Sub
        End If

        If TextBox2.Text = String.Empty OrElse TextBox1.Text = "" Then
            MsgBox("Impossibile aggiungere la domanda: la risposta A è vuota")
            Exit Sub
        End If
        If TextBox3.Text = String.Empty OrElse TextBox1.Text = "" Then
            MsgBox("Impossibile aggiungere la domanda: la risposta B è vuota")
            Exit Sub
        End If
        If TextBox4.Text = String.Empty OrElse TextBox1.Text = "" Then
            MsgBox("Impossibile aggiungere la domanda: la risposta C è vuota")
            Exit Sub
        End If
        If TextBox5.Text = String.Empty OrElse TextBox1.Text = "" Then
            MsgBox("Impossibile aggiungere la domanda: la risposta D è vuota")
            Exit Sub
        End If

        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("Impossibile aggiungere la domanda: la categoria non è specificata")
            Exit Sub
        End If

        If ComboBox2.SelectedIndex < 0 Then
            MsgBox("Impossibile aggiungere la domanda: la risposta corretta non è specificata")
            Exit Sub
        End If

        'If (TextBox6.Text = String.Empty OrElse TextBox6.Text = "") Then
        'If (Not (My.Computer.Keyboard.CtrlKeyDown Xor (Not CheckBox2.Checked))) AndAlso MsgBox("La domanda non contiene alcun aiuto. Inserirla comunque?") = MsgBoxResult.Yes Then
        Dim q As New Question
        q.Text = TextBox1.Text
        q.A = TextBox2.Text
        q.B = TextBox3.Text
        q.C = TextBox4.Text
        q.D = TextBox5.Text
        q.Correct = ComboBox2.SelectedIndex
        q.Category = ComboBox1.SelectedIndex
        q.Time = 100
        q.ID = 0
        q.Help = TextBox6.Text
        ClearTextboxes()
        Questions.Add(q)
        UpdateListboxes()
        MsgBox("Domanda aggiunta al progetto!", MsgBoxStyle.Information)
        ' End If
        ' End If

    End Sub

    Public Sub ClearTextboxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MsgBox("Sei sicuro di voler cancellare questa domanda dal progetto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Questions.RemoveAt(ListBox1.SelectedIndex)
            UpdateListboxes()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If MsgBox("Sei sicuro di voler cancellare tutte le domande del progetto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Questions.Clear()
            UpdateListboxes()
        End If
    End Sub

    Private Sub AreaAmministratore_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuPrincipale.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedIndex = -1 Then
            TextBox1.Text = Questions(ListBox1.SelectedIndex).Text
            TextBox2.Text = Questions(ListBox1.SelectedIndex).A
            TextBox3.Text = Questions(ListBox1.SelectedIndex).B
            TextBox4.Text = Questions(ListBox1.SelectedIndex).C
            TextBox5.Text = Questions(ListBox1.SelectedIndex).D
            TextBox6.Text = Questions(ListBox1.SelectedIndex).Help
            ComboBox1.SelectedIndex = Questions(ListBox1.SelectedIndex).Category
            ComboBox2.SelectedIndex = Questions(ListBox1.SelectedIndex).Correct
        End If
        'UpdateListboxes()
    End Sub

    Public Sub UpdateListboxes()
        SelectedIndex = ListBox1.SelectedIndex
        ListBox1.Items.Clear()
        For x = 0 To Questions.Count - 1

            With Questions(x)
                ListBox1.Items.Add(.Text & " - {" & .A & ", " & .B & ", " & .C & ", " & .D & "}")
            End With
        Next
        Try
            ListBox1.SelectedIndex = SelectedIndex
        Catch ex As ArgumentOutOfRangeException
            ListBox1.SelectedIndex = -1
        Catch ex As Exception
            If Not TypeOf ex Is ArgumentOutOfRangeException Then
                MsgBox("Errore nell'aggiornamento delle liste. Riporta all'autore. " & ex.ToString)
            End If
        End Try

        Label12.Text = Questions.Count
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        'If (TextBox6.Text = String.Empty OrElse TextBox6.Text = "") Then
        'If (Not (My.Computer.Keyboard.CtrlKeyDown Xor (Not CheckBox2.Checked))) AndAlso MsgBox("La domanda non contiene alcun aiuto. Inserirla comunque?") = MsgBoxResult.Yes Then
        If Not ListBox1.SelectedIndex = -1 Then

            If TextBox1.Text = String.Empty Or TextBox1.Text = "" Then
                MsgBox("Impossibile salvare la domanda: la traccia è vuota")
                Exit Sub
            End If

            If TextBox2.Text = String.Empty OrElse TextBox1.Text = "" Then
                MsgBox("Impossibile salvare la domanda: la risposta A è vuota")
                Exit Sub
            End If
            If TextBox3.Text = String.Empty OrElse TextBox1.Text = "" Then
                MsgBox("Impossibile salvare la domanda: la risposta B è vuota")
                Exit Sub
            End If
            If TextBox4.Text = String.Empty OrElse TextBox1.Text = "" Then
                MsgBox("Impossibile salvare la domanda: la risposta C è vuota")
                Exit Sub
            End If
            If TextBox5.Text = String.Empty OrElse TextBox1.Text = "" Then
                MsgBox("Impossibile salvare la domanda: la risposta D è vuota")
                Exit Sub
            End If

            If ComboBox1.SelectedIndex < 0 Then
                MsgBox("Impossibile salvare la domanda: la categoria non è specificata")
                Exit Sub
            End If

            If ComboBox2.SelectedIndex < 0 Then
                MsgBox("Impossibile salvare la domanda: la risposta corretta non è specificata")
                Exit Sub
            End If

            Dim q As Question = DirectCast(ListBox1.SelectedItem, Question)
            q.Text = TextBox1.Text
            q.A = TextBox2.Text
            q.B = TextBox3.Text
            q.C = TextBox4.Text
            q.D = TextBox5.Text
            q.Correct = ComboBox2.SelectedIndex
            q.Category = ComboBox1.SelectedIndex
            q.Time = 100
            q.ID = 0
            q.Help = TextBox6.Text
            ClearTextboxes()
            ListBox1.SelectedValue = q
            UpdateListboxes()
            MsgBox("Domanda salvata!", MsgBoxStyle.Information)
        Else
            MsgBox("Selezionare prima la domanda da modificare nell'elenco a sinistra", MsgBoxStyle.Exclamation)
        End If
        ' End If
        'end if
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ClearTextboxes()
    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalvaToolStripMenuItem.Click
        'do all the checks
        'If Project Is Nothing Then
        '    MsgBox("Non è possibile salvare un progetto senza prima averne creato o aperto uno. Per iniziare fare click su File->Nuovo progetto (Ctrl + N).", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        If TextBox13.Text = String.Empty Or TextBox13.Text = "" Then
            MsgBox("Impossibile salvare il progetto: il progetto è senza nome. Immettere un nome e riprovare.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Questions.Count < 1 Then
            MsgBox("Impossibile salvare il progetto: il progetto non contiene alcuna domanda. Inserire una domanda immettendo tutti i dati e facendo click su ""Nuova Domanda"".", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox7.Text = String.Empty Or TextBox7.Text = "" Then
            MsgBox("Impossibile salvare il progetto: specificare il nome dell'autore.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox1.Text.Contains("§") OrElse TextBox2.Text.Contains("§") OrElse TextBox3.Text.Contains("§") OrElse TextBox4.Text.Contains("§") OrElse TextBox5.Text.Contains("§") OrElse TextBox6.Text.Contains("§") OrElse TextBox7.Text.Contains("§") OrElse TextBox8.Text.Contains("§") OrElse TextBox13.Text.Contains("§") Then
            MsgBox("Impossibile salvare il progetto: le domande non possono contenere il carattere riservato ""§""", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox9.Text = "" Or TextBox9.Text = String.Empty Then
            MsgBox("Impossibile salvare il progetto: non è stata specificata alcuna password", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            SaveFileDialog1.FileName = TextBox13.Text
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                'creates a new project as saves it
                Dim p As New Project
                p.Name = TextBox13.Text
                p.Author = TextBox7.Text
                p.Contributors = Split(TextBox8.Text, ";")
                p.ErrorPunishment = CheckBox1.Checked
                p.PointsRemovedOnError = NumericUpDown1.Value
                p.Questions = Questions
                p.Helps = NumericUpDown2.Value
                p.Simulation = CheckBox3.Checked
                p.Password = TextBox9.Text


                FileWriter = New StreamWriter(SaveFileDialog1.FileName)
                Dim content As String = ""
                'gets the name and removes it from the strings list
                content = p.Name & "§"
                content &= p.Count & "§"
                content &= p.ErrorPunishment & "§"
                content &= p.PointsRemovedOnError & "§"
                content &= p.Author & "§"
                content &= String.Join(";", p.Contributors) & "§"
                content &= p.Helps & "§"
                content &= p.Simulation & "§"
                content &= p.Password & "§"

                For x = 0 To p.Count - 1
                    content &= Questions(x).Text & "§"
                    content &= Questions(x).A & "§"
                    content &= Questions(x).B & "§"
                    content &= Questions(x).C & "§"
                    content &= Questions(x).D & "§"
                    content &= Questions(x).Correct & "§"
                    content &= Questions(x).Help & "§"
                    content &= Questions(x).Time & "§"
                    content &= Questions(x).Category & "§"
                    content &= Questions(x).ID & "§"
                Next

                content &= "END"

                FileWriter.Write(content)
                FileWriter.Close()
            End If
        Catch ex As Exception
            MsgBox("Errore nel salvataggio del file. Non è stato possibile salvare il progetto. Errore sconosciuto", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
              'do all the checks
        'If Project Is Nothing Then
        '    MsgBox("Non è possibile salvare un progetto senza prima averne creato o aperto uno. Per iniziare fare click su File->Nuovo progetto (Ctrl + N).", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        If TextBox13.Text = String.Empty Or TextBox13.Text = "" Then
            MsgBox("Impossibile esportare il progetto: il progetto è senza nome. Immettere un nome e riprovare.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Questions.Count < 1 Then
            MsgBox("Impossibile esportare il progetto: il progetto non contiene alcuna domanda. Inserire una domanda immettendo tutti i dati e facendo click su ""Nuova Domanda"".", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox7.Text = String.Empty Or TextBox7.Text = "" Then
            MsgBox("Impossibile esportare il progetto: specificare il nome dell'autore.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox1.Text.Contains("§") OrElse TextBox2.Text.Contains("§") OrElse TextBox3.Text.Contains("§") OrElse TextBox4.Text.Contains("§") OrElse TextBox5.Text.Contains("§") OrElse TextBox6.Text.Contains("§") OrElse TextBox7.Text.Contains("§") OrElse TextBox8.Text.Contains("§") OrElse TextBox13.Text.Contains("§") Then
            MsgBox("Impossibile esportare il progetto: le domande non possono contenere il carattere riservato ""§""", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If TextBox9.Text = "" Or TextBox9.Text = String.Empty Then
            MsgBox("Impossibile esportare il progetto: non è stata specificata alcuna password", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Try
        SaveFileDialog2.FileName = TextBox13.Text
        If SaveFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then

            'creates a new project as saves it
            Dim p As New Project
            p.Name = TextBox13.Text
            p.Author = TextBox7.Text
            p.Contributors = Split(TextBox8.Text, ";")
            p.ErrorPunishment = CheckBox1.Checked
            p.PointsRemovedOnError = NumericUpDown1.Value
            p.Questions = Questions
            p.Helps = NumericUpDown2.Value
            p.Simulation = CheckBox3.Checked
            p.Password = TextBox9.Text

            FileWriter = New StreamWriter(SaveFileDialog2.FileName)
            Dim content As String = ""
            'gets the name and removes it from the strings list
            content = p.Name & "§"
            content &= p.Count & "§"
            content &= p.ErrorPunishment & "§"
            content &= p.PointsRemovedOnError & "§"
            content &= p.Author & "§"
            content &= String.Join(";", p.Contributors) & "§"
            content &= p.Helps & "§"
            content &= p.Simulation & "§"
            content &= p.Password & "§"

            For x = 0 To p.Count - 1
                content &= Questions(x).Text & "§"
                content &= Questions(x).A & "§"
                content &= Questions(x).B & "§"
                content &= Questions(x).C & "§"
                content &= Questions(x).D & "§"
                content &= Questions(x).Correct & "§"
                content &= Questions(x).Help & "§"
                content &= Questions(x).Time & "§"
                content &= Questions(x).Category & "§"
                content &= Questions(x).ID & "§"
            Next

            content &= "END"

            Enc = New Encryptor
            FileWriter.Write(Enc.TranslationEncrypt(content, +17))
            FileWriter.Close()
        End If
        'Catch ex As Exception
        'MsgBox("Errore nell'apertura del file. Non è stato possibile aprire il progetto. Il file potrebbe essere obsoleto e/o danneggiato.", MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub GiocaProgettoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GiocaProgettoToolStripMenuItem.Click
        AreaCompito.Show()
        Me.Hide()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class