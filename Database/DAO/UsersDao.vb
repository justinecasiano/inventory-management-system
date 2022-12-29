Module UsersDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub Init()
		DataTable = New DataTable
		DataTable.TableName = "Users"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Users] ORDER BY [Role]"
			.InsertCommand = "INSERT INTO [Users] ([Role], [Username], [Password], [Remember Me]) VALUES(?, ?, ?, ?)"
			.UpdateCommand = "UPDATE [Users] SET [Role]=?, [Username]=?, [Password]=?, [Remember Me]=? WHERE [Username]=?"
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

End Module
