<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.side_buttons = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.log_in_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.d_permit_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.d_official_btn = New FontAwesome.Sharp.IconButton()
        Me.household_btn = New FontAwesome.Sharp.IconButton()
        Me.d_purok_btn = New FontAwesome.Sharp.IconButton()
        Me.d_resident_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.d_home_btn = New FontAwesome.Sharp.IconButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.side_buttons.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'side_buttons
        '
        Me.side_buttons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.side_buttons.BackColor = System.Drawing.Color.DarkBlue
        Me.side_buttons.Controls.Add(Me.Label1)
        Me.side_buttons.Controls.Add(Me.log_in_btn)
        Me.side_buttons.Controls.Add(Me.Panel3)
        Me.side_buttons.Controls.Add(Me.d_permit_btn)
        Me.side_buttons.Controls.Add(Me.Panel2)
        Me.side_buttons.Controls.Add(Me.d_official_btn)
        Me.side_buttons.Controls.Add(Me.household_btn)
        Me.side_buttons.Controls.Add(Me.d_purok_btn)
        Me.side_buttons.Controls.Add(Me.d_resident_btn)
        Me.side_buttons.Controls.Add(Me.Panel1)
        Me.side_buttons.Controls.Add(Me.d_home_btn)
        Me.side_buttons.Location = New System.Drawing.Point(0, 30)
        Me.side_buttons.Name = "side_buttons"
        Me.side_buttons.Size = New System.Drawing.Size(160, 704)
        Me.side_buttons.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 624)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(28, 0, 0, 0)
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Hello Guest!!!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'log_in_btn
        '
        Me.log_in_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.log_in_btn.FlatAppearance.BorderSize = 0
        Me.log_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_in_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.log_in_btn.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.log_in_btn.IconColor = System.Drawing.Color.White
        Me.log_in_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.log_in_btn.IconSize = 35
        Me.log_in_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.log_in_btn.Location = New System.Drawing.Point(0, 644)
        Me.log_in_btn.Name = "log_in_btn"
        Me.log_in_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.log_in_btn.Size = New System.Drawing.Size(160, 60)
        Me.log_in_btn.TabIndex = 11
        Me.log_in_btn.Text = "Log In"
        Me.log_in_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.log_in_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.log_in_btn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 370)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 5)
        Me.Panel3.TabIndex = 9
        '
        'd_permit_btn
        '
        Me.d_permit_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.d_permit_btn.Enabled = False
        Me.d_permit_btn.FlatAppearance.BorderSize = 0
        Me.d_permit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_permit_btn.ForeColor = System.Drawing.Color.LightGray
        Me.d_permit_btn.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.d_permit_btn.IconColor = System.Drawing.Color.LightGray
        Me.d_permit_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.d_permit_btn.IconSize = 35
        Me.d_permit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_permit_btn.Location = New System.Drawing.Point(0, 310)
        Me.d_permit_btn.Name = "d_permit_btn"
        Me.d_permit_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.d_permit_btn.Size = New System.Drawing.Size(160, 60)
        Me.d_permit_btn.TabIndex = 8
        Me.d_permit_btn.Text = "Barangay Transaction"
        Me.d_permit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_permit_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.d_permit_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 305)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 5)
        Me.Panel2.TabIndex = 6
        '
        'd_official_btn
        '
        Me.d_official_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.d_official_btn.Enabled = False
        Me.d_official_btn.FlatAppearance.BorderSize = 0
        Me.d_official_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_official_btn.ForeColor = System.Drawing.Color.LightGray
        Me.d_official_btn.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.d_official_btn.IconColor = System.Drawing.Color.LightGray
        Me.d_official_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.d_official_btn.IconSize = 35
        Me.d_official_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_official_btn.Location = New System.Drawing.Point(0, 245)
        Me.d_official_btn.Name = "d_official_btn"
        Me.d_official_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.d_official_btn.Size = New System.Drawing.Size(160, 60)
        Me.d_official_btn.TabIndex = 5
        Me.d_official_btn.Text = "Officials"
        Me.d_official_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_official_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.d_official_btn.UseVisualStyleBackColor = True
        '
        'household_btn
        '
        Me.household_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.household_btn.Enabled = False
        Me.household_btn.FlatAppearance.BorderSize = 0
        Me.household_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.household_btn.ForeColor = System.Drawing.Color.LightGray
        Me.household_btn.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.household_btn.IconColor = System.Drawing.Color.LightGray
        Me.household_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.household_btn.IconSize = 35
        Me.household_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.household_btn.Location = New System.Drawing.Point(0, 185)
        Me.household_btn.Name = "household_btn"
        Me.household_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.household_btn.Size = New System.Drawing.Size(160, 60)
        Me.household_btn.TabIndex = 4
        Me.household_btn.Text = "Household"
        Me.household_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.household_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.household_btn.UseVisualStyleBackColor = True
        '
        'd_purok_btn
        '
        Me.d_purok_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.d_purok_btn.Enabled = False
        Me.d_purok_btn.FlatAppearance.BorderSize = 0
        Me.d_purok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_purok_btn.ForeColor = System.Drawing.Color.LightGray
        Me.d_purok_btn.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt
        Me.d_purok_btn.IconColor = System.Drawing.Color.LightGray
        Me.d_purok_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.d_purok_btn.IconSize = 35
        Me.d_purok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_purok_btn.Location = New System.Drawing.Point(0, 125)
        Me.d_purok_btn.Name = "d_purok_btn"
        Me.d_purok_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.d_purok_btn.Size = New System.Drawing.Size(160, 60)
        Me.d_purok_btn.TabIndex = 3
        Me.d_purok_btn.Text = "Purok"
        Me.d_purok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_purok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.d_purok_btn.UseVisualStyleBackColor = True
        '
        'd_resident_btn
        '
        Me.d_resident_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.d_resident_btn.Enabled = False
        Me.d_resident_btn.FlatAppearance.BorderSize = 0
        Me.d_resident_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_resident_btn.ForeColor = System.Drawing.Color.LightGray
        Me.d_resident_btn.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.d_resident_btn.IconColor = System.Drawing.Color.LightGray
        Me.d_resident_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.d_resident_btn.IconSize = 35
        Me.d_resident_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_resident_btn.Location = New System.Drawing.Point(0, 65)
        Me.d_resident_btn.Name = "d_resident_btn"
        Me.d_resident_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.d_resident_btn.Size = New System.Drawing.Size(160, 60)
        Me.d_resident_btn.TabIndex = 2
        Me.d_resident_btn.Text = "Resident"
        Me.d_resident_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_resident_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.d_resident_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 5)
        Me.Panel1.TabIndex = 1
        '
        'd_home_btn
        '
        Me.d_home_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.d_home_btn.Enabled = False
        Me.d_home_btn.FlatAppearance.BorderSize = 0
        Me.d_home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d_home_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.d_home_btn.ForeColor = System.Drawing.Color.LightGray
        Me.d_home_btn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.d_home_btn.IconColor = System.Drawing.Color.LightGray
        Me.d_home_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.d_home_btn.IconSize = 35
        Me.d_home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_home_btn.Location = New System.Drawing.Point(0, 0)
        Me.d_home_btn.Name = "d_home_btn"
        Me.d_home_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.d_home_btn.Size = New System.Drawing.Size(160, 60)
        Me.d_home_btn.TabIndex = 0
        Me.d_home_btn.Text = "Home"
        Me.d_home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.d_home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.d_home_btn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Navy
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1232, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.CloseProgramToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'CloseProgramToolStripMenuItem
        '
        Me.CloseProgramToolStripMenuItem.Name = "CloseProgramToolStripMenuItem"
        Me.CloseProgramToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CloseProgramToolStripMenuItem.Text = "Close Program"
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.BackgroundImage = CType(resources.GetObject("PanelContainer.BackgroundImage"), System.Drawing.Image)
        Me.PanelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelContainer.Location = New System.Drawing.Point(166, 40)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1061, 681)
        Me.PanelContainer.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1232, 733)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.side_buttons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Household System"
        Me.side_buttons.ResumeLayout(False)
        Me.side_buttons.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents side_buttons As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents d_permit_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents d_official_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents household_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents d_purok_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents d_resident_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents d_home_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents log_in_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContainer As Panel
End Class
