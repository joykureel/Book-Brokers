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
    public partial class AddBookForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmClientOrder ,currencyManager;
        private CurrencyManager cmBook ,cmClient, currencyManager2;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDT;
        private CurrencyManager cmCCB;
        public AddBookForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            //getting positions from the tables through currency Manager
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "ClientOrder"];
            cmBook = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            cmDT = (CurrencyManager)this.BindingContext[dt];
            cmCCB = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER.CLIENTORDER_BOOK"];
            cmClient = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];
            currencyManager2 = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Book"];

            BindControls();


        }
        //binding data from tables 
        public void BindControls()
        {
            dgvClientOrder.DataSource = DM.dsBookBrokers;
            dgvClientOrder.DataMember = "ClientOrder";

            dgvBookDetails.DataSource = DM.dsBookBrokers;
            dgvBookDetails.DataMember = "CLIENTORDER.CLIENTORDER_BOOK";

            DataView dataViewBookNullClient = DM.dsBookBrokers.Tables["Book"].DefaultView;
            dataViewBookNullClient.RowFilter = "ClientOrderID is null";
            dgvBookDetails2.DataSource = dataViewBookNullClient;
            dgvBookDetails2.Columns["ClientOrderID"].Visible = false;


            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvClientOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Adding book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
                {
                    DataRow UpdateBookrow = DM.dtBook.Rows[currencyManager.Position];
                    UpdateBookrow["ClientOrderID"] = dgvClientOrder["ClientOrderID", cmClientOrder.Position].Value;

                    currencyManager.EndCurrentEdit();
                    DM.UpdateBook();
                    MessageBox.Show("Book Added Successfully");
                }
                else
                {
                    MessageBox.Show("Book can only be added to current order");
                }

            }
            catch (ConstraintException)
            {
                MessageBox.Show("Test");
            }


        }
        //removing book status
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {

            if (DM.dtClientOrder.Rows[cmClientOrder.Position]["Status"].ToString() == "Current")
            {
                DataRow UpdateBookrow1 = DM.dtBook.Rows[currencyManager2.Position];
                UpdateBookrow1["ClientOrderID"] = DBNull.Value;

                currencyManager2.EndCurrentEdit();
                DM.UpdateBook();
                MessageBox.Show("Book deleted Successfully");
            }
            else
            {
                MessageBox.Show("Book can only be deleted wose current order");
            }
        }
        //geting Client data from ClientOrder table's ClientID
        private void dgvClientOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvClientOrder.Rows[e.RowIndex];
            int aClientID = Convert.ToInt32(row.Cells[2].Value);
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];
            txtClientLastName.Text = drClient["LastName"].ToString();
            txtClientFirstName.Text = drClient["FirstName"].ToString();
        }
        //getting title from BookInfo 

        private void dgvBookDetails2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvBookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow rows = this.dgvBookDetails.Rows[e.RowIndex];



                int aClientID = Convert.ToInt32(rows.Cells[4].Value);
                cmBook.Position = DM.BookInfoView.Find(aClientID);
                DataRow drClient = DM.dtBookInfo.Rows[cmBook.Position];
                txtTitle.Text = drClient["Title"].ToString();

                int aBookID1 = Convert.ToInt32(rows.Cells[0].Value);
                currencyManager2.Position = DM.BookView.Find(aBookID1);
            }
        }
        private void dgvBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
