<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_transaction_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_transaction_add))
        Me.transaction_add = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'transaction_add
        '
        Me.transaction_add.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.transaction_add.Location = New System.Drawing.Point(788, 249)
        Me.transaction_add.Name = "transaction_add"
        Me.transaction_add.Size = New System.Drawing.Size(182, 38)
        Me.transaction_add.TabIndex = 75
        Me.transaction_add.Text = "Save"
        Me.transaction_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.transaction_add.UseVisualStyleBackColor = False
        '
        'resident_id
        '
        Me.resident_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_id.Location = New System.Drawing.Point(376, 36)
        Me.resident_id.Name = "resident_id"
        Me.resident_id.Size = New System.Drawing.Size(127, 27)
        Me.resident_id.TabIndex = 74
        '
        'transaction_date
        '
        Me.transaction_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transaction_date.Location = New System.Drawing.Point(439, 202)
        Me.transaction_date.Name = "transaction_date"
        Me.transaction_date.Size = New System.Drawing.Size(503, 27)
        Me.transaction_date.TabIndex = 73
        '
        'transaction_cost
        '
        Me.transaction_cost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transaction_cost.Location = New System.Drawing.Point(338, 147)
        Me.transaction_cost.Name = "transaction_cost"
        Me.transaction_cost.Size = New System.Drawing.Size(263, 27)
        Me.transaction_cost.TabIndex = 72
        '
        'transaction_purpose
        '
        Me.transaction_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transaction_purpose.Location = New System.Drawing.Point(404, 89)
        Me.transaction_purpose.Name = "transaction_purpose"
        Me.transaction_purpose.Size = New System.Drawing.Size(538, 27)
        Me.transaction_purpose.TabIndex = 71
        '
        'transaction_number
        '
        Me.transaction_number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transaction_number.Location = New System.Drawing.Point(705, 39)
        Me.transaction_number.Name = "transaction_number"
        Me.transaction_number.Size = New System.Drawing.Size(237, 27)
        Me.transaction_number.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(269, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Transaction Date:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(530, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Transaction Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(269, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(269, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Purpose of Use:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(269, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Resident ID:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 304)
        Me.Panel1.TabIndex = 76
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(854, 302)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(111, 35)
        Me.exit_btn.TabIndex = 77
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'record_transaction_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(954, 360)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.transaction_add)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_transaction_add"
        Me.Text = "Add Transaction Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents transaction_add As Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents exit_btn As Button
End Class
