Public Class MainView

	Sub New()
		InitializeComponent()
		PresenterCommon.Init(Me, New Dictionary(Of View, UserControl) _
							 From {{View.Login, New Login}})
		PresenterCommon.Switch(View.Login, True)
	End Sub

End Class
