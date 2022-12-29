Module DaoCommon

	Property ConnectionString As String

	Sub Init(provider As String, source As String)
		ConnectionString = provider & source
		UsersDao.Init()
	End Sub

	Sub Fetch()
		UsersDao.Read()
	End Sub

End Module
