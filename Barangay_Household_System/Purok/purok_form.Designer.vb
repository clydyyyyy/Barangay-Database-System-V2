<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purok_form
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
        Me.delete_purok = New FontAwesome.Sharp.IconButton()
        Me.edit_purok = New FontAwesome.Sharp.IconButton()
        Me.add_purok = New FontAwesome.Sharp.IconButton()
        Me.refresh_purok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.search_purok = New System.Windows.Forms.TextBox()
        Me.purok_gridlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.purok_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        Me.Label1.Text = "List of Purok"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'delete_purok
        '
        Me.delete_purok.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_purok.IconColor = System.Drawing.Color.Black
        Me.delete_purok.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_purok.IconSize = 20
        Me.delete_purok.Location = New System.Drawing.Point(916, 75)
        Me.delete_purok.Name = "delete_purok"
        Me.delete_purok.Size = New System.Drawing.Size(136, 41)
        Me.delete_purok.TabIndex = 16
        Me.delete_purok.Text = "Delete Record"
        Me.delete_purok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_purok.UseVisualStyleBackColor = True
        '
        'edit_purok
        '
        Me.edit_purok.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_purok.IconColor = System.Drawing.Color.Black
        Me.edit_purok.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_purok.IconSize = 20
        Me.edit_purok.Location = New System.Drawing.Point(790, 78)
        Me.edit_purok.Name = "edit_purok"
        Me.edit_purok.Size = New System.Drawing.Size(120, 41)
        Me.edit_purok.TabIndex = 14
        Me.edit_purok.Text = "Edit Record"
        Me.edit_purok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_purok.UseVisualStyleBackColor = True
        '
        'add_purok
        '
        Me.add_purok.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_purok.IconColor = System.Drawing.Color.Black
        Me.add_purok.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_purok.IconSize = 20
        Me.add_purok.Location = New System.Drawing.Point(664, 78)
        Me.add_purok.Name = "add_purok"
        Me.add_purok.Size = New System.Drawing.Size(120, 41)
        Me.add_purok.TabIndex = 13
        Me.add_purok.Text = "New Record"
        Me.add_purok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_purok.UseVisualStyleBackColor = True
        '
        'refresh_purok
        '
        Me.refresh_purok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_purok.Location = New System.Drawing.Point(952, 122)
        Me.refresh_purok.Name = "refresh_purok"
        Me.refresh_purok.Size = New System.Drawing.Size(100, 30)
        Me.refresh_purok.TabIndex = 19
        Me.refresh_purok.Text = "Refresh"
        Me.refresh_purok.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Search"
        '
        'search_purok
        '
        Me.search_purok.Location = New System.Drawing.Point(86, 125)
        Me.search_purok.Name = "search_purok"
        Me.search_purok.Size = New System.Drawing.Size(860, 27)
        Me.search_purok.TabIndex = 17
        '
        'purok_gridlist
        '
        Me.purok_gridlist.AllowUserToAddRows = False
        Me.purok_gridlist.AllowUserToDeleteRows = False
        Me.purok_gridlist.AllowUserToResizeColumns = False
        Me.purok_gridlist.AllowUserToResizeRows = False
        Me.purok_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.purok_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.purok_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purok_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.purok_gridlist.Location = New System.Drawing.Point(11, 158)
        Me.purok_gridlist.Name = "purok_gridlist"
        Me.purok_gridlist.RowHeadersWidth = 51
        Me.purok_gridlist.Size = New System.Drawing.Size(1041, 530)
        Me.purok_gridlist.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "purok_number"
        Me.Column1.HeaderText = "Purok Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "street_name"
        Me.Column2.HeaderText = "Street Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'purok_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 698)
        Me.Controls.Add(Me.purok_gridlist)
        Me.Controls.Add(Me.refresh_purok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_purok)
        Me.Controls.Add(Me.delete_purok)
        Me.Controls.Add(Me.edit_purok)
        Me.Controls.Add(Me.add_purok)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "purok_form"
        Me.Text = "purok_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.purok_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents delete_purok As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_purok As FontAwesome.Sharp.IconButton
    Friend WithEvents add_purok As FontAwesome.Sharp.IconButton
    Friend WithEvents refresh_purok As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents search_purok As TextBox
    Friend WithEvents purok_gridlist As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
