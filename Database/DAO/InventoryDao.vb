
Class InventoryDao
	Implements IDao

	Public Property DataTable As DataTable Implements IDao.DataTable
	Public Property Commands As Commands Implements IDao.Commands

	Sub New()
		DataTable = New DataTable
		DataTable.TableName = "Inventory"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Inventory] ORDER BY [Category]"
			.InsertCommand = "INSERT INTO [Inventory] ([Category], [Item], [Quantity], [Measurement], [Price], [Total Price], [Supplier], [Last Restock]) VALUES(?, ?, ?, ?, ?, ?, ?, ?)"
			.UpdateCommand = "UPDATE [Inventory] SET [Category]=?, [Item]=?, [Quantity]=?, [Measurement]=?, [Price]=?, [Total Price]=?, [Supplier]=?, [Last Restock]=? WHERE [Item]=?"
			.DeleteCommand = "DELETE FROM [Inventory] WHERE [Item]=?"
		End With
	End Sub

	Public Sub AddParameters(record As Object(), command As OleDb.OleDbCommand) Implements IDao.AddParameters
		With command
			.Parameters.AddWithValue("Category", record(0))
			.Parameters.AddWithValue("Item", record(1))
			.Parameters.AddWithValue("Quantity", record(2))
			.Parameters.AddWithValue("Measurement", record(3))
			.Parameters.AddWithValue("Price", record(4))
			.Parameters.AddWithValue("Total Price", record(5))
			.Parameters.AddWithValue("Supplier", record(6))
			.Parameters.AddWithValue("Last Restock", record(7))
		End With
	End Sub

End Class
