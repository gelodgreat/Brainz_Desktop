Imports MySql.Data.MySqlClient
Public Class CreateReviewer

    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim reader As MySqlDataReader
    Dim levels(3) As String
    Dim subjects(3) As String



    Private Sub CreateReviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cbs()
        load_questions()
    End Sub

    Public Sub storing_arrays_cb()
        levels(0) = "Easy"
        levels(1) = "Normal"
        levels(2) = "Hard"
        levels(3) = "Brutal"

        subjects(0) = "Cisco"
        subjects(1) = "VB.Net"
        subjects(2) = "MySQL"
        subjects(3) = "Computer Essentials"
    End Sub

    Public Sub load_cbs()
        storing_arrays_cb()
        cb_subjects.Items.AddRange(subjects)
        cb_levels.Items.AddRange(levels)
    End Sub



    Public Sub load_questions()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try
            mysqlconn.Open()
            query = "SELECT * FROM reviewer"
            Command = New MySqlCommand(query, mysqlconn)
            sda.SelectCommand = Command
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            rgv_questions.DataSource = bsource
            sda.Update(dbdataset)
            mysqlconn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub qm_btn_add_Click(sender As Object, e As EventArgs) Handles qm_btn_add.Click

        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring

        Try
            mysqlconn.Open()
            query = "INSERT INTO reviewer (subject,levels,question,cha,chb,chc) VALUES (@subject,@levels,@question,@cha,@chb,@chc)"
            Command = New MySqlCommand(query, mysqlconn)
            Command.Parameters.AddWithValue("subject", cb_subjects.Text)
            Command.Parameters.AddWithValue("levels", cb_levels.SelectedItem)
            Command.Parameters.AddWithValue("question", tb_question.Text)
            Command.Parameters.AddWithValue("cha", tb_a.Text)
            Command.Parameters.AddWithValue("chb", tb_b.Text)
            Command.Parameters.AddWithValue("chc", tb_c.Text)
            reader = Command.ExecuteReader
            mysqlconn.Close()

            load_questions()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try



    End Sub


End Class
