Public Class RegisterForm

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterPanel()

        SetPlaceholder(txtName, "First Name        Middle Name       Last Name")
        SetPlaceholder(txtUsername, "Username")
        SetPlaceholder(txtPassword, "Password", True)
        SetPlaceholder(txtConfirmPassword, "Confirm Password", True)
        SetPlaceholder(txtEmail, "Email")
        SetPlaceholder(txtContactNumber, "Contact Number")
        SetPlaceholder(txtAddress, "Address")
        SetPlaceholder(txtDriversLicense, "Driver's License Number")
        SetPlaceholder(txtLicenseExpiry, "License Expiry Date")

        cbxSex.Items.Clear()
        cbxSex.Items.Add("Select Sex")
        cbxSex.Items.Add("Male")
        cbxSex.Items.Add("Female")
        SetupComboBoxPlaceholder()
    End Sub

    Private Sub RegisterForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub CenterPanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

    Private Sub SetPlaceholder(txt As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        txt.Text = placeholder
        txt.ForeColor = Color.Gray
        If isPassword Then txt.PasswordChar = ControlChars.NullChar

        AddHandler txt.Enter, Sub()
                                  If txt.Text = placeholder Then
                                      txt.Text = ""
                                      txt.ForeColor = Color.Black
                                      If isPassword Then txt.PasswordChar = "•"c
                                  End If
                              End Sub

        AddHandler txt.Leave, Sub()
                                  If txt.Text = "" Then
                                      txt.Text = placeholder
                                      txt.ForeColor = Color.Gray
                                      If isPassword Then txt.PasswordChar = ControlChars.NullChar
                                  End If
                              End Sub
    End Sub

    Private Sub SetupComboBoxPlaceholder()
        cbxSex.DrawMode = DrawMode.OwnerDrawFixed
        AddHandler cbxSex.DrawItem, Sub(sender As Object, e As DrawItemEventArgs)
                                        If e.Index < 0 Then Exit Sub
                                        e.DrawBackground()
                                        Dim text As String = cbxSex.Items(e.Index).ToString()
                                        Dim color As Color = If(e.Index = 0, Color.Gray, Color.Black)
                                        Using brush As New SolidBrush(color)
                                            e.Graphics.DrawString(text, cbxSex.Font, brush, e.Bounds.X, e.Bounds.Y)
                                        End Using
                                    End Sub
        cbxSex.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "First Name        Middle Name       Last Name" Or txtUsername.Text = "Username" Or txtPassword.Text = "Password" Or txtConfirmPassword.Text = "Confirm Password" Then
            MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If cbxSex.SelectedIndex = 0 Then
            MessageBox.Show("Please select sex.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked Then
            txtConfirmPassword.PasswordChar = ControlChars.NullChar
        Else
            txtConfirmPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub cbxSex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSex.SelectedIndexChanged

    End Sub
End Class
