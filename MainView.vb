Public Class MainView

	Sub New()
		InitializeComponent()
		DaoCommon.Init("Provider=Microsoft.ACE.OLEDB.12.0;",
					   "Data Source=..\..\Database\Data\Donya Badiday Mock Database.accdb")
		DaoCommon.Fetch()
		PresenterCommon.Init(Me, New Dictionary(Of View, UserControl) _
							 From {{View.Login, New Login}})
		NotificationUtils.Init()
		PresenterCommon.Switch(View.Login, True)
	End Sub

End Class
