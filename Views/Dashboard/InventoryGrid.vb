Public Class InventoryGrid

	Sub New()
		InitializeComponent()
		DataGridUtils.Init(dgvTable)
		DataGridUtils.Populate(Table.Inventory)
	End Sub

	Public Sub Init()
		DataGridUtils.Init(dgvTable)
		DataGridUtils.ChangeTable(Table.Inventory)
	End Sub

	Private Sub dgvTable_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTable.DataBindingComplete
		dgvTable.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

		dgvTable.Columns.Item(5).DefaultCellStyle.Format = "c"
		dgvTable.Columns.Item(6).DefaultCellStyle.Format = "c"
	End Sub

End Class
