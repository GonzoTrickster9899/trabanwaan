<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgclient_accounts = New System.Windows.Forms.DataGridView()
        Me.Client_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteCAccount = New System.Windows.Forms.Button()
        Me.btnSaveCAccount = New System.Windows.Forms.Button()
        Me.txtCAddress = New System.Windows.Forms.TextBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.txtCNumber = New System.Windows.Forms.TextBox()
        Me.txtCUsername = New System.Windows.Forms.TextBox()
        Me.txtClD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCAccount = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCSearch = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabClients = New System.Windows.Forms.TabPage()
        Me.tabWorkers = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteWAccount = New System.Windows.Forms.Button()
        Me.btnSaveWAccount = New System.Windows.Forms.Button()
        Me.txtWAddress = New System.Windows.Forms.TextBox()
        Me.txtWName = New System.Windows.Forms.TextBox()
        Me.txtWNumber = New System.Windows.Forms.TextBox()
        Me.txtWUsername = New System.Windows.Forms.TextBox()
        Me.txtWID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddWAccount = New System.Windows.Forms.Button()
        Me.btnWSearch = New System.Windows.Forms.Button()
        Me.txtWSearch = New System.Windows.Forms.TextBox()
        Me.dgworker_accounts = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgclient_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabClients.SuspendLayout()
        Me.tabWorkers.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgworker_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PostToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(866, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PostToolStripMenuItem
        '
        Me.PostToolStripMenuItem.Name = "PostToolStripMenuItem"
        Me.PostToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.PostToolStripMenuItem.Text = "Posts"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'dgclient_accounts
        '
        Me.dgclient_accounts.AllowUserToAddRows = False
        Me.dgclient_accounts.AllowUserToDeleteRows = False
        Me.dgclient_accounts.BackgroundColor = System.Drawing.Color.White
        Me.dgclient_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgclient_accounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client_ID, Me.CUsername, Me.CName, Me.CNumber, Me.CAddress})
        Me.dgclient_accounts.Location = New System.Drawing.Point(3, 3)
        Me.dgclient_accounts.Name = "dgclient_accounts"
        Me.dgclient_accounts.ReadOnly = True
        Me.dgclient_accounts.RowHeadersWidth = 51
        Me.dgclient_accounts.Size = New System.Drawing.Size(515, 351)
        Me.dgclient_accounts.TabIndex = 12
        '
        'Client_ID
        '
        Me.Client_ID.HeaderText = "Client_ID"
        Me.Client_ID.MinimumWidth = 6
        Me.Client_ID.Name = "Client_ID"
        Me.Client_ID.ReadOnly = True
        Me.Client_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Client_ID.Width = 50
        '
        'CUsername
        '
        Me.CUsername.HeaderText = "Username"
        Me.CUsername.MinimumWidth = 6
        Me.CUsername.Name = "CUsername"
        Me.CUsername.ReadOnly = True
        Me.CUsername.Width = 125
        '
        'CName
        '
        Me.CName.HeaderText = "Name"
        Me.CName.MinimumWidth = 6
        Me.CName.Name = "CName"
        Me.CName.ReadOnly = True
        Me.CName.Width = 125
        '
        'CNumber
        '
        Me.CNumber.HeaderText = "Contact Number"
        Me.CNumber.MinimumWidth = 6
        Me.CNumber.Name = "CNumber"
        Me.CNumber.ReadOnly = True
        Me.CNumber.Width = 125
        '
        'CAddress
        '
        Me.CAddress.HeaderText = "Address"
        Me.CAddress.MinimumWidth = 6
        Me.CAddress.Name = "CAddress"
        Me.CAddress.ReadOnly = True
        Me.CAddress.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnDeleteCAccount)
        Me.Panel1.Controls.Add(Me.btnSaveCAccount)
        Me.Panel1.Controls.Add(Me.txtCAddress)
        Me.Panel1.Controls.Add(Me.txtCName)
        Me.Panel1.Controls.Add(Me.txtCNumber)
        Me.Panel1.Controls.Add(Me.txtCUsername)
        Me.Panel1.Controls.Add(Me.txtClD)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAddCAccount)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtCSearch)
        Me.Panel1.Location = New System.Drawing.Point(524, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 350)
        Me.Panel1.TabIndex = 13
        '
        'btnDeleteCAccount
        '
        Me.btnDeleteCAccount.Location = New System.Drawing.Point(92, 273)
        Me.btnDeleteCAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteCAccount.Name = "btnDeleteCAccount"
        Me.btnDeleteCAccount.Size = New System.Drawing.Size(118, 19)
        Me.btnDeleteCAccount.TabIndex = 24
        Me.btnDeleteCAccount.Text = "Delete Client Account"
        Me.btnDeleteCAccount.UseVisualStyleBackColor = True
        '
        'btnSaveCAccount
        '
        Me.btnSaveCAccount.Location = New System.Drawing.Point(153, 237)
        Me.btnSaveCAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveCAccount.Name = "btnSaveCAccount"
        Me.btnSaveCAccount.Size = New System.Drawing.Size(109, 19)
        Me.btnSaveCAccount.TabIndex = 23
        Me.btnSaveCAccount.Text = "Save Edit Account"
        Me.btnSaveCAccount.UseVisualStyleBackColor = True
        '
        'txtCAddress
        '
        Me.txtCAddress.Location = New System.Drawing.Point(20, 203)
        Me.txtCAddress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCAddress.Name = "txtCAddress"
        Me.txtCAddress.Size = New System.Drawing.Size(243, 20)
        Me.txtCAddress.TabIndex = 22
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(20, 129)
        Me.txtCName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(243, 20)
        Me.txtCName.TabIndex = 21
        '
        'txtCNumber
        '
        Me.txtCNumber.Location = New System.Drawing.Point(20, 166)
        Me.txtCNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCNumber.Name = "txtCNumber"
        Me.txtCNumber.Size = New System.Drawing.Size(243, 20)
        Me.txtCNumber.TabIndex = 21
        '
        'txtCUsername
        '
        Me.txtCUsername.Location = New System.Drawing.Point(20, 92)
        Me.txtCUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCUsername.Name = "txtCUsername"
        Me.txtCUsername.Size = New System.Drawing.Size(243, 20)
        Me.txtCUsername.TabIndex = 20
        '
        'txtClD
        '
        Me.txtClD.Location = New System.Drawing.Point(20, 55)
        Me.txtClD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClD.Name = "txtClD"
        Me.txtClD.Size = New System.Drawing.Size(243, 20)
        Me.txtClD.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Contact Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Client ID (Save Edit and Delete Account Only)"
        '
        'btnAddCAccount
        '
        Me.btnAddCAccount.Location = New System.Drawing.Point(22, 237)
        Me.btnAddCAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddCAccount.Name = "btnAddCAccount"
        Me.btnAddCAccount.Size = New System.Drawing.Size(107, 19)
        Me.btnAddCAccount.TabIndex = 13
        Me.btnAddCAccount.Text = "Add Client Account"
        Me.btnAddCAccount.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSearch.Location = New System.Drawing.Point(256, 9)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 19)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCSearch
        '
        Me.txtCSearch.Location = New System.Drawing.Point(38, 10)
        Me.txtCSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCSearch.Name = "txtCSearch"
        Me.txtCSearch.Size = New System.Drawing.Size(214, 20)
        Me.txtCSearch.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabClients)
        Me.TabControl1.Controls.Add(Me.tabWorkers)
        Me.TabControl1.Location = New System.Drawing.Point(9, 25)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(856, 379)
        Me.TabControl1.TabIndex = 14
        '
        'tabClients
        '
        Me.tabClients.Controls.Add(Me.dgclient_accounts)
        Me.tabClients.Controls.Add(Me.Panel1)
        Me.tabClients.Location = New System.Drawing.Point(4, 22)
        Me.tabClients.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabClients.Name = "tabClients"
        Me.tabClients.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabClients.Size = New System.Drawing.Size(848, 353)
        Me.tabClients.TabIndex = 0
        Me.tabClients.Text = "Client Accounts"
        Me.tabClients.UseVisualStyleBackColor = True
        '
        'tabWorkers
        '
        Me.tabWorkers.Controls.Add(Me.Panel2)
        Me.tabWorkers.Controls.Add(Me.dgworker_accounts)
        Me.tabWorkers.Location = New System.Drawing.Point(4, 22)
        Me.tabWorkers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabWorkers.Name = "tabWorkers"
        Me.tabWorkers.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabWorkers.Size = New System.Drawing.Size(848, 353)
        Me.tabWorkers.TabIndex = 1
        Me.tabWorkers.Text = "Worker Accounts"
        Me.tabWorkers.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnDeleteWAccount)
        Me.Panel2.Controls.Add(Me.btnSaveWAccount)
        Me.Panel2.Controls.Add(Me.txtWAddress)
        Me.Panel2.Controls.Add(Me.txtWName)
        Me.Panel2.Controls.Add(Me.txtWNumber)
        Me.Panel2.Controls.Add(Me.txtWUsername)
        Me.Panel2.Controls.Add(Me.txtWID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btnAddWAccount)
        Me.Panel2.Controls.Add(Me.btnWSearch)
        Me.Panel2.Controls.Add(Me.txtWSearch)
        Me.Panel2.Location = New System.Drawing.Point(524, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 350)
        Me.Panel2.TabIndex = 14
        '
        'btnDeleteWAccount
        '
        Me.btnDeleteWAccount.Location = New System.Drawing.Point(92, 273)
        Me.btnDeleteWAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteWAccount.Name = "btnDeleteWAccount"
        Me.btnDeleteWAccount.Size = New System.Drawing.Size(132, 19)
        Me.btnDeleteWAccount.TabIndex = 24
        Me.btnDeleteWAccount.Text = "Delete Worker Account"
        Me.btnDeleteWAccount.UseVisualStyleBackColor = True
        '
        'btnSaveWAccount
        '
        Me.btnSaveWAccount.Location = New System.Drawing.Point(153, 237)
        Me.btnSaveWAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveWAccount.Name = "btnSaveWAccount"
        Me.btnSaveWAccount.Size = New System.Drawing.Size(109, 19)
        Me.btnSaveWAccount.TabIndex = 23
        Me.btnSaveWAccount.Text = "Save Edit Account"
        Me.btnSaveWAccount.UseVisualStyleBackColor = True
        '
        'txtWAddress
        '
        Me.txtWAddress.Location = New System.Drawing.Point(20, 203)
        Me.txtWAddress.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWAddress.Name = "txtWAddress"
        Me.txtWAddress.Size = New System.Drawing.Size(243, 20)
        Me.txtWAddress.TabIndex = 22
        '
        'txtWName
        '
        Me.txtWName.Location = New System.Drawing.Point(20, 129)
        Me.txtWName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWName.Name = "txtWName"
        Me.txtWName.Size = New System.Drawing.Size(243, 20)
        Me.txtWName.TabIndex = 21
        '
        'txtWNumber
        '
        Me.txtWNumber.Location = New System.Drawing.Point(20, 166)
        Me.txtWNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWNumber.Name = "txtWNumber"
        Me.txtWNumber.Size = New System.Drawing.Size(243, 20)
        Me.txtWNumber.TabIndex = 21
        '
        'txtWUsername
        '
        Me.txtWUsername.Location = New System.Drawing.Point(20, 92)
        Me.txtWUsername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWUsername.Name = "txtWUsername"
        Me.txtWUsername.Size = New System.Drawing.Size(243, 20)
        Me.txtWUsername.TabIndex = 20
        '
        'txtWID
        '
        Me.txtWID.Location = New System.Drawing.Point(20, 55)
        Me.txtWID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWID.Name = "txtWID"
        Me.txtWID.Size = New System.Drawing.Size(243, 20)
        Me.txtWID.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Username"
        '
        'btnAddWAccount
        '
        Me.btnAddWAccount.Location = New System.Drawing.Point(22, 237)
        Me.btnAddWAccount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddWAccount.Name = "btnAddWAccount"
        Me.btnAddWAccount.Size = New System.Drawing.Size(116, 19)
        Me.btnAddWAccount.TabIndex = 13
        Me.btnAddWAccount.Text = "Add Worker Account"
        Me.btnAddWAccount.UseVisualStyleBackColor = True
        '
        'btnWSearch
        '
        Me.btnWSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnWSearch.Location = New System.Drawing.Point(256, 9)
        Me.btnWSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWSearch.Name = "btnWSearch"
        Me.btnWSearch.Size = New System.Drawing.Size(56, 19)
        Me.btnWSearch.TabIndex = 12
        Me.btnWSearch.Text = "Search"
        Me.btnWSearch.UseVisualStyleBackColor = True
        '
        'txtWSearch
        '
        Me.txtWSearch.Location = New System.Drawing.Point(38, 10)
        Me.txtWSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWSearch.Name = "txtWSearch"
        Me.txtWSearch.Size = New System.Drawing.Size(214, 20)
        Me.txtWSearch.TabIndex = 11
        '
        'dgworker_accounts
        '
        Me.dgworker_accounts.AllowUserToAddRows = False
        Me.dgworker_accounts.AllowUserToDeleteRows = False
        Me.dgworker_accounts.BackgroundColor = System.Drawing.Color.White
        Me.dgworker_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgworker_accounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgworker_accounts.Location = New System.Drawing.Point(3, 3)
        Me.dgworker_accounts.Name = "dgworker_accounts"
        Me.dgworker_accounts.ReadOnly = True
        Me.dgworker_accounts.RowHeadersWidth = 51
        Me.dgworker_accounts.Size = New System.Drawing.Size(515, 351)
        Me.dgworker_accounts.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Worker_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Client ID (Save Edit and Delete Account Only)"
        '
        'AccountsSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 407)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AccountsSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgclient_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabClients.ResumeLayout(False)
        Me.tabWorkers.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgworker_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgclient_accounts As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Client_ID As DataGridViewTextBoxColumn
    Friend WithEvents CUsername As DataGridViewTextBoxColumn
    Friend WithEvents CName As DataGridViewTextBoxColumn
    Friend WithEvents CNumber As DataGridViewTextBoxColumn
    Friend WithEvents CAddress As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCSearch As TextBox
    Friend WithEvents txtCAddress As TextBox
    Friend WithEvents txtCName As TextBox
    Friend WithEvents txtCNumber As TextBox
    Friend WithEvents txtCUsername As TextBox
    Friend WithEvents txtClD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddCAccount As Button
    Friend WithEvents btnSaveCAccount As Button
    Friend WithEvents btnDeleteCAccount As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabClients As TabPage
    Friend WithEvents tabWorkers As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeleteWAccount As Button
    Friend WithEvents btnSaveWAccount As Button
    Friend WithEvents txtWAddress As TextBox
    Friend WithEvents txtWName As TextBox
    Friend WithEvents txtWNumber As TextBox
    Friend WithEvents txtWUsername As TextBox
    Friend WithEvents txtWID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddWAccount As Button
    Friend WithEvents btnWSearch As Button
    Friend WithEvents txtWSearch As TextBox
    Friend WithEvents dgworker_accounts As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label10 As Label
End Class
