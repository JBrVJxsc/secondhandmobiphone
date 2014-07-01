namespace MobilePhoneLibrary.Controls.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barBtnAdd = new DevExpress.XtraBars.BarSubItem();
            this.barBtnAddSold = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddBought = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarSubItem();
            this.barBtnPrintQRCode = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintTrade = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGrpSold = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGrpBought = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tradeObjectShow = new MobilePhoneLibrary.Controls.Controls.TradeObjectShow();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain,
            this.barStatus});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageList;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAdd,
            this.barBtnExit,
            this.barBtnQuery,
            this.barBtnAddSold,
            this.barBtnAddBought,
            this.barButtonItem1,
            this.barBtnPrint,
            this.barBtnPrintQRCode,
            this.barBtnPrintTrade});
            this.barManager.MainMenu = this.barMain;
            this.barManager.MaxItemId = 13;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.barManager.StatusBar = this.barStatus;
            // 
            // barMain
            // 
            this.barMain.BarName = "Main menu";
            this.barMain.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnQuery, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barMain.OptionsBar.AllowQuickCustomization = false;
            this.barMain.OptionsBar.DisableCustomization = true;
            this.barMain.OptionsBar.DrawDragBorder = false;
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Main menu";
            // 
            // barBtnAdd
            // 
            this.barBtnAdd.Caption = "新建记录";
            this.barBtnAdd.Id = 0;
            this.barBtnAdd.ImageIndex = 0;
            this.barBtnAdd.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddSold),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddBought)});
            this.barBtnAdd.Name = "barBtnAdd";
            // 
            // barBtnAddSold
            // 
            this.barBtnAddSold.Caption = "出售";
            this.barBtnAddSold.Id = 5;
            this.barBtnAddSold.ImageIndex = 4;
            this.barBtnAddSold.Name = "barBtnAddSold";
            this.barBtnAddSold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddSold_ItemClick);
            // 
            // barBtnAddBought
            // 
            this.barBtnAddBought.Caption = "收购";
            this.barBtnAddBought.Id = 7;
            this.barBtnAddBought.ImageIndex = 3;
            this.barBtnAddBought.Name = "barBtnAddBought";
            this.barBtnAddBought.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddBought_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "打印";
            this.barBtnPrint.Id = 10;
            this.barBtnPrint.ImageIndex = 6;
            this.barBtnPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrintQRCode),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrintTrade)});
            this.barBtnPrint.Name = "barBtnPrint";
            // 
            // barBtnPrintQRCode
            // 
            this.barBtnPrintQRCode.Caption = "二维码";
            this.barBtnPrintQRCode.Id = 11;
            this.barBtnPrintQRCode.ImageIndex = 7;
            this.barBtnPrintQRCode.Name = "barBtnPrintQRCode";
            this.barBtnPrintQRCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrintQRCode_ItemClick);
            // 
            // barBtnPrintTrade
            // 
            this.barBtnPrintTrade.Caption = "记录";
            this.barBtnPrintTrade.Id = 12;
            this.barBtnPrintTrade.ImageIndex = 8;
            this.barBtnPrintTrade.Name = "barBtnPrintTrade";
            this.barBtnPrintTrade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrintTrade_ItemClick);
            // 
            // barBtnQuery
            // 
            this.barBtnQuery.Caption = "查找";
            this.barBtnQuery.Id = 2;
            this.barBtnQuery.ImageIndex = 2;
            this.barBtnQuery.Name = "barBtnQuery";
            this.barBtnQuery.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnExit
            // 
            this.barBtnExit.Caption = "退出";
            this.barBtnExit.Id = 1;
            this.barBtnExit.ImageIndex = 1;
            this.barBtnExit.Name = "barBtnExit";
            this.barBtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExit_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(760, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 532);
            this.barDockControlBottom.Size = new System.Drawing.Size(760, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(760, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Add.png");
            this.imageList.Images.SetKeyName(1, "Exit.png");
            this.imageList.Images.SetKeyName(2, "Query.png");
            this.imageList.Images.SetKeyName(3, "Bought.png");
            this.imageList.Images.SetKeyName(4, "Sold.png");
            this.imageList.Images.SetKeyName(5, "Phone.png");
            this.imageList.Images.SetKeyName(6, "Print.png");
            this.imageList.Images.SetKeyName(7, "QRCode.png");
            this.imageList.Images.SetKeyName(8, "Trade.png");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGrpSold;
            this.navBarControl.AllowSelectedLink = true;
            this.navBarControl.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl.Appearance.NavigationPaneHeader.Options.UseFont = true;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGrpSold,
            this.navBarGrpBought});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5});
            this.navBarControl.LargeImages = this.imageList;
            this.navBarControl.Location = new System.Drawing.Point(0, 40);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 257;
            this.navBarControl.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl.OptionsNavPane.ShowSplitter = false;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(257, 492);
            this.navBarControl.SmallImages = this.imageList;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 9;
            this.navBarControl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl_LinkClicked);
            // 
            // navBarGrpSold
            // 
            this.navBarGrpSold.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGrpSold.Appearance.Options.UseFont = true;
            this.navBarGrpSold.Caption = "已出售";
            this.navBarGrpSold.Expanded = true;
            this.navBarGrpSold.Name = "navBarGrpSold";
            this.navBarGrpSold.SmallImage = global::MobilePhoneLibrary.Properties.Resources.Sold;
            // 
            // navBarGrpBought
            // 
            this.navBarGrpBought.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGrpBought.Appearance.Options.UseFont = true;
            this.navBarGrpBought.Caption = "已收购";
            this.navBarGrpBought.Name = "navBarGrpBought";
            this.navBarGrpBought.SmallImage = global::MobilePhoneLibrary.Properties.Resources.Bought;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "navBarItem3";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "navBarItem4";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "navBarItem5";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // timer
            // 
            this.timer.Interval = 300000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tradeObjectShow
            // 
            this.tradeObjectShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tradeObjectShow.Location = new System.Drawing.Point(257, 40);
            this.tradeObjectShow.Name = "tradeObjectShow";
            this.tradeObjectShow.Size = new System.Drawing.Size(503, 492);
            this.tradeObjectShow.TabIndex = 14;
            this.tradeObjectShow.TradeObject = null;
            // 
            // MainForm
            // 
            this.AlwaysActivate = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(760, 555);
            this.Controls.Add(this.tradeObjectShow);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "手机交易管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barBtnAdd;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraBars.BarButtonItem barBtnExit;
        private DevExpress.XtraBars.BarButtonItem barBtnQuery;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGrpSold;
        private DevExpress.XtraNavBar.NavBarGroup navBarGrpBought;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddSold;
        private DevExpress.XtraBars.BarButtonItem barBtnAddBought;
        private System.Windows.Forms.Timer timer;
        private Controls.TradeObjectShow tradeObjectShow;
        private DevExpress.XtraBars.BarSubItem barBtnPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintQRCode;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintTrade;

    }
}