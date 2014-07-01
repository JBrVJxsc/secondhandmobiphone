using System;
using System.Drawing;
using MobilePhoneLibrary.Classes.Enums;
using MobilePhoneLibrary.Classes.Managers;

namespace MobilePhoneLibrary.Classes.Objects
{
    public class TradeObject
    {
        public TradeObject()
        {
            if (TradeID == null || TradeID == string.Empty)
            {
                TradeID = GuidManager.GetNewGuid();
            }
        }

        public string TradeID
        {
            get;
            set;
        }

        public TradeType TradeType
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string PhoneColor
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public string IMEI
        {
            get;
            set;
        }

        public string PersonName
        {
            get;
            set;
        }

        public string PersonID
        {
            get;
            set;
        }

        public string PersonPhoneNumber
        {
            get;
            set;
        }

        public string OperName
        {
            get;
            set;
        }

        public DateTime OperDate
        {
            get;
            set;
        }

        public bool SendToServer
        {
            get;
            set;
        }

        public void SetPhoneColor(Color color)
        {
            PhoneColor = ColorTranslator.ToHtml(color);
        }

        public Color GetPhoneColor()
        {
            return ColorTranslator.FromHtml(PhoneColor);
        }
    }
}
