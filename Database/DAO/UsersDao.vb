
Class UsersDao
	Implements IDao

	Public Property DataTable As DataTable Implements IDao.DataTable
	Public Property Commands As Commands Implements IDao.Commands

	Sub New()
		DataTable = New DataTable
		DataTable.TableName = "Users"
		Commands = New Commands
		With Commands
			.SelectCommand = "SELECT * FROM [Users] ORDER BY [Role]"
			.InsertCommand = "INSERT INTO [Users] ([Role], [Username], [Password]) VALUES(?, ?, ?)"
			.UpdateCommand = "UPDATE [Users] SET [Role]=?, [Username]=?, [Password]=? WHERE [ID]=?"
			.DeleteCommand = "DELETE FROM [Users] WHERE [Username]=?"
		End With
	End Sub

	Public Sub AddParameters(record As Object(), command As OleDb.OleDbCommand) Implements IDao.AddParameters
		With command
			.Parameters.AddWithValue("Role", record(0))
			.Parameters.AddWithValue("Username", record(1))
			.Parameters.AddWithValue("Password", record(2))
		End With
	End Sub

End Class
