<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.menustripview = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransfersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UcHelpPage1 = New LibraryApp.UCHelpPage()
        Me.UcSettings1 = New LibraryApp.UCSettings()
        Me.UcManageLib1 = New LibraryApp.UCManageLib()
        Me.UcLoginForm1 = New LibraryApp.UCLoginForm()
        Me.UcBookListForm1 = New LibraryApp.UCBookListForm()
        Me.UcBookActions1 = New LibraryApp.UCBookActions()
        Me.UcAdminPanelForm1 = New LibraryApp.UCAdminPanelForm()
        Me.UCaddbook1 = New LibraryApp.UCaddbook()
        Me.UcLogsList1 = New LibraryApp.UCLogsList()
        Me.UcStats1 = New LibraryApp.UCStats()
        Me.UcAboutPage1 = New LibraryApp.UCAboutPage()
        Me.menustripview.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustripview
        '
        Me.menustripview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menustripview.Location = New System.Drawing.Point(0, 0)
        Me.menustripview.Name = "menustripview"
        Me.menustripview.Size = New System.Drawing.Size(800, 24)
        Me.menustripview.TabIndex = 9
        Me.menustripview.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditBookToolStripMenuItem, Me.DeleteBookToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EditBookToolStripMenuItem
        '
        Me.EditBookToolStripMenuItem.Name = "EditBookToolStripMenuItem"
        Me.EditBookToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EditBookToolStripMenuItem.Text = "Edit Book"
        '
        'DeleteBookToolStripMenuItem
        '
        Me.DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem"
        Me.DeleteBookToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DeleteBookToolStripMenuItem.Text = "Delete Book"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransfersToolStripMenuItem, Me.SearchBooksToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TransfersToolStripMenuItem
        '
        Me.TransfersToolStripMenuItem.Name = "TransfersToolStripMenuItem"
        Me.TransfersToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TransfersToolStripMenuItem.Text = "Transfers"
        '
        'SearchBooksToolStripMenuItem
        '
        Me.SearchBooksToolStripMenuItem.Name = "SearchBooksToolStripMenuItem"
        Me.SearchBooksToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SearchBooksToolStripMenuItem.Text = "Search Books"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBookToolStripMenuItem, Me.AdminPanelToolStripMenuItem, Me.BorrowActionToolStripMenuItem, Me.ReturnActionToolStripMenuItem, Me.ManageLibraryToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowsToolStripMenuItem.Text = "Window"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AddBookToolStripMenuItem.Text = "Add Book"
        '
        'AdminPanelToolStripMenuItem
        '
        Me.AdminPanelToolStripMenuItem.Name = "AdminPanelToolStripMenuItem"
        Me.AdminPanelToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AdminPanelToolStripMenuItem.Text = "Admin Panel"
        '
        'BorrowActionToolStripMenuItem
        '
        Me.BorrowActionToolStripMenuItem.Name = "BorrowActionToolStripMenuItem"
        Me.BorrowActionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BorrowActionToolStripMenuItem.Text = "Borrow Action"
        '
        'ReturnActionToolStripMenuItem
        '
        Me.ReturnActionToolStripMenuItem.Name = "ReturnActionToolStripMenuItem"
        Me.ReturnActionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ReturnActionToolStripMenuItem.Text = "Return Action"
        '
        'ManageLibraryToolStripMenuItem
        '
        Me.ManageLibraryToolStripMenuItem.Name = "ManageLibraryToolStripMenuItem"
        Me.ManageLibraryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ManageLibraryToolStripMenuItem.Text = "Manage Library"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'UcHelpPage1
        '
        Me.UcHelpPage1.Location = New System.Drawing.Point(0, 27)
        Me.UcHelpPage1.Name = "UcHelpPage1"
        Me.UcHelpPage1.Size = New System.Drawing.Size(800, 450)
        Me.UcHelpPage1.TabIndex = 20
        '
        'UcSettings1
        '
        Me.UcSettings1.Location = New System.Drawing.Point(0, 27)
        Me.UcSettings1.Name = "UcSettings1"
        Me.UcSettings1.Size = New System.Drawing.Size(800, 450)
        Me.UcSettings1.TabIndex = 17
        '
        'UcManageLib1
        '
        Me.UcManageLib1.Location = New System.Drawing.Point(0, 27)
        Me.UcManageLib1.Name = "UcManageLib1"
        Me.UcManageLib1.Size = New System.Drawing.Size(800, 450)
        Me.UcManageLib1.TabIndex = 15
        '
        'UcLoginForm1
        '
        Me.UcLoginForm1.Location = New System.Drawing.Point(0, 27)
        Me.UcLoginForm1.Name = "UcLoginForm1"
        Me.UcLoginForm1.Size = New System.Drawing.Size(800, 450)
        Me.UcLoginForm1.TabIndex = 14
        '
        'UcBookListForm1
        '
        Me.UcBookListForm1.Location = New System.Drawing.Point(0, 27)
        Me.UcBookListForm1.Name = "UcBookListForm1"
        Me.UcBookListForm1.Size = New System.Drawing.Size(800, 450)
        Me.UcBookListForm1.TabIndex = 13
        '
        'UcBookActions1
        '
        Me.UcBookActions1.Location = New System.Drawing.Point(0, 27)
        Me.UcBookActions1.Name = "UcBookActions1"
        Me.UcBookActions1.Size = New System.Drawing.Size(800, 450)
        Me.UcBookActions1.TabIndex = 12
        '
        'UcAdminPanelForm1
        '
        Me.UcAdminPanelForm1.Location = New System.Drawing.Point(0, 27)
        Me.UcAdminPanelForm1.Name = "UcAdminPanelForm1"
        Me.UcAdminPanelForm1.Size = New System.Drawing.Size(800, 450)
        Me.UcAdminPanelForm1.TabIndex = 11
        '
        'UCaddbook1
        '
        Me.UCaddbook1.Location = New System.Drawing.Point(0, 27)
        Me.UCaddbook1.Name = "UCaddbook1"
        Me.UCaddbook1.Size = New System.Drawing.Size(800, 450)
        Me.UCaddbook1.TabIndex = 10
        '
        'UcLogsList1
        '
        Me.UcLogsList1.Location = New System.Drawing.Point(0, 27)
        Me.UcLogsList1.Name = "UcLogsList1"
        Me.UcLogsList1.Size = New System.Drawing.Size(800, 450)
        Me.UcLogsList1.TabIndex = 19
        '
        'UcStats1
        '
        Me.UcStats1.Location = New System.Drawing.Point(0, 27)
        Me.UcStats1.Name = "UcStats1"
        Me.UcStats1.Size = New System.Drawing.Size(800, 450)
        Me.UcStats1.TabIndex = 18
        '
        'UcAboutPage1
        '
        Me.UcAboutPage1.Location = New System.Drawing.Point(0, 27)
        Me.UcAboutPage1.Name = "UcAboutPage1"
        Me.UcAboutPage1.Size = New System.Drawing.Size(800, 450)
        Me.UcAboutPage1.TabIndex = 21
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.UcAboutPage1)
        Me.Controls.Add(Me.UcHelpPage1)
        Me.Controls.Add(Me.UcSettings1)
        Me.Controls.Add(Me.UcManageLib1)
        Me.Controls.Add(Me.UcLoginForm1)
        Me.Controls.Add(Me.UcBookListForm1)
        Me.Controls.Add(Me.UcBookActions1)
        Me.Controls.Add(Me.UcAdminPanelForm1)
        Me.Controls.Add(Me.UCaddbook1)
        Me.Controls.Add(Me.menustripview)
        Me.Controls.Add(Me.UcLogsList1)
        Me.Controls.Add(Me.UcStats1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.menustripview.ResumeLayout(False)
        Me.menustripview.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menustripview As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UCaddbook1 As UCaddbook
    Friend WithEvents UcAdminPanelForm1 As UCAdminPanelForm
    Friend WithEvents UcBookActions1 As UCBookActions
    Friend WithEvents UcBookListForm1 As UCBookListForm
    Friend WithEvents UcLoginForm1 As UCLoginForm
    Friend WithEvents UcManageLib1 As UCManageLib
    Friend WithEvents UcSettings1 As UCSettings
    Friend WithEvents UcStats1 As UCStats
    Friend WithEvents UcLogsList1 As UCLogsList
    Friend WithEvents TransfersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UcHelpPage1 As UCHelpPage
    Friend WithEvents UcAboutPage1 As UCAboutPage
End Class
