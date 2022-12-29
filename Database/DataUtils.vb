﻿Module DataUtils

	Property DataGrid As DataGridView
	Property CurrentTable As DataTable
	Property BlankTable As DataTable

	Sub Init(dataGrid As DataGridView)
		DataUtils.DataGrid = dataGrid
	End Sub

	Sub ChangeTable(table As Table)
		CurrentTable = If(table = Table.Inventory, InventoryDao.DataTable, UsersDao.DataTable)
		BlankTable = CurrentTable.Copy
		BlankTable.Rows.Clear()
	End Sub

	Sub Populate(dataTable As DataTable)
		DataGrid.DataSource = dataTable
	End Sub

	Sub Populate(table As Table)
		ChangeTable(table)
		Populate(CurrentTable)
	End Sub

	Sub Refresh(table As Table)
		If table = Table.Inventory Then
			InventoryDao.Read()
		Else
			UsersDao.Read()
		End If
		Populate(table)
	End Sub

	Sub Search(query As String)
		query = query.ToLower & "*"

		Dim rows = If(CurrentTable.TableName = "Inventory", SearchInventory(query), SearchUsers(query))

		If rows.Any Then
			Populate(rows.CopyToDataTable)
		Else
			Populate(BlankTable)
		End If
	End Sub

	Function SearchInventory(query As String) As EnumerableRowCollection(Of DataRow)
		Return From row In CurrentTable
			   Where row.Field(Of String)("Category").ToLower Like query Or
					 row.Field(Of String)("Item").ToLower Like query Or
					 row.Field(Of Integer)("Quantity").ToString Like query Or
					 row.Field(Of String)("Measurement").ToLower Like query
			   Select row
	End Function

	Function SearchUsers(query As String) As EnumerableRowCollection(Of DataRow)
		Return From row In CurrentTable
			   Where row.Field(Of String)("Role").ToLower Like query Or
					 row.Field(Of String)("Username").ToLower Like query
			   Select row
	End Function

End Module