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
    public partial class ClientOrderForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmClientOrder, cmClient;
       
        public ClientOrderForm(DataModule dm, MainForm mnu)
        {

            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClientOrder.Left = 275;
            pnlAddClientOrder.Top = 20;
            pnlUpdateClientOrder.Left = 275;
            pnlUpdateClientOrder.Top = 10;



        }
  
        //binding data from datatable to textbox
        public void BindControls()
        {
            txtClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            txtStatus.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.Status");
            lstClientOrderID.DataSource = DM.dsBookBrokers;
            lstClientOrderID.DisplayMember = "ClientOrder.ClientOrderID";
            lstClientOrderID.ValueMember = "ClientOrder.ClientOrderID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
           txtClientOrderID.Enabled = false;
            txtClientOrderDate.Enabled = false;
            txtClientID.Enabled = false;
            txtStatus.Enabled = false;
            txtClientLastName.Enabled = false;
            txtClientFirstName.Enabled = false;
            txtUpdateClientOrderID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientOrderID");
            cboAddClientOrderDate.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.OrderDate");
            txtUpdateClientID.DataBindings.Add("Text", DM.dsBookBrokers, "ClientOrder.ClientID");
            cmClient= (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENT"];
            cmClientOrder = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "CLIENTORDER"];
        }
        
        //binding data from datatable to combobox
        private void ClientOrderForm_Load(object sender, EventArgs e)
        {
            cboAddClientID.DataSource = DM.dsBookBrokers;
            cboAddClientID.DisplayMember = "Client.ClientID";
            cboAddClientID.ValueMember = "Client.ClientID";

            cboAddClientLastName.DataSource = DM.dsBookBrokers;
            cboAddClientLastName.DisplayMember = "Client.LastName";
            cboAddClientLastName.ValueMember = "Client.LastName";

            cboAddClientFirstName.DataSource = DM.dsBookBrokers;
            cboAddClientFirstName.DisplayMember = "Client.FirstName";
            cboAddClientFirstName.ValueMember = "Client.FirstName";




        }
        //databinding from database by Client to textboxes
        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
           
            int aClientID = Convert.ToInt32(txtClientID.Text);
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow draClient = DM.dtClient.Rows[cmClient.Position];
            txtClientFirstName.Text = draClient["FirstName"].ToString();

            int bClientID = Convert.ToInt32(txtClientID.Text);
            cmClient.Position = DM.ClientView.Find(aClientID);
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];
            txtClientLastName.Text = drClient["LastName"].ToString();

        }

        private void txtClientOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClientLastName_TextChanged(object sender, EventArgs e)
        {

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
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrderID.Visible = false;
            lstClientOrderID.Enabled = false;
            lstClientOrderID.SelectedItem = null;
            btnDeleteClientOrder.Enabled = false;
            btnUpdateClientOrder.Enabled = false;
            btnMarkPaid.Enabled = false;
            btnMarkShipped.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddClientOrder.Show();
        }

        private void pnlAddClientOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstClientOrderID.Visible = true;
            lstClientOrderID.Enabled = true;
            lstClientOrderID.SelectedItem = true;
            btnDeleteClientOrder.Enabled = true;
            btnUpdateClientOrder.Enabled = true;
            btnMarkPaid.Enabled = true;
            btnMarkShipped.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddClientOrder.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboAddClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //getting data from Client 
        private void btnAddSaveClientOrder_Click(object sender, EventArgs e)
        {
            DataRow newClientOrderRow = DM.dtClientOrder.NewRow();
        
            if ((cboAddClientOrderDate.Text == "") || (cboAddClientID.Text == "") || (cboAddClientLastName.Text == "") || (cboAddClientFirstName.Text == ""))
            {
                MessageBox.Show("You must type in a valid data in all field");
            }
            else
            {
                newClientOrderRow["OrderDate"] = cboAddClientOrderDate.Text;
                newClientOrderRow["ClientID"] = cboAddClientID.Text;
                newClientOrderRow["Status"] = "Current";
           
                DM.dtClientOrder.Rows.Add(newClientOrderRow);
           
                MessageBox.Show("Client Order added successfully", "Success");
                DM.UpdateClientOrder();
            }
        }
        //Extracting Data from Client table by textbox ClientID
        private void txtUpdateClientID_TextChanged(object sender, EventArgs e)
        {
           int aLastNameID = Convert.ToInt32(txtUpdateClientID.Text);
            cmClientOrder.Position = DM.ClientView.Find(aLastNameID);
            DataRow drLastName = DM.dtClient.Rows[cmClientOrder.Position];
            txtUpdateClientLastName.Text = drLastName["LastName"].ToString();

            int aFirstNameID = Convert.ToInt32(txtUpdateClientID.Text);
            cmClientOrder.Position = DM.ClientView.Find(aFirstNameID);
            DataRow drFirstName = DM.dtClient.Rows[cmClientOrder.Position];
            txtUpdateClientFirstName.Text = drFirstName["FirstName"].ToString();
        }

        private void btnUpdateClientOrder_Click(object sender, EventArgs e)
        {
            lstClientOrderID.Visible = false;
            lstClientOrderID.Enabled = false;
            lstClientOrderID.SelectedItem = null;
            btnDeleteClientOrder.Enabled = false;
            btnAddClientOrder.Enabled = false;
            btnMarkPaid.Enabled = false;
            btnMarkShipped.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateClientOrder.Show();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            lstClientOrderID.Visible = true;
            lstClientOrderID.Enabled = true;
            lstClientOrderID.SelectedItem = true;
            btnDeleteClientOrder.Enabled = true;
            btnAddClientOrder.Enabled = true;
            btnMarkPaid.Enabled = true;
            btnMarkShipped.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpdateClientOrder.Hide();
        }
        //Update date changes
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if ((cboUpdateClientOrderDate.Text == ""))

            {
                MessageBox.Show("Cannot Update ", "Error");
            }
            else
            {
                updateClientOrderRow["Orderdate"] = cboUpdateClientOrderDate.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client order updated successfully", "Success");
            }
        }
        //delete client order row if client has no books
        private void btnDeleteClientOrder_Click(object sender, EventArgs e)
        {
            DataRow deleteClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("ClientOrderID = " + txtClientOrderID.Text);
            if (BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete Client has no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record? ", "warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientOrderRow.Delete();
                    DM.UpdateClientOrder();
                    MessageBox.Show("Client order deleted successfully");

                }
            }
        }
        //MarkShipped order if current then change

        private void btnMarkShipped_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if ((txtStatus.Text == "Shipped") || (txtStatus.Text == "Paid"))

            {
                MessageBox.Show("Only current client orders can be marked as shipped ", "Error");
            }
            else
            {
                if (txtStatus.Text == "Current")
                    updateClientOrderRow["Status"] = "Shipped";

                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client marked as shipped", "Success");
            }
        }
        //Mark as Paid if current status to shipped
        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            DataRow updateClientOrderRow = DM.dtClientOrder.Rows[currencyManager.Position];
            if ((txtStatus.Text == "Current") || (txtStatus.Text == "Paid"))

            {
                MessageBox.Show("Only current client orders can be marked as paid ", "Error");
            }
            else
            {
                if (txtStatus.Text == "Shipped")
                    updateClientOrderRow["Status"] = "paid";

                currencyManager.EndCurrentEdit();
                DM.UpdateClientOrder();
                MessageBox.Show("Client marked as paid", "Success");
            }

        }

        private void cboAddClientOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
