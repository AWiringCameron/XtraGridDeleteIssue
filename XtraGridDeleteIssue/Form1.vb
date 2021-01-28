Imports System.IO
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form1
	Private m_dbData As New dcCustomersDataContext
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim strDBPath As String = Path.Combine(Directory.GetCurrentDirectory, "Database1.mdf")
		m_dbData = New dcCustomersDataContext("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & strDBPath & ";Integrated Security=True")
		LoadCustomers()
		DataBind()
		InitializeGrid()
	End Sub
	Private Sub DataBind()
		txtCompany.DataBindings.Add(New Binding("EditValue", bsCustomer, "CompanyName", True))
		txtContactName.DataBindings.Add(New Binding("EditValue", bsCustomer, "ContactName", True))
		txtPhone.DataBindings.Add(New Binding("EditValue", bsCustomer, "Phone", True))
		gcOrders.DataBindings.Add(New Binding("DataSource", bsCustomer, "Orders", True))
	End Sub
	Private Sub LoadCustomers()

		bsCustomer.DataSource = m_dbData.Customers
		gcCustomers.DataSource = bsCustomer
	End Sub
	Private Sub InitializeGrid()
		dgvCustomers.Columns("ID").Visible = False

		dgvOrders.Columns("ID").Visible = False
		dgvOrders.Columns("CustomerID").Visible = False
		dgvOrders.Columns("Customer").Visible = False
	End Sub
	Private Sub dgvOrders_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles dgvOrders.PopupMenuShowing
		If Not dgvOrders.FocusedRowHandle >= 0 Then Exit Sub

		e.Menu = CreateDeleteMenu(dgvOrders, CType(AddressOf DeleteOrder, EventHandler))
	End Sub
	Private Function CreateDeleteMenu(objGridView As GridView, objEventHandler As [Delegate]) As GridViewMenu
		Dim objMenu As New GridViewMenu(objGridView)
		Dim objMenuItem As New DXMenuItem
		objMenuItem.Caption = "Delete"
		AddHandler objMenuItem.Click, objEventHandler
		objMenu.Items.Add(objMenuItem)

		Return objMenu
	End Function
	Private Sub DeleteOrder(sender As Object, e As EventArgs)
		If XtraMessageBox.Show("Are you sure you want to delete this order.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub
		dgvOrders.DeleteRow(dgvOrders.FocusedRowHandle)
	End Sub
	Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
		bsCustomer.EndEdit()
		Dim obj = m_dbData.GetChangeSet
		m_dbData.SubmitChanges()
	End Sub

	Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
		LoadCustomers()
	End Sub

	Private Sub dgvOrders_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs)
		bsCustomer.EndEdit()
		bsCustomer.Position = dgvCustomers.FocusedRowHandle
	End Sub
End Class
