<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaction_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaction_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.transaction_gridlist = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refresh_transaction = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.search_transaction = New System.Windows.Forms.TextBox()
        Me.delete_transaction = New FontAwesome.Sharp.IconButton()
        Me.print_transaction = New FontAwesome.Sharp.IconButton()
        Me.edit_transaction = New FontAwesome.Sharp.IconButton()
        Me.add_transaction = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.transaction_gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 48
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
        Me.Label1.Text = "Transaction Record"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'transaction_gridlist
        '
        Me.transaction_gridlist.AllowUserToAddRows = False
        Me.transaction_gridlist.AllowUserToDeleteRows = False
        Me.transaction_gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.transaction_gridlist.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.transaction_gridlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.transaction_gridlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.transaction_gridlist.Location = New System.Drawing.Point(32, 159)
        Me.transaction_gridlist.Name = "transaction_gridlist"
        Me.transaction_gridlist.ReadOnly = True
        Me.transaction_gridlist.RowHeadersVisible = False
        Me.transaction_gridlist.RowHeadersWidth = 51
        Me.transaction_gridlist.Size = New System.Drawing.Size(1006, 530)
        Me.transaction_gridlist.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "transaction_number"
        Me.Column1.HeaderText = "Transaction Code"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "transaction_date"
        Me.Column2.HeaderText = "Transaction Date"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "purpose_of_use"
        Me.Column3.HeaderText = "Purpose"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "cost"
        Me.Column4.HeaderText = "Cost"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "res_id"
        Me.Column5.HeaderText = "Resident ID"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'refresh_transaction
        '
        Me.refresh_transaction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh_transaction.Location = New System.Drawing.Point(953, 123)
        Me.refresh_transaction.Name = "refresh_transaction"
        Me.refresh_transaction.Size = New System.Drawing.Size(100, 30)
        Me.refresh_transaction.TabIndex = 55
        Me.refresh_transaction.Text = "Refresh"
        Me.refresh_transaction.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Search"
        '
        'search_transaction
        '
        Me.search_transaction.Location = New System.Drawing.Point(87, 126)
        Me.search_transaction.Name = "search_transaction"
        Me.search_transaction.Size = New System.Drawing.Size(860, 27)
        Me.search_transaction.TabIndex = 53
        '
        'delete_transaction
        '
        Me.delete_transaction.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.delete_transaction.IconColor = System.Drawing.Color.Black
        Me.delete_transaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_transaction.IconSize = 20
        Me.delete_transaction.Location = New System.Drawing.Point(833, 79)
        Me.delete_transaction.Name = "delete_transaction"
        Me.delete_transaction.Size = New System.Drawing.Size(136, 41)
        Me.delete_transaction.TabIndex = 52
        Me.delete_transaction.Text = "Delete Record"
        Me.delete_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.delete_transaction.UseVisualStyleBackColor = True
        '
        'print_transaction
        '
        Me.print_transaction.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.print_transaction.IconColor = System.Drawing.Color.Black
        Me.print_transaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.print_transaction.IconSize = 20
        Me.print_transaction.Location = New System.Drawing.Point(975, 79)
        Me.print_transaction.Name = "print_transaction"
        Me.print_transaction.Size = New System.Drawing.Size(78, 41)
        Me.print_transaction.TabIndex = 51
        Me.print_transaction.Text = "Print"
        Me.print_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.print_transaction.UseVisualStyleBackColor = True
        '
        'edit_transaction
        '
        Me.edit_transaction.IconChar = FontAwesome.Sharp.IconChar.CommentSlash
        Me.edit_transaction.IconColor = System.Drawing.Color.Black
        Me.edit_transaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_transaction.IconSize = 20
        Me.edit_transaction.Location = New System.Drawing.Point(707, 79)
        Me.edit_transaction.Name = "edit_transaction"
        Me.edit_transaction.Size = New System.Drawing.Size(120, 41)
        Me.edit_transaction.TabIndex = 50
        Me.edit_transaction.Text = "Edit Record"
        Me.edit_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.edit_transaction.UseVisualStyleBackColor = True
        '
        'add_transaction
        '
        Me.add_transaction.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.add_transaction.IconColor = System.Drawing.Color.Black
        Me.add_transaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_transaction.IconSize = 20
        Me.add_transaction.Location = New System.Drawing.Point(581, 79)
        Me.add_transaction.Name = "add_transaction"
        Me.add_transaction.Size = New System.Drawing.Size(120, 41)
        Me.add_transaction.TabIndex = 49
        Me.add_transaction.Text = "New Record"
        Me.add_transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_transaction.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 100000
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'transaction_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 698)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.transaction_gridlist)
        Me.Controls.Add(Me.refresh_transaction)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_transaction)
        Me.Controls.Add(Me.delete_transaction)
        Me.Controls.Add(Me.print_transaction)
        Me.Controls.Add(Me.edit_transaction)
        Me.Controls.Add(Me.add_transaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transaction_form"
        Me.Text = "permit_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.transaction_gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents transaction_gridlist As DataGridView
    Friend WithEvents refresh_transaction As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents search_transaction As TextBox
    Friend WithEvents delete_transaction As FontAwesome.Sharp.IconButton
    Friend WithEvents print_transaction As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_transaction As FontAwesome.Sharp.IconButton
    Friend WithEvents add_transaction As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
