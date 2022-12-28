<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.btnShowHide = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.btnLogin = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(61, 33)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(365, 71)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.Panel6)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.Panel7)
		Me.Panel1.Controls.Add(Me.btnLogin)
		Me.Panel1.Location = New System.Drawing.Point(188, 119)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(266, 242)
		Me.Panel1.TabIndex = 1
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(21, 116)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 21)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Password"
		'
		'Panel6
		'
		Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
		Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel6.Controls.Add(Me.btnShowHide)
		Me.Panel6.Controls.Add(Me.txtPassword)
		Me.Panel6.Location = New System.Drawing.Point(25, 149)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(220, 30)
		Me.Panel6.TabIndex = 9
		'
		'btnShowHide
		'
		Me.btnShowHide.BackgroundImage = CType(resources.GetObject("btnShowHide.BackgroundImage"), System.Drawing.Image)
		Me.btnShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnShowHide.FlatAppearance.BorderSize = 0
		Me.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnShowHide.Location = New System.Drawing.Point(189, 4)
		Me.btnShowHide.Name = "btnShowHide"
		Me.btnShowHide.Size = New System.Drawing.Size(28, 23)
		Me.btnShowHide.TabIndex = 1
		Me.btnShowHide.UseVisualStyleBackColor = True
		'
		'txtPassword
		'
		Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPassword.Location = New System.Drawing.Point(10, 3)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(173, 22)
		Me.txtPassword.TabIndex = 0
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(21, 32)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(81, 21)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Username"
		'
		'Panel7
		'
		Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
		Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel7.Controls.Add(Me.txtUsername)
		Me.Panel7.Location = New System.Drawing.Point(25, 67)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(220, 30)
		Me.Panel7.TabIndex = 7
		'
		'txtUsername
		'
		Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUsername.Location = New System.Drawing.Point(10, 3)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(200, 22)
		Me.txtUsername.TabIndex = 0
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.Transparent
		Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
		Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnLogin.FlatAppearance.BorderSize = 0
		Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
		Me.btnLogin.ForeColor = System.Drawing.Color.White
		Me.btnLogin.Location = New System.Drawing.Point(25, 195)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(220, 31)
		Me.btnLogin.TabIndex = 0
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Transparent
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.PictureBox1)
		Me.MaximumSize = New System.Drawing.Size(481, 497)
		Me.MinimumSize = New System.Drawing.Size(481, 497)
		Me.Name = "Login"
		Me.Size = New System.Drawing.Size(481, 497)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents btnLogin As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents Panel6 As Panel
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Panel7 As Panel
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents btnShowHide As Button
End Class
