using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrokers
{
    public partial class InvoicesForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private DataRow[] invoicesForPrint;
        private int amountofInvoicesPrinted, pagesAmountExpected;

        public InvoicesForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 13, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 13, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 13, FontStyle.Bold);
            Font headingFont = new Font("Arial", 13, FontStyle.Bold);
            DataRow drClientOrder = invoicesForPrint[amountofInvoicesPrinted];
            CurrencyManager cmClientOrder;
            CurrencyManager cmClient;
            CurrencyManager cmBook;
            CurrencyManager cmBookInfo;
            CurrencyManager cmCountry;

            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            // get the clientorder and client record
            int aClientID = Convert.ToInt32(drClientOrder["ClientID"].ToString());
            cmClient.Position = DM.ClientOrderView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];

            //get the book record
            int aClientOrderID = Convert.ToInt32(drClientOrder["ClientOrderID"].ToString());
            cmClientOrder.Position = DM.ClientOrderView.Find(aClientOrderID);
            DataRow drBook = DM.dtBook.Rows[cmBook.Position];

            //get country with countryis
            int aCountryID = Convert.ToInt32(drClient["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];



            //heading
            g.DrawString("Client ID:    " + drClientOrder["ClientID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString(drClient["LastName"] + " " + drClient["FirstName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["StreetAddress"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["Suburb"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drClient["City"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Client Order ID: " + drClientOrder["ClientOrderID"] + "   Date:  " + drClientOrder["OrderDate"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Books: ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            
            DataRow[] drBooks = drClientOrder.GetChildRows(DM.dtClientOrder.ChildRelations["CLIENTORDER_BOOK"]);
            double price;
            price = 0.00;
            if (drBooks.Length == 0)
            {
                g.DrawString("This Client has no Order" + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            }
            else
            {
                foreach (DataRow drClientOrderID in drBooks)
                {



                    //get the book info record
                    int aBookInfoID = Convert.ToInt32(drClientOrderID["BookInfoID"].ToString());
                    cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                    DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];

                    g.DrawString(drClientOrderID["BookID"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString(drBookInfo["Title"] + "", headingFont, brush, leftMargin + 70 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    g.DrawString("$" + drClientOrderID["Price"] + "", headingFont, brush, leftMargin + 400 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                    linesSoFarHeading++;

                    //Add price for total
                    price += Convert.ToDouble(drBook["Price"]);




                }
                linesSoFarHeading++;
                linesSoFarHeading++;
                g.DrawString("Total:  $" + Convert.ToString(price), headingFont, brush, leftMargin + 340 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
            }
            price = 0;


            amountofInvoicesPrinted++;
            if (!(amountofInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }






        }


        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            amountofInvoicesPrinted = 0;
            string strFilter = "Status = 'Shipped'";
            string strSort = "ClientOrderID";
            invoicesForPrint = DM.dsBookBrokers.Tables["CLIENTORDER"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();
        }
    }
}
