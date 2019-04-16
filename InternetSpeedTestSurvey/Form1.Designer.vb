<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInter))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstInternetSpeeds = New System.Windows.Forms.ListBox()
        Me.btnEnterInternetSpeed = New System.Windows.Forms.Button()
        Me.lblAverageInternetSpeed = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(12, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(329, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'lstInternetSpeeds
        '
        Me.lstInternetSpeeds.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInternetSpeeds.FormattingEnabled = True
        Me.lstInternetSpeeds.ItemHeight = 24
        Me.lstInternetSpeeds.Location = New System.Drawing.Point(37, 147)
        Me.lstInternetSpeeds.Name = "lstInternetSpeeds"
        Me.lstInternetSpeeds.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInternetSpeeds.ScrollAlwaysVisible = True
        Me.lstInternetSpeeds.Size = New System.Drawing.Size(98, 148)
        Me.lstInternetSpeeds.TabIndex = 1
        '
        'btnEnterInternetSpeed
        '
        Me.btnEnterInternetSpeed.BackColor = System.Drawing.Color.Olive
        Me.btnEnterInternetSpeed.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterInternetSpeed.Location = New System.Drawing.Point(18, 88)
        Me.btnEnterInternetSpeed.Name = "btnEnterInternetSpeed"
        Me.btnEnterInternetSpeed.Size = New System.Drawing.Size(289, 37)
        Me.btnEnterInternetSpeed.TabIndex = 2
        Me.btnEnterInternetSpeed.Text = "Enter Internet Speed"
        Me.btnEnterInternetSpeed.UseVisualStyleBackColor = False
        '
        'lblAverageInternetSpeed
        '
        Me.lblAverageInternetSpeed.AutoSize = True
        Me.lblAverageInternetSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblAverageInternetSpeed.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInternetSpeed.Location = New System.Drawing.Point(14, 477)
        Me.lblAverageInternetSpeed.Name = "lblAverageInternetSpeed"
        Me.lblAverageInternetSpeed.Size = New System.Drawing.Size(329, 24)
        Me.lblAverageInternetSpeed.TabIndex = 3
        Me.lblAverageInternetSpeed.Text = "Average Internet Speed: XX.XX Mbps"
        Me.lblAverageInternetSpeed.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'frmInter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblAverageInternetSpeed)
        Me.Controls.Add(Me.btnEnterInternetSpeed)
        Me.Controls.Add(Me.lstInternetSpeeds)
        Me.Controls.Add(Me.lblHeading)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInter"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lstInternetSpeeds As ListBox
    Friend WithEvents btnEnterInternetSpeed As Button
    Friend WithEvents lblAverageInternetSpeed As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
