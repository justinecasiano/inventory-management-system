
Module InventoryDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub Init()
		DataTable = New DataTable
		DataTable.TableName = "Inventory"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Inventory] ORDER BY [Category]"
			.InsertCommand = "INSERT INTO [Inventory] ([Category], [Item], [Quantity], [Measurement], [Price], [Total Price], [Supplier], [Last Restock]) VALUES(?, ?, ?, ?, ?, ?, ?, ?)"
			.UpdateCommand = "UPDATE [Inventory] SET [Category]=?, [Item]=?, [Quantity]=?, [Measurement]=?, [Price]=?, [Total Price]=?, [Supplier]=?, [Last Restock]=? WHERE [ID]=?"
			.DeleteCommand = "DELETE FROM [Inventory] WHERE [Item]=?"
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

			AddParameters(record, command)
			connection.Open()
			command.ExecuteNonQuery()
		End Using
	End Sub

	Sub Update(record As Object())
		Using connection As New OleDb.OleDbConnection(DaoCommon.ConnectionString),
				command As New OleDb.OleDbCommand(Commands.UpdateCommand, connection)

			AddParameters(record, command)
			connection.Open()
			With command
				.Parameters.AddWithValue("ID", record(8))
				.ExecuteNonQuery()
			End With
		End Using
	End Sub

	Sub Delete(item As Object)
		Using connection As New OleDb.OleDbConnection(DaoCommon.ConnectionString),
				command As New OleDb.OleDbCommand(Commands.DeleteCommand, connection)

			connection.Open()
			With command
				.Parameters.AddWithValue("Item", item)
				.ExecuteNonQuery()
			End With
		End Using
	End Sub

	Sub AddParameters(record As Object(), command As OleDb.OleDbCommand)
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

End Module
