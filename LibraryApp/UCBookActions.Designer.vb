<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBookActions
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
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.tbreturnbookid = New System.Windows.Forms.TextBox()
        Me.nudAcademicYear = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbborrowcondition = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnborrow = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbreturncondition = New System.Windows.Forms.ComboBox()
        Me.lblreturn = New System.Windows.Forms.Label()
        Me.tbregno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbborrowBookId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tcBookActions = New System.Windows.Forms.TabControl()
        Me.tpBorrowBook = New System.Windows.Forms.TabPage()
        Me.tpReturnBook = New System.Windows.Forms.TabPage()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.nudAcademicYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcBookActions.SuspendLayout()
        Me.tpBorrowBook.SuspendLayout()
        Me.tpReturnBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnreturn
        '
        Me.btnreturn.Location = New System.Drawing.Point(354, 184)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(88, 23)
        Me.btnreturn.TabIndex = 18
        Me.btnreturn.Text = "Submit"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'tbreturnbookid
        '
        Me.tbreturnbookid.Location = New System.Drawing.Point(267, 123)
        Me.tbreturnbookid.Name = "tbreturnbookid"
        Me.tbreturnbookid.Size = New System.Drawing.Size(272, 20)
        Me.tbreturnbookid.TabIndex = 12
        '
        'nudAcademicYear
        '
        Me.nudAcademicYear.Location = New System.Drawing.Point(267, 175)
        Me.nudAcademicYear.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudAcademicYear.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAcademicYear.Name = "nudAcademicYear"
        Me.nudAcademicYear.Size = New System.Drawing.Size(272, 20)
        Me.nudAcademicYear.TabIndex = 25
        Me.nudAcademicYear.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Condition"
        '
        'cbborrowcondition
        '
        Me.cbborrowcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbborrowcondition.FormattingEnabled = True
        Me.cbborrowcondition.Items.AddRange(New Object() {"New", "Fine", "Very Good", "Good", "Fair", "Poor"})
        Me.cbborrowcondition.Location = New System.Drawing.Point(267, 201)
        Me.cbborrowcondition.Name = "cbborrowcondition"
        Me.cbborrowcondition.Size = New System.Drawing.Size(272, 21)
        Me.cbborrowcondition.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(309, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 31)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Book Borrow"
        '
        'btnborrow
        '
        Me.btnborrow.Location = New System.Drawing.Point(356, 279)
        Me.btnborrow.Name = "btnborrow"
        Me.btnborrow.Size = New System.Drawing.Size(88, 23)
        Me.btnborrow.TabIndex = 10
        Me.btnborrow.Text = "Submit"
        Me.btnborrow.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Academic Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Student RegNo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Condition"
        '
        'cbreturncondition
        '
        Me.cbreturncondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbreturncondition.FormattingEnabled = True
        Me.cbreturncondition.Items.AddRange(New Object() {"New", "Fine", "Very Good", "Good", "Fair", "Poor"})
        Me.cbreturncondition.Location = New System.Drawing.Point(267, 150)
        Me.cbreturncondition.Name = "cbreturncondition"
        Me.cbreturncondition.Size = New System.Drawing.Size(272, 21)
        Me.cbreturncondition.TabIndex = 21
        '
        'lblreturn
        '
        Me.lblreturn.AutoSize = True
        Me.lblreturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreturn.Location = New System.Drawing.Point(309, 65)
        Me.lblreturn.Name = "lblreturn"
        Me.lblreturn.Size = New System.Drawing.Size(165, 31)
        Me.lblreturn.TabIndex = 19
        Me.lblreturn.Text = "Book Return"
        '
        'tbregno
        '
        Me.tbregno.Location = New System.Drawing.Point(267, 149)
        Me.tbregno.MaxLength = 255
        Me.tbregno.Name = "tbregno"
        Me.tbregno.Size = New System.Drawing.Size(272, 20)
        Me.tbregno.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Book ID"
        '
        'tbborrowBookId
        '
        Me.tbborrowBookId.Location = New System.Drawing.Point(267, 123)
        Me.tbborrowBookId.MaxLength = 255
        Me.tbborrowBookId.Name = "tbborrowBookId"
        Me.tbborrowBookId.Size = New System.Drawing.Size(272, 20)
        Me.tbborrowBookId.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Book ID"
        '
        'tcBookActions
        '
        Me.tcBookActions.Controls.Add(Me.tpBorrowBook)
        Me.tcBookActions.Controls.Add(Me.tpReturnBook)
        Me.tcBookActions.Location = New System.Drawing.Point(12, 52)
        Me.tcBookActions.Name = "tcBookActions"
        Me.tcBookActions.SelectedIndex = 0
        Me.tcBookActions.Size = New System.Drawing.Size(784, 405)
        Me.tcBookActions.TabIndex = 1
        '
        'tpBorrowBook
        '
        Me.tpBorrowBook.Controls.Add(Me.nudAcademicYear)
        Me.tpBorrowBook.Controls.Add(Me.Label6)
        Me.tpBorrowBook.Controls.Add(Me.cbborrowcondition)
        Me.tpBorrowBook.Controls.Add(Me.Label4)
        Me.tpBorrowBook.Controls.Add(Me.btnborrow)
        Me.tpBorrowBook.Controls.Add(Me.Label3)
        Me.tpBorrowBook.Controls.Add(Me.Label2)
        Me.tpBorrowBook.Controls.Add(Me.tbregno)
        Me.tpBorrowBook.Controls.Add(Me.Label1)
        Me.tpBorrowBook.Controls.Add(Me.tbborrowBookId)
        Me.tpBorrowBook.Location = New System.Drawing.Point(4, 22)
        Me.tpBorrowBook.Name = "tpBorrowBook"
        Me.tpBorrowBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBorrowBook.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tpBorrowBook.Size = New System.Drawing.Size(776, 379)
        Me.tpBorrowBook.TabIndex = 0
        Me.tpBorrowBook.Text = "Borrow"
        Me.tpBorrowBook.UseVisualStyleBackColor = True
        '
        'tpReturnBook
        '
        Me.tpReturnBook.Controls.Add(Me.Label5)
        Me.tpReturnBook.Controls.Add(Me.cbreturncondition)
        Me.tpReturnBook.Controls.Add(Me.lblreturn)
        Me.tpReturnBook.Controls.Add(Me.btnreturn)
        Me.tpReturnBook.Controls.Add(Me.Label8)
        Me.tpReturnBook.Controls.Add(Me.tbreturnbookid)
        Me.tpReturnBook.Location = New System.Drawing.Point(4, 22)
        Me.tpReturnBook.Name = "tpReturnBook"
        Me.tpReturnBook.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReturnBook.Size = New System.Drawing.Size(776, 379)
        Me.tpReturnBook.TabIndex = 1
        Me.tpReturnBook.Text = "Return"
        Me.tpReturnBook.UseVisualStyleBackColor = True
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
        Me.btnback.TabIndex = 12
        Me.btnback.UseVisualStyleBackColor = True
        '
        'UCBookActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tcBookActions)
        Me.Controls.Add(Me.btnback)
        Me.Name = "UCBookActions"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.nudAcademicYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcBookActions.ResumeLayout(False)
        Me.tpBorrowBook.ResumeLayout(False)
        Me.tpBorrowBook.PerformLayout()
        Me.tpReturnBook.ResumeLayout(False)
        Me.tpReturnBook.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnreturn As Button
    Friend WithEvents tbreturnbookid As TextBox
    Friend WithEvents nudAcademicYear As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cbborrowcondition As ComboBox
    Friend WithEvents btnback As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnborrow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbreturncondition As ComboBox
    Friend WithEvents lblreturn As Label
    Friend WithEvents tbregno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbborrowBookId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tcBookActions As TabControl
    Friend WithEvents tpBorrowBook As TabPage
    Friend WithEvents tpReturnBook As TabPage
End Class
