Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Public Sub connect()
        Dim DatabaseName As String = "racquetball_reservations"
        Dim server As String = "104.198.54.212"
        Dim userName As String = "root"
        Dim password As String = "2000266"
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()

            Console.Write("Connected")
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub btn_userSubmit_Click(sender As Object, e As EventArgs) Handles btn_userSubmit.Click
        Try
            conn.Open()
            MsgBox("Connected...executing query")
        Catch ex As Exception
        End Try
        Dim cmd As New MySqlCommand(String.Format("INSERT INTO users(user_id, user_firstName, user_lastName, user_age, user_skill) VALUES ('{0}','{1}','{2}',{3},'{4}')", txt_userid.Text, txt_userFirstName.Text, txt_userLastName.Text, txt_userAge.Text, txt_userSkill.Text), conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
