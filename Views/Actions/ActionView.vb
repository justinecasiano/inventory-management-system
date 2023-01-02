Public Class ActionView

	Sub New()
		InitializeComponent()
		ActionUtils.Views = New Dictionary(Of Action, UserControl) _
							From {{Action.CreateInventory, New CreateInventory},
								  {Action.UpdateInventory, New UpdateInventory},
								  {Action.DeleteInventory, New DeleteInventory},
								  {Action.CreateUser, New CreateUser},
								  {Action.UpdateUser, New UpdateUser},
								  {Action.DeleteUser, New DeleteUser}}
	End Sub

End Class