<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSettings
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
        Me.TCSettings = New System.Windows.Forms.TabControl()
        Me.tpgeneral = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudlatefee = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudmaxdays = New System.Windows.Forms.NumericUpDown()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.tpaccountinfo = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpchangepass = New System.Windows.Forms.TabPage()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboldpassword = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.btnupdatepass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.gbcolors = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.rbstandard = New System.Windows.Forms.RadioButton()
        Me.rbblue = New System.Windows.Forms.RadioButton()
        Me.graycolor = New System.Windows.Forms.PictureBox()
        Me.bluecolor = New System.Windows.Forms.PictureBox()
        Me.pinkcolor = New System.Windows.Forms.PictureBox()
        Me.rbpink = New System.Windows.Forms.RadioButton()
        Me.TCSettings.SuspendLayout()
        Me.tpgeneral.SuspendLayout()
        CType(Me.nudlatefee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudmaxdays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpaccountinfo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpchangepass.SuspendLayout()
        Me.gbcolors.SuspendLayout()
        CType(Me.graycolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bluecolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pinkcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCSettings
        '
        Me.TCSettings.Controls.Add(Me.tpgeneral)
        Me.TCSettings.Controls.Add(Me.tpaccountinfo)
        Me.TCSettings.Location = New System.Drawing.Point(3, 52)
        Me.TCSettings.Name = "TCSettings"
        Me.TCSettings.SelectedIndex = 0
        Me.TCSettings.Size = New System.Drawing.Size(794, 395)
        Me.TCSettings.TabIndex = 0
        '
        'tpgeneral
        '
        Me.tpgeneral.Controls.Add(Me.gbcolors)
        Me.tpgeneral.Controls.Add(Me.Label5)
        Me.tpgeneral.Controls.Add(Me.nudlatefee)
        Me.tpgeneral.Controls.Add(Me.Label4)
        Me.tpgeneral.Controls.Add(Me.nudmaxdays)
        Me.tpgeneral.Controls.Add(Me.btnSaveSettings)
        Me.tpgeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpgeneral.Name = "tpgeneral"
        Me.tpgeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgeneral.Size = New System.Drawing.Size(786, 369)
        Me.tpgeneral.TabIndex = 1
        Me.tpgeneral.Text = "General"
        Me.tpgeneral.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fee Per Late Day"
        '
        'nudlatefee
        '
        Me.nudlatefee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudlatefee.Location = New System.Drawing.Point(382, 127)
        Me.nudlatefee.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudlatefee.Name = "nudlatefee"
        Me.nudlatefee.Size = New System.Drawing.Size(120, 30)
        Me.nudlatefee.TabIndex = 3
        Me.nudlatefee.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Borrow Max Days"
        '
        'nudmaxdays
        '
        Me.nudmaxdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudmaxdays.Location = New System.Drawing.Point(382, 74)
        Me.nudmaxdays.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudmaxdays.Name = "nudmaxdays"
        Me.nudmaxdays.Size = New System.Drawing.Size(120, 30)
        Me.nudmaxdays.TabIndex = 1
        Me.nudmaxdays.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(236, 287)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(266, 23)
        Me.btnSaveSettings.TabIndex = 0
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'tpaccountinfo
        '
        Me.tpaccountinfo.Controls.Add(Me.TabControl1)
        Me.tpaccountinfo.Location = New System.Drawing.Point(4, 22)
        Me.tpaccountinfo.Name = "tpaccountinfo"
        Me.tpaccountinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpaccountinfo.Size = New System.Drawing.Size(786, 369)
        Me.tpaccountinfo.TabIndex = 0
        Me.tpaccountinfo.Text = "Account"
        Me.tpaccountinfo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpchangepass)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 369)
        Me.TabControl1.TabIndex = 0
        '
        'tpchangepass
        '
        Me.tpchangepass.Controls.Add(Me.tbusername)
        Me.tpchangepass.Controls.Add(Me.Label3)
        Me.tpchangepass.Controls.Add(Me.Label2)
        Me.tpchangepass.Controls.Add(Me.tboldpassword)
        Me.tpchangepass.Controls.Add(Me.tbpassword)
        Me.tpchangepass.Controls.Add(Me.btnupdatepass)
        Me.tpchangepass.Controls.Add(Me.Label1)
        Me.tpchangepass.Location = New System.Drawing.Point(4, 22)
        Me.tpchangepass.Name = "tpchangepass"
        Me.tpchangepass.Padding = New System.Windows.Forms.Padding(3)
        Me.tpchangepass.Size = New System.Drawing.Size(779, 343)
        Me.tpchangepass.TabIndex = 0
        Me.tpchangepass.Text = "Change Password"
        Me.tpchangepass.UseVisualStyleBackColor = True
        '
        'tbusername
        '
        Me.tbusername.AcceptsReturn = True
        Me.tbusername.BackColor = System.Drawing.SystemColors.Window
        Me.tbusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbusername.Location = New System.Drawing.Point(298, 42)
        Me.tbusername.MaxLength = 255
        Me.tbusername.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(205, 29)
        Me.tbusername.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "New Password"
        '
        'tboldpassword
        '
        Me.tboldpassword.AcceptsReturn = True
        Me.tboldpassword.BackColor = System.Drawing.SystemColors.Window
        Me.tboldpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboldpassword.Location = New System.Drawing.Point(298, 88)
        Me.tboldpassword.MaxLength = 255
        Me.tboldpassword.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tboldpassword.Name = "tboldpassword"
        Me.tboldpassword.Size = New System.Drawing.Size(205, 29)
        Me.tboldpassword.TabIndex = 19
        Me.tboldpassword.UseSystemPasswordChar = True
        '
        'tbpassword
        '
        Me.tbpassword.BackColor = System.Drawing.SystemColors.Window
        Me.tbpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpassword.Location = New System.Drawing.Point(298, 142)
        Me.tbpassword.MaxLength = 255
        Me.tbpassword.MinimumSize = New System.Drawing.Size(4, 30)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(205, 29)
        Me.tbpassword.TabIndex = 22
        Me.tbpassword.UseSystemPasswordChar = True
        '
        'btnupdatepass
        '
        Me.btnupdatepass.Location = New System.Drawing.Point(350, 224)
        Me.btnupdatepass.Name = "btnupdatepass"
        Me.btnupdatepass.Size = New System.Drawing.Size(75, 23)
        Me.btnupdatepass.TabIndex = 20
        Me.btnupdatepass.Text = "Update Password"
        Me.btnupdatepass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Old Password"
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
        Me.btnback.TabIndex = 13
        Me.btnback.UseVisualStyleBackColor = True
        '
        'gbcolors
        '
        Me.gbcolors.Controls.Add(Me.pinkcolor)
        Me.gbcolors.Controls.Add(Me.rbpink)
        Me.gbcolors.Controls.Add(Me.bluecolor)
        Me.gbcolors.Controls.Add(Me.graycolor)
        Me.gbcolors.Controls.Add(Me.rbblue)
        Me.gbcolors.Controls.Add(Me.rbstandard)
        Me.gbcolors.Location = New System.Drawing.Point(205, 163)
        Me.gbcolors.Name = "gbcolors"
        Me.gbcolors.Size = New System.Drawing.Size(341, 100)
        Me.gbcolors.TabIndex = 5
        Me.gbcolors.TabStop = False
        Me.gbcolors.Text = "Theme Color"
        '
        'rbstandard
        '
        Me.rbstandard.AutoSize = True
        Me.rbstandard.Location = New System.Drawing.Point(7, 31)
        Me.rbstandard.Name = "rbstandard"
        Me.rbstandard.Size = New System.Drawing.Size(14, 13)
        Me.rbstandard.TabIndex = 0
        Me.rbstandard.TabStop = True
        Me.rbstandard.UseVisualStyleBackColor = True
        '
        'rbblue
        '
        Me.rbblue.AutoSize = True
        Me.rbblue.Location = New System.Drawing.Point(137, 31)
        Me.rbblue.Name = "rbblue"
        Me.rbblue.Size = New System.Drawing.Size(28, 17)
        Me.rbblue.TabIndex = 1
        Me.rbblue.TabStop = True
        Me.rbblue.Text = " "
        Me.rbblue.UseVisualStyleBackColor = True
        '
        'graycolor
        '
        Me.graycolor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.graycolor.Location = New System.Drawing.Point(28, 31)
        Me.graycolor.Name = "graycolor"
        Me.graycolor.Size = New System.Drawing.Size(70, 50)
        Me.graycolor.TabIndex = 2
        Me.graycolor.TabStop = False
        '
        'bluecolor
        '
        Me.bluecolor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.bluecolor.Location = New System.Drawing.Point(157, 31)
        Me.bluecolor.Name = "bluecolor"
        Me.bluecolor.Size = New System.Drawing.Size(70, 50)
        Me.bluecolor.TabIndex = 3
        Me.bluecolor.TabStop = False
        '
        'pinkcolor
        '
        Me.pinkcolor.BackColor = System.Drawing.Color.HotPink
        Me.pinkcolor.Location = New System.Drawing.Point(258, 31)
        Me.pinkcolor.Name = "pinkcolor"
        Me.pinkcolor.Size = New System.Drawing.Size(70, 50)
        Me.pinkcolor.TabIndex = 5
        Me.pinkcolor.TabStop = False
        '
        'rbpink
        '
        Me.rbpink.AutoSize = True
        Me.rbpink.Location = New System.Drawing.Point(238, 31)
        Me.rbpink.Name = "rbpink"
        Me.rbpink.Size = New System.Drawing.Size(28, 17)
        Me.rbpink.TabIndex = 4
        Me.rbpink.TabStop = True
        Me.rbpink.Text = " "
        Me.rbpink.UseVisualStyleBackColor = True
        '
        'UCSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.TCSettings)
        Me.Name = "UCSettings"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.TCSettings.ResumeLayout(False)
        Me.tpgeneral.ResumeLayout(False)
        Me.tpgeneral.PerformLayout()
        CType(Me.nudlatefee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudmaxdays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpaccountinfo.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpchangepass.ResumeLayout(False)
        Me.tpchangepass.PerformLayout()
        Me.gbcolors.ResumeLayout(False)
        Me.gbcolors.PerformLayout()
        CType(Me.graycolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bluecolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pinkcolor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCSettings As TabControl
    Friend WithEvents tpaccountinfo As TabPage
    Friend WithEvents tpgeneral As TabPage
    Friend WithEvents btnback As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpchangepass As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents tboldpassword As TextBox
    Friend WithEvents tbpassword As TextBox
    Friend WithEvents btnupdatepass As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nudlatefee As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudmaxdays As NumericUpDown
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents gbcolors As GroupBox
    Friend WithEvents bluecolor As PictureBox
    Friend WithEvents graycolor As PictureBox
    Friend WithEvents rbblue As RadioButton
    Friend WithEvents rbstandard As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pinkcolor As PictureBox
    Friend WithEvents rbpink As RadioButton
End Class
