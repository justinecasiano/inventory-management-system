<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryGrid
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dgvTable = New System.Windows.Forms.DataGridView()
		CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvTable
		'
		Me.dgvTable.AllowUserToAddRows = False
		Me.dgvTable.AllowUserToDeleteRows = False
		Me.dgvTable.AllowUserToOrderColumns = True
		Me.dgvTable.AllowUserToResizeColumns = False
		Me.dgvTable.AllowUserToResizeRows = False
		Me.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(191, Byte), Integer))
		Me.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(170, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(191, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(170, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvTable.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvTable.EnableHeadersVisualStyles = False
		Me.dgvTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(124, Byte), Integer))
		Me.dgvTable.Location = New System.Drawing.Point(0, 0)
		Me.dgvTable.MultiSelect = False
		Me.dgvTable.Name = "dgvTable"
		Me.dgvTable.ReadOnly = True
		Me.dgvTable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(191, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(170, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(191, Byte), Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(170, Byte), Integer))
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
		Me.dgvTable.RowsDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvTable.ShowCellErrors = False
		Me.dgvTable.ShowCellToolTips = False
		Me.dgvTable.ShowEditingIcon = False
		Me.dgvTable.ShowRowErrors = False
		Me.dgvTable.Size = New System.Drawing.Size(625, 335)
		Me.dgvTable.TabIndex = 24
		'
		'InventoryGrid
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(191, Byte), Integer))
		Me.Controls.Add(Me.dgvTable)
		Me.Name = "InventoryGrid"
		Me.Size = New System.Drawing.Size(625, 335)
		CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents dgvTable As DataGridView
End Class
