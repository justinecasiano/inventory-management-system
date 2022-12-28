﻿Module PresenterCommon

	Property Form As Form
	Property Views As Dictionary(Of View, UserControl)

	Sub Init(form As Form, views As Dictionary(Of View, UserControl))
		PresenterCommon.Form = form
		PresenterCommon.Views = views
	End Sub

	Sub Switch(view As View, loadInBackround As Boolean, Optional windowstate As FormWindowState = FormWindowState.Normal)
		If loadInBackround = True Then
			PresenterCommon.BackgroundLoading()
		End If
		Switch(Views.Item(view), windowstate)
	End Sub

	Sub Switch(view As UserControl, windowState As FormWindowState)
		Form.WindowState = windowState
		Form.Size = view.Size

		Form.Controls.Clear()
		Form.Controls.Add(view)
		view.Dock = DockStyle.Fill
	End Sub

	Async Sub BackgroundLoading()
		Form.Opacity = 0
		Await Task.Delay(2000)
		Form.Opacity = 100
	End Sub

	Async Sub Delay(button As Button)
		button.Enabled = False
		Await Task.Delay(1500)
		button.Enabled = True
	End Sub

End Module