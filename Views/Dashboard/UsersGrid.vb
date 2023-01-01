Public Class UsersGrid

	Sub New()
		InitializeComponent()
		DataGridUtils.Init(dgvTable)
		DataGridUtils.Populate(Table.Users)
	End Sub

	Public Sub Init()
		DataGridUtils.Init(dgvTable)
		DataGridUtils.ChangeTable(Table.Users)
	End Sub

End Class
