<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCaddbook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnCoverPicker = New System.Windows.Forms.Button()
        Me.tbdescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbisbn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPublicationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbauthor = New System.Windows.Forms.TextBox()
        Me.lblbauthor = New System.Windows.Forms.Label()
        Me.tbtitle = New System.Windows.Forms.TextBox()
        Me.lblbTitle = New System.Windows.Forms.Label()
        Me.lblAddBookTitle = New System.Windows.Forms.Label()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.tbbookid = New System.Windows.Forms.TextBox()
        Me.lblbookid = New System.Windows.Forms.Label()
        Me.nudpages = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbcondition = New System.Windows.Forms.ComboBox()
        CType(Me.nudpages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.BackgroundImage = Global.LibraryApp.My.Resources.Resources.left_arrow__2_
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(3, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 43)
        Me.btnback.TabIndex = 33
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnCoverPicker
        '
        Me.btnCoverPicker.Location = New System.Drawing.Point(285, 324)
        Me.btnCoverPicker.Name = "btnCoverPicker"
        Me.btnCoverPicker.Size = New System.Drawing.Size(271, 23)
        Me.btnCoverPicker.TabIndex = 32
        Me.btnCoverPicker.Text = "Choose Cover"
        Me.btnCoverPicker.UseVisualStyleBackColor = True
        '
        'tbdescription
        '
        Me.tbdescription.Location = New System.Drawing.Point(284, 271)
        Me.tbdescription.Name = "tbdescription"
        Me.tbdescription.Size = New System.Drawing.Size(271, 20)
        Me.tbdescription.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Pages"
        '
        'tbisbn
        '
        Me.tbisbn.Location = New System.Drawing.Point(284, 219)
        Me.tbisbn.Name = "tbisbn"
        Me.tbisbn.Size = New System.Drawing.Size(271, 20)
        Me.tbisbn.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ISBN"
        '
        'dtpPublicationDate
        '
        Me.dtpPublicationDate.Location = New System.Drawing.Point(284, 182)
        Me.dtpPublicationDate.Name = "dtpPublicationDate"
        Me.dtpPublicationDate.Size = New System.Drawing.Size(271, 20)
        Me.dtpPublicationDate.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Publication date"
        '
        'tbauthor
        '
        Me.tbauthor.Location = New System.Drawing.Point(284, 129)
        Me.tbauthor.Name = "tbauthor"
        Me.tbauthor.Size = New System.Drawing.Size(271, 20)
        Me.tbauthor.TabIndex = 23
        '
        'lblbauthor
        '
        Me.lblbauthor.AutoSize = True
        Me.lblbauthor.Location = New System.Drawing.Point(195, 132)
        Me.lblbauthor.Name = "lblbauthor"
        Me.lblbauthor.Size = New System.Drawing.Size(38, 13)
        Me.lblbauthor.TabIndex = 22
        Me.lblbauthor.Text = "Author"
        '
        'tbtitle
        '
        Me.tbtitle.Location = New System.Drawing.Point(284, 103)
        Me.tbtitle.Name = "tbtitle"
        Me.tbtitle.Size = New System.Drawing.Size(271, 20)
        Me.tbtitle.TabIndex = 21
        '
        'lblbTitle
        '
        Me.lblbTitle.AutoSize = True
        Me.lblbTitle.Location = New System.Drawing.Point(195, 106)
        Me.lblbTitle.Name = "lblbTitle"
        Me.lblbTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblbTitle.TabIndex = 20
        Me.lblbTitle.Text = "Title"
        '
        'lblAddBookTitle
        '
        Me.lblAddBookTitle.AutoSize = True
        Me.lblAddBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddBookTitle.Location = New System.Drawing.Point(329, 36)
        Me.lblAddBookTitle.Name = "lblAddBookTitle"
        Me.lblAddBookTitle.Size = New System.Drawing.Size(193, 31)
        Me.lblAddBookTitle.TabIndex = 19
        Me.lblAddBookTitle.Text = "Add New Book"
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(398, 379)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBook.TabIndex = 18
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'tbbookid
        '
        Me.tbbookid.Location = New System.Drawing.Point(284, 156)
        Me.tbbookid.Name = "tbbookid"
        Me.tbbookid.Size = New System.Drawing.Size(271, 20)
        Me.tbbookid.TabIndex = 35
        '
        'lblbookid
        '
        Me.lblbookid.AutoSize = True
        Me.lblbookid.Location = New System.Drawing.Point(195, 159)
        Me.lblbookid.Name = "lblbookid"
        Me.lblbookid.Size = New System.Drawing.Size(46, 13)
        Me.lblbookid.TabIndex = 34
        Me.lblbookid.Text = "Book ID"
        '
        'nudpages
        '
        Me.nudpages.Location = New System.Drawing.Point(284, 246)
        Me.nudpages.Name = "nudpages"
        Me.nudpages.Size = New System.Drawing.Size(271, 20)
        Me.nudpages.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Condition"
        '
        'cbcondition
        '
        Me.cbcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcondition.FormattingEnabled = True
        Me.cbcondition.Items.AddRange(New Object() {"New", "Fine", "Very Good", "Good", "Fair", "Poor"})
        Me.cbcondition.Location = New System.Drawing.Point(284, 297)
        Me.cbcondition.Name = "cbcondition"
        Me.cbcondition.Size = New System.Drawing.Size(272, 21)
        Me.cbcondition.TabIndex = 73
        '
        'UCaddbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcondition)
        Me.Controls.Add(Me.nudpages)
        Me.Controls.Add(Me.tbbookid)
        Me.Controls.Add(Me.lblbookid)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnCoverPicker)
        Me.Controls.Add(Me.tbdescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbisbn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpPublicationDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbauthor)
        Me.Controls.Add(Me.lblbauthor)
        Me.Controls.Add(Me.tbtitle)
        Me.Controls.Add(Me.lblbTitle)
        Me.Controls.Add(Me.lblAddBookTitle)
        Me.Controls.Add(Me.btnAddBook)
        Me.Name = "UCaddbook"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.nudpages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback As Button
    Friend WithEvents btnCoverPicker As Button
    Friend WithEvents tbdescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbisbn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpPublicationDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents tbauthor As TextBox
    Friend WithEvents lblbauthor As Label
    Friend WithEvents tbtitle As TextBox
    Friend WithEvents lblbTitle As Label
    Friend WithEvents lblAddBookTitle As Label
    Friend WithEvents btnAddBook As Button
    Friend WithEvents tbbookid As TextBox
    Friend WithEvents lblbookid As Label
    Friend WithEvents nudpages As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cbcondition As ComboBox
End Class
