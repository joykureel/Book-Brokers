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
    public partial class BookInfoForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmBookInfo;
        private CurrencyManager currencyManager;

        public object deleteBookInfoRow { get; private set; }

        public BookInfoForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBookInfo.Left = 275;
            pnlAddBookInfo.Top = 10;
            pnlUpdateBookInfo.Left = 275;
            pnlUpdateBookInfo.Top = 10;
        }
        //binding data from database to text boxes 
        private void BindControls()
        {
            txtBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
            txtNotes.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Notes");
            txtBookInfoID.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthorID.Enabled = false;
            txtNotes.Enabled = false;
            txtAuthorLastName.Enabled = false;
            txtAuthorFirstName.Enabled = false;
            lstBookTitles.DataSource= DM.dsBookBrokers;
            lstBookTitles.DisplayMember = "BookInfo.Title";
            lstBookTitles.ValueMember = "BookInfo.Title";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "BOOKINFO"];
            cmBookInfo = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "AUTHOR"];
            txtUpdateBookInfoID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.BookInfoID");
            txtUpdateTitle.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.Title");
            txtUpdateAuthorID.DataBindings.Add("Text", DM.dsBookBrokers, "BookInfo.AuthorID");
       
        }

        //binding data from database to combo boxes
        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            cboAddAuthorID.DataSource = DM.dsBookBrokers;
            cboAddAuthorID.DisplayMember = "Author.AuthorID";
            cboAddAuthorID.ValueMember = "Author.AuthorID";

            cboAddAuthorFirstName.DataSource = DM.dsBookBrokers;
            cboAddAuthorFirstName.DisplayMember = "Author.FirstName";
            cboAddAuthorFirstName.ValueMember = "Author.FirstName";

            cboAddAuthorLastName.DataSource = DM.dsBookBrokers;
            cboAddAuthorLastName.DisplayMember = "Author.LastName";
            cboAddAuthorLastName.ValueMember = "Author.LastName";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            lstBookTitles.Visible = false;
            lstBookTitles.Enabled = false;
            lstBookTitles.SelectedItem = null;
            btnDeleteBookInfo.Enabled = false;
            btnUpdateBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddBookInfo.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            lstBookTitles.Visible = false;
            lstBookTitles.Enabled = false;
            lstBookTitles.SelectedItem = null;
            btnDeleteBookInfo.Enabled = false;
            btnAddBookInfo.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateBookInfo.Show();
        }
        //add new title
        private void btnAddSaveBookInfo_Click(object sender, EventArgs e)
        {
            DataRow newBookInfoRow = DM.dtBookInfo.NewRow();
            DataRow newBookInfoRow1 = DM.dtAuthor.NewRow();

            if ((txtAddTitle.Text == ""))
            {
                MessageBox.Show("You must type in a valid Data");
            }
            else
            {
                newBookInfoRow["Title"] = txtAddTitle.Text;
                newBookInfoRow["Notes"] = txtAddNotes.Text;
                newBookInfoRow["AuthorID"] = cboAddAuthorID.Text;
                newBookInfoRow1["FirstName"] = cboAddAuthorFirstName.Text;
                newBookInfoRow1["LastName"] = cboAddAuthorLastName.Text;
                DM.dtAuthor.Rows.Add(newBookInfoRow1);
                DM.dtBookInfo.Rows.Add(newBookInfoRow);
                MessageBox.Show("Vendor added successfully", "Success");
                DM.UpdateBookInfo();

            }
        }

        private void lstBookTitles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //binding data from database by AuthorID to textboxes
        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {
            
                int aAuthorID = Convert.ToInt32(txtAuthorID.Text);
                cmBookInfo.Position = DM.AuthorView.Find(aAuthorID);
                DataRow draAuthor = DM.dtAuthor.Rows[cmBookInfo.Position];
                txtAuthorFirstName.Text = draAuthor["FirstName"].ToString();

                int bAuthorID = Convert.ToInt32(txtAuthorID.Text);
                cmBookInfo.Position = DM.AuthorView.Find(aAuthorID);
                DataRow drbAuthor = DM.dtAuthor.Rows[cmBookInfo.Position];
                txtAuthorLastName.Text = drbAuthor["LastName"].ToString();


            
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstBookTitles.Visible = true;
            lstBookTitles.Enabled = true;
            lstBookTitles.SelectedItem = true;
            btnDeleteBookInfo.Enabled = true;
            btnUpdateBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddBookInfo.Hide();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            lstBookTitles.Visible = true;
            lstBookTitles.Enabled = true;
            lstBookTitles.SelectedItem = true;
            btnDeleteBookInfo.Enabled = true;
            btnAddBookInfo.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpdateBookInfo.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlAddBookInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboAddAuthorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //delete record, if bookinfo records that have no books then error
        private void btnDeleteBookInfo_Click(object sender, EventArgs e)
        {
            DataRow deleteBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("BookInfoID = " + txtBookInfoID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete Book Info records that have no Book", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this ? ", "warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBookInfoRow.Delete();
                    DM.UpdateBookInfo();
                    MessageBox.Show("ClientOrder deleted successfully");

                }
            }
        }
        //databinding from database by authorID to textboxFields
        private void txtUpdateAuthorID_TextChanged(object sender, EventArgs e)
        {
            
            int aAuthorID = Convert.ToInt32(txtUpdateAuthorID.Text);
            cmBookInfo.Position = DM.AuthorView.Find(aAuthorID);
            DataRow draAuthor = DM.dtAuthor.Rows[cmBookInfo.Position];
            txtUpdateAuthorFirstName.Text = draAuthor["FirstName"].ToString();

            int bAuthorID = Convert.ToInt32(txtUpdateAuthorID.Text);
            cmBookInfo.Position = DM.AuthorView.Find(aAuthorID);
            DataRow drbAuthor = DM.dtAuthor.Rows[cmBookInfo.Position];
            txtUpdateAuthorLastName.Text = drbAuthor["LastName"].ToString();
        }

        private void btnUpdateSaveBook_Click(object sender, EventArgs e)
        {
            DataRow updateBookInfoRow = DM.dtBookInfo.Rows[currencyManager.Position];

            if ((txtUpdateNotes.Text == "") || (txtUpdateTitle.Text == ""))
            {
                MessageBox.Show("You must enter valid data for each field");

            }
            else
            {
                updateBookInfoRow["Title"] = txtUpdateTitle.Text;
                updateBookInfoRow["Notes"] = txtUpdateNotes.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateBookInfo();
                MessageBox.Show("Book Updated Successfully");
            }

        }
    }
}
