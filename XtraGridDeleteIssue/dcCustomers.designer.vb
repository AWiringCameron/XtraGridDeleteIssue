﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Database1")>  _
Partial Public Class dcCustomersDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCustomer(instance As Customer)
    End Sub
  Partial Private Sub UpdateCustomer(instance As Customer)
    End Sub
  Partial Private Sub DeleteCustomer(instance As Customer)
    End Sub
  Partial Private Sub InsertOrder(instance As [Order])
    End Sub
  Partial Private Sub UpdateOrder(instance As [Order])
    End Sub
  Partial Private Sub DeleteOrder(instance As [Order])
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.XtraGridDeleteIssue.My.MySettings.Default.Database1ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
		Get
			Return Me.GetTable(Of Customer)
		End Get
	End Property
	
	Public ReadOnly Property Orders() As System.Data.Linq.Table(Of [Order])
		Get
			Return Me.GetTable(Of [Order])
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Customers")>  _
Partial Public Class Customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _Phone As String
	
	Private _Orders As EntitySet(Of [Order])
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnCompanyNameChanging(value As String)
    End Sub
    Partial Private Sub OnCompanyNameChanged()
    End Sub
    Partial Private Sub OnContactNameChanging(value As String)
    End Sub
    Partial Private Sub OnContactNameChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Orders = New EntitySet(Of [Order])(AddressOf Me.attach_Orders, AddressOf Me.detach_Orders)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CompanyName", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me.OnCompanyNameChanging(value)
				Me.SendPropertyChanging
				Me._CompanyName = value
				Me.SendPropertyChanged("CompanyName")
				Me.OnCompanyNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactName", DbType:="VarChar(50)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If (String.Equals(Me._ContactName, value) = false) Then
				Me.OnContactNameChanging(value)
				Me.SendPropertyChanging
				Me._ContactName = value
				Me.SendPropertyChanged("ContactName")
				Me.OnContactNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(50)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Orders", ThisKey:="ID", OtherKey:="CustomerID")>  _
	Public Property Orders() As EntitySet(Of [Order])
		Get
			Return Me._Orders
		End Get
		Set
			Me._Orders.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Me
	End Sub
	
	Private Sub detach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Orders")>  _
Partial Public Class [Order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _CustomerID As Integer
	
	Private _OrderDate As System.Nullable(Of Date)
	
	Private _OrderQuantity As System.Nullable(Of Integer)
	
	Private _Customer As EntityRef(Of Customer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnOrderDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnOrderDateChanged()
    End Sub
    Partial Private Sub OnOrderQuantityChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnOrderQuantityChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Customer = CType(Nothing, EntityRef(Of Customer))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="Int NOT NULL")>  _
	Public Property CustomerID() As Integer
		Get
			Return Me._CustomerID
		End Get
		Set
			If ((Me._CustomerID = value)  _
						= false) Then
				If Me._Customer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderDate", DbType:="DateTime")>  _
	Public Property OrderDate() As System.Nullable(Of Date)
		Get
			Return Me._OrderDate
		End Get
		Set
			If (Me._OrderDate.Equals(value) = false) Then
				Me.OnOrderDateChanging(value)
				Me.SendPropertyChanging
				Me._OrderDate = value
				Me.SendPropertyChanged("OrderDate")
				Me.OnOrderDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderQuantity", DbType:="Int")>  _
	Public Property OrderQuantity() As System.Nullable(Of Integer)
		Get
			Return Me._OrderQuantity
		End Get
		Set
			If (Me._OrderQuantity.Equals(value) = false) Then
				Me.OnOrderQuantityChanging(value)
				Me.SendPropertyChanging
				Me._OrderQuantity = value
				Me.SendPropertyChanged("OrderQuantity")
				Me.OnOrderQuantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Customer", ThisKey:="CustomerID", OtherKey:="ID", IsForeignKey:=true)>  _
	Public Property Customer() As Customer
		Get
			Return Me._Customer.Entity
		End Get
		Set
			Dim previousValue As Customer = Me._Customer.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Customer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Customer.Entity = Nothing
					previousValue.Orders.Remove(Me)
				End If
				Me._Customer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Orders.Add(Me)
					Me._CustomerID = value.ID
				Else
					Me._CustomerID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Customer")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
