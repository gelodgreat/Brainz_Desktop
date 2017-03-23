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
        Me.log_btn_login = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.log_tb_password = New Telerik.WinControls.UI.RadTextBox()
        Me.log_tb_username = New Telerik.WinControls.UI.RadTextBox()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_settings = New System.Windows.Forms.PictureBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.log_btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'log_btn_login
        '
        Me.log_btn_login.Location = New System.Drawing.Point(156, 172)
        Me.log_btn_login.Name = "log_btn_login"
        Me.log_btn_login.Size = New System.Drawing.Size(110, 33)
        Me.log_btn_login.TabIndex = 1
        Me.log_btn_login.Text = "Login"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.PictureBox2)
        Me.RadGroupBox1.Controls.Add(Me.pb_settings)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.log_btn_login)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.log_tb_password)
        Me.RadGroupBox1.Controls.Add(Me.log_tb_username)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(292, 252)
        Me.RadGroupBox1.TabIndex = 2
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(34, 135)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Password:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 108)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Username:"
        '
        'log_tb_password
        '
        Me.log_tb_password.Location = New System.Drawing.Point(96, 133)
        Me.log_tb_password.Name = "log_tb_password"
        Me.log_tb_password.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_password.TabIndex = 1
        '
        'log_tb_username
        '
        Me.log_tb_username.Location = New System.Drawing.Point(96, 106)
        Me.log_tb_username.Name = "log_tb_username"
        Me.log_tb_username.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_username.TabIndex = 0
        '
        'PictureBox2
        '
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
        Me.pb_settings.Image = Global.Brainz_Desktop_Version.My.Resources.Resources._1490244831_Settings_2
        Me.pb_settings.Location = New System.Drawing.Point(221, 12)
        Me.pb_settings.Name = "pb_settings"
        Me.pb_settings.Size = New System.Drawing.Size(63, 65)
        Me.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_settings.TabIndex = 4
        Me.pb_settings.TabStop = False
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(93, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(115, 33)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "Brainz Inc."
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 252)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.log_btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents log_btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents log_tb_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents log_tb_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents pb_settings As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
End Class

