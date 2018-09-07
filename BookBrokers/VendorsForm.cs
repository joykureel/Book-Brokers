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
    public partial class VendorsForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountofInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;
        
        public VendorsForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnPrintVendors_Click(object sender, EventArgs e)
        {
            amountofInvoicesPrinted = 0;
            string strFilter = "";
            string strSort = "VendorID";
            invoicesForPrint = DM.dsBookBrokers.Tables["Vendor"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvVendorInvoices.Show();
        }

        private void printVendorInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drVendors = invoicesForPrint[amountofInvoicesPrinted];
            //currency manager
            CurrencyManager cmVendor;
            CurrencyManager cmBook;
            CurrencyManager cmCountry;
            CurrencyManager cmBookInfo;
            CurrencyManager cmAuthor;

            //Binding context to currencymanager
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Vendor"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Country"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BookInfo"];
            cmAuthor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Author"];

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 0;
            int topMarginDetails = topMargin + 30;
            int rightMargin = e.MarginBounds.Right;

            //getting Vendor with Vendor id

            
            //getting country with country id
            int aCountryID = Convert.ToInt32(drVendors["CountryID"].ToString());
            cmCountry.Position = DM.CountryView.Find(aCountryID);
            DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];

            //getting book with vendor id
            int aBookID = Convert.ToInt32(drVendors["VendorID"].ToString());
            cmBook.Position = DM.BookView.Find(aBookID);
            DataRow drBook = DM.dtBook.Rows[cmBook.Position];




            //display 

            //heading
            g.DrawString("Vendor ID:    " + drVendors["VendorID"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString(drVendors["VendorName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString("PO Box " + drVendors["PostBoxNumber"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drCountry["CountryName"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            g.DrawString(drVendors["Email"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            g.DrawString("Books: ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            
            DataRow[] drBooks = drVendors.GetChildRows(DM.dtVendor.ChildRelations["VENDOR_BOOK"]);

            if (drBooks.Length == 0)
            {
                g.DrawString("This Vendor has no Books at all" + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            }
            else
            {
                foreach (DataRow drShowBook in drBooks)
                {
                    if (drShowBook["ClientOrderID"].ToString() == "")
                    {



                        //get the book info record
                        int aBookInfoID = Convert.ToInt32(drShowBook["BookInfoID"].ToString());
                        cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
                        DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
                        //get the author  record
                        int aAUthor = Convert.ToInt32(drShowBook["BookInfoID"].ToString());
                        cmAuthor.Position = DM.AuthorView.Find(aAUthor);
                        DataRow drAuthor = DM.dtAuthor.Rows[cmAuthor.Position];

                        g.DrawString(drShowBook["BookID"] + "", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drBookInfo["Title"] + "", headingFont, brush, leftMargin + 30 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString("$" + drShowBook["Cost"] + "", headingFont, brush, leftMargin + 250 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString("$" + drShowBook["Price"] + "", headingFont, brush, leftMargin + 320 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drShowBook["DatePublished"] + "", headingFont, brush, leftMargin + 390 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                        g.DrawString(drAuthor["LastName"] + " " + drAuthor["FirstName"], headingFont, brush, leftMargin + 550 + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                        linesSoFarHeading++;

                        //Add price for total

                    }


                }
                linesSoFarHeading++;
                linesSoFarHeading++;

            }

            amountofInvoicesPrinted++;
            if (!(amountofInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }


    



        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
