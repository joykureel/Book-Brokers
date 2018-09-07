namespace BookBrokers
{
    partial class BookForm
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
            this.lstBookID = new System.Windows.Forms.ListBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.cboAddDatePublished = new System.Windows.Forms.DateTimePicker();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSaveInfo = new System.Windows.Forms.Button();
            this.cboAddVendorName = new System.Windows.Forms.ComboBox();
            this.cboAddVendorID = new System.Windows.Forms.ComboBox();
            this.cboAddBookInfoTitle = new System.Windows.Forms.ComboBox();
            this.cboAddBookInfoID = new System.Windows.Forms.ComboBox();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.lblAddVendor = new System.Windows.Forms.Label();
            this.lblAddDatePublished = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddBookInfo = new System.Windows.Forms.Label();
            this.pnlUpdateBook = new System.Windows.Forms.Panel();
            this.cboUpdateDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateVendorName = new System.Windows.Forms.TextBox();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateCost = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateVendorID = new System.Windows.Forms.TextBox();
            this.txtUpdateBookID = new System.Windows.Forms.TextBox();
            this.lblUpdateVendorName = new System.Windows.Forms.Label();
            this.lblUpdateVendorID = new System.Windows.Forms.Label();
            this.lblUpdateDatePublished = new System.Windows.Forms.Label();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblUpdateCost = new System.Windows.Forms.Label();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUpdateBookID = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSaveChanges = new System.Windows.Forms.Button();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.pnlAddBook.SuspendLayout();
            this.pnlUpdateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBookID
            // 
            this.lstBookID.FormattingEnabled = true;
            this.lstBookID.Location = new System.Drawing.Point(25, 13);
            this.lstBookID.Name = "lstBookID";
            this.lstBookID.Size = new System.Drawing.Size(159, 238);
            this.lstBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(237, 22);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(237, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(237, 84);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(237, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(237, 146);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblDatePublished.TabIndex = 5;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(237, 179);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblVendorID.TabIndex = 6;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(237, 212);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(72, 13);
            this.lblVendorName.TabIndex = 7;
            this.lblVendorName.Text = "VendorName:";
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(237, 238);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(79, 13);
            this.lblClientOrderID.TabIndex = 8;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(328, 19);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(68, 20);
            this.txtBookID.TabIndex = 1;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(328, 176);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(38, 20);
            this.txtVendorID.TabIndex = 6;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Location = new System.Drawing.Point(328, 143);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(68, 20);
            this.txtDatePublished.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(328, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(68, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(328, 81);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(68, 20);
            this.txtCost.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(328, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(248, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(328, 209);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtVendorName.TabIndex = 7;
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(328, 235);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(38, 20);
            this.txtClientOrderID.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 360);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(98, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(513, 404);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 23);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(144, 360);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(513, 360);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteBook.TabIndex = 12;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(391, 360);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateBook.TabIndex = 11;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(267, 360);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(98, 23);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.Controls.Add(this.cboAddDatePublished);
            this.pnlAddBook.Controls.Add(this.btnAddCancel);
            this.pnlAddBook.Controls.Add(this.btnAddSaveInfo);
            this.pnlAddBook.Controls.Add(this.cboAddVendorName);
            this.pnlAddBook.Controls.Add(this.cboAddVendorID);
            this.pnlAddBook.Controls.Add(this.cboAddBookInfoTitle);
            this.pnlAddBook.Controls.Add(this.cboAddBookInfoID);
            this.pnlAddBook.Controls.Add(this.txtAddCost);
            this.pnlAddBook.Controls.Add(this.txtAddPrice);
            this.pnlAddBook.Controls.Add(this.lblAddVendor);
            this.pnlAddBook.Controls.Add(this.lblAddDatePublished);
            this.pnlAddBook.Controls.Add(this.lblAddPrice);
            this.pnlAddBook.Controls.Add(this.lblAddCost);
            this.pnlAddBook.Controls.Add(this.lblAddBookInfo);
            this.pnlAddBook.Location = new System.Drawing.Point(689, 13);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(461, 273);
            this.pnlAddBook.TabIndex = 23;
            this.pnlAddBook.Visible = false;
            this.pnlAddBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddBook_Paint);
            // 
            // cboAddDatePublished
            // 
            this.cboAddDatePublished.Location = new System.Drawing.Point(156, 102);
            this.cboAddDatePublished.Name = "cboAddDatePublished";
            this.cboAddDatePublished.Size = new System.Drawing.Size(114, 20);
            this.cboAddDatePublished.TabIndex = 5;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(342, 208);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(101, 23);
            this.btnAddCancel.TabIndex = 8;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSaveInfo
            // 
            this.btnAddSaveInfo.Location = new System.Drawing.Point(45, 208);
            this.btnAddSaveInfo.Name = "btnAddSaveInfo";
            this.btnAddSaveInfo.Size = new System.Drawing.Size(100, 23);
            this.btnAddSaveInfo.TabIndex = 7;
            this.btnAddSaveInfo.Text = "Save Book";
            this.btnAddSaveInfo.UseVisualStyleBackColor = true;
            this.btnAddSaveInfo.Click += new System.EventHandler(this.btnAddSaveInfo_Click);
            // 
            // cboAddVendorName
            // 
            this.cboAddVendorName.FormattingEnabled = true;
            this.cboAddVendorName.Location = new System.Drawing.Point(229, 141);
            this.cboAddVendorName.Name = "cboAddVendorName";
            this.cboAddVendorName.Size = new System.Drawing.Size(137, 21);
            this.cboAddVendorName.TabIndex = 7;
            // 
            // cboAddVendorID
            // 
            this.cboAddVendorID.FormattingEnabled = true;
            this.cboAddVendorID.Location = new System.Drawing.Point(156, 138);
            this.cboAddVendorID.Name = "cboAddVendorID";
            this.cboAddVendorID.Size = new System.Drawing.Size(52, 21);
            this.cboAddVendorID.TabIndex = 6;
            // 
            // cboAddBookInfoTitle
            // 
            this.cboAddBookInfoTitle.FormattingEnabled = true;
            this.cboAddBookInfoTitle.Location = new System.Drawing.Point(229, 19);
            this.cboAddBookInfoTitle.Name = "cboAddBookInfoTitle";
            this.cboAddBookInfoTitle.Size = new System.Drawing.Size(153, 21);
            this.cboAddBookInfoTitle.TabIndex = 2;
            // 
            // cboAddBookInfoID
            // 
            this.cboAddBookInfoID.FormattingEnabled = true;
            this.cboAddBookInfoID.Location = new System.Drawing.Point(156, 19);
            this.cboAddBookInfoID.Name = "cboAddBookInfoID";
            this.cboAddBookInfoID.Size = new System.Drawing.Size(52, 21);
            this.cboAddBookInfoID.TabIndex = 1;
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(156, 43);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(68, 20);
            this.txtAddCost.TabIndex = 3;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(156, 74);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(68, 20);
            this.txtAddPrice.TabIndex = 4;
            // 
            // lblAddVendor
            // 
            this.lblAddVendor.AutoSize = true;
            this.lblAddVendor.Location = new System.Drawing.Point(42, 141);
            this.lblAddVendor.Name = "lblAddVendor";
            this.lblAddVendor.Size = new System.Drawing.Size(44, 13);
            this.lblAddVendor.TabIndex = 12;
            this.lblAddVendor.Text = "Vendor:";
            // 
            // lblAddDatePublished
            // 
            this.lblAddDatePublished.AutoSize = true;
            this.lblAddDatePublished.Location = new System.Drawing.Point(42, 108);
            this.lblAddDatePublished.Name = "lblAddDatePublished";
            this.lblAddDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblAddDatePublished.TabIndex = 11;
            this.lblAddDatePublished.Text = "Date Published:";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(42, 77);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(34, 13);
            this.lblAddPrice.TabIndex = 10;
            this.lblAddPrice.Text = "Price:";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(42, 46);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(31, 13);
            this.lblAddCost.TabIndex = 9;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddBookInfo
            // 
            this.lblAddBookInfo.AutoSize = true;
            this.lblAddBookInfo.Location = new System.Drawing.Point(42, 19);
            this.lblAddBookInfo.Name = "lblAddBookInfo";
            this.lblAddBookInfo.Size = new System.Drawing.Size(56, 13);
            this.lblAddBookInfo.TabIndex = 7;
            this.lblAddBookInfo.Text = "Book Info:";
            // 
            // pnlUpdateBook
            // 
            this.pnlUpdateBook.Controls.Add(this.cboUpdateDatePublished);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateVendorName);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateCost);
            this.pnlUpdateBook.Controls.Add(this.txtUpdatePrice);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateVendorID);
            this.pnlUpdateBook.Controls.Add(this.txtUpdateBookID);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateVendorName);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateVendorID);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateDatePublished);
            this.pnlUpdateBook.Controls.Add(this.lblUpdatePrice);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateCost);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateBook.Controls.Add(this.lblUpdateBookID);
            this.pnlUpdateBook.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateBook.Controls.Add(this.btnUpdateSaveChanges);
            this.pnlUpdateBook.Location = new System.Drawing.Point(689, 310);
            this.pnlUpdateBook.Name = "pnlUpdateBook";
            this.pnlUpdateBook.Size = new System.Drawing.Size(461, 311);
            this.pnlUpdateBook.TabIndex = 24;
            this.pnlUpdateBook.Visible = false;
            this.pnlUpdateBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdateBook_Paint);
            // 
            // cboUpdateDatePublished
            // 
            this.cboUpdateDatePublished.Location = new System.Drawing.Point(140, 147);
            this.cboUpdateDatePublished.Name = "cboUpdateDatePublished";
            this.cboUpdateDatePublished.Size = new System.Drawing.Size(130, 20);
            this.cboUpdateDatePublished.TabIndex = 5;
            // 
            // txtUpdateVendorName
            // 
            this.txtUpdateVendorName.Location = new System.Drawing.Point(140, 218);
            this.txtUpdateVendorName.Name = "txtUpdateVendorName";
            this.txtUpdateVendorName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateVendorName.TabIndex = 7;
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(140, 57);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(248, 20);
            this.txtUpdateTitle.TabIndex = 2;
            // 
            // txtUpdateCost
            // 
            this.txtUpdateCost.Location = new System.Drawing.Point(140, 90);
            this.txtUpdateCost.Name = "txtUpdateCost";
            this.txtUpdateCost.Size = new System.Drawing.Size(68, 20);
            this.txtUpdateCost.TabIndex = 3;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(140, 121);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(68, 20);
            this.txtUpdatePrice.TabIndex = 4;
            // 
            // txtUpdateVendorID
            // 
            this.txtUpdateVendorID.Location = new System.Drawing.Point(140, 185);
            this.txtUpdateVendorID.Name = "txtUpdateVendorID";
            this.txtUpdateVendorID.Size = new System.Drawing.Size(38, 20);
            this.txtUpdateVendorID.TabIndex = 6;
            // 
            // txtUpdateBookID
            // 
            this.txtUpdateBookID.Location = new System.Drawing.Point(140, 28);
            this.txtUpdateBookID.Name = "txtUpdateBookID";
            this.txtUpdateBookID.Size = new System.Drawing.Size(68, 20);
            this.txtUpdateBookID.TabIndex = 1;
            // 
            // lblUpdateVendorName
            // 
            this.lblUpdateVendorName.AutoSize = true;
            this.lblUpdateVendorName.Location = new System.Drawing.Point(49, 221);
            this.lblUpdateVendorName.Name = "lblUpdateVendorName";
            this.lblUpdateVendorName.Size = new System.Drawing.Size(72, 13);
            this.lblUpdateVendorName.TabIndex = 31;
            this.lblUpdateVendorName.Text = "VendorName:";
            // 
            // lblUpdateVendorID
            // 
            this.lblUpdateVendorID.AutoSize = true;
            this.lblUpdateVendorID.Location = new System.Drawing.Point(49, 188);
            this.lblUpdateVendorID.Name = "lblUpdateVendorID";
            this.lblUpdateVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateVendorID.TabIndex = 30;
            this.lblUpdateVendorID.Text = "Vendor ID:";
            // 
            // lblUpdateDatePublished
            // 
            this.lblUpdateDatePublished.AutoSize = true;
            this.lblUpdateDatePublished.Location = new System.Drawing.Point(49, 155);
            this.lblUpdateDatePublished.Name = "lblUpdateDatePublished";
            this.lblUpdateDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblUpdateDatePublished.TabIndex = 29;
            this.lblUpdateDatePublished.Text = "Date Published:";
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(49, 124);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(34, 13);
            this.lblUpdatePrice.TabIndex = 28;
            this.lblUpdatePrice.Text = "Price:";
            // 
            // lblUpdateCost
            // 
            this.lblUpdateCost.AutoSize = true;
            this.lblUpdateCost.Location = new System.Drawing.Point(49, 93);
            this.lblUpdateCost.Name = "lblUpdateCost";
            this.lblUpdateCost.Size = new System.Drawing.Size(31, 13);
            this.lblUpdateCost.TabIndex = 27;
            this.lblUpdateCost.Text = "Cost:";
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(49, 60);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdateTitle.TabIndex = 26;
            this.lblUpdateTitle.Text = "Title:";
            // 
            // lblUpdateBookID
            // 
            this.lblUpdateBookID.AutoSize = true;
            this.lblUpdateBookID.Location = new System.Drawing.Point(49, 31);
            this.lblUpdateBookID.Name = "lblUpdateBookID";
            this.lblUpdateBookID.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateBookID.TabIndex = 25;
            this.lblUpdateBookID.Text = "Book ID:";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(342, 267);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(101, 23);
            this.btnUpdateCancel.TabIndex = 9;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSaveChanges
            // 
            this.btnUpdateSaveChanges.Location = new System.Drawing.Point(45, 267);
            this.btnUpdateSaveChanges.Name = "btnUpdateSaveChanges";
            this.btnUpdateSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateSaveChanges.TabIndex = 8;
            this.btnUpdateSaveChanges.Text = "Save Changes";
            this.btnUpdateSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpdateSaveChanges.Click += new System.EventHandler(this.btnUpdateSaveChanges_Click);
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(422, 19);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(30, 20);
            this.txtBookInfoID.TabIndex = 25;
            this.txtBookInfoID.Visible = false;
            this.txtBookInfoID.TextChanged += new System.EventHandler(this.txtBookInfoID_TextChanged);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 463);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.pnlUpdateBook);
            this.Controls.Add(this.pnlAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDatePublished);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lstBookID);
            this.Name = "BookForm";
            this.Text = "Book Maintenance";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            this.pnlUpdateBook.ResumeLayout(false);
            this.pnlUpdateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtDatePublished;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSaveInfo;
        private System.Windows.Forms.ComboBox cboAddVendorName;
        private System.Windows.Forms.ComboBox cboAddVendorID;
        private System.Windows.Forms.ComboBox cboAddBookInfoTitle;
        private System.Windows.Forms.ComboBox cboAddBookInfoID;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.Label lblAddVendor;
        private System.Windows.Forms.Label lblAddDatePublished;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddBookInfo;
        private System.Windows.Forms.Panel pnlUpdateBook;
        private System.Windows.Forms.TextBox txtUpdateVendorName;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateCost;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateVendorID;
        private System.Windows.Forms.TextBox txtUpdateBookID;
        private System.Windows.Forms.Label lblUpdateVendorName;
        private System.Windows.Forms.Label lblUpdateVendorID;
        private System.Windows.Forms.Label lblUpdateDatePublished;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblUpdateCost;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUpdateBookID;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSaveChanges;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.DateTimePicker cboAddDatePublished;
        private System.Windows.Forms.DateTimePicker cboUpdateDatePublished;
    }
}