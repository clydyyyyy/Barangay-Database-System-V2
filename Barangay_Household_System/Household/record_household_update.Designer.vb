<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_household_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_household_update))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.house_family = New System.Windows.Forms.TextBox()
        Me.house_number = New System.Windows.Forms.TextBox()
        Me.household_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.purok_number = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(218, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 23)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Purok Number:"
        '
        'house_family
        '
        Me.house_family.Location = New System.Drawing.Point(350, 153)
        Me.house_family.Name = "house_family"
        Me.house_family.Size = New System.Drawing.Size(245, 27)
        Me.house_family.TabIndex = 58
        '
        'house_number
        '
        Me.house_number.Location = New System.Drawing.Point(388, 106)
        Me.house_number.Name = "house_number"
        Me.house_number.Size = New System.Drawing.Size(207, 27)
        Me.house_number.TabIndex = 57
        '
        'household_update
        '
        Me.household_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.household_update.Location = New System.Drawing.Point(451, 195)
        Me.household_update.Name = "household_update"
        Me.household_update.Size = New System.Drawing.Size(165, 29)
        Me.household_update.TabIndex = 56
        Me.household_update.Text = "Update"
        Me.household_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.household_update.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(218, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Family Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(218, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Household Number:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 246)
        Me.Panel1.TabIndex = 61
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.exit_btn.Location = New System.Drawing.Point(496, 237)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(120, 29)
        Me.exit_btn.TabIndex = 62
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'purok_number
        '
        Me.purok_number.FormattingEnabled = True
        Me.purok_number.Location = New System.Drawing.Point(350, 54)
        Me.purok_number.Name = "purok_number"
        Me.purok_number.Size = New System.Drawing.Size(245, 28)
        Me.purok_number.TabIndex = 63
        '
        'record_household_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 278)
        Me.Controls.Add(Me.purok_number)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.house_family)
        Me.Controls.Add(Me.house_number)
        Me.Controls.Add(Me.household_update)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_household_update"
        Me.Text = "Update Household Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents house_family As TextBox
    Friend WithEvents house_number As TextBox
    Friend WithEvents household_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents exit_btn As Button
    Friend WithEvents purok_number As ComboBox
End Class
