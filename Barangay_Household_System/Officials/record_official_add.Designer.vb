<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_official_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_official_add))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.official_add = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.official_end = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.official_start = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.official_position = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gender_female = New System.Windows.Forms.RadioButton()
        Me.gender_male = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.official_age = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.official_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.official_contact = New System.Windows.Forms.TextBox()
        Me.official_dob = New System.Windows.Forms.DateTimePicker()
        Me.official_full_name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.official_household = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(442, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barangay Official Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'official_add
        '
        Me.official_add.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.official_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.official_add.Location = New System.Drawing.Point(291, 448)
        Me.official_add.Name = "official_add"
        Me.official_add.Size = New System.Drawing.Size(212, 48)
        Me.official_add.TabIndex = 112
        Me.official_add.Text = "Save"
        Me.official_add.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(11, 393)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 25)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Residence Number:"
        '
        'official_end
        '
        Me.official_end.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_end.Location = New System.Drawing.Point(522, 345)
        Me.official_end.Name = "official_end"
        Me.official_end.Size = New System.Drawing.Size(266, 27)
        Me.official_end.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(431, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Term End:"
        '
        'official_start
        '
        Me.official_start.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_start.Location = New System.Drawing.Point(109, 345)
        Me.official_start.Name = "official_start"
        Me.official_start.Size = New System.Drawing.Size(260, 27)
        Me.official_start.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 23)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Term Start:"
        '
        'official_position
        '
        Me.official_position.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_position.Location = New System.Drawing.Point(91, 295)
        Me.official_position.Name = "official_position"
        Me.official_position.Size = New System.Drawing.Size(384, 27)
        Me.official_position.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Position:"
        '
        'gender_female
        '
        Me.gender_female.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gender_female.AutoSize = True
        Me.gender_female.Location = New System.Drawing.Point(665, 247)
        Me.gender_female.Name = "gender_female"
        Me.gender_female.Size = New System.Drawing.Size(78, 24)
        Me.gender_female.TabIndex = 103
        Me.gender_female.TabStop = True
        Me.gender_female.Text = "Female"
        Me.gender_female.UseVisualStyleBackColor = True
        '
        'gender_male
        '
        Me.gender_male.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gender_male.AutoSize = True
        Me.gender_male.Location = New System.Drawing.Point(587, 247)
        Me.gender_male.Name = "gender_male"
        Me.gender_male.Size = New System.Drawing.Size(63, 24)
        Me.gender_male.TabIndex = 102
        Me.gender_male.TabStop = True
        Me.gender_male.Text = "Male"
        Me.gender_male.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(538, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 25)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Sex:"
        '
        'official_age
        '
        Me.official_age.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_age.Location = New System.Drawing.Point(588, 185)
        Me.official_age.Name = "official_age"
        Me.official_age.Size = New System.Drawing.Size(200, 27)
        Me.official_age.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(538, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Age:"
        '
        'official_id
        '
        Me.official_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_id.Location = New System.Drawing.Point(115, 75)
        Me.official_id.Name = "official_id"
        Me.official_id.Size = New System.Drawing.Size(232, 27)
        Me.official_id.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Official ID:"
        '
        'official_contact
        '
        Me.official_contact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_contact.Location = New System.Drawing.Point(91, 243)
        Me.official_contact.Name = "official_contact"
        Me.official_contact.Size = New System.Drawing.Size(384, 27)
        Me.official_contact.TabIndex = 96
        '
        'official_dob
        '
        Me.official_dob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_dob.Location = New System.Drawing.Point(138, 183)
        Me.official_dob.Name = "official_dob"
        Me.official_dob.Size = New System.Drawing.Size(337, 27)
        Me.official_dob.TabIndex = 95
        '
        'official_full_name
        '
        Me.official_full_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.official_full_name.Location = New System.Drawing.Point(115, 125)
        Me.official_full_name.Name = "official_full_name"
        Me.official_full_name.Size = New System.Drawing.Size(673, 27)
        Me.official_full_name.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(11, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 23)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Contact:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Date Of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Full Name:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 49)
        Me.Panel1.TabIndex = 90
        '
        'official_household
        '
        Me.official_household.FormattingEnabled = True
        Me.official_household.Location = New System.Drawing.Point(196, 394)
        Me.official_household.Name = "official_household"
        Me.official_household.Size = New System.Drawing.Size(592, 28)
        Me.official_household.TabIndex = 113
        '
        'record_official_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 508)
        Me.Controls.Add(Me.official_household)
        Me.Controls.Add(Me.official_add)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.official_end)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.official_start)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.official_position)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gender_female)
        Me.Controls.Add(Me.gender_male)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.official_age)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.official_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.official_contact)
        Me.Controls.Add(Me.official_dob)
        Me.Controls.Add(Me.official_full_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_official_add"
        Me.Text = "Add Barangay Official Record"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents official_add As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents official_end As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents official_start As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents official_position As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gender_female As RadioButton
    Friend WithEvents gender_male As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents official_age As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents official_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents official_contact As TextBox
    Friend WithEvents official_dob As DateTimePicker
    Friend WithEvents official_full_name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents official_household As ComboBox
End Class
