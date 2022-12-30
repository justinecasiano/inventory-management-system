Imports System.Text.RegularExpressions

Public Class CreateInventory

	Private Property Categories As List(Of String)
	Private Property Measurements As List(Of String)

	Sub New()
		InitializeComponent()
		GetCategories()
		GetMeasurements()
		dateLastRestock.Value = Date.Now
		dateLastRestock.MinDate = Date.Now
	End Sub

	Private Async Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		btnCreate.Enabled = False
		If CheckInput() Then
			InventoryDao.Create(New Object() {cboCategory.SelectedValue, txtItem.Text, numQuantity.Value,
											  cboMeasurement.SelectedValue, txtPrice.Text, txtTotalPrice.Text,
											  txtSupplier.Text, dateLastRestock.Value.ToShortDateString})
			DataUtils.Refresh(Table.Inventory)
			PresenterCommon.Notify(Notification.Action, Type.CreateInventorySuccess, Actions.Form)
		Else
			PresenterCommon.Notify(Notification.Action, Type.ActionError, Actions.Form)
		End If
		Await Task.Delay(1500)
		txtItem_TextChanged(sender, e)
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

	Private Sub GetCategories()
		Categories = InventoryDao.DataTable.Rows.Cast(Of DataRow) _
					 .Select(Function(row) row.Field(Of String)("Category")) _
					 .Distinct() _
					 .ToList()
	End Sub

	Private Sub GetMeasurements()
		Measurements = InventoryDao.DataTable.Rows.Cast(Of DataRow) _
					   .Select(Function(row) row.Field(Of String)("Measurement")) _
					   .Distinct() _
					   .ToList()
	End Sub

	Private Sub cboCategory_DropDown(sender As Object, e As EventArgs) Handles cboCategory.DropDown
		cboCategory.DataSource = Categories
	End Sub

	Private Sub cboMeasurement_DropDown(sender As Object, e As EventArgs) Handles cboMeasurement.DropDown
		cboMeasurement.DataSource = Measurements
	End Sub

	Private Sub CreateInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
		For Each control In Controls
			If TypeOf control Is PictureBox Then
				Dim pic = CType(control, PictureBox)
				If pic.Name.Contains("pic") Then
					DataUtils.Validate(pic.Name.Equals(picLastRestock.Name), pic)
				End If
			End If
		Next
	End Sub

	Private Sub cboCategory_TextChanged(sender As Object, e As EventArgs) Handles cboCategory.TextChanged
		DataUtils.Validate(cboCategory.SelectedValue IsNot Nothing AndAlso
						   cboCategory.SelectedValue.ToString.Length > 0, picCategory)
	End Sub

	Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged
		DataUtils.TextBoxUtil(txtItem, "[^a-zA-Z\s]")
		DataUtils.Validate(Regex.IsMatch(txtItem.Text, "^[a-zA-Z]{2,15}(\s[a-zA-Z]{2,15})?$") AndAlso
						   IsItemValid(txtItem.Text), picItem)
	End Sub

	Private Function IsItemValid(item As String) As Boolean
		Return Not InventoryDao.DataTable.Rows.Cast(Of DataRow) _
				   .Where(Function(row) row.Field(Of String)("Item").ToLower.Equals(item.ToLower)) _
				   .Any
	End Function

	Private Sub numQuantity_TextChanged(sender As Object, e As EventArgs) Handles numQuantity.TextChanged
		DataUtils.Validate(numQuantity.Value > 0, picQuantity)
	End Sub

	Private Sub cboMeasurement_TextChanged(sender As Object, e As EventArgs) Handles cboMeasurement.TextChanged
		DataUtils.Validate(cboMeasurement.SelectedValue IsNot Nothing AndAlso
						   cboMeasurement.SelectedValue.ToString.Length > 0, picMeasurement)
	End Sub

	Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
		DataUtils.TextBoxUtil(txtPrice, "[^\d.]")
		DataUtils.Validate(Regex.IsMatch(txtPrice.Text, "^[1-9]\d{0,4}(\.\d{0,2})?$"), picPrice)
		If txtPrice.TextLength > 0 Then
			txtTotalPrice_TextChanged(sender, e)
		End If
	End Sub

	Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
		DataUtils.TextBoxUtil(txtTotalPrice, "[^\d.]")
		DataUtils.Validate(Regex.IsMatch(txtTotalPrice.Text, "^[1-9]\d{0,4}(\.\d{0,2})?$") AndAlso
						   txtPrice.TextLength > 0 AndAlso
						   Not txtPrice.Text.Chars(0) = CChar("0") AndAlso
						   Decimal.Parse(txtTotalPrice.Text) >= Decimal.Parse(txtPrice.Text), picTotalPrice)
	End Sub

	Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
		TextBoxUtil(txtSupplier, "[^a-zA-Z\s]")
		DataUtils.Validate(Regex.IsMatch(txtSupplier.Text, "^[a-zA-Z]{2,15}(\s[a-zA-Z]{2,15})?(\s[a-zA-Z]{2,15})?$"), picSupplier)
	End Sub

End Class
