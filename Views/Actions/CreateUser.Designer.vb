<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateUser
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
		Me.cboRole = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.picUsername = New System.Windows.Forms.PictureBox()
		Me.picRole = New System.Windows.Forms.PictureBox()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.picPassword = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		CType(Me.picUsername, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picRole, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel7.SuspendLayout()
		CType(Me.picPassword, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'cboRole
		'
		Me.cboRole.BackColor = System.Drawing.Color.White
		Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboRole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboRole.FormattingEnabled = True
		Me.cboRole.Location = New System.Drawing.Point(164, 53)
		Me.cboRole.Name = "cboRole"
		Me.cboRole.Size = New System.Drawing.Size(148, 29)
		Me.cboRole.TabIndex = 26
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(32, 98)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(128, 25)
		Me.Label2.TabIndex = 34
		Me.Label2.Text = "Username"
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
		Me.Label3.Text = "Role"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'picUsername
		'
		Me.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picUsername.Location = New System.Drawing.Point(378, 98)
		Me.picUsername.Name = "picUsername"
		Me.picUsername.Size = New System.Drawing.Size(30, 29)
		Me.picUsername.TabIndex = 43
		Me.picUsername.TabStop = False
		'
		'picRole
		'
		Me.picRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picRole.Location = New System.Drawing.Point(378, 53)
		Me.picRole.Name = "picRole"
		Me.picRole.Size = New System.Drawing.Size(30, 29)
		Me.picRole.TabIndex = 42
		Me.picRole.TabStop = False
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.txtUsername)
		Me.Panel7.Location = New System.Drawing.Point(162, 93)
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
		Me.btnCreate.Location = New System.Drawing.Point(121, 215)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(227, 35)
		Me.btnCreate.TabIndex = 24
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = False
		'
		'picPassword
		'
		Me.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picPassword.Location = New System.Drawing.Point(378, 147)
		Me.picPassword.Name = "picPassword"
		Me.picPassword.Size = New System.Drawing.Size(30, 29)
		Me.picPassword.TabIndex = 46
		Me.picPassword.TabStop = False
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(32, 147)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 25)
		Me.Label1.TabIndex = 45
		Me.Label1.Text = "Password"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Panel1
		'
		Me.Panel1.BackgroundImage = Global.inventory_management_system.My.Resources.Resources.dashboard_search_box
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Controls.Add(Me.txtPassword)
		Me.Panel1.Location = New System.Drawing.Point(162, 142)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(210, 36)
		Me.Panel1.TabIndex = 44
		'
		'txtPassword
		'
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.Location = New System.Drawing.Point(10, 8)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(188, 22)
		Me.txtPassword.TabIndex = 0
		'
		'CreateUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(132, Byte), Integer))
		Me.Controls.Add(Me.picPassword)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.picUsername)
		Me.Controls.Add(Me.picRole)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.cboRole)
		Me.Controls.Add(Me.btnCreate)
		Me.Name = "CreateUser"
		Me.Size = New System.Drawing.Size(465, 306)
		CType(Me.picUsername, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picRole, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		CType(Me.picPassword, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnCreate As Button
	Friend WithEvents cboRole As ComboBox
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents picRole As PictureBox
	Friend WithEvents picUsername As PictureBox
	Friend WithEvents picPassword As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel1 As Panel
	Friend WithEvents txtPassword As TextBox
End Class
