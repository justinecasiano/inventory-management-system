
Public Class CreateInventory

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		dateLastRestock.Value = Date.Now
		ActionUtils.ChangeImage(Me, picLastRestock)
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		ActionUtils.Create(Me, btnCreate, Type.CreateInventorySuccess, txtItem.Text, 2, Table.Inventory,
						   New Object() {cboCategory.SelectedValue, txtItem.Text, numQuantity.Value,
										 cboMeasurement.SelectedValue, txtPrice.Text, txtTotalPrice.Text,
										 txtSupplier.Text, dateLastRestock.Value.ToShortDateString})
		txtItem_TextChanged(sender, e)
	End Sub

	Private Sub cboCategory_DropDown(sender As Object, e As EventArgs) Handles cboCategory.DropDown
		cboCategory.DataSource = ActionUtils.GetCategories
	End Sub

	Private Sub cboMeasurement_DropDown(sender As Object, e As EventArgs) Handles cboMeasurement.DropDown
		cboMeasurement.DataSource = ActionUtils.GetMeasurements
	End Sub

	Private Sub cboCategory_TextChanged(sender As Object, e As EventArgs) Handles cboCategory.TextChanged
		ActionUtils.Validate(cboCategory, picCategory)
	End Sub

	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		ActionUtils.Validate(txtItem, "", "[^a-zA-Z\s-()]", picItem, Field.Item)
	End Sub

	Private Sub numQuantity_TextChanged(sender As Object, e As EventArgs) Handles numQuantity.TextChanged
		ActionUtils.Validate(numQuantity, picQuantity)
	End Sub

	Private Sub cboMeasurement_TextChanged(sender As Object, e As EventArgs) Handles cboMeasurement.TextChanged
		ActionUtils.Validate(cboMeasurement, picMeasurement)
	End Sub

	Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
		ActionUtils.Validate(txtPrice, "", "[^\d.]", picPrice, Field.Price)
		If txtPrice.TextLength > 0 Then
			txtTotalPrice_TextChanged(sender, e)
		End If
	End Sub

	Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
		ActionUtils.Validate(txtTotalPrice, txtPrice.Text, "[^\d.]", picTotalPrice, Field.TotalPrice)
	End Sub

	Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
		ActionUtils.Validate(txtSupplier, "", "[^a-zA-Z\s]", picSupplier, Field.Supplier)
	End Sub

End Class
