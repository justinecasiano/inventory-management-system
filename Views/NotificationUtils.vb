
Module NotificationUtils

	Property NotificationView As NotificationView
	Property NotificationTexts As Dictionary(Of Type, String)

	Sub Init()
		NotificationTexts = New Dictionary(Of Type, String) _
							From {{Type.LoginError, "Incorrect username or password"},
								  {Type.LoginSuccess, "Logged in successfully"},
								  {Type.ActionError, "Fix incorrect or empty field"},
								  {Type.CreateInventorySuccess, "Item created successfully"}}
	End Sub

	Sub ShowNotification(notif As Notification, type As Type, owner As Form)
		GetNotificationData(notif, type, owner)
	End Sub

	Sub GetNotificationData(notif As Notification, type As Type, owner As Form)
		Dim top, left As Integer, color As Color, background As Image, text As String = ""

		If notif = Notification.Login Then
			top = 107
			left = 195
			color = Color.FromArgb(244, 175, 27)
		ElseIf notif = Notification.Action Then
			top = 35
			left = 107
			color = Color.FromArgb(255, 222, 132)
		End If
		background = If(type.ToString.Contains("Error"), My.Resources.notif_error, My.Resources.notif_success)
		text = NotificationTexts.Item(type)

		SetNotificationData(owner, top, left, color, background, text)
	End Sub

	Sub SetNotificationData(owner As Form, top As Integer, left As Integer, color As Color, background As Image, text As String)
		Dim NotificationView As New NotificationView
		With NotificationView
			.Owner = owner
			.Location = owner.Location
			.Top += top
			.Left += left
			.BackColor = color
			.pnlBackground.BackgroundImage = background
			.lblNotification.Text = text
			.Show()
		End With
	End Sub

End Module
