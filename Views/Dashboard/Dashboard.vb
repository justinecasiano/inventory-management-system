﻿
Public Class Dashboard

	Private Property Grids As Dictionary(Of Grid, UserControl)
	Private Property CurrentGrid As Grid

	Sub New()
		InitializeComponent()
		Grids = New Dictionary(Of Grid, UserControl) _
				From {{Grid.Inventory, New InventoryGrid}, {Grid.Users, New UsersGrid}}
		CurrentGrid = Grid.None
	End Sub

	Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
		Switch(Grid.Inventory)
	End Sub

	Private Sub Switch(grid As Grid)
		If Not CurrentGrid = grid Then
			Dim newGrid = Grids.Item(grid)
			Init(grid, newGrid)
			pnlDataGridHolder.Controls.Clear()
			pnlDataGridHolder.Controls.Add(newGrid)
			pnlDataGridHolder.Controls.Item(0).Dock = DockStyle.Fill
			CurrentGrid = grid
		End If
	End Sub

	Private Sub Init(grid As Grid, newGrid As UserControl)
		Select Case grid
			Case Grid.Inventory
				CType(newGrid, InventoryGrid).Init()
			Case Grid.Users
				CType(newGrid, UsersGrid).Init()
		End Select
	End Sub

	Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnUsers.Click, btnInventory.Click
		If CType(sender, Button).Name.Equals("btnUsers") Then
			Switch(Grid.Users)
		Else
			Switch(Grid.Inventory)
		End If
	End Sub

	Private Sub btnAction(sender As Object, e As EventArgs) Handles btnCreate.Click, btnUpdate.Click, btnDelete.Click
		If CurrentGrid = Grid.Inventory Then
			If CType(sender, Button).Name.Equals("btnCreate") Then
				Actions.Init(Action.CreateInventory, "Create a new item")
			End If
		End If
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		If MessageBox.Show(PresenterCommon.Form, "Are you sure you want to logout?", "Logout",
						   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
			PresenterCommon.Form.Close()
		End If
	End Sub

	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		DataUtils.Search(txtSearch.Text)
	End Sub
End Class