Public Class Credentials

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Function Autenticate(ByVal aut As String, pass As String) As Boolean
        If TextBox1.Text = aut AndAlso TextBox2.Text = pass Then
            Return True
        End If
        Return False
    End Function
End Class