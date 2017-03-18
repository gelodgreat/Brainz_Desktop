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
        Me.log_tb_username = New Telerik.WinControls.UI.RadTextBox()
        Me.log_tb_password = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.log_btn_metro = New Telerik.WinControls.UI.RadButton()
        Me.log_btn_light = New Telerik.WinControls.UI.RadButton()
        Me.log_btn_dark = New Telerik.WinControls.UI.RadButton()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        CType(Me.log_btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.log_btn_metro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_btn_light, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.log_btn_dark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'log_btn_login
        '
        Me.log_btn_login.Location = New System.Drawing.Point(149, 116)
        Me.log_btn_login.Name = "log_btn_login"
        Me.log_btn_login.Size = New System.Drawing.Size(110, 33)
        Me.log_btn_login.TabIndex = 1
        Me.log_btn_login.Text = "Login"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadGroupBox2)
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
        'log_tb_username
        '
        Me.log_tb_username.Location = New System.Drawing.Point(89, 44)
        Me.log_tb_username.Name = "log_tb_username"
        Me.log_tb_username.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_username.TabIndex = 0
        '
        'log_tb_password
        '
        Me.log_tb_password.Location = New System.Drawing.Point(89, 71)
        Me.log_tb_password.Name = "log_tb_password"
        Me.log_tb_password.Size = New System.Drawing.Size(170, 20)
        Me.log_tb_password.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(24, 46)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Username:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(27, 73)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Password:"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.log_btn_metro)
        Me.RadGroupBox2.Controls.Add(Me.log_btn_light)
        Me.RadGroupBox2.Controls.Add(Me.log_btn_dark)
        Me.RadGroupBox2.HeaderText = "&Themes"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 175)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(268, 65)
        Me.RadGroupBox2.TabIndex = 3
        Me.RadGroupBox2.Text = "&Themes"
        '
        'log_btn_metro
        '
        Me.log_btn_metro.Location = New System.Drawing.Point(190, 21)
        Me.log_btn_metro.Name = "log_btn_metro"
        Me.log_btn_metro.Size = New System.Drawing.Size(73, 33)
        Me.log_btn_metro.TabIndex = 7
        Me.log_btn_metro.Text = "Metro"
        '
        'log_btn_light
        '
        Me.log_btn_light.Location = New System.Drawing.Point(102, 21)
        Me.log_btn_light.Name = "log_btn_light"
        Me.log_btn_light.Size = New System.Drawing.Size(73, 33)
        Me.log_btn_light.TabIndex = 6
        Me.log_btn_light.Text = "Light"
        '
        'log_btn_dark
        '
        Me.log_btn_dark.Location = New System.Drawing.Point(12, 21)
        Me.log_btn_dark.Name = "log_btn_dark"
        Me.log_btn_dark.Size = New System.Drawing.Size(73, 33)
        Me.log_btn_dark.TabIndex = 5
        Me.log_btn_dark.Text = "Dark"
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
        CType(Me.log_tb_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_tb_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.log_btn_metro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_btn_light, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.log_btn_dark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents log_btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents log_btn_metro As Telerik.WinControls.UI.RadButton
    Friend WithEvents log_btn_light As Telerik.WinControls.UI.RadButton
    Friend WithEvents log_btn_dark As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents log_tb_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents log_tb_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
End Class

