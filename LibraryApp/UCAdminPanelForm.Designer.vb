<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCAdminPanelForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.lblbookactions = New System.Windows.Forms.Label()
        Me.lbladdbook = New System.Windows.Forms.Label()
        Me.lbllogout = New System.Windows.Forms.Label()
        Me.btnsettings = New System.Windows.Forms.Button()
        Me.btnreports = New System.Windows.Forms.Button()
        Me.btnTransfers = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnbookactions = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(633, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Reports"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Manage Library"
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(605, 202)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(86, 13)
        Me.lblsearch.TabIndex = 17
        Me.lblsearch.Text = "Search Books"
        '
        'lblbookactions
        '
        Me.lblbookactions.AutoSize = True
        Me.lblbookactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookactions.Location = New System.Drawing.Point(339, 202)
        Me.lblbookactions.Name = "lblbookactions"
        Me.lblbookactions.Size = New System.Drawing.Size(90, 13)
        Me.lblbookactions.TabIndex = 16
        Me.lblbookactions.Text = "Borrow/Return"
        '
        'lbladdbook
        '
        Me.lbladdbook.AutoSize = True
        Me.lbladdbook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdbook.Location = New System.Drawing.Point(109, 202)
        Me.lbladdbook.Name = "lbladdbook"
        Me.lbladdbook.Size = New System.Drawing.Size(62, 13)
        Me.lbladdbook.TabIndex = 15
        Me.lbladdbook.Text = "Add Book"
        '
        'lbllogout
        '
        Me.lbllogout.AutoSize = True
        Me.lbllogout.Location = New System.Drawing.Point(699, 22)
        Me.lbllogout.Name = "lbllogout"
        Me.lbllogout.Size = New System.Drawing.Size(40, 13)
        Me.lbllogout.TabIndex = 25
        Me.lbllogout.Text = "Logout"
        Me.lbllogout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnsettings
        '
        Me.btnsettings.FlatAppearance.BorderSize = 0
        Me.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsettings.Image = Global.LibraryApp.My.Resources.Resources.settings
        Me.btnsettings.Location = New System.Drawing.Point(575, 288)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(164, 80)
        Me.btnsettings.TabIndex = 20
        Me.btnsettings.UseVisualStyleBackColor = True
        '
        'btnreports
        '
        Me.btnreports.FlatAppearance.BorderSize = 0
        Me.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreports.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.Image = Global.LibraryApp.My.Resources.Resources.laptop
        Me.btnreports.Location = New System.Drawing.Point(313, 288)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Size = New System.Drawing.Size(164, 80)
        Me.btnreports.TabIndex = 19
        Me.btnreports.UseVisualStyleBackColor = True
        '
        'btnTransfers
        '
        Me.btnTransfers.FlatAppearance.BorderSize = 0
        Me.btnTransfers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfers.Image = Global.LibraryApp.My.Resources.Resources.process
        Me.btnTransfers.Location = New System.Drawing.Point(63, 288)
        Me.btnTransfers.Name = "btnTransfers"
        Me.btnTransfers.Size = New System.Drawing.Size(164, 80)
        Me.btnTransfers.TabIndex = 18
        Me.btnTransfers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTransfers.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.FlatAppearance.BorderSize = 0
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Image = Global.LibraryApp.My.Resources.Resources.magnifier
        Me.btnsearch.Location = New System.Drawing.Point(561, 119)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(164, 80)
        Me.btnsearch.TabIndex = 14
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnbookactions
        '
        Me.btnbookactions.FlatAppearance.BorderSize = 0
        Me.btnbookactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbookactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbookactions.Image = Global.LibraryApp.My.Resources.Resources.transfer
        Me.btnbookactions.Location = New System.Drawing.Point(299, 119)
        Me.btnbookactions.Name = "btnbookactions"
        Me.btnbookactions.Size = New System.Drawing.Size(164, 80)
        Me.btnbookactions.TabIndex = 13
        Me.btnbookactions.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.FlatAppearance.BorderSize = 0
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Image = Global.LibraryApp.My.Resources.Resources.add_book
        Me.btnAddBook.Location = New System.Drawing.Point(63, 119)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(164, 80)
        Me.btnAddBook.TabIndex = 12
        Me.btnAddBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnlogout
        '
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Image = Global.LibraryApp.My.Resources.Resources.exit_to_app_button__1_
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogout.Location = New System.Drawing.Point(745, 13)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(33, 31)
        Me.btnlogout.TabIndex = 24
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'UCAdminPanelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbllogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsettings)
        Me.Controls.Add(Me.btnreports)
        Me.Controls.Add(Me.btnTransfers)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.lblbookactions)
        Me.Controls.Add(Me.lbladdbook)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnbookactions)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.btnlogout)
        Me.Name = "UCAdminPanelForm"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsettings As Button
    Friend WithEvents btnreports As Button
    Friend WithEvents btnTransfers As Button
    Friend WithEvents lblsearch As Label
    Friend WithEvents lblbookactions As Label
    Friend WithEvents lbladdbook As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnbookactions As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents lbllogout As Label
End Class
