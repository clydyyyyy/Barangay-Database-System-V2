<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user_tb = New System.Windows.Forms.TextBox()
        Me.pass_tb = New System.Windows.Forms.TextBox()
        Me.log_btn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(271, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(271, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'user_tb
        '
        Me.user_tb.Location = New System.Drawing.Point(378, 38)
        Me.user_tb.Name = "user_tb"
        Me.user_tb.Size = New System.Drawing.Size(230, 27)
        Me.user_tb.TabIndex = 3
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(378, 92)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass_tb.Size = New System.Drawing.Size(230, 27)
        Me.pass_tb.TabIndex = 4
        '
        'log_btn
        '
        Me.log_btn.Location = New System.Drawing.Point(278, 154)
        Me.log_btn.Name = "log_btn"
        Me.log_btn.Size = New System.Drawing.Size(330, 29)
        Me.log_btn.TabIndex = 5
        Me.log_btn.Text = "Log In"
        Me.log_btn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(253, 187)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 211)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.log_btn)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.user_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents user_tb As TextBox
    Friend WithEvents pass_tb As TextBox
    Friend WithEvents log_btn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
