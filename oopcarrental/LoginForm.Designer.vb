<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.lblLogoName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSeePassword = New System.Windows.Forms.Button()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.lblNoAcc = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogoName
        '
        Me.lblLogoName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogoName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoName.ForeColor = System.Drawing.Color.White
        Me.lblLogoName.Location = New System.Drawing.Point(139, 51)
        Me.lblLogoName.Name = "lblLogoName"
        Me.lblLogoName.Size = New System.Drawing.Size(270, 51)
        Me.lblLogoName.TabIndex = 0
        Me.lblLogoName.Text = "CAR RENTAL"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSeePassword)
        Me.Panel1.Controls.Add(Me.lnkRegister)
        Me.Panel1.Controls.Add(Me.lblNoAcc)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnForgotPassword)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.lblLogIn)
        Me.Panel1.Location = New System.Drawing.Point(338, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 519)
        Me.Panel1.TabIndex = 1
        '
        'btnSeePassword
        '
        Me.btnSeePassword.BackColor = System.Drawing.Color.White
        Me.btnSeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSeePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSeePassword.Location = New System.Drawing.Point(536, 245)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(51, 32)
        Me.btnSeePassword.TabIndex = 9
        Me.btnSeePassword.Text = "👁️"
        Me.btnSeePassword.UseVisualStyleBackColor = False
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkRegister.Location = New System.Drawing.Point(254, 389)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(71, 23)
        Me.lnkRegister.TabIndex = 8
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Register"
        '
        'lblNoAcc
        '
        Me.lblNoAcc.AutoSize = True
        Me.lblNoAcc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblNoAcc.ForeColor = System.Drawing.Color.White
        Me.lblNoAcc.Location = New System.Drawing.Point(75, 389)
        Me.lblNoAcc.Name = "lblNoAcc"
        Me.lblNoAcc.Size = New System.Drawing.Size(181, 23)
        Me.lblNoAcc.TabIndex = 7
        Me.lblNoAcc.Text = "Don't have a account?"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLogin.Location = New System.Drawing.Point(365, 320)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(224, 46)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnForgotPassword.Location = New System.Drawing.Point(75, 320)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(224, 46)
        Me.btnForgotPassword.TabIndex = 5
        Me.btnForgotPassword.Text = "Forgot Password"
        Me.btnForgotPassword.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.txtPassword.Location = New System.Drawing.Point(75, 242)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(514, 38)
        Me.txtPassword.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(72, 223)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 21)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(75, 157)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(514, 38)
        Me.txtUsername.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(72, 135)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 21)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblLogIn
        '
        Me.lblLogIn.Font = New System.Drawing.Font("Segoe UI", 20.2!, System.Drawing.FontStyle.Bold)
        Me.lblLogIn.ForeColor = System.Drawing.Color.White
        Me.lblLogIn.Location = New System.Drawing.Point(198, 48)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(251, 53)
        Me.lblLogIn.TabIndex = 0
        Me.lblLogIn.Text = "User Login"
        Me.lblLogIn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 760)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLogoName)
        Me.Name = "LoginForm"
        Me.Text = "Login Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLogoName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogIn As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblNoAcc As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents lnkRegister As LinkLabel
    Friend WithEvents btnSeePassword As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
