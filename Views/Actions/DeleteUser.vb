
Public Class DeleteUser

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		txtUsername_TextChanged(sender, e)
		txtUsername.Text = GetSelectedRow(2).ToString
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		ActionUtils.Delete(Me, btnDelete, Table.Users, "Username", txtUsername.Text)
	End Sub

	Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
		TextBoxUtil(txtUsername, TextPattern(Field.LoginText))
		ActionUtils.Validate(Match(txtUsername.Text, Field.LoginText) AndAlso
							 IsUsernameValid(txtUsername.Text), picUsername)
		If IsUsernameValid(txtUsername.Text) Then
			txtUsername.Text = ChangeCase(txtUsername.Text)
			SetSelectedRow(txtUsername.Text)
		End If
	End Sub

	Function IsUsernameValid(username As String) As Boolean
		Return DataTable.Rows.Cast(Of DataRow) _
							 .Where(Function(row) row.Field(Of String)("Username").Equals(username)) _
							 .Any OrElse username.Equals(GetSelectedRow(2).ToString)

	End Function

End Class
