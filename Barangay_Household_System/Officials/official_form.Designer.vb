<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class official_form
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
        Me.official_gridlist = New System.Windows.Forms.DataGridView()
        Me.refresh_official = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.search_official = New System.Windows.Forms.TextBox()
        Me.delete_official = New FontAwesome.Sharp.IconButton()
        Me.edit_official = New FontAwesome.Sharp.IconButton()
        Me.add_official = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.official_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 59)
        Me.Panel1.TabIndex = 21
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
        Me.Label1.Text = "Barangay Official Informations"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'official_gridlist
        '
        Me.official_gridlist.AllowUserToAddRows = False
        Me.official_gridlist.AllowUserToDeleteRows = False
        Me.official_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.official_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.official_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.official_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.official_gridlist.Location = New System.Drawing.Point(11, 159)
        Me.official_gridlist.Name = "official_gridlist"
        Me.official_gridlist.ReadOnly = True
        Me.official_gridlist.RowHeadersWidth = 51
        Me.official_gridlist.Size = New System.Drawing.Size(1041, 530)
        Me.official_gridlist.TabIndex = 29
        '
        'refresh_official
        '
        Me.refresh_official.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_official.Location = New System.Drawing.Point(952, 123)
        Me.refresh_official.Name = "refresh_official"
        Me.refresh_official.Size = New System.Drawing.Size(100, 30)
        Me.refresh_official.TabIndex = 28
        Me.refresh_official.Text = "Refresh"
        Me.refresh_official.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Search"
        '
        'search_official
        '
        Me.search_official.Location = New System.Drawing.Point(86, 126)
        Me.search_official.Name = "search_official"
        Me.search_official.Size = New System.Drawing.Size(860, 27)
        Me.search_official.TabIndex = 26
        '
        'delete_official
        '
        Me.delete_official.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_official.IconColor = System.Drawing.Color.Black
        Me.delete_official.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_official.IconSize = 20
        Me.delete_official.Location = New System.Drawing.Point(916, 76)
        Me.delete_official.Name = "delete_official"
        Me.delete_official.Size = New System.Drawing.Size(136, 41)
        Me.delete_official.TabIndex = 25
        Me.delete_official.Text = "Delete Record"
        Me.delete_official.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_official.UseVisualStyleBackColor = True
        '
        'edit_official
        '
        Me.edit_official.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_official.IconColor = System.Drawing.Color.Black
        Me.edit_official.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_official.IconSize = 20
        Me.edit_official.Location = New System.Drawing.Point(790, 76)
        Me.edit_official.Name = "edit_official"
        Me.edit_official.Size = New System.Drawing.Size(120, 41)
        Me.edit_official.TabIndex = 23
        Me.edit_official.Text = "Edit Record"
        Me.edit_official.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_official.UseVisualStyleBackColor = True
        '
        'add_official
        '
        Me.add_official.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_official.IconColor = System.Drawing.Color.Black
        Me.add_official.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_official.IconSize = 20
        Me.add_official.Location = New System.Drawing.Point(664, 76)
        Me.add_official.Name = "add_official"
        Me.add_official.Size = New System.Drawing.Size(120, 41)
        Me.add_official.TabIndex = 22
        Me.add_official.Text = "New Record"
        Me.add_official.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_official.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "official_id"
        Me.Column1.HeaderText = "Barangay Official ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 143
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "official_full_name"
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "official_contact"
        Me.Column3.HeaderText = "Contact"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 89
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "official_gender"
        Me.Column4.HeaderText = "Gender"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 86
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "official_age"
        Me.Column5.HeaderText = "Age"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 65
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "official_position"
        Me.Column6.HeaderText = "Position"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "term_start"
        Me.Column7.HeaderText = "Term Start"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 98
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "term_end"
        Me.Column8.HeaderText = "Term End"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 92
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "household_number"
        Me.Column9.HeaderText = "Household"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 110
        '
        'official_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 698)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.official_gridlist)
        Me.Controls.Add(Me.refresh_official)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_official)
        Me.Controls.Add(Me.delete_official)
        Me.Controls.Add(Me.edit_official)
        Me.Controls.Add(Me.add_official)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "official_form"
        Me.Text = "official_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.official_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents official_gridlist As DataGridView
    Friend WithEvents refresh_official As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents search_official As TextBox
    Friend WithEvents delete_official As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_official As FontAwesome.Sharp.IconButton
    Friend WithEvents add_official As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
