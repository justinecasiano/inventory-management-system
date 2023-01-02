<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteUser
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.picUsername = New System.Windows.Forms.PictureBox()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		CType(Me.picUsername, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel7.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(32, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 25)
		Me.Label2.TabIndex = 34
		Me.Label2.Text = "Username"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'picUsername
		'
		Me.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picUsername.Location = New System.Drawing.Point(378, 49)
		Me.picUsername.Name = "picUsername"
		Me.picUsername.Size = New System.Drawing.Size(30, 29)
		Me.picUsername.TabIndex = 43
		Me.picUsername.TabStop = False
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.txtUsername)
		Me.Panel7.Location = New System.Drawing.Point(162, 44)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(210, 36)
		Me.Panel7.TabIndex = 28
		'
		'txtUsername
		'
		Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsername.Location = New System.Drawing.Point(10, 8)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(188, 22)
		Me.txtUsername.TabIndex = 0
		'
		'btnDelete
		'
		Me.btnDelete.AutoSize = True
		Me.btnDelete.BackColor = System.Drawing.Color.Transparent
		Me.btnDelete.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.action_delete_button
		Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnDelete.FlatAppearance.BorderSize = 0
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(121, 110)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(227, 35)
		Me.btnDelete.TabIndex = 24
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = False
		'
		'DeleteUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Controls.Add(Me.picUsername)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.btnDelete)
		Me.MaximumSize = New System.Drawing.Size(465, 201)
		Me.MinimumSize = New System.Drawing.Size(465, 201)
		Me.Name = "DeleteUser"
		Me.Size = New System.Drawing.Size(465, 201)
		CType(Me.picUsername, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnDelete As Button
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents picUsername As PictureBox
End Class
