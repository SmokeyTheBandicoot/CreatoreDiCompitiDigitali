Public Class MenuPrincipale
    Dim Drawn As Boolean = False
    Dim a As Boolean = True

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        Label5.Text = "Svolgi un test creato con Bit-Test"
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        Label5.Text = "Crea un test digitale, condividilo e sottoponi altri utenti al tuo test"
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        Label5.Text = "Vedi i risultati di coloro che sono stati sottoposti al tuo test"
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label5.Text = "A presto!"
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        Label5.Text = "Vedi i crediti e la licenza di BiT-Test"
    End Sub

    Public Sub SetColor(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter, Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label7.MouseEnter
        Label1.ForeColor = Color.Gray
        Label2.ForeColor = Color.Gray
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Gray
        Label7.ForeColor = Color.Gray
        Try
            DirectCast(sender, Label).ForeColor = Color.FromArgb(0, 194, 255)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Correttore_compiti.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        AreaAmministratore.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        AreaCompito.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Credits.Show()
        Me.Hide()
    End Sub

    Private Sub MenuPrincipale_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        Label1.ForeColor = Color.Gray
        Label2.ForeColor = Color.Gray
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Gray
        Label7.ForeColor = Color.Gray
        Label5.Text = "Benvenuto in BiT-Test (C) di GameShards Software (R)! Ti aiuteremo a creare nuovi test in formato digitale, condividerli e collezionarne i risultati con Bit-Test!"
        Label9.Text = ""
        Label9.ForeColor = Color.Gray
    End Sub

    Private Sub MenuPrincipale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.Text = "GameShards BiT-Test " + My.Application.Info.Version.ToString

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles FBPict.Click
        Process.Start("https://www.facebook.com/gameshardsSTB/")
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles TWPict.Click
        Process.Start("https://twitter.com/gameshardsSW")
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles GHPict.Click
        Process.Start("https://github.com/SmokeyTheBandicoot/CreatoreDiCompitiDigitali/issues")
    End Sub

    Private Sub FBPict_MouseEnter(sender As Object, e As System.EventArgs) Handles FBPict.MouseEnter
        Label9.Text = "GameShards on Facebook"
        Label9.ForeColor = Color.FromArgb(59, 89, 152)
        FBPict.BackgroundImage = My.Resources.facebook_on
    End Sub

    Private Sub TWPict_MouseEnter(sender As Object, e As System.EventArgs) Handles TWPict.MouseEnter
        Label9.Text = "GameShardsSW on Twitter"
        Label9.ForeColor = Color.FromArgb(64, 153, 255)
        TWPict.BackgroundImage = My.Resources.twitter_on
    End Sub

    Private Sub GHPict_MouseEnter(sender As Object, e As System.EventArgs) Handles GHPict.MouseEnter
        Label9.Text = "Segnala un problema di BiT-Test su GitHub"
        Label9.ForeColor = Color.FromArgb(50, 49, 49)
        GHPict.BackgroundImage = My.Resources.github_on
    End Sub

    Private Sub FBPict_MouseLeave(sender As Object, e As System.EventArgs) Handles FBPict.MouseLeave
        FBPict.BackgroundImage = My.Resources.facebook_off
    End Sub

    Private Sub TWPict_MouseLeave(sender As Object, e As System.EventArgs) Handles TWPict.MouseLeave
        TWPict.BackgroundImage = My.Resources.twitter_off
    End Sub

    Private Sub GHPict_MouseLeave(sender As Object, e As System.EventArgs) Handles GHPict.MouseLeave
        GHPict.BackgroundImage = My.Resources.github_off
    End Sub

    Private Sub MailPict_MouseLeave(sender As Object, e As System.EventArgs) Handles MailPict.MouseLeave
        MailPict.BackgroundImage = My.Resources.email_off
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles MailPict.MouseEnter
        Label9.ForeColor = Color.FromArgb(89, 45, 161)
        MailPict.BackgroundImage = My.Resources.email_on
        Label9.Text = "contattaci a: gameshardssoftware@hotmail.com"
    End Sub

    Private Sub MailPict_Click(sender As Object, e As EventArgs) Handles MailPict.Click
        Process.Start("mailto:gameshardssoftware@hotmail.com")
    End Sub
End Class


