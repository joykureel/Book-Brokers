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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private ClientForm frmClient;
        private BookInfoForm frmBookInfo;
        private BookForm frmBook;
        private ClientOrderForm frmClientOrder;
        private AddBookForm frmAddBook;
        private InvoicesForm frmInvoices;
        private VendorsForm frmVendors;
        private VendorForm frmVendor;
     

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
            

        }

    

        private void btnVendor_Click(object sender, EventArgs e)
        {
            if (frmVendor == null)
            {
                frmVendor = new VendorForm(DM, this);
                
            }
            frmVendor.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM,this);
            }
            frmClient.ShowDialog();
        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            if(frmBookInfo == null)
            {
                frmBookInfo = new BookInfoForm(DM, this);
            }
            frmBookInfo.ShowDialog();
        }

        private void btnClientOrder_Click(object sender, EventArgs e)
        {
            if(frmClientOrder == null)
            {
                frmClientOrder = new ClientOrderForm(DM,this);
            }
            frmClientOrder.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (frmAddBook == null)
            {
                frmAddBook = new AddBookForm(DM,this);
            }
            frmAddBook.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (frmBook == null)
            {
                frmBook = new BookForm(DM, this);
            }
            frmBook.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoices == null)
            {
                frmInvoices = new InvoicesForm(DM, this);
            }
            frmInvoices.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            if(frmVendors == null)
            {
                frmVendors = new VendorsForm(DM, this);
            }
            frmVendors.ShowDialog();
        }
    }
}
