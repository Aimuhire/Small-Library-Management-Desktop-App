<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCStats
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbltotalbooks = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblborrowed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbllatereturns = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotalbooks
        '
        Me.lbltotalbooks.AutoSize = True
        Me.lbltotalbooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotalbooks.Location = New System.Drawing.Point(87, 46)
        Me.lbltotalbooks.Name = "lbltotalbooks"
        Me.lbltotalbooks.Size = New System.Drawing.Size(120, 63)
        Me.lbltotalbooks.TabIndex = 0
        Me.lbltotalbooks.Text = "445"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Books"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Borrowed"
        '
        'lblborrowed
        '
        Me.lblborrowed.AutoSize = True
        Me.lblborrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblborrowed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblborrowed.Location = New System.Drawing.Point(250, 46)
        Me.lblborrowed.Name = "lblborrowed"
        Me.lblborrowed.Size = New System.Drawing.Size(89, 63)
        Me.lblborrowed.TabIndex = 2
        Me.lblborrowed.Text = "78"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Late Returns"
        '
        'lbllatereturns
        '
        Me.lbllatereturns.AutoSize = True
        Me.lbllatereturns.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllatereturns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbllatereturns.Location = New System.Drawing.Point(402, 46)
        Me.lbllatereturns.Name = "lbllatereturns"
        Me.lbllatereturns.Size = New System.Drawing.Size(58, 63)
        Me.lbllatereturns.TabIndex = 4
        Me.lbllatereturns.Text = "4"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(570, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Activity Log"
        '
        'btnlog
        '
        Me.btnlog.FlatAppearance.BorderSize = 0
        Me.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlog.Image = Global.LibraryApp.My.Resources.Resources.files
        Me.btnlog.Location = New System.Drawing.Point(552, 46)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(103, 65)
        Me.btnlog.TabIndex = 14
        Me.btnlog.UseVisualStyleBackColor = True
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
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(98, 177)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "logs"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(557, 248)
        Me.Chart1.TabIndex = 16
        Me.Chart1.Text = "Chart1"
        '
        'UCStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbllatereturns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblborrowed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltotalbooks)
        Me.Name = "UCStats"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotalbooks As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblborrowed As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbllatereturns As Label
    Friend WithEvents btnback As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnlog As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
