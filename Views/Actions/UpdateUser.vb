
Public Class UpdateUser

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		ActionUtils.ChangeImage(Me)
		cboRole_DropDown(sender, e)
		FillDataFields()
	End Sub

	Private Sub FillDataFields()
		cboRole.Text = CType(GetSelectedRow(1), String)
		txtUsername.Text = CType(GetSelectedRow(2), String)
		txtPassword.Text = CType(GetSelectedRow(3), String)
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		ActionUtils.Update(Me, btnUpdate, txtUsername.Text, Table.Users, "User", GetSelectedRow(0),
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

		If Not IsUsernameValid(txtUsername.Text) Then
			txtUsername.Text = ChangeCase(txtUsername.Text)
			SetSelectedRow(txtUsername.Text)
			txtUsername_TextChanged(sender, e)
			FillDataFields()
		End If
	End Sub

	Function IsUsernameValid(username As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
							 .Where(Function(row) row.Field(Of String)("Username").Equals(username)) _
							 .Any OrElse username.Equals(GetSelectedRow(2).ToString)
	End Function

	Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
		TextBoxUtil(txtPassword, TextPattern(Field.LoginText))
		ActionUtils.Validate(Match(txtPassword.Text, Field.LoginText), picPassword)
	End Sub

End Class
