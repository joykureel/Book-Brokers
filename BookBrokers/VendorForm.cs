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
    public partial class VendorForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmCountry;

        public VendorForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVendor.Left = 255;
            pnlAddVendor.Top = 10;
            pnlUpdateVendor.Left = 255;
            pnlUpdateVendor.Top = 15;
        }
        //this method binds the data from database to the input field
        public void BindControls()
        {
            txtVendorID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorID");
            txtVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtPostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtVendorID.Enabled = false;
            txtVendorName.Enabled = false;
            txtPostBoxNumber.Enabled = false;
            txtCountryName.Enabled = false;
            lblCountryID.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
            txtEmail.Enabled = false;
            lstVendor.DataSource = DM.dsBookBrokers;
            lstVendor.DisplayMember = "Vendor.VendorName";
            lstVendor.ValueMember = "Vendor.VendorName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "VENDOR"];
            cmCountry = (CurrencyManager)this.BindingContext[DM.dsBookBrokers, "COUNTRY"];
            txtUpdateVendorID.DataBindings.Add("text", DM.dsBookBrokers, "Vendor.VendorID");
            txtUpdateVendorName.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.VendorName");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.Email");
            txtUpdatePostBoxNumber.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.PostBoxNumber");
            txtUpdateCountry.DataBindings.Add("Text", DM.dsBookBrokers, "Vendor.CountryID");
        }
    

        private void VendorForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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
            if(currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            lstVendor.Enabled = false;
            lstVendor.SelectedItem = null;
            btnDeleteVendor.Enabled = false;
            btnUpdateVendor.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            txtCountryName.Enabled = false;
            pnlAddVendor.Show();
            LoadVendors();

        }
        //deletes the vendor which has no books 
        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            DataRow deleteVendorRow = DM.dtVendor.Rows[currencyManager.Position];
            DataRow[] BookRow = DM.dtBook.Select("VendorID = " + txtVendorID.Text);
            if(BookRow.Length != 0)
            {
                MessageBox.Show("You may only delete vendor that have no books", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record? ", "warning", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVendorRow.Delete();
                    DM.UpdateVendor();
                    MessageBox.Show("Vendor deleted successfully");

                }
            }
        }

        private void btnUpdateVendor_Click(object sender, EventArgs e)
        {
            lstVendor.Visible = false;
            lstVendor.Enabled = false;
            lstVendor.SelectedItem = null;
            btnDeleteVendor.Enabled = false;
            btnAddVendor.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            txtCountryName.Enabled = false;
            pnlUpdateVendor.Show();
            txtUpdateCountry.Enabled = false;
            txtUpdateVendorID.Enabled = false;

        }

        //Add new vendor data and saves it
        private void btnAddSaveVendor_Click(object sender, EventArgs e)
        {
            DataRow newVendorRow = DM.dtVendor.NewRow();

            if ((txtAddVendorName.Text == "") || (txtAddPostBoxNumber.Text == "") ||
                (cboAddCountryID.Text == "") || (txtAddEmail.Text == ""))
            {
                MessageBox.Show("You must type in a valid data","Error");
            }
            else
            {
                newVendorRow["VendorName"] = txtAddVendorName.Text;
                newVendorRow["PostBoxNumber"] = txtAddPostBoxNumber.Text;
                newVendorRow["CountryID"] = cboAddCountryID.Text;
                newVendorRow["Email"] = txtAddEmail.Text;
                DM.dtVendor.Rows.Add(newVendorRow);
                MessageBox.Show("Vendor added successfully", "Success");
                DM.UpdateVendor();
                
            }
        }
        //binds the data from database to combo box fields
        private void LoadVendors()
        {
            cboAddCountryID.DataSource = DM.dsBookBrokers;
            cboAddCountryID.DisplayMember = "Country.Country.ID";
            cboAddCountryID.ValueMember = "Country.CountryID";
            cboAddCountryName.DataSource = DM.dsBookBrokers;
            cboAddCountryName.DisplayMember = "Country.CountryName";
            cboAddCountryName.ValueMember = "Country.CountryName";
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            pnlAddVendor.Hide();
            lstVendor.Visible = true;
            lstVendor.Enabled = true;
            
            btnDeleteVendor.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateVendor.Hide();
            lstVendor.Visible = true;
            lstVendor.Enabled = true;
            btnAddVendor.Enabled = true;
            btnDeleteVendor.Enabled = true;
            btnUpdateVendor.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnReturn.Enabled = true;
        }
        //update the data fields
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            
            DataRow updateVendorRow = DM.dtVendor.Rows[currencyManager.Position];

            if ((txtUpdateVendorName.Text == "") || (txtUpdatePostBoxNumber.Text == "") || (txtUpdateEmail.Text == ""))
            {
                MessageBox.Show("You must enter valid data for each field");

            }
            else
            {
                updateVendorRow["VendorName"] = txtUpdateVendorName.Text;
                updateVendorRow["PostBoxNumber"] = txtUpdatePostBoxNumber.Text;
                updateVendorRow["CountryID"] = txtUpdateCountry.Text;
                updateVendorRow["Email"] = txtUpdateEmail.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateVendor();
                MessageBox.Show("Vendor Updated Successfully");
            }
        
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtCountryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboAddCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Extracting Country Name from Country Table by label CountryID
        private void lblCountryID_TextChanged(object sender, EventArgs e)
        {
             
            if (lblCountryID.Text == "")
            {
                txtCountryName.Text = "";
            }
            else
            {
                int aCountryID = Convert.ToInt32(lblCountryID.Text);
                cmCountry.Position = DM.CountryView.Find(aCountryID);
                DataRow drCountry = DM.dtCountry.Rows[cmCountry.Position];
                txtCountryName.Text = drCountry["CountryName"].ToString();
            }

        }
    }
}
