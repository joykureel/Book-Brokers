using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BookBrokers
{
    public partial class DataModule : Form
    {
        public DataTable dtAuthor;
        public DataTable dtBook;
        public DataTable dtClient;
        public DataTable dtBookInfo;
        public DataTable dtClientOrder;
        public DataTable dtCountry;
        public DataTable dtVendor;
        public DataView AuthorView;
        public DataView BookView;
        public DataView ClientView;
        public DataView BookInfoView;
        public DataView ClientOrderView;
        public DataView CountryView;
        public DataView VendorView;


        public DataModule()
        {
            InitializeComponent();
            dsBookBrokers.EnforceConstraints = false;
            daAuthor.Fill(dsBookBrokers);
            daBook.Fill(dsBookBrokers);
            daBookInfo.Fill(dsBookBrokers);
            daClient.Fill(dsBookBrokers);
            daClientOrder.Fill(dsBookBrokers);
            daCountry.Fill(dsBookBrokers);
            daVendor.Fill(dsBookBrokers);
            dtAuthor = dsBookBrokers.Tables["Author"];
            dtBook = dsBookBrokers.Tables["Book"];
            dtBookInfo = dsBookBrokers.Tables["BookInfo"];
            dtClient = dsBookBrokers.Tables["Client"];
            dtClientOrder = dsBookBrokers.Tables["ClientOrder"];
            dtCountry = dsBookBrokers.Tables["Country"];
            dtVendor = dsBookBrokers.Tables["Vendor"];
            dsBookBrokers.EnforceConstraints = true;
            CountryView = new DataView(dtCountry);
            CountryView.Sort = "CountryID";
            AuthorView = new DataView(dtAuthor);
            AuthorView.Sort = "AuthorID";
            BookInfoView = new DataView(dtBookInfo);
            BookInfoView.Sort = "BookInfoID";
            VendorView = new DataView(dtVendor);
            VendorView.Sort = "VendorID";
            ClientView = new DataView(dtClient);
            ClientView.Sort = "ClientID";
            ClientOrderView = new DataView(dtClientOrder);
            ClientOrderView.Sort = "ClientOrderID";
            BookView = new DataView(dtBook);
            BookView.Sort = "BookID";
            AuthorView = new DataView(dtAuthor);
            AuthorView.Sort = "AuthorID";

            
        }

        private void DataModule_Load(object sender, EventArgs e)
        {
            
        }
        public void UpdateVendor()
        {
            daVendor.Update(dtVendor);
        }

        public void UpdateBookInfo()
        {
            daBookInfo.Update(dtBookInfo);
        }

        public void UpdateClient()
        {
            daClient.Update(dtClient);
        }

        public void UpdateClientOrder()
        {
            daClientOrder.Update(dtClientOrder);

        }

        public void UpdateBook()
        {
            daBook.Update(dtBook);
        }

        private void daVendor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if(e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the VendorID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VendorID"] = newID;
            }
        }

        private void daAuthor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the AuthorID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["AuthorID"] = newID;
            }
        }

        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the BookID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookID"] = newID;
            }
        }

        private void daBookInfo_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the BookInfoID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookInfoID"] = newID;
            }
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the ClientID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        private void daClientOrder_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the ClientOrderID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientOrderID"] = newID;
            }
        }

        private void daCountry_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrieve
            //the identity value for the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBookBrokers);

            if (e.StatementType == StatementType.Insert)
            {
                //Retrieve the identity value and
                //store it in the CountryID Column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CountryID"] = newID;
            }
        }
    }
}
