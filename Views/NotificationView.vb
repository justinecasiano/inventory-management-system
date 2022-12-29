
Public Class NotificationView

	Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Await Task.Delay(1000)

		If Me.Opacity > 0 Then
			Me.Opacity -= 0.1
		Else
			Me.Close()
		End If
	End Sub

End Class