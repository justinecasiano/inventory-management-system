Public Class Actions

	Private Shared Property Views As Dictionary(Of Action, UserControl)
	Public Shared Property Form As Actions

	Sub New()
		InitializeComponent()
		Views = New Dictionary(Of Action, UserControl) _
				From {{Action.CreateInventory, New CreateInventory},
					  {Action.UpdateInventory, New UpdateInventory},
					  {Action.DeleteInventory, New DeleteInventory}}
	End Sub

	Public Shared Sub Init(action As Action, text As String)
		Form = New Actions
		Form.Switch(Views.Item(action), text)
		Form.ShowDialog()
	End Sub

	Public Shared Sub CloseForm()
		Form.Close()
	End Sub

	Public Sub Switch(view As UserControl, title As String)
		Me.Text = title
		Me.Size = view.Size
		Me.Controls.Clear()
		Me.Controls.Add(view)
		Me.Controls.Item(0).Dock = DockStyle.Fill
	End Sub

End Class