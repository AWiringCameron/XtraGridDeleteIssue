<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.gcCustomers = New DevExpress.XtraGrid.GridControl()
		Me.dgvCustomers = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.TablePanel1 = New DevExpress.Utils.Layout.TablePanel()
		Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
		Me.txtContactName = New DevExpress.XtraEditors.TextEdit()
		Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
		Me.Bar1 = New DevExpress.XtraBars.Bar()
		Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
		Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
		Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
		Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
		Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
		Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
		Me.gcOrders = New DevExpress.XtraGrid.GridControl()
		Me.dgvOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
		Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
		Me.txtCompany = New DevExpress.XtraEditors.TextEdit()
		Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
		CType(Me.gcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TablePanel1.SuspendLayout()
		CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupControl1.SuspendLayout()
		CType(Me.txtContactName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gcOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'gcCustomers
		'
		Me.TablePanel1.SetColumn(Me.gcCustomers, 0)
		Me.gcCustomers.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gcCustomers.Location = New System.Drawing.Point(3, 3)
		Me.gcCustomers.MainView = Me.dgvCustomers
		Me.gcCustomers.Name = "gcCustomers"
		Me.TablePanel1.SetRow(Me.gcCustomers, 0)
		Me.gcCustomers.Size = New System.Drawing.Size(394, 415)
		Me.gcCustomers.TabIndex = 0
		Me.gcCustomers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvCustomers})
		'
		'dgvCustomers
		'
		Me.dgvCustomers.GridControl = Me.gcCustomers
		Me.dgvCustomers.Name = "dgvCustomers"
		Me.dgvCustomers.OptionsBehavior.Editable = False
		Me.dgvCustomers.OptionsDetail.EnableMasterViewMode = False
		'
		'TablePanel1
		'
		Me.TablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.0!), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50.0!)})
		Me.TablePanel1.Controls.Add(Me.GroupControl1)
		Me.TablePanel1.Controls.Add(Me.gcCustomers)
		Me.TablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TablePanel1.Location = New System.Drawing.Point(0, 29)
		Me.TablePanel1.Name = "TablePanel1"
		Me.TablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!)})
		Me.TablePanel1.Size = New System.Drawing.Size(800, 421)
		Me.TablePanel1.TabIndex = 2
		'
		'GroupControl1
		'
		Me.TablePanel1.SetColumn(Me.GroupControl1, 1)
		Me.GroupControl1.Controls.Add(Me.txtCompany)
		Me.GroupControl1.Controls.Add(Me.LabelControl3)
		Me.GroupControl1.Controls.Add(Me.txtPhone)
		Me.GroupControl1.Controls.Add(Me.txtContactName)
		Me.GroupControl1.Controls.Add(Me.LabelControl1)
		Me.GroupControl1.Controls.Add(Me.LabelControl2)
		Me.GroupControl1.Controls.Add(Me.gcOrders)
		Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupControl1.Location = New System.Drawing.Point(403, 3)
		Me.GroupControl1.Name = "GroupControl1"
		Me.TablePanel1.SetRow(Me.GroupControl1, 0)
		Me.GroupControl1.Size = New System.Drawing.Size(394, 415)
		Me.GroupControl1.TabIndex = 5
		Me.GroupControl1.Text = "Customer Info:"
		'
		'txtContactName
		'
		Me.txtContactName.Location = New System.Drawing.Point(101, 62)
		Me.txtContactName.MenuManager = Me.BarManager1
		Me.txtContactName.Name = "txtContactName"
		Me.txtContactName.Size = New System.Drawing.Size(196, 20)
		Me.txtContactName.TabIndex = 4
		'
		'BarManager1
		'
		Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
		Me.BarManager1.DockControls.Add(Me.barDockControlTop)
		Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
		Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
		Me.BarManager1.DockControls.Add(Me.barDockControlRight)
		Me.BarManager1.Form = Me
		Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnRefresh})
		Me.BarManager1.MaxItemId = 3
		'
		'Bar1
		'
		Me.Bar1.BarName = "Custom 2"
		Me.Bar1.DockCol = 0
		Me.Bar1.DockRow = 0
		Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
		Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh)})
		Me.Bar1.OptionsBar.UseWholeRow = True
		Me.Bar1.Text = "Custom 2"
		'
		'btnSave
		'
		Me.btnSave.Caption = "Save"
		Me.btnSave.Id = 1
		Me.btnSave.Name = "btnSave"
		'
		'btnRefresh
		'
		Me.btnRefresh.Caption = "Refresh"
		Me.btnRefresh.Id = 2
		Me.btnRefresh.Name = "btnRefresh"
		'
		'barDockControlTop
		'
		Me.barDockControlTop.CausesValidation = False
		Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
		Me.barDockControlTop.Manager = Me.BarManager1
		Me.barDockControlTop.Size = New System.Drawing.Size(800, 29)
		'
		'barDockControlBottom
		'
		Me.barDockControlBottom.CausesValidation = False
		Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.barDockControlBottom.Location = New System.Drawing.Point(0, 450)
		Me.barDockControlBottom.Manager = Me.BarManager1
		Me.barDockControlBottom.Size = New System.Drawing.Size(800, 0)
		'
		'barDockControlLeft
		'
		Me.barDockControlLeft.CausesValidation = False
		Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
		Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
		Me.barDockControlLeft.Manager = Me.BarManager1
		Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
		'
		'barDockControlRight
		'
		Me.barDockControlRight.CausesValidation = False
		Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
		Me.barDockControlRight.Location = New System.Drawing.Point(800, 29)
		Me.barDockControlRight.Manager = Me.BarManager1
		Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
		'
		'LabelControl1
		'
		Me.LabelControl1.Location = New System.Drawing.Point(23, 65)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
		Me.LabelControl1.TabIndex = 2
		Me.LabelControl1.Text = "Contact Name:"
		'
		'LabelControl2
		'
		Me.LabelControl2.Location = New System.Drawing.Point(61, 91)
		Me.LabelControl2.Name = "LabelControl2"
		Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
		Me.LabelControl2.TabIndex = 3
		Me.LabelControl2.Text = "Phone:"
		'
		'gcOrders
		'
		Me.gcOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gcOrders.Location = New System.Drawing.Point(0, 131)
		Me.gcOrders.MainView = Me.dgvOrders
		Me.gcOrders.Name = "gcOrders"
		Me.gcOrders.Size = New System.Drawing.Size(394, 284)
		Me.gcOrders.TabIndex = 1
		Me.gcOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvOrders})
		'
		'dgvOrders
		'
		Me.dgvOrders.GridControl = Me.gcOrders
		Me.dgvOrders.Name = "dgvOrders"
		Me.dgvOrders.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
		'
		'GridView1
		'
		Me.GridView1.Name = "GridView1"
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(101, 88)
		Me.txtPhone.MenuManager = Me.BarManager1
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(196, 20)
		Me.txtPhone.TabIndex = 5
		'
		'txtCompany
		'
		Me.txtCompany.Location = New System.Drawing.Point(101, 36)
		Me.txtCompany.MenuManager = Me.BarManager1
		Me.txtCompany.Name = "txtCompany"
		Me.txtCompany.Size = New System.Drawing.Size(196, 20)
		Me.txtCompany.TabIndex = 7
		'
		'LabelControl3
		'
		Me.LabelControl3.Location = New System.Drawing.Point(16, 39)
		Me.LabelControl3.Name = "LabelControl3"
		Me.LabelControl3.Size = New System.Drawing.Size(79, 13)
		Me.LabelControl3.TabIndex = 6
		Me.LabelControl3.Text = "Company Name:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TablePanel1)
		Me.Controls.Add(Me.barDockControlLeft)
		Me.Controls.Add(Me.barDockControlRight)
		Me.Controls.Add(Me.barDockControlBottom)
		Me.Controls.Add(Me.barDockControlTop)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.gcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TablePanel1.ResumeLayout(False)
		CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupControl1.ResumeLayout(False)
		Me.GroupControl1.PerformLayout()
		CType(Me.txtContactName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gcOrders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents gcCustomers As DevExpress.XtraGrid.GridControl
	Friend WithEvents dgvCustomers As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents TablePanel1 As DevExpress.Utils.Layout.TablePanel
	Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
	Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
	Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
	Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
	Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
	Friend WithEvents txtContactName As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
	Friend WithEvents gcOrders As DevExpress.XtraGrid.GridControl
	Friend WithEvents dgvOrders As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
	Friend WithEvents bsCustomer As BindingSource
	Friend WithEvents txtCompany As DevExpress.XtraEditors.TextEdit
	Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
