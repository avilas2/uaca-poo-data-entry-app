Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.IO
Imports Microsoft.Office.Interop.Excel

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
        Catch ex As Exception
        End Try
        Dim cmd As New MySqlCommand(String.Format("CALL createUser('{0}','{1}','{2}','{3}','{4}')", txt_userid.Text, txt_userFirstName.Text, txt_userLastName.Text, txt_userAge.Text, txt_userSkill.Text), conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        getUsers()
    End Sub

    Public Sub getUsers()
        Dim query As String = "SELECT * FROM users"
        Dim daUsers As New MySqlDataAdapter(query, conn)
        Dim dsUsers As New DataSet()

        If daUsers.Fill(dsUsers) Then
            DataGridView1.DataSource = dsUsers.Tables(0)
        End If

        conn.Close()
    End Sub

    Public Sub exportXML()
        Dim path As String
        path = "C:\Users\savila\Desktop\"
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        dt.AcceptChanges()
        dt.WriteXml(path & "users" & Math.Round(VBMath.Rnd * 10000) & ".xml", System.Data.XmlWriteMode.WriteSchema, False)
        MsgBox("File successfully exported to " & path)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_exportXML.Click
        exportXML()
    End Sub

    Private Sub btn_getUsers_Click(sender As Object, e As EventArgs) Handles btn_getUsers.Click
        getUsers()
    End Sub

    Public Sub exportCSV()
        Dim filePath As String = "C:\Users\savila\Desktop\"
        Dim delimiter As String = ","
        Dim fileName As String = "users" & Math.Round(VBMath.Rnd * 10000) & ".csv"
        Dim sb As New StringBuilder

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim array As String() = New String(DataGridView1.Rows.Count - 1) {}
            If i.Equals(0) Then
                For j As Integer = 0 To DataGridView1.Rows.Count - 2
                    array(j) = DataGridView1.Columns(j).HeaderText
                Next
                sb.AppendLine(String.Join(delimiter, array))
            End If
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                If Not DataGridView1.Rows(i).IsNewRow Then
                    array(j) = DataGridView1(j, i).Value.ToString
                End If
            Next
            If Not DataGridView1.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(delimiter, array))
            End If
        Next

        File.WriteAllText(filePath & fileName, sb.ToString)
        MsgBox("File successfully exported to " & filePath)

    End Sub

    Public Sub exportXLSX()
        Dim filePath As String = "C:\Users\savila\Desktop\"
        Dim fileName As String = "users" & Math.Round(VBMath.Rnd * 10000) & ".xlsx"

        Dim xlApp As Application
        Dim xlWorkBook As Workbook
        Dim xlWorkSheet As Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs(filePath & fileName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("File successfully exported to " & filePath)
    End Sub

    Private Sub btn_exportCSV_Click(sender As Object, e As EventArgs) Handles btn_exportCSV.Click
        exportCSV()
    End Sub

    Private Sub btn_exportXLSX_Click(sender As Object, e As EventArgs) Handles btn_exportXLSX.Click
        exportXLSX()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class



