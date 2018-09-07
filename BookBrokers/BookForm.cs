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
    public partial class BookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmBookInfo;
        private CurrencyManager cmVendor;
        public BookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBook.Left = 240;
            pnlAddBook.Top = 10;
            pnlUpdateBook.Left = 240;
            pnlUpdateBook.Top = 10;
        }
        //Binding Data from database to combo box fields

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboAddBookInfoID.DataSource = DM.dsBookBrokers;
            cboAddBookInfoID.DisplayMember = "BookInfo.BookInfoID";
            cboAddBookInfoID.ValueMember = "BookInfo.BookInfoID";
            cboAddBookInfoTitle.DataSource = DM.dsBookBrokers;
            cboAddBookInfoTitle.DisplayMember = "BookInfo.Title";
            cboAddBookInfoTitle.ValueMember = "BookInfo.Title";

            cboAddVendorID.DataSource = DM.dsBookBrokers;
            cboAddVendorID.DisplayMember = "Vendor.VendorID";
            cboAddVendorID.ValueMember = "Vendor.VendorID";
            cboAddVendorName.DataSource = DM.dsBookBrokers;
            cboAddVendorName.DisplayMember = "Vendor.VendorName";
            cboAddVendorName.ValueMember = "Vendor.VendorName";


        }
        //binding data from database to textbox fields
        private void BindControls()
        {
            txtBookID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookID");
            txtCost.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Cost");
            txtPrice.DataBindings.Add("Text", DM.dsBookBrokers, "Book.Price");
            txtDatePublished.DataBindings.Add("Text", DM.dsBookBrokers, "Book.DatePublished");
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.VendorID");
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.BookInfoID");
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "Book.ClientOrderID");
            txtBookID.Enabled = false;
            txtTitle.Enabled = false;
            txtCost.Enabled = false;
            txtPrice.Enabled = false;
            txtDatePublished.Enabled = false;
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtClientOrderID.Enabled = false;
            lstBookID.DataSource = DM.dsBookBrokers;
            lstBookID.DisplayMember = "Book.BookID";
            lstBookID.ValueMember = "Book.BookID";
            txtUpdateCost.DataBindings.Add("text", DM.dsBookBrokers, "Book.Cost");
            txtUpdatePrice.DataBindings.Add("text", DM.dsBookBrokers, "Book.Price");
            cboUpdateDatePublished.DataBindings.Add("text", DM.dsBookBrokers, "Book.DatePublished");
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOK"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmVendor = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position > 0)
            {
                ++currencyManager.Position;
            }
        }
        //binding data from bookinfo in column title to title textbox field

        private void txtBookInfoID_TextChanged(object sender, EventArgs e)
        {
            int aBookInfoID = Convert.ToInt32(txtBookInfoID.Text);
            cmBookInfo.Position = DM.BookInfoView.Find(aBookInfoID);
            DataRow drBookInfo = DM.dtBookInfo.Rows[cmBookInfo.Position];
            txtTitle.Text = drBookInfo["Title"].ToString();
        }
        //binding data from Vendor in column VendorName to Vendor Name textbox field
        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            int aVendorID = Convert.ToInt32(txtVendorID.Text);
            cmVendor.Position = DM.VendorView.Find(aVendorID);
            DataRow drVendor = DM.dtVendor.Rows[cmVendor.Position];
            txtVendorName.Text = drVendor["VendorName"].ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lstBookID.Visible = false;
            lstBookID.Enabled = false;
            lstBookID.SelectedItem = null;
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddBook.Show();
        }
        //if client order ID is not null , cannot update book
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (txtClientOrderID.Text != "")
            {
                MessageBox.Show("Cannot update a book that is on order", "Error");
            }
            else
            {
                lstBookID.Visible = false;
                lstBookID.Enabled = false;
                lstBookID.SelectedItem = null;
                btnDeleteBook.Enabled = false;
                btnAddBook.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnReturn.Enabled = false;
                pnlUpdateBook.Show();
                txtBookID.Enabled = false;
                txtTitle.Enabled = false;
                txtVendorID.Enabled = false;
                txtVendorName.Enabled = false;
            }
            
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstBookID.Visible = true;
            lstBookID.Enabled = true;
            lstBookID.SelectedItem = true;
            btnDeleteBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddBook.Hide();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            lstBookID.Visible = true;
            lstBookID.Enabled = true;
            lstBookID.SelectedItem = true;
            btnDeleteBook.Enabled = true;
            btnAddBook.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpdateBook.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //adding in three datatables
        private void btnAddSaveInfo_Click(object sender, EventArgs e)
        {
            DataRow newBookRow = DM.dtBook.NewRow();
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();
            DataRow newVendorRow = DM.dtVendor.NewRow();
            if ((txtCost.Text == "") || (txtPrice.Text == "") || (cboAddBookInfoTitle.Text == "") ||
                (cboAddBookInfoID.Text == "") || (cboAddVendorID.Text == "") || (cboAddVendorName.Text == "") || (cboAddDatePublished.Text ==""))
            {
                MessageBox.Show("You must type in a valid data in all field");
            }
            else
            {
                newBookRow["BookInfoID"] = cboAddBookInfoID.Text;
                newBookInfoRow["Title"] = cboAddBookInfoTitle.Text;
                newBookRow["Cost"] = txtCost.Text;
                newBookRow["Price"] = txtPrice.Text;
                newBookRow["DatePublished"] = txtDatePublished.Text;
                newBookRow["VendorID"] = cboAddVendorID.Text;
                newVendorRow["VendorName"] = cboAddVendorName.Text;
                DM.dtVendor.Rows.Add(newVendorRow);
                DM.dtBook.Rows.Add(newBookRow);
                DM.dtBookInfo.Rows.Add(newBookInfoRow);

                MessageBox.Show("Vendor added successfully", "Success");
                DM.UpdateBook();

            }
        }
        //save updates
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBookRow = DM.dtBook.Rows[currencyManager.Position];
            if ((txtCost.Text == "") || (txtPrice.Text == "") || (cboUpdateDatePublished.Text =="") || (txtClientOrderID.Text ==""))

            {
                MessageBox.Show("enter valid data in valid fields ", "Error");
            }
            else
            {
                updateBookRow["Cost"] = txtCost.Text;
                updateBookRow["Price"] = txtPrice.Text;
                updateBookRow["DatePublished"] = cboUpdateDatePublished.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateBook();
                MessageBox.Show("Book updated successfully", "Success");
            }
        }
        //delete condition, cannot delete if clientorderID is not null
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataRow deleteBookRow = DM.dtBook.Rows[currencyManager.Position];
            if (txtClientOrderID != null && !string.IsNullOrWhiteSpace(txtClientOrderID.Text))
            {
                MessageBox.Show("You may only delete books that are not on order", "Error");
            }
            
             if (txtClientOrderID.Text == "")
                {
                    if (MessageBox.Show("Are you sure want to delete this record? ", "warning",
                 MessageBoxButtons.OKCancel) == DialogResult.OK)


                    {
                        deleteBookRow.Delete();
                        DM.UpdateClient();
                        MessageBox.Show("Book deleted successfully");
                    }
                }
            
            
        }

        private void pnlAddBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpdateBook_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
