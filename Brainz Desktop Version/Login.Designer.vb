<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.log_btn_login = New Telerik.WinControls.UI.RadButton()
        Me.log_tb_password = New Telerik.WinControls.UI.RadTextBox()
        Me.log_tb_username = New Telerik.WinControls.UI.RadTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_settings = New System.Windows.Forms.PictureBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.log_btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.log_btn_login)
        Me.RadGroupBox1.Controls.Add(Me.log_tb_password)
        Me.RadGroupBox1.Controls.Add(Me.log_tb_username)
        Me.RadGroupBox1.Controls.Add(Me.PictureBox2)
        Me.RadGroupBox1.Controls.Add(Me.pb_settings)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(292, 217)
        Me.RadGroupBox1.TabIndex = 2
        '
        'log_btn_login
        '
        Me.log_btn_login.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.log_btn_login.Location = New System.Drawing.Point(158, 173)
        Me.log_btn_login.Name = "log_btn_login"
        Me.log_btn_login.Size = New System.Drawing.Size(110, 33)
        Me.log_btn_login.TabIndex = 13
        Me.log_btn_login.Text = "Login"
        '
        'log_tb_password
        '
        Me.log_tb_password.Location = New System.Drawing.Point(98, 134)
        Me.log_tb_password.Name = "log_tb_password"
        Me.log_tb_password.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_password.TabIndex = 11
        '
        'log_tb_username
        '
        Me.log_tb_username.Location = New System.Drawing.Point(98, 107)
        Me.log_tb_username.Name = "log_tb_username"
        Me.log_tb_username.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_username.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Brainz_Desktop_Version.My.Resources.Resources.brainz
        Me.PictureBox2.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'pb_settings
        '
        Me.pb_settings.BackColor = System.Drawing.Color.Transparent
        Me.pb_settings.Image = Global.Brainz_Desktop_Version.My.Resources.Resources._1490244831_Settings_2
        Me.pb_settings.Location = New System.Drawing.Point(221, 12)
        Me.pb_settings.Name = "pb_settings"
        Me.pb_settings.Size = New System.Drawing.Size(63, 65)
        Me.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_settings.TabIndex = 4
        Me.pb_settings.TabStop = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(82, 12)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(129, 30)
        Me.RadLabel4.TabIndex = 14
        Me.RadLabel4.Text = "Brainz Inc."
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(18, 109)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(74, 18)
        Me.RadLabel3.TabIndex = 15
        Me.RadLabel3.Text = "&Username:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(25, 136)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(67, 18)
        Me.RadLabel5.TabIndex = 16
        Me.RadLabel5.Text = "&Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 217)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.log_btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents pb_settings As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents log_btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents log_tb_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents log_tb_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
End Class

