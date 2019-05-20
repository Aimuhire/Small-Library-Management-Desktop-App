<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLogsList
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
        Me.dgvlogs = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvlogs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnback.TabIndex = 34
        Me.btnback.UseVisualStyleBackColor = True
        '
        'dgvlogs
        '
        Me.dgvlogs.AllowUserToAddRows = False
        Me.dgvlogs.AllowUserToDeleteRows = False
        Me.dgvlogs.AllowUserToOrderColumns = True
        Me.dgvlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlogs.Location = New System.Drawing.Point(3, 54)
        Me.dgvlogs.Name = "dgvlogs"
        Me.dgvlogs.ReadOnly = True
        Me.dgvlogs.Size = New System.Drawing.Size(794, 393)
        Me.dgvlogs.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 42)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Library Activity Logger"
        '
        'UCLogsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvlogs)
        Me.Controls.Add(Me.btnback)
        Me.Name = "UCLogsList"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.dgvlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As Button
    Friend WithEvents dgvlogs As DataGridView
    Friend WithEvents Label1 As Label
End Class
