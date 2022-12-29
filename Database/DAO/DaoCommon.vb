Module DaoCommon

	Property ConnectionString As String

	Sub Init(provider As String, source As String)
		ConnectionString = provider & source
		InventoryDao.Init()
		UsersDao.Init()
	End Sub

	Sub Fetch()
		InventoryDao.Read()
		UsersDao.Read()
	End Sub

End Module
