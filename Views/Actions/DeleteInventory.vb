
Public Class DeleteInventory

	Private Sub DeleteInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		txtItem_TextChanged(sender, e)
		txtItem.Text = GetSelectedRow(2).ToString
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		ActionUtils.Delete(Me, btnDelete, Table.Inventory, "Item", txtItem.Text)
	End Sub


	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		ActionUtils.Validate(txtItem, "", "[^a-zA-Z\s-()]", picItem, Field.Item)
	End Sub

End Class
