Public Class Login

	Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
		If txtPassword.PasswordChar = CChar("*") Then
			txtPassword.PasswordChar = CChar("")
			btnShowHide.BackgroundImage = My.Resources.login_password_hide
		Else
			txtPassword.PasswordChar = CChar("*")
			btnShowHide.BackgroundImage = My.Resources.login_password_show
		End If
	End Sub

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		Validate(txtUsername.Text, txtPassword.Text)
	End Sub

	Private Shadows Async Sub Validate(username As String, password As String)
		Dim account = DAOs.Item(Table.Users).DataTable.Rows.Cast(Of DataRow) _
					  .Where(Function(row) row.Field(Of String)("Username").Equals(username) And
										   row.Field(Of String)("Password").Equals(password)) _
					  .Select(Function(row) row).SingleOrDefault

		btnLogin.Enabled = False

		If account IsNot Nothing Then
			DataGridUtils.Role = account.Field(Of String)("Role")
			PresenterCommon.Notify(Notification.Login, Type.LoginSuccess, PresenterCommon.Form)
			Await Task.Delay(2500)
			PresenterCommon.Switch(View.Dashboard, True, FormWindowState.Maximized)
		Else
			PresenterCommon.Notify(Notification.Login, Type.LoginError, PresenterCommon.Form)
			Await Task.Delay(1500)
		End If
		btnLogin.Enabled = True
		txtUsername.Clear()
		txtPassword.Clear()
	End Sub

End Class
