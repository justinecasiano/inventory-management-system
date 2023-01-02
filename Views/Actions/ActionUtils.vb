Imports System.Text.RegularExpressions

Module ActionUtils

	Property Form As ActionView
	Property Views As Dictionary(Of Action, UserControl)
	Property TextPattern As Dictionary(Of Field, String)
	Property InputPattern As Dictionary(Of Field, String)

	Sub Init()
		TextPattern = New Dictionary(Of Field, String) _
					  From {{Field.ActionText, "[^a-zA-Z\s-()]"},
							{Field.ActionNumber, "[^\d.]"},
							{Field.LoginText, "[^a-zA-Z0-9]"}}

		InputPattern = New Dictionary(Of Field, String) _
					   From {{Field.ActionText, "^[a-zA-Z]{2,15}.*?$"},
							 {Field.ActionNumber, "^[1-9]\d{0,4}(\.\d{0,2})?$"},
							 {Field.LoginText, "^[a-zA-Z][a-zA-Z0-9]{3,10}$"}}
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

	Async Sub Create(form As UserControl, button As Button, type As Type, field As String,
							 table As Table, record As Object())
		button.Enabled = False
		If IsInputTrue(form) Then
			DaoCommon.Create(table, record)
			DataGridUtils.Refresh(table)
			DataGridUtils.SetSelectedRow(field)
			NotifySuccess(type)
		Else
			NotifyError()
		End If
		button.Enabled = True
		Await Task.Delay(1500)
	End Sub

	Async Sub Update(form As UserControl, button As Button, field As String, table As Table,
					 name As String, value As Object, record As Object())
		button.Enabled = False
		If IsInputTrue(form) Then
			DaoCommon.Update(table, name, value, record)
			DataGridUtils.Refresh(table)
			SetSelectedRow(field)
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
			DataGridUtils.Refresh(table)
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

	Sub Validate(condition As Boolean, pic As PictureBox)
		ChangeImage(condition, pic)
	End Sub

	Sub TextBoxUtil(txtbox As TextBox, pattern As String)
		txtbox.Text = Regex.Replace(txtbox.Text, pattern, "")
		txtbox.SelectionStart = txtbox.Text.Length
		txtbox.SelectionLength = 0
	End Sub

	Function Match(text As String, field As Field) As Boolean
		Return Regex.IsMatch(text, InputPattern(field))
	End Function

	Sub ChangeImage(form As UserControl)
		For Each pic In form.Controls.OfType(Of PictureBox)
			ChangeImage(pic.Name.Contains("pic"), pic)
		Next
	End Sub

	Sub ChangeImage(form As UserControl, picLastRestock As PictureBox)
		For Each pic In form.Controls.OfType(Of PictureBox)
			If pic.Name.Contains("pic") Then ChangeImage(pic.Name.Equals(picLastRestock.Name), pic)
		Next
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
		Dim image, correct As Integer
		For Each pic In form.Controls.OfType(Of PictureBox)
			If pic.Name.Contains("pic") Then
				image += 1
				If pic.BackgroundImage.Tag.Equals("Correct") Then correct += 1
			End If
		Next
		Return image = correct
	End Function

	Function ChangeCase(field As String) As String
		Return DataGridView.Rows.Cast(Of DataGridViewRow) _
								.Where(Function(row) row.Cells(2).Value.ToString.ToLower.Equals(field.ToLower)) _
								.Single.Cells(2).Value.ToString
	End Function

	Function GetCategories() As List(Of String)
		Return New List(Of String) _
			   From {"Processed Food", "Condiment",
					 "Beverage", "Flavoring", "Halo-halo",
					 "Add-on", "Essential", "Pancit"}
	End Function

	Function GetMeasurements() As List(Of String)
		Return New List(Of String) _
			   From {"pc", "pcs", "mL", "L",
					 "pack", "packs", "box", "boxes"}
	End Function

	Function GetRoles() As List(Of String)
		Return New List(Of String) _
			   From {"Owner", "Staff"}
	End Function

End Module
