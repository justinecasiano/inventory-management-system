
Module InventoryDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub Init()
		DataTable = New DataTable
		DataTable.TableName = "Inventory"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Inventory] ORDER BY [ID]"
			.InsertCommand = "INSERT INTO [Inventory] ([Category], [Item], [Quantity], [Measurement], [Price], [Total Price], [Supplier], [Last Restock]) VALUES(?, ?, ?, ?, ?, ?, ?, ?)"
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

	Sub Create(record As Object())
		Using connection As New OleDb.OleDbConnection(DaoCommon.ConnectionString),
				command As New OleDb.OleDbCommand(Commands.InsertCommand, connection)

			DataTable.Clear()
			AddParameters(record, command)
			connection.Open()
			command.ExecuteNonQuery()
		End Using
	End Sub

	Sub AddParameters(record As Object(), command As OleDb.OleDbCommand)
		With command
			.Parameters.AddWithValue("Category", CType(record(0), String))
			.Parameters.AddWithValue("Item", CType(record(1), String))
			.Parameters.AddWithValue("Quantity", CType(record(2), Integer))
			.Parameters.AddWithValue("Measurement", CType(record(3), String))
			.Parameters.AddWithValue("Price", CType(record(4), Decimal))
			.Parameters.AddWithValue("Total Price", CType(record(5), Decimal))
			.Parameters.AddWithValue("Supplier", CType(record(6), String))
			.Parameters.AddWithValue("Last Restock", CType(record(7), String))
		End With
	End Sub

End Module
