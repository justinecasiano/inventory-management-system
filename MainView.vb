Public Class MainView

	Sub New()
		InitializeComponent()
		InitModules()
		PresenterCommon.Switch(View.Login, True)
	End Sub

	Private Sub InitModules()
		DaoCommon.Init("Provider=Microsoft.ACE.OLEDB.12.0;",
					   "Data Source=..\..\Database\Data\Donya Badiday Mock Database.accdb")
		DaoCommon.Fetch()
		PresenterCommon.Init(Me, New Dictionary(Of View, UserControl) _
							 From {{View.Login, New Login},
								   {View.Dashboard, New Dashboard}})
		NotificationUtils.Init()
		ActionUtils.Init()
	End Sub

End Class
