<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resident_form
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
        Me.resident_gridlist = New System.Windows.Forms.DataGridView()
        Me.search_resident = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.refresh_resident = New System.Windows.Forms.Button()
        Me.add_resident = New FontAwesome.Sharp.IconButton()
        Me.edit_resident = New FontAwesome.Sharp.IconButton()
        Me.delete_resident = New FontAwesome.Sharp.IconButton()
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
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.resident_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1064, 59)
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Text = "Resident Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resident_gridlist
        '
        Me.resident_gridlist.AllowUserToAddRows = False
        Me.resident_gridlist.AllowUserToDeleteRows = False
        Me.resident_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.resident_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.resident_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resident_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.resident_gridlist.Location = New System.Drawing.Point(12, 156)
        Me.resident_gridlist.Name = "resident_gridlist"
        Me.resident_gridlist.ReadOnly = True
        Me.resident_gridlist.RowHeadersWidth = 51
        Me.resident_gridlist.Size = New System.Drawing.Size(1041, 530)
        Me.resident_gridlist.TabIndex = 1
        '
        'search_resident
        '
        Me.search_resident.Location = New System.Drawing.Point(87, 123)
        Me.search_resident.Name = "search_resident"
        Me.search_resident.Size = New System.Drawing.Size(860, 27)
        Me.search_resident.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search"
        '
        'refresh_resident
        '
        Me.refresh_resident.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_resident.Location = New System.Drawing.Point(953, 120)
        Me.refresh_resident.Name = "refresh_resident"
        Me.refresh_resident.Size = New System.Drawing.Size(100, 30)
        Me.refresh_resident.TabIndex = 6
        Me.refresh_resident.Text = "Refresh"
        Me.refresh_resident.UseVisualStyleBackColor = True
        '
        'add_resident
        '
        Me.add_resident.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_resident.IconColor = System.Drawing.Color.Black
        Me.add_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_resident.IconSize = 20
        Me.add_resident.Location = New System.Drawing.Point(664, 73)
        Me.add_resident.Name = "add_resident"
        Me.add_resident.Size = New System.Drawing.Size(120, 41)
        Me.add_resident.TabIndex = 9
        Me.add_resident.Text = "New Record"
        Me.add_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_resident.UseVisualStyleBackColor = True
        '
        'edit_resident
        '
        Me.edit_resident.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_resident.IconColor = System.Drawing.Color.Black
        Me.edit_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_resident.IconSize = 20
        Me.edit_resident.Location = New System.Drawing.Point(790, 73)
        Me.edit_resident.Name = "edit_resident"
        Me.edit_resident.Size = New System.Drawing.Size(120, 41)
        Me.edit_resident.TabIndex = 10
        Me.edit_resident.Text = "Edit Record"
        Me.edit_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_resident.UseVisualStyleBackColor = True
        '
        'delete_resident
        '
        Me.delete_resident.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_resident.IconColor = System.Drawing.Color.Black
        Me.delete_resident.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_resident.IconSize = 20
        Me.delete_resident.Location = New System.Drawing.Point(916, 73)
        Me.delete_resident.Name = "delete_resident"
        Me.delete_resident.Size = New System.Drawing.Size(136, 41)
        Me.delete_resident.TabIndex = 12
        Me.delete_resident.Text = "Delete Record"
        Me.delete_resident.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_resident.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "res_id"
        Me.Column1.HeaderText = "Resident ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "res_full_name"
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "res_age"
        Me.Column3.HeaderText = "Age"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 65
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "res_gender"
        Me.Column4.HeaderText = "Gender"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 86
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "res_birth_date"
        Me.Column5.HeaderText = "Birthdate"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 99
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "res_birth_place"
        Me.Column6.HeaderText = "Birth place"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 101
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "res_citizenship"
        Me.Column7.HeaderText = "Citizenship"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "res_marital_status"
        Me.Column8.HeaderText = "Marital Status"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 119
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "res_religion"
        Me.Column9.HeaderText = "Religion"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 93
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "job"
        Me.Column10.HeaderText = "Job"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 61
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "household_number"
        Me.Column11.HeaderText = "Household Number"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 154
        '
        'resident_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 698)
        Me.Controls.Add(Me.delete_resident)
        Me.Controls.Add(Me.edit_resident)
        Me.Controls.Add(Me.add_resident)
        Me.Controls.Add(Me.refresh_resident)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_resident)
        Me.Controls.Add(Me.resident_gridlist)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resident_form"
        Me.Text = "resident_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.resident_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents resident_gridlist As DataGridView
    Friend WithEvents search_resident As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents refresh_resident As Button
    Friend WithEvents add_resident As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_resident As FontAwesome.Sharp.IconButton
    Friend WithEvents delete_resident As FontAwesome.Sharp.IconButton
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
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
