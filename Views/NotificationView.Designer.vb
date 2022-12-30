<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationView
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.pnlBackground = New System.Windows.Forms.Panel()
		Me.lblNotification = New System.Windows.Forms.Label()
		Me.pnlBackground.SuspendLayout()
		Me.SuspendLayout()
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		'
		'pnlBackground
		'
		Me.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pnlBackground.Controls.Add(Me.lblNotification)
		Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnlBackground.Location = New System.Drawing.Point(0, 0)
		Me.pnlBackground.Name = "pnlBackground"
		Me.pnlBackground.Size = New System.Drawing.Size(266, 42)
		Me.pnlBackground.TabIndex = 3
		'
		'lblNotification
		'
		Me.lblNotification.BackColor = System.Drawing.Color.Transparent
		Me.lblNotification.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.lblNotification.ForeColor = System.Drawing.Color.White
		Me.lblNotification.Location = New System.Drawing.Point(0, 11)
		Me.lblNotification.Name = "lblNotification"
		Me.lblNotification.Size = New System.Drawing.Size(267, 20)
		Me.lblNotification.TabIndex = 3
		Me.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'NotificationView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(27, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(266, 42)
		Me.Controls.Add(Me.pnlBackground)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "NotificationView"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Notification"
		Me.pnlBackground.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Timer1 As Timer
	Friend WithEvents pnlBackground As Panel
	Friend WithEvents lblNotification As Label
End Class
