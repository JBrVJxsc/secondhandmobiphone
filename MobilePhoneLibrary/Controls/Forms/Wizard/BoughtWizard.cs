
using MobilePhoneLibrary.Classes.Enums;
namespace MobilePhoneLibrary.Controls.Forms.Wizard
{
    public partial class BoughtWizard : TradeWizard
    {
        public BoughtWizard()
        {
            InitializeComponent();
            tradeObject.TradeType = TradeType.收购;
        }
    }
}
