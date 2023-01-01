Imports System.Text.RegularExpressions

Public Class CreateUser

	Private Property Roles As List(Of String)

	Sub New()
		InitializeComponent()
		GetRoles()
	End Sub

	Private Async Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		btnCreate.Enabled = False
		If CheckInput() Then
			UsersDao.Create(New Object() {cboRole.SelectedValue, txtUsername.Text, txtPassword.Text})
			DataUtils.Refresh(Table.Users)
			DataUtils.SetSelectedRow(txtUsername.Text, 1)
			PresenterCommon.Notify(Notification.Action, Type.CreateUserSuccess, Actions.Form)
		Else
			PresenterCommon.Notify(Notification.Action, Type.ActionError, Actions.Form)
		End If
		Await Task.Delay(1500)
		txtUsername_TextChanged(sender, e)
		btnCreate.Enabled = True
	End Sub

	Private Function CheckInput() As Boolean
		Dim Image, Correct As Integer
		For Each control In Controls
			If TypeOf control Is PictureBox Then
				If CType(control, PictureBox).Name.Contains("pic") Then
					Image += 1
					If CType(control, PictureBox).BackgroundImage.Tag.Equals("Correct") Then
						Correct += 1
					End If
				End If
			End If
		Next
		Return Image = Correct
	End Function

	Private Sub GetRoles()
		Roles = UsersDao.DataTable.Rows.Cast(Of DataRow) _
				.Select(Function(row) row.Field(Of String)("Role")) _
				.Distinct() _
				.ToList()
	End Sub

	Private Sub cboRole_DropDown(sender As Object, e As EventArgs) Handles cboRole.DropDown
		cboRole.DataSource = Roles
		Dim list = New List(Of String)
	End Sub

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		For Each control In Controls
			If TypeOf control Is PictureBox Then
				Dim pic = CType(control, PictureBox)
				DataUtils.Validate(Not pic.Name.Contains("pic"), pic)
			End If
		Next
	End Sub

	Private Sub cboRole_TextChanged(sender As Object, e As EventArgs) Handles cboRole.TextChanged
		DataUtils.Validate(cboRole.SelectedValue IsNot Nothing AndAlso
						   cboRole.SelectedValue.ToString.Length > 0, picRole)
	End Sub

	Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
		DataUtils.TextBoxUtil(txtUsername, "[^a-zA-Z0-9]")
		DataUtils.Validate(Regex.IsMatch(txtUsername.Text, "^[a-zA-Z][a-zA-Z0-9]{3,10}$") AndAlso
						   IsUsernameValid(txtUsername.Text), picUsername)
	End Sub

	Private Function IsUsernameValid(username As String) As Boolean
		Return Not UsersDao.DataTable.Rows.Cast(Of DataRow) _
				   .Where(Function(row) row.Field(Of String)("Username").Equals(username)) _
				   .Any
	End Function

	Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
		DataUtils.TextBoxUtil(txtPassword, "[^a-zA-Z0-9]")
		DataUtils.Validate(Regex.IsMatch(txtPassword.Text, "^[a-zA-Z0-9]{3,10}$"), picPassword)
	End Sub

End Class
