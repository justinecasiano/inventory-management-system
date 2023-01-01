Public Interface IDao

	Property DataTable As DataTable
	Property Commands As Commands

	Sub AddParameters(record As Object(), command As OleDb.OleDbCommand)

End Interface
