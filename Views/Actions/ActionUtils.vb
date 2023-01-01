Imports System.Text.RegularExpressions

Module ActionUtils

	Property Form As ActionView
	Property Views As Dictionary(Of Action, UserControl)

	Sub Init()
		Views = New Dictionary(Of Action, UserControl) _
				From {{Action.CreateInventory, New CreateInventory},
					  {Action.UpdateInventory, New UpdateInventory},
					  {Action.DeleteInventory, New DeleteInventory},
					  {Action.CreateUser, New CreateUser},
					  {Action.UpdateUser, New UpdateUser}}
	End Sub

	Sub ShowAction(action As Action)
		Form = New ActionView
		Switch(Views.Item(action))
	End Sub

	Sub Switch(view As UserControl)
		With Form
			.Size = view.Size
			.Controls.Clear()
			.Controls.Add(view)
			.Controls.Item(0).Dock = DockStyle.Fill
			.ShowDialog()
		End With
	End Sub

	Sub Close()
		Form.Close()
	End Sub

	Async Sub Create(form As UserControl, button As Button, type As Type, field As String, cell As Integer,
							 table As Table, record As Object())
		button.Enabled = False
		If IsInputTrue(form) Then
			DaoCommon.Create(table, record)
			DataGridUtils.Refresh(table)
			DataGridUtils.SetSelectedRow(field, cell)
			NotifySuccess(type)
		Else
			NotifyError()
		End If
		Await Task.Delay(1500)
		button.Enabled = True
	End Sub

	Async Sub Update(form As UserControl, button As Button, field As String, cell As Integer,
							 table As Table, name As String, value As Object, record As Object())
		button.Enabled = False
		If IsInputTrue(form) Then
			DaoCommon.Update(table, name, value, record)
			DataGridUtils.Refresh(table)
			DataGridUtils.SetSelectedRow(field, cell)
			Close()
		Else
			NotifyError()
			Await Task.Delay(1500)
			button.Enabled = True
		End If
	End Sub

	Async Sub Delete(form As UserControl, button As Button, table As Table,
					 name As String, value As Object)
		button.Enabled = False
		If IsInputTrue(form) Then
			DaoCommon.Delete(table, name, value)
			Close()
		Else
			NotifyError()
			Await Task.Delay(1500)
			button.Enabled = True
		End If
	End Sub

	Sub NotifySuccess(type As Type)
		PresenterCommon.Notify(Notification.Action, type, ActionUtils.Form)
	End Sub

	Sub NotifyError()
		PresenterCommon.Notify(Notification.Action, Type.ActionError, ActionUtils.Form)
	End Sub

	Sub Validate(num As NumericUpDown, pic As PictureBox)
		ChangeImage(num.Value > 0, pic)
	End Sub

	Sub Validate(cbo As ComboBox, pic As PictureBox)
		ChangeImage(cbo.SelectedValue IsNot Nothing AndAlso
					cbo.SelectedValue.ToString.Length > 0, pic)
	End Sub

	Sub Validate(txt As TextBox, text As String, pattern As String, pic As PictureBox, field As Field)
		TextBoxUtil(txt, pattern)
		ChangeImage(GetCondition(field, txt.Text, text), pic)
	End Sub

	Sub TextBoxUtil(txtbox As TextBox, pattern As String)
		txtbox.Text = Regex.Replace(txtbox.Text, pattern, "")
		txtbox.SelectionStart = txtbox.Text.Length
		txtbox.SelectionLength = 0
	End Sub

	Sub ChangeImage(form As UserControl)
		form.Controls.OfType(Of PictureBox) _
					 .Select(Function(pic)
								 ChangeImage(Not pic.Name.Contains("pic"), pic)
								 Return 1
							 End Function
							 )
	End Sub

	Sub ChangeImage(form As UserControl, picLastRestock As PictureBox)
		form.Controls.OfType(Of PictureBox) _
					 .Select(Function(pic)
								 ChangeImage(pic.Name.Equals(picLastRestock.Name), pic)
								 Return 1
							 End Function
							 )
	End Sub

	Sub ChangeImage(isConditionTrue As Boolean, pic As PictureBox)
		If isConditionTrue Then
			pic.BackgroundImage = My.Resources.action_correct_input
			pic.BackgroundImage.Tag = "Correct"
		Else
			pic.BackgroundImage = My.Resources.action_incorrect_input
			pic.BackgroundImage.Tag = "Incorrect"
		End If
	End Sub

	Function IsInputTrue(form As UserControl) As Boolean
		Dim image = form.Controls.OfType(Of PictureBox).Count
		Dim correct = form.Controls.OfType(Of PictureBox) _
								   .Where(Function(pic) pic.BackgroundImage.Tag.Equals("Correct")).Count
		Return image = correct
	End Function

	Function IsItemValid(item As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
								 .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
								 .Any
	End Function

	Function IsUsernameValid(username As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
								 .Where(Function(row) row.Field(Of String)("Username").Equals(username)) _
								 .Any
	End Function

	Function ChangeCase(field As String, cell As Integer) As String
		Return DataGridView.Rows.Cast(Of DataGridViewRow) _
								.Where(Function(row) row.Cells(cell).Value.ToString.ToLower.Equals(field.ToLower)) _
								.Single.Cells(cell).Value.ToString
	End Function

	Function GetCondition(field As Field, text1 As String, text2 As String) As Boolean
		Dim condition As Boolean
		Select Case field
			Case Field.Item
				condition = Regex.IsMatch(text1, "^[a-zA-Z]{2,15}.*$") AndAlso IsItemValid(text1)
			Case Field.Price
				condition = Regex.IsMatch(text1, "^[1-9]\d{0,4}(\.\d{0,2})?$")
			Case Field.TotalPrice
				condition = Regex.IsMatch(text1, "^[1-9]\d{0,4}(\.\d{0,2})?$") AndAlso
							text2.Length > 0 AndAlso
							Not text2.Chars(0) = CChar("0") AndAlso
							Decimal.Parse(text1) >= Decimal.Parse(text2)
			Case Field.Supplier
				condition = Regex.IsMatch(text1, "^[a-zA-Z]{2,15}.*$")
			Case Field.Username
				condition = Regex.IsMatch(text1, "^[a-zA-Z][a-zA-Z0-9]{3,10}$") AndAlso
							IsUsernameValid(text1)
			Case Field.Password
				condition = Regex.IsMatch(text1, "^[a-zA-Z][a-zA-Z0-9]{3,10}$")
		End Select

		Return condition
	End Function

	Function GetCategories() As List(Of String)
		Return DataTable.Rows.Cast(Of DataRow) _
							 .Select(Function(row) row.Field(Of String)("Category")) _
							 .Distinct() _
							 .ToList()
	End Function

	Function GetMeasurements() As List(Of String)
		Return DataTable.Rows.Cast(Of DataRow) _
							 .Select(Function(row) row.Field(Of String)("Measurement")) _
							 .Distinct() _
							 .ToList()
	End Function

	Function GetRoles() As List(Of String)
		Return DataTable.Rows.Cast(Of DataRow) _
							 .Select(Function(row) row.Field(Of String)("Role")) _
							 .Distinct() _
							 .ToList()
	End Function

End Module
