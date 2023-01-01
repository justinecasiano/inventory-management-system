<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateInventory
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
		Me.cboCategory = New System.Windows.Forms.ComboBox()
		Me.numQuantity = New System.Windows.Forms.NumericUpDown()
		Me.cboMeasurement = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.dateLastRestock = New System.Windows.Forms.DateTimePicker()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.picTotalPrice = New System.Windows.Forms.PictureBox()
		Me.picLastRestock = New System.Windows.Forms.PictureBox()
		Me.picSupplier = New System.Windows.Forms.PictureBox()
		Me.picPrice = New System.Windows.Forms.PictureBox()
		Me.picMeasurement = New System.Windows.Forms.PictureBox()
		Me.picQuantity = New System.Windows.Forms.PictureBox()
		Me.picItem = New System.Windows.Forms.PictureBox()
		Me.picCategory = New System.Windows.Forms.PictureBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.txtSupplier = New System.Windows.Forms.TextBox()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtItem = New System.Windows.Forms.TextBox()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.txtTotalPrice = New System.Windows.Forms.TextBox()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.txtPrice = New System.Windows.Forms.TextBox()
		CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picLastRestock, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picMeasurement, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCategory, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'cboCategory
		'
		Me.cboCategory.BackColor = System.Drawing.Color.White
		Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCategory.FormattingEnabled = True
		Me.cboCategory.Location = New System.Drawing.Point(164, 53)
		Me.cboCategory.Name = "cboCategory"
		Me.cboCategory.Size = New System.Drawing.Size(148, 29)
		Me.cboCategory.TabIndex = 26
		'
		'numQuantity
		'
		Me.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numQuantity.ForeColor = System.Drawing.Color.Black
		Me.numQuantity.Location = New System.Drawing.Point(162, 144)
		Me.numQuantity.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
		Me.numQuantity.Name = "numQuantity"
		Me.numQuantity.Size = New System.Drawing.Size(76, 29)
		Me.numQuantity.TabIndex = 29
		'
		'cboMeasurement
		'
		Me.cboMeasurement.BackColor = System.Drawing.Color.White
		Me.cboMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboMeasurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboMeasurement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMeasurement.FormattingEnabled = True
		Me.cboMeasurement.Location = New System.Drawing.Point(164, 188)
		Me.cboMeasurement.Name = "cboMeasurement"
		Me.cboMeasurement.Size = New System.Drawing.Size(144, 29)
		Me.cboMeasurement.TabIndex = 32
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(32, 188)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(128, 25)
		Me.Label5.TabIndex = 31
		Me.Label5.Text = "Measurement"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(32, 143)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(128, 25)
		Me.Label6.TabIndex = 33
		Me.Label6.Text = "Quantity"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(32, 98)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 25)
		Me.Label2.TabIndex = 34
		Me.Label2.Text = "Item"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(32, 53)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(128, 25)
		Me.Label3.TabIndex = 35
		Me.Label3.Text = "Category"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label4.ForeColor = System.Drawing.Color.Black
		Me.Label4.Location = New System.Drawing.Point(32, 233)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(128, 25)
		Me.Label4.TabIndex = 37
		Me.Label4.Text = "Price"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label7.ForeColor = System.Drawing.Color.Black
		Me.Label7.Location = New System.Drawing.Point(32, 327)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(128, 25)
		Me.Label7.TabIndex = 39
		Me.Label7.Text = "Supplier"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dateLastRestock
		'
		Me.dateLastRestock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dateLastRestock.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateLastRestock.Location = New System.Drawing.Point(164, 373)
		Me.dateLastRestock.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
		Me.dateLastRestock.MinDate = New Date(2022, 12, 1, 0, 0, 0, 0)
		Me.dateLastRestock.Name = "dateLastRestock"
		Me.dateLastRestock.Size = New System.Drawing.Size(131, 29)
		Me.dateLastRestock.TabIndex = 40
		Me.dateLastRestock.Value = New Date(2022, 12, 22, 0, 0, 0, 0)
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label8.ForeColor = System.Drawing.Color.Black
		Me.Label8.Location = New System.Drawing.Point(32, 373)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(128, 25)
		Me.Label8.TabIndex = 41
		Me.Label8.Text = "Last Restock"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(32, 280)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 25)
		Me.Label1.TabIndex = 50
		Me.Label1.Text = "Total Price"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'PictureBox2
		'
		Me.PictureBox2.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.peso_sign
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox2.Location = New System.Drawing.Point(162, 276)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(30, 29)
		Me.PictureBox2.TabIndex = 56
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.peso_sign
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(162, 229)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(30, 29)
		Me.PictureBox1.TabIndex = 55
		Me.PictureBox1.TabStop = False
		'
		'picTotalPrice
		'
		Me.picTotalPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picTotalPrice.Location = New System.Drawing.Point(378, 280)
		Me.picTotalPrice.Name = "picTotalPrice"
		Me.picTotalPrice.Size = New System.Drawing.Size(30, 29)
		Me.picTotalPrice.TabIndex = 51
		Me.picTotalPrice.TabStop = False
		'
		'picLastRestock
		'
		Me.picLastRestock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picLastRestock.Location = New System.Drawing.Point(378, 373)
		Me.picLastRestock.Name = "picLastRestock"
		Me.picLastRestock.Size = New System.Drawing.Size(30, 29)
		Me.picLastRestock.TabIndex = 48
		Me.picLastRestock.TabStop = False
		'
		'picSupplier
		'
		Me.picSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picSupplier.Location = New System.Drawing.Point(378, 327)
		Me.picSupplier.Name = "picSupplier"
		Me.picSupplier.Size = New System.Drawing.Size(30, 29)
		Me.picSupplier.TabIndex = 47
		Me.picSupplier.TabStop = False
		'
		'picPrice
		'
		Me.picPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picPrice.Location = New System.Drawing.Point(378, 233)
		Me.picPrice.Name = "picPrice"
		Me.picPrice.Size = New System.Drawing.Size(30, 29)
		Me.picPrice.TabIndex = 46
		Me.picPrice.TabStop = False
		'
		'picMeasurement
		'
		Me.picMeasurement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picMeasurement.Location = New System.Drawing.Point(378, 188)
		Me.picMeasurement.Name = "picMeasurement"
		Me.picMeasurement.Size = New System.Drawing.Size(30, 29)
		Me.picMeasurement.TabIndex = 45
		Me.picMeasurement.TabStop = False
		'
		'picQuantity
		'
		Me.picQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picQuantity.Location = New System.Drawing.Point(378, 144)
		Me.picQuantity.Name = "picQuantity"
		Me.picQuantity.Size = New System.Drawing.Size(30, 29)
		Me.picQuantity.TabIndex = 44
		Me.picQuantity.TabStop = False
		'
		'picItem
		'
		Me.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picItem.Location = New System.Drawing.Point(378, 98)
		Me.picItem.Name = "picItem"
		Me.picItem.Size = New System.Drawing.Size(30, 29)
		Me.picItem.TabIndex = 43
		Me.picItem.TabStop = False
		'
		'picCategory
		'
		Me.picCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picCategory.Location = New System.Drawing.Point(378, 53)
		Me.picCategory.Name = "picCategory"
		Me.picCategory.Size = New System.Drawing.Size(30, 29)
		Me.picCategory.TabIndex = 42
		Me.picCategory.TabStop = False
		'
		'Panel2
		'
		Me.Panel2.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel2.Controls.Add(Me.txtSupplier)
		Me.Panel2.Location = New System.Drawing.Point(162, 322)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(210, 36)
		Me.Panel2.TabIndex = 38
		'
		'txtSupplier
		'
		Me.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSupplier.Location = New System.Drawing.Point(10, 8)
		Me.txtSupplier.Name = "txtSupplier"
		Me.txtSupplier.Size = New System.Drawing.Size(188, 22)
		Me.txtSupplier.TabIndex = 0
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.txtItem)
		Me.Panel7.Location = New System.Drawing.Point(162, 93)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(210, 36)
		Me.Panel7.TabIndex = 28
		'
		'txtItem
		'
		Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtItem.Location = New System.Drawing.Point(10, 8)
		Me.txtItem.Name = "txtItem"
		Me.txtItem.Size = New System.Drawing.Size(188, 22)
		Me.txtItem.TabIndex = 0
		'
		'btnCreate
		'
		Me.btnCreate.AutoSize = True
		Me.btnCreate.BackColor = System.Drawing.Color.Transparent
		Me.btnCreate.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.action_create_button
		Me.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnCreate.FlatAppearance.BorderSize = 0
		Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreate.ForeColor = System.Drawing.Color.White
		Me.btnCreate.Location = New System.Drawing.Point(121, 439)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(227, 35)
		Me.btnCreate.TabIndex = 24
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = False
		'
		'Panel3
		'
		Me.Panel3.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel3.Controls.Add(Me.txtTotalPrice)
		Me.Panel3.Location = New System.Drawing.Point(193, 273)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(155, 36)
		Me.Panel3.TabIndex = 29
		'
		'txtTotalPrice
		'
		Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtTotalPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalPrice.Location = New System.Drawing.Point(10, 8)
		Me.txtTotalPrice.Name = "txtTotalPrice"
		Me.txtTotalPrice.Size = New System.Drawing.Size(135, 22)
		Me.txtTotalPrice.TabIndex = 0
		'
		'Panel4
		'
		Me.Panel4.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel4.Controls.Add(Me.txtPrice)
		Me.Panel4.Location = New System.Drawing.Point(193, 226)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(155, 36)
		Me.Panel4.TabIndex = 30
		'
		'txtPrice
		'
		Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPrice.Location = New System.Drawing.Point(10, 8)
		Me.txtPrice.Name = "txtPrice"
		Me.txtPrice.Size = New System.Drawing.Size(135, 22)
		Me.txtPrice.TabIndex = 0
		'
		'CreateInventory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.picTotalPrice)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.picLastRestock)
		Me.Controls.Add(Me.picSupplier)
		Me.Controls.Add(Me.picPrice)
		Me.Controls.Add(Me.picMeasurement)
		Me.Controls.Add(Me.picQuantity)
		Me.Controls.Add(Me.picItem)
		Me.Controls.Add(Me.picCategory)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.dateLastRestock)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.cboMeasurement)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.numQuantity)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.cboCategory)
		Me.Controls.Add(Me.btnCreate)
		Me.MaximumSize = New System.Drawing.Size(465, 530)
		Me.MinimumSize = New System.Drawing.Size(465, 530)
		Me.Name = "CreateInventory"
		Me.Size = New System.Drawing.Size(465, 530)
		CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picLastRestock, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSupplier, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picMeasurement, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCategory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnCreate As Button
	Friend WithEvents cboCategory As ComboBox
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtItem As TextBox
	Friend WithEvents numQuantity As NumericUpDown
	Friend WithEvents cboMeasurement As ComboBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents txtSupplier As TextBox
	Friend WithEvents dateLastRestock As DateTimePicker
	Friend WithEvents Label8 As Label
	Friend WithEvents picCategory As PictureBox
	Friend WithEvents picItem As PictureBox
	Friend WithEvents picQuantity As PictureBox
	Friend WithEvents picMeasurement As PictureBox
	Friend WithEvents picPrice As PictureBox
	Friend WithEvents picSupplier As PictureBox
	Friend WithEvents picLastRestock As PictureBox
	Friend WithEvents picTotalPrice As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents txtTotalPrice As TextBox
	Friend WithEvents Panel4 As Panel
	Friend WithEvents txtPrice As TextBox
End Class
