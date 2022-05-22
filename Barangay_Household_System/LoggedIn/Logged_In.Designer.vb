<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logged_In
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logged_In))
        Me.side_buttons = New System.Windows.Forms.Panel()
        Me.log_out_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.transaction_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.official_btn = New FontAwesome.Sharp.IconButton()
        Me.household_btn = New FontAwesome.Sharp.IconButton()
        Me.purok_btn = New FontAwesome.Sharp.IconButton()
        Me.resident_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.home_btn = New FontAwesome.Sharp.IconButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.side_buttons.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'side_buttons
        '
        Me.side_buttons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.side_buttons.BackColor = System.Drawing.Color.DarkBlue
        Me.side_buttons.Controls.Add(Me.log_out_btn)
        Me.side_buttons.Controls.Add(Me.Panel3)
        Me.side_buttons.Controls.Add(Me.transaction_btn)
        Me.side_buttons.Controls.Add(Me.Panel2)
        Me.side_buttons.Controls.Add(Me.official_btn)
        Me.side_buttons.Controls.Add(Me.household_btn)
        Me.side_buttons.Controls.Add(Me.purok_btn)
        Me.side_buttons.Controls.Add(Me.resident_btn)
        Me.side_buttons.Controls.Add(Me.Panel1)
        Me.side_buttons.Controls.Add(Me.home_btn)
        Me.side_buttons.Location = New System.Drawing.Point(0, 30)
        Me.side_buttons.Name = "side_buttons"
        Me.side_buttons.Size = New System.Drawing.Size(160, 704)
        Me.side_buttons.TabIndex = 3
        '
        'log_out_btn
        '
        Me.log_out_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.log_out_btn.FlatAppearance.BorderSize = 0
        Me.log_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_out_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.log_out_btn.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.log_out_btn.IconColor = System.Drawing.Color.White
        Me.log_out_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.log_out_btn.IconSize = 35
        Me.log_out_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.log_out_btn.Location = New System.Drawing.Point(0, 644)
        Me.log_out_btn.Name = "log_out_btn"
        Me.log_out_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.log_out_btn.Size = New System.Drawing.Size(160, 60)
        Me.log_out_btn.TabIndex = 10
        Me.log_out_btn.Text = "Log Out"
        Me.log_out_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.log_out_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.log_out_btn.UseVisualStyleBackColor = True
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
        'transaction_btn
        '
        Me.transaction_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.transaction_btn.FlatAppearance.BorderSize = 0
        Me.transaction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.transaction_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.transaction_btn.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.transaction_btn.IconColor = System.Drawing.Color.White
        Me.transaction_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.transaction_btn.IconSize = 35
        Me.transaction_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transaction_btn.Location = New System.Drawing.Point(0, 310)
        Me.transaction_btn.Name = "transaction_btn"
        Me.transaction_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.transaction_btn.Size = New System.Drawing.Size(160, 60)
        Me.transaction_btn.TabIndex = 8
        Me.transaction_btn.Text = "Barangay Transaction"
        Me.transaction_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transaction_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.transaction_btn.UseVisualStyleBackColor = True
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
        'official_btn
        '
        Me.official_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.official_btn.FlatAppearance.BorderSize = 0
        Me.official_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.official_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.official_btn.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.official_btn.IconColor = System.Drawing.Color.White
        Me.official_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.official_btn.IconSize = 35
        Me.official_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.official_btn.Location = New System.Drawing.Point(0, 245)
        Me.official_btn.Name = "official_btn"
        Me.official_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.official_btn.Size = New System.Drawing.Size(160, 60)
        Me.official_btn.TabIndex = 5
        Me.official_btn.Text = "Officials"
        Me.official_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.official_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.official_btn.UseVisualStyleBackColor = True
        '
        'household_btn
        '
        Me.household_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.household_btn.FlatAppearance.BorderSize = 0
        Me.household_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.household_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.household_btn.IconChar = FontAwesome.Sharp.IconChar.HouseUser
        Me.household_btn.IconColor = System.Drawing.Color.White
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
        'purok_btn
        '
        Me.purok_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.purok_btn.FlatAppearance.BorderSize = 0
        Me.purok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purok_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.purok_btn.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt
        Me.purok_btn.IconColor = System.Drawing.Color.White
        Me.purok_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.purok_btn.IconSize = 35
        Me.purok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.purok_btn.Location = New System.Drawing.Point(0, 125)
        Me.purok_btn.Name = "purok_btn"
        Me.purok_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.purok_btn.Size = New System.Drawing.Size(160, 60)
        Me.purok_btn.TabIndex = 3
        Me.purok_btn.Text = "Purok"
        Me.purok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.purok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.purok_btn.UseVisualStyleBackColor = True
        '
        'resident_btn
        '
        Me.resident_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.resident_btn.FlatAppearance.BorderSize = 0
        Me.resident_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resident_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.resident_btn.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.resident_btn.IconColor = System.Drawing.Color.White
        Me.resident_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.resident_btn.IconSize = 35
        Me.resident_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.resident_btn.Location = New System.Drawing.Point(0, 65)
        Me.resident_btn.Name = "resident_btn"
        Me.resident_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.resident_btn.Size = New System.Drawing.Size(160, 60)
        Me.resident_btn.TabIndex = 2
        Me.resident_btn.Text = "Resident"
        Me.resident_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.resident_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.resident_btn.UseVisualStyleBackColor = True
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
        'home_btn
        '
        Me.home_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.home_btn.FlatAppearance.BorderSize = 0
        Me.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.home_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.home_btn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.home_btn.IconColor = System.Drawing.Color.White
        Me.home_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.home_btn.IconSize = 35
        Me.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.home_btn.Location = New System.Drawing.Point(0, 0)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.home_btn.Size = New System.Drawing.Size(160, 60)
        Me.home_btn.TabIndex = 0
        Me.home_btn.Text = "Home"
        Me.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.home_btn.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.Location = New System.Drawing.Point(165, 32)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1061, 699)
        Me.PanelContainer.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Navy
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1232, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ManageUsersToolStripMenuItem.Text = "Manage Users"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Logged_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 733)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.side_buttons)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Logged_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay Household System"
        Me.side_buttons.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents side_buttons As Panel
    Friend WithEvents log_out_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents transaction_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents official_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents household_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents purok_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents resident_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents home_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
