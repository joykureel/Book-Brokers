namespace BookBrokers
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstClient = new System.Windows.Forms.ListBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountryID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboCreditStatus = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.pnlAddClient = new System.Windows.Forms.Panel();
            this.btnAddSaveClient = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.cboAddCountryID = new System.Windows.Forms.ComboBox();
            this.cboAddCreditStatus = new System.Windows.Forms.ComboBox();
            this.cboAddCountryName = new System.Windows.Forms.ComboBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.lblAddCreditStatus = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.lblAddStreetAddress = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.pnlUpdateClient = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSaveChanges = new System.Windows.Forms.Button();
            this.cboUpdateCountryName = new System.Windows.Forms.ComboBox();
            this.cboUpdateCountryID = new System.Windows.Forms.ComboBox();
            this.cboUpdateCreditStatus = new System.Windows.Forms.ComboBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateStreetAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblUpdateCreditStatus = new System.Windows.Forms.Label();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdateStreetAddress = new System.Windows.Forms.Label();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.pnlAddClient.SuspendLayout();
            this.pnlUpdateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.Location = new System.Drawing.Point(25, 34);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(218, 277);
            this.lstClient.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(318, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(317, 37);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Client ID:";
            this.lblClientID.Click += new System.EventHandler(this.lblClientID_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(317, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(317, 123);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAddress.TabIndex = 4;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(317, 152);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblSuburb.TabIndex = 5;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(317, 184);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(317, 217);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(317, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.AutoSize = true;
            this.lblCreditStatus.Location = new System.Drawing.Point(317, 286);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(70, 13);
            this.lblCreditStatus.TabIndex = 9;
            this.lblCreditStatus.Text = "Credit Status:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(392, 34);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(43, 20);
            this.txtClientID.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(392, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(392, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(392, 116);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(140, 20);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(392, 145);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(392, 181);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtCountryID
            // 
            this.txtCountryID.Location = new System.Drawing.Point(470, 214);
            this.txtCountryID.Name = "txtCountryID";
            this.txtCountryID.Size = new System.Drawing.Size(22, 20);
            this.txtCountryID.TabIndex = 16;
            this.txtCountryID.TextChanged += new System.EventHandler(this.txtCountryID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // cboCreditStatus
            // 
            this.cboCreditStatus.Location = new System.Drawing.Point(392, 279);
            this.cboCreditStatus.Name = "cboCreditStatus";
            this.cboCreditStatus.Size = new System.Drawing.Size(100, 20);
            this.cboCreditStatus.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(613, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 23);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(55, 334);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(106, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(191, 334);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(329, 334);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(106, 23);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(473, 334);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateClient.TabIndex = 12;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(613, 334);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteClient.TabIndex = 13;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // pnlAddClient
            // 
            this.pnlAddClient.Controls.Add(this.btnAddSaveClient);
            this.pnlAddClient.Controls.Add(this.btnAddCancel);
            this.pnlAddClient.Controls.Add(this.cboAddCountryID);
            this.pnlAddClient.Controls.Add(this.cboAddCreditStatus);
            this.pnlAddClient.Controls.Add(this.cboAddCountryName);
            this.pnlAddClient.Controls.Add(this.txtAddEmail);
            this.pnlAddClient.Controls.Add(this.txtAddCity);
            this.pnlAddClient.Controls.Add(this.txtAddLastName);
            this.pnlAddClient.Controls.Add(this.txtAddFirstName);
            this.pnlAddClient.Controls.Add(this.txtAddSuburb);
            this.pnlAddClient.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddClient.Controls.Add(this.lblAddCreditStatus);
            this.pnlAddClient.Controls.Add(this.lblAddEmail);
            this.pnlAddClient.Controls.Add(this.lblAddCountry);
            this.pnlAddClient.Controls.Add(this.lblAddCity);
            this.pnlAddClient.Controls.Add(this.lblAddSuburb);
            this.pnlAddClient.Controls.Add(this.lblAddStreetAddress);
            this.pnlAddClient.Controls.Add(this.lblAddFirstName);
            this.pnlAddClient.Controls.Add(this.lblAddLastName);
            this.pnlAddClient.Location = new System.Drawing.Point(598, 37);
            this.pnlAddClient.Name = "pnlAddClient";
            this.pnlAddClient.Size = new System.Drawing.Size(271, 291);
            this.pnlAddClient.TabIndex = 25;
            this.pnlAddClient.Visible = false;
            this.pnlAddClient.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddClient_Paint);
            // 
            // btnAddSaveClient
            // 
            this.btnAddSaveClient.Location = new System.Drawing.Point(15, 256);
            this.btnAddSaveClient.Name = "btnAddSaveClient";
            this.btnAddSaveClient.Size = new System.Drawing.Size(86, 23);
            this.btnAddSaveClient.TabIndex = 10;
            this.btnAddSaveClient.Text = "Save Client";
            this.btnAddSaveClient.UseVisualStyleBackColor = true;
            this.btnAddSaveClient.Click += new System.EventHandler(this.btnAddSaveClient_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(175, 256);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(82, 23);
            this.btnAddCancel.TabIndex = 11;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // cboAddCountryID
            // 
            this.cboAddCountryID.FormattingEnabled = true;
            this.cboAddCountryID.Location = new System.Drawing.Point(142, 169);
            this.cboAddCountryID.Name = "cboAddCountryID";
            this.cboAddCountryID.Size = new System.Drawing.Size(43, 21);
            this.cboAddCountryID.TabIndex = 6;
            // 
            // cboAddCreditStatus
            // 
            this.cboAddCreditStatus.FormattingEnabled = true;
            this.cboAddCreditStatus.Items.AddRange(new object[] {
            "Valid",
            "Invalid"});
            this.cboAddCreditStatus.Location = new System.Drawing.Point(142, 229);
            this.cboAddCreditStatus.Name = "cboAddCreditStatus";
            this.cboAddCreditStatus.Size = new System.Drawing.Size(100, 21);
            this.cboAddCreditStatus.TabIndex = 9;
            this.cboAddCreditStatus.SelectedIndexChanged += new System.EventHandler(this.cboAddCreditStatus_SelectedIndexChanged);
            // 
            // cboAddCountryName
            // 
            this.cboAddCountryName.FormattingEnabled = true;
            this.cboAddCountryName.Location = new System.Drawing.Point(191, 169);
            this.cboAddCountryName.Name = "cboAddCountryName";
            this.cboAddCountryName.Size = new System.Drawing.Size(51, 21);
            this.cboAddCountryName.TabIndex = 7;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(142, 200);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddEmail.TabIndex = 8;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Location = new System.Drawing.Point(142, 134);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(100, 20);
            this.txtAddCity.TabIndex = 5;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(142, 16);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 1;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(142, 47);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFirstName.TabIndex = 2;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(142, 105);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtAddSuburb.TabIndex = 4;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(142, 79);
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddStreetAddress.TabIndex = 3;
            // 
            // lblAddCreditStatus
            // 
            this.lblAddCreditStatus.AutoSize = true;
            this.lblAddCreditStatus.Location = new System.Drawing.Point(40, 231);
            this.lblAddCreditStatus.Name = "lblAddCreditStatus";
            this.lblAddCreditStatus.Size = new System.Drawing.Size(70, 13);
            this.lblAddCreditStatus.TabIndex = 7;
            this.lblAddCreditStatus.Text = "Credit Status:";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(40, 203);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAddEmail.TabIndex = 6;
            this.lblAddEmail.Text = "Email:";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(42, 172);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(46, 13);
            this.lblAddCountry.TabIndex = 5;
            this.lblAddCountry.Text = "Country:";
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(40, 134);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(27, 13);
            this.lblAddCity.TabIndex = 4;
            this.lblAddCity.Text = "City:";
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(40, 108);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblAddSuburb.TabIndex = 3;
            this.lblAddSuburb.Text = "Suburb:";
            // 
            // lblAddStreetAddress
            // 
            this.lblAddStreetAddress.AutoSize = true;
            this.lblAddStreetAddress.Location = new System.Drawing.Point(42, 82);
            this.lblAddStreetAddress.Name = "lblAddStreetAddress";
            this.lblAddStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblAddStreetAddress.TabIndex = 2;
            this.lblAddStreetAddress.Text = "Street Address:";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(40, 54);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblAddFirstName.TabIndex = 1;
            this.lblAddFirstName.Text = "First Name";
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(40, 26);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(61, 13);
            this.lblAddLastName.TabIndex = 0;
            this.lblAddLastName.Text = "Last Name:";
            // 
            // pnlUpdateClient
            // 
            this.pnlUpdateClient.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateClient.Controls.Add(this.btnUpdateSaveChanges);
            this.pnlUpdateClient.Controls.Add(this.cboUpdateCountryName);
            this.pnlUpdateClient.Controls.Add(this.cboUpdateCountryID);
            this.pnlUpdateClient.Controls.Add(this.cboUpdateCreditStatus);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateCity);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateSuburb);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateStreetAddress);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateFirstName);
            this.pnlUpdateClient.Controls.Add(this.txtUpdateLastName);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateCreditStatus);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateCountry);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateCity);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateSuburb);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateStreetAddress);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateFirstName);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateLastName);
            this.pnlUpdateClient.Location = new System.Drawing.Point(921, 37);
            this.pnlUpdateClient.Name = "pnlUpdateClient";
            this.pnlUpdateClient.Size = new System.Drawing.Size(278, 291);
            this.pnlUpdateClient.TabIndex = 26;
            this.pnlUpdateClient.Visible = false;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(180, 256);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateCancel.TabIndex = 11;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSaveChanges
            // 
            this.btnUpdateSaveChanges.Location = new System.Drawing.Point(19, 256);
            this.btnUpdateSaveChanges.Name = "btnUpdateSaveChanges";
            this.btnUpdateSaveChanges.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateSaveChanges.TabIndex = 10;
            this.btnUpdateSaveChanges.Text = "Save Changes";
            this.btnUpdateSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpdateSaveChanges.Click += new System.EventHandler(this.btnUpdateSaveChanges_Click);
            // 
            // cboUpdateCountryName
            // 
            this.cboUpdateCountryName.FormattingEnabled = true;
            this.cboUpdateCountryName.Location = new System.Drawing.Point(190, 169);
            this.cboUpdateCountryName.Name = "cboUpdateCountryName";
            this.cboUpdateCountryName.Size = new System.Drawing.Size(59, 21);
            this.cboUpdateCountryName.TabIndex = 7;
            // 
            // cboUpdateCountryID
            // 
            this.cboUpdateCountryID.FormattingEnabled = true;
            this.cboUpdateCountryID.Location = new System.Drawing.Point(149, 169);
            this.cboUpdateCountryID.Name = "cboUpdateCountryID";
            this.cboUpdateCountryID.Size = new System.Drawing.Size(35, 21);
            this.cboUpdateCountryID.TabIndex = 6;
            // 
            // cboUpdateCreditStatus
            // 
            this.cboUpdateCreditStatus.FormattingEnabled = true;
            this.cboUpdateCreditStatus.Items.AddRange(new object[] {
            "Valid",
            "Invalid"});
            this.cboUpdateCreditStatus.Location = new System.Drawing.Point(149, 226);
            this.cboUpdateCreditStatus.Name = "cboUpdateCreditStatus";
            this.cboUpdateCreditStatus.Size = new System.Drawing.Size(100, 21);
            this.cboUpdateCreditStatus.TabIndex = 9;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(149, 200);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEmail.TabIndex = 8;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(149, 138);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateCity.TabIndex = 5;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(149, 108);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateSuburb.TabIndex = 4;
            // 
            // txtUpdateStreetAddress
            // 
            this.txtUpdateStreetAddress.Location = new System.Drawing.Point(149, 82);
            this.txtUpdateStreetAddress.Name = "txtUpdateStreetAddress";
            this.txtUpdateStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateStreetAddress.TabIndex = 3;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(149, 51);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateFirstName.TabIndex = 2;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(149, 23);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLastName.TabIndex = 1;
            // 
            // lblUpdateCreditStatus
            // 
            this.lblUpdateCreditStatus.AutoSize = true;
            this.lblUpdateCreditStatus.Location = new System.Drawing.Point(37, 232);
            this.lblUpdateCreditStatus.Name = "lblUpdateCreditStatus";
            this.lblUpdateCreditStatus.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateCreditStatus.TabIndex = 15;
            this.lblUpdateCreditStatus.Text = "Credit Status:";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(37, 204);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateEmail.TabIndex = 14;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(39, 172);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateCountry.TabIndex = 13;
            this.lblUpdateCountry.Text = "Country:";
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(39, 141);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(27, 13);
            this.lblUpdateCity.TabIndex = 12;
            this.lblUpdateCity.Text = "City:";
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(37, 109);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(44, 13);
            this.lblUpdateSuburb.TabIndex = 11;
            this.lblUpdateSuburb.Text = "Suburb:";
            // 
            // lblUpdateStreetAddress
            // 
            this.lblUpdateStreetAddress.AutoSize = true;
            this.lblUpdateStreetAddress.Location = new System.Drawing.Point(39, 83);
            this.lblUpdateStreetAddress.Name = "lblUpdateStreetAddress";
            this.lblUpdateStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblUpdateStreetAddress.TabIndex = 10;
            this.lblUpdateStreetAddress.Text = "Street Address:";
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(37, 55);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblUpdateFirstName.TabIndex = 9;
            this.lblUpdateFirstName.Text = "First Name";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(37, 27);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateLastName.TabIndex = 8;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(392, 214);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 7;
            this.txtCountryName.TextChanged += new System.EventHandler(this.txtCountryName_TextChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 444);
            this.Controls.Add(this.pnlUpdateClient);
            this.Controls.Add(this.pnlAddClient);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cboCreditStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCountryID);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lstClient);
            this.Name = "ClientForm";
            this.Text = "Client Maintenance";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.pnlAddClient.ResumeLayout(false);
            this.pnlAddClient.PerformLayout();
            this.pnlUpdateClient.ResumeLayout(false);
            this.pnlUpdateClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountryID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox cboCreditStatus;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Panel pnlAddClient;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.Label lblAddCreditStatus;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Label lblAddStreetAddress;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.ComboBox cboAddCreditStatus;
        private System.Windows.Forms.ComboBox cboAddCountryName;
        private System.Windows.Forms.ComboBox cboAddCountryID;
        private System.Windows.Forms.Button btnAddSaveClient;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Panel pnlUpdateClient;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSaveChanges;
        private System.Windows.Forms.ComboBox cboUpdateCountryName;
        private System.Windows.Forms.ComboBox cboUpdateCountryID;
        private System.Windows.Forms.ComboBox cboUpdateCreditStatus;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateStreetAddress;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label lblUpdateCreditStatus;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateStreetAddress;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.TextBox txtCountryName;
    }
}