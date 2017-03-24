Imports MySql.Data.MySqlClient

Module GlobalVariables

    Public mysqlconn As MySqlConnection
    Public connection As String = "SERVER='localhost';port='3306';database='brainzdesktopdb';username='root';password='root' "
    Public connstring As String = connection
    Public query As String

    Public Command As MySqlCommand
    Public dbdataset As New DataTable
    Public reader As MySqlDataReader
End Module
