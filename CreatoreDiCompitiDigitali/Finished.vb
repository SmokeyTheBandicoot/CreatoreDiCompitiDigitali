Public Class Finished
    Public corrects As Integer = 0
    Public count As Integer
    Public notans As Integer = 0
    Public wrong As Integer = 0
    Public percent As Byte
    Public vote As Double
    Public votelaw As Double
    Public pname As String
    Public paut As String

    Private Sub Finished_Show(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        With AreaCompito
            count = .Questions.Count
            For x = 0 To count - 1
                If .Questions(x).UserAnswer = .Questions(x).Correct Then
                    corrects += 1
                ElseIf .Questions(x).UserAnswer = -1 Then
                    notans += 1
                ElseIf .Questions(x).UserAnswer <> .Questions(x).Correct AndAlso .Questions(x).UserAnswer <> -1 Then
                    wrong += 1
                End If
            Next

            'If .CurrentProject.ErrorPunishment Then
            '    corrects -= .CurrentProject.PointsRemovedOnError * wrong
            'End If
            If corrects < 0 Then
                corrects = 0
            End If
            percent = (corrects * 100) / .Questions.Count
            vote = (10 * corrects) / count
            votelaw = (9 * corrects) / count + 1
        End With

        If votelaw >= 6 Then
            Label1.Text = "Congratulazioni!"
        Else
            Label1.Text = "Peccato :("
        End If

        Label2.Text = String.Format("Risultati del progetto {6} di {7}: Hai risposto a {0} domande su {1}, di cui {2} corrette e {3} sbagliate. Hai raggiunto il voto {4}, rispondendo al {5}% dei quesiti proposti", count - notans, count, corrects, wrong, votelaw, percent, AreaCompito.CurrentProject.Name, AreaCompito.CurrentProject.Author)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
            Me.Close()
    End Sub

    Private Sub Finished_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = Label1.Width
    End Sub
End Class