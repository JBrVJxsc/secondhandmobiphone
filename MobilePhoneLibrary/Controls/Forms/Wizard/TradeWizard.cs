using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using MobilePhoneLibrary.Classes.Managers;
using MobilePhoneLibrary.Classes.Objects;
using MobilePhoneLoader.Class.Managers;
using MobilePhoneLoader.Controls.Forms;

namespace MobilePhoneLibrary.Controls.Forms.Wizard
{
    public partial class TradeWizard : BaseForm, IMessageFilter
    {
        public TradeWizard()
        {
            InitializeComponent();
            InitBrandComboBox();
            InitQRCode();
            InitColor();
            InitUserCode();
        }

        protected TradeObject tradeObject = new TradeObject();
        private CommunicationManager communicationManager = new CommunicationManager();
        private XmlManager<TradeObject> tradeObjectXmlManager = new XmlManager<TradeObject>();
        private int currentShowPhotoIndex = 0;
        private string userCode = string.Empty;
        private static SortedList GlobalBrandList = null;
        private static Hashtable htModelList = new Hashtable();

        public virtual string CompletionText
        {
            get
            {
                return wizardPagePersonInfo.Text;
            }
            set
            {
                wizardPagePersonInfo.Text = value;
            }
        }

        private void InitBrandComboBox()
        {
            if (GlobalBrandList == null)
            {
                GlobalBrandList = DataBaseManager.GlobalDataBaseManager.QueryAllBrand();
            }
            foreach (DictionaryEntry de in GlobalBrandList)
            {
                cmbBrand.Properties.Items.Add(de.Key);
            }
        }

        private void InitQRCode()
        {
            barCodeControl.Text = tradeObject.TradeID;
        }

        private void InitColor()
        {
            colorEdit.Color = Color.Black;
        }

        private void InitUserCode()
        {
            userCode = UserCodeManager.GetUserCode();
        }

        private void ChangeIMEIHelp()
        {
            if (currentShowPhotoIndex == 0)
            {
                galleryControl.Gallery.ScrollTo(galleryControl.Gallery.Groups[0].Items[1], true);
                currentShowPhotoIndex = 1;
            }
            else
            {
                galleryControl.Gallery.ScrollTo(galleryControl.Gallery.Groups[0].Items[0], true);
                currentShowPhotoIndex = 0;
            }
        }

        private void FillTradeObject()
        {
            tradeObject.Brand = cmbBrand.Text;
            tradeObject.Model = cmbModel.Text;
            tradeObject.SetPhoneColor(colorEdit.Color);
            tradeObject.Price = calcEditPrice.Value;
            tradeObject.IMEI = txtIMEI.Text;
            tradeObject.PersonName = txtPersonName.Text;
            tradeObject.PersonID = txtPersonID.Text;
            tradeObject.PersonPhoneNumber = txtPersonPhoneNumber.Text;
            tradeObject.OperName = userCode;
            tradeObject.OperDate = DateTime.Now;
        }

        private bool SaveTrade()
        {
            int i = DataBaseManager.GlobalDataBaseManager.InsertTradeObject(tradeObject);
            if (i < 0)
            {
                return false;
            }
            tradeObject.SendToServer = true;
            if (communicationManager.SendTrade(tradeObject.PersonID, tradeObjectXmlManager.SerializeToString(tradeObject)))
            {
                i = DataBaseManager.GlobalDataBaseManager.UpdateTradeByTradeID(tradeObject, tradeObject.TradeID);
                if (i < 0)
                {
                    tradeObject.SendToServer = false;
                    return false;
                }
            }
            return true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            timer.Start();
            cmbBrand.Focus();
            Application.AddMessageFilter(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ChangeIMEIHelp();
        }

        private void TextControl_TextChanged(object sender, EventArgs e)
        {
            if (cmbBrand.Text.Trim() == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (cmbModel.Text.Trim() == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (calcEditPrice.Text == string.Empty)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else if (txtIMEI.Text.Trim() == string.Empty || txtIMEI.Text.Length < 15 || txtIMEI.Text.Length > 17)
            {
                welcomeWizardPage.AllowNext = false;
            }
            else
            {
                welcomeWizardPage.AllowNext = true;
            }

            if (txtPersonName.Text.Trim() == string.Empty)
            {
                wizardPagePersonInfo.AllowNext = false;
            }
            else if (txtPersonID.Text.Trim() == string.Empty || txtPersonID.Text.Trim().Length != 15 && txtPersonID.Text.Trim().Length != 18 || !PersonIDManager.CheckIDCard(txtPersonID.Text))
            {
                wizardPagePersonInfo.AllowNext = false;
            }
            else if (txtPersonPhoneNumber.Text.Trim() == string.Empty)
            {
                wizardPagePersonInfo.AllowNext = false;
            }
            else
            {
                wizardPagePersonInfo.AllowNext = true;
            }
            FillTradeObject();
        }

        private void wizardControl_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == welcomeWizardPage)
            {
                wizardControl.NextText = "&提交";        
            }
            else if (e.Page == wizardPagePersonInfo)
            {
                DialogResult dr = XtraMessageBox.Show("提交后不可更改，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes)
                {
                    e.Handled = true;
                    return;
                }
                if (!SaveTrade())
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = true;
                    XtraMessageBox.Show("提交成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void wizardControl_PrevClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPagePersonInfo)
            {
                wizardControl.NextText = "&下一步 >";
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedItem == null)
            {
                return;
            }
            string brandEnglishName = (cmbBrand.SelectedItem as BrandObject).EnglishName;
            SortedList modelList = null;
            if (htModelList.Contains(brandEnglishName))
            {
                modelList = htModelList[brandEnglishName] as SortedList;
            }
            else
            {
                modelList = DataBaseManager.GlobalDataBaseManager.QueryModelByBrandEnglishName(brandEnglishName);
                if (modelList == null || modelList.Count == 0)
                {
                    return;
                }
                else
                {
                    htModelList.Add(brandEnglishName, modelList);
                }
            }
            cmbModel.Properties.Items.Clear();
            cmbModel.Text = string.Empty;
            foreach (DictionaryEntry de in modelList)
            {
                cmbModel.Properties.Items.Add(de.Key);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            btPrint.Enabled = false;
            try
            {
                PrintManager.PrintQRCode(tradeObject.TradeID);
            }
            catch (Exception ex)
            {
                LogManager.GlobalLogManager.CreateLog(ex);
                XtraMessageBox.Show("打印出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btPrint.Enabled = true;
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (!galleryControl.Focused)
            {
                return false;
            }
            if (m.Msg == 522)
            {
                return true;
            }
            return false;
        }
    }
}
