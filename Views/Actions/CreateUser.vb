
Public Class CreateUser

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		ActionUtils.ChangeImage(Me)
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		ActionUtils.Create(Me, btnCreate, Type.CreateUserSuccess, txtUsername.Text, 1, Table.Users,
						   New Object() {cboRole.SelectedValue, txtUsername.Text, txtPassword.Text})
		txtUsername_TextChanged(sender, e)
	End Sub

	Private Sub cboRole_DropDown(sender As Object, e As EventArgs) Handles cboRole.DropDown
		cboRole.DataSource = GetRoles()
	End Sub

	Private Sub cboRole_TextChanged(sender As Object, e As EventArgs) Handles cboRole.TextChanged
		ActionUtils.Validate(cboRole, picRole)
	End Sub

	Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
		ActionUtils.Validate(txtUsername, "", "[^a-zA-Z0-9]", picUsername, Field.Username)
	End Sub

	Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
		ActionUtils.Validate(txtPassword, "", "[^a-zA-Z0-9]", picPassword, Field.Password)
	End Sub

End Class
