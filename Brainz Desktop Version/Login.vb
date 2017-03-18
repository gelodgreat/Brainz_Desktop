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

    Private Sub log_btn_dark_Click(sender As Object, e As EventArgs) Handles log_btn_dark.Click
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
    End Sub

    Private Sub log_btn_light_Click(sender As Object, e As EventArgs) Handles log_btn_light.Click
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light"
    End Sub

    Private Sub log_btn_metro_Click(sender As Object, e As EventArgs) Handles log_btn_metro.Click
        ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue"
    End Sub

End Class
