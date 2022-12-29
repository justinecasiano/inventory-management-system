<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.pnlMenu = New System.Windows.Forms.Panel()
		Me.pnlUser = New System.Windows.Forms.Panel()
		Me.lblUser = New System.Windows.Forms.Label()
		Me.pnlDashboardView = New System.Windows.Forms.Panel()
		Me.pnlPlaceHolder = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Panel10 = New System.Windows.Forms.Panel()
		Me.pnlDataGridHolder = New System.Windows.Forms.Panel()
		Me.Panel9 = New System.Windows.Forms.Panel()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.btnUsers = New System.Windows.Forms.Button()
		Me.btnInventory = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.pnlMenu.SuspendLayout()
		Me.pnlUser.SuspendLayout()
		Me.pnlDashboardView.SuspendLayout()
		Me.pnlPlaceHolder.SuspendLayout()
		Me.Panel10.SuspendLayout()
		Me.Panel7.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlMenu
		'
		Me.pnlMenu.AutoScroll = True
		Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(27, Byte), Integer))
		Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlMenu.Controls.Add(Me.btnLogout)
		Me.pnlMenu.Controls.Add(Me.btnUsers)
		Me.pnlMenu.Controls.Add(Me.btnInventory)
		Me.pnlMenu.Controls.Add(Me.pnlUser)
		Me.pnlMenu.Controls.Add(Me.Panel1)
		Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
		Me.pnlMenu.Name = "pnlMenu"
		Me.pnlMenu.Size = New System.Drawing.Size(277, 500)
		Me.pnlMenu.TabIndex = 1
		'
		'pnlUser
		'
		Me.pnlUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(39, Byte), Integer))
		Me.pnlUser.Controls.Add(Me.lblUser)
		Me.pnlUser.Controls.Add(Me.PictureBox1)
		Me.pnlUser.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlUser.Location = New System.Drawing.Point(0, 116)
		Me.pnlUser.Name = "pnlUser"
		Me.pnlUser.Size = New System.Drawing.Size(277, 68)
		Me.pnlUser.TabIndex = 7
		'
		'lblUser
		'
		Me.lblUser.BackColor = System.Drawing.Color.Transparent
		Me.lblUser.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 13.0!)
		Me.lblUser.Location = New System.Drawing.Point(0, 42)
		Me.lblUser.Name = "lblUser"
		Me.lblUser.Size = New System.Drawing.Size(277, 26)
		Me.lblUser.TabIndex = 4
		Me.lblUser.Text = "Owner"
		Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlDashboardView
		'
		Me.pnlDashboardView.Controls.Add(Me.Panel10)
		Me.pnlDashboardView.Controls.Add(Me.pnlPlaceHolder)
		Me.pnlDashboardView.Controls.Add(Me.FlowLayoutPanel2)
		Me.pnlDashboardView.Controls.Add(Me.FlowLayoutPanel3)
		Me.pnlDashboardView.Controls.Add(Me.Panel4)
		Me.pnlDashboardView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlDashboardView.Location = New System.Drawing.Point(277, 0)
		Me.pnlDashboardView.Name = "pnlDashboardView"
		Me.pnlDashboardView.Size = New System.Drawing.Size(735, 500)
		Me.pnlDashboardView.TabIndex = 2
		'
		'pnlPlaceHolder
		'
		Me.pnlPlaceHolder.Controls.Add(Me.btnDelete)
		Me.pnlPlaceHolder.Controls.Add(Me.btnUpdate)
		Me.pnlPlaceHolder.Controls.Add(Me.btnCreate)
		Me.pnlPlaceHolder.Controls.Add(Me.Panel7)
		Me.pnlPlaceHolder.Controls.Add(Me.Label1)
		Me.pnlPlaceHolder.Controls.Add(Me.Panel2)
		Me.pnlPlaceHolder.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.pnlPlaceHolder.Location = New System.Drawing.Point(28, 386)
		Me.pnlPlaceHolder.Name = "pnlPlaceHolder"
		Me.pnlPlaceHolder.Size = New System.Drawing.Size(674, 114)
		Me.pnlPlaceHolder.TabIndex = 17
		'
		'Label1
		'
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(86, 36)
		Me.Label1.TabIndex = 19
		Me.Label1.Text = "Search"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.Transparent
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel2.Location = New System.Drawing.Point(0, 36)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(674, 78)
		Me.Panel2.TabIndex = 3
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent
		Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 27)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(28, 473)
		Me.FlowLayoutPanel2.TabIndex = 16
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Transparent
		Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(702, 27)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(33, 473)
		Me.FlowLayoutPanel3.TabIndex = 15
		'
		'Panel4
		'
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(735, 27)
		Me.Panel4.TabIndex = 14
		'
		'Panel10
		'
		Me.Panel10.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_datagrid_background
		Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel10.Controls.Add(Me.pnlDataGridHolder)
		Me.Panel10.Controls.Add(Me.Panel9)
		Me.Panel10.Controls.Add(Me.Panel8)
		Me.Panel10.Controls.Add(Me.Panel6)
		Me.Panel10.Controls.Add(Me.Panel5)
		Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel10.Location = New System.Drawing.Point(28, 27)
		Me.Panel10.Name = "Panel10"
		Me.Panel10.Size = New System.Drawing.Size(674, 359)
		Me.Panel10.TabIndex = 18
		'
		'pnlDataGridHolder
		'
		Me.pnlDataGridHolder.BackColor = System.Drawing.Color.Transparent
		Me.pnlDataGridHolder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlDataGridHolder.Location = New System.Drawing.Point(26, 21)
		Me.pnlDataGridHolder.Name = "pnlDataGridHolder"
		Me.pnlDataGridHolder.Size = New System.Drawing.Size(626, 321)
		Me.pnlDataGridHolder.TabIndex = 21
		'
		'Panel9
		'
		Me.Panel9.BackColor = System.Drawing.Color.Transparent
		Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel9.Location = New System.Drawing.Point(0, 21)
		Me.Panel9.Name = "Panel9"
		Me.Panel9.Size = New System.Drawing.Size(26, 321)
		Me.Panel9.TabIndex = 18
		'
		'Panel8
		'
		Me.Panel8.BackColor = System.Drawing.Color.Transparent
		Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel8.Location = New System.Drawing.Point(652, 21)
		Me.Panel8.Name = "Panel8"
		Me.Panel8.Size = New System.Drawing.Size(22, 321)
		Me.Panel8.TabIndex = 17
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.Transparent
		Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel6.Location = New System.Drawing.Point(0, 342)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(674, 17)
		Me.Panel6.TabIndex = 2
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.Transparent
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel5.Location = New System.Drawing.Point(0, 0)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(674, 21)
		Me.Panel5.TabIndex = 1
		'
		'btnDelete
		'
		Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.btnDelete.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_delete_button
		Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
		Me.btnDelete.FlatAppearance.BorderSize = 0
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(623, 0)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(76, 36)
		Me.btnDelete.TabIndex = 25
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.btnUpdate.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_update_button
		Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
		Me.btnUpdate.FlatAppearance.BorderSize = 0
		Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUpdate.ForeColor = System.Drawing.Color.White
		Me.btnUpdate.Location = New System.Drawing.Point(547, 0)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(76, 36)
		Me.btnUpdate.TabIndex = 24
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = False
		'
		'btnCreate
		'
		Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.btnCreate.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_create_button
		Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Left
		Me.btnCreate.FlatAppearance.BorderSize = 0
		Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreate.ForeColor = System.Drawing.Color.White
		Me.btnCreate.Location = New System.Drawing.Point(471, 0)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(76, 36)
		Me.btnCreate.TabIndex = 23
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = False
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.txtSearch)
		Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel7.Location = New System.Drawing.Point(86, 0)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(385, 36)
		Me.Panel7.TabIndex = 20
		'
		'txtSearch
		'
		Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSearch.Location = New System.Drawing.Point(15, 8)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(352, 22)
		Me.txtSearch.TabIndex = 0
		'
		'btnLogout
		'
		Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(27, Byte), Integer))
		Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.btnLogout.FlatAppearance.BorderSize = 0
		Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 13.0!)
		Me.btnLogout.Image = Global.inventory_management_system.My.Resources.Resources.dashboard_logout
		Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLogout.Location = New System.Drawing.Point(0, 450)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Padding = New System.Windows.Forms.Padding(35, 0, 50, 0)
		Me.btnLogout.Size = New System.Drawing.Size(277, 50)
		Me.btnLogout.TabIndex = 8
		Me.btnLogout.Text = "Logout"
		Me.btnLogout.UseVisualStyleBackColor = False
		'
		'btnUsers
		'
		Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(27, Byte), Integer))
		Me.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnUsers.FlatAppearance.BorderSize = 0
		Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUsers.Image = Global.inventory_management_system.My.Resources.Resources.dashboard_users_button
		Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnUsers.Location = New System.Drawing.Point(0, 229)
		Me.btnUsers.Name = "btnUsers"
		Me.btnUsers.Padding = New System.Windows.Forms.Padding(5, 0, 110, 0)
		Me.btnUsers.Size = New System.Drawing.Size(277, 39)
		Me.btnUsers.TabIndex = 15
		Me.btnUsers.Text = "Users"
		Me.btnUsers.UseVisualStyleBackColor = False
		'
		'btnInventory
		'
		Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(27, Byte), Integer))
		Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
		Me.btnInventory.FlatAppearance.BorderSize = 0
		Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInventory.Image = Global.inventory_management_system.My.Resources.Resources.dashboard_inventory_button
		Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnInventory.Location = New System.Drawing.Point(0, 184)
		Me.btnInventory.Name = "btnInventory"
		Me.btnInventory.Padding = New System.Windows.Forms.Padding(5, 0, 80, 0)
		Me.btnInventory.Size = New System.Drawing.Size(277, 45)
		Me.btnInventory.TabIndex = 13
		Me.btnInventory.Text = "Inventory"
		Me.btnInventory.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_user_label
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
		Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(277, 42)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(28, Byte), Integer))
		Me.Panel1.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_logo
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(277, 116)
		Me.Panel1.TabIndex = 0
		'
		'Dashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Controls.Add(Me.pnlDashboardView)
		Me.Controls.Add(Me.pnlMenu)
		Me.Name = "Dashboard"
		Me.Size = New System.Drawing.Size(1012, 500)
		Me.pnlMenu.ResumeLayout(False)
		Me.pnlUser.ResumeLayout(False)
		Me.pnlDashboardView.ResumeLayout(False)
		Me.pnlPlaceHolder.ResumeLayout(False)
		Me.Panel10.ResumeLayout(False)
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents pnlMenu As Panel
	Friend WithEvents pnlUser As Panel
	Friend WithEvents btnInventory As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnUsers As Button
	Friend WithEvents lblUser As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnLogout As Button
	Friend WithEvents pnlDashboardView As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents pnlPlaceHolder As Panel
	Friend WithEvents Panel10 As Panel
	Friend WithEvents Panel9 As Panel
	Friend WithEvents Panel8 As Panel
	Friend WithEvents Panel6 As Panel
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnCreate As Button
	Friend WithEvents pnlDataGridHolder As Panel
End Class
