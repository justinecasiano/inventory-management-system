
Imports System.Text.RegularExpressions

Module DataGridUtils

	Property DataGridView As DataGridView
	Property DataTable As DataTable
	Property BlankDataTable As DataTable
	Property Table As Table
	Property Role As String
	Property Query As String

	Sub Init(dataGrid As DataGridView)
		DataGridView = dataGrid
	End Sub

	Sub Populate(table As Table)
		ChangeTable(table)
		Populate(DataTable)
	End Sub

	Sub ChangeTable(table As Table)
		DataTable = DaoCommon.DAOs.Item(table).DataTable
		BlankDataTable = DataTable.Copy
		BlankDataTable.Rows.Clear()
	End Sub

	Sub Populate(dataTable As DataTable)
		DataGridView.DataSource = dataTable
	End Sub

	Sub Refresh(table As Table)
		DataTable.Clear()
		DaoCommon.Fetch(table)
		Populate(table)
	End Sub

	Sub Search(text As String)
		Query = text
		Dim rows = If(DataTable.TableName = "Inventory", SearchInventory(Query), SearchUsers(Query))

		If rows.Any Then
			Populate(rows.CopyToDataTable)
		Else
			Populate(BlankDataTable)
		End If
	End Sub

	Function SearchInventory(query As String) As EnumerableRowCollection(Of DataRow)
		Return From row In DataTable
			   Where IsMatch(row, "String", "Category") OrElse
					 IsMatch(row, "String", "Item") OrElse
					 IsMatch(row, "Integer", "Quantity") OrElse
					 IsMatch(row, "String", "Measurement")
			   Select row
	End Function

	Function SearchUsers(query As String) As EnumerableRowCollection(Of DataRow)
		Return From row In DataTable
			   Where IsMatch(row, "String", "Role") OrElse
					 IsMatch(row, "String", "Username")
			   Select row
	End Function

	Function IsMatch(row As DataRow, type As String, column As String) As Boolean
		Dim record = If(type.Equals("Integer"), row.Field(Of Integer)(column).ToString, row.Field(Of String)(column).ToLower)
		Query = $"^.*?{Query.ToLower}.*?$"
		Return Regex.IsMatch(record, Query)
	End Function

	Function GetSelectedRow(cell As Integer) As Object
		Return DataGridView.SelectedRows(0).Cells(cell).Value
	End Function

	Sub SetSelectedRow(field As String, cell As Integer)
		DataGridView.CurrentCell =
			DataGridView.Rows.Cast(Of DataGridViewRow) _
							 .Where(Function(row) row.Cells(cell).Value.Equals(field)) _
							 .Single.Cells(0)
	End Sub

End Module
