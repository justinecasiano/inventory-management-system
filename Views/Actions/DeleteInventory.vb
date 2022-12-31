Imports System.Text.RegularExpressions

Public Class DeleteInventory

	Private Property ID As Integer

	Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		btnDelete.Enabled = False
		If CheckInput() Then
			InventoryDao.Delete(ID)
			DataUtils.Refresh(Table.Inventory)
			PresenterCommon.Notify(Notification.Action, Type.DeleteInventorySuccess, Actions.Form)
			Await Task.Delay(1500)
			Actions.CloseForm()
		Else
			PresenterCommon.Notify(Notification.Action, Type.ActionError, Actions.Form)
			Await Task.Delay(1500)
			btnDelete.Enabled = True
		End If
	End Sub

	Private Function CheckInput() As Boolean
		Dim Image = 1, Correct = 0
		If picItem.BackgroundImage.Tag.Equals("Correct") Then
			Correct += 1
		End If
		Return Image = Correct
	End Function

	Private Sub DeleteInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		txtItem_TextChanged(sender, e)
		ID = CInt(GetSelectedRow(0))
		txtItem.Text = GetSelectedRow(2).ToString
	End Sub

	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		DataUtils.TextBoxUtil(txtItem, "[^a-zA-Z\s]")
		DataUtils.Validate(Regex.IsMatch(txtItem.Text, "^[a-zA-Z]{2,15}(\s[a-zA-Z]{2,15})?$") AndAlso
						   IsItemValid(txtItem.Text), picItem)
	End Sub

	Private Function IsItemValid(item As String) As Boolean
		Return InventoryDao.DataTable.Rows.Cast(Of DataRow) _
			   .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
			   .Any
	End Function

End Class
