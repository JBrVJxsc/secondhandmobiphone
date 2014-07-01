
using MobilePhoneLibrary.Classes.Enums;
namespace MobilePhoneLibrary.Controls.Forms.Wizard
{
    public partial class SoldWizard : TradeWizard
    {
        public SoldWizard()
        {
            InitializeComponent();
            tradeObject.TradeType = TradeType.出售;
        }
    }
}
