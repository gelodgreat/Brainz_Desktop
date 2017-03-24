Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class Login

    Public globaluserid As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
    End Sub


    Private Sub pb_settings_Click(sender As Object, e As EventArgs) Handles pb_settings.Click
        Hide()
        LoginSettings.ShowDialog()

    End Sub

    Private Sub RadGroupBox1_Enter(sender As Object, e As EventArgs) Handles RadGroupBox1.Enter
        AcceptButton = log_btn_login
    End Sub

    Private Sub log_btn_login_Click(sender As Object, e As EventArgs) Handles log_btn_login.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            query = "SELECT * FROM accounts WHERE username=@username AND password=@password OR userid=@username"
            Command = New MySqlCommand(query, mysqlconn)
            Command.Parameters.AddWithValue("username", log_tb_username.Text)
            Command.Parameters.AddWithValue("password", log_tb_password.Text)
            reader = Command.ExecuteReader

            Dim count As Integer
            count = 0


            If count >= 0 Then

                While reader.Read
                    globaluserid = reader.GetString("userid")
                End While

                Me.Hide()
                Main.Show()
                log_tb_password.Clear()
                log_tb_username.Clear()
                log_tb_username.Focus()
            Else
                MsgBox("Invalid User Account!")
                log_tb_password.Clear()
                log_tb_username.Clear()
                log_tb_username.Focus()
            End If
            mysqlconn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try

    End Sub
End Class
