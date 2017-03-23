Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles log_btn_login.Click



        Hide()
        Main.Show()
    End Sub

    Private Sub pb_settings_Click(sender As Object, e As EventArgs) Handles pb_settings.Click
        Hide()
        LoginSettings.ShowDialog()

    End Sub
End Class
