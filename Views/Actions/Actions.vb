Public Class Actions

	Private Shared Property Views As Dictionary(Of Action, UserControl)
	Public Shared Property Form As Actions

	Sub New()
		InitializeComponent()
		Views = New Dictionary(Of Action, UserControl) _
				From {{Action.CreateInventory, New CreateInventory},
					  {Action.UpdateInventory, New UpdateInventory},
					  {Action.DeleteInventory, New DeleteInventory},
					  {Action.CreateUser, New CreateUser}}
	End Sub

	Public Shared Sub Init(action As Action)
		Form = New Actions
		Form.Switch(Views.Item(action))
		Form.ShowDialog()
	End Sub

	Public Shared Sub CloseForm()
		Form.Close()
	End Sub

	Public Sub Switch(view As UserControl)
		Me.Size = view.Size
		Me.Controls.Clear()
		Me.Controls.Add(view)
		Me.Controls.Item(0).Dock = DockStyle.Fill
	End Sub

End Class