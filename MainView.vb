
Public Class MainView

	Sub New()
		InitializeComponent()
		InitModules()
		CheckAccount()
		PresenterCommon.Switch(View.Login, True)
	End Sub

	Private Sub InitModules()
		DaoCommon.Init("Provider=Microsoft.ACE.OLEDB.12.0;",
					   "Data Source=..\..\Database\Data\Donya Badiday Database.accdb")
		DaoCommon.Fetch()
		PresenterCommon.Init(Me, New Dictionary(Of View, UserControl) _
							 From {{View.Login, New Login},
								   {View.Dashboard, New Dashboard}})
		NotificationUtils.Init()
		ActionUtils.Init()
	End Sub

	Private Sub CheckAccount()
		If Not HasDefaultAccount() Then
			MakeDefaultAccount()
			DaoCommon.Fetch(Table.Users)
		End If
	End Sub

	Private Function HasDefaultAccount() As Boolean
		Return DAOs.Item(Table.Users).DataTable.Rows _
						.Cast(Of DataRow) _
						.Where(Function(row) row.Field(Of String)("Username").Equals("admin")) _
						.Any
	End Function

	Private Sub MakeDefaultAccount()
		DaoCommon.Create(Table.Users, New Object() {"Owner", "admin", "admin123"})
	End Sub

End Class
