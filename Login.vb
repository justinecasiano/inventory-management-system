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

End Class
