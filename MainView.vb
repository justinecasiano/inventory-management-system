Public Class MainView

	Sub New()
		InitializeComponent()
		DaoCommon.Init("Provider=Microsoft.ACE.OLEDB.12.0;",
					   "Data Source=..\..\Database\Data\Donya Badiday Mock Database.accdb")
		DaoCommon.Fetch()
		NotificationUtils.Init()
		PresenterCommon.Init(Me, New Dictionary(Of View, UserControl) _
							 From {{View.Login, New Login},
								  {View.Dashboard, New Dashboard}})
		PresenterCommon.Switch(View.Login, True)
	End Sub

End Class
