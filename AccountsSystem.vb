Imports MySql.Data.MySqlClient
Public Class AccountsSystem
    Public DBConnection As New MySqlConnection

    Public Sub Connect_to_DB()
        Dim DBConnectionstring As String = "Server=localhost;Uid=root;Pwd='admin';Database=trabanwaan1;"
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub AccountsSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgclient_accounts.Rows.Clear()
        Dim strsql1 As String
        Dim mycommand1 As New MySqlCommand
        strsql1 = "Select * from clients"
        Connect_to_DB()
        With mycommand1
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql1
        End With
        Dim myreader1 As MySqlDataReader
        myreader1 = mycommand1.ExecuteReader
        While myreader1.Read()
            Me.dgclient_accounts.Rows.Add(New Object() {myreader1.Item("client_id"), myreader1.Item("client_username"), myreader1.Item("client_name"), myreader1.Item("client_number"), myreader1.Item("client_address")})
        End While
        Disconnect_to_DB()

        Me.dgworker_accounts.Rows.Clear()
        Dim strsql2 As String
        Dim mycommand2 As New MySqlCommand
        strsql2 = "Select * from workers"
        Connect_to_DB()
        With mycommand2
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql2
        End With
        Dim myreader2 As MySqlDataReader
        myreader2 = mycommand2.ExecuteReader
        While myreader2.Read()
            Me.dgworker_accounts.Rows.Add(New Object() {myreader2.Item("worker_id"), myreader2.Item("worker_username"), myreader2.Item("worker_name"), myreader2.Item("worker_number"), myreader2.Item("worker_address")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.dgclient_accounts.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM clients WHERE client_username LIKE '%" & Me.txtCSearch.Text & "%'"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.dgclient_accounts.Rows.Add(New Object() {myreader.Item("client_id"), myreader.Item("client_username"), myreader.Item("client_name"), myreader.Item("client_number"), myreader.Item("client_address")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnAddCAccount_Click(sender As Object, e As EventArgs) Handles btnAddCAccount.Click
        Dim strsql As String = "INSERT INTO `trabanwaan1`.`clients` (`client_username`, `client_name`, `client_number`, `client_address`) VALUES ('" & Me.txtCUsername.Text & "', '" & Me.txtCName.Text & "', '" & Me.txtCNumber.Text & "', '" & Me.txtCAddress.Text & "')"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub btnSaveCAccount_Click(sender As Object, e As EventArgs) Handles btnSaveCAccount.Click
        Dim strsql As String
        strsql = "UPDATE `trabanwaan1`.`clients` SET `client_username` = '" & Me.txtCUsername.Text & "', `client_name` = '" & Me.txtCName.Text & "', `client_number` = '" & Me.txtCNumber.Text & "', `client_address` = '" & Me.txtCAddress.Text & "' WHERE (`client_id` = '" & Me.txtClD.Text & "');"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub btnDeleteCAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteCAccount.Click
        Dim strsql As String
        strsql = "Delete from clients " _
        & " where client_id = '" & Me.txtClD.Text & "'"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub btnWSearch_Click(sender As Object, e As EventArgs) Handles btnWSearch.Click
        Me.dgworker_accounts.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM workers WHERE worker_username LIKE '%" & Me.txtWSearch.Text & "%'"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.dgworker_accounts.Rows.Add(New Object() {myreader.Item("worker_id"), myreader.Item("worker_username"), myreader.Item("worker_name"), myreader.Item("worker_number"), myreader.Item("worker_address")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnAddWAccount_Click(sender As Object, e As EventArgs) Handles btnAddWAccount.Click
        Dim strsql As String = "INSERT INTO `trabanwaan1`.`workers` (`worker_username`, `worker_name`, `worker_number`, `worker_address`) VALUES ('" & Me.txtWUsername.Text & "', '" & Me.txtWName.Text & "', '" & Me.txtWNumber.Text & "', '" & Me.txtWAddress.Text & "')"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub btnSaveWAccount_Click(sender As Object, e As EventArgs) Handles btnSaveWAccount.Click
        Dim strsql As String
        strsql = "UPDATE `trabanwaan1`.`workers` SET `worker_username` = '" & Me.txtWUsername.Text & "', `worker_name` = '" & Me.txtWName.Text & "', `worker_number` = '" & Me.txtWNumber.Text & "', `worker_address` = '" & Me.txtWAddress.Text & "' WHERE (`worker_id` = '" & Me.txtWID.Text & "');"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub btnDeleteWAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteWAccount.Click
        Dim strsql As String
        strsql = "Delete from workers " _
        & " where worker_id = '" & Me.txtWID.Text & "'"
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
        Call AccountsSystem_Load(sender, e)
    End Sub

    Private Sub PostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PostToolStripMenuItem.Click
        PostSystem.Show()
        Me.Hide()
    End Sub
End Class