
Public Class UpdateInventory

	Private Sub UpdateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		dateLastRestock.Value = Date.Now
		ActionUtils.ChangeImage(Me, picLastRestock)
		cboCategory_DropDown(sender, e)
		cboMeasurement_DropDown(sender, e)
		FillDataFields()
	End Sub

	Private Sub FillDataFields()
		cboCategory.Text = GetSelectedRow(1).ToString
		txtItem.Text = GetSelectedRow(2).ToString
		numQuantity.Value = CDec(GetSelectedRow(3))
		cboMeasurement.Text = GetSelectedRow(4).ToString
		txtPrice.Text = GetSelectedRow(5).ToString
		txtTotalPrice.Text = GetSelectedRow(6).ToString
		txtSupplier.Text = GetSelectedRow(7).ToString
		dateLastRestock.Value = CDate(GetSelectedRow(8))
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		ActionUtils.Update(Me, btnUpdate, txtItem.Text, 2, Table.Inventory, "Item", txtItem.Text,
						   New Object() {cboCategory.SelectedValue, txtItem.Text, numQuantity.Value,
										 cboMeasurement.SelectedValue, txtPrice.Text, txtTotalPrice.Text,
										 txtSupplier.Text, dateLastRestock.Value.ToShortDateString})
	End Sub

	Private Sub cboCategory_DropDown(sender As Object, e As EventArgs) Handles cboCategory.DropDown
		cboCategory.DataSource = GetCategories()
	End Sub

	Private Sub cboMeasurement_DropDown(sender As Object, e As EventArgs) Handles cboMeasurement.DropDown
		cboMeasurement.DataSource = GetMeasurements()
	End Sub

	Private Sub cboCategory_TextChanged(sender As Object, e As EventArgs) Handles cboCategory.TextChanged
		ActionUtils.Validate(cboCategory, picCategory)
	End Sub

	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		ActionUtils.Validate(txtItem, "", "[^a-zA-Z\s-()]", picItem, Field.Item)
		If Not IsItemValid(txtItem.Text) Then
			txtItem.Text = ChangeCase(txtItem.Text, 2)
			SetSelectedRow(txtItem.Text, 2)
			txtItem_TextChanged(sender, e)
			FillDataFields()
		End If
	End Sub

	Private Function IsItemValid(item As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
								 .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
								 .Any OrElse item.Equals(GetSelectedRow(2).ToString)
	End Function

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
