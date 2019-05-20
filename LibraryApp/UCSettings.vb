Imports System.Configuration
Public Class UCSettings
    Private Sub tpchangepass_Click(sender As Object, e As EventArgs) Handles tpchangepass.Click

    End Sub

    Private Sub btnupdatepass_Click(sender As Object, e As EventArgs) Handles btnupdatepass.Click
        Dim user As New User()
        user.Newpassword = tbpassword.Text
        user.Password = tboldpassword.Text
        user.Username = tbusername.Text


        If (user.Newpassword = user.Password) Then
            MessageBox.Show("Old and New Password should be different.")
            Exit Sub
        End If

        If user.UpdatePassword() Then
            MessageBox.Show("Password change successfull!.")
        Else
            MessageBox.Show("Error: Could not change password.")

        End If

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Try
            AddUpdateAppSettings("late_day_fee", nudlatefee.Value)
            AddUpdateAppSettings("max_borrow_days", nudmaxdays.Value)

            If (rbblue.Checked) Then
                MainForm.BackColor = Color.CornflowerBlue
                AddUpdateAppSettings("theme_color", Color.CornflowerBlue.ToArgb.ToString)
            Else
                MainForm.BackColor = Color.WhiteSmoke
                AddUpdateAppSettings("theme_color", Color.WhiteSmoke.ToArgb.ToString)
            End If

            MessageBox.Show("Settings saved successfully.")

        Catch ex As Exception
            MessageBox.Show("Error saving...")
        End Try



    End Sub




    Sub AddUpdateAppSettings(key As String, value As String)
        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings
            If IsNothing(settings(key)) Then
                settings.Add(key, value)
            Else
                settings(key).Value = value
            End If
            configFile.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch e As ConfigurationErrorsException
            Console.WriteLine("Error writing app settings")
        End Try
    End Sub


    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles nudlatefee.ValueChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles bluecolor.Click
        rbblue.Checked = True
        MainForm.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub pinkcolor_Click(sender As Object, e As EventArgs) Handles pinkcolor.Click
        rbpink.Checked = True
        MainForm.BackColor = Color.HotPink
    End Sub

    Private Sub graycolor_Click(sender As Object, e As EventArgs) Handles graycolor.Click
        rbstandard.Checked = True
        MainForm.BackColor = Color.WhiteSmoke
    End Sub
End Class
