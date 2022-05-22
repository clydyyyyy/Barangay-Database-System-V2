<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_info_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_info_edit))
        Me.log_btn = New System.Windows.Forms.Button()
        Me.pass_tb = New System.Windows.Forms.TextBox()
        Me.user_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'log_btn
        '
        Me.log_btn.Location = New System.Drawing.Point(299, 209)
        Me.log_btn.Name = "log_btn"
        Me.log_btn.Size = New System.Drawing.Size(380, 29)
        Me.log_btn.TabIndex = 19
        Me.log_btn.Text = "Done!"
        Me.log_btn.UseVisualStyleBackColor = True
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(423, 95)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.Size = New System.Drawing.Size(256, 27)
        Me.pass_tb.TabIndex = 18
        '
        'user_tb
        '
        Me.user_tb.Location = New System.Drawing.Point(423, 41)
        Me.user_tb.Name = "user_tb"
        Me.user_tb.Size = New System.Drawing.Size(256, 27)
        Me.user_tb.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(299, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(299, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Username:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 226)
        Me.Panel1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.LightCoral
        Me.Label4.Location = New System.Drawing.Point(337, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(315, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "*Please Change One Field At A Time"
        '
        'user_info_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 264)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.log_btn)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.user_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "user_info_edit"
        Me.Text = "Edit User Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents log_btn As Button
    Friend WithEvents pass_tb As TextBox
    Friend WithEvents user_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
