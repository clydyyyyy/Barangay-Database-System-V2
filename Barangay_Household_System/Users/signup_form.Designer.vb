<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup_form))
        Me.log_btn = New System.Windows.Forms.Button()
        Me.pass_tb = New System.Windows.Forms.TextBox()
        Me.user_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'log_btn
        '
        Me.log_btn.Location = New System.Drawing.Point(317, 200)
        Me.log_btn.Name = "log_btn"
        Me.log_btn.Size = New System.Drawing.Size(373, 29)
        Me.log_btn.TabIndex = 11
        Me.log_btn.Text = "Sign Up"
        Me.log_btn.UseVisualStyleBackColor = True
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(434, 118)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.Size = New System.Drawing.Size(256, 27)
        Me.pass_tb.TabIndex = 10
        '
        'user_tb
        '
        Me.user_tb.Location = New System.Drawing.Point(434, 64)
        Me.user_tb.Name = "user_tb"
        Me.user_tb.Size = New System.Drawing.Size(256, 27)
        Me.user_tb.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(310, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(310, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 233)
        Me.Panel1.TabIndex = 14
        '
        'signup_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 257)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.log_btn)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.user_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "signup_form"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents log_btn As Button
    Friend WithEvents pass_tb As TextBox
    Friend WithEvents user_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
