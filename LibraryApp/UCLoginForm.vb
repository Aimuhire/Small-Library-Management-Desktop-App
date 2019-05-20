Public Class UCLoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            If tbusername.Text = "" Or tbpassword.Text = "" Then
                MessageBox.Show("Please fill all fields.")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        Dim User As New User()
        User.Username = tbusername.Text
        User.Password = tbpassword.Text

        If (Not User.login()) Then
            MessageBox.Show("Could not login with provided information.")
            Exit Sub
        End If


        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")


    End Sub

    Private Sub UCLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
