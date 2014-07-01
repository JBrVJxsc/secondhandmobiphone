using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using MobilePhoneLibrary.Classes.Enums;
using MobilePhoneLibrary.Classes.Managers;
using MobilePhoneLibrary.Classes.Objects;
using MobilePhoneLibrary.Controls.Forms.Wizard;
using MobilePhoneLoader.Class.Managers;

namespace MobilePhoneLibrary.Controls.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshTrade();
            timer.Start();
        }

        private CommunicationManager communicationManager = new CommunicationManager();
        private XmlManager<TradeObject> tradeObjectXmlManager = new XmlManager<TradeObject>();
        private TradeObject currentTradeObject = null;

        private void RefreshTrade()
        {
            navBarControl.Items.Clear();
            List<TradeObject> soldList = DataBaseManager.GlobalDataBaseManager.QueryTrade(100, TradeType.出售);
            List<TradeObject> boughtList = DataBaseManager.GlobalDataBaseManager.QueryTrade(100, TradeType.收购);
            AddSold(soldList);
            AddBought(boughtList);
        }

        private void AddSold(List<TradeObject> tradeObjectList)
        {
            foreach (TradeObject tradeObject in tradeObjectList)
            {
                AddItem(navBarGrpSold, tradeObject, "品牌：" + tradeObject.Brand + "\n型号：" + tradeObject.Model + "\n买家：" + tradeObject.PersonName + "\n时间：" + tradeObject.OperDate.ToString());
            }
        }

        private void AddBought(List<TradeObject> tradeObjectList)
        {
            foreach (TradeObject tradeObject in tradeObjectList)
            {
                AddItem(navBarGrpBought, tradeObject, "品牌：" + tradeObject.Brand + "\n型号：" + tradeObject.Model + "\n卖家：" + tradeObject.PersonName + "\n时间：" + tradeObject.OperDate.ToString());
            }
        }

        private void AddItem(NavBarGroup navBarGroup,TradeObject tradeObject, string caption)
        {
            NavBarItem item = navBarControl.Items.Add();
            item.Tag = tradeObject;
            item.LargeImageIndex = item.SmallImageIndex = 5;
            item.Caption = caption;
            item.Appearance.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            navBarGroup.ItemLinks.Add(item);
        }

        private void CheckSendServer()
        {
            List<TradeObject> tradeObjectList = DataBaseManager.GlobalDataBaseManager.QueryUnsendedTrade();
            foreach (TradeObject tradeObject in tradeObjectList)
            {
                if (communicationManager.SendTrade(tradeObject.PersonID, tradeObjectXmlManager.SerializeToString(tradeObject)))
                {
                    DataBaseManager.GlobalDataBaseManager.UpdateTradeByTradeID(tradeObject, tradeObject.TradeID);
                }
            }
        }

        private void barBtnAddSold_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SoldWizard soldWizard = new SoldWizard();
            soldWizard.ShowDialog();
            RefreshTrade();
        }

        private void barBtnAddBought_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BoughtWizard boughtWizard = new BoughtWizard();
            boughtWizard.ShowDialog();
            RefreshTrade();
        }

        private void barBtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            CheckSendServer();
        }

        private void navBarControl_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag as TradeObject != null)
            {
                currentTradeObject = e.Link.Item.Tag as TradeObject;
                tradeObjectShow.TradeObject = currentTradeObject;
            }
        }

        private void barBtnPrintQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currentTradeObject == null)
            {
                return;
            }
            barBtnPrintQRCode.Enabled = false;
            try
            {
                PrintManager.PrintQRCode(currentTradeObject.TradeID);
            }
            catch (Exception ex)
            {
                LogManager.GlobalLogManager.CreateLog(ex);
                XtraMessageBox.Show("打印二维码出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                barBtnPrintQRCode.Enabled = true;
            }
        }

        private void barBtnPrintTrade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currentTradeObject == null)
            {
                return;
            }
            barBtnPrintTrade.Enabled = false;
            try
            {
                PrintManager.PrintTrade(currentTradeObject);
            }
            catch (Exception ex)
            {
                LogManager.GlobalLogManager.CreateLog(ex);
                XtraMessageBox.Show("打印记录出错。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                barBtnPrintTrade.Enabled = true;
            }
        }
    }
}
