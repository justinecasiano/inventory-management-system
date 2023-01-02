
Public Class CreateInventory

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		dateLastRestock.Value = Date.Now
		ChangeImage(Me, picLastRestock)
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		ActionUtils.Create(Me, btnCreate, Type.CreateInventorySuccess, txtItem.Text, Table.Inventory,
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
		TextBoxUtil(txtItem, TextPattern(Field.ActionText))
		ActionUtils.Validate(match(txtItem.Text, Field.ActionText) AndAlso
							 IsItemValid(txtItem.Text), picItem)
	End Sub

	Function IsItemValid(item As String) As Boolean
		Return Not DataTable.Rows.Cast(Of DataRow) _
								 .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
								 .Any
	End Function

	Private Sub numQuantity_TextChanged(sender As Object, e As EventArgs) Handles numQuantity.TextChanged
		ActionUtils.Validate(numQuantity, picQuantity)
	End Sub

	Private Sub cboMeasurement_TextChanged(sender As Object, e As EventArgs) Handles cboMeasurement.TextChanged
		ActionUtils.Validate(cboMeasurement, picMeasurement)
	End Sub

	Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
		TextBoxUtil(txtPrice, TextPattern(Field.ActionNumber))
		ActionUtils.Validate(Match(txtPrice.Text, Field.ActionNumber), picPrice)
		If txtPrice.TextLength > 0 Then
			txtTotalPrice_TextChanged(sender, e)
		End If
	End Sub

	Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
		TextBoxUtil(txtTotalPrice, TextPattern(Field.ActionNumber))
		ActionUtils.Validate(Match(txtTotalPrice.Text, Field.ActionNumber) AndAlso
							 txtPrice.TextLength > 0 AndAlso
							 Not txtPrice.Text.Chars(0) = CChar("0") AndAlso
							 Decimal.Parse(txtTotalPrice.Text) >= Decimal.Parse(txtPrice.Text), picTotalPrice)
	End Sub

	Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
		TextBoxUtil(txtSupplier, TextPattern(Field.ActionText))
		ActionUtils.Validate(Match(txtSupplier.Text, Field.ActionText), picSupplier)
	End Sub

End Class
