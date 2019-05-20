<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCManageLib
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
        Me.btnsearchid = New System.Windows.Forms.Button()
        Me.tbsearchid = New System.Windows.Forms.TextBox()
        Me.LibdbDataSet1 = New LibraryApp.libdbDataSet()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbldcondition = New System.Windows.Forms.Label()
        Me.lbldbookid = New System.Windows.Forms.Label()
        Me.lblddescr = New System.Windows.Forms.Label()
        Me.lbldpages = New System.Windows.Forms.Label()
        Me.lbldisbn = New System.Windows.Forms.Label()
        Me.lbldpubdate = New System.Windows.Forms.Label()
        Me.lbldauthor = New System.Windows.Forms.Label()
        Me.lbldtitle = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btndsearch = New System.Windows.Forms.Button()
        Me.tbdsearchid = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbcondition = New System.Windows.Forms.ComboBox()
        Me.nudpages = New System.Windows.Forms.NumericUpDown()
        Me.tbbookid = New System.Windows.Forms.TextBox()
        Me.lblbookid = New System.Windows.Forms.Label()
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
        Me.btnedit = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbregnumber = New System.Windows.Forms.RadioButton()
        Me.rbbookid = New System.Windows.Forms.RadioButton()
        Me.dgvTransfers = New System.Windows.Forms.DataGridView()
        Me.llblreturned = New System.Windows.Forms.LinkLabel()
        Me.llblall = New System.Windows.Forms.LinkLabel()
        Me.llblborrowed = New System.Windows.Forms.LinkLabel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.tbeditdeletetransfer = New System.Windows.Forms.TabControl()
        Me.vsearchbyid = New LibraryApp.UCSearchbyidView()
        Me.vdsearchid = New LibraryApp.UCSearchbyidView()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.LibdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudpages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTransfers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbeditdeletetransfer.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsearchid
        '
        Me.btnsearchid.Location = New System.Drawing.Point(449, 6)
        Me.btnsearchid.Name = "btnsearchid"
        Me.btnsearchid.Size = New System.Drawing.Size(88, 23)
        Me.btnsearchid.TabIndex = 54
        Me.btnsearchid.Text = "Search by ID"
        Me.btnsearchid.UseVisualStyleBackColor = True
        '
        'tbsearchid
        '
        Me.tbsearchid.Location = New System.Drawing.Point(266, 6)
        Me.tbsearchid.Name = "tbsearchid"
        Me.tbsearchid.Size = New System.Drawing.Size(177, 20)
        Me.tbsearchid.TabIndex = 53
        '
        'LibdbDataSet1
        '
        Me.LibdbDataSet1.DataSetName = "libdbDataSet"
        Me.LibdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.vdsearchid)
        Me.TabPage3.Controls.Add(Me.lbldcondition)
        Me.TabPage3.Controls.Add(Me.lbldbookid)
        Me.TabPage3.Controls.Add(Me.lblddescr)
        Me.TabPage3.Controls.Add(Me.lbldpages)
        Me.TabPage3.Controls.Add(Me.lbldisbn)
        Me.TabPage3.Controls.Add(Me.lbldpubdate)
        Me.TabPage3.Controls.Add(Me.lbldauthor)
        Me.TabPage3.Controls.Add(Me.lbldtitle)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.btndsearch)
        Me.TabPage3.Controls.Add(Me.tbdsearchid)
        Me.TabPage3.Controls.Add(Me.btndelete)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(792, 357)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delete Book"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbldcondition
        '
        Me.lbldcondition.AutoSize = True
        Me.lbldcondition.Location = New System.Drawing.Point(321, 242)
        Me.lbldcondition.Name = "lbldcondition"
        Me.lbldcondition.Size = New System.Drawing.Size(145, 13)
        Me.lbldcondition.TabIndex = 108
        Me.lbldcondition.Text = "----------------------------------------------"
        '
        'lbldbookid
        '
        Me.lbldbookid.AutoSize = True
        Me.lbldbookid.Location = New System.Drawing.Point(321, 113)
        Me.lbldbookid.Name = "lbldbookid"
        Me.lbldbookid.Size = New System.Drawing.Size(145, 13)
        Me.lbldbookid.TabIndex = 107
        Me.lbldbookid.Text = "----------------------------------------------"
        '
        'lblddescr
        '
        Me.lblddescr.AutoSize = True
        Me.lblddescr.Location = New System.Drawing.Point(320, 216)
        Me.lblddescr.Name = "lblddescr"
        Me.lblddescr.Size = New System.Drawing.Size(145, 13)
        Me.lblddescr.TabIndex = 106
        Me.lblddescr.Text = "----------------------------------------------"
        '
        'lbldpages
        '
        Me.lbldpages.AutoSize = True
        Me.lbldpages.Location = New System.Drawing.Point(320, 190)
        Me.lbldpages.Name = "lbldpages"
        Me.lbldpages.Size = New System.Drawing.Size(145, 13)
        Me.lbldpages.TabIndex = 105
        Me.lbldpages.Text = "----------------------------------------------"
        '
        'lbldisbn
        '
        Me.lbldisbn.AutoSize = True
        Me.lbldisbn.Location = New System.Drawing.Point(320, 162)
        Me.lbldisbn.Name = "lbldisbn"
        Me.lbldisbn.Size = New System.Drawing.Size(145, 13)
        Me.lbldisbn.TabIndex = 104
        Me.lbldisbn.Text = "----------------------------------------------"
        '
        'lbldpubdate
        '
        Me.lbldpubdate.AutoSize = True
        Me.lbldpubdate.Location = New System.Drawing.Point(320, 136)
        Me.lbldpubdate.Name = "lbldpubdate"
        Me.lbldpubdate.Size = New System.Drawing.Size(145, 13)
        Me.lbldpubdate.TabIndex = 103
        Me.lbldpubdate.Text = "----------------------------------------------"
        '
        'lbldauthor
        '
        Me.lbldauthor.AutoSize = True
        Me.lbldauthor.Location = New System.Drawing.Point(321, 86)
        Me.lbldauthor.Name = "lbldauthor"
        Me.lbldauthor.Size = New System.Drawing.Size(145, 13)
        Me.lbldauthor.TabIndex = 102
        Me.lbldauthor.Text = "----------------------------------------------"
        '
        'lbldtitle
        '
        Me.lbldtitle.AutoSize = True
        Me.lbldtitle.Location = New System.Drawing.Point(321, 60)
        Me.lbldtitle.Name = "lbldtitle"
        Me.lbldtitle.Size = New System.Drawing.Size(145, 13)
        Me.lbldtitle.TabIndex = 101
        Me.lbldtitle.Text = "----------------------------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Condition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Book ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(235, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Pages"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(235, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "ISBN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(235, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Publication date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(236, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Author"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(236, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Title"
        '
        'btndsearch
        '
        Me.btndsearch.Location = New System.Drawing.Point(449, 6)
        Me.btndsearch.Name = "btndsearch"
        Me.btndsearch.Size = New System.Drawing.Size(88, 23)
        Me.btndsearch.TabIndex = 56
        Me.btndsearch.Text = "Search by ID"
        Me.btndsearch.UseVisualStyleBackColor = True
        '
        'tbdsearchid
        '
        Me.tbdsearchid.Location = New System.Drawing.Point(266, 6)
        Me.tbdsearchid.Name = "tbdsearchid"
        Me.tbdsearchid.Size = New System.Drawing.Size(177, 20)
        Me.tbdsearchid.TabIndex = 55
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.vsearchbyid)
        Me.TabPage2.Controls.Add(Me.btnsearchid)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.tbsearchid)
        Me.TabPage2.Controls.Add(Me.cbcondition)
        Me.TabPage2.Controls.Add(Me.nudpages)
        Me.TabPage2.Controls.Add(Me.tbbookid)
        Me.TabPage2.Controls.Add(Me.lblbookid)
        Me.TabPage2.Controls.Add(Me.btnCoverPicker)
        Me.TabPage2.Controls.Add(Me.tbdescription)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.tbisbn)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dtpPublicationDate)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.tbauthor)
        Me.TabPage2.Controls.Add(Me.lblbauthor)
        Me.TabPage2.Controls.Add(Me.tbtitle)
        Me.TabPage2.Controls.Add(Me.lblbTitle)
        Me.TabPage2.Controls.Add(Me.btnedit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 357)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edit Book"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Condition"
        '
        'cbcondition
        '
        Me.cbcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcondition.FormattingEnabled = True
        Me.cbcondition.Items.AddRange(New Object() {"New", "Fine", "Very Good", "Good", "Fair", "Poor"})
        Me.cbcondition.Location = New System.Drawing.Point(266, 232)
        Me.cbcondition.Name = "cbcondition"
        Me.cbcondition.Size = New System.Drawing.Size(272, 21)
        Me.cbcondition.TabIndex = 89
        '
        'nudpages
        '
        Me.nudpages.Location = New System.Drawing.Point(266, 181)
        Me.nudpages.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudpages.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudpages.Name = "nudpages"
        Me.nudpages.Size = New System.Drawing.Size(271, 20)
        Me.nudpages.TabIndex = 88
        Me.nudpages.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbbookid
        '
        Me.tbbookid.Location = New System.Drawing.Point(266, 103)
        Me.tbbookid.Name = "tbbookid"
        Me.tbbookid.Size = New System.Drawing.Size(271, 20)
        Me.tbbookid.TabIndex = 87
        '
        'lblbookid
        '
        Me.lblbookid.AutoSize = True
        Me.lblbookid.Location = New System.Drawing.Point(177, 106)
        Me.lblbookid.Name = "lblbookid"
        Me.lblbookid.Size = New System.Drawing.Size(46, 13)
        Me.lblbookid.TabIndex = 86
        Me.lblbookid.Text = "Book ID"
        '
        'btnCoverPicker
        '
        Me.btnCoverPicker.Location = New System.Drawing.Point(266, 258)
        Me.btnCoverPicker.Name = "btnCoverPicker"
        Me.btnCoverPicker.Size = New System.Drawing.Size(271, 23)
        Me.btnCoverPicker.TabIndex = 85
        Me.btnCoverPicker.Text = "Choose Cover"
        Me.btnCoverPicker.UseVisualStyleBackColor = True
        '
        'tbdescription
        '
        Me.tbdescription.Location = New System.Drawing.Point(266, 206)
        Me.tbdescription.Name = "tbdescription"
        Me.tbdescription.Size = New System.Drawing.Size(271, 20)
        Me.tbdescription.TabIndex = 84
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Pages"
        '
        'tbisbn
        '
        Me.tbisbn.Location = New System.Drawing.Point(266, 155)
        Me.tbisbn.Name = "tbisbn"
        Me.tbisbn.Size = New System.Drawing.Size(271, 20)
        Me.tbisbn.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "ISBN"
        '
        'dtpPublicationDate
        '
        Me.dtpPublicationDate.Location = New System.Drawing.Point(266, 129)
        Me.dtpPublicationDate.Name = "dtpPublicationDate"
        Me.dtpPublicationDate.Size = New System.Drawing.Size(271, 20)
        Me.dtpPublicationDate.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Publication date"
        '
        'tbauthor
        '
        Me.tbauthor.Location = New System.Drawing.Point(266, 76)
        Me.tbauthor.Name = "tbauthor"
        Me.tbauthor.Size = New System.Drawing.Size(271, 20)
        Me.tbauthor.TabIndex = 77
        '
        'lblbauthor
        '
        Me.lblbauthor.AutoSize = True
        Me.lblbauthor.Location = New System.Drawing.Point(177, 79)
        Me.lblbauthor.Name = "lblbauthor"
        Me.lblbauthor.Size = New System.Drawing.Size(38, 13)
        Me.lblbauthor.TabIndex = 76
        Me.lblbauthor.Text = "Author"
        '
        'tbtitle
        '
        Me.tbtitle.Location = New System.Drawing.Point(266, 50)
        Me.tbtitle.Name = "tbtitle"
        Me.tbtitle.Size = New System.Drawing.Size(271, 20)
        Me.tbtitle.TabIndex = 75
        '
        'lblbTitle
        '
        Me.lblbTitle.AutoSize = True
        Me.lblbTitle.Location = New System.Drawing.Point(177, 53)
        Me.lblbTitle.Name = "lblbTitle"
        Me.lblbTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblbTitle.TabIndex = 74
        Me.lblbTitle.Text = "Title"
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(368, 303)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 73
        Me.btnedit.Text = " Submit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dgvTransfers)
        Me.TabPage1.Controls.Add(Me.llblreturned)
        Me.TabPage1.Controls.Add(Me.llblall)
        Me.TabPage1.Controls.Add(Me.llblborrowed)
        Me.TabPage1.Controls.Add(Me.btnsearch)
        Me.TabPage1.Controls.Add(Me.tbsearch)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transfers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbregnumber)
        Me.GroupBox1.Controls.Add(Me.rbbookid)
        Me.GroupBox1.Location = New System.Drawing.Point(158, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 37)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Column"
        '
        'rbregnumber
        '
        Me.rbregnumber.AutoSize = True
        Me.rbregnumber.Location = New System.Drawing.Point(76, 14)
        Me.rbregnumber.Name = "rbregnumber"
        Me.rbregnumber.Size = New System.Drawing.Size(85, 17)
        Me.rbregnumber.TabIndex = 3
        Me.rbregnumber.TabStop = True
        Me.rbregnumber.Text = "Reg Number"
        Me.rbregnumber.UseVisualStyleBackColor = True
        '
        'rbbookid
        '
        Me.rbbookid.AutoSize = True
        Me.rbbookid.Location = New System.Drawing.Point(6, 14)
        Me.rbbookid.Name = "rbbookid"
        Me.rbbookid.Size = New System.Drawing.Size(64, 17)
        Me.rbbookid.TabIndex = 2
        Me.rbbookid.TabStop = True
        Me.rbbookid.Text = "Book ID"
        Me.rbbookid.UseVisualStyleBackColor = True
        '
        'dgvTransfers
        '
        Me.dgvTransfers.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransfers.GridColor = System.Drawing.SystemColors.WindowFrame
        Me.dgvTransfers.Location = New System.Drawing.Point(-1, 121)
        Me.dgvTransfers.MultiSelect = False
        Me.dgvTransfers.Name = "dgvTransfers"
        Me.dgvTransfers.ReadOnly = True
        Me.dgvTransfers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTransfers.Size = New System.Drawing.Size(794, 261)
        Me.dgvTransfers.TabIndex = 53
        '
        'llblreturned
        '
        Me.llblreturned.AutoSize = True
        Me.llblreturned.Location = New System.Drawing.Point(313, 102)
        Me.llblreturned.Name = "llblreturned"
        Me.llblreturned.Size = New System.Drawing.Size(51, 13)
        Me.llblreturned.TabIndex = 54
        Me.llblreturned.TabStop = True
        Me.llblreturned.Text = "Returned"
        '
        'llblall
        '
        Me.llblall.AutoSize = True
        Me.llblall.Location = New System.Drawing.Point(162, 102)
        Me.llblall.Name = "llblall"
        Me.llblall.Size = New System.Drawing.Size(18, 13)
        Me.llblall.TabIndex = 52
        Me.llblall.TabStop = True
        Me.llblall.Text = "All"
        '
        'llblborrowed
        '
        Me.llblborrowed.AutoSize = True
        Me.llblborrowed.Location = New System.Drawing.Point(231, 102)
        Me.llblborrowed.Name = "llblborrowed"
        Me.llblborrowed.Size = New System.Drawing.Size(52, 13)
        Me.llblborrowed.TabIndex = 51
        Me.llblborrowed.TabStop = True
        Me.llblborrowed.Text = "Borrowed"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(507, 32)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 50
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(158, 35)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(324, 20)
        Me.tbsearch.TabIndex = 49
        '
        'tbeditdeletetransfer
        '
        Me.tbeditdeletetransfer.Controls.Add(Me.TabPage1)
        Me.tbeditdeletetransfer.Controls.Add(Me.TabPage2)
        Me.tbeditdeletetransfer.Controls.Add(Me.TabPage3)
        Me.tbeditdeletetransfer.Location = New System.Drawing.Point(3, 52)
        Me.tbeditdeletetransfer.Name = "tbeditdeletetransfer"
        Me.tbeditdeletetransfer.SelectedIndex = 0
        Me.tbeditdeletetransfer.Size = New System.Drawing.Size(800, 383)
        Me.tbeditdeletetransfer.TabIndex = 0
        '
        'vsearchbyid
        '
        Me.vsearchbyid.Location = New System.Drawing.Point(3, 48)
        Me.vsearchbyid.Name = "vsearchbyid"
        Me.vsearchbyid.Size = New System.Drawing.Size(780, 340)
        Me.vsearchbyid.TabIndex = 92
        '
        'vdsearchid
        '
        Me.vdsearchid.Location = New System.Drawing.Point(3, 48)
        Me.vdsearchid.Name = "vdsearchid"
        Me.vdsearchid.Size = New System.Drawing.Size(780, 330)
        Me.vdsearchid.TabIndex = 110
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
        Me.btnback.TabIndex = 49
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Image = Global.LibraryApp.My.Resources.Resources.delete
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(275, 281)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(113, 41)
        Me.btndelete.TabIndex = 109
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'UCManageLib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.tbeditdeletetransfer)
        Me.Name = "UCManageLib"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.LibdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudpages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTransfers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbeditdeletetransfer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnback As Button
    Friend WithEvents btnsearchid As Button
    Friend WithEvents tbsearchid As TextBox
    Friend WithEvents LibdbDataSet1 As libdbDataSet
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbregnumber As RadioButton
    Friend WithEvents rbbookid As RadioButton
    Friend WithEvents dgvTransfers As DataGridView
    Friend WithEvents llblreturned As LinkLabel
    Friend WithEvents llblall As LinkLabel
    Friend WithEvents llblborrowed As LinkLabel
    Friend WithEvents btnsearch As Button
    Friend WithEvents tbsearch As TextBox
    Friend WithEvents tbeditdeletetransfer As TabControl
    Friend WithEvents Label6 As Label
    Friend WithEvents cbcondition As ComboBox
    Friend WithEvents nudpages As NumericUpDown
    Friend WithEvents tbbookid As TextBox
    Friend WithEvents lblbookid As Label
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
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents lbldcondition As Label
    Friend WithEvents lbldbookid As Label
    Friend WithEvents lblddescr As Label
    Friend WithEvents lbldpages As Label
    Friend WithEvents lbldisbn As Label
    Friend WithEvents lbldpubdate As Label
    Friend WithEvents lbldauthor As Label
    Friend WithEvents lbldtitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btndsearch As Button
    Friend WithEvents tbdsearchid As TextBox
    Friend WithEvents vdsearchid As UCSearchbyidView
    Friend WithEvents vsearchbyid As UCSearchbyidView
End Class
