using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MobilePhoneLibrary.Controls.Forms
{
    public partial class BaseForm : XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public bool AlwaysActivate
        {
            get;
            set;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x086)
            {
                if (m.WParam == IntPtr.Zero)
                {
                    if (AlwaysActivate)
                    {
                        m.WParam = new IntPtr(1);
                    }
                }
            }
            base.WndProc(ref m);
        }
    }
}
