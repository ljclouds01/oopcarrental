<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLicenseExpiry = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cbxSex = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtDriversLicense = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cb2)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.txtConfirmPassword)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtLicenseExpiry)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.cbxSex)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtContactNumber)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblRegister)
        Me.Panel1.Location = New System.Drawing.Point(116, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 637)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(574, 578)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 23)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login here"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(367, 578)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Already have an account?"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(92, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(860, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb2.AutoSize = True
        Me.cb2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb2.ForeColor = System.Drawing.Color.White
        Me.cb2.Location = New System.Drawing.Point(92, 481)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(244, 27)
        Me.cb2.TabIndex = 13
        Me.cb2.Text = "I Agree to the Privacy Policy"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb1.ForeColor = System.Drawing.Color.White
        Me.cb1.Location = New System.Drawing.Point(92, 448)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(301, 27)
        Me.cb1.TabIndex = 12
        Me.cb1.Text = "I Agree to the Terms and Condition"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(544, 392)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(409, 36)
        Me.txtConfirmPassword.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtPassword.Location = New System.Drawing.Point(92, 392)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(416, 36)
        Me.txtPassword.TabIndex = 10
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtUsername.Location = New System.Drawing.Point(544, 330)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(409, 36)
        Me.txtUsername.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtEmail.Location = New System.Drawing.Point(92, 330)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(416, 36)
        Me.txtEmail.TabIndex = 8
        '
        'txtLicenseExpiry
        '
        Me.txtLicenseExpiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLicenseExpiry.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtLicenseExpiry.Location = New System.Drawing.Point(543, 268)
        Me.txtLicenseExpiry.Name = "txtLicenseExpiry"
        Me.txtLicenseExpiry.Size = New System.Drawing.Size(409, 36)
        Me.txtLicenseExpiry.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtAddress.Location = New System.Drawing.Point(92, 208)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(861, 36)
        Me.txtAddress.TabIndex = 6
        '
        'cbxSex
        '
        Me.cbxSex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxSex.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.cbxSex.FormattingEnabled = True
        Me.cbxSex.Location = New System.Drawing.Point(660, 147)
        Me.cbxSex.Name = "cbxSex"
        Me.cbxSex.Size = New System.Drawing.Size(292, 38)
        Me.cbxSex.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 148)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(249, 36)
        Me.DateTimePicker1.TabIndex = 4
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtContactNumber.Location = New System.Drawing.Point(360, 148)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(284, 36)
        Me.txtContactNumber.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtName.Location = New System.Drawing.Point(92, 89)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(861, 36)
        Me.txtName.TabIndex = 1
        '
        'lblRegister
        '
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(25, 22)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(150, 46)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Register"
        '
        'txtDriversLicense
        '
        Me.txtDriversLicense.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDriversLicense.Font = New System.Drawing.Font("Segoe UI", 12.8!)
        Me.txtDriversLicense.Location = New System.Drawing.Point(210, 334)
        Me.txtDriversLicense.Name = "txtDriversLicense"
        Me.txtDriversLicense.Size = New System.Drawing.Size(416, 36)
        Me.txtDriversLicense.TabIndex = 2
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 760)
        Me.Controls.Add(Me.txtDriversLicense)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtLicenseExpiry As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents cbxSex As ComboBox
    Friend WithEvents txtDriversLicense As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
