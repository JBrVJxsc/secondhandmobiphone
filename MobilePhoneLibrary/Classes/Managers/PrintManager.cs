
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using MobilePhoneLibrary.Classes.Objects;
using MobilePhoneLibrary.Controls.Controls;
namespace MobilePhoneLibrary.Classes.Managers
{
    public class PrintManager
    {
        private static string qrCode = string.Empty;
        private static TradeObject tradeObject=null;

        public static void PrintQRCode(string qrCode)
        {
            PrintManager.qrCode = qrCode;
            PrintQRCode();
        }

        public static void PrintTrade(TradeObject tradeObject)
        {
            PrintManager.tradeObject = tradeObject;
            PrintTrade();
        }

        private static BarCodeControl GetBarCodeControl(string qrCode)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            qrCodeGenerator.CompactionMode = QRCodeCompactionMode.Byte;
            qrCodeGenerator.Version = QRCodeVersion.Version3;
            BarCodeControl barCodeControl = new BarCodeControl();
            barCodeControl.AutoModule = true;
            barCodeControl.BackColor = System.Drawing.Color.White;
            barCodeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            barCodeControl.Location = new System.Drawing.Point(317, 7);
            barCodeControl.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            barCodeControl.ShowText = false;
            barCodeControl.Size = new System.Drawing.Size(100, 100);
            barCodeControl.Symbology = qrCodeGenerator;
            barCodeControl.TabIndex = 25;
            barCodeControl.Text = qrCode;
            return barCodeControl;
        }

        private static TradePrint GetTradePrintControl(TradeObject tradeObject)
        {
            TradePrint tradePrint = new TradePrint();
            tradePrint.SetTradeObject(tradeObject);
            return tradePrint;
        }

        private static void PrintQRCode()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printQRCodeDocument = new PrintDocument();
            PrintController printController = new StandardPrintController();
            printQRCodeDocument.PrintController = printController;  
            printDialog.Document = printQRCodeDocument;
            printQRCodeDocument.PrintPage += new PrintPageEventHandler(printQRCodeDocument_PrintPage);
            DialogResult dr = printDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printQRCodeDocument.Print();
            }
        }

        private static void PrintTrade()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printTradeDocument = new PrintDocument();
            PrintController printController = new StandardPrintController();
            printTradeDocument.PrintController = printController;  
            printDialog.Document = printTradeDocument;
            printTradeDocument.PrintPage += new PrintPageEventHandler(printTradeDocument_PrintPage);
            DialogResult dr = printDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printTradeDocument.Print();
            }
        }

        static void printTradeDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            TradePrint tradePrint = GetTradePrintControl(PrintManager.tradeObject);
            Graphics g = e.Graphics;
            Bitmap bitmap = new Bitmap(tradePrint.Width, tradePrint.Height);
            tradePrint.DrawToBitmap(bitmap, new Rectangle(0, 0, tradePrint.Width, tradePrint.Height));
            g.DrawImage(bitmap, new Point(0, 0));
        }

        static void printQRCodeDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarCodeControl barCodeControl = GetBarCodeControl(PrintManager.qrCode);
            Graphics g = e.Graphics;
            Bitmap bitmap = new Bitmap(barCodeControl.Width, barCodeControl.Height);
            barCodeControl.DrawToBitmap(bitmap, new Rectangle(0, 0, barCodeControl.Width, barCodeControl.Height));
            g.DrawImage(bitmap, new Point(0, 0));
        }
    }
}
