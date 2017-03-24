<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateReviewer
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateReviewer))
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rgv_questions = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tb_idno = New Telerik.WinControls.UI.RadLabel()
        Me.cb_levels = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.qm_btn_clear = New Telerik.WinControls.UI.RadButton()
        Me.qm_btn_add = New Telerik.WinControls.UI.RadButton()
        Me.qm_btn_update = New Telerik.WinControls.UI.RadButton()
        Me.qm_btn_delete = New Telerik.WinControls.UI.RadButton()
        Me.tb_c = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.tb_b = New Telerik.WinControls.UI.RadTextBox()
        Me.tb_a = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.tb_question = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.cb_subjects = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rgv_questions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgv_questions.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.tb_idno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_levels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qm_btn_clear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qm_btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qm_btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qm_btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_question, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_subjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.rgv_questions)
        Me.RadGroupBox1.HeaderText = "&List of &Questions"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(942, 214)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "&List of &Questions"
        '
        'rgv_questions
        '
        Me.rgv_questions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgv_questions.Location = New System.Drawing.Point(2, 18)
        '
        '
        '
        Me.rgv_questions.MasterTemplate.AllowAddNewRow = False
        Me.rgv_questions.MasterTemplate.AllowDeleteRow = False
        Me.rgv_questions.MasterTemplate.AllowEditRow = False
        Me.rgv_questions.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.rgv_questions.MasterTemplate.EnableGrouping = False
        Me.rgv_questions.MasterTemplate.ShowRowHeaderColumn = False
        Me.rgv_questions.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.rgv_questions.Name = "rgv_questions"
        Me.rgv_questions.ReadOnly = True
        Me.rgv_questions.Size = New System.Drawing.Size(938, 194)
        Me.rgv_questions.TabIndex = 0
        Me.rgv_questions.Text = "RadGridView1"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.tb_idno)
        Me.RadGroupBox2.Controls.Add(Me.cb_levels)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.Controls.Add(Me.qm_btn_clear)
        Me.RadGroupBox2.Controls.Add(Me.qm_btn_add)
        Me.RadGroupBox2.Controls.Add(Me.qm_btn_update)
        Me.RadGroupBox2.Controls.Add(Me.qm_btn_delete)
        Me.RadGroupBox2.Controls.Add(Me.tb_c)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.tb_b)
        Me.RadGroupBox2.Controls.Add(Me.tb_a)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.tb_question)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.cb_subjects)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.HeaderText = "&Question &Manager"
        Me.RadGroupBox2.Location = New System.Drawing.Point(14, 232)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(940, 269)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.Text = "&Question &Manager"
        '
        'tb_idno
        '
        Me.tb_idno.Location = New System.Drawing.Point(890, 246)
        Me.tb_idno.Name = "tb_idno"
        Me.tb_idno.Size = New System.Drawing.Size(45, 18)
        Me.tb_idno.TabIndex = 14
        Me.tb_idno.Text = "&Subject:"
        Me.tb_idno.Visible = False
        '
        'cb_levels
        '
        Me.cb_levels.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cb_levels.Location = New System.Drawing.Point(94, 141)
        Me.cb_levels.Name = "cb_levels"
        Me.cb_levels.Size = New System.Drawing.Size(360, 20)
        Me.cb_levels.TabIndex = 13
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(49, 143)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(39, 18)
        Me.RadLabel6.TabIndex = 12
        Me.RadLabel6.Text = "&Levels:"
        '
        'qm_btn_clear
        '
        Me.qm_btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.qm_btn_clear.Location = New System.Drawing.Point(90, 190)
        Me.qm_btn_clear.Name = "qm_btn_clear"
        Me.qm_btn_clear.Size = New System.Drawing.Size(110, 31)
        Me.qm_btn_clear.TabIndex = 11
        Me.qm_btn_clear.Text = "Clear"
        '
        'qm_btn_add
        '
        Me.qm_btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qm_btn_add.Location = New System.Drawing.Point(565, 190)
        Me.qm_btn_add.Name = "qm_btn_add"
        Me.qm_btn_add.Size = New System.Drawing.Size(110, 31)
        Me.qm_btn_add.TabIndex = 10
        Me.qm_btn_add.Text = "Add"
        '
        'qm_btn_update
        '
        Me.qm_btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qm_btn_update.Location = New System.Drawing.Point(681, 190)
        Me.qm_btn_update.Name = "qm_btn_update"
        Me.qm_btn_update.Size = New System.Drawing.Size(110, 31)
        Me.qm_btn_update.TabIndex = 10
        Me.qm_btn_update.Text = "Update"
        '
        'qm_btn_delete
        '
        Me.qm_btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.qm_btn_delete.Location = New System.Drawing.Point(797, 190)
        Me.qm_btn_delete.Name = "qm_btn_delete"
        Me.qm_btn_delete.Size = New System.Drawing.Size(110, 31)
        Me.qm_btn_delete.TabIndex = 9
        Me.qm_btn_delete.Text = "Delete"
        '
        'tb_c
        '
        Me.tb_c.Location = New System.Drawing.Point(537, 138)
        Me.tb_c.Name = "tb_c"
        Me.tb_c.Size = New System.Drawing.Size(360, 20)
        Me.tb_c.TabIndex = 8
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(478, 140)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(53, 18)
        Me.RadLabel5.TabIndex = 7
        Me.RadLabel5.Text = "&Choice C:"
        '
        'tb_b
        '
        Me.tb_b.Location = New System.Drawing.Point(537, 92)
        Me.tb_b.Name = "tb_b"
        Me.tb_b.Size = New System.Drawing.Size(360, 20)
        Me.tb_b.TabIndex = 6
        '
        'tb_a
        '
        Me.tb_a.Location = New System.Drawing.Point(537, 46)
        Me.tb_a.Name = "tb_a"
        Me.tb_a.Size = New System.Drawing.Size(360, 20)
        Me.tb_a.TabIndex = 5
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(479, 94)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(52, 18)
        Me.RadLabel4.TabIndex = 3
        Me.RadLabel4.Text = "&Choice B:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(478, 48)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(53, 18)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "&Choice A:"
        '
        'tb_question
        '
        Me.tb_question.AutoSize = False
        Me.tb_question.Location = New System.Drawing.Point(94, 81)
        Me.tb_question.Multiline = True
        Me.tb_question.Name = "tb_question"
        Me.tb_question.Size = New System.Drawing.Size(360, 46)
        Me.tb_question.TabIndex = 3
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(34, 89)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(54, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "&Question:"
        '
        'cb_subjects
        '
        Me.cb_subjects.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cb_subjects.Location = New System.Drawing.Point(94, 47)
        Me.cb_subjects.Name = "cb_subjects"
        Me.cb_subjects.Size = New System.Drawing.Size(360, 20)
        Me.cb_subjects.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(43, 49)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "&Subject:"
        '
        'CreateReviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 513)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateReviewer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reviewer"
        Me.TopMost = True
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.rgv_questions.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgv_questions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.tb_idno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_levels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qm_btn_clear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qm_btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qm_btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qm_btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_question, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_subjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rgv_questions As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents qm_btn_clear As Telerik.WinControls.UI.RadButton
    Friend WithEvents qm_btn_add As Telerik.WinControls.UI.RadButton
    Friend WithEvents qm_btn_update As Telerik.WinControls.UI.RadButton
    Friend WithEvents qm_btn_delete As Telerik.WinControls.UI.RadButton
    Friend WithEvents tb_c As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tb_b As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents tb_a As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tb_question As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cb_subjects As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cb_levels As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tb_idno As Telerik.WinControls.UI.RadLabel
End Class

