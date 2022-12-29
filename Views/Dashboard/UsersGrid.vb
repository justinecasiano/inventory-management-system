Public Class UsersGrid

	Sub New()
		InitializeComponent()
		DataUtils.Init(dgvTable)
		DataUtils.Populate(Table.Users)
	End Sub

	Public Sub Init()
		DataUtils.Init(dgvTable)
		DataUtils.ChangeTable(Table.Users)
	End Sub

End Class
