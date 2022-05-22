<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class household_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.household_gridlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refresh_household = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.search_household = New System.Windows.Forms.TextBox()
        Me.delete_household = New FontAwesome.Sharp.IconButton()
        Me.edit_household = New FontAwesome.Sharp.IconButton()
        Me.add_household = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.household_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1082, 59)
        Me.Panel1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(510, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Household List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'household_gridlist
        '
        Me.household_gridlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.household_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.household_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.household_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.household_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.household_gridlist.Location = New System.Drawing.Point(12, 159)
        Me.household_gridlist.Name = "household_gridlist"
        Me.household_gridlist.RowHeadersWidth = 51
        Me.household_gridlist.Size = New System.Drawing.Size(1041, 530)
        Me.household_gridlist.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "household_number"
        Me.Column1.HeaderText = "House Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "household_family"
        Me.Column2.HeaderText = "Family"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "purok_number"
        Me.Column3.HeaderText = "Purok Number"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'refresh_household
        '
        Me.refresh_household.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_household.Location = New System.Drawing.Point(953, 123)
        Me.refresh_household.Name = "refresh_household"
        Me.refresh_household.Size = New System.Drawing.Size(100, 30)
        Me.refresh_household.TabIndex = 37
        Me.refresh_household.Text = "Refresh"
        Me.refresh_household.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Search"
        '
        'search_household
        '
        Me.search_household.Location = New System.Drawing.Point(87, 126)
        Me.search_household.Name = "search_household"
        Me.search_household.Size = New System.Drawing.Size(860, 27)
        Me.search_household.TabIndex = 35
        '
        'delete_household
        '
        Me.delete_household.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_household.IconColor = System.Drawing.Color.Black
        Me.delete_household.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_household.IconSize = 20
        Me.delete_household.Location = New System.Drawing.Point(916, 76)
        Me.delete_household.Name = "delete_household"
        Me.delete_household.Size = New System.Drawing.Size(136, 41)
        Me.delete_household.TabIndex = 34
        Me.delete_household.Text = "Delete Record"
        Me.delete_household.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_household.UseVisualStyleBackColor = True
        '
        'edit_household
        '
        Me.edit_household.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_household.IconColor = System.Drawing.Color.Black
        Me.edit_household.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_household.IconSize = 20
        Me.edit_household.Location = New System.Drawing.Point(790, 76)
        Me.edit_household.Name = "edit_household"
        Me.edit_household.Size = New System.Drawing.Size(120, 41)
        Me.edit_household.TabIndex = 32
        Me.edit_household.Text = "Edit Record"
        Me.edit_household.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_household.UseVisualStyleBackColor = True
        '
        'add_household
        '
        Me.add_household.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_household.IconColor = System.Drawing.Color.Black
        Me.add_household.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_household.IconSize = 20
        Me.add_household.Location = New System.Drawing.Point(664, 76)
        Me.add_household.Name = "add_household"
        Me.add_household.Size = New System.Drawing.Size(120, 41)
        Me.add_household.TabIndex = 31
        Me.add_household.Text = "New Record"
        Me.add_household.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_household.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'household_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 698)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.household_gridlist)
        Me.Controls.Add(Me.refresh_household)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_household)
        Me.Controls.Add(Me.delete_household)
        Me.Controls.Add(Me.edit_household)
        Me.Controls.Add(Me.add_household)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "household_form"
        Me.Text = "household_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.household_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents household_gridlist As DataGridView
    Friend WithEvents refresh_household As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents search_household As TextBox
    Friend WithEvents delete_household As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_household As FontAwesome.Sharp.IconButton
    Friend WithEvents add_household As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
