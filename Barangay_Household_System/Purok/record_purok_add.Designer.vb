<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_purok_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_purok_add))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.purok_add = New System.Windows.Forms.Button()
        Me.purok_number = New System.Windows.Forms.TextBox()
        Me.street_name = New System.Windows.Forms.TextBox()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(211, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Purok Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(211, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Street Name:"
        '
        'purok_add
        '
        Me.purok_add.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.purok_add.Location = New System.Drawing.Point(465, 132)
        Me.purok_add.Name = "purok_add"
        Me.purok_add.Size = New System.Drawing.Size(151, 38)
        Me.purok_add.TabIndex = 44
        Me.purok_add.Text = "Create"
        Me.purok_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.purok_add.UseVisualStyleBackColor = False
        '
        'purok_number
        '
        Me.purok_number.Location = New System.Drawing.Point(343, 34)
        Me.purok_number.Name = "purok_number"
        Me.purok_number.Size = New System.Drawing.Size(245, 27)
        Me.purok_number.TabIndex = 45
        '
        'street_name
        '
        Me.street_name.Location = New System.Drawing.Point(343, 84)
        Me.street_name.Name = "street_name"
        Me.street_name.Size = New System.Drawing.Size(245, 27)
        Me.street_name.TabIndex = 46
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.exit_btn.Location = New System.Drawing.Point(496, 176)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(120, 29)
        Me.exit_btn.TabIndex = 57
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 204)
        Me.Panel1.TabIndex = 58
        '
        'record_purok_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 228)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.street_name)
        Me.Controls.Add(Me.purok_number)
        Me.Controls.Add(Me.purok_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_purok_add"
        Me.Text = "Add Purok Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents purok_add As Button
    Friend WithEvents purok_number As TextBox
    Friend WithEvents street_name As TextBox
    Friend WithEvents exit_btn As Button
    Friend WithEvents Panel1 As Panel
End Class
