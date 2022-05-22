<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.delete_resident = New FontAwesome.Sharp.IconButton()
        Me.edit_resident = New FontAwesome.Sharp.IconButton()
        Me.add_resident = New FontAwesome.Sharp.IconButton()
        Me.user_gridlist = New System.Windows.Forms.DataGridView()
        Me.refresh_resident = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.search_user = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.user_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 59)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(347, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'delete_resident
        '
        Me.delete_resident.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_resident.IconColor = System.Drawing.Color.Black
        Me.delete_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_resident.IconSize = 20
        Me.delete_resident.Location = New System.Drawing.Point(898, 82)
        Me.delete_resident.Name = "delete_resident"
        Me.delete_resident.Size = New System.Drawing.Size(136, 41)
        Me.delete_resident.TabIndex = 19
        Me.delete_resident.Text = "Delete Record"
        Me.delete_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_resident.UseVisualStyleBackColor = True
        '
        'edit_resident
        '
        Me.edit_resident.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_resident.IconColor = System.Drawing.Color.Black
        Me.edit_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_resident.IconSize = 20
        Me.edit_resident.Location = New System.Drawing.Point(772, 85)
        Me.edit_resident.Name = "edit_resident"
        Me.edit_resident.Size = New System.Drawing.Size(120, 41)
        Me.edit_resident.TabIndex = 18
        Me.edit_resident.Text = "Edit Record"
        Me.edit_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_resident.UseVisualStyleBackColor = True
        '
        'add_resident
        '
        Me.add_resident.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_resident.IconColor = System.Drawing.Color.Black
        Me.add_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_resident.IconSize = 20
        Me.add_resident.Location = New System.Drawing.Point(646, 85)
        Me.add_resident.Name = "add_resident"
        Me.add_resident.Size = New System.Drawing.Size(120, 41)
        Me.add_resident.TabIndex = 17
        Me.add_resident.Text = "New Record"
        Me.add_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_resident.UseVisualStyleBackColor = True
        '
        'user_gridlist
        '
        Me.user_gridlist.AllowUserToAddRows = False
        Me.user_gridlist.AllowUserToDeleteRows = False
        Me.user_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.user_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.user_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.user_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.user_gridlist.Location = New System.Drawing.Point(12, 170)
        Me.user_gridlist.Name = "user_gridlist"
        Me.user_gridlist.ReadOnly = True
        Me.user_gridlist.RowHeadersWidth = 51
        Me.user_gridlist.Size = New System.Drawing.Size(1022, 469)
        Me.user_gridlist.TabIndex = 24
        '
        'refresh_resident
        '
        Me.refresh_resident.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_resident.Location = New System.Drawing.Point(934, 134)
        Me.refresh_resident.Name = "refresh_resident"
        Me.refresh_resident.Size = New System.Drawing.Size(100, 30)
        Me.refresh_resident.TabIndex = 23
        Me.refresh_resident.Text = "Refresh"
        Me.refresh_resident.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Search"
        '
        'search_user
        '
        Me.search_user.Location = New System.Drawing.Point(87, 137)
        Me.search_user.Name = "search_user"
        Me.search_user.Size = New System.Drawing.Size(841, 27)
        Me.search_user.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "username"
        Me.Column1.HeaderText = "Username"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "password"
        Me.Column2.HeaderText = "Password"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 651)
        Me.Controls.Add(Me.user_gridlist)
        Me.Controls.Add(Me.refresh_resident)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_user)
        Me.Controls.Add(Me.delete_resident)
        Me.Controls.Add(Me.edit_resident)
        Me.Controls.Add(Me.add_resident)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "user_form"
        Me.Text = "Manage Users"
        Me.Panel1.ResumeLayout(False)
        CType(Me.user_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents delete_resident As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_resident As FontAwesome.Sharp.IconButton
    Friend WithEvents add_resident As FontAwesome.Sharp.IconButton
    Friend WithEvents user_gridlist As DataGridView
    Friend WithEvents refresh_resident As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents search_user As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
