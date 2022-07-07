<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostSystem
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
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgposts = New System.Windows.Forms.DataGridView()
        Me.Post_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uploaded_on = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeletePost = New System.Windows.Forms.Button()
        Me.btnSaveEditPost = New System.Windows.Forms.Button()
        Me.txtWUsername = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddPost = New System.Windows.Forms.Button()
        Me.btnServiceSearch = New System.Windows.Forms.Button()
        Me.txtServiceSearch = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPosts = New System.Windows.Forms.TabPage()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.dtpMeetDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnSaveEditBook = New System.Windows.Forms.Button()
        Me.txtClientUsername = New System.Windows.Forms.TextBox()
        Me.txtPostID = New System.Windows.Forms.TextBox()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnSearchTrans = New System.Windows.Forms.Button()
        Me.txtSearchTrans = New System.Windows.Forms.TextBox()
        Me.dgbook = New System.Windows.Forms.DataGridView()
        Me.Transaction_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPost_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeetDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeetTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgposts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPosts.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(853, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'dgposts
        '
        Me.dgposts.AllowUserToAddRows = False
        Me.dgposts.AllowUserToDeleteRows = False
        Me.dgposts.BackgroundColor = System.Drawing.Color.White
        Me.dgposts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgposts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Post_ID, Me.ServiceDescription, Me.PostedBy, Me.price, Me.Uploaded_on})
        Me.dgposts.Location = New System.Drawing.Point(3, 3)
        Me.dgposts.Name = "dgposts"
        Me.dgposts.ReadOnly = True
        Me.dgposts.RowHeadersWidth = 51
        Me.dgposts.Size = New System.Drawing.Size(492, 344)
        Me.dgposts.TabIndex = 14
        '
        'Post_ID
        '
        Me.Post_ID.HeaderText = "Post_ID"
        Me.Post_ID.MinimumWidth = 6
        Me.Post_ID.Name = "Post_ID"
        Me.Post_ID.ReadOnly = True
        Me.Post_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Post_ID.Width = 50
        '
        'ServiceDescription
        '
        Me.ServiceDescription.HeaderText = "Service Description"
        Me.ServiceDescription.MinimumWidth = 6
        Me.ServiceDescription.Name = "ServiceDescription"
        Me.ServiceDescription.ReadOnly = True
        Me.ServiceDescription.Width = 125
        '
        'PostedBy
        '
        Me.PostedBy.HeaderText = "Posted by"
        Me.PostedBy.MinimumWidth = 6
        Me.PostedBy.Name = "PostedBy"
        Me.PostedBy.ReadOnly = True
        Me.PostedBy.Width = 125
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 125
        '
        'Uploaded_on
        '
        Me.Uploaded_on.HeaderText = "Uploaded On"
        Me.Uploaded_on.MinimumWidth = 6
        Me.Uploaded_on.Name = "Uploaded_on"
        Me.Uploaded_on.ReadOnly = True
        Me.Uploaded_on.Width = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnDeletePost)
        Me.Panel2.Controls.Add(Me.btnSaveEditPost)
        Me.Panel2.Controls.Add(Me.txtWUsername)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.txtService)
        Me.Panel2.Controls.Add(Me.txtPID)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnAddPost)
        Me.Panel2.Controls.Add(Me.btnServiceSearch)
        Me.Panel2.Controls.Add(Me.txtServiceSearch)
        Me.Panel2.Location = New System.Drawing.Point(515, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 350)
        Me.Panel2.TabIndex = 15
        '
        'btnDeletePost
        '
        Me.btnDeletePost.Location = New System.Drawing.Point(92, 273)
        Me.btnDeletePost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeletePost.Name = "btnDeletePost"
        Me.btnDeletePost.Size = New System.Drawing.Size(118, 19)
        Me.btnDeletePost.TabIndex = 24
        Me.btnDeletePost.Text = "Delete Post"
        Me.btnDeletePost.UseVisualStyleBackColor = True
        '
        'btnSaveEditPost
        '
        Me.btnSaveEditPost.Location = New System.Drawing.Point(153, 237)
        Me.btnSaveEditPost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveEditPost.Name = "btnSaveEditPost"
        Me.btnSaveEditPost.Size = New System.Drawing.Size(109, 19)
        Me.btnSaveEditPost.TabIndex = 23
        Me.btnSaveEditPost.Text = "Save Edit Post"
        Me.btnSaveEditPost.UseVisualStyleBackColor = True
        '
        'txtWUsername
        '
        Me.txtWUsername.Location = New System.Drawing.Point(20, 129)
        Me.txtWUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWUsername.Name = "txtWUsername"
        Me.txtWUsername.Size = New System.Drawing.Size(243, 20)
        Me.txtWUsername.TabIndex = 21
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(20, 166)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(243, 20)
        Me.txtPrice.TabIndex = 21
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(20, 92)
        Me.txtService.Margin = New System.Windows.Forms.Padding(2)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(243, 20)
        Me.txtService.TabIndex = 20
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(20, 55)
        Me.txtPID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(243, 20)
        Me.txtPID.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Worker Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Service Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Post ID"
        '
        'btnAddPost
        '
        Me.btnAddPost.Location = New System.Drawing.Point(22, 237)
        Me.btnAddPost.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddPost.Name = "btnAddPost"
        Me.btnAddPost.Size = New System.Drawing.Size(107, 19)
        Me.btnAddPost.TabIndex = 13
        Me.btnAddPost.Text = "Add Post"
        Me.btnAddPost.UseVisualStyleBackColor = True
        '
        'btnServiceSearch
        '
        Me.btnServiceSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnServiceSearch.Location = New System.Drawing.Point(256, 9)
        Me.btnServiceSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnServiceSearch.Name = "btnServiceSearch"
        Me.btnServiceSearch.Size = New System.Drawing.Size(56, 19)
        Me.btnServiceSearch.TabIndex = 12
        Me.btnServiceSearch.Text = "Search"
        Me.btnServiceSearch.UseVisualStyleBackColor = True
        '
        'txtServiceSearch
        '
        Me.txtServiceSearch.Location = New System.Drawing.Point(38, 10)
        Me.txtServiceSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtServiceSearch.Name = "txtServiceSearch"
        Me.txtServiceSearch.Size = New System.Drawing.Size(214, 20)
        Me.txtServiceSearch.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPosts)
        Me.TabControl1.Controls.Add(Me.tabBooking)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(852, 373)
        Me.TabControl1.TabIndex = 16
        '
        'tabPosts
        '
        Me.tabPosts.Controls.Add(Me.dgposts)
        Me.tabPosts.Controls.Add(Me.Panel2)
        Me.tabPosts.Location = New System.Drawing.Point(4, 22)
        Me.tabPosts.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPosts.Name = "tabPosts"
        Me.tabPosts.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPosts.Size = New System.Drawing.Size(844, 334)
        Me.tabPosts.TabIndex = 0
        Me.tabPosts.Text = "Posts"
        Me.tabPosts.UseVisualStyleBackColor = True
        '
        'tabBooking
        '
        Me.tabBooking.Controls.Add(Me.Panel1)
        Me.tabBooking.Controls.Add(Me.dgbook)
        Me.tabBooking.Location = New System.Drawing.Point(4, 22)
        Me.tabBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBooking.Size = New System.Drawing.Size(844, 347)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking"
        Me.tabBooking.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txtMessage)
        Me.Panel1.Controls.Add(Me.dtpMeetDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnDeleteBook)
        Me.Panel1.Controls.Add(Me.btnSaveEditBook)
        Me.Panel1.Controls.Add(Me.txtClientUsername)
        Me.Panel1.Controls.Add(Me.txtPostID)
        Me.Panel1.Controls.Add(Me.txtTransactionID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnAddBook)
        Me.Panel1.Controls.Add(Me.btnSearchTrans)
        Me.Panel1.Controls.Add(Me.txtSearchTrans)
        Me.Panel1.Location = New System.Drawing.Point(515, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 344)
        Me.Panel1.TabIndex = 16
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(21, 219)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(242, 61)
        Me.txtMessage.TabIndex = 30
        '
        'dtpMeetDate
        '
        Me.dtpMeetDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.dtpMeetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMeetDate.Location = New System.Drawing.Point(21, 170)
        Me.dtpMeetDate.Name = "dtpMeetDate"
        Me.dtpMeetDate.Size = New System.Drawing.Size(195, 20)
        Me.dtpMeetDate.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Message"
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Location = New System.Drawing.Point(79, 308)
        Me.btnDeleteBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(118, 19)
        Me.btnDeleteBook.TabIndex = 24
        Me.btnDeleteBook.Text = "Delete Post"
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'btnSaveEditBook
        '
        Me.btnSaveEditBook.Location = New System.Drawing.Point(154, 285)
        Me.btnSaveEditBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveEditBook.Name = "btnSaveEditBook"
        Me.btnSaveEditBook.Size = New System.Drawing.Size(109, 19)
        Me.btnSaveEditBook.TabIndex = 23
        Me.btnSaveEditBook.Text = "Save Edit Book"
        Me.btnSaveEditBook.UseVisualStyleBackColor = True
        '
        'txtClientUsername
        '
        Me.txtClientUsername.Location = New System.Drawing.Point(20, 129)
        Me.txtClientUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtClientUsername.Name = "txtClientUsername"
        Me.txtClientUsername.Size = New System.Drawing.Size(243, 20)
        Me.txtClientUsername.TabIndex = 21
        '
        'txtPostID
        '
        Me.txtPostID.Location = New System.Drawing.Point(20, 92)
        Me.txtPostID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPostID.Name = "txtPostID"
        Me.txtPostID.Size = New System.Drawing.Size(243, 20)
        Me.txtPostID.TabIndex = 20
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Location = New System.Drawing.Point(20, 55)
        Me.txtTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(243, 20)
        Me.txtTransactionID.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Meet Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Booking By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Post ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Transaction ID"
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(20, 285)
        Me.btnAddBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(107, 19)
        Me.btnAddBook.TabIndex = 13
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnSearchTrans
        '
        Me.btnSearchTrans.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSearchTrans.Location = New System.Drawing.Point(256, 9)
        Me.btnSearchTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchTrans.Name = "btnSearchTrans"
        Me.btnSearchTrans.Size = New System.Drawing.Size(56, 19)
        Me.btnSearchTrans.TabIndex = 12
        Me.btnSearchTrans.Text = "Search Trans"
        Me.btnSearchTrans.UseVisualStyleBackColor = True
        '
        'txtSearchTrans
        '
        Me.txtSearchTrans.Location = New System.Drawing.Point(38, 10)
        Me.txtSearchTrans.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchTrans.Name = "txtSearchTrans"
        Me.txtSearchTrans.Size = New System.Drawing.Size(214, 20)
        Me.txtSearchTrans.TabIndex = 11
        '
        'dgbook
        '
        Me.dgbook.AllowUserToAddRows = False
        Me.dgbook.AllowUserToDeleteRows = False
        Me.dgbook.BackgroundColor = System.Drawing.Color.White
        Me.dgbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Transaction_ID, Me.TPost_ID, Me.BookedBy, Me.MeetDate, Me.MeetTime, Me.Message})
        Me.dgbook.Location = New System.Drawing.Point(3, 3)
        Me.dgbook.Name = "dgbook"
        Me.dgbook.ReadOnly = True
        Me.dgbook.RowHeadersWidth = 51
        Me.dgbook.Size = New System.Drawing.Size(492, 344)
        Me.dgbook.TabIndex = 15
        '
        'Transaction_ID
        '
        Me.Transaction_ID.HeaderText = "Trans_ID"
        Me.Transaction_ID.MinimumWidth = 6
        Me.Transaction_ID.Name = "Transaction_ID"
        Me.Transaction_ID.ReadOnly = True
        Me.Transaction_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transaction_ID.Width = 50
        '
        'TPost_ID
        '
        Me.TPost_ID.HeaderText = "Post_ID"
        Me.TPost_ID.MinimumWidth = 6
        Me.TPost_ID.Name = "TPost_ID"
        Me.TPost_ID.ReadOnly = True
        Me.TPost_ID.Width = 125
        '
        'BookedBy
        '
        Me.BookedBy.HeaderText = "Booked by"
        Me.BookedBy.MinimumWidth = 6
        Me.BookedBy.Name = "BookedBy"
        Me.BookedBy.ReadOnly = True
        Me.BookedBy.Width = 125
        '
        'MeetDate
        '
        Me.MeetDate.HeaderText = "Meet Date"
        Me.MeetDate.MinimumWidth = 6
        Me.MeetDate.Name = "MeetDate"
        Me.MeetDate.ReadOnly = True
        Me.MeetDate.Width = 125
        '
        'MeetTime
        '
        Me.MeetTime.HeaderText = "Meet Time"
        Me.MeetTime.MinimumWidth = 6
        Me.MeetTime.Name = "MeetTime"
        Me.MeetTime.ReadOnly = True
        Me.MeetTime.Width = 125
        '
        'Message
        '
        Me.Message.HeaderText = "Message"
        Me.Message.MinimumWidth = 6
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        Me.Message.Width = 125
        '
        'PostSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 401)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PostSystem"
        Me.ShowIcon = False
        Me.Text = "Worker's Post System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgposts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPosts.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgposts As DataGridView
    Friend WithEvents Post_ID As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDescription As DataGridViewTextBoxColumn
    Friend WithEvents PostedBy As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeletePost As Button
    Friend WithEvents btnSaveEditPost As Button
    Friend WithEvents txtWUsername As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddPost As Button
    Friend WithEvents btnServiceSearch As Button
    Friend WithEvents txtServiceSearch As TextBox
    Friend WithEvents Uploaded_on As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPosts As TabPage
    Friend WithEvents tabBooking As TabPage
    Friend WithEvents dgbook As DataGridView
    Friend WithEvents Transaction_ID As DataGridViewTextBoxColumn
    Friend WithEvents TPost_ID As DataGridViewTextBoxColumn
    Friend WithEvents BookedBy As DataGridViewTextBoxColumn
    Friend WithEvents MeetDate As DataGridViewTextBoxColumn
    Friend WithEvents MeetTime As DataGridViewTextBoxColumn
    Friend WithEvents Message As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents btnSaveEditBook As Button
    Friend WithEvents txtClientUsername As TextBox
    Friend WithEvents txtPostID As TextBox
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnSearchTrans As Button
    Friend WithEvents txtSearchTrans As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents dtpMeetDate As DateTimePicker
End Class
