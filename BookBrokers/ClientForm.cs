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
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;
        public ClientForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddClient.Left = 270;
            pnlAddClient.Top = 20;
            pnlUpdateClient.Left = 270;
            pnlUpdateClient.Top = 20;
        }
        //this method binds the data from database to the input field
        public void BindControls()
        {
            txtClientID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsBookBrokers, "Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsBookBrokers, "Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsBookBrokers, "Client.City");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            cboCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");
            txtCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CountryID");
            txtClientID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtCity.Enabled = false;
            txtCountryName.Enabled = false;
            txtEmail.Enabled = false;
            cboCreditStatus.Enabled = false;
            lstClient.DataSource = DM.dsBookBrokers;
            lstClient.DisplayMember = "Client.LastName";
            lstClient.ValueMember = "Client.LastName";
            //Update Panel Boxes databinding
            txtUpdateLastName.DataBindings.Add("text", DM.dsBookBrokers, "Client.LastName");
            txtUpdateFirstName.DataBindings.Add("text", DM.dsBookBrokers, "Client.FirstName");
            txtUpdateStreetAddress.DataBindings.Add("text", DM.dsBookBrokers, "Client.StreetAddress");
            txtUpdateSuburb.DataBindings.Add("text", DM.dsBookBrokers, "Client.Suburb");
            txtUpdateCity.DataBindings.Add("text", DM.dsBookBrokers, "Client.City");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Client.Email");
            cboUpdateCreditStatus.DataBindings.Add("Text", DM.dsBookBrokers, "Client.CreditStatus");
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "Client"];
            cmCountry = (CurrencyManager)BindingContext[DM.dsBookBrokers, "COUNTRY"];

        }


        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void lblClientID_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            lstClient.Enabled = false;
            lstClient.SelectedItem = null;
            btnDeleteClient.Enabled = false;
            btnUpdateClient.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlAddClient.Show();
            LoadVendors();
        }
        //binds the data from database to the combo box fields
        private void LoadVendors()
        {
            cboAddCountryID.DataSource = DM.dsBookBrokers;
            cboAddCountryID.DisplayMember = "Country.Country.ID";
            cboAddCountryID.ValueMember = "Country.CountryID";
            cboAddCountryName.DataSource = DM.dsBookBrokers;
            cboAddCountryName.DisplayMember = "Country.CountryName";
            cboAddCountryName.ValueMember = "Country.CountryName";
            cboUpdateCountryID.DataSource = DM.dsBookBrokers;
            cboUpdateCountryID.DisplayMember = "Country.Country.ID";
            cboUpdateCountryID.ValueMember = "Country.CountryID";
            cboUpdateCountryName.DataSource = DM.dsBookBrokers;
            cboUpdateCountryName.DisplayMember = "Country.CountryName";
            cboUpdateCountryName.ValueMember = "Country.CountryName";
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lstClient.Visible = false;
            lstClient.Enabled = false;
            lstClient.SelectedItem = null;
            btnDeleteClient.Enabled = false;
            btnAddClient.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateClient.Show();
            LoadVendors();
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

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            lstClient.Visible = true;
            lstClient.Enabled = true;
            lstClient.SelectedItem = true;
            btnDeleteClient.Enabled = true;
            btnUpdateClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlAddClient.Hide();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            lstClient.Visible = true;
            lstClient.Enabled = true;
            lstClient.SelectedItem = true;
            btnDeleteClient.Enabled = true;
            btnAddClient.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
            pnlUpdateClient.Hide();
        }
        //Add new Client data and saves it
        private void btnAddSaveClient_Click(object sender, EventArgs e)
        {
            txtClientID.Text = null;
            DataRow newClientRow = DM.dtClient.NewRow();

            if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == "") ||
                (txtAddSuburb.Text == "") || (txtStreetAddress.Text == "") ||
                (txtAddCity.Text == ""))
            {
                MessageBox.Show("You must type in a First Name, Last Name, Suburb and Street Address");
            }
            else
            {
                newClientRow["LastName"] = txtAddLastName.Text;
                newClientRow["FirstName"] = txtAddFirstName.Text;
                newClientRow["StreetAddress"] = txtAddStreetAddress.Text;
                newClientRow["Suburb"] = txtAddSuburb.Text;
                newClientRow["City"] = txtAddCity.Text;
                newClientRow["CountryID"] = cboAddCountryID.Text;
                newClientRow["Email"] = txtEmail.Text;
                newClientRow["CreditStatus"] = cboCreditStatus.Text;
                DM.dtClient.Rows.Add(newClientRow);
                MessageBox.Show("Client added successfully", "Success");
                DM.UpdateClient();

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //delete client, clients cannot be deleted who have no client orders
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] ClientOrderRow = DM.dtClientOrder.Select("ClientID = " + txtClientID.Text);
            if (ClientOrderRow.Length != 0)
            {
                MessageBox.Show("You may only delete clients who have no client orders", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record? ", "warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.UpdateClient();
                    MessageBox.Show("Client deleted successfully");

                }
            }
        }
        //updating changes
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateClientRow = DM.dtClient.Rows[currencyManager.Position];
            if ((txtUpdateLastName.Text == "") || (txtUpdateFirstName.Text == "") ||
                (txtUpdateSuburb.Text == "") || (txtUpdateCity.Text == "") ||
                (txtUpdateEmail.Text == ""))
            {
                MessageBox.Show("You must type in a valid data", "Error");
            }
            else
            {
                updateClientRow["LastName"] = txtUpdateLastName.Text;
                updateClientRow["FirstName"] = txtUpdateFirstName.Text;
                updateClientRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateClientRow["Suburb"] = txtUpdateSuburb.Text;
                updateClientRow["City"] = txtUpdateCity.Text;
                updateClientRow["CountryID"] = cboUpdateCountryID.Text;
                updateClientRow["Email"] = txtUpdateEmail.Text;
                updateClientRow["CreditStatus"] = cboUpdateCreditStatus.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateClient();
                MessageBox.Show("Client updated successfully", "Success");
            }
        }

        private void cboAddCreditStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //databinding of database from CountryName to txtbox
        private void txtCountryID_TextChanged(object sender, EventArgs e)
        {
            if (txtCountryID.Text == "")
            {
                txtCountryName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(txtCountryID.Text);
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountryName.Text = drCountry["CountryName"].ToString();
            }

        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
