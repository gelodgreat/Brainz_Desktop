Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Public Class LoginSettings
    Public globaluserid As String
    Private Sub LoginSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub log_btn_dark_Click(sender As Object, e As EventArgs)
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
    End Sub

    Private Sub log_btn_light_Click(sender As Object, e As EventArgs)
        ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light"
    End Sub

    Private Sub log_btn_metro_Click(sender As Object, e As EventArgs)
        ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue"
    End Sub
    Private Sub reg_tb_username_TextChanged(sender As Object, e As EventArgs) Handles reg_tb_username.TextChanged
        Dim bdaystring As String
        Dim useridstring As String
        bdaystring = rdpt_bday.Value.ToString("yyMMdd")
        useridstring = bdaystring + "" + reg_tb_username.Text
        globaluserid = useridstring

        lbl_globaluserid.Text = globaluserid

    End Sub

    Private Sub reg_signup_Click(sender As Object, e As EventArgs) Handles reg_signup.Click

        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring
        Dim Command = New MySqlCommand
        Dim reader As MySqlDataReader



        Try

            If (reg_tb_username.Text = "") Or (reg_tb_password.Text = "") Or (reg_tb_repassword.Text = "") Then
                MsgBox("Please fill all fields!")
            Else

                mysqlconn.Open()
                query = "SELECT * FROM accounts WHERE userid='" & lbl_globaluserid.Text & "' OR username='" & reg_tb_username.Text & "'"
                Command = New MySqlCommand(query, mysqlconn)
                reader = Command.ExecuteReader
                Dim count As Integer
                count = 0

                While reader.Read
                    count += 1
                End While

                If count >= 1 Then
                    MsgBox("Username '" & reg_tb_username.Text & "' is already used. ")
                Else

                    If (reg_tb_password.Text) <> (reg_tb_repassword.Text) Then
                        MsgBox("Password doesn't match!")
                        reg_tb_password.Text = ""
                        reg_tb_repassword.Text = ""
                        reg_tb_password.Focus()
                    Else

                        mysqlconn.Close()
                        mysqlconn.Open()
                        query = "INSERT INTO accounts VALUES (@uid,@bday,@username,@password)"
                        Command = New MySqlCommand(query, mysqlconn)
                        Command.Parameters.AddWithValue("uid", lbl_globaluserid.Text)
                        Command.Parameters.AddWithValue("bday", Format(CDate(rdpt_bday.Value), "yyyy-MM-dd"))
                        Command.Parameters.AddWithValue("username", reg_tb_username.Text)
                        Command.Parameters.AddWithValue("password", reg_tb_password.Text)
                        reader = Command.ExecuteReader

                        reg_tb_username.Focus()
                        reg_tb_username.Text = ""
                        reg_tb_password.Text = ""
                        reg_tb_repassword.Text = ""
                        MsgBox("Account Registered!")


                        mysqlconn.Close()

                    End If
                End If
            End If


        Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try




    End Sub

    Private Sub LoginSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        Login.Show()
    End Sub
End Class
