namespace MobilePhoneLibrary.Controls.Forms.Wizard
{
    partial class TradeWizard
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeWizard));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.galleryControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControlPhoneInfo = new DevExpress.XtraLayout.LayoutControl();
            this.txtIMEI = new DevExpress.XtraEditors.TextEdit();
            this.calcEditPrice = new DevExpress.XtraEditors.CalcEdit();
            this.colorEdit = new DevExpress.XtraEditors.ColorEdit();
            this.cmbBrand = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbBrand = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbModel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbIMEI = new DevExpress.XtraLayout.LayoutControlItem();
            this.wizardPagePersonInfo = new DevExpress.XtraWizard.WizardPage();
            this.btPrint = new DevExpress.XtraEditors.SimpleButton();
            this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
            this.layoutControlPersonInfo = new DevExpress.XtraLayout.LayoutControl();
            this.txtPersonPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonID = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbPersonName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPersonID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbPersonPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).BeginInit();
            this.galleryControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPhoneInfo)).BeginInit();
            this.layoutControlPhoneInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIMEI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbIMEI)).BeginInit();
            this.wizardPagePersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPersonInfo)).BeginInit();
            this.layoutControlPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.CancelText = "取消";
            this.wizardControl.Controls.Add(this.welcomeWizardPage);
            this.wizardControl.Controls.Add(this.wizardPagePersonInfo);
            this.wizardControl.Controls.Add(this.completionWizardPage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.FinishText = "&完成";
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.MinimumSize = new System.Drawing.Size(117, 117);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.NextText = "&下一步 >";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wizardPagePersonInfo,
            this.completionWizardPage});
            this.wizardControl.PreviousText = "< &上一步";
            this.wizardControl.Size = new System.Drawing.Size(812, 562);
            this.wizardControl.Text = "上一步";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_PrevClick);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.AllowNext = false;
            this.welcomeWizardPage.Controls.Add(this.galleryControl);
            this.welcomeWizardPage.Controls.Add(this.layoutControlPhoneInfo);
            this.welcomeWizardPage.IntroductionText = "";
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = "";
            this.welcomeWizardPage.Size = new System.Drawing.Size(752, 400);
            this.welcomeWizardPage.Text = "输入手机信息";
            // 
            // galleryControl
            // 
            this.galleryControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.galleryControl.Controls.Add(this.galleryControlClient);
            this.galleryControl.DesignGalleryGroupIndex = 0;
            this.galleryControl.DesignGalleryItemIndex = 0;
            this.galleryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "Item1";
            galleryItem1.ImageIndex = 0;
            galleryItem2.Caption = "Item2";
            galleryItem2.ImageIndex = 1;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
            this.galleryControl.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl.Gallery.Images = this.imageCollection;
            this.galleryControl.Gallery.ImageSize = new System.Drawing.Size(500, 400);
            this.galleryControl.Gallery.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.galleryControl.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth;
            this.galleryControl.Gallery.ShowGroupCaption = false;
            this.galleryControl.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.galleryControl.Location = new System.Drawing.Point(252, 0);
            this.galleryControl.Name = "galleryControl";
            this.galleryControl.Size = new System.Drawing.Size(500, 400);
            this.galleryControl.TabIndex = 3;
            // 
            // galleryControlClient
            // 
            this.galleryControlClient.GalleryControl = this.galleryControl;
            this.galleryControlClient.Location = new System.Drawing.Point(1, 1);
            this.galleryControlClient.Size = new System.Drawing.Size(498, 398);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(500, 400);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "FindIMEIWayOne.png");
            this.imageCollection.Images.SetKeyName(1, "FindIMEIWayTwo.png");
            // 
            // layoutControlPhoneInfo
            // 
            this.layoutControlPhoneInfo.Controls.Add(this.txtIMEI);
            this.layoutControlPhoneInfo.Controls.Add(this.calcEditPrice);
            this.layoutControlPhoneInfo.Controls.Add(this.colorEdit);
            this.layoutControlPhoneInfo.Controls.Add(this.cmbBrand);
            this.layoutControlPhoneInfo.Controls.Add(this.cmbModel);
            this.layoutControlPhoneInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControlPhoneInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPhoneInfo.Name = "layoutControlPhoneInfo";
            this.layoutControlPhoneInfo.Root = this.layoutControlGroup;
            this.layoutControlPhoneInfo.Size = new System.Drawing.Size(252, 400);
            this.layoutControlPhoneInfo.TabIndex = 2;
            // 
            // txtIMEI
            // 
            this.txtIMEI.EnterMoveNextControl = true;
            this.txtIMEI.Location = new System.Drawing.Point(59, 132);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIMEI.Properties.Appearance.Options.UseFont = true;
            this.txtIMEI.Size = new System.Drawing.Size(181, 26);
            this.txtIMEI.StyleController = this.layoutControlPhoneInfo;
            this.txtIMEI.TabIndex = 3;
            this.txtIMEI.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // calcEditPrice
            // 
            this.calcEditPrice.EnterMoveNextControl = true;
            this.calcEditPrice.Location = new System.Drawing.Point(59, 102);
            this.calcEditPrice.Name = "calcEditPrice";
            this.calcEditPrice.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calcEditPrice.Properties.Appearance.Options.UseFont = true;
            this.calcEditPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditPrice.Properties.Precision = 2;
            this.calcEditPrice.Size = new System.Drawing.Size(181, 26);
            this.calcEditPrice.StyleController = this.layoutControlPhoneInfo;
            this.calcEditPrice.TabIndex = 3;
            this.calcEditPrice.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // colorEdit
            // 
            this.colorEdit.EditValue = System.Drawing.Color.Empty;
            this.colorEdit.EnterMoveNextControl = true;
            this.colorEdit.Location = new System.Drawing.Point(59, 72);
            this.colorEdit.Name = "colorEdit";
            this.colorEdit.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.colorEdit.Properties.Appearance.Options.UseFont = true;
            this.colorEdit.Properties.Appearance.Options.UseForeColor = true;
            this.colorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit.Properties.ShowSystemColors = false;
            this.colorEdit.Properties.ShowWebColors = false;
            this.colorEdit.Size = new System.Drawing.Size(181, 26);
            this.colorEdit.StyleController = this.layoutControlPhoneInfo;
            this.colorEdit.TabIndex = 3;
            this.colorEdit.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // cmbBrand
            // 
            this.cmbBrand.EditValue = "";
            this.cmbBrand.EnterMoveNextControl = true;
            this.cmbBrand.Location = new System.Drawing.Point(59, 12);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBrand.Properties.Appearance.Options.UseFont = true;
            this.cmbBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrand.Size = new System.Drawing.Size(181, 26);
            this.cmbBrand.StyleController = this.layoutControlPhoneInfo;
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            this.cmbBrand.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.EditValue = "";
            this.cmbModel.EnterMoveNextControl = true;
            this.cmbModel.Location = new System.Drawing.Point(59, 42);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbModel.Properties.Appearance.Options.UseFont = true;
            this.cmbModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbModel.Size = new System.Drawing.Size(181, 26);
            this.cmbModel.StyleController = this.layoutControlPhoneInfo;
            this.cmbModel.TabIndex = 3;
            this.cmbModel.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.CustomizationFormText = "layoutControlGroup";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbBrand,
            this.lbModel,
            this.lbColor,
            this.lbPrice,
            this.lbIMEI});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(252, 400);
            this.layoutControlGroup.Text = "layoutControlGroup";
            this.layoutControlGroup.TextVisible = false;
            // 
            // lbBrand
            // 
            this.lbBrand.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBrand.AppearanceItemCaption.Options.UseFont = true;
            this.lbBrand.Control = this.cmbBrand;
            this.lbBrand.CustomizationFormText = "手机品牌：";
            this.lbBrand.Location = new System.Drawing.Point(0, 0);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(232, 30);
            this.lbBrand.Text = "品牌：";
            this.lbBrand.TextSize = new System.Drawing.Size(44, 20);
            // 
            // lbModel
            // 
            this.lbModel.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbModel.AppearanceItemCaption.Options.UseFont = true;
            this.lbModel.Control = this.cmbModel;
            this.lbModel.CustomizationFormText = "手机型号：";
            this.lbModel.Location = new System.Drawing.Point(0, 30);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(232, 30);
            this.lbModel.Text = "型号：";
            this.lbModel.TextSize = new System.Drawing.Size(44, 20);
            // 
            // lbColor
            // 
            this.lbColor.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbColor.AppearanceItemCaption.Options.UseFont = true;
            this.lbColor.Control = this.colorEdit;
            this.lbColor.CustomizationFormText = "颜色：";
            this.lbColor.Location = new System.Drawing.Point(0, 60);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(232, 30);
            this.lbColor.Text = "颜色：";
            this.lbColor.TextSize = new System.Drawing.Size(44, 20);
            // 
            // lbPrice
            // 
            this.lbPrice.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPrice.AppearanceItemCaption.Options.UseFont = true;
            this.lbPrice.Control = this.calcEditPrice;
            this.lbPrice.CustomizationFormText = "价格：";
            this.lbPrice.Location = new System.Drawing.Point(0, 90);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(232, 30);
            this.lbPrice.Text = "价格：";
            this.lbPrice.TextSize = new System.Drawing.Size(44, 20);
            // 
            // lbIMEI
            // 
            this.lbIMEI.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIMEI.AppearanceItemCaption.Options.UseFont = true;
            this.lbIMEI.Control = this.txtIMEI;
            this.lbIMEI.CustomizationFormText = "IMEI：";
            this.lbIMEI.Location = new System.Drawing.Point(0, 120);
            this.lbIMEI.Name = "lbIMEI";
            this.lbIMEI.Size = new System.Drawing.Size(232, 260);
            this.lbIMEI.Text = "IMEI：";
            this.lbIMEI.TextSize = new System.Drawing.Size(44, 20);
            // 
            // wizardPagePersonInfo
            // 
            this.wizardPagePersonInfo.AllowNext = false;
            this.wizardPagePersonInfo.Controls.Add(this.btPrint);
            this.wizardPagePersonInfo.Controls.Add(this.barCodeControl);
            this.wizardPagePersonInfo.Controls.Add(this.layoutControlPersonInfo);
            this.wizardPagePersonInfo.DescriptionText = "";
            this.wizardPagePersonInfo.Name = "wizardPagePersonInfo";
            this.wizardPagePersonInfo.Size = new System.Drawing.Size(752, 400);
            this.wizardPagePersonInfo.Text = "输入买家\\卖家信息";
            // 
            // btPrint
            // 
            this.btPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Appearance.Options.UseFont = true;
            this.btPrint.Appearance.Options.UseTextOptions = true;
            this.btPrint.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btPrint.Image = global::MobilePhoneLibrary.Properties.Resources.Print;
            this.btPrint.Location = new System.Drawing.Point(327, 358);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(128, 38);
            this.btPrint.TabIndex = 26;
            this.btPrint.Text = "打印二维码";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // barCodeControl
            // 
            this.barCodeControl.AutoModule = true;
            this.barCodeControl.BackColor = System.Drawing.Color.White;
            this.barCodeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControl.Location = new System.Drawing.Point(317, 7);
            this.barCodeControl.Name = "barCodeControl";
            this.barCodeControl.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl.ShowText = false;
            this.barCodeControl.Size = new System.Drawing.Size(350, 350);
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version3;
            this.barCodeControl.Symbology = qrCodeGenerator1;
            this.barCodeControl.TabIndex = 25;
            // 
            // layoutControlPersonInfo
            // 
            this.layoutControlPersonInfo.Controls.Add(this.txtPersonPhoneNumber);
            this.layoutControlPersonInfo.Controls.Add(this.txtPersonID);
            this.layoutControlPersonInfo.Controls.Add(this.txtPersonName);
            this.layoutControlPersonInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControlPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.layoutControlPersonInfo.Name = "layoutControlPersonInfo";
            this.layoutControlPersonInfo.Root = this.layoutControlGroup1;
            this.layoutControlPersonInfo.Size = new System.Drawing.Size(252, 400);
            this.layoutControlPersonInfo.TabIndex = 1;
            this.layoutControlPersonInfo.Text = "layoutControl1";
            // 
            // txtPersonPhoneNumber
            // 
            this.txtPersonPhoneNumber.EnterMoveNextControl = true;
            this.txtPersonPhoneNumber.Location = new System.Drawing.Point(71, 72);
            this.txtPersonPhoneNumber.Name = "txtPersonPhoneNumber";
            this.txtPersonPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPersonPhoneNumber.Size = new System.Drawing.Size(169, 26);
            this.txtPersonPhoneNumber.StyleController = this.layoutControlPersonInfo;
            this.txtPersonPhoneNumber.TabIndex = 27;
            this.txtPersonPhoneNumber.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtPersonID
            // 
            this.txtPersonID.EditValue = "";
            this.txtPersonID.EnterMoveNextControl = true;
            this.txtPersonID.Location = new System.Drawing.Point(71, 42);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonID.Properties.Appearance.Options.UseFont = true;
            this.txtPersonID.Properties.Mask.EditMask = "c";
            this.txtPersonID.Size = new System.Drawing.Size(169, 26);
            this.txtPersonID.StyleController = this.layoutControlPersonInfo;
            this.txtPersonID.TabIndex = 5;
            this.txtPersonID.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // txtPersonName
            // 
            this.txtPersonName.EnterMoveNextControl = true;
            this.txtPersonName.Location = new System.Drawing.Point(71, 12);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPersonName.Properties.Appearance.Options.UseFont = true;
            this.txtPersonName.Properties.Mask.EditMask = "d";
            this.txtPersonName.Size = new System.Drawing.Size(169, 26);
            this.txtPersonName.StyleController = this.layoutControlPersonInfo;
            this.txtPersonName.TabIndex = 4;
            this.txtPersonName.TextChanged += new System.EventHandler(this.TextControl_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbPersonName,
            this.lbPersonID,
            this.lbPersonPhoneNumber});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(252, 400);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lbPersonName
            // 
            this.lbPersonName.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPersonName.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonName.Control = this.txtPersonName;
            this.lbPersonName.CustomizationFormText = "姓名：";
            this.lbPersonName.Location = new System.Drawing.Point(0, 0);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Size = new System.Drawing.Size(232, 30);
            this.lbPersonName.Text = "姓名：";
            this.lbPersonName.TextSize = new System.Drawing.Size(56, 20);
            // 
            // lbPersonID
            // 
            this.lbPersonID.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPersonID.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonID.Control = this.txtPersonID;
            this.lbPersonID.CustomizationFormText = "身份证：";
            this.lbPersonID.Location = new System.Drawing.Point(0, 30);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(232, 30);
            this.lbPersonID.Text = "身份证：";
            this.lbPersonID.TextSize = new System.Drawing.Size(56, 20);
            // 
            // lbPersonPhoneNumber
            // 
            this.lbPersonPhoneNumber.AppearanceItemCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonPhoneNumber.AppearanceItemCaption.Options.UseFont = true;
            this.lbPersonPhoneNumber.Control = this.txtPersonPhoneNumber;
            this.lbPersonPhoneNumber.CustomizationFormText = "电话：";
            this.lbPersonPhoneNumber.Location = new System.Drawing.Point(0, 60);
            this.lbPersonPhoneNumber.Name = "lbPersonPhoneNumber";
            this.lbPersonPhoneNumber.Size = new System.Drawing.Size(232, 320);
            this.lbPersonPhoneNumber.Text = "电话：";
            this.lbPersonPhoneNumber.TextSize = new System.Drawing.Size(56, 20);
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.Size = new System.Drawing.Size(752, 400);
            // 
            // timer
            // 
            this.timer.Interval = 8000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TradeWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.wizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TradeWizard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TradeWizard";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).EndInit();
            this.galleryControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPhoneInfo)).EndInit();
            this.layoutControlPhoneInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIMEI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbIMEI)).EndInit();
            this.wizardPagePersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPersonInfo)).EndInit();
            this.layoutControlPersonInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPersonPhoneNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrand;
        private DevExpress.XtraLayout.LayoutControl layoutControlPhoneInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cmbModel;
        private DevExpress.XtraLayout.LayoutControlItem lbBrand;
        private DevExpress.XtraLayout.LayoutControlItem lbModel;
        protected DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraEditors.ColorEdit colorEdit;
        private DevExpress.XtraLayout.LayoutControlItem lbColor;
        private DevExpress.XtraEditors.CalcEdit calcEditPrice;
        private DevExpress.XtraLayout.LayoutControlItem lbPrice;
        private DevExpress.XtraEditors.TextEdit txtIMEI;
        private DevExpress.XtraLayout.LayoutControlItem lbIMEI;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraWizard.WizardPage wizardPagePersonInfo;
        private DevExpress.XtraLayout.LayoutControl layoutControlPersonInfo;
        private DevExpress.XtraEditors.TextEdit txtPersonID;
        private DevExpress.XtraEditors.TextEdit txtPersonName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonName;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonID;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
        private DevExpress.XtraEditors.SimpleButton btPrint;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraEditors.TextEdit txtPersonPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem lbPersonPhoneNumber;
    }
}