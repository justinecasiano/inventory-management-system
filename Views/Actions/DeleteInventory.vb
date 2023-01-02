
Public Class DeleteInventory

	Private Sub DeleteInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		txtItem_TextChanged(sender, e)
		txtItem.Text = GetSelectedRow(2).ToString
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		ActionUtils.Delete(Me, btnDelete, Table.Inventory, "Item", txtItem.Text)
	End Sub

	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		TextBoxUtil(txtItem, TextPattern(Field.ActionText))
		ActionUtils.Validate(Match(txtItem.Text, Field.ActionText) AndAlso
							 IsItemValid(txtItem.Text), picItem)

		If IsItemValid(txtItem.Text) Then
			txtItem.Text = ChangeCase(txtItem.Text)
			SetSelectedRow(txtItem.Text)
		End If
	End Sub

	Function IsItemValid(item As String) As Boolean
		Return DataTable.Rows.Cast(Of DataRow) _
							 .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
							 .Any OrElse item.Equals(GetSelectedRow(2).ToString)
	End Function

End Class
