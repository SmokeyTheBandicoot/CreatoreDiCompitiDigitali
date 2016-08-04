Imports System.Windows.Forms

Public Class Dialog2

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Inserire i dati prima di proseguire. Se non si immettono i dati il test non potrà essere corretto dal docente")
        End If
    End Sub

    Private Sub Dialog2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "") AndAlso Me.DialogResult <> Windows.Forms.DialogResult.OK Then
            If MsgBox("Sei sicuro di voler chiudere questa finestra? Se la chiudi non potrai immettere i tuoi dati e il compito non verrà corretto.") = MsgBoxResult.Ok Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class
