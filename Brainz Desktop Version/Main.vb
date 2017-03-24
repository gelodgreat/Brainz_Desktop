Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Public Class Main
    Public mainglobaluserid As String
    Dim dialog As DialogResult
    Private Sub btn_createreviewer_Click(sender As Object, e As EventArgs) Handles btn_createreviewer.Click
        Hide()
        CreateReviewer.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainglobaluserid = Login.globaluserid
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        dialog = RadMessageBox.Show(Me, "Are you sure you want to logout?", "Brainz.Inc", MessageBoxButtons.YesNo, RadMessageIcon.Question)

        If dialog = DialogResult.Yes Then
            Login.Show()
            Login.log_tb_username.Focus()
            Me.Dispose()

        Else

        End If
    End Sub
End Class
