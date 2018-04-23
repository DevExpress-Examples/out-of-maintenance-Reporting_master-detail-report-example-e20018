namespace Users.Reports
{
    partial class UserItemReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.issueListDataSet1 = new Users.Data.IssueListDataSet();
            this.usersTableAdapter = new Users.Data.IssueListDataSetTableAdapters.UsersTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.itemsTableAdapter = new Users.Data.IssueListDataSetTableAdapters.ItemsTableAdapter();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.itemsTableAdapter1 = new Users.Data.IssueListDataSetTableAdapters.ItemsTableAdapter();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.tasksTableAdapter = new Users.Data.IssueListDataSetTableAdapters.TasksTableAdapter();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Even = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.issueListDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 23F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.LastName")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(130.2083F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(519.7916F, 23F);
            this.xrLabel2.StyleName = "Title";
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.FirstName"),
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "Users.FirstName")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(130.2083F, 23F);
            this.xrLabel1.StyleName = "Title";
            this.xrLabel1.Text = "xrLabel1";
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // issueListDataSet1
            // 
            this.issueListDataSet1.DataSetName = "IssueListDataSet";
            this.issueListDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupHeader1});
            this.DetailReport.DataAdapter = this.itemsTableAdapter;
            this.DetailReport.DataMember = "Users.CreatedItems";
            this.DetailReport.DataSource = this.issueListDataSet1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3});
            this.Detail1.HeightF = 45.99998F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.CreatedItems.Description")});
            this.xrLabel4.EvenStyleName = "Even";
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(64.58334F, 22.99999F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(575.4166F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.CreatedItems.Name")});
            this.xrLabel3.EvenStyleName = "Even";
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(64.58334F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(575.4167F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5});
            this.GroupHeader1.HeightF = 23F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Bookmark = "Created Items";
            this.xrLabel5.BookmarkParent = this.xrLabel1;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(614.5833F, 23F);
            this.xrLabel5.StyleName = "Header";
            this.xrLabel5.Text = "Created Items";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader2});
            this.DetailReport1.DataAdapter = this.itemsTableAdapter1;
            this.DetailReport1.DataMember = "Users.OwnedItems";
            this.DetailReport1.DataSource = this.issueListDataSet1;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            this.DetailReport1.ReportPrintOptions.PrintOnEmptyDataSource = false;
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6});
            this.Detail2.HeightF = 45.99998F;
            this.Detail2.Name = "Detail2";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.OwnedItems.Description")});
            this.xrLabel7.EvenStyleName = "Even";
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(64.58334F, 22.99999F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(575.4167F, 23F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.OwnedItems.Name")});
            this.xrLabel6.EvenStyleName = "Even";
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(64.58334F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(575.4167F, 23F);
            this.xrLabel6.Text = "xrLabel6";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8});
            this.GroupHeader2.HeightF = 23F;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Bookmark = "Owned Items";
            this.xrLabel8.BookmarkParent = this.xrLabel1;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(35.41667F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(614.5833F, 23F);
            this.xrLabel8.StyleName = "Header";
            this.xrLabel8.Text = "Owned Items";
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3,
            this.GroupHeader3});
            this.DetailReport2.DataAdapter = this.tasksTableAdapter;
            this.DetailReport2.DataMember = "Users.UserTasks";
            this.DetailReport2.DataSource = this.issueListDataSet1;
            this.DetailReport2.Level = 2;
            this.DetailReport2.Name = "DetailReport2";
            this.DetailReport2.ReportPrintOptions.PrintOnEmptyDataSource = false;
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel9});
            this.Detail3.HeightF = 23F;
            this.Detail3.Name = "Detail3";
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.UserTasks.Priority")});
            this.xrLabel10.EvenStyleName = "Even";
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(584.7916F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(55.20831F, 23F);
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Users.UserTasks.Name")});
            this.xrLabel9.EvenStyleName = "Even";
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(64.58334F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(520.2083F, 23F);
            this.xrLabel9.Text = "xrLabel9";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11});
            this.GroupHeader3.HeightF = 23.95833F;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Bookmark = "Tasks";
            this.xrLabel11.BookmarkParent = this.xrLabel1;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(35.41676F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(614.5833F, 23F);
            this.xrLabel11.StyleName = "Header";
            this.xrLabel11.Text = "Tasks";
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Header.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Header.Name = "Header";
            this.Header.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Even
            // 
            this.Even.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Even.Name = "Even";
            this.Even.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // Title
            // 
            this.Title.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.Title.BorderWidth = 3;
            this.Title.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Name = "Title";
            this.Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // UserItemReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2});
            this.DataAdapter = this.usersTableAdapter;
            this.DataMember = "Users";
            this.DataSource = this.issueListDataSet1;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header,
            this.Even,
            this.Title});
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this.issueListDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private Data.IssueListDataSet issueListDataSet1;
        private Data.IssueListDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private Data.IssueListDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private Data.IssueListDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private Data.IssueListDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.XtraReports.UI.XRControlStyle Even;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
    }
}
