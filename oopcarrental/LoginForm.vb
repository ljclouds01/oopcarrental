Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "•"c
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray
        CenterPanel()
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
            txtPassword.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    Private Sub btnSeePassword_Click(sender As Object, e As EventArgs) Handles btnSeePassword.Click
        If txtPassword.PasswordChar = "•"c Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "admin" AndAlso password = "1234" Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Dim regForm As New RegisterForm()
        regForm.Size = Me.Size
        regForm.StartPosition = FormStartPosition.CenterScreen
        Me.Hide()
        regForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        MessageBox.Show("Forgot Password feature not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
