<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_resident_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record_resident_update))
        Me.resident_age = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resident_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gender_female = New System.Windows.Forms.RadioButton()
        Me.gender_male = New System.Windows.Forms.RadioButton()
        Me.resident_religion = New System.Windows.Forms.TextBox()
        Me.resident_occupation = New System.Windows.Forms.TextBox()
        Me.resident_citizenship = New System.Windows.Forms.TextBox()
        Me.resident_pob = New System.Windows.Forms.TextBox()
        Me.resident_fullname = New System.Windows.Forms.TextBox()
        Me.resident_update = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resident_dob = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.marital_single = New System.Windows.Forms.CheckBox()
        Me.marital_separated = New System.Windows.Forms.CheckBox()
        Me.marital_widowed = New System.Windows.Forms.CheckBox()
        Me.marital_married = New System.Windows.Forms.CheckBox()
        Me.resident_household = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'resident_age
        '
        Me.resident_age.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_age.Location = New System.Drawing.Point(599, 181)
        Me.resident_age.Name = "resident_age"
        Me.resident_age.Size = New System.Drawing.Size(253, 27)
        Me.resident_age.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(549, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Age:"
        '
        'resident_id
        '
        Me.resident_id.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_id.Enabled = False
        Me.resident_id.Location = New System.Drawing.Point(136, 71)
        Me.resident_id.Name = "resident_id"
        Me.resident_id.Size = New System.Drawing.Size(231, 27)
        Me.resident_id.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(29, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Resident ID:"
        '
        'gender_female
        '
        Me.gender_female.AutoSize = True
        Me.gender_female.Location = New System.Drawing.Point(148, 378)
        Me.gender_female.Name = "gender_female"
        Me.gender_female.Size = New System.Drawing.Size(78, 24)
        Me.gender_female.TabIndex = 64
        Me.gender_female.TabStop = True
        Me.gender_female.Text = "Female"
        Me.gender_female.UseVisualStyleBackColor = True
        '
        'gender_male
        '
        Me.gender_male.AutoSize = True
        Me.gender_male.Location = New System.Drawing.Point(148, 348)
        Me.gender_male.Name = "gender_male"
        Me.gender_male.Size = New System.Drawing.Size(63, 24)
        Me.gender_male.TabIndex = 63
        Me.gender_male.TabStop = True
        Me.gender_male.Text = "Male"
        Me.gender_male.UseVisualStyleBackColor = True
        '
        'resident_religion
        '
        Me.resident_religion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_religion.Location = New System.Drawing.Point(560, 426)
        Me.resident_religion.Name = "resident_religion"
        Me.resident_religion.Size = New System.Drawing.Size(292, 27)
        Me.resident_religion.TabIndex = 61
        '
        'resident_occupation
        '
        Me.resident_occupation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_occupation.Location = New System.Drawing.Point(142, 427)
        Me.resident_occupation.Name = "resident_occupation"
        Me.resident_occupation.Size = New System.Drawing.Size(268, 27)
        Me.resident_occupation.TabIndex = 60
        '
        'resident_citizenship
        '
        Me.resident_citizenship.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_citizenship.Location = New System.Drawing.Point(132, 295)
        Me.resident_citizenship.Name = "resident_citizenship"
        Me.resident_citizenship.Size = New System.Drawing.Size(720, 27)
        Me.resident_citizenship.TabIndex = 59
        '
        'resident_pob
        '
        Me.resident_pob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_pob.Location = New System.Drawing.Point(149, 239)
        Me.resident_pob.Name = "resident_pob"
        Me.resident_pob.Size = New System.Drawing.Size(703, 27)
        Me.resident_pob.TabIndex = 58
        '
        'resident_fullname
        '
        Me.resident_fullname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_fullname.Location = New System.Drawing.Point(136, 121)
        Me.resident_fullname.Name = "resident_fullname"
        Me.resident_fullname.Size = New System.Drawing.Size(716, 27)
        Me.resident_fullname.TabIndex = 56
        '
        'resident_update
        '
        Me.resident_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.resident_update.Location = New System.Drawing.Point(336, 562)
        Me.resident_update.Name = "resident_update"
        Me.resident_update.Size = New System.Drawing.Size(212, 48)
        Me.resident_update.TabIndex = 55
        Me.resident_update.Text = "Save"
        Me.resident_update.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(29, 480)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 25)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Residence Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Occupation:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(469, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 25)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Religion:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(29, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 23)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Place of birth:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(425, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Marital Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(35, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 25)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Sex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(29, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Citizenship:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(29, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Date Of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(29, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 23)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Full Name:"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(347, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resident Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resident_dob
        '
        Me.resident_dob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resident_dob.Location = New System.Drawing.Point(149, 179)
        Me.resident_dob.Name = "resident_dob"
        Me.resident_dob.Size = New System.Drawing.Size(337, 27)
        Me.resident_dob.TabIndex = 57
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 49)
        Me.Panel1.TabIndex = 45
        '
        'marital_single
        '
        Me.marital_single.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marital_single.AutoSize = True
        Me.marital_single.Location = New System.Drawing.Point(572, 351)
        Me.marital_single.Name = "marital_single"
        Me.marital_single.Size = New System.Drawing.Size(72, 24)
        Me.marital_single.TabIndex = 73
        Me.marital_single.Text = "Single"
        Me.marital_single.UseVisualStyleBackColor = True
        '
        'marital_separated
        '
        Me.marital_separated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marital_separated.AutoSize = True
        Me.marital_separated.Location = New System.Drawing.Point(749, 381)
        Me.marital_separated.Name = "marital_separated"
        Me.marital_separated.Size = New System.Drawing.Size(99, 24)
        Me.marital_separated.TabIndex = 74
        Me.marital_separated.Text = "Separated"
        Me.marital_separated.UseVisualStyleBackColor = True
        '
        'marital_widowed
        '
        Me.marital_widowed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marital_widowed.AutoSize = True
        Me.marital_widowed.Location = New System.Drawing.Point(749, 351)
        Me.marital_widowed.Name = "marital_widowed"
        Me.marital_widowed.Size = New System.Drawing.Size(95, 24)
        Me.marital_widowed.TabIndex = 75
        Me.marital_widowed.Text = "Widowed"
        Me.marital_widowed.UseVisualStyleBackColor = True
        '
        'marital_married
        '
        Me.marital_married.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marital_married.AutoSize = True
        Me.marital_married.Location = New System.Drawing.Point(572, 381)
        Me.marital_married.Name = "marital_married"
        Me.marital_married.Size = New System.Drawing.Size(83, 24)
        Me.marital_married.TabIndex = 76
        Me.marital_married.Text = "Married"
        Me.marital_married.UseVisualStyleBackColor = True
        '
        'resident_household
        '
        Me.resident_household.FormattingEnabled = True
        Me.resident_household.Location = New System.Drawing.Point(208, 481)
        Me.resident_household.Name = "resident_household"
        Me.resident_household.Size = New System.Drawing.Size(636, 28)
        Me.resident_household.TabIndex = 77
        '
        'record_resident_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 632)
        Me.Controls.Add(Me.resident_household)
        Me.Controls.Add(Me.marital_married)
        Me.Controls.Add(Me.marital_widowed)
        Me.Controls.Add(Me.marital_separated)
        Me.Controls.Add(Me.marital_single)
        Me.Controls.Add(Me.resident_age)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.resident_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gender_female)
        Me.Controls.Add(Me.gender_male)
        Me.Controls.Add(Me.resident_religion)
        Me.Controls.Add(Me.resident_occupation)
        Me.Controls.Add(Me.resident_citizenship)
        Me.Controls.Add(Me.resident_pob)
        Me.Controls.Add(Me.resident_fullname)
        Me.Controls.Add(Me.resident_update)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resident_dob)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record_resident_update"
        Me.Text = "Update Resident"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resident_age As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents resident_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gender_female As RadioButton
    Friend WithEvents gender_male As RadioButton
    Friend WithEvents resident_religion As TextBox
    Friend WithEvents resident_occupation As TextBox
    Friend WithEvents resident_citizenship As TextBox
    Friend WithEvents resident_pob As TextBox
    Friend WithEvents resident_fullname As TextBox
    Friend WithEvents resident_update As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents resident_dob As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents marital_single As CheckBox
    Friend WithEvents marital_separated As CheckBox
    Friend WithEvents marital_widowed As CheckBox
    Friend WithEvents marital_married As CheckBox
    Friend WithEvents resident_household As ComboBox
End Class
