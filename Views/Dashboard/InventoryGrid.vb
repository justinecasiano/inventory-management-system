Public Class InventoryGrid

	Sub New()
		InitializeComponent()
		DataUtils.Init(dgvTable)
		DataUtils.Populate(Table.Inventory)
	End Sub

	Public Sub Init()
		DataUtils.Init(dgvTable)
		DataUtils.ChangeTable(Table.Inventory)
	End Sub

	Private Async Sub dgvTable_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTable.DataBindingComplete
		dgvTable.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		dgvTable.Columns.Item(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

		dgvTable.Columns.Item(5).DefaultCellStyle.Format = "c"
		dgvTable.Columns.Item(6).DefaultCellStyle.Format = "c"
		Await Task.Delay(200)
	End Sub

End Class
