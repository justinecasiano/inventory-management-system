
Module NotificationUtils

	Property NotificationView As NotificationView
	Property Locations As List(Of Integer)

	Sub Init()
		Locations = New List(Of Integer)
	End Sub

	Sub ShowNotification(notif As UserControl, owner As Form)
		NotificationView = New NotificationView
		GetLocations(notif)
		With NotificationView
			.Controls.Add(notif)
			.Owner = owner
			.Location = owner.Location
			.Top += Locations.Item(0)
			.Left += Locations.Item(1)
			.Show()
		End With
	End Sub

	Sub GetLocations(notif As UserControl)
		Locations.Clear()
		If TypeOf notif Is LoginError OrElse
		   TypeOf notif Is LoginSuccess Then
			Locations.Add(107)
			Locations.Add(197)
		End If
	End Sub

End Module
