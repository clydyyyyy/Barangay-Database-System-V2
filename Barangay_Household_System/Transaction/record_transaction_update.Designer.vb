<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_transaction_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_transaction_update))
        Me.transaction_update = New System.Windows.Forms.Button()
        Me.resident_id = New System.Windows.Forms.TextBox()
        Me.transaction_date = New System.Windows.Forms.DateTimePicker()
        Me.transaction_cost = New System.Windows.Forms.TextBox()
        Me.transaction_purpose = New System.Windows.Forms.TextBox()
        Me.transaction_number = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'transaction_update
        '
        Me.transaction_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.transaction_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.transaction_update.Location = New System.Drawing.Point(772, 249)
        Me.transaction_update.Name = "transaction_update"
        Me.transaction_update.Size = New System.Drawing.Size(182, 38)
        Me.transaction_update.TabIndex = 64
        Me.transaction_update.Text = "Update"
        Me.transaction_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transaction_update.UseVisualStyleBackColor = False
        '
        'resident_id
        '
        Me.resident_id.Enabled = False
        Me.resident_id.Location = New System.Drawing.Point(393, 38)
        Me.resident_id.Name = "resident_id"
        Me.resident_id.Size = New System.Drawing.Size(149, 27)
        Me.resident_id.TabIndex = 63
        '
        'transaction_date
        '
        Me.transaction_date.Location = New System.Drawing.Point(444, 189)
        Me.transaction_date.Name = "transaction_date"
        Me.transaction_date.Size = New System.Drawing.Size(476, 27)
        Me.transaction_date.TabIndex = 62
        '
        'transaction_cost
        '
        Me.transaction_cost.Location = New System.Drawing.Point(363, 132)
        Me.transaction_cost.Name = "transaction_cost"
        Me.transaction_cost.Size = New System.Drawing.Size(226, 27)
        Me.transaction_cost.TabIndex = 61
        '
        'transaction_purpose
        '
        Me.transaction_purpose.Location = New System.Drawing.Point(429, 87)
        Me.transaction_purpose.Name = "transaction_purpose"
        Me.transaction_purpose.Size = New System.Drawing.Size(491, 27)
        Me.transaction_purpose.TabIndex = 60
        '
        'transaction_number
        '
        Me.transaction_number.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.transaction_number.Enabled = False
        Me.transaction_number.Location = New System.Drawing.Point(763, 41)
        Me.transaction_number.Name = "transaction_number"
        Me.transaction_number.Size = New System.Drawing.Size(157, 27)
        Me.transaction_number.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(286, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Transaction Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(588, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Transaction Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(286, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(286, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Purpose of Use:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(286, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Resident ID:"
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(843, 302)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(111, 35)
        Me.exit_btn.TabIndex = 78
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 304)
        Me.Panel1.TabIndex = 79
        '
        'record_transaction_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(948, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.transaction_update)
        Me.Controls.Add(Me.resident_id)
        Me.Controls.Add(Me.transaction_date)
        Me.Controls.Add(Me.transaction_cost)
        Me.Controls.Add(Me.transaction_purpose)
        Me.Controls.Add(Me.transaction_number)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_transaction_update"
        Me.Text = "Update Transaction Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents transaction_update As Button
    Friend WithEvents resident_id As TextBox
    Friend WithEvents transaction_date As DateTimePicker
    Friend WithEvents transaction_cost As TextBox
    Friend WithEvents transaction_purpose As TextBox
    Friend WithEvents transaction_number As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents exit_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
