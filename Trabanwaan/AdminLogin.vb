Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Public DBConnection As New MySqlConnection

    Public Sub Connect_to_DB()
        'Change the uid and pwd based on your set up of your mysql.
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
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select * from admin_users where admin_username = '" & Me.txtUsername.Text _
            & "' and admin_password = '" & Me.txtPassword.Text & "'"

        Connect_to_DB()

        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        If myreader.HasRows Then
            txtUsername.Clear()
            txtPassword.Clear()
            Me.Hide()
            AccountsSystem.Show()
        Else
            MessageBox.Show("Invalid username or password")
        End If
        Disconnect_to_DB()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Close()
    End Sub
End Class