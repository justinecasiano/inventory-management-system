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

	Private Sub dgvTable_BindingContextChanged(sender As Object, e As EventArgs) Handles dgvTable.DataBindingComplete
		dgvTable.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
	End Sub

End Class
