<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_purok_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_purok_update))
        Me.street_tb = New System.Windows.Forms.TextBox()
        Me.purok_tb = New System.Windows.Forms.TextBox()
        Me.purok_update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'street_tb
        '
        Me.street_tb.Location = New System.Drawing.Point(332, 83)
        Me.street_tb.Name = "street_tb"
        Me.street_tb.Size = New System.Drawing.Size(245, 27)
        Me.street_tb.TabIndex = 51
        '
        'purok_tb
        '
        Me.purok_tb.Location = New System.Drawing.Point(332, 33)
        Me.purok_tb.Name = "purok_tb"
        Me.purok_tb.Size = New System.Drawing.Size(245, 27)
        Me.purok_tb.TabIndex = 50
        '
        'purok_update
        '
        Me.purok_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.purok_update.Location = New System.Drawing.Point(446, 132)
        Me.purok_update.Name = "purok_update"
        Me.purok_update.Size = New System.Drawing.Size(151, 39)
        Me.purok_update.TabIndex = 49
        Me.purok_update.Text = "Update"
        Me.purok_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.purok_update.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(200, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Street Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(200, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Purok Number:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 204)
        Me.Panel1.TabIndex = 55
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.exit_btn.Location = New System.Drawing.Point(477, 177)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(120, 29)
        Me.exit_btn.TabIndex = 56
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'record_purok_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 228)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.street_tb)
        Me.Controls.Add(Me.purok_tb)
        Me.Controls.Add(Me.purok_update)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_purok_update"
        Me.Text = "Update Purok Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents street_tb As TextBox
    Friend WithEvents purok_tb As TextBox
    Friend WithEvents purok_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents exit_btn As Button
End Class
