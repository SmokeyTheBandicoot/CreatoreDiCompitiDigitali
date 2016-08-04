Imports GameShardsCore.Encryptor
Imports System.IO
Public Class Correttore_compiti

    Dim enc As GameShardsCore.Encryptor
    Dim r As StreamReader
    Dim t As String
    Dim splits As New List(Of String)

    Private Sub ApriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApriToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            r = New StreamReader(OpenFileDialog1.FileName)
            splits.Clear()
            enc = New GameShardsCore.Encryptor
            t = enc.SymmetryEncrypt(r.ReadToEnd)
            splits = Split(t, "§").ToList
            If Credentials.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Credentials.Autenticate(splits(0), splits(1)) Then
                    TextBox1.Text = splits(2)
                Else
                    MsgBox("Autore o password errata. Verificare che il BLOCK-MAIUSC. non sia inserito e riprovare.")
                End If
            End If
        End If
    End Sub

    Private Sub ChiudiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChiudiToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Correttore_compiti_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuPrincipale.Show()
    End Sub
End Class