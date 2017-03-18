<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btn_createreviewer = New Telerik.WinControls.UI.RadButton()
        Me.btn_export_db = New Telerik.WinControls.UI.RadButton()
        Me.btn_import = New Telerik.WinControls.UI.RadButton()
        CType(Me.btn_createreviewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_export_db, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_import, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_createreviewer
        '
        Me.btn_createreviewer.Location = New System.Drawing.Point(25, 12)
        Me.btn_createreviewer.Name = "btn_createreviewer"
        Me.btn_createreviewer.Size = New System.Drawing.Size(110, 73)
        Me.btn_createreviewer.TabIndex = 0
        Me.btn_createreviewer.Text = "Create Reviewer"
        '
        'btn_export_db
        '
        Me.btn_export_db.Location = New System.Drawing.Point(141, 12)
        Me.btn_export_db.Name = "btn_export_db"
        Me.btn_export_db.Size = New System.Drawing.Size(110, 73)
        Me.btn_export_db.TabIndex = 1
        Me.btn_export_db.Text = "Export Questions"
        '
        'btn_import
        '
        Me.btn_import.Location = New System.Drawing.Point(257, 12)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(110, 73)
        Me.btn_import.TabIndex = 2
        Me.btn_import.Text = "Import Questions"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 97)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.btn_export_db)
        Me.Controls.Add(Me.btn_createreviewer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TopMost = True
        CType(Me.btn_createreviewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_export_db, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_import, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_createreviewer As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_export_db As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_import As Telerik.WinControls.UI.RadButton
End Class

