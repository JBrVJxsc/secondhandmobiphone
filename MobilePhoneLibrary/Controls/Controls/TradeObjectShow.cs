using System.Windows.Forms;
using MobilePhoneLibrary.Classes.Enums;
using MobilePhoneLibrary.Classes.Objects;

namespace MobilePhoneLibrary.Controls.Controls
{
    public partial class TradeObjectShow : UserControl
    {
        public TradeObjectShow()
        {
            InitializeComponent();
        }

        private TradeObject tradeObject = null;

        public TradeObject TradeObject
        {
            get
            {
                return tradeObject;
            }
            set
            {
                tradeObject = value;
                if (tradeObject == null)
                {
                    return;
                }
                FillTradeObjectShow();
            }
        }

        private void FillTradeObjectShow()
        {
            txtPhoneBrand.Text = tradeObject.Brand;
            txtPhoneModel.Text = tradeObject.Model;
            colorEditPhoneColor.Color = tradeObject.GetPhoneColor();
            txtPhonePrice.Text = tradeObject.Price.ToString();
            txtPhoneIMEI.Text = tradeObject.IMEI;
            txtPersonName.Text = tradeObject.PersonName;
            txtPersonID.Text = tradeObject.PersonID;
            txtPersonPhoneNumber.Text = tradeObject.PersonPhoneNumber;
            if (tradeObject.TradeType == TradeType.出售)
            {
                xtraTabPagePersonInfo.Text = "买家信息";
            }
            else
            {
                xtraTabPagePersonInfo.Text = "卖家信息";
            }
        }
    }
}
