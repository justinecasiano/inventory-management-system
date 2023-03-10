
Public Class CreateUser

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		ActionUtils.ChangeImage(Me)
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		ActionUtils.Create(Me, btnCreate, Type.CreateUserSuccess, txtUsername.Text, Table.Users,
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
		TextBoxUtil(txtUsername, TextPattern(Field.LoginText))
		ActionUtils.Validate(Match(txtUsername.Text, Field.LoginText) AndAlso
							 IsUsernameValid(txtUsername.Text), picUsername)
	End Sub

	Function IsUsernameValid(username As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
								 .Where(Function(row) row.Field(Of String)("Username").ToLower.Equals(username.ToLower)) _
								 .Any
	End Function

	Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
		TextBoxUtil(txtPassword, TextPattern(Field.LoginText))
		ActionUtils.Validate(Match(txtPassword.Text, Field.LoginText), picPassword)
	End Sub

End Class
