Imports MySql.Data.MySqlClient

Public Class PostSystem
    Public DBConnection As New MySqlConnection

    Public Sub Connect_to_DB()
        Dim DBConnectionstring As String = "Server=localhost;Uid=root;Pwd='admin';Database=trabanwaan1;Convert Zero Datetime=True"
        With DBConnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionstring
                .Open()
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error")
                Call Disconnect_to_DB()
            End Try
        End With
    End Sub
    Public Sub Disconnect_to_DB()
        With DBConnection
            .Close()
            .Dispose()
        End With
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        AccountsSystem.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub PostSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgposts.Rows.Clear()
        Dim strsql1 As String
        Dim mycommand1 As New MySqlCommand
        strsql1 = "Select * from posts"
        Connect_to_DB()
        With mycommand1
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql1
        End With
        Dim myreader1 As MySqlDataReader
        myreader1 = mycommand1.ExecuteReader
        While myreader1.Read()
            Me.dgposts.Rows.Add(New Object() {myreader1.Item("post_id"), myreader1.Item("postservice"), myreader1.Item("worker_username"), myreader1.Item("price"), myreader1.Item("postdt")})
        End While
        Disconnect_to_DB()

        Me.dgbook.Rows.Clear()
        Dim strsql2 As String
        Dim mycommand2 As New MySqlCommand
        strsql2 = "Select * from transactions"
        Connect_to_DB()
        With mycommand2
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql2
        End With
        Dim myreader2 As MySqlDataReader
        myreader2 = mycommand2.ExecuteReader
        While myreader2.Read()
            Me.dgbook.Rows.Add(New Object() {myreader2.Item("transaction_id"), myreader2.Item("post_id"), myreader2.Item("client_username"), myreader2.Item("meetdatetime"), myreader2.Item("message")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnServiceSearch_Click(sender As Object, e As EventArgs) Handles btnServiceSearch.Click
        Me.dgposts.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM posts WHERE postservice LIKE '%" & Me.txtServiceSearch.Text & "%'"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.dgposts.Rows.Add(New Object() {myreader.Item("post_id"), myreader.Item("postservice"), myreader.Item("worker_username"), myreader.Item("price"), myreader.Item("postdt")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnAddPost_Click(sender As Object, e As EventArgs) Handles btnAddPost.Click
        Dim strsql As String = "INSERT INTO `trabanwaan1`.`posts` (`postservice`, `worker_username`, `price`, `postdt`) VALUES ('" & Me.txtService.Text & "', '" & Me.txtWUsername.Text & "', '" & Me.txtPrice.Text & "', now())"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully added.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub

    Private Sub btnSaveEditPost_Click(sender As Object, e As EventArgs) Handles btnSaveEditPost.Click
        Dim strsql As String
        strsql = "UPDATE `trabanwaan1`.`posts` SET `postservice` = '" & Me.txtService.Text & "', `price` = '" & Me.txtPrice.Text & "', `postdt` = now() WHERE (`post_id` = '" & Me.txtPID.Text & "');"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub

    Private Sub btnDeletePost_Click(sender As Object, e As EventArgs) Handles btnDeletePost.Click
        Dim strsql As String
        strsql = "Delete from posts " _
        & " where post_id = '" & Me.txtPID.Text & "'"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Deleted.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub

    Private Sub btnSearchTrans_Click(sender As Object, e As EventArgs) Handles btnSearchTrans.Click
        Me.dgbook.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM transactions WHERE transaction_id LIKE '%" & Me.txtSearchTrans.Text & "%'"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.dgbook.Rows.Add(New Object() {myreader.Item("transaction_id"), myreader.Item("post_id"), myreader.Item("client_username"), myreader.Item("meetdate"), myreader.Item("meettime"), myreader.Item("message")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Dim strsql As String = "INSERT INTO `trabanwaan1`.`transactions` (`post_id`, `client_username`, `meetdatetime`, `message`) VALUES ('" & Me.txtPostID.Text & "', '" & Me.txtClientUsername.Text & "', '" & Me.dtpMeetDate.Text & "', '" & Me.txtMessage.Text & "')"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully added.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub

    Private Sub btnSaveEditBook_Click(sender As Object, e As EventArgs) Handles btnSaveEditBook.Click
        Dim strsql As String
        strsql = "UPDATE `trabanwaan1`.`transactions` SET `post_id` = '" & Me.txtPostID.Text & "', `meetdatetime` = '" & Me.dtpMeetDate.Text & "', `message` = '" & Me.txtMessage.Text & "' WHERE (`transaction_id` = '" & Me.txtTransactionID.Text & "');"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub

    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        Dim strsql As String
        strsql = "Delete from transactions " _
        & " where transaction_id = '" & Me.txtTransactionID.Text & "'"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Deleted.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call PostSystem_Load(sender, e)
    End Sub
End Class