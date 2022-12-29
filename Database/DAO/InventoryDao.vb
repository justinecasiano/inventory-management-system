
Module InventoryDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub Init()
		DataTable = New DataTable
		DataTable.TableName = "Inventory"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Inventory] ORDER BY [ID]"
			.InsertCommand = "INSERT INTO [Inventory] ([Category], [Item], [Quantity], [Measurement], [Price], [Total Price], [Supplier], [Last Restock]) VALUES(?, ?, ?, ?, ?, ?, ?)"
			.UpdateCommand = "UPDATE [Inventory] SET [Category]=?, [Item]=?, [Quantity]=?, [Measurement]=?, [Price]=?, [Total Price]=?, [Supplier]=?, [Last Restock]=? WHERE [ID]=?"
			.DeleteCommand = "DELETE FROM [Inventory] WHERE [ID]=?"
		End With
	End Sub

	Sub Read()
		Using connection As New OleDb.OleDbConnection(DaoCommon.ConnectionString),
				command As New OleDb.OleDbCommand(Commands.SelectCommand, connection),
				adapter As New OleDb.OleDbDataAdapter(command)
			adapter.Fill(DataTable)
		End Using
	End Sub

End Module
