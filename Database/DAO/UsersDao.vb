Module UsersDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub Init()
		DataTable = New DataTable
		DataTable.TableName = "Users"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Users] ORDER BY [Role]"
			.InsertCommand = "INSERT INTO [Users] ([Role], [Username], [Password]) VALUES(?, ?, ?)"
			.UpdateCommand = "UPDATE [Users] SET [Role]=?, [Username]=?, [Password]=?, WHERE [Username]=?"
			.DeleteCommand = "DELETE FROM [Users] WHERE [Username]='?'"
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

	Sub AddParameters(record As Object(), command As OleDb.OleDbCommand)
		With command
			.Parameters.AddWithValue("Role", record(0))
			.Parameters.AddWithValue("Username", record(1))
			.Parameters.AddWithValue("Password", record(2))
		End With
	End Sub

End Module
