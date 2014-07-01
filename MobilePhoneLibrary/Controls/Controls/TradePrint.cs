using System.Windows.Forms;
using MobilePhoneLibrary.Classes.Enums;
using MobilePhoneLibrary.Classes.Objects;

namespace MobilePhoneLibrary.Controls.Controls
{
    public partial class TradePrint : UserControl
    {
        public TradePrint()
        {
            InitializeComponent();
        }

        public void SetTradeObject(TradeObject tradeObject)
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
                lbTradeType.Text = "买家信息：";
            }
            else
            {
                lbTradeType.Text = "卖家信息：";
            }
            lbTradeTime.Text = tradeObject.OperDate.ToString();
        }
    }
}
