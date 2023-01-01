
Module NotificationUtils

	Property NotificationTexts As Dictionary(Of Type, String)
	Property Properties As Dictionary(Of Notification, Integer())

	Sub Init()
		NotificationTexts = New Dictionary(Of Type, String) _
							From {{Type.LoginError, "Incorrect username or password"},
								  {Type.LoginSuccess, "Logged in successfully"},
								  {Type.ActionError, "Fix incorrect or empty field"},
								  {Type.CreateInventorySuccess, "Item created successfully"},
								  {Type.CreateUserSuccess, "User created successfully"}}

		Properties = New Dictionary(Of Notification, Integer()) _
					 From {{Notification.Login, {107, 195, 244, 175, 27}},
						   {Notification.Action, {35, 107, 255, 222, 132}}}
	End Sub

	Sub ShowNotification(notif As Notification, type As Type, owner As Form)
		SetProperties(notif, type, owner)
	End Sub

	Sub SetProperties(notif As Notification, type As Type, owner As Form)
		'refactor
		Dim properties = NotificationUtils.Properties.Item(notif)

		Dim NotificationView As New NotificationView
		With NotificationView
			.Owner = owner
			.Location = owner.Location
			.Top += properties(0)
			.Left += properties(1)
			.BackColor = Color.FromArgb(properties(2), properties(3), properties(4))
			.pnlBackground.BackgroundImage = If(type.ToString.Contains("Error"), My.Resources.notif_error, My.Resources.notif_success)
			.lblNotification.Text = NotificationTexts.Item(type)
			.Show()
		End With
	End Sub

End Module
