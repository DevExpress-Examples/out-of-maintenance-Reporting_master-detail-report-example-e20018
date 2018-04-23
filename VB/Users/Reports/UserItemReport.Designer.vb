Imports Microsoft.VisualBasic
Imports System
Namespace Users.Reports
	Partial Public Class UserItemReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.issueListDataSet1 = New Users.Data.IssueListDataSet()
			Me.usersTableAdapter = New Users.Data.IssueListDataSetTableAdapters.UsersTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.itemsTableAdapter = New Users.Data.IssueListDataSetTableAdapters.ItemsTableAdapter()
			Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
			Me.itemsTableAdapter1 = New Users.Data.IssueListDataSetTableAdapters.ItemsTableAdapter()
			Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
			Me.tasksTableAdapter = New Users.Data.IssueListDataSetTableAdapters.TasksTableAdapter()
			Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.Even = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			CType(Me.issueListDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.LastName")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(130.2083F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(519.7916F, 23F)
			Me.xrLabel2.StyleName = "Title"
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.FirstName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Users.FirstName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(130.2083F, 23F)
			Me.xrLabel1.StyleName = "Title"
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' issueListDataSet1
			' 
			Me.issueListDataSet1.DataSetName = "IssueListDataSet"
			Me.issueListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' usersTableAdapter
			' 
			Me.usersTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
			Me.DetailReport.DataAdapter = Me.itemsTableAdapter
			Me.DetailReport.DataMember = "Users.CreatedItems"
			Me.DetailReport.DataSource = Me.issueListDataSet1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrLabel3})
			Me.Detail1.HeightF = 45.99998F
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.CreatedItems.Description")})
			Me.xrLabel4.EvenStyleName = "Even"
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 22.99999F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(575.4166F, 23F)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.CreatedItems.Name")})
			Me.xrLabel3.EvenStyleName = "Even"
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(575.4167F, 23F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel5})
			Me.GroupHeader1.HeightF = 23F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.Bookmark = "Created Items"
			Me.xrLabel5.BookmarkParent = Me.xrLabel1
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(35.41667F, 0F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(614.5833F, 23F)
			Me.xrLabel5.StyleName = "Header"
			Me.xrLabel5.Text = "Created Items"
			' 
			' itemsTableAdapter
			' 
			Me.itemsTableAdapter.ClearBeforeFill = True
			' 
			' DetailReport1
			' 
			Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail2, Me.GroupHeader2})
			Me.DetailReport1.DataAdapter = Me.itemsTableAdapter1
			Me.DetailReport1.DataMember = "Users.OwnedItems"
			Me.DetailReport1.DataSource = Me.issueListDataSet1
			Me.DetailReport1.Level = 1
			Me.DetailReport1.Name = "DetailReport1"
			Me.DetailReport1.ReportPrintOptions.PrintOnEmptyDataSource = False
			' 
			' Detail2
			' 
			Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6})
			Me.Detail2.HeightF = 45.99998F
			Me.Detail2.Name = "Detail2"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.OwnedItems.Description")})
			Me.xrLabel7.EvenStyleName = "Even"
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 22.99999F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(575.4167F, 23F)
			Me.xrLabel7.Text = "xrLabel7"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.OwnedItems.Name")})
			Me.xrLabel6.EvenStyleName = "Even"
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 0F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(575.4167F, 23F)
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel8})
			Me.GroupHeader2.HeightF = 23F
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' xrLabel8
			' 
			Me.xrLabel8.Bookmark = "Owned Items"
			Me.xrLabel8.BookmarkParent = Me.xrLabel1
			Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(35.41667F, 0F)
			Me.xrLabel8.Name = "xrLabel8"
			Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel8.SizeF = New System.Drawing.SizeF(614.5833F, 23F)
			Me.xrLabel8.StyleName = "Header"
			Me.xrLabel8.Text = "Owned Items"
			' 
			' itemsTableAdapter1
			' 
			Me.itemsTableAdapter1.ClearBeforeFill = True
			' 
			' DetailReport2
			' 
			Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail3, Me.GroupHeader3})
			Me.DetailReport2.DataAdapter = Me.tasksTableAdapter
			Me.DetailReport2.DataMember = "Users.UserTasks"
			Me.DetailReport2.DataSource = Me.issueListDataSet1
			Me.DetailReport2.Level = 2
			Me.DetailReport2.Name = "DetailReport2"
			Me.DetailReport2.ReportPrintOptions.PrintOnEmptyDataSource = False
			' 
			' Detail3
			' 
			Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel10, Me.xrLabel9})
			Me.Detail3.HeightF = 23F
			Me.Detail3.Name = "Detail3"
			' 
			' xrLabel10
			' 
			Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.UserTasks.Priority")})
			Me.xrLabel10.EvenStyleName = "Even"
			Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(584.7916F, 0F)
			Me.xrLabel10.Name = "xrLabel10"
			Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel10.SizeF = New System.Drawing.SizeF(55.20831F, 23F)
			Me.xrLabel10.Text = "xrLabel10"
			' 
			' xrLabel9
			' 
			Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Users.UserTasks.Name")})
			Me.xrLabel9.EvenStyleName = "Even"
			Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(64.58334F, 0F)
			Me.xrLabel9.Name = "xrLabel9"
			Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel9.SizeF = New System.Drawing.SizeF(520.2083F, 23F)
			Me.xrLabel9.Text = "xrLabel9"
			' 
			' GroupHeader3
			' 
			Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel11})
			Me.GroupHeader3.HeightF = 23.95833F
			Me.GroupHeader3.Name = "GroupHeader3"
			' 
			' xrLabel11
			' 
			Me.xrLabel11.Bookmark = "Tasks"
			Me.xrLabel11.BookmarkParent = Me.xrLabel1
			Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(35.41676F, 0F)
			Me.xrLabel11.Name = "xrLabel11"
			Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel11.SizeF = New System.Drawing.SizeF(614.5833F, 23F)
			Me.xrLabel11.StyleName = "Header"
			Me.xrLabel11.Text = "Tasks"
			' 
			' tasksTableAdapter
			' 
			Me.tasksTableAdapter.ClearBeforeFill = True
			' 
			' Header
			' 
			Me.Header.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))))
			Me.Header.Font = New System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Header.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.Header.Name = "Header"
			Me.Header.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F)
			Me.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' Even
			' 
			Me.Even.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
			Me.Even.Name = "Even"
			Me.Even.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' Title
			' 
			Me.Title.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))))
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.Title.BorderWidth = 3
			Me.Title.Font = New System.Drawing.Font("Verdana", 18F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Title.Name = "Title"
			Me.Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' UserItemReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.DetailReport1, Me.DetailReport2})
			Me.DataAdapter = Me.usersTableAdapter
			Me.DataMember = "Users"
			Me.DataSource = Me.issueListDataSet1
			Me.Font = New System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ReportPrintOptions.PrintOnEmptyDataSource = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Header, Me.Even, Me.Title})
			Me.Version = "12.2"
			CType(Me.issueListDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private issueListDataSet1 As Data.IssueListDataSet
		Private usersTableAdapter As Data.IssueListDataSetTableAdapters.UsersTableAdapter
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private itemsTableAdapter As Data.IssueListDataSetTableAdapters.ItemsTableAdapter
		Private DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail2 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
		Private itemsTableAdapter1 As Data.IssueListDataSetTableAdapters.ItemsTableAdapter
		Private DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail3 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
		Private tasksTableAdapter As Data.IssueListDataSetTableAdapters.TasksTableAdapter
		Private Header As DevExpress.XtraReports.UI.XRControlStyle
		Private Even As DevExpress.XtraReports.UI.XRControlStyle
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
	End Class
End Namespace
