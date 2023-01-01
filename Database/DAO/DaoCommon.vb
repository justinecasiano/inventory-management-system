Module DaoCommon

	Property ConnectionString As String
	Property DAOs As Dictionary(Of Table, IDao)

	Sub Init(provider As String, source As String)
		ConnectionString = provider & source
		DAOs = New Dictionary(Of Table, IDao) _
			   From {{Table.Inventory, New InventoryDao},
					 {Table.Users, New UsersDao}}
	End Sub

	Sub Fetch()
		For Each dao In DAOs.Values
			Using connection As New OleDb.OleDbConnection(ConnectionString),
				command As New OleDb.OleDbCommand(dao.Commands.SelectCommand, connection),
				adapter As New OleDb.OleDbDataAdapter(command)

				adapter.Fill(dao.DataTable)
			End Using
		Next
	End Sub

	Sub Fetch(table As Table)
		Dim dao = DAOs.Item(table)
		Using connection As New OleDb.OleDbConnection(ConnectionString),
			command As New OleDb.OleDbCommand(dao.Commands.SelectCommand, connection),
			adapter As New OleDb.OleDbDataAdapter(command)

			adapter.Fill(dao.DataTable)
		End Using
	End Sub

	Sub Create(table As Table, record As Object())
		Dim dao = DAOs.Item(table)
		Using connection As New OleDb.OleDbConnection(ConnectionString),
				command As New OleDb.OleDbCommand(dao.Commands.InsertCommand, connection)

			dao.AddParameters(record, command)
			connection.Open()
			command.ExecuteNonQuery()
			DataGridUtils.Refresh(table)
		End Using
	End Sub

	Sub Update(table As Table, name As String, value As Object, record As Object())
		Dim dao = DAOs.Item(table)
		Using connection As New OleDb.OleDbConnection(ConnectionString),
				command As New OleDb.OleDbCommand(dao.Commands.UpdateCommand, connection)

			dao.AddParameters(record, command)
			connection.Open()
			With command
				.Parameters.AddWithValue(name, value)
				.ExecuteNonQuery()
			End With
		End Using
	End Sub


	Sub Delete(table As Table, name As String, value As Object)
		Dim dao = DAOs.Item(table)
		Using connection As New OleDb.OleDbConnection(ConnectionString),
				command As New OleDb.OleDbCommand(dao.Commands.DeleteCommand, connection)

			connection.Open()
			With command
				.Parameters.AddWithValue(name, value)
				.ExecuteNonQuery()
			End With
		End Using
	End Sub

End Module
