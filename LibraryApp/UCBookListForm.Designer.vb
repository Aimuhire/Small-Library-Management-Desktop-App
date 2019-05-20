<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCBookListForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.llblall = New System.Windows.Forms.LinkLabel()
        Me.llblborrowed = New System.Windows.Forms.LinkLabel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.llblavailable = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbisbn = New System.Windows.Forms.RadioButton()
        Me.rbdescription = New System.Windows.Forms.RadioButton()
        Me.rbbookid = New System.Windows.Forms.RadioButton()
        Me.rbauthor = New System.Windows.Forms.RadioButton()
        Me.rbtitle = New System.Windows.Forms.RadioButton()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'llblall
        '
        Me.llblall.AutoSize = True
        Me.llblall.Location = New System.Drawing.Point(166, 91)
        Me.llblall.Name = "llblall"
        Me.llblall.Size = New System.Drawing.Size(18, 13)
        Me.llblall.TabIndex = 31
        Me.llblall.TabStop = True
        Me.llblall.Text = "All"
        '
        'llblborrowed
        '
        Me.llblborrowed.AutoSize = True
        Me.llblborrowed.Location = New System.Drawing.Point(307, 91)
        Me.llblborrowed.Name = "llblborrowed"
        Me.llblborrowed.Size = New System.Drawing.Size(52, 13)
        Me.llblborrowed.TabIndex = 29
        Me.llblborrowed.TabStop = True
        Me.llblborrowed.Text = "Borrowed"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(511, 21)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(162, 24)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(324, 20)
        Me.tbsearch.TabIndex = 27
        '
        'dgvBooks
        '
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(3, 117)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBooks.Size = New System.Drawing.Size(794, 330)
        Me.dgvBooks.TabIndex = 33
        '
        'llblavailable
        '
        Me.llblavailable.AutoSize = True
        Me.llblavailable.Location = New System.Drawing.Point(226, 91)
        Me.llblavailable.Name = "llblavailable"
        Me.llblavailable.Size = New System.Drawing.Size(50, 13)
        Me.llblavailable.TabIndex = 38
        Me.llblavailable.TabStop = True
        Me.llblavailable.Text = "Available"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbisbn)
        Me.GroupBox1.Controls.Add(Me.rbdescription)
        Me.GroupBox1.Controls.Add(Me.rbbookid)
        Me.GroupBox1.Controls.Add(Me.rbauthor)
        Me.GroupBox1.Controls.Add(Me.rbtitle)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 37)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Column"
        '
        'rbisbn
        '
        Me.rbisbn.AutoSize = True
        Me.rbisbn.Location = New System.Drawing.Point(268, 14)
        Me.rbisbn.Name = "rbisbn"
        Me.rbisbn.Size = New System.Drawing.Size(50, 17)
        Me.rbisbn.TabIndex = 4
        Me.rbisbn.TabStop = True
        Me.rbisbn.Text = "ISBN"
        Me.rbisbn.UseVisualStyleBackColor = True
        '
        'rbdescription
        '
        Me.rbdescription.AutoSize = True
        Me.rbdescription.Location = New System.Drawing.Point(190, 14)
        Me.rbdescription.Name = "rbdescription"
        Me.rbdescription.Size = New System.Drawing.Size(78, 17)
        Me.rbdescription.TabIndex = 3
        Me.rbdescription.TabStop = True
        Me.rbdescription.Text = "Description"
        Me.rbdescription.UseVisualStyleBackColor = True
        '
        'rbbookid
        '
        Me.rbbookid.AutoSize = True
        Me.rbbookid.Location = New System.Drawing.Point(120, 14)
        Me.rbbookid.Name = "rbbookid"
        Me.rbbookid.Size = New System.Drawing.Size(64, 17)
        Me.rbbookid.TabIndex = 2
        Me.rbbookid.TabStop = True
        Me.rbbookid.Text = "Book ID"
        Me.rbbookid.UseVisualStyleBackColor = True
        '
        'rbauthor
        '
        Me.rbauthor.AutoSize = True
        Me.rbauthor.Location = New System.Drawing.Point(58, 14)
        Me.rbauthor.Name = "rbauthor"
        Me.rbauthor.Size = New System.Drawing.Size(56, 17)
        Me.rbauthor.TabIndex = 1
        Me.rbauthor.TabStop = True
        Me.rbauthor.Text = "Author"
        Me.rbauthor.UseVisualStyleBackColor = True
        '
        'rbtitle
        '
        Me.rbtitle.AutoSize = True
        Me.rbtitle.Location = New System.Drawing.Point(7, 14)
        Me.rbtitle.Name = "rbtitle"
        Me.rbtitle.Size = New System.Drawing.Size(45, 17)
        Me.rbtitle.TabIndex = 0
        Me.rbtitle.TabStop = True
        Me.rbtitle.Text = "Title"
        Me.rbtitle.UseVisualStyleBackColor = True
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
        Me.btnback.TabIndex = 26
        Me.btnback.UseVisualStyleBackColor = True
        '
        'UCBookListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.llblavailable)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.llblall)
        Me.Controls.Add(Me.llblborrowed)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.btnback)
        Me.Name = "UCBookListForm"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llblall As LinkLabel
    Friend WithEvents llblborrowed As LinkLabel
    Friend WithEvents btnsearch As Button
    Friend WithEvents tbsearch As TextBox
    Friend WithEvents btnback As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents llblavailable As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbisbn As RadioButton
    Friend WithEvents rbdescription As RadioButton
    Friend WithEvents rbbookid As RadioButton
    Friend WithEvents rbauthor As RadioButton
    Friend WithEvents rbtitle As RadioButton
End Class
